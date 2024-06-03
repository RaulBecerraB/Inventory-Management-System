using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TechMate_Inventory
{
    public partial class frmGeneralInventory : Form
    {
        private string connectionString;
        private usrCtrlNewMovement newMovementControl;
        public int userId;
        private DataTable originalDataTable;
        private int clickedMatId;
        
        public frmGeneralInventory(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        // Propiedad pública para acceder al DataGridView
        public DataGridView vwInventory
        {
            get { return vwInventoryGridView; }
        }

        private void frmGeneralInventory_Load(object sender, EventArgs e)
        {
            newMovementControl = new usrCtrlNewMovement(this,connectionString);
            LoadInventoryView(vwInventoryGridView);
            LoadNewMovementForm();

        }

        public void LoadInventoryView()
        {
            LoadInventoryView(vwInventoryGridView);
        }

        public void LoadNewMovementForm()
        {
            newMovementControl.vw = vwInventoryGridView;
            newMovementControl.Dock = DockStyle.Fill; // Opcional: Ajusta el control para llenar el panel
            scInventoryMove.Panel2.Controls.Clear(); // Opcional: Limpia los controles existentes en el panel
            scInventoryMove.Panel2.Controls.Add(newMovementControl); // Agrega el UserControl al panel
        }
        public void LoadInventoryView(DataGridView gridView)
        {
            string query = @"
SELECT 
    m.ID_Material,
    m.shortDescription, 
    m.Description,
    ISNULL(SUM(mov.quantity), 0) AS TotalQuantity,
    u.Name AS UnitName
FROM 
    Materials m
LEFT JOIN 
    Movements mov ON m.ID_Material = mov.ID_Material
LEFT JOIN
    MatUnits u ON m.ID_Unit = u.ID_Unit
GROUP BY 
    m.ID_Material, 
    m.shortDescription, 
    m.Description,
    u.Name";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    gridView.DataSource = Program.GetDataTable(query,connection);
                    originalDataTable = Program.GetDataTable(query,connection); 

                    gridView.Columns["ID_Material"].Visible = false;
                    gridView.Columns["Description"].Visible = false;
                    gridView.Columns["shortDescription"].HeaderText = "Material";
                    gridView.Columns["TotalQuantity"].HeaderText = "En existencia";
                    gridView.Columns["UnitName"].HeaderText = "Unidad de medida";

                    // Establece explícitamente el ancho de la columna después de añadirla
                    //gridView.Columns["shortDescription"].Width = 800;

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
            LoadInventoryView(vwInventoryGridView);
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

        public static void changeCellTextColor(DataGridViewCellFormattingEventArgs celda, Color color)
        {
            celda.CellStyle.ForeColor = color;
        }
        public static bool isNegative(int cellValue)
        {
            if (cellValue < 0)
            {
                return true;
            }

            return false;
        }

        private void vwInventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGridViewRows.isSelectedRowAHeader(e))
            {
                newMovementControl.intMatId = DGridViewRows.ReturnSelectedRowID(e, "ID_Material", vwInventoryGridView);
                DGridViewUtils.SetLabelTextById(newMovementControl.intMatId, vwInventoryGridView, "ID_Material", "shortDescription",newMovementControl.labelSelectedMat);
                clickedMatId = DGridViewRows.ReturnSelectedRowID(e, "ID_Material", vwInventory);
                DGridViewUtils.SetRichTextBoxTextById(clickedMatId, vwInventory, "ID_Material", "Description", DescriptionTextBox);
            }

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string filterText = SearchBar.Text.ToLower();
            if (originalDataTable != null)
            {
                DataView dv = originalDataTable.DefaultView;
                dv.RowFilter = $"shortDescription LIKE '%{filterText}%'"; // Ajusta los nombres de las columnas según sea necesario
                vwInventoryGridView.DataSource = dv;
            }
        }
    }
}
