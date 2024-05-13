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
using System.Configuration;
using TechMate_Inventory.TechMateInventoryDataSetTableAdapters;
using System.Data.Common;


namespace TechMate_Inventory
{
    public partial class frmMatCatalogue : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["TechMate_Inventory.Properties.Settings.TechMateInventoryConnectionString"].ConnectionString;
        public int selectedIndex = 0;
        public frmMatCatalogue()
        {
            InitializeComponent();
        }

        private void frmMatCatalogue_Load(object sender, EventArgs e)
        {

            try
            {
                // Carga datos en la tabla 'techMateInventoryDataSet.vwMaterialCatalogue'
                this.vwMaterialCatalogueTableAdapter.Fill(this.techMateInventoryDataSet.vwMaterialCatalogue);

                // Llama a la función para cargar datos desde la vista
                LoadDataFromView();
                LoadLowerTables();

                AddDeleteButtonColumn();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error al usuario con información sobre la excepción
                MessageBox.Show("Error al cargar el catálogo de materiales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Puedes registrar el error si es necesario
                // LogException(ex); // Si tienes un mecanismo de registro de errores

                // Puedes realizar acciones adicionales para manejar el error, como detener el proceso o limpiar recursos
            }

        }

        // Función genérica para eliminar un item de cualquier tabla
        private void DeleteItem(string tableName, string idColumn, int itemId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"DELETE FROM {tableName} WHERE {idColumn} = @ItemId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ItemId", itemId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo eliminar el item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LoadDataFromView()
        {
            //MessageBox.Show(connectionString);
            string query = "-- Query para checar Materials\r\nSELECT \r\n    Materials.ID_Material,  -- ID del material\r\n\tMaterials.shortDescription,\r\n    Categories.Name AS Category,  -- Nombre de la categoría\r\n    MatTypes.Name AS MaterialType,  -- Nombre del tipo de material\r\n    MatUnits.Name AS UnitName,  -- Nombre de la unidad\r\n    Materials.BorrowLimitDays  -- Límite de días de préstamo\r\nFROM \r\n    Materials  -- Tabla principal\r\nLEFT JOIN \r\n    MatTypes \r\n    ON Materials.ID_MatType = MatTypes.ID_MatType  -- Unir con MatTypes por el tipo de material\r\nLEFT JOIN \r\n    Categories\r\n    ON MatTypes.ID_Category = Categories.ID_Category  -- Unir con Categories por la categoría del MatType\r\nLEFT JOIN \r\n    MatUnits \r\n    ON Materials.ID_Unit = MatUnits.ID_Unit  -- Unir con MatUnits por la unidad\r\n";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();          

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    vwMatCatGridView.DataSource = table;

                    // Opcionalmente configurar las cabeceras si es necesario

                    vwMatCatGridView.Columns["ID_Material"].HeaderText = "Índice";
                    vwMatCatGridView.Columns["shortDescription"].HeaderText = "Descripción corta";
                    vwMatCatGridView.Columns["Category"].HeaderText = "Categoría";
                    vwMatCatGridView.Columns["MaterialType"].HeaderText = "Tipo";
                    vwMatCatGridView.Columns["UnitName"].HeaderText = "Unidad";
                    vwMatCatGridView.Columns["BorrowLimitDays"].HeaderText = "Días máximos de préstamo";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cargando los MATERIALES: " + ex.Message);
                }
            }
        }
        public void LoadLowerTables()
        {
            string categoriesQuery = "SELECT * FROM Categories" ;
            string matTypesQuery = "SELECT ID_MatType,Name FROM MatTypes";
            string matUnitsQuery = "SELECT * FROM MatUnits";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand CategoriesCmd = new SqlCommand(categoriesQuery, connection);
                SqlCommand MatTypesCmd = new SqlCommand (matTypesQuery, connection);
                SqlCommand MatUnitsCmd = new SqlCommand(matUnitsQuery, connection);
                
                SqlDataAdapter Categoriesadapter = new SqlDataAdapter(CategoriesCmd);
                SqlDataAdapter MatTypesadapter = new SqlDataAdapter(MatTypesCmd);
                SqlDataAdapter MatUnitsadapter = new SqlDataAdapter(MatUnitsCmd);

                DataTable tableCategories = new DataTable();
                DataTable tableMatTypes = new DataTable();
                DataTable tableMatUnits = new DataTable();

                try
                {
                    connection.Open();

                    Categoriesadapter.Fill(tableCategories);
                    MatTypesadapter.Fill(tableMatTypes);
                    MatUnitsadapter.Fill(tableMatUnits);

                    vwCategoriesGridView.DataSource = tableCategories;
                    vwMatTypesGridView.DataSource = tableMatTypes;
                    vwMatUnitsGridView.DataSource = tableMatUnits;

                    //Renaming rows (READ ONLY)

                    vwCategoriesGridView.Columns["ID_Category"].HeaderText = "Índice";
                    vwCategoriesGridView.Columns["Name"].HeaderText = "Nombre";

                    vwMatTypesGridView.Columns["ID_MatType"].HeaderText = "Índice";
                    vwMatTypesGridView.Columns["Name"].HeaderText = "Nombre";

                    vwMatUnitsGridView.Columns["ID_Unit"].HeaderText = "Índice";
                    vwMatUnitsGridView.Columns["Name"].HeaderText = "Nombre";


                }
                catch (Exception ex)
                {
                    MessageBox.Show( " Error cargando las CATEGORÍAS: " + ex.Message);
                }
            }
        }
        private void AddDeleteButtonColumnToGridView(DataGridView gridView)
        {
            // Verifica si la columna ya existe para evitar duplicados
            if (!gridView.Columns.Contains("deleteColumn"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "deleteColumn";
                deleteButtonColumn.HeaderText = "";
                deleteButtonColumn.Text = "Borrar";
                deleteButtonColumn.UseColumnTextForButtonValue = true;  // Hace que el texto del botón sea el valor por defecto de la columna
                deleteButtonColumn.Width = 60;  // Ancho de la columna de botón

                // Añade la columna de botón al final de todas las columnas existentes
                gridView.Columns.Add(deleteButtonColumn);
            }
        }
        private void AddDeleteButtonColumn()
        {
            // Aplica el método refactorizado a cada DataGridView relevante
            AddDeleteButtonColumnToGridView(vwMatCatGridView);
            AddDeleteButtonColumnToGridView(vwCategoriesGridView);
            AddDeleteButtonColumnToGridView(vwMatUnitsGridView);
            AddDeleteButtonColumnToGridView(vwMatTypesGridView);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void catMatTitle_Click(object sender, EventArgs e)
        {

        }
        private void addNewMatBtn_Click(object sender, EventArgs e)
        {
            //THE CREATE MATERIAL
            frmAddMatpopup addMatpopup = new frmAddMatpopup(this,connectionString);
            addMatpopup.Show();
        }
        // Event handlers refactored to use DeleteItem
        private void vwMatCatGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == vwMatCatGridView.Columns["deleteColumn"].Index)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas borrar esta fila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int materialId = Convert.ToInt32(vwMatCatGridView.Rows[e.RowIndex].Cells["ID_Material"].Value);
                    DeleteItem("Materials", "ID_Material", materialId);
                    vwMatCatGridView.Rows.RemoveAt(e.RowIndex);  // Elimina la fila de la vista
                }
            }
        }
        private void vwMatCatGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //THE EDIT MATERIAL

            // Comprueba si el doble clic fue sobre una fila (y no en el área de encabezado)
            if (e.RowIndex >= 0)
            {
                // Aquí puedes acceder a la fila en la que se hizo doble clic
                DataGridViewRow clickedRow = vwMatCatGridView.Rows[e.RowIndex];

                Material_CRUD_PopUp1 editPopup = new Material_CRUD_PopUp1(this,connectionString);
                editPopup.intMaterialId = (int)clickedRow.Cells["ID_Material"].Value;
                editPopup.Show();

                // Por ejemplo, mostrar información de la fila
                //MessageBox.Show($"Doble clic en la fila con ID: {clickedRow.Cells["ID_Material"].Value.ToString()}");
                //selectedIndex = clickedRow.Cells["ID_Material"].Value;
            }
            
        }
        private void addNewCatBtn_Click(object sender, EventArgs e)
        {
            frmAddCatpopup addCatPoPup = new frmAddCatpopup(this, connectionString);
            addCatPoPup.Show();
        }
        private void vwCategoriesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == vwCategoriesGridView.Columns["deleteColumn"].Index)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas borrar esta fila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int categoryId = Convert.ToInt32(vwCategoriesGridView.Rows[e.RowIndex].Cells["ID_Category"].Value);
                    DeleteItem("Categories", "ID_Category", categoryId);
                    vwCategoriesGridView.Rows.RemoveAt(e.RowIndex);  // Elimina la fila de la vista
                }
            }
        }
        private void addNewTypeBtn_Click(object sender, EventArgs e)
        {
            frmAddMaterialTypepopup addMatTypePopUp = new frmAddMaterialTypepopup(this, connectionString);
            addMatTypePopUp.Show();
        }
        private void addNewUnitBtn_Click(object sender, EventArgs e)
        {
            frmAddUnitPopUp addUnitPopUp = new frmAddUnitPopUp(this, connectionString);
            addUnitPopUp.Show();
        }
        private void vwMatUnitsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == vwMatUnitsGridView.Columns["deleteColumn"].Index)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas borrar esta fila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int unitId = Convert.ToInt32(vwMatUnitsGridView.Rows[e.RowIndex].Cells["ID_Unit"].Value);
                    DeleteItem("MatUnits", "ID_Unit", unitId);
                    vwMatUnitsGridView.Rows.RemoveAt(e.RowIndex);  // Elimina la fila de la vista
                }
            }
        }

        private void vwMatTypesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == vwMatTypesGridView.Columns["deleteColumn"].Index)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas borrar esta fila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int unitId = Convert.ToInt32(vwMatTypesGridView.Rows[e.RowIndex].Cells["ID_MatType"].Value);
                    DeleteItem("MatTypes", "ID_MatType", unitId);
                    vwMatTypesGridView.Rows.RemoveAt(e.RowIndex);  // Elimina la fila de la vista
                }
            }
        }
    }
}
