namespace TechMate_Inventory
{
    partial class frmGeneralInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vwKardexGridView = new System.Windows.Forms.DataGridView();
            this.catMatTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwKardexGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vwKardexGridView
            // 
            this.vwKardexGridView.AllowUserToAddRows = false;
            this.vwKardexGridView.AllowUserToDeleteRows = false;
            this.vwKardexGridView.AllowUserToResizeColumns = false;
            this.vwKardexGridView.AllowUserToResizeRows = false;
            this.vwKardexGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwKardexGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwKardexGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vwKardexGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwKardexGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.vwKardexGridView.Location = new System.Drawing.Point(34, 90);
            this.vwKardexGridView.Margin = new System.Windows.Forms.Padding(2);
            this.vwKardexGridView.Name = "vwKardexGridView";
            this.vwKardexGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwKardexGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.vwKardexGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.NullValue = "(Ninguno)";
            this.vwKardexGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.vwKardexGridView.RowTemplate.Height = 32;
            this.vwKardexGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwKardexGridView.Size = new System.Drawing.Size(477, 275);
            this.vwKardexGridView.TabIndex = 7;
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(29, 44);
            this.catMatTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(311, 34);
            this.catMatTitle.TabIndex = 6;
            this.catMatTitle.Text = "Stock general";
            // 
            // frmGeneralInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1151, 826);
            this.Controls.Add(this.vwKardexGridView);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneralInventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmGeneralInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGeneralInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwKardexGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vwKardexGridView;
        private System.Windows.Forms.Label catMatTitle;
    }
}