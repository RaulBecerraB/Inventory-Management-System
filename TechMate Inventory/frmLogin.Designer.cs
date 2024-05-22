namespace TechMate_Inventory
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.catMatTitle = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHidePwd = new System.Windows.Forms.PictureBox();
            this.forceLoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHidePwd)).BeginInit();
            this.SuspendLayout();
            // 
            // catMatTitle
            // 
            this.catMatTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catMatTitle.Location = new System.Drawing.Point(133, 49);
            this.catMatTitle.Name = "catMatTitle";
            this.catMatTitle.Size = new System.Drawing.Size(137, 61);
            this.catMatTitle.TabIndex = 0;
            this.catMatTitle.Text = "Login";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(69, 169);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(274, 34);
            this.textBoxUserName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre de usuario";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(69, 314);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(274, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(69, 252);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 34);
            this.textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "No tienes cuenta?";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRegister.Location = new System.Drawing.Point(214, 407);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 25);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Regístrate";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, -158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnHidePwd
            // 
            this.btnHidePwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnHidePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePwd.Image")));
            this.btnHidePwd.Location = new System.Drawing.Point(310, 252);
            this.btnHidePwd.Name = "btnHidePwd";
            this.btnHidePwd.Size = new System.Drawing.Size(33, 34);
            this.btnHidePwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHidePwd.TabIndex = 27;
            this.btnHidePwd.TabStop = false;
            this.btnHidePwd.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // forceLoginBtn
            // 
            this.forceLoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceLoginBtn.Location = new System.Drawing.Point(499, 22);
            this.forceLoginBtn.Name = "forceLoginBtn";
            this.forceLoginBtn.Size = new System.Drawing.Size(180, 61);
            this.forceLoginBtn.TabIndex = 8;
            this.forceLoginBtn.Text = "Forzar login (developer)";
            this.forceLoginBtn.UseVisualStyleBackColor = true;
            this.forceLoginBtn.Click += new System.EventHandler(this.forceLoginBtn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 476);
            this.Controls.Add(this.forceLoginBtn);
            this.Controls.Add(this.btnHidePwd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.catMatTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESIÓN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHidePwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catMatTitle;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnHidePwd;
        private System.Windows.Forms.Button forceLoginBtn;
    }
}