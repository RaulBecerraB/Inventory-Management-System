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
    public partial class frmBorrowings : Form
    {
        private string connectionString;
        public frmBorrowings(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmBorrowings_Load(object sender, EventArgs e)
        {
            LoadBorrowingsView();
        }

        private void LoadBorrowingsView()
        {
            string query = @"
        SELECT 
            M.shortDescription,
            U.Name AS UserName,
            S.name AS StudentName,
            B.quantity,
            B.return_date,
            B.borrow_date
        FROM 
            Borrowings B
        JOIN 
            Materials M ON B.ID_Material = M.ID_Material
        JOIN 
            Users U ON B.ID_User = U.ID_User
        JOIN 
            Students S ON B.Matricula = S.Matricula";

            DGridView.LoadDataGridWithQuery(vwBorrowingsGridView,query,connectionString);

            
            RenameDGVColumn(vwBorrowingsGridView,"shortDescription","Material");
            RenameDGVColumn(vwBorrowingsGridView, "UserName", "Prestamista");
            RenameDGVColumn(vwBorrowingsGridView, "StudentName", "Estudiante");
            RenameDGVColumn(vwBorrowingsGridView, "quantity", "Cantidad prestada");
            RenameDGVColumn(vwBorrowingsGridView, "return_date", "Fecha máxima de retorno");
            RenameDGVColumn(vwBorrowingsGridView, "borrow_date", "Fecha del préstamo");

        }

        private void RenameDGVColumn(DataGridView gridView, string columnName, string text)
        {
            gridView.Columns[columnName].HeaderText = text;
        }
    }
}
