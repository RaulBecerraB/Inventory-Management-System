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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneralInventory));
            this.vwInventoryGridView = new System.Windows.Forms.DataGridView();
            this.catMatTitle = new System.Windows.Forms.Label();
            this.addNewMatBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.scInventoryMove = new System.Windows.Forms.SplitContainer();
            this.SearchBarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vwInventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scInventoryMove)).BeginInit();
            this.scInventoryMove.SuspendLayout();
            this.SearchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vwInventoryGridView
            // 
            this.vwInventoryGridView.AccessibleName = "vwInventory";
            this.vwInventoryGridView.AllowUserToAddRows = false;
            this.vwInventoryGridView.AllowUserToDeleteRows = false;
            this.vwInventoryGridView.AllowUserToResizeColumns = false;
            this.vwInventoryGridView.AllowUserToResizeRows = false;
            this.vwInventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vwInventoryGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.vwInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vwInventoryGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.vwInventoryGridView.Location = new System.Drawing.Point(103, 152);
            this.vwInventoryGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwInventoryGridView.Name = "vwInventoryGridView";
            this.vwInventoryGridView.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Franklin Gothic Demi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.vwInventoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.NullValue = "(Ninguno)";
            this.vwInventoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.vwInventoryGridView.RowTemplate.Height = 32;
            this.vwInventoryGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vwInventoryGridView.Size = new System.Drawing.Size(745, 338);
            this.vwInventoryGridView.TabIndex = 7;
            this.vwInventoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwInventoryGridView_CellClick);
            this.vwInventoryGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.vwInventoryGridView_CellFormatting);
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(97, 81);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(415, 42);
            this.catMatTitle.TabIndex = 6;
            this.catMatTitle.Text = "Stock general";
            // 
            // addNewMatBtn
            // 
            this.addNewMatBtn.AutoSize = true;
            this.addNewMatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNewMatBtn.BackgroundImage")));
            this.addNewMatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewMatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMatBtn.Location = new System.Drawing.Point(795, 496);
            this.addNewMatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewMatBtn.Name = "addNewMatBtn";
            this.addNewMatBtn.Size = new System.Drawing.Size(53, 49);
            this.addNewMatBtn.TabIndex = 8;
            this.addNewMatBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewMatBtn.UseVisualStyleBackColor = true;
            this.addNewMatBtn.Visible = false;
            this.addNewMatBtn.Click += new System.EventHandler(this.addNewMatBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 503);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "* = falta prodcuto";
            this.label2.Visible = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSize = true;
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(806, 81);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(42, 42);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // scInventoryMove
            // 
            this.scInventoryMove.Location = new System.Drawing.Point(853, 2);
            this.scInventoryMove.Name = "scInventoryMove";
            this.scInventoryMove.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.scInventoryMove.Size = new System.Drawing.Size(670, 562);
            this.scInventoryMove.SplitterDistance = 25;
            this.scInventoryMove.TabIndex = 12;
            // 
            // SearchBarPanel
            // 
            this.SearchBarPanel.Controls.Add(this.pictureBox1);
            this.SearchBarPanel.Controls.Add(this.SearchBar);
            this.SearchBarPanel.Location = new System.Drawing.Point(369, 81);
            this.SearchBarPanel.Name = "SearchBarPanel";
            this.SearchBarPanel.Size = new System.Drawing.Size(430, 42);
            this.SearchBarPanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(390, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.Window;
            this.SearchBar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchBar.Location = new System.Drawing.Point(3, 4);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(420, 30);
            this.SearchBar.TabIndex = 10;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripción";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(103, 581);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(1300, 84);
            this.DescriptionTextBox.TabIndex = 14;
            this.DescriptionTextBox.Text = "";
            // 
            // frmGeneralInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1535, 1017);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SearchBarPanel);
            this.Controls.Add(this.scInventoryMove);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewMatBtn);
            this.Controls.Add(this.vwInventoryGridView);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneralInventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmGeneralInventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGeneralInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwInventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scInventoryMove)).EndInit();
            this.scInventoryMove.ResumeLayout(false);
            this.SearchBarPanel.ResumeLayout(false);
            this.SearchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vwInventoryGridView;
        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.Button addNewMatBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.SplitContainer scInventoryMove;
        private System.Windows.Forms.Panel SearchBarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
    }
}