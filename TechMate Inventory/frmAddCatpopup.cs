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

                    string queryINSERT = @"INSERT INTO Categories (Name) 
                                           VALUES (@newCatName);
";
                    using (SqlCommand cmd = new SqlCommand(queryINSERT,connection))
                    {
                        //Obtener valores desde el FrontEnd
                        string newCatName = textBoxNewCat.Text;

                        //Añadir parámetros al comando
                        cmd.Parameters.AddWithValue("@newCatName", newCatName);
                    }
                }
                catch (Exception ex)
                {

                }

        }
    }
}
