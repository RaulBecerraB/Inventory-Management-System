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
            this.Inicio = new System.Windows.Forms.ToolStripButton();
            this.InventoryBtn = new System.Windows.Forms.ToolStripButton();
            this.kardexBtn = new System.Windows.Forms.ToolStripButton();
            this.catalogueBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inicio,
            this.InventoryBtn,
            this.kardexBtn,
            this.catalogueBtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStrip1.Size = new System.Drawing.Size(1311, 118);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "mainToolStrip";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Inicio
            // 
            this.Inicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Inicio.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
            this.Inicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(78, 95);
            this.Inicio.Text = "Inicio";
            this.Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
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
            this.kardexBtn.Size = new System.Drawing.Size(94, 95);
            this.kardexBtn.Text = "Kardex";
            this.kardexBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // catalogueBtn
            // 
            this.catalogueBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.catalogueBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogueBtn.Image = ((System.Drawing.Image)(resources.GetObject("catalogueBtn.Image")));
            this.catalogueBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.catalogueBtn.Name = "catalogueBtn";
            this.catalogueBtn.Size = new System.Drawing.Size(115, 95);
            this.catalogueBtn.Text = "Catálogo";
            this.catalogueBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1311, 699);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AAAIMX Inventory System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Inicio;
        private System.Windows.Forms.ToolStripButton InventoryBtn;
        private System.Windows.Forms.ToolStripButton catalogueBtn;
        private System.Windows.Forms.ToolStripButton kardexBtn;
    }
}

