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
            this.vwMatCatGridView = new System.Windows.Forms.DataGridView();
            this.vwMaterialCatalogueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.techMateInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techMateInventoryDataSet = new TechMate_Inventory.TechMateInventoryDataSet();
            this.vwMaterialCatalogueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catMatTitle = new System.Windows.Forms.Label();
            this.vwMaterialCatalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwMaterialCatalogueTableAdapter = new TechMate_Inventory.TechMateInventoryDataSetTableAdapters.vwMaterialCatalogueTableAdapter();
            this.addNewMatBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwMatCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vwMatCatGridView
            // 
            this.vwMatCatGridView.AllowUserToAddRows = false;
            this.vwMatCatGridView.AllowUserToDeleteRows = false;
            this.vwMatCatGridView.AllowUserToResizeColumns = false;
            this.vwMatCatGridView.AllowUserToResizeRows = false;
            this.vwMatCatGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vwMatCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwMatCatGridView.Location = new System.Drawing.Point(16, 128);
            this.vwMatCatGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwMatCatGridView.Name = "vwMatCatGridView";
            this.vwMatCatGridView.ReadOnly = true;
            this.vwMatCatGridView.RowHeadersWidth = 51;
            this.vwMatCatGridView.RowTemplate.Height = 24;
            this.vwMatCatGridView.Size = new System.Drawing.Size(941, 312);
            this.vwMatCatGridView.TabIndex = 0;
            this.vwMatCatGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.catMatTitle.Location = new System.Drawing.Point(5, 84);
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
            this.addNewMatBtn.Location = new System.Drawing.Point(16, 15);
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
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Añadir nuevo material";
            // 
            // frmMatCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 900);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewMatBtn);
            this.Controls.Add(this.catMatTitle);
            this.Controls.Add(this.vwMatCatGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMatCatalogue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Catálogo de materiales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMatCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwMatCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMaterialCatalogueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vwMatCatGridView;
        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.BindingSource techMateInventoryDataSetBindingSource;
        private TechMateInventoryDataSet techMateInventoryDataSet;
        private System.Windows.Forms.BindingSource vwMaterialCatalogueBindingSource;
        private TechMateInventoryDataSetTableAdapters.vwMaterialCatalogueTableAdapter vwMaterialCatalogueTableAdapter;
        private System.Windows.Forms.BindingSource vwMaterialCatalogueBindingSource1;
        private System.Windows.Forms.Button addNewMatBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vwMaterialCatalogueBindingSource2;
    }
}