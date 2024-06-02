using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    internal static class DGridViewUtils
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

        public static void RenameDGVColumn(DataGridView gridView, string columnName, string text)
        {
            gridView.Columns[columnName].HeaderText = text;
        }

        public static void SetLabelTextById(int id, DataGridView vw, string idName, string columnToShow, Label label)
        {
            foreach (DataGridViewRow row in vw.Rows)
            {
                if (row.Cells[idName].Value != null && (int)row.Cells[idName].Value == id)
                {
                    label.Text = row.Cells[columnToShow].Value.ToString();
                    break;
                }
            }
        }

        public static void SetRichTextBoxTextById(int id, DataGridView vw, string idName, string columnToShow, RichTextBox richTextBox)
        {
            foreach (DataGridViewRow row in vw.Rows)
            {
                if (row.Cells[idName].Value != null && (int)row.Cells[idName].Value == id)
                {
                    richTextBox.Text = row.Cells[columnToShow].Value.ToString();
                    break;
                }
            }
        }
    }
}
