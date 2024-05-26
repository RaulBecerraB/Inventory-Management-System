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
        private frmGeneralInventory parentForm;
        public int intMatId;
        public DataGridView vw;
        private string connectionString;
        public usrCtrlNewMovement(frmGeneralInventory parentForm, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.parentForm = parentForm;
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
                    //Program.FillComboBoxWithQuery(comboBoxMatDesc, "Materials", "ID_Material", "shortDescription", connection);
                    
                    Program.FillComboBoxWithQuery(comboBoxMoveTypes, "MoveTypes", "ID_MoveType", "Name", connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
        }

        public void SetLabelTextById(int id, DataGridView vw, string idName, string columnToShow)
        {
            foreach (DataGridViewRow row in vw.Rows)
            {
                if (row.Cells[idName].Value != null && (int)row.Cells[idName].Value == id)
                {
                    labelSelectedMaterial.Text = row.Cells[columnToShow].Value.ToString();
                    break;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //int materialId = intMatId;
            int materialId = intMatId;
            int moveTypeId = (int)comboBoxMoveTypes.SelectedValue;
            string comment = richTextBoxCommentary.Text;

            if (materialId == 0)
            {
                MessageBox.Show("Primero seleccione un material");
                return;
            }
            // Validar cantidad
            if (!int.TryParse(textBoxQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            if (comboBoxMoveTypes.Text == "ADJ")
            {
                MessageBox.Show("ADJ no ha sido implementado, seleccione otro tipo de movimiento");
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
                        command.Parameters.AddWithValue("@ID_User", parentForm.userId); // Asignar un valor de ID_User apropiado
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
                        parentForm.LoadInventoryView();     
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

        private void usrCtrlNewMovement_MouseMove(object sender, MouseEventArgs e)
        {
            //SetLabelTextById(intMatId, vw);
        }
    }
}
