namespace TechMate_Inventory
{
    partial class frmStore
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
            this.catMatTitle = new System.Windows.Forms.Label();
            this.vwInventoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(61, 46);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 7;
            this.catMatTitle.Text = "Seleccionar materiales";
            // 
            // vwInventoryGridView
            // 
            this.vwInventoryGridView.AllowUserToAddRows = false;
            this.vwInventoryGridView.AllowUserToDeleteRows = false;
            this.vwInventoryGridView.AllowUserToResizeColumns = false;
            this.vwInventoryGridView.AllowUserToResizeRows = false;
            this.vwInventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwInventoryGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vwInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwInventoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vwInventoryGridView.Location = new System.Drawing.Point(67, 118);
            this.vwInventoryGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwInventoryGridView.Name = "vwInventoryGridView";
            this.vwInventoryGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vwInventoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.NullValue = "(Ninguno)";
            this.vwInventoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.vwInventoryGridView.RowTemplate.Height = 32;
            this.vwInventoryGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventoryGridView.Size = new System.Drawing.Size(1344, 338);
            this.vwInventoryGridView.TabIndex = 8;
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1535, 1017);
            this.Controls.Add(this.vwInventoryGridView);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStore";
            this.ShowIcon = false;
            this.Text = "TIENDA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwInventoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.DataGridView vwInventoryGridView;
    }
}