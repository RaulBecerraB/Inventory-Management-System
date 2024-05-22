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
        public string connectionString = ConfigurationManager.ConnectionStrings["local.TechMateInventoryConnectionString"].ConnectionString;

        public string userName;
        public frmLogin parentLogin;
        public Form1(string userName, frmLogin parentLogin)
        {
            InitializeComponent();
            this.userName = userName;
            this.parentLogin = parentLogin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Used this to solve line break problem
            InventoryBtn.Text = "Inventario\nGeneral";

            frmInicio Home = new frmInicio(connectionString);

            labelUserName.Text = userName;
            Home.MdiParent = this;
            Home.Dock = DockStyle.Fill;
            Home.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "HomeBtn":

                    int childIndexHome = fnBuscaMDIChild("frmInicio");

                    if (childIndexHome == -1)
                    {
                        frmInicio Home = new frmInicio(connectionString);
                        Home.MdiParent = this;
                        Home.Dock = DockStyle.Fill;
                        Home.Show();
                    }
                    else
                    {
                        this.MdiChildren[childIndexHome].Focus();
                    }

                break;

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
                        frmKardex Kardex = (frmKardex)this.MdiChildren[childIndexKardex];
                        Kardex.LoadKardexView();
                        this.MdiChildren[childIndexKardex].Focus();
                    }
                    
                break;

                case "InventoryBtn":

                    int childIndexInventory = fnBuscaMDIChild("frmGeneralInventory");

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentLogin.Close();
        }
    }
}
