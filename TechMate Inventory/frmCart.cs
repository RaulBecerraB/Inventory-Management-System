using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechMate_Inventory
{
    public partial class frmCart : Form
    {
        private string connectionString;
        public frmStore parentStore;
        public int actualID;

        public frmCart(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                FillStudentsComboBox(connection);
            }

            LoadCartData(comboBoxStudents.SelectedValue.ToString());
                
        }

        public void LoadCartData(string selectedStudent)
        {
            string query = @"
                SELECT 
                    S.name AS StudentName,
                    M.shortDescription,
                    U.Name AS UserName,
                    C.quantity
                FROM 
                    Carts C
                JOIN 
                    Materials M ON C.ID_Material = M.ID_Material
                JOIN 
                    Users U ON C.ID_User = U.ID_User
                JOIN 
                    Students S ON C.Matricula = S.Matricula
                WHERE 
                    C.Matricula = @selectedStudent";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedStudent", selectedStudent);
                    vwCartGridView.DataSource = Program.GetDataTable(command);

                    vwCartGridView.Columns["StudentName"].HeaderText = "Estudiante";
                    vwCartGridView.Columns["shortDescription"].HeaderText = "Material";
                    vwCartGridView.Columns["UserName"].HeaderText = "Usuario";
                    vwCartGridView.Columns["quantity"].HeaderText = "Cantidad";
                }
            }
        }

        private void FillStudentsComboBox(SqlConnection connection)
        {
            try
            {
                connection.Open();

                Program.FillComboBoxWithQuery(comboBoxStudents, "Students", "Matricula", "name", "last_name", connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR cargando a alumnos: " + ex.Message);
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue != null)
            {
                parentStore.selectedStudent = comboBoxStudents.SelectedValue.ToString();
                parentStore.UpdateLabel2();

                LoadCartData(parentStore.selectedStudent);
            }
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres hacer eso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteStudentCart();
            }
            
        }

        private void DeleteStudentCart()
        {
            string query = @"DELETE FROM Carts WHERE Matricula = @selectedStudent";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedStudent", parentStore.selectedStudent);
                    vwCartGridView.DataSource = Program.GetDataTable(command);
                }
            }
        }

        private void CreateBorrowingBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parentStore.selectedStudent))
            {
                MessageBox.Show("No se ha seleccionado un estudiante.");
                return;
            }
            if (MessageBox.Show("¿Confirmar préstamo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TransferCartToMovements();
                TransferCartToBorrowings();
                DeleteStudentCart();

                parentStore.RefreshStoreView();

                MessageBox.Show("Prestamo realizado a " + parentStore.selectedStudent, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TransferCartToMovements()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID_Material, ID_User, quantity FROM Carts WHERE Matricula = @selectedStudent";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@selectedStudent", parentStore.selectedStudent);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        List<(int idMaterial, int idUser, int quantity)> cartItems = new List<(int, int, int)>();

                        while (reader.Read())
                        {
                            int idMaterial = reader.GetInt32(0);
                            int idUser = reader.GetInt32(1);
                            int quantity = reader.GetInt32(2);

                            cartItems.Add((idMaterial, idUser, quantity));
                        }

                        reader.Close(); // Cerrar el reader antes de ejecutar otro comando

                        foreach (var item in cartItems)
                        {
                            // Llamar a InsertMovement con la cantidad negativa
                            InsertMovement(connection, item.idMaterial, item.idUser, -item.quantity);
                        }
                    }
                }
            }
        }

        private void TransferCartToBorrowings()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = @"
                    SELECT C.ID_Material, C.ID_User, C.quantity, M.BorrowLimitDays 
                    FROM Carts C 
                    JOIN Materials M ON C.ID_Material = M.ID_Material 
                    WHERE C.Matricula = @selectedUser";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@selectedUser", parentStore.selectedStudent);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        List<(int idMaterial, int idUser, int quantity, int borrowLimitDays)> cartItems = new List<(int, int, int, int)>();

                        while (reader.Read())
                        {
                            int idMaterial = reader.GetInt32(0);
                            int idUser = reader.GetInt32(1);
                            int quantity = reader.GetInt32(2);
                            int borrowLimitDays = reader.GetInt32(3);

                            cartItems.Add((idMaterial, idUser, quantity, borrowLimitDays));
                        }

                        reader.Close(); // Cerrar el reader antes de ejecutar otro comando

                        foreach (var item in cartItems)
                        {
                            // Llamar a InsertBorrowing con la cantidad positiva y calcular return_date
                            InsertBorrowing(connection, item.idMaterial, item.idUser, parentStore.selectedStudent, item.quantity, item.borrowLimitDays);
                        }
                    }
                }
            }
        }
        private void InsertMovement(SqlConnection connection, int idMaterial, int idUser, int quantity)
        {
            string insertQuery = @"
                INSERT INTO Movements (ID_MoveType, ID_Material, ID_User, movDate, comment, quantity)
                VALUES (@moveType, @idMaterial, @idUser, GETDATE(), NULL, @quantity)";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@moveType", 2);
                insertCommand.Parameters.AddWithValue("@idMaterial", idMaterial);
                insertCommand.Parameters.AddWithValue("@idUser", idUser);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);

                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Movimiento creado");
            }
        }

        private void InsertBorrowing(SqlConnection connection, int idMaterial, int idUser, string matricula, int quantity, int borrowLimitDays)
        {
            string insertQuery = @"
        INSERT INTO Borrowings (ID_Material, ID_User, Matricula, quantity, return_date)
        VALUES (@idMaterial, @idUser, @matricula, @quantity, DATEADD(DD,@borrowLimitDays,GETDATE()))";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@idMaterial", idMaterial);
                insertCommand.Parameters.AddWithValue("@idUser", idUser);
                insertCommand.Parameters.AddWithValue("@matricula", matricula);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);
                insertCommand.Parameters.AddWithValue("@borrowLimitDays", borrowLimitDays);

                insertCommand.ExecuteNonQuery();
            }

            Console.WriteLine("Borrowing creado");
        }

    }
}
