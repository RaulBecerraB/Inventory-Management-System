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
            string query = "SELECT * FROM vwMaterialCatalogue";
            

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

                // Por ejemplo, mostrar información de la fila
                MessageBox.Show($"Doble clic en la fila con ID: {clickedRow.Cells["ID_Material"].Value.ToString()}");
            }
        }
    }
}
