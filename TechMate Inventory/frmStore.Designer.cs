namespace TechMate_Inventory
{
    partial class frmStore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStore));
            this.catMatTitle = new System.Windows.Forms.Label();
            this.vwStoreGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.techMateInventoryDataSet = new TechMate_Inventory.TechMateInventoryDataSet();
            this.matUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matUnitsTableAdapter = new TechMate_Inventory.TechMateInventoryDataSetTableAdapters.MatUnitsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vwStoreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matUnitsBindingSource)).BeginInit();
            this.SearchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(97, 81);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 7;
            this.catMatTitle.Text = "Seleccionar materiales";
            // 
            // vwStoreGridView
            // 
            this.vwStoreGridView.AllowUserToAddRows = false;
            this.vwStoreGridView.AllowUserToDeleteRows = false;
            this.vwStoreGridView.AllowUserToResizeColumns = false;
            this.vwStoreGridView.AllowUserToResizeRows = false;
            this.vwStoreGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwStoreGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwStoreGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vwStoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwStoreGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.vwStoreGridView.Location = new System.Drawing.Point(103, 152);
            this.vwStoreGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwStoreGridView.Name = "vwStoreGridView";
            this.vwStoreGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwStoreGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.vwStoreGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.NullValue = "(Ninguno)";
            this.vwStoreGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.vwStoreGridView.RowTemplate.Height = 32;
            this.vwStoreGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwStoreGridView.Size = new System.Drawing.Size(1300, 338);
            this.vwStoreGridView.TabIndex = 8;
            this.vwStoreGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwInventoryGridView_CellClick);
            this.vwStoreGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.vwInventoryGridView_CellFormatting);
            this.vwStoreGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.vwStoreGridView_CellValidating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(103, 587);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(1300, 84);
            this.DescriptionTextBox.TabIndex = 10;
            this.DescriptionTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripción";
            // 
            // techMateInventoryDataSet
            // 
            this.techMateInventoryDataSet.DataSetName = "TechMateInventoryDataSet";
            this.techMateInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matUnitsBindingSource
            // 
            this.matUnitsBindingSource.DataMember = "MatUnits";
            this.matUnitsBindingSource.DataSource = this.techMateInventoryDataSet;
            // 
            // matUnitsTableAdapter
            // 
            this.matUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccionar materiales";
            this.label2.Visible = false;
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
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1535, 1017);
            this.Controls.Add(this.SearchBarPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.vwStoreGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStore";
            this.ShowIcon = false;
            this.Text = "TIENDA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwStoreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matUnitsBindingSource)).EndInit();
            this.SearchBarPanel.ResumeLayout(false);
            this.SearchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.DataGridView vwStoreGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private TechMateInventoryDataSet techMateInventoryDataSet;
        private System.Windows.Forms.BindingSource matUnitsBindingSource;
        private TechMateInventoryDataSetTableAdapters.MatUnitsTableAdapter matUnitsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SearchBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBar;
    }
}