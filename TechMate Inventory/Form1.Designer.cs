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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.InventoryBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inicio,
            this.InventoryBtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 80);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = false;
            this.Inicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Inicio.Image = ((System.Drawing.Image)(resources.GetObject("Inicio.Image")));
            this.Inicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(100, 47);
            this.Inicio.Text = "Inicio";
            this.Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 47);
            this.toolStripButton1.Text = "Inicio";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // InventoryBtn
            // 
            this.InventoryBtn.AutoSize = false;
            this.InventoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InventoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryBtn.Image")));
            this.InventoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InventoryBtn.Name = "InventoryBtn";
            this.InventoryBtn.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.InventoryBtn.Padding = new System.Windows.Forms.Padding(20);
            this.InventoryBtn.Size = new System.Drawing.Size(100, 77);
            this.InventoryBtn.Text = "Inventario General";
            this.InventoryBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.InventoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InventoryBtn.ToolTipText = "Inventario \r\nGeneral";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Inicio;
        private System.Windows.Forms.ToolStripButton InventoryBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

