using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "Inicio":
                    frmMatCatalogue2 frmMatCatalogue = new frmMatCatalogue2();
                    frmMatCatalogue.MdiParent = this;
                    frmMatCatalogue.Dock = DockStyle.Fill;  
                    frmMatCatalogue.Show();
                    break;
                default:
                    break;
            }
            //MessageBox.Show(e.ClickedItem.Name);

        }

     
    }
}
