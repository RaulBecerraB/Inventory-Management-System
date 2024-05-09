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
            // TODO: esta línea de código carga datos en la tabla 'techMateInventoryDataSet.vwMaterialCatalogue' Puede moverla o quitarla según sea necesario.
            this.vwMaterialCatalogueTableAdapter.Fill(this.techMateInventoryDataSet.vwMaterialCatalogue);
            // TODO: esta línea de código carga datos en la tabla 'techMateInventoryDataSet.vwMaterialCatalogue' Puede moverla o quitarla según sea necesario.
            this.vwMaterialCatalogueTableAdapter.Fill(this.techMateInventoryDataSet.vwMaterialCatalogue);
            LoadDataFromView();

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
            frmAddMatpopup addMatpopup = new frmAddMatpopup();
            addMatpopup.Show();
        }
    }
}
