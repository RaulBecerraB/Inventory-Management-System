namespace TechMate_Inventory
{
    partial class frmMatCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatCatalogue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vwMaterialCatalogueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.techMateInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techMateInventoryDataSet = new TechMate_Inventory.TechMateInventoryDataSet();
            this.vwMaterialCatalogueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catMatTitle = new System.Windows.Forms.Label();
            this.vwMaterialCatalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwMaterialCatalogueTableAdapter = new TechMate_Inventory.TechMateInventoryDataSetTableAdapters.vwMaterialCatalogueTableAdapter();
            this.addNewMatBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vwMatCatGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewCatBtn = new System.Windows.Forms.Button();
            this.vwCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vwMaterialCatalogueBindingSource2
            // 
            this.vwMaterialCatalogueBindingSource2.DataMember = "vwMaterialCatalogue";
            this.vwMaterialCatalogueBindingSource2.DataSource = this.techMateInventoryDataSetBindingSource;
            // 
            // techMateInventoryDataSetBindingSource
            // 
            this.techMateInventoryDataSetBindingSource.DataSource = this.techMateInventoryDataSet;
            this.techMateInventoryDataSetBindingSource.Position = 0;
            // 
            // techMateInventoryDataSet
            // 
            this.techMateInventoryDataSet.DataSetName = "TechMateInventoryDataSet";
            this.techMateInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwMaterialCatalogueBindingSource1
            // 
            this.vwMaterialCatalogueBindingSource1.DataMember = "vwMaterialCatalogue";
            this.vwMaterialCatalogueBindingSource1.DataSource = this.techMateInventoryDataSetBindingSource;
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(28, 84);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 1;
            this.catMatTitle.Text = "Catálogo de materiales";
            this.catMatTitle.Click += new System.EventHandler(this.catMatTitle_Click);
            // 
            // vwMaterialCatalogueBindingSource
            // 
            this.vwMaterialCatalogueBindingSource.DataMember = "vwMaterialCatalogue";
            this.vwMaterialCatalogueBindingSource.DataSource = this.techMateInventoryDataSetBindingSource;
            // 
            // vwMaterialCatalogueTableAdapter
            // 
            this.vwMaterialCatalogueTableAdapter.ClearBeforeFill = true;
            // 
            // addNewMatBtn
            // 
            this.addNewMatBtn.AutoSize = true;
            this.addNewMatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewMatBtn.BackgroundImage")));
            this.addNewMatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewMatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMatBtn.Location = new System.Drawing.Point(35, 21);
            this.addNewMatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewMatBtn.Name = "addNewMatBtn";
            this.addNewMatBtn.Size = new System.Drawing.Size(53, 49);
            this.addNewMatBtn.TabIndex = 2;
            this.addNewMatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewMatBtn.UseVisualStyleBackColor = true;
            this.addNewMatBtn.Click += new System.EventHandler(this.addNewMatBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Añadir nuevo material";
            // 
            // vwMatCatGridView
            // 
            this.vwMatCatGridView.AllowUserToAddRows = false;
            this.vwMatCatGridView.AllowUserToDeleteRows = false;
            this.vwMatCatGridView.AllowUserToResizeColumns = false;
            this.vwMatCatGridView.AllowUserToResizeRows = false;
            this.vwMatCatGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwMatCatGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.vwMatCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatCatGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.vwMatCatGridView.Location = new System.Drawing.Point(34, 129);
            this.vwMatCatGridView.Name = "vwMatCatGridView";
            this.vwMatCatGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.vwMatCatGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.NullValue = "(Ninguno)";
            this.vwMatCatGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.vwMatCatGridView.RowTemplate.Height = 32;
            this.vwMatCatGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.Size = new System.Drawing.Size(1510, 339);
            this.vwMatCatGridView.TabIndex = 4;
            this.vwMatCatGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatCatGridView_CellClick);
            this.vwMatCatGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatCatGridView_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 778);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Añadir nueva categoría";
            // 
            // addNewCatBtn
            // 
            this.addNewCatBtn.AutoSize = true;
            this.addNewCatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewCatBtn.BackgroundImage")));
            this.addNewCatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCatBtn.Location = new System.Drawing.Point(408, 485);
            this.addNewCatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewCatBtn.Name = "addNewCatBtn";
            this.addNewCatBtn.Size = new System.Drawing.Size(53, 49);
            this.addNewCatBtn.TabIndex = 5;
            this.addNewCatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewCatBtn.UseVisualStyleBackColor = true;
            this.addNewCatBtn.Click += new System.EventHandler(this.addNewCatBtn_Click);
            // 
            // vwCategoriesGridView
            // 
            this.vwCategoriesGridView.AllowUserToAddRows = false;
            this.vwCategoriesGridView.AllowUserToDeleteRows = false;
            this.vwCategoriesGridView.AllowUserToResizeColumns = false;
            this.vwCategoriesGridView.AllowUserToResizeRows = false;
            this.vwCategoriesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwCategoriesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.vwCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwCategoriesGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.vwCategoriesGridView.Location = new System.Drawing.Point(34, 547);
            this.vwCategoriesGridView.Name = "vwCategoriesGridView";
            this.vwCategoriesGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.vwCategoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.NullValue = "(Ninguno)";
            this.vwCategoriesGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.vwCategoriesGridView.RowTemplate.Height = 32;
            this.vwCategoriesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.Size = new System.Drawing.Size(427, 339);
            this.vwCategoriesGridView.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categorías";
            // 
            // frmMatCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1065);
            this.ControlBox = false;
            this.Controls.Add(this.addNewCatBtn);
            this.Controls.Add(this.vwCategoriesGridView);
            this.Controls.Add(this.vwMatCatGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewMatBtn);
            this.Controls.Add(this.catMatTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMatCatalogue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Catálogo de materiales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMatCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.BindingSource techMateInventoryDataSetBindingSource;
        private TechMateInventoryDataSet techMateInventoryDataSet;
        private System.Windows.Forms.BindingSource vwMaterialCatalogueBindingSource;
        private TechMateInventoryDataSetTableAdapters.vwMaterialCatalogueTableAdapter vwMaterialCatalogueTableAdapter;
        private System.Windows.Forms.BindingSource vwMaterialCatalogueBindingSource1;
        private System.Windows.Forms.Button addNewMatBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vwMaterialCatalogueBindingSource2;
        private System.Windows.Forms.DataGridView vwMatCatGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewCatBtn;
        private System.Windows.Forms.DataGridView vwCategoriesGridView;
        private System.Windows.Forms.Label label3;
    }
}