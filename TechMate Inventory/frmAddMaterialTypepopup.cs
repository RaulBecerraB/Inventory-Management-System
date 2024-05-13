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
    public partial class frmAddMaterialTypepopup : Form
    {
        public string connectionString;
        private frmMatCatalogue catalogueParent;
        public frmAddMaterialTypepopup(frmMatCatalogue parent, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            LoadDataIntoComboBox();
            this.catalogueParent = parent;
        }

        private void frmAddMaterialTypepopup_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }
        private int GetNextMaterialId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(ID_MatType) FROM MatTypes";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    return 1; // Devuelve 1 si la tabla está vacía
                }
            }
        }

        private void LoadDataIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); //Abri la conexión primero

                    string Catquery = "SELECT ID_Category, Name FROM Categories";

                    SqlDataAdapter Catadapter = new SqlDataAdapter(Catquery, connection);

                    DataTable categoriesName = new DataTable();

                    Catadapter.Fill(categoriesName);

                    // Asignar DataTable como DataSource del ComboBox.
                    comboBoxCategories.DataSource = categoriesName;

                    // Configurar DisplayMember y ValueMember.
                    comboBoxCategories.DisplayMember = "Name";  // Columna para mostrar en el ComboBox.
                    comboBoxCategories.ValueMember = "ID_Category";  // Columna como valor que representa los items.

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                    // Copiar al Portapapeles
                    Clipboard.SetText(ex.Message);
                }
            }
        }
        private void addMatTypeInTextBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int newMatTypeId = GetNextMaterialId();  // Obtiene el próximo ID disponible
                    string newMatTypeName = textBoxNewCat.Text;  // Obtiene el nombre del nuevo MatType del TextBox
                    int selectedCategoryId = Convert.ToInt32(comboBoxCategories.SelectedValue);  // Obtiene el ID de la categoría seleccionada del ComboBox

                    // Comando SQL para insertar el nuevo MatType
                    string insertQuery = @"
                INSERT INTO MatTypes (ID_MatType, Name, ID_Category) 
                VALUES (@ID_MatType, @Name, @ID_Category)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Asignar los valores a los parámetros del comando SQL
                        command.Parameters.AddWithValue("@ID_MatType", newMatTypeId);
                        command.Parameters.AddWithValue("@Name", newMatTypeName);
                        command.Parameters.AddWithValue("@ID_Category", selectedCategoryId);

                        command.ExecuteNonQuery();  // Ejecutar el comando SQL
                    }

                    MessageBox.Show("Material Type added successfully.");

                    if (catalogueParent != null)
                    {
                        // Actualizar el padre, si es necesario, puede ser que necesites recargar ciertos datos
                        catalogueParent.LoadLowerTables();
                    }

                    this.Close();  // Cerrar la ventana de diálogo después de insertar el dato
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding Material Type: " + ex.Message);
                    Clipboard.SetText(ex.Message);  // Copiar mensaje de error al portapapeles automáticamente
                }
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            addMatTypeInTextBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
