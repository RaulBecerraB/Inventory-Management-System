using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private DataTable originalDataTable;
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    vwBorrowingsGridView.DataSource = Program.GetDataTable(query, connection);
                    originalDataTable = Program.GetDataTable(query, connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR cargando la gridView: " + ex.Message);
                }
            }

            DGridView.RenameDGVColumn(vwBorrowingsGridView,"shortDescription","Material");
            DGridView.RenameDGVColumn(vwBorrowingsGridView, "UserName", "Prestamista");
            DGridView.RenameDGVColumn(vwBorrowingsGridView, "StudentName", "Estudiante");
            DGridView.RenameDGVColumn(vwBorrowingsGridView, "quantity", "Cantidad prestada");
            DGridView.RenameDGVColumn(vwBorrowingsGridView, "return_date", "Fecha máxima de retorno");
            DGridView.RenameDGVColumn(vwBorrowingsGridView, "borrow_date", "Fecha del préstamo");

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string filterText = SearchBar.Text.ToLower();
            if (originalDataTable != null)
            {
                DataView dv = originalDataTable.DefaultView;
                dv.RowFilter = $"shortDescription LIKE '%{filterText}%' OR UserName LIKE '%{filterText}%' OR StudentName LIKE '%{filterText}%'"; // Ajusta los nombres de las columnas según sea necesario
                vwBorrowingsGridView.DataSource = dv;
            }
        }
    }
}
