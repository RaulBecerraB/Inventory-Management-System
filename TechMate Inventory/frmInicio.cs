﻿using System;
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
    public partial class frmInicio : Form
    {
        public string connectionString;
        public frmInicio(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

    }
}
