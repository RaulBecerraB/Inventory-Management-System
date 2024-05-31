﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public frmStore(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            frmGeneralInventory frmInventory = new frmGeneralInventory(connectionString);
            frmInventory.LoadInventoryView(vwInventoryGridView);

            Program.AddButtonToGridView(vwInventoryGridView,"+","Add",45);
            //Program.AddTextBoxToGridView(vwInventoryGridView,"Cantidad","quantity");
            Program.AddCounterToGridView(vwInventoryGridView, "Cantidad","Quantity",0);
            Program.AddButtonToGridView(vwInventoryGridView,"-","Remove", 45);
            Program.AddButtonToGridView(vwInventoryGridView, "Añadir\n al carrito", "Add to cart",120);
        }

    }
}
