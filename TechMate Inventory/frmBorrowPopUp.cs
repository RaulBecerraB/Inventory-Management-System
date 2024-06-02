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
                string query = "SELECT shortDescription, Description FROM Materials WHERE ID_Material = @materialId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@materialId", materialId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    StringBuilder materialData = new StringBuilder();
                    materialData.AppendLine(reader["shortDescription"].ToString());
                    materialData.AppendLine(reader["Description"].ToString());

                    MaterialDataRichTextBox.Text = materialData.ToString();
                }
                reader.Close();
            }
        }

    }
}
