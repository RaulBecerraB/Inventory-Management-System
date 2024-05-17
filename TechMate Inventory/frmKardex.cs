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
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        vwKardexGridView.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            frmNewMovement frmNewMovement = new frmNewMovement(this,connectionString);
            frmNewMovement.Show();
        }
    }
}
