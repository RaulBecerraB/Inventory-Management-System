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

        public static DataTable GetDataTable(string query, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static void AddTextBoxToGridView(DataGridView gridView, string text, string name)
        {
            // Verifica si la columna ya existe para evitar duplicados
            if (!gridView.Columns.Contains(text))
            {
                DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
                textBoxColumn.Name = name;
                textBoxColumn.HeaderText = text;

                // Añade la columna de texto al final de todas las columnas existentes
                gridView.Columns.Add(textBoxColumn);

            }
        }

        public static void AddCounterToGridView(DataGridView gridView, string text, string name, int startValue)
        {
            // Verifica si la columna ya existe para evitar duplicados
            if (!gridView.Columns.Contains(name))
            {
                DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn
                {
                    Name = name,
                    HeaderText = text
                };

                // Añade la columna de texto al final de todas las columnas existentes
                gridView.Columns.Add(textBoxColumn);

                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (!row.IsNewRow) // Asegúrate de no intentar asignar valor a la fila nueva
                    {
                        row.Cells[name].Value = startValue;
                        // Verificar el valor asignado
                        Console.WriteLine($"Fila {row.Index}, Columna {name}, Valor Asignado: {row.Cells[name].Value}");
                    }

                    // Refrescar el DataGridView después de asignar los valores
                    gridView.Refresh();
                }
            }
        }

        public static void AddButtonToGridView(DataGridView gridView, string text, string name, int width)
        {
            // Verifica si la columna ya existe para evitar duplicados
            if (!gridView.Columns.Contains(name))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = name;
                buttonColumn.HeaderText = "";
                buttonColumn.Text = text;
                buttonColumn.UseColumnTextForButtonValue = true;  // Hace que el texto del botón sea el valor por defecto de la columna
                buttonColumn.Width = width; // Establece el ancho de la columna del botón

                // Añade la columna de botón al final de todas las columnas existentes
                gridView.Columns.Add(buttonColumn);

                // Ajusta las propiedades de autoajuste de columnas del DataGridView
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Establece explícitamente el ancho de la columna después de añadirla
                gridView.Columns[name].Width = width;

                /////////////////////////////////////////////////////////
                // TODO: AJUSTE DE ALTURA POR ROW SIGUE SIN FUNCIONAR, //
                // ARREGLAR MÁS TARDE                                  //
                /////////////////////////////////////////////////////////

                // Establece la altura predeterminada de todas las filas
                gridView.RowTemplate.Height = 400;
            }
        }
    }
}
