using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    public partial class frmAddCatpopup : Form
    {

        private frmMatCatalogue catalogueParent;
        public string connectionString;
        public frmAddCatpopup(frmMatCatalogue catalogue)
        {
            InitializeComponent();
            this.catalogueParent = catalogue;
        }

        private void frmAddCatpopup_Load(object sender, EventArgs e)
        {

        }
    }
}
