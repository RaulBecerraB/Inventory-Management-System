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
    public partial class frmCart : Form
    {
        private string connectionString;
        public frmCart(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    Program.FillComboBoxWithQuery(comboBoxStudents, "Students", "Matricula", "name",connection);
                }
                catch 
                {

                }
            }
                
        }
    }
}
