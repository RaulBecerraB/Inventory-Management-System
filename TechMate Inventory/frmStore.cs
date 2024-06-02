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
    public partial class frmStore : Form
    {
        private string connectionString;
        public frmCart childCart;
        //Atributos para ESTE estudiante, usuario y material
        public string selectedStudent;
        public int userId;
        public int matId;
        public frmStore(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        public void frmStore_Load(object sender, EventArgs e)
        {
            frmGeneralInventory frmInventory = new frmGeneralInventory(connectionString);

            frmInventory.LoadInventoryView(vwStoreGridView);

            DGridViewCounter.AddButtonColumn(vwStoreGridView,"Increment","+");
            DGridViewCounter.AddCounterToGridView(vwStoreGridView, "Cantidad","Quantity",0);
            DGridViewCounter.AddButtonColumn(vwStoreGridView, "Decrement", "-");
            DGridViewCounter.AddButtonColumn(vwStoreGridView, "AddToCartBtn", "Añadir al carrito");

        }

        //This function is mostly for debugging
        public void UpdateLabel2()
        {
            label2.Text = selectedStudent;
        }

        private void vwInventoryGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si es la columna "Quantity"
            if (vwStoreGridView.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Si el valor es nulo, mostrar "0"
                if (e.Value == null)
                {
                    e.Value = "0";
                    e.FormattingApplied = true;
                }
                else
                {
                    // Asegurarse de que se muestre el valor actual
                    e.Value = e.Value.ToString();
                    e.FormattingApplied = true;
                }
            }
            // Reemplaza "ColumnName" con el nombre de la columna que deseas evaluar
            string columnName = "TotalQuantity";

            // Verifica si la celda actual pertenece a la columna que deseas cambiar
            if (vwStoreGridView.Columns[e.ColumnIndex].Name == columnName)
            {
                // Intenta obtener el valor de la celda como un número
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int cellValue))
                {
                    // Cambia el color de fondo a rojo si el valor es menor a 0
                    if (frmGeneralInventory.isNegative(cellValue))
                    {
                        frmGeneralInventory.changeCellTextColor(e, Color.Red);
                        e.Value = cellValue + " *"; // Concatenar un asterisco al valor
                    }
                    else
                    {
                        frmGeneralInventory.changeCellTextColor(e, Color.Black); // Restablece el color si no es menor a 0
                        e.Value = cellValue; // Asegura que el valor se muestre correctamente si no se cumple la condición
                    }
                }
            }
        }

        private void AddItemToCart(int userId, int matId, string selectedStudent, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Carts (ID_User, ID_Material, Matricula, quantity) VALUES (@userId, @matId, @selectedStudent, @quantity)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@matId", matId);
                    command.Parameters.AddWithValue("@selectedStudent", selectedStudent);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void RefreshStoreView()
        {
            frmGeneralInventory frmInventory = new frmGeneralInventory(connectionString);
            frmInventory.LoadInventoryView(vwStoreGridView);
        }
        private void vwInventoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda de tipo botón
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = vwStoreGridView.Rows[e.RowIndex];
                int currentValue = Convert.ToInt32(row.Cells["Quantity"].Value);

                // Incrementar o decrementar el valor según el botón presionado
                if (vwStoreGridView.Columns[e.ColumnIndex].Name == "Increment")
                {
                    row.Cells["Quantity"].Value = currentValue + 1;
                }
                else if (vwStoreGridView.Columns[e.ColumnIndex].Name == "Decrement" && currentValue > 0)
                {
                    row.Cells["Quantity"].Value = currentValue - 1;
                }
                else if (vwStoreGridView.Columns[e.ColumnIndex].Name == "AddToCartBtn")
                {
                    try
                    {
                        //Obtener parámetro faltante para ejcutar el query
                        matId = DGridViewRows.ReturnSelectedRowID(e, "ID_Material", vwStoreGridView);
                        //Ejecutar el query usando los valores globales
                        AddItemToCart(userId, matId, selectedStudent, currentValue);
                        MessageBox.Show("Añadido al carrito!");

                        childCart.LoadCartData(selectedStudent);
                    }
                    catch 
                    {
                        MessageBox.Show("El estudiante seleccionado no puede estar vacío.");
                    }
                    
                }

                // Refrescar el DataGridView después de actualizar los valores
                vwStoreGridView.Refresh();
            }
        }
    }
}
