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
    public partial class frmEditCategoryPopUp : Form
    {
        frmMatCatalogue catalogueParent;
        public int intCategoryId;
        string connectionString;
        public frmEditCategoryPopUp(frmMatCatalogue parent,string connectionString)
        {
            InitializeComponent();
            this.catalogueParent = parent;
            this.connectionString = connectionString;
        }

        private void frmEditCategoryPopUp_Load(object sender, EventArgs e)
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
                UPDATE Categories   
                SET Name = @Name
                WHERE ID_Category = @CategoryID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Suponemos que tienes controles para capturar estos valores, ajusta los nombres de los controles según corresponda
                        string name = textBoxEditCategory.Text; // Asume que hay un TextBox txtName para el nombre del tipo de material

                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@CategoryID", intCategoryId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Type updated successfully!");
                    }

                    // Si el formulario padre está configurado, actualízalo
                    if (catalogueParent != null)
                    {
                        catalogueParent.LoadLowerTables();
                    }
                    this.Close(); // Opcionalmente cierra este formulario
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to UPDATE Type: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
