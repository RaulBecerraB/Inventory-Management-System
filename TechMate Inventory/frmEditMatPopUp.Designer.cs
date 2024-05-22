namespace TechMate_Inventory
{
    partial class Material_CRUD_PopUp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techMateInventoryDataSet = new TechMate_Inventory.TechMateInventoryDataSet();
            this.techMateInventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new TechMate_Inventory.TechMateInventoryDataSetTableAdapters.CategoriesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMatDesc = new System.Windows.Forms.RichTextBox();
            this.comboBoxMatTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMatUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBorrowLimitDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxshortDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar material existente";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.techMateInventoryDataSet;
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
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción";
            // 
            // richTextBoxMatDesc
            // 
            this.richTextBoxMatDesc.Location = new System.Drawing.Point(31, 277);
            this.richTextBoxMatDesc.MaxLength = 150;
            this.richTextBoxMatDesc.Name = "richTextBoxMatDesc";
            this.richTextBoxMatDesc.Size = new System.Drawing.Size(724, 96);
            this.richTextBoxMatDesc.TabIndex = 10;
            this.richTextBoxMatDesc.Text = "";
            this.richTextBoxMatDesc.TextChanged += new System.EventHandler(this.richTextBoxMatDesc_TextChanged);
            // 
            // comboBoxMatTypes
            // 
            this.comboBoxMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatTypes.FormattingEnabled = true;
            this.comboBoxMatTypes.Location = new System.Drawing.Point(31, 116);
            this.comboBoxMatTypes.Name = "comboBoxMatTypes";
            this.comboBoxMatTypes.Size = new System.Drawing.Size(205, 37);
            this.comboBoxMatTypes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo";
            // 
            // comboBoxMatUnit
            // 
            this.comboBoxMatUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatUnit.FormattingEnabled = true;
            this.comboBoxMatUnit.Location = new System.Drawing.Point(275, 116);
            this.comboBoxMatUnit.Name = "comboBoxMatUnit";
            this.comboBoxMatUnit.Size = new System.Drawing.Size(205, 37);
            this.comboBoxMatUnit.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unidad";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(638, 388);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 50);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(515, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Días límite de préstamo";
            // 
            // textBoxBorrowLimitDays
            // 
            this.textBoxBorrowLimitDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorrowLimitDays.Location = new System.Drawing.Point(519, 119);
            this.textBoxBorrowLimitDays.Name = "textBoxBorrowLimitDays";
            this.textBoxBorrowLimitDays.Size = new System.Drawing.Size(205, 34);
            this.textBoxBorrowLimitDays.TabIndex = 6;
            this.textBoxBorrowLimitDays.TextChanged += new System.EventHandler(this.textBoxBorrowLimitDays_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripción CORTA";
            // 
            // textBoxshortDescription
            // 
            this.textBoxshortDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxshortDescription.Location = new System.Drawing.Point(31, 197);
            this.textBoxshortDescription.Name = "textBoxshortDescription";
            this.textBoxshortDescription.Size = new System.Drawing.Size(724, 34);
            this.textBoxshortDescription.TabIndex = 8;
            // 
            // Material_CRUD_PopUp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxshortDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBorrowLimitDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMatUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMatTypes);
            this.Controls.Add(this.richTextBoxMatDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Material_CRUD_PopUp1";
            this.Text = "frmEditMatPopUp";
            this.Load += new System.EventHandler(this.frmAddMatpopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techMateInventoryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource techMateInventoryDataSetBindingSource;
        private TechMateInventoryDataSet techMateInventoryDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private TechMateInventoryDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxMatDesc;
        private System.Windows.Forms.ComboBox comboBoxMatTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMatUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBorrowLimitDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxshortDescription;
    }
}