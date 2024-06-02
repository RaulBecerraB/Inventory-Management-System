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
    public partial class frmKardex : Form
    {
        private string connectionString;
        private DataTable originalDataTable;
        public frmKardex(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmKardex_Load(object sender, EventArgs e)
        {
            LoadKardexView();
        }

        public void LoadKardexView()
        {
            string query = @"SELECT 
                                m.ID_Movement, 
                                mat.shortDescription, 
                                u.Name AS UserName, 
                                mt.Name AS MoveTypeName, 
                                m.quantity, 
                                m.movDate
                             FROM 
                                Movements m
                             JOIN 
                                Materials mat ON m.ID_Material = mat.ID_Material
                             JOIN 
                                Users u ON m.ID_User = u.ID_User
                             JOIN 
                                MoveTypes mt ON m.ID_MoveType = mt.ID_MoveType;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {  
                    try
                    {
                        connection.Open();

                        vwKardexGridView.DataSource = Program.GetDataTable(query,connection);
                        originalDataTable = Program.GetDataTable(query,connection);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
            }

            DGridView.RenameDGVColumn(vwKardexGridView, "shortDescription", "Material");
            DGridView.RenameDGVColumn(vwKardexGridView, "UserName", "Usuario");
            DGridView.RenameDGVColumn(vwKardexGridView, "MoveTypeName", "Tipo de mov");
            DGridView.RenameDGVColumn(vwKardexGridView, "quantity", "Cantidad");
            DGridView.RenameDGVColumn(vwKardexGridView, "movDate", "Fecha del movimiento");

        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            frmNewMovement frmNewMovement = new frmNewMovement(this,connectionString);
            frmNewMovement.Show();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string filterText = SearchBar.Text.ToLower();
            if (originalDataTable != null)
            {
                DataView dv = originalDataTable.DefaultView;
                dv.RowFilter = $"shortDescription LIKE '%{filterText}%' OR UserName LIKE '%{filterText}%' OR MoveTypeName LIKE '%{filterText}%'"; // Ajusta los nombres de las columnas según sea necesario
                vwKardexGridView.DataSource = dv;
            }
        }
    }
}
