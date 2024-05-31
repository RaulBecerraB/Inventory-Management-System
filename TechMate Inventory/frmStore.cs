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

        }

        private void vwInventoryGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si es la columna "Quantity"
            if (vwInventoryGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Verificar si el valor es 0 y formatear adecuadamente
                if (e.Value == null || e.Value.Equals(0))
                {
                    e.Value = "0";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
