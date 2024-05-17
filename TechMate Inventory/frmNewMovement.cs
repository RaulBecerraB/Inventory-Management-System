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

namespace TechMate_Inventory
{
    public partial class frmNewMovement : Form
    {
        private frmKardex parentForm;

        private string connectionString;
        public frmNewMovement(frmKardex parentForm,string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.parentForm = parentForm;
        }

        private void frmNewMovement_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void LoadDataIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //MessageBox.Show(connectionString);

                    //Fill comboBoxes
                    FillComboBoxWithQuery(comboBoxMatDesc, "Materials", "ID_Material", "shortDescription", connection);
                    FillComboBoxWithQuery(comboBoxMoveTypes, "MoveTypes", "ID_MoveType", "Name", connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
        }

        private void FillComboBoxWithQuery(ComboBox comboBox ,string table,string id,string attribute, SqlConnection connection)
        {
            string query = $"SELECT {id} , {attribute} FROM {table}";

            DataTable dataTable = GetDataTable(query,connection);

            comboBox.DataSource = dataTable; // Asignar dataTable como DataSource
            comboBox.DisplayMember = attribute;  // Columna para mostrar en el ComboBox.
            comboBox.ValueMember = id;  // Columna como valor que representa los items.
        }

        private DataTable GetDataTable(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int materialId = (int)comboBoxMatDesc.SelectedValue;
            int moveTypeId = (int)comboBoxMoveTypes.SelectedValue;
            int quantity = int.Parse(textBoxQuantity.Text);
            string comment = richTextBoxCommentary.Text;

            //Validar quantity
            bool isQuantityValid = int.TryParse(textBoxQuantity.Text, out quantity);
            if (!isQuantityValid)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Movements (ID_MoveType, ID_Material, ID_User, movDate, comment, quantity) VALUES (@ID_MoveType, @ID_Material, @ID_User, GETDATE(), @Comment, @Quantity)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar valores a los parámetros
                        command.Parameters.AddWithValue("@ID_MoveType", moveTypeId);
                        command.Parameters.AddWithValue("@ID_Material", materialId);
                        command.Parameters.AddWithValue("@ID_User", 1);
                        command.Parameters.AddWithValue("@Comment", comment);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        // Ejecutar la consulta de inserción
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("INSERT failed: " + ex.Message);
                }

                if(parentForm != null)
                {
                    parentForm.LoadKardexView();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetNextId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(ID_Movement FROM Movements";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    return 1; // Devuelve 1 si la tabla está vacía
                }
            }
        }
    }

}

