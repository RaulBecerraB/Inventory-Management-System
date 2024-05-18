using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public string connectionString = ConfigurationManager.ConnectionStrings["Local.TechMateInventoryConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Used this to solve line break problem
            InventoryBtn.Text = "Inventario\nGeneral";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "catalogueBtn":
                    int childIndexCatalogue = fnBuscaMDIChild("frmMatCatalogue");
         
                    if (childIndexCatalogue == -1)
                    {
                        frmMatCatalogue Catalogue = new frmMatCatalogue(connectionString);
                        Catalogue.MdiParent = this;
                        Catalogue.Dock = DockStyle.Fill;
                        Catalogue.Show();
                    }
                    else
                    {
                        this.MdiChildren[childIndexCatalogue].Focus();
                    }
                    break;

                case "kardexBtn":

                    int childIndexKardex = fnBuscaMDIChild("frmKardex");

                    if (childIndexKardex == -1)
                    {
                        frmKardex Kardex = new frmKardex(connectionString);
                        Kardex.MdiParent = this;
                        Kardex.Dock = DockStyle.Fill;
                        Kardex.Show();
                    }
                    else
                    {
                        this.MdiChildren[childIndexKardex].Focus();
                    }
                    
                break;

                case "InventoryBtn":

                    int childIndexInventory = fnBuscaMDIChild("frmGeneralInevntory");

                    if (childIndexInventory == -1)
                    {
                        frmGeneralInventory Inventory = new frmGeneralInventory(connectionString);
                        Inventory.MdiParent = this;
                        Inventory.Dock = DockStyle.Fill;
                        Inventory.Show();
                    }
                    else
                    {
                        this.MdiChildren[childIndexInventory].Focus();
                    }

                break;

                default:
                    break;
            }
            //MessageBox.Show(e.ClickedItem.Name);

        }

        private int fnBuscaMDIChild(string strNombre)
        {
            int i;

            if (this.MdiChildren.Length != 0)
            {
                for (i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name == strNombre)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
