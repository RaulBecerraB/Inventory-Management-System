using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public int borrowId;
        public string studentId;
        public int materialId;
        public int quantity;
        public frmBorrowPopUp(frmBorrowings parentBorrowings, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.parentBorrowings = parentBorrowings;
        }

        private void frmBorrowPopUp_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            LoadMaterialData();
            LoadBorrowingStatus();
        }

        private void LoadStudentData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Matricula, name, last_name, phone, email FROM Students WHERE Matricula = @studentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentId", studentId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    StringBuilder studentData = new StringBuilder();
                    studentData.AppendLine(reader["Matricula"].ToString());
                    studentData.AppendLine($"{reader["name"]} {reader["last_name"]}");
                    studentData.AppendLine(reader["phone"].ToString());
                    studentData.AppendLine(reader["email"].ToString());

                    StudentDataRichTextBox.Text = studentData.ToString();
                }
                reader.Close();
            }
        }

        private void LoadMaterialData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT m.shortDescription, m.Description, u.Name
                    FROM Materials m
                    INNER JOIN MatUnits u ON m.ID_Unit = u.ID_Unit
                    WHERE m.ID_Material = @materialId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@materialId", materialId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    StringBuilder materialData = new StringBuilder();
                    materialData.AppendLine(reader["shortDescription"].ToString());
                    materialData.AppendLine(reader["Description"].ToString());
                    materialData.AppendLine($"{quantity} {reader["Name"]}");

                    MaterialDataRichTextBox.Text = materialData.ToString();
                }
                reader.Close();
            }
        }

        private void LoadBorrowingStatus()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT isBorrowed FROM Borrowings WHERE ID_Borrowing = @borrowId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@borrowId", borrowId);

                connection.Open();
                bool isBorrowed = (bool)command.ExecuteScalar();
                BorrowingStatusTextBox.Text = isBorrowed ? "Préstamo en curso" : "Material devuelto";
                BorrowingStatusTextBox.BackColor = isBorrowed ? Color.FromArgb(255, 223, 186) : Color.FromArgb(198, 239, 206);
            }
        }

    }
}
