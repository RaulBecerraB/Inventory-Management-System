using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    public partial class frmAddCatpopup : Form
    {

        private frmMatCatalogue catalogueParent;
        public string connectionString;
        public frmAddCatpopup(frmMatCatalogue catalogue, string connectionString)
        {
            InitializeComponent();
            this.catalogueParent = catalogue;
            this.connectionString = connectionString;

        }

        private void frmAddCatpopup_Load(object sender, EventArgs e)
        {

        }

        private void addCategoryInTextBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
                try
                {
                    connection.Open();

                    String queryINSERT = @"INSERT INTO Categories (ID_Category,Name) 
                                           VALUES (@newMatID,@newCatName);
";
                    using (SqlCommand cmd = new SqlCommand(queryINSERT,connection))
                    {
                        //Obtener valores desde el FrontEnd
                        int newID = GetNextMaterialId();
                        string newCatName = textBoxNewCat.Text;

                        //Añadir parámetros al comando
                        cmd.Parameters.AddWithValue("@newMatID" , newID);
                        cmd.Parameters.AddWithValue("@newCatName", newCatName);
                        cmd.ExecuteNonQuery();
                    }
                    if (catalogueParent != null)
                    {
                        catalogueParent.LoadLowerTables();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            addCategoryInTextBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetNextMaterialId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(ID_Category) FROM Categories";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    return 1; // Devuelve 1 si la tabla está vacía
                }
            }
        }

    }
}
