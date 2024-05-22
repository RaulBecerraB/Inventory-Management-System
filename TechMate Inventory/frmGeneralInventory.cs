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
    public partial class frmGeneralInventory : Form
    {
        private string connectionString;
        public frmGeneralInventory(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmGeneralInventory_Load(object sender, EventArgs e)
        {
            LoadInventoryView();
            LoadNewMovementForm();
        }

        public void LoadNewMovementForm()
        {
            usrCtrlNewMovement newMovementControl = new usrCtrlNewMovement(this, connectionString); // Ajusta el constructor según sea necesario
            newMovementControl.Dock = DockStyle.Fill; // Opcional: Ajusta el control para llenar el panel
            scInventoryMove.Panel2.Controls.Clear(); // Opcional: Limpia los controles existentes en el panel
            scInventoryMove.Panel2.Controls.Add(newMovementControl); // Agrega el UserControl al panel
        }
        public void LoadInventoryView()
        {
            string query = @"
        SELECT m.shortDescription, 
               ISNULL(SUM(mov.quantity), 0) AS TotalQuantity
        FROM Materials m
        LEFT JOIN Movements mov ON m.ID_Material = mov.ID_Material
        GROUP BY m.shortDescription";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    vwInventoryGridView.DataSource = Program.GetDataTable(query,connection);
                    vwInventoryGridView.Columns["shortDescription"].HeaderText = "Material";
                    vwInventoryGridView.Columns["TotalQuantity"].HeaderText = "Cantidad";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR cargando el Stock: " + ex.Message);
                }
            }
        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadInventoryView();
        }

        private void vwInventoryGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Reemplaza "ColumnName" con el nombre de la columna que deseas evaluar
            string columnName = "TotalQuantity";

            // Verifica si la celda actual pertenece a la columna que deseas cambiar
            if (vwInventoryGridView.Columns[e.ColumnIndex].Name == columnName)
            {
                // Intenta obtener el valor de la celda como un número
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int cellValue))
                {
                    // Cambia el color de fondo a rojo si el valor es menor a 0
                    if (isNegative(cellValue))
                    {
                        changeCellTextColor(e,Color.Red);
                        e.Value = cellValue + " *"; // Concatenar un asterisco al valor
                    }
                    else
                    {
                        changeCellTextColor(e,Color.Black); // Restablece el color si no es menor a 0
                        e.Value = cellValue; // Asegura que el valor se muestre correctamente si no se cumple la condición
                    }
                }
            }
        }

        private void changeCellTextColor(DataGridViewCellFormattingEventArgs celda, Color color)
        {
            celda.CellStyle.ForeColor = color;
        }
        private bool isNegative(int cellValue)
        {
            if (cellValue < 0)
            {
                return true;
            }

            return false;
        }
    }
}
