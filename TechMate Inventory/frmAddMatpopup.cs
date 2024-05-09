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

namespace TechMate_Inventory
{
    public partial class frmAddMatpopup : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["TechMate_Inventory.Properties.Settings.TechMateInventoryConnectionString"].ConnectionString;
        public frmAddMatpopup()
        {
            InitializeComponent();  // Esto inicializa todos los controles del formulario
            LoadDataIntoComboBox();
        }

        private void frmAddMatpopup_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'techMateInventoryDataSet.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.techMateInventoryDataSet.Categories);

            // Asegúrate que esta línea está después de InitializeComponent();
            LoadDataIntoComboBox();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.FillBy(this.techMateInventoryDataSet.Categories);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                    string MatTypequery = "SELECT ID_MatType, Name FROM MatTypes";

                    SqlDataAdapter Catadapter = new SqlDataAdapter(Catquery, connection);
                    SqlDataAdapter MatTypeAdapter = new SqlDataAdapter(MatTypequery, connection);

                    DataTable categoriesName = new DataTable();
                    DataTable matTypeName = new DataTable();

                    Catadapter.Fill(categoriesName);
                    MatTypeAdapter.Fill(matTypeName);

                    // Asignar DataTable como DataSource del ComboBox.
                    comboBoxCategories.DataSource = categoriesName;
                    comboBoxMatTypes.DataSource = matTypeName;

                    // Configurar DisplayMember y ValueMember.
                    comboBoxCategories.DisplayMember = "Name";  // Columna para mostrar en el ComboBox.
                    comboBoxCategories.ValueMember = "ID_Category";  // Columna como valor que representa los items.

                    // Configurar DisplayMember y ValueMember.
                    comboBoxMatTypes.DisplayMember = "Name";  // Columna para mostrar en el ComboBox.
                    comboBoxMatTypes.ValueMember = "ID_MatType";  // Columna como valor que representa los items.

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
        }


        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
