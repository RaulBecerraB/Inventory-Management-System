using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new frmLogin());
        }

        public static void FillComboBoxWithQuery(ComboBox comboBox, string table, string id, string attribute, SqlConnection connection)
        {
            string query = $"SELECT {id} , {attribute} FROM {table}";

            DataTable dataTable = GetDataTable(query, connection);

            comboBox.DataSource = dataTable; // Asignar dataTable como DataSource
            comboBox.DisplayMember = attribute;  // Columna para mostrar en el ComboBox.
            comboBox.ValueMember = id;  // Columna como valor que representa los items.
        }

        public static void FillComboBoxWithQuery(ComboBox comboBox, string table, string id, string attribute1, string attribute2, SqlConnection connection)
        {
            string query = $"SELECT {id}, {attribute1} + ' ' + {attribute2} AS FullName FROM {table}";

            DataTable dataTable = GetDataTable(query, connection);

            comboBox.DataSource = dataTable; // Asignar dataTable como DataSource
            comboBox.DisplayMember = "FullName";  // Columna para mostrar en el ComboBox.
            comboBox.ValueMember = id;  // Columna como valor que representa los items.
        }

        public static DataTable GetDataTable(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable GetDataTable(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


    }
}
