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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vwMatCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatCatGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vwMatCatGridView.Location = new System.Drawing.Point(35, 129);
            this.vwMatCatGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatCatGridView.Name = "vwMatCatGridView";
            this.vwMatCatGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatCatGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vwMatCatGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.NullValue = "(Ninguno)";
            this.vwMatCatGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vwCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwCategoriesGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.vwCategoriesGridView.Location = new System.Drawing.Point(35, 580);
            this.vwCategoriesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwCategoriesGridView.Name = "vwCategoriesGridView";
            this.vwCategoriesGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.vwCategoriesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.NullValue = "(Ninguno)";
            this.vwCategoriesGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.vwCategoriesGridView.RowTemplate.Height = 32;
            this.vwCategoriesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCategoriesGridView.Size = new System.Drawing.Size(427, 338);
            this.vwCategoriesGridView.TabIndex = 7;
            this.vwCategoriesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwCategoriesGridView_CellClick);
            this.vwCategoriesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwCategoriesGridView_CellDoubleClick);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatTypesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.vwMatTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatTypesGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.vwMatTypesGridView.Location = new System.Drawing.Point(501, 580);
            this.vwMatTypesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatTypesGridView.Name = "vwMatTypesGridView";
            this.vwMatTypesGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatTypesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.vwMatTypesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.NullValue = "(Ninguno)";
            this.vwMatTypesGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatUnitsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.vwMatUnitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwMatUnitsGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.vwMatUnitsGridView.Location = new System.Drawing.Point(1117, 580);
            this.vwMatUnitsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatUnitsGridView.Name = "vwMatUnitsGridView";
            this.vwMatUnitsGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatUnitsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.vwMatUnitsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.NullValue = "(Ninguno)";
            this.vwMatUnitsGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.vwMatUnitsGridView.RowTemplate.Height = 32;
            this.vwMatUnitsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwMatUnitsGridView.Size = new System.Drawing.Size(427, 338);
            this.vwMatUnitsGridView.TabIndex = 14;
            this.vwMatUnitsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatUnitsGridView_CellClick);
            this.vwMatUnitsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwMatUnitsGridView_CellDoubleClick);
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