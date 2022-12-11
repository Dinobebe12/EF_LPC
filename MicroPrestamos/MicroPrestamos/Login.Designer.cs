namespace MicroPrestamos
{
    partial class Login
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.BtnVerContrasena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(105, 224);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(84, 23);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(131, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(122, 108);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(105, 73);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 3;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(105, 134);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(100, 20);
            this.TxtContrasena.TabIndex = 4;
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.Location = new System.Drawing.Point(105, 257);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(84, 23);
            this.BtnRegistrarse.TabIndex = 5;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = true;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // BtnVerContrasena
            // 
            this.BtnVerContrasena.Location = new System.Drawing.Point(114, 160);
            this.BtnVerContrasena.Name = "BtnVerContrasena";
            this.BtnVerContrasena.Size = new System.Drawing.Size(69, 24);
            this.BtnVerContrasena.TabIndex = 29;
            this.BtnVerContrasena.Text = "Ver";
            this.BtnVerContrasena.UseVisualStyleBackColor = true;
            this.BtnVerContrasena.Click += new System.EventHandler(this.BtnVerContrasena_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 292);
            this.Controls.Add(this.BtnVerContrasena);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.BtnLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.Button BtnVerContrasena;
    }
}