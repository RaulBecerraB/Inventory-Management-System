namespace TechMate_Inventory
{
    partial class frmNewMovement
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
            this.textBoxBorrowLimitDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMatUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMatTypes = new System.Windows.Forms.ComboBox();
            this.richTextBoxMatDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBorrowLimitDays
            // 
            this.textBoxBorrowLimitDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorrowLimitDays.Location = new System.Drawing.Point(227, 154);
            this.textBoxBorrowLimitDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBorrowLimitDays.Name = "textBoxBorrowLimitDays";
            this.textBoxBorrowLimitDays.Size = new System.Drawing.Size(155, 28);
            this.textBoxBorrowLimitDays.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo de movimiento";
            // 
            // comboBoxMatUnit
            // 
            this.comboBoxMatUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatUnit.FormattingEnabled = true;
            this.comboBoxMatUnit.Location = new System.Drawing.Point(29, 154);
            this.comboBoxMatUnit.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMatUnit.Name = "comboBoxMatUnit";
            this.comboBoxMatUnit.Size = new System.Drawing.Size(155, 30);
            this.comboBoxMatUnit.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Material";
            // 
            // comboBoxMatTypes
            // 
            this.comboBoxMatTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatTypes.FormattingEnabled = true;
            this.comboBoxMatTypes.Location = new System.Drawing.Point(28, 90);
            this.comboBoxMatTypes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMatTypes.Name = "comboBoxMatTypes";
            this.comboBoxMatTypes.Size = new System.Drawing.Size(354, 30);
            this.comboBoxMatTypes.TabIndex = 21;
            // 
            // richTextBoxMatDesc
            // 
            this.richTextBoxMatDesc.Location = new System.Drawing.Point(28, 221);
            this.richTextBoxMatDesc.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxMatDesc.MaxLength = 150;
            this.richTextBoxMatDesc.Name = "richTextBoxMatDesc";
            this.richTextBoxMatDesc.Size = new System.Drawing.Size(354, 79);
            this.richTextBoxMatDesc.TabIndex = 20;
            this.richTextBoxMatDesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Comentario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nuevo movimiento";
            // 
            // frmNewMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 322);
            this.Controls.Add(this.textBoxBorrowLimitDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMatUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMatTypes);
            this.Controls.Add(this.richTextBoxMatDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewMovement";
            this.Text = "frmNewMovement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBorrowLimitDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMatUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMatTypes;
        private System.Windows.Forms.RichTextBox richTextBoxMatDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}