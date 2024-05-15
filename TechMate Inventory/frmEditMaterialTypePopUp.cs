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
using System.Xml.Linq;

namespace TechMate_Inventory
{
    public partial class frmEditMaterialTypePopUp : Form
    {
        frmMatCatalogue catalogueParent;
        string connectionString;

        public int intTypeId;

        public frmEditMaterialTypePopUp(frmMatCatalogue parent ,string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.catalogueParent = parent;
        }

        private void frmEditMaterialTypePopUp_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void LoadDataIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Cargar la comboBox con las categorías
                    string Catquery = "SELECT ID_Category, Name FROM Categories";
                    SqlDataAdapter CatAdapter = new SqlDataAdapter(Catquery, connection);
                    DataTable categoriesName = new DataTable();
                    CatAdapter.Fill(categoriesName);

                    comboBoxCategories.DataSource = categoriesName;
                    comboBoxCategories.DisplayMember = "Name";
                    comboBoxCategories.ValueMember = "ID_Category";

                    //Llenar comboBox con los valores correspondientes en la base de datos a el tipo seleccionado
                    SetInitialComboBoxValues(intTypeId, connection);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("EditType EXCEPTION: " + ex.Message);
                }             
            }
        }

        private void SetInitialComboBoxValues(int TypeId, SqlConnection connection)
        {
            // Consulta para obtener el ID de la categoría directamente desde MatTypes
            string query = @"
            SELECT ID_Category
            FROM MatTypes
            WHERE ID_MatType = @MatTypeId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MatTypeId", TypeId);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Asumiendo que comboBoxCategories ya tiene las categorías cargadas y está configurado correctamente
                    comboBoxCategories.SelectedValue = reader["ID_Category"];
                }
                else
                {
                    // Opcional: Manejo en caso de que no se encuentre un valor, por ejemplo, seleccionar un valor por defecto
                    comboBoxCategories.SelectedIndex = -1; // Esto podría establecer el ComboBox sin selección o a un valor por defecto
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = @"
                UPDATE MatTypes
                SET Name = @Name, 
                    ID_Category = @Category
                WHERE ID_MatType = @MatTypeID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Suponemos que tienes controles para capturar estos valores, ajusta los nombres de los controles según corresponda
                        string name = textBoxEditType.Text; // Asume que hay un TextBox txtName para el nombre del tipo de material
                        int categoryID = (int)comboBoxCategories.SelectedValue; // Asume que hay un ComboBox comboBoxCategory para la categoría

                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Category", categoryID);
                        command.Parameters.AddWithValue("@MatTypeID", intTypeId); // Asegúrate de tener matTypeID disponible

                        command.ExecuteNonQuery();
                        MessageBox.Show("Type updated successfully!");
                    }

                    // Si el formulario padre está configurado, actualízalo
                    if (catalogueParent != null)
                    {
                        catalogueParent.LoadDataFromView();
                        catalogueParent.LoadLowerTables();
                    }
                    this.Close(); // Opcionalmente cierra este formulario
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to UPDATE Type: " + ex.Message);
                }
            }
        }
    }
}
