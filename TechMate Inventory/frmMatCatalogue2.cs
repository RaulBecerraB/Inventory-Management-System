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
    public partial class frmMatCatalogue2 : Form
    {
        public frmMatCatalogue2()
        {
            InitializeComponent();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techMateInventoryDataSet);

        }

        private void frmMatCatalogue2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'techMateInventoryDataSet.Materials' Puede moverla o quitarla según sea necesario.
            this.materialsTableAdapter.Fill(this.techMateInventoryDataSet.Materials);

        }

        private void materialsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
