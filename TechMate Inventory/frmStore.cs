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
        public frmCart childCart;
        public string selectedStudent;
        public frmStore(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmStore_Load(object sender, EventArgs e)
        {   
            frmGeneralInventory frmInventory = new frmGeneralInventory(connectionString);

            frmInventory.LoadInventoryView(vwInventoryGridView);

            DGridViewCounter.AddButtonColumn(vwInventoryGridView,"Increment","+");
            DGridViewCounter.AddCounterToGridView(vwInventoryGridView, "Cantidad","Quantity",0);
            DGridViewCounter.AddButtonColumn(vwInventoryGridView, "Decrement", "-");
            DGridViewCounter.AddButtonColumn(vwInventoryGridView, "AddToCart", "Añadir al carrito");

        }

        public void UpdateLabel2()
        {
            label2.Text = selectedStudent;
        }

        private void vwInventoryGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si es la columna "Quantity"
            if (vwInventoryGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Si el valor es nulo, mostrar "0"
                if (e.Value == null)
                {
                    e.Value = "0";
                    e.FormattingApplied = true;
                }
                else
                {
                    // Asegurarse de que se muestre el valor actual
                    e.Value = e.Value.ToString();
                    e.FormattingApplied = true;
                }
            }
        }

        private void vwInventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda de tipo botón
            if (e.RowIndex >= 0 && (vwInventoryGridView.Columns[e.ColumnIndex].Name == "Increment" || vwInventoryGridView.Columns[e.ColumnIndex].Name == "Decrement"))
            {
                DataGridViewRow row = vwInventoryGridView.Rows[e.RowIndex];
                int currentValue = Convert.ToInt32(row.Cells["Quantity"].Value);

                // Incrementar o decrementar el valor según el botón presionado
                if (vwInventoryGridView.Columns[e.ColumnIndex].Name == "Increment")
                {
                    row.Cells["Quantity"].Value = currentValue + 1;
                }
                else if (vwInventoryGridView.Columns[e.ColumnIndex].Name == "Decrement" && currentValue > 0)
                {
                    row.Cells["Quantity"].Value = currentValue - 1;
                }

                // Refrescar el DataGridView después de actualizar los valores
                vwInventoryGridView.Refresh();
            }
        }
    }
}
