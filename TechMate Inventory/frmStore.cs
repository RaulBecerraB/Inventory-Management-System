using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

            AddButtonToGridView(vwInventoryGridView,"+","Add",45);
            AddTextBoxToGridView(vwInventoryGridView,"Cantidad","quantity");
            AddButtonToGridView(vwInventoryGridView,"-","Remove", 45);
            AddButtonToGridView(vwInventoryGridView, "Añadir\n al carrito", "Add to cart",120);
        }

        private void AddButtonToGridView(DataGridView gridView, string text, string name, int width)
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


        private void AddTextBoxToGridView(DataGridView gridView,string text ,string name)
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
    }
}
