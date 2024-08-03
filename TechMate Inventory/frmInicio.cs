using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMate_Inventory
{
    public partial class frmInicio : Form
    {
        public string connectionString;
        public frmInicio(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            frmBorrowings borrowings = new frmBorrowings(connectionString);
            LoadBorrowingsView();
        }

        public void LoadBorrowingsView()
        {
            string query = @"
SELECT 
    B.ID_Borrowing,
    M.ID_Material,
    S.Matricula,
    M.shortDescription,
    U.Name AS UserName,
    S.name AS StudentName,
    B.quantity,
    B.return_date,
    B.borrow_date,
    B.isBorrowed
FROM 
    Borrowings B
JOIN 
    Materials M ON B.ID_Material = M.ID_Material
JOIN 
    Users U ON B.ID_User = U.ID_User
JOIN 
    Students S ON B.Matricula = S.Matricula";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable borrowingsDataTable = Program.GetDataTable(query, connection);
                    vwBorrowingsGridView.DataSource = borrowingsDataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR cargando la gridView: " + ex.Message);
                }
            }

            vwBorrowingsGridView.Columns["ID_Material"].Visible = false;
            vwBorrowingsGridView.Columns["ID_Borrowing"].Visible = false;
            vwBorrowingsGridView.Columns["Matricula"].Visible = false;
            vwBorrowingsGridView.Columns["isBorrowed"].Visible = false;

            DGridViewUtils.RenameDGVColumn(vwBorrowingsGridView, "shortDescription", "Material");
            DGridViewUtils.RenameDGVColumn(vwBorrowingsGridView, "UserName", "Prestamista");
            DGridViewUtils.RenameDGVColumn(vwBorrowingsGridView, "StudentName", "Estudiante");
            DGridViewUtils.RenameDGVColumn(vwBorrowingsGridView, "quantity", "Cantidad prestada");
            DGridViewUtils.RenameDGVColumn(vwBorrowingsGridView, "return_date", "Fecha máxima de retorno");
            DGridViewUtils.RenameDGVColumn(vwBorrowingsGridView, "borrow_date", "Fecha del préstamo");
        }
    }
}
