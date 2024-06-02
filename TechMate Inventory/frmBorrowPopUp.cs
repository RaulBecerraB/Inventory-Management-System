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
    public partial class frmBorrowPopUp : Form
    {
        private string connectionString;
        private frmBorrowings parentBorrowings;
        public frmBorrowPopUp(string connectionString, frmBorrowings parentBorrowings)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.parentBorrowings = parentBorrowings;
        }

        private void frmBorrowPopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
