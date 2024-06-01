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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.catMatTitle = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.vwCartGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.comboBoxStudents.DisplayMember = "hola";
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(103, 137);
            this.comboBoxStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(374, 37);
            this.comboBoxStudents.TabIndex = 9;
            this.comboBoxStudents.ValueMember = "hola";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vwCartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwCartGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vwCartGridView.Location = new System.Drawing.Point(564, 137);
            this.vwCartGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwCartGridView.Name = "vwCartGridView";
            this.vwCartGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwCartGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vwCartGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.NullValue = "(Ninguno)";
            this.vwCartGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.pictureBox2.Size = new System.Drawing.Size(374, 341);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 970);
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
    }
}