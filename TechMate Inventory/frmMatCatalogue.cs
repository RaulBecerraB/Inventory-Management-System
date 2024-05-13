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
using System.Configuration;
using TechMate_Inventory.TechMateInventoryDataSetTableAdapters;


namespace TechMate_Inventory
{
    public partial class frmMatCatalogue : Form
    {
        public int selectedIndex = 0;
        public frmMatCatalogue()
        {
            InitializeComponent();
        }

        private void frmMatCatalogue_Load(object sender, EventArgs e)
        {

            try
            {
                // Carga datos en la tabla 'techMateInventoryDataSet.vwMaterialCatalogue'
                this.vwMaterialCatalogueTableAdapter.Fill(this.techMateInventoryDataSet.vwMaterialCatalogue);
                this.vwMaterialCatalogueTableAdapter.Fill(this.techMateInventoryDataSet.vwMaterialCatalogue);

                // Llama a la función para cargar datos desde la vista
                LoadDataFromView();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error al usuario con información sobre la excepción
                MessageBox.Show("Error al cargar el catálogo de materiales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Puedes registrar el error si es necesario
                // LogException(ex); // Si tienes un mecanismo de registro de errores

                // Puedes realizar acciones adicionales para manejar el error, como detener el proceso o limpiar recursos
            }

        }

        public void LoadDataFromView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TechMate_Inventory.Properties.Settings.TechMateInventoryConnectionString"].ConnectionString;
            //MessageBox.Show(connectionString);
            string query = "-- Query para checar Materials\r\nSELECT \r\n    Materials.ID_Material,  -- ID del material\r\n\tMaterials.shortDescription,\r\n    Categories.Name AS Category,  -- Nombre de la categoría\r\n    MatTypes.Name AS MaterialType,  -- Nombre del tipo de material\r\n    MatUnits.Name AS UnitName,  -- Nombre de la unidad\r\n    Materials.BorrowLimitDays  -- Límite de días de préstamo\r\nFROM \r\n    Materials  -- Tabla principal\r\nLEFT JOIN \r\n    MatTypes \r\n    ON Materials.ID_MatType = MatTypes.ID_MatType  -- Unir con MatTypes por el tipo de material\r\nLEFT JOIN \r\n    Categories\r\n    ON MatTypes.ID_Category = Categories.ID_Category  -- Unir con Categories por la categoría del MatType\r\nLEFT JOIN \r\n    MatUnits \r\n    ON Materials.ID_Unit = MatUnits.ID_Unit  -- Unir con MatUnits por la unidad\r\n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();          

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    vwMatCatGridView.DataSource = table;

                    // Opcionalmente configurar las cabeceras si es necesario

                    vwMatCatGridView.Columns["ID_Material"].HeaderText = "Índice";
                    vwMatCatGridView.Columns["shortDescription"].HeaderText = "Descripción corta";
                    vwMatCatGridView.Columns["Category"].HeaderText = "Categoría";
                    vwMatCatGridView.Columns["MaterialType"].HeaderText = "Tipo";
                    vwMatCatGridView.Columns["UnitName"].HeaderText = "Unidad";
                    vwMatCatGridView.Columns["BorrowLimitDays"].HeaderText = "Días máximos de préstamo";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void catMatTitle_Click(object sender, EventArgs e)
        {

        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            frmAddMatpopup addMatpopup = new frmAddMatpopup(this);
            addMatpopup.Show();
        }

        private void vwMatCatGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comprueba si el doble clic fue sobre una fila (y no en el área de encabezado)
            if (e.RowIndex >= 0)
            {
                // Aquí puedes acceder a la fila en la que se hizo doble clic
                DataGridViewRow clickedRow = vwMatCatGridView.Rows[e.RowIndex];

                Material_CRUD_PopUp1 editPopup = new Material_CRUD_PopUp1(this);
                editPopup.intMaterialId = (int)clickedRow.Cells["ID_Material"].Value;
                editPopup.Show();

                // Por ejemplo, mostrar información de la fila
                //MessageBox.Show($"Doble clic en la fila con ID: {clickedRow.Cells["ID_Material"].Value.ToString()}");
                //selectedIndex = clickedRow.Cells["ID_Material"].Value;
            }
        }
    }
}
