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
        }
        public void LoadInventoryView()
        {
            string query = @"
        SELECT m.shortDescription, 
               ISNULL(SUM(mov.quantity), 0) AS TotalQuantity
        FROM Materials m
        LEFT JOIN Movements mov ON m.ID_Material = mov.ID_Material
        GROUP BY m.shortDescription;";

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
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            frmNewMovement frmNewMovement = new frmNewMovement(this, connectionString);
            frmNewMovement.Show();
        }
    }
}
