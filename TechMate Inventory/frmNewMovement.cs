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
        private Form parentForm;

        private string connectionString;
        public frmNewMovement(Form parentForm,string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.parentForm = parentForm;

            // Verificar el tipo del formulario padre
            if (parentForm is frmKardex)
            {
                // Lógica específica para frmKardex
                frmKardex kardexForm = (frmKardex)parentForm;
                // Usa kardexForm según sea necesario
            }
            else if (parentForm is frmGeneralInventory)
            {
                // Lógica específica para frmOtherForm
                frmGeneralInventory Inventory = (frmGeneralInventory)parentForm;
                // Usa otherForm según sea necesario
            }
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
                    Program.FillComboBoxWithQuery(comboBoxMatDesc, "Materials", "ID_Material", "shortDescription", connection);
                    Program.FillComboBoxWithQuery(comboBoxMoveTypes, "MoveTypes", "ID_MoveType", "Name", connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
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

                if(parentForm != null && parentForm is frmKardex kardexForm)
                {
                    kardexForm.LoadKardexView();
                }
                else if (parentForm != null && parentForm is frmGeneralInventory inventoryForm)
                {
                    inventoryForm.LoadInventoryView();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

