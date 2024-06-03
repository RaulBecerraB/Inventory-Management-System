namespace TechMate_Inventory
{
    partial class frmCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.catMatTitle = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.vwCartGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.CreateBorrowingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vwCartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(97, 81);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 8;
            this.catMatTitle.Text = "Seleccionar alumno:";
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(103, 137);
            this.comboBoxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(374, 37);
            this.comboBoxStudents.TabIndex = 9;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);
            // 
            // vwCartGridView
            // 
            this.vwCartGridView.AllowUserToAddRows = false;
            this.vwCartGridView.AllowUserToDeleteRows = false;
            this.vwCartGridView.AllowUserToResizeColumns = false;
            this.vwCartGridView.AllowUserToResizeRows = false;
            this.vwCartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwCartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.vwCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwCartGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.vwCartGridView.Location = new System.Drawing.Point(564, 137);
            this.vwCartGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwCartGridView.Name = "vwCartGridView";
            this.vwCartGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCartGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.vwCartGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.NullValue = "(Ninguno)";
            this.vwCartGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.vwCartGridView.RowTemplate.Height = 32;
            this.vwCartGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCartGridView.Size = new System.Drawing.Size(850, 421);
            this.vwCartGridView.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Carrito del alumno:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(103, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(374, 353);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCart.Location = new System.Drawing.Point(1200, 587);
            this.btnDeleteCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(214, 93);
            this.btnDeleteCart.TabIndex = 13;
            this.btnDeleteCart.Text = "Borrar carrito";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // CreateBorrowingBtn
            // 
            this.CreateBorrowingBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBorrowingBtn.Location = new System.Drawing.Point(913, 587);
            this.CreateBorrowingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBorrowingBtn.Name = "CreateBorrowingBtn";
            this.CreateBorrowingBtn.Size = new System.Drawing.Size(259, 93);
            this.CreateBorrowingBtn.TabIndex = 14;
            this.CreateBorrowingBtn.Text = "Realizar préstamo";
            this.CreateBorrowingBtn.UseVisualStyleBackColor = true;
            this.CreateBorrowingBtn.Click += new System.EventHandler(this.CreateBorrowingBtn_Click);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 970);
            this.Controls.Add(this.CreateBorrowingBtn);
            this.Controls.Add(this.btnDeleteCart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vwCartGridView);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCart";
            this.Text = "frmCart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwCartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.DataGridView vwCartGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDeleteCart;
        private System.Windows.Forms.Button CreateBorrowingBtn;
    }
}