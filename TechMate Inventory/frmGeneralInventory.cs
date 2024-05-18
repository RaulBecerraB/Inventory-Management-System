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
    public partial class frmGeneralInventory : Form
    {
        private string connectionString;
        public frmGeneralInventory(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmGeneralInventory_Load(object sender, EventArgs e)
        {

        }
    }
}
