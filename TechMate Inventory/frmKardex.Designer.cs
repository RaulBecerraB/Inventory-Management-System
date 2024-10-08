﻿using InventoryManagement;

namespace TechMate_Inventory
{
    partial class frmKardex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKardex));
            this.techMateInventoryDataSet = new TechMate_Inventory.TechMateInventoryDataSet();
            this.techMateInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catMatTitle = new System.Windows.Forms.Label();
            this.vwKardexGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewMatBtn = new System.Windows.Forms.Button();
            this.SearchBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwKardexGridView)).BeginInit();
            this.SearchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // techMateInventoryDataSet
            // 
            this.techMateInventoryDataSet.DataSetName = "TechMateInventoryDataSet";
            this.techMateInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techMateInventoryDataSetBindingSource
            // 
            this.techMateInventoryDataSetBindingSource.DataSource = this.techMateInventoryDataSet;
            this.techMateInventoryDataSetBindingSource.Position = 0;
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(97, 81);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 2;
            this.catMatTitle.Text = "Movimientos";
            // 
            // vwKardexGridView
            // 
            this.vwKardexGridView.AllowUserToAddRows = false;
            this.vwKardexGridView.AllowUserToDeleteRows = false;
            this.vwKardexGridView.AllowUserToResizeColumns = false;
            this.vwKardexGridView.AllowUserToResizeRows = false;
            this.vwKardexGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwKardexGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwKardexGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vwKardexGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwKardexGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vwKardexGridView.Location = new System.Drawing.Point(103, 152);
            this.vwKardexGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwKardexGridView.Name = "vwKardexGridView";
            this.vwKardexGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwKardexGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vwKardexGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.NullValue = "(Ninguno)";
            this.vwKardexGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.vwKardexGridView.RowTemplate.Height = 32;
            this.vwKardexGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwKardexGridView.Size = new System.Drawing.Size(1300, 338);
            this.vwKardexGridView.TabIndex = 5;
            this.vwKardexGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwKardexGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nuevo movimiento";
            this.label1.Visible = false;
            // 
            // addNewMatBtn
            // 
            this.addNewMatBtn.AutoSize = true;
            this.addNewMatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewMatBtn.BackgroundImage")));
            this.addNewMatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewMatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMatBtn.Location = new System.Drawing.Point(625, 75);
            this.addNewMatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewMatBtn.Name = "addNewMatBtn";
            this.addNewMatBtn.Size = new System.Drawing.Size(53, 49);
            this.addNewMatBtn.TabIndex = 6;
            this.addNewMatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewMatBtn.UseVisualStyleBackColor = true;
            this.addNewMatBtn.Visible = false;
            this.addNewMatBtn.Click += new System.EventHandler(this.addNewMatBtn_Click);
            // 
            // SearchBarPanel
            // 
            this.SearchBarPanel.Controls.Add(this.pictureBox1);
            this.SearchBarPanel.Controls.Add(this.SearchBar);
            this.SearchBarPanel.Location = new System.Drawing.Point(833, 81);
            this.SearchBarPanel.Name = "SearchBarPanel";
            this.SearchBarPanel.Size = new System.Drawing.Size(570, 42);
            this.SearchBarPanel.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.Window;
            this.SearchBar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchBar.Location = new System.Drawing.Point(14, 4);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(553, 30);
            this.SearchBar.TabIndex = 10;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Comentario:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.commentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTextBox.Location = new System.Drawing.Point(103, 582);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ReadOnly = true;
            this.commentTextBox.Size = new System.Drawing.Size(1300, 84);
            this.commentTextBox.TabIndex = 16;
            this.commentTextBox.Text = "";
            // 
            // frmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1775, 913);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.SearchBarPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewMatBtn);
            this.Controls.Add(this.vwKardexGridView);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKardex";
            this.Text = "frmKardex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwKardexGridView)).EndInit();
            this.SearchBarPanel.ResumeLayout(false);
            this.SearchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TechMateInventoryDataSet techMateInventoryDataSet;
        private System.Windows.Forms.BindingSource techMateInventoryDataSetBindingSource;
        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.DataGridView vwKardexGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewMatBtn;
        private System.Windows.Forms.Panel SearchBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox commentTextBox;
    }
}