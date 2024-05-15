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
    public partial class frmEditUnitPopUp : Form
    {

        frmMatCatalogue catalogueParent;
        string connectionString;
        public int intUnitId;
        public frmEditUnitPopUp(frmMatCatalogue catalogueParent, string connectionString)
        {
            InitializeComponent();
            this.catalogueParent = catalogueParent;
            this.connectionString = connectionString;
        }

        private void frmEditUnitPopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = @"
                    UPDATE MatUnits   
                    SET Name = @Name
                    WHERE ID_Unit = @UnitID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Suponemos que tienes controles para capturar estos valores, ajusta los nombres de los controles según corresponda
                        string name = textBoxEditUnit.Text; // Asume que hay un TextBox txtName para el nombre del tipo de material

                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@UnitID", intUnitId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Unit updated successfully!");
                    }

                    // Si el formulario padre está configurado, actualízalo
                    if (catalogueParent != null)
                    {
                        catalogueParent.LoadDataFromView();
                        catalogueParent.LoadLowerTables();
                    }
                    this.Close(); // Opcionalmente cierra este formulario
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to UPDATE Unit: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
