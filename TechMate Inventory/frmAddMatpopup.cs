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
    public partial class frmAddMatpopup : Form
    {
        private frmMatCatalogue parentForm;

        // private string connectionString = catalogue.connectionString;
        public string connectionString;

        public frmAddMatpopup(frmMatCatalogue parent, string connectionString)
        {
            InitializeComponent();  // Esto inicializa todos los controles del formulario
            this.connectionString = connectionString;
            LoadDataIntoComboBox();
            this.parentForm = parent;
        }

        private void frmAddMatpopup_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'techMateInventoryDataSet.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.techMateInventoryDataSet.Categories);

            // Asegúrate que esta línea está después de InitializeComponent();
            LoadDataIntoComboBox();
        }

        private void LoadDataIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); //Abri la conexión primero

                    string Catquery = "SELECT ID_Category, Name FROM Categories";
                    string MatTypequery = "SELECT ID_MatType, Name FROM MatTypes";
                    string MatUnitquery = "SELECT ID_Unit, Name FROM MatUnits";

                    SqlDataAdapter Catadapter = new SqlDataAdapter(Catquery, connection);
                    SqlDataAdapter MatTypeAdapter = new SqlDataAdapter(MatTypequery, connection);
                    SqlDataAdapter MatUnitAdapter = new SqlDataAdapter(MatUnitquery, connection);

                    DataTable categoriesName = new DataTable();
                    DataTable matTypeName = new DataTable();
                    DataTable matUnitName = new DataTable();


                    Catadapter.Fill(categoriesName);
                    MatTypeAdapter.Fill(matTypeName);
                    MatUnitAdapter.Fill(matUnitName);


                    // Asignar DataTable como DataSource del ComboBox.
                    //comboBoxCategories.DataSource = categoriesName;
                    comboBoxMatTypes.DataSource = matTypeName;
                    comboBoxMatUnit.DataSource = matUnitName;

                    // Configurar DisplayMember y ValueMember.
                    //comboBoxCategories.DisplayMember = "Name";  // Columna para mostrar en el ComboBox.
                    //comboBoxCategories.ValueMember = "ID_Category";  // Columna como valor que representa los items.

                    // Configurar DisplayMember y ValueMember.
                    comboBoxMatTypes.DisplayMember = "Name";  // Columna para mostrar en el ComboBox.
                    comboBoxMatTypes.ValueMember = "ID_MatType";  // Columna como valor que representa los items.

                    //Configurar DisplayMember y ValueMember
                    comboBoxMatUnit.DisplayMember = "Name";
                    comboBoxMatUnit.ValueMember = "ID_Unit";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                    // Copiar al Portapapeles
                    Clipboard.SetText(ex.Message);
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

                    string insertQuery = @"INSERT INTO Materials (ID_Material, ID_MatType, ID_Unit, BorrowLimitDays, Description, shortDescription) VALUES (@MaterialID, @MatType, @Unit, @BorrowDays, @Description, @shortDescription)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Obteniendo los valores seleccionados de los ComboBoxes y el valor de la descripción
                        int newMaterialId = GetNextMaterialId(); // Obtén el próximo ID
                        int matType = (int)comboBoxMatTypes.SelectedValue;
                        int unit = (int)comboBoxMatUnit.SelectedValue;
                        String shortDescription = textBoxshortDescription.Text;
                        String description = richTextBoxMatDesc.Text;
                        
                        // Seguro manejo de la conversión de BorrowLimitDays
                        int borrowLimitDays = 0;
                        int.TryParse(textBoxBorrowLimitDays.Text, out borrowLimitDays);

                        // Añadiendo los parámetros al comando
                        command.Parameters.AddWithValue("@MaterialID", newMaterialId);
                        command.Parameters.AddWithValue("@MatType", matType);
                        command.Parameters.AddWithValue("@Unit", unit);
                        command.Parameters.AddWithValue("@BorrowDays", borrowLimitDays);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@shortDescription", shortDescription);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Material added successfully!");
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
