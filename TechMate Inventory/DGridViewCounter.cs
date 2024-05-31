using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    internal static class DGridViewCounter
    {
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
                        row.Cells[name].Value = 0;
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

                // Establece la altura predeterminada de todas las filas
                gridView.RowTemplate.Height = 400;
            }
        }

        public static void UpdateCounter(DataGridView dataGridView, int increment)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    int currentValue = Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Quantity"].Value = currentValue + increment;
                }
            }

            // Refrescar el DataGridView después de actualizar los valores
            dataGridView.Refresh();
        }

        public static void AddButtonColumn(DataGridView gridView, string name, string text)
        {
            DataGridViewButtonColumn incrementButtonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = "",
                Text = text,
                UseColumnTextForButtonValue = true
            };

            // Añadir las columnas de botones al final de todas las columnas existentes
            gridView.Columns.Add(incrementButtonColumn);
        }
    }




}
