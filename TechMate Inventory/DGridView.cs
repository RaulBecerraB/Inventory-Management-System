using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    internal static class DGridView
    {
        public static void LoadDataGridWithQuery(DataGridView gridView, string query, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    gridView.DataSource = Program.GetDataTable(query, connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR cargando la gridView: "+ ex.Message);
                }
            }
        }
    }
}
