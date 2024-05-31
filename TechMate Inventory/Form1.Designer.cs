namespace TechMate_Inventory
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HomeBtn = new System.Windows.Forms.ToolStripButton();
            this.InventoryBtn = new System.Windows.Forms.ToolStripButton();
            this.kardexBtn = new System.Windows.Forms.ToolStripButton();
            this.catalogueBtn = new System.Windows.Forms.ToolStripButton();
            this.StoreBtn = new System.Windows.Forms.ToolStripButton();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CartBtn = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeBtn,
            this.InventoryBtn,
            this.kardexBtn,
            this.catalogueBtn,
            this.StoreBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1117, 118);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "mainToolStrip";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // HomeBtn
            // 
            this.HomeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HomeBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(97, 95);
            this.HomeBtn.Text = "Inicio";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.AutoSize = false;
            this.InventoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InventoryBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryBtn.Image")));
            this.InventoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.InventoryBtn.Padding = new System.Windows.Forms.Padding(20);
            this.InventoryBtn.Size = new System.Drawing.Size(182, 95);
            this.InventoryBtn.Text = "Inventario General";
            this.InventoryBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.InventoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InventoryBtn.ToolTipText = "Inventario \\r\\n\r\nGeneral";
            this.InventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // kardexBtn
            // 
            this.kardexBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.kardexBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kardexBtn.Image = ((System.Drawing.Image)(resources.GetObject("kardexBtn.Image")));
            this.kardexBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kardexBtn.Name = "kardexBtn";
            this.kardexBtn.Size = new System.Drawing.Size(196, 95);
            this.kardexBtn.Text = "Movimientos";
            this.kardexBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // catalogueBtn
            // 
            this.catalogueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.catalogueBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogueBtn.Image = ((System.Drawing.Image)(resources.GetObject("catalogueBtn.Image")));
            this.catalogueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.catalogueBtn.Name = "catalogueBtn";
            this.catalogueBtn.Size = new System.Drawing.Size(145, 95);
            this.catalogueBtn.Text = "Catálogo";
            this.catalogueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // StoreBtn
            // 
            this.StoreBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StoreBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("StoreBtn.Image")));
            this.StoreBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(113, 95);
            this.StoreBtn.Text = "Tienda";
            this.StoreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelUserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUserName.Location = new System.Drawing.Point(739, 41);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(162, 42);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "userName";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(907, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // CartBtn
            // 
            this.CartBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CartBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CartBtn.Image = ((System.Drawing.Image)(resources.GetObject("CartBtn.Image")));
            this.CartBtn.Location = new System.Drawing.Point(1010, 16);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(87, 80);
            this.CartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartBtn.TabIndex = 9;
            this.CartBtn.TabStop = false;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1117, 699);
            this.Controls.Add(this.CartBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton HomeBtn;
        private System.Windows.Forms.ToolStripButton InventoryBtn;
        private System.Windows.Forms.ToolStripButton catalogueBtn;
        private System.Windows.Forms.ToolStripButton kardexBtn;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton StoreBtn;
        private System.Windows.Forms.PictureBox CartBtn;
    }
}

