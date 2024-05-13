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
    public partial class frmAddUnitPopUp : Form
    {
        public string connectionString;
        private frmMatCatalogue catalogueParent;
        public frmAddUnitPopUp(frmMatCatalogue parent, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.catalogueParent = parent;

        }

        private void frmAddUnitPopUp_Load(object sender, EventArgs e)
        {
            //Used this to solve line break problem
            label6.Text = "Ingrese la nueva unidad\nde medida";
        }

        private void addUnitInTextBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
                try
                {
                    connection.Open();

                    String queryINSERT = @"INSERT INTO MatUnits (ID_Unit,Name) 
                                           VALUES (@newUnitID,@newUnitName)";
                    using (SqlCommand cmd = new SqlCommand(queryINSERT, connection))
                    {
                        //Obtener valores desde el FrontEnd
                        int newID = GetNextMaterialId();
                        string newUnitName = textBoxNewUnit.Text;

                        //Añadir parámetros al comando
                        cmd.Parameters.AddWithValue("@newUnitID", newID);
                        cmd.Parameters.AddWithValue("@newUnitName", newUnitName);
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

        private int GetNextMaterialId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(ID_Unit) FROM MatUnits";
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            addUnitInTextBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
