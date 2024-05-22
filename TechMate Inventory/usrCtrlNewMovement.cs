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
    public partial class usrCtrlNewMovement : UserControl
    {
        private Form parentForm;

        private string connectionString;
        public usrCtrlNewMovement(Form parentForm, string connectionString)
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

        private void usrCtrlNewMovement_Load(object sender, EventArgs e)
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
            string comment = richTextBoxCommentary.Text;

            // Validar cantidad
            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Verificar si el movimiento es "OUT" y hacer negativa la cantidad
            if (comboBoxMoveTypes.Text == "OUT")
            {
                quantity = -quantity;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Movements (ID_MoveType, ID_Material, ID_User, movDate, comment, quantity) 
                             VALUES (@ID_MoveType, @ID_Material, @ID_User, GETDATE(), @Comment, @Quantity)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar valores a los parámetros
                        command.Parameters.AddWithValue("@ID_MoveType", moveTypeId);
                        command.Parameters.AddWithValue("@ID_Material", materialId);
                        command.Parameters.AddWithValue("@ID_User", 1); // Asignar un valor de ID_User apropiado
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

                // Verificar el tipo de formulario padre y actualizar la vista correspondiente
                if (parentForm != null)
                {
                    if (parentForm is frmKardex kardexForm)
                    {
                        kardexForm.LoadKardexView();
                    }
                    else if (parentForm is frmGeneralInventory inventoryForm)
                    {
                        inventoryForm.LoadInventoryView();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número, punto decimal o un carácter de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
