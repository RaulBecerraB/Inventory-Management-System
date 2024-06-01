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
    }
}
