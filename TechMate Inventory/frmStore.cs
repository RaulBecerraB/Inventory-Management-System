using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    public partial class frmStore : Form
    {
        private string connectionString;
        public frmStore(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            frmGeneralInventory frmInventory = new frmGeneralInventory(connectionString);
            frmInventory.LoadInventoryView(vwInventoryGridView);
            AddButtonToGridView(vwInventoryGridView,"+","Add");
            AddTextBoxToGridView(vwInventoryGridView,"Cantidad","quantity");
            AddButtonToGridView(vwInventoryGridView,"-","Remove");
            AddButtonToGridView(vwInventoryGridView, "Añadir\n al carrito", "Add to cart");
        }

        private void AddButtonToGridView(DataGridView gridView, string text, string name)
        {
            // Verifica si la columna ya existe para evitar duplicados
            if (!gridView.Columns.Contains("deleteColumn"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = name;
                deleteButtonColumn.HeaderText = "";
                deleteButtonColumn.Text = text;
                deleteButtonColumn.UseColumnTextForButtonValue = true;  // Hace que el texto del botón sea el valor por defecto de la columna
                deleteButtonColumn.Width = 60;  // Ancho de la columna de botón

                // Añade la columna de botón al final de todas las columnas existentes
                gridView.Columns.Add(deleteButtonColumn);

                // Ajusta las propiedades de autoajuste de columnas del DataGridView
                gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Establece explícitamente el ancho de la columna después de añadirla
                gridView.Columns[name].Width = 60;
            }
        }

        private void AddTextBoxToGridView(DataGridView gridView,string text ,string name)
        {
            // Verifica si la columna ya existe para evitar duplicados
            if (!gridView.Columns.Contains(text))
            {
                DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
                textBoxColumn.Name = name;
                textBoxColumn.HeaderText = text;
                textBoxColumn.Width = 100;  // Ancho de la columna de texto

                // Añade la columna de texto al final de todas las columnas existentes
                gridView.Columns.Add(textBoxColumn);
            }
        }
    }
}
