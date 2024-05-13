using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TechMate_Inventory
{
    public partial class Material_CRUD_PopUp1 : Form
    {
        private frmMatCatalogue parentForm;

        public int intMaterialId;

        private string connectionString;
        public Material_CRUD_PopUp1(frmMatCatalogue parent, string connectionString)
        {
            InitializeComponent();  // Esto inicializa todos los controles del formulario
            //Primero se inicializa el connectionString antes de tocar SQL
            this.connectionString = connectionString; 
            LoadMaterialDetails();
            this.parentForm = parent;
        }

        private void frmAddMatpopup_Load(object sender, EventArgs e)
        {
            // Asegúrate que esta línea está después de InitializeComponent();
            LoadMaterialDetails();

            //MessageBox.Show($"Doble clic en la fila con ID: " + intMaterialId);
        }

        private void LoadMaterialDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los detalles del material basado en intMaterialId
                    string query = @"
                SELECT m.shortDescription, m.BorrowLimitDays, m.Description, m.ID_MatType, m.ID_Unit
                FROM Materials m
                WHERE m.ID_Material = @MaterialId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaterialId", intMaterialId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Carga los datos en los controles
                            textBoxshortDescription.Text = reader["shortDescription"].ToString();
                            textBoxBorrowLimitDays.Text = reader["BorrowLimitDays"].ToString();
                            richTextBoxMatDesc.Text = reader["Description"].ToString();

                            // Ajusta los ComboBox según el tipo de material y la unidad
                            comboBoxMatTypes.SelectedValue = reader["ID_MatType"];
                            comboBoxMatUnit.SelectedValue = reader["ID_Unit"];
                        }
                    }

                    // Cargar categorías y otros datos combobox después de establecer el tipo de material
                    LoadDataIntoComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading material data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void LoadDataIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre la conexión primero

                    // Consulta para obtener todos los Tipos de Materiales y seleccionar el actual
                    string MatTypequery = "SELECT ID_MatType, Name FROM MatTypes";
                    SqlDataAdapter MatTypeAdapter = new SqlDataAdapter(MatTypequery, connection);
                    DataTable matTypeTable = new DataTable();
                    MatTypeAdapter.Fill(matTypeTable);
                    comboBoxMatTypes.DataSource = matTypeTable;
                    comboBoxMatTypes.DisplayMember = "Name";
                    comboBoxMatTypes.ValueMember = "ID_MatType";

                    // Consulta para obtener todas las Categorías y seleccionar la actual
                    string Catquery = "SELECT ID_Category, Name FROM Categories";
                    SqlDataAdapter CatAdapter = new SqlDataAdapter(Catquery, connection);
                    DataTable categoriesName = new DataTable();
                    CatAdapter.Fill(categoriesName);
                    comboBoxCategories.DataSource = categoriesName;
                    comboBoxCategories.DisplayMember = "Name";
                    comboBoxCategories.ValueMember = "ID_Category";

                    // Consulta para obtener todas las Unidades y seleccionar la actual
                    string MatUnitquery = "SELECT ID_Unit, Name FROM MatUnits";
                    SqlDataAdapter MatUnitAdapter = new SqlDataAdapter(MatUnitquery, connection);
                    DataTable matUnitTable = new DataTable();
                    MatUnitAdapter.Fill(matUnitTable);
                    comboBoxMatUnit.DataSource = matUnitTable;
                    comboBoxMatUnit.DisplayMember = "Name";
                    comboBoxMatUnit.ValueMember = "ID_Unit";

                    // Establece los valores seleccionados basados en el material actual
                    SetInitialComboBoxValues(intMaterialId, connection);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
        }
        private void SetInitialComboBoxValues(int materialId, SqlConnection connection)
        {
            // Consulta para obtener los valores actuales del material
            string query = @"
        SELECT ID_MatType, ID_Unit, (SELECT ID_Category FROM MatTypes WHERE ID_MatType = Materials.ID_MatType) AS ID_Category
        FROM Materials
        WHERE ID_Material = @MaterialId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaterialId", materialId);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    comboBoxMatTypes.SelectedValue = reader["ID_MatType"];
                    comboBoxMatUnit.SelectedValue = reader["ID_Unit"];
                    comboBoxCategories.SelectedValue = reader["ID_Category"];
                }
            }
        }
        private int GetNextMaterialId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(ID_Material) FROM Materials";
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
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                UPDATE Materials 
                SET ID_MatType = @MatType, 
                    ID_Unit = @Unit, 
                    BorrowLimitDays = @BorrowDays, 
                    Description = @Description, 
                    shortDescription = @shortDescription 
                WHERE ID_Material = @MaterialID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Obteniendo los valores seleccionados de los ComboBoxes y el valor de la descripción
                        int matType = (int)comboBoxMatTypes.SelectedValue;
                        int unit = (int)comboBoxMatUnit.SelectedValue;
                        string shortDescription = textBoxshortDescription.Text;
                        string description = richTextBoxMatDesc.Text;

                        // Seguro manejo de la conversión de BorrowLimitDays
                        int borrowLimitDays = 0;
                        int.TryParse(textBoxBorrowLimitDays.Text, out borrowLimitDays);

                        // Añadiendo los parámetros al comando
                        command.Parameters.AddWithValue("@MaterialID", intMaterialId);
                        command.Parameters.AddWithValue("@MatType", matType);
                        command.Parameters.AddWithValue("@Unit", unit);
                        command.Parameters.AddWithValue("@BorrowDays", borrowLimitDays);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@shortDescription", shortDescription);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Material updated successfully!");
                    }

                    // Si el formulario padre está configurado, actualízalo
                    if (parentForm != null)
                    {
                        parentForm.LoadDataFromView();
                    }
                    this.Close(); // Opcionalmente cierra este formulario
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add material: " + ex.Message);
                }
            }
        }

        private void richTextBoxMatDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBorrowLimitDays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
