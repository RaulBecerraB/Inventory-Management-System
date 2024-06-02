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
        public int userId;
        public frmBorrowings(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmBorrowings_Load(object sender, EventArgs e)
        {
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
                    originalDataTable = borrowingsDataTable;
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


        private DateTime GetServerDateTime()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT GETDATE()", connection))
                {
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }

        private void ApplyRowColor(DataGridViewRow row, DateTime currentDateTime)
        {
            bool isBorrowed = Convert.ToBoolean(row.Cells["isBorrowed"].Value);
            DateTime returnDate = Convert.ToDateTime(row.Cells["return_date"].Value);

            if (!isBorrowed)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(198, 239, 206); // Verde suave
            }
            else if (isBorrowed && currentDateTime > returnDate)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 183, 183); // Rojo suave
            }
            else if (isBorrowed)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 186); // Naranja suave
            }
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

        private void vwBorrowingsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Comprueba si el doble clic fue sobre una fila (y no en el área de encabezado)
            if (e.RowIndex >= 0)
            {
                // Aquí puedes acceder a la fila en la que se hizo doble clic
                DataGridViewRow clickedRow = vwBorrowingsGridView.Rows[e.RowIndex];

                frmBorrowPopUp BorrowPopUp = new frmBorrowPopUp(this, connectionString);
                BorrowPopUp.borrowId = (int)clickedRow.Cells["ID_Borrowing"].Value;
                BorrowPopUp.studentId = (string)clickedRow.Cells["Matricula"].Value;
                BorrowPopUp.materialId = (int)clickedRow.Cells["ID_Material"].Value;
                BorrowPopUp.quantity = (int)clickedRow.Cells["quantity"].Value;
                BorrowPopUp.Show();

                // Por ejemplo, mostrar información de la fila
                //MessageBox.Show($"Doble clic en la fila con ID: {clickedRow.Cells["ID_Material"].Value.ToString()}");
                //selectedIndex = clickedRow.Cells["ID_Material"].Value;
            }
        }

        private void vwBorrowingsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DateTime currentDateTime = GetServerDateTime();

            foreach (DataGridViewRow row in vwBorrowingsGridView.Rows)
            {
                ApplyRowColor(row, currentDateTime);
            }
        }
    }
}
