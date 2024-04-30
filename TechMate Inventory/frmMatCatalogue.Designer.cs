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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.techMateInventoryDataSet = new TechMate_Inventory.TechMateInventoryDataSet();
            this.techMateInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new TechMate_Inventory.TechMateInventoryDataSetTableAdapters.MaterialsTableAdapter();
            this.iDMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowLimitDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMaterialDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.iDCategoryDataGridViewTextBoxColumn,
            this.iDMatTypeDataGridViewTextBoxColumn,
            this.iDUnitDataGridViewTextBoxColumn,
            this.borrowLimitDaysDataGridViewTextBoxColumn,
            this.unitValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.techMateInventoryDataSetBindingSource;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // iDMaterialDataGridViewTextBoxColumn
            // 
            this.iDMaterialDataGridViewTextBoxColumn.DataPropertyName = "ID_Material";
            this.iDMaterialDataGridViewTextBoxColumn.HeaderText = "ID_Material";
            this.iDMaterialDataGridViewTextBoxColumn.Name = "iDMaterialDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // iDCategoryDataGridViewTextBoxColumn
            // 
            this.iDCategoryDataGridViewTextBoxColumn.DataPropertyName = "ID_Category";
            this.iDCategoryDataGridViewTextBoxColumn.HeaderText = "ID_Category";
            this.iDCategoryDataGridViewTextBoxColumn.Name = "iDCategoryDataGridViewTextBoxColumn";
            // 
            // iDMatTypeDataGridViewTextBoxColumn
            // 
            this.iDMatTypeDataGridViewTextBoxColumn.DataPropertyName = "ID_MatType";
            this.iDMatTypeDataGridViewTextBoxColumn.HeaderText = "ID_MatType";
            this.iDMatTypeDataGridViewTextBoxColumn.Name = "iDMatTypeDataGridViewTextBoxColumn";
            // 
            // iDUnitDataGridViewTextBoxColumn
            // 
            this.iDUnitDataGridViewTextBoxColumn.DataPropertyName = "ID_Unit";
            this.iDUnitDataGridViewTextBoxColumn.HeaderText = "ID_Unit";
            this.iDUnitDataGridViewTextBoxColumn.Name = "iDUnitDataGridViewTextBoxColumn";
            // 
            // borrowLimitDaysDataGridViewTextBoxColumn
            // 
            this.borrowLimitDaysDataGridViewTextBoxColumn.DataPropertyName = "BorrowLimitDays";
            this.borrowLimitDaysDataGridViewTextBoxColumn.HeaderText = "BorrowLimitDays";
            this.borrowLimitDaysDataGridViewTextBoxColumn.Name = "borrowLimitDaysDataGridViewTextBoxColumn";
            // 
            // unitValueDataGridViewTextBoxColumn
            // 
            this.unitValueDataGridViewTextBoxColumn.DataPropertyName = "unitValue";
            this.unitValueDataGridViewTextBoxColumn.HeaderText = "unitValue";
            this.unitValueDataGridViewTextBoxColumn.Name = "unitValueDataGridViewTextBoxColumn";
            // 
            // frmMatCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMatCatalogue";
            this.Text = "frmMatCatalogue";
            this.Load += new System.EventHandler(this.frmMatCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource techMateInventoryDataSetBindingSource;
        private TechMateInventoryDataSet techMateInventoryDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TechMateInventoryDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowLimitDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitValueDataGridViewTextBoxColumn;
    }
}