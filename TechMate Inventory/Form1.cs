using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        public static string connectionString = ConfigurationManager.ConnectionStrings["local.TechMateInventoryConnectionString"].ConnectionString;

        public string userName;
        public frmLogin parentLogin;
        private int userId;

        //Inicializar todas las forms para acceder a ellas de manera universal

        frmStore Store = new frmStore(connectionString);
        frmGeneralInventory Inventory = new frmGeneralInventory(connectionString);
        frmKardex Kardex = new frmKardex(connectionString);
        frmMatCatalogue Catalogue = new frmMatCatalogue(connectionString);
        frmInicio Home = new frmInicio(connectionString);
        frmCart Cart = new frmCart(connectionString);
        frmBorrowings Borrowings = new frmBorrowings(connectionString);  

        public Form1(string userName, frmLogin parentLogin, int userId)
        {
            InitializeComponent();
            this.userName = userName;
            this.parentLogin = parentLogin;
            this.userId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Used this to solve line break problem
            InventoryBtn.Text = "Inventario\nGeneral";

            labelUserName.Text = userName;
            Home.MdiParent = this;
            Home.Dock = DockStyle.Fill;
            Home.Show();

            CheckUserRole();
 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "HomeBtn":

                    int childIndexHome = fnBuscaMDIChild("frmInicio");

                    if (childIndexHome == -1)
                    {
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
                        Inventory.MdiParent = this;
                        Inventory.Dock = DockStyle.Fill;
                        Inventory.userId = userId;
                        Inventory.Show();
                    }
                    else
                    {
                        frmGeneralInventory Inventory = (frmGeneralInventory)this.MdiChildren[childIndexInventory];
                        Inventory.LoadInventoryView();
                        this.MdiChildren[childIndexInventory].Focus();
                    }

                break;

                case "StoreBtn":

                    int childIndexStore = fnBuscaMDIChild("frmStore");

                    if (childIndexStore == -1)
                    {
                        Store.MdiParent = this;
                        Store.Dock = DockStyle.Fill;
                        Store.childCart = Cart;
                        Store.userId = userId;
                        Store.Show();
                    }
                    else
                    {
                        frmStore Store = (frmStore)this.MdiChildren[childIndexStore];
                     
                        this.MdiChildren[childIndexStore].Focus();
                    }
                break;
                case "BorrowingBtn":

                    int childIndexBorrowing = fnBuscaMDIChild("frmBorrowings");

                    if (childIndexBorrowing == -1)
                    {
                        Borrowings.MdiParent = this;
                        Borrowings.Dock = DockStyle.Fill;
                        Borrowings.userId = userId;
                        Borrowings.Show();
                    }
                    else
                    {
                        frmBorrowings Borrowings = (frmBorrowings)this.MdiChildren[childIndexBorrowing];
                        Borrowings.LoadBorrowingsView();
                        this.MdiChildren[childIndexBorrowing].Focus();
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

        private void CartBtn_Click(object sender, EventArgs e)
        {
            int childIndexCart = fnBuscaMDIChild("frmCart");

            if (childIndexCart == -1)
            {
                Cart.MdiParent = this;
                Cart.Dock = DockStyle.Fill;
                Cart.parentStore = Store;
                Cart.Show();
            }
            else
            {
                this.MdiChildren[childIndexCart].Focus();
            }
        }

        private void CheckUserRole()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_Role FROM Users WHERE ID_User = @userId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                int userRole = Convert.ToInt32(command.ExecuteScalar());

                if (userRole == 2) // Usuario
                {
                    // Esconde ciertas formas para usuarios no administradores
                    kardexBtn.Visible = false;
                    InventoryBtn.Visible = false;
                    catalogueBtn.Visible = false;
                }
            }
        }
    }
}
