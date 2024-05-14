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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.addNewCatBtn = new System.Windows.Forms.Button();
            this.vwCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.vwMatTypesGridView = new System.Windows.Forms.DataGridView();
            this.addNewTypeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewUnitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.vwMatUnitsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatTypesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatUnitsGridView)).BeginInit();
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
            this.addNewMatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.vwMatCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatCatGridView.DefaultCellStyle = dataGridViewCellStyle34;
            this.vwMatCatGridView.Location = new System.Drawing.Point(35, 129);
            this.vwMatCatGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatCatGridView.Name = "vwMatCatGridView";
            this.vwMatCatGridView.ReadOnly = true;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.vwMatCatGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle36.NullValue = "(Ninguno)";
            this.vwMatCatGridView.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.vwMatCatGridView.RowTemplate.Height = 32;
            this.vwMatCatGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.Size = new System.Drawing.Size(1509, 338);
            this.vwMatCatGridView.TabIndex = 4;
            this.vwMatCatGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatCatGridView_CellClick);
            this.vwMatCatGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatCatGridView_CellDoubleClick);
            // 
            // addNewCatBtn
            // 
            this.addNewCatBtn.AutoSize = true;
            this.addNewCatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewCatBtn.BackgroundImage")));
            this.addNewCatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCatBtn.Location = new System.Drawing.Point(35, 501);
            this.addNewCatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.vwCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwCategoriesGridView.DefaultCellStyle = dataGridViewCellStyle38;
            this.vwCategoriesGridView.Location = new System.Drawing.Point(35, 580);
            this.vwCategoriesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwCategoriesGridView.Name = "vwCategoriesGridView";
            this.vwCategoriesGridView.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.vwCategoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle40.NullValue = "(Ninguno)";
            this.vwCategoriesGridView.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.vwCategoriesGridView.RowTemplate.Height = 32;
            this.vwCategoriesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.Size = new System.Drawing.Size(427, 338);
            this.vwCategoriesGridView.TabIndex = 7;
            this.vwCategoriesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwCategoriesGridView_CellClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categorías";
            // 
            // vwMatTypesGridView
            // 
            this.vwMatTypesGridView.AllowUserToAddRows = false;
            this.vwMatTypesGridView.AllowUserToDeleteRows = false;
            this.vwMatTypesGridView.AllowUserToResizeColumns = false;
            this.vwMatTypesGridView.AllowUserToResizeRows = false;
            this.vwMatTypesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwMatTypesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatTypesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.vwMatTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatTypesGridView.DefaultCellStyle = dataGridViewCellStyle42;
            this.vwMatTypesGridView.Location = new System.Drawing.Point(501, 580);
            this.vwMatTypesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatTypesGridView.Name = "vwMatTypesGridView";
            this.vwMatTypesGridView.ReadOnly = true;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatTypesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.vwMatTypesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle44.NullValue = "(Ninguno)";
            this.vwMatTypesGridView.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.vwMatTypesGridView.RowTemplate.Height = 32;
            this.vwMatTypesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatTypesGridView.Size = new System.Drawing.Size(579, 338);
            this.vwMatTypesGridView.TabIndex = 9;
            this.vwMatTypesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatTypesGridView_CellClick);
            this.vwMatTypesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatTypesGridView_CellDoubleClick);
            // 
            // addNewTypeBtn
            // 
            this.addNewTypeBtn.AutoSize = true;
            this.addNewTypeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewTypeBtn.BackgroundImage")));
            this.addNewTypeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTypeBtn.Location = new System.Drawing.Point(503, 502);
            this.addNewTypeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewTypeBtn.Name = "addNewTypeBtn";
            this.addNewTypeBtn.Size = new System.Drawing.Size(53, 49);
            this.addNewTypeBtn.TabIndex = 10;
            this.addNewTypeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewTypeBtn.UseVisualStyleBackColor = true;
            this.addNewTypeBtn.Click += new System.EventHandler(this.addNewTypeBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipos";
            // 
            // addNewUnitBtn
            // 
            this.addNewUnitBtn.AutoSize = true;
            this.addNewUnitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewUnitBtn.BackgroundImage")));
            this.addNewUnitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewUnitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUnitBtn.Location = new System.Drawing.Point(1119, 503);
            this.addNewUnitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewUnitBtn.Name = "addNewUnitBtn";
            this.addNewUnitBtn.Size = new System.Drawing.Size(53, 49);
            this.addNewUnitBtn.TabIndex = 12;
            this.addNewUnitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewUnitBtn.UseVisualStyleBackColor = true;
            this.addNewUnitBtn.Click += new System.EventHandler(this.addNewUnitBtn_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1177, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unidades de medida";
            // 
            // vwMatUnitsGridView
            // 
            this.vwMatUnitsGridView.AllowUserToAddRows = false;
            this.vwMatUnitsGridView.AllowUserToDeleteRows = false;
            this.vwMatUnitsGridView.AllowUserToResizeColumns = false;
            this.vwMatUnitsGridView.AllowUserToResizeRows = false;
            this.vwMatUnitsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwMatUnitsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatUnitsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.vwMatUnitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatUnitsGridView.DefaultCellStyle = dataGridViewCellStyle46;
            this.vwMatUnitsGridView.Location = new System.Drawing.Point(1117, 580);
            this.vwMatUnitsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatUnitsGridView.Name = "vwMatUnitsGridView";
            this.vwMatUnitsGridView.ReadOnly = true;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatUnitsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.vwMatUnitsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle48.NullValue = "(Ninguno)";
            this.vwMatUnitsGridView.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.vwMatUnitsGridView.RowTemplate.Height = 32;
            this.vwMatUnitsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatUnitsGridView.Size = new System.Drawing.Size(427, 338);
            this.vwMatUnitsGridView.TabIndex = 14;
            this.vwMatUnitsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatUnitsGridView_CellClick);
            // 
            // frmMatCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1556, 1065);
            this.ControlBox = false;
            this.Controls.Add(this.vwMatUnitsGridView);
            this.Controls.Add(this.addNewUnitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addNewTypeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vwMatTypesGridView);
            this.Controls.Add(this.addNewCatBtn);
            this.Controls.Add(this.vwCategoriesGridView);
            this.Controls.Add(this.vwMatCatGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewMatBtn);
            this.Controls.Add(this.catMatTitle);
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
            ((System.ComponentModel.ISupportInitialize)(this.vwMatTypesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatUnitsGridView)).EndInit();
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
        private System.Windows.Forms.Button addNewCatBtn;
        private System.Windows.Forms.DataGridView vwCategoriesGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView vwMatTypesGridView;
        private System.Windows.Forms.Button addNewTypeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewUnitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView vwMatUnitsGridView;
    }
}