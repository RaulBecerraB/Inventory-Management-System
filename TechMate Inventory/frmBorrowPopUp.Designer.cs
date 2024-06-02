namespace TechMate_Inventory
{
    partial class frmBorrowPopUp
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
            this.catMatTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MaterialDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BorrowingStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.btnCancelBorrowing = new System.Windows.Forms.Button();
            this.ConfirmReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(66, 45);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 8;
            this.catMatTitle.Text = "Datos del estudiante:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material prestado";
            // 
            // StudentDataRichTextBox
            // 
            this.StudentDataRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.StudentDataRichTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDataRichTextBox.Location = new System.Drawing.Point(72, 104);
            this.StudentDataRichTextBox.Name = "StudentDataRichTextBox";
            this.StudentDataRichTextBox.ReadOnly = true;
            this.StudentDataRichTextBox.Size = new System.Drawing.Size(481, 286);
            this.StudentDataRichTextBox.TabIndex = 11;
            this.StudentDataRichTextBox.Text = "";
            // 
            // MaterialDataRichTextBox
            // 
            this.MaterialDataRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MaterialDataRichTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialDataRichTextBox.Location = new System.Drawing.Point(628, 104);
            this.MaterialDataRichTextBox.Name = "MaterialDataRichTextBox";
            this.MaterialDataRichTextBox.ReadOnly = true;
            this.MaterialDataRichTextBox.Size = new System.Drawing.Size(481, 286);
            this.MaterialDataRichTextBox.TabIndex = 12;
            this.MaterialDataRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado del préstamo:";
            // 
            // BorrowingStatusTextBox
            // 
            this.BorrowingStatusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BorrowingStatusTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowingStatusTextBox.Location = new System.Drawing.Point(72, 468);
            this.BorrowingStatusTextBox.Name = "BorrowingStatusTextBox";
            this.BorrowingStatusTextBox.ReadOnly = true;
            this.BorrowingStatusTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BorrowingStatusTextBox.Size = new System.Drawing.Size(481, 72);
            this.BorrowingStatusTextBox.TabIndex = 14;
            this.BorrowingStatusTextBox.Text = "";
            // 
            // btnCancelBorrowing
            // 
            this.btnCancelBorrowing.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBorrowing.Location = new System.Drawing.Point(628, 468);
            this.btnCancelBorrowing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBorrowing.Name = "btnCancelBorrowing";
            this.btnCancelBorrowing.Size = new System.Drawing.Size(214, 91);
            this.btnCancelBorrowing.TabIndex = 15;
            this.btnCancelBorrowing.Text = "Cancelar préstamo";
            this.btnCancelBorrowing.UseVisualStyleBackColor = true;
            this.btnCancelBorrowing.Click += new System.EventHandler(this.btnCancelBorrowing_Click);
            // 
            // ConfirmReturnBtn
            // 
            this.ConfirmReturnBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmReturnBtn.Location = new System.Drawing.Point(895, 468);
            this.ConfirmReturnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmReturnBtn.Name = "ConfirmReturnBtn";
            this.ConfirmReturnBtn.Size = new System.Drawing.Size(214, 91);
            this.ConfirmReturnBtn.TabIndex = 16;
            this.ConfirmReturnBtn.Text = "Confirmar devolución";
            this.ConfirmReturnBtn.UseVisualStyleBackColor = true;
            this.ConfirmReturnBtn.Click += new System.EventHandler(this.ConfirmReturnBtn_Click);
            // 
            // frmBorrowPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 592);
            this.Controls.Add(this.ConfirmReturnBtn);
            this.Controls.Add(this.btnCancelBorrowing);
            this.Controls.Add(this.BorrowingStatusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaterialDataRichTextBox);
            this.Controls.Add(this.StudentDataRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catMatTitle);
            this.Name = "frmBorrowPopUp";
            this.Text = "frmBorrowPopUp";
            this.Load += new System.EventHandler(this.frmBorrowPopUp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox StudentDataRichTextBox;
        private System.Windows.Forms.RichTextBox MaterialDataRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox BorrowingStatusTextBox;
        private System.Windows.Forms.Button btnCancelBorrowing;
        private System.Windows.Forms.Button ConfirmReturnBtn;
    }
}