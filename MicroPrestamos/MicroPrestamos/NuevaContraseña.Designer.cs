namespace MicroPrestamos
{
    partial class NuevaContraseña
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
            this.BtnVerConfirmarContrasena = new System.Windows.Forms.Button();
            this.BtnVerNuevaContrasena = new System.Windows.Forms.Button();
            this.TxtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.TxtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.LblNuevaContrasena = new System.Windows.Forms.Label();
            this.LblConfirmarContrasena = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVerConfirmarContrasena
            // 
            this.BtnVerConfirmarContrasena.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerConfirmarContrasena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVerConfirmarContrasena.Location = new System.Drawing.Point(227, 180);
            this.BtnVerConfirmarContrasena.Name = "BtnVerConfirmarContrasena";
            this.BtnVerConfirmarContrasena.Size = new System.Drawing.Size(67, 27);
            this.BtnVerConfirmarContrasena.TabIndex = 58;
            this.BtnVerConfirmarContrasena.Text = "Ver";
            this.BtnVerConfirmarContrasena.UseVisualStyleBackColor = true;
            this.BtnVerConfirmarContrasena.Click += new System.EventHandler(this.BtnVerConfirmarContrasena_Click);
            // 
            // BtnVerNuevaContrasena
            // 
            this.BtnVerNuevaContrasena.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerNuevaContrasena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVerNuevaContrasena.Location = new System.Drawing.Point(227, 122);
            this.BtnVerNuevaContrasena.Name = "BtnVerNuevaContrasena";
            this.BtnVerNuevaContrasena.Size = new System.Drawing.Size(67, 27);
            this.BtnVerNuevaContrasena.TabIndex = 57;
            this.BtnVerNuevaContrasena.Text = "Ver";
            this.BtnVerNuevaContrasena.UseVisualStyleBackColor = true;
            this.BtnVerNuevaContrasena.Click += new System.EventHandler(this.BtnVerNuevaContrasena_Click);
            // 
            // TxtNuevaContrasena
            // 
            this.TxtNuevaContrasena.Location = new System.Drawing.Point(52, 122);
            this.TxtNuevaContrasena.Name = "TxtNuevaContrasena";
            this.TxtNuevaContrasena.PasswordChar = '*';
            this.TxtNuevaContrasena.Size = new System.Drawing.Size(170, 20);
            this.TxtNuevaContrasena.TabIndex = 56;
            // 
            // TxtConfirmarContrasena
            // 
            this.TxtConfirmarContrasena.Location = new System.Drawing.Point(52, 181);
            this.TxtConfirmarContrasena.Name = "TxtConfirmarContrasena";
            this.TxtConfirmarContrasena.PasswordChar = '*';
            this.TxtConfirmarContrasena.Size = new System.Drawing.Size(170, 20);
            this.TxtConfirmarContrasena.TabIndex = 55;
            // 
            // LblNuevaContrasena
            // 
            this.LblNuevaContrasena.AutoSize = true;
            this.LblNuevaContrasena.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevaContrasena.Location = new System.Drawing.Point(47, 93);
            this.LblNuevaContrasena.Name = "LblNuevaContrasena";
            this.LblNuevaContrasena.Size = new System.Drawing.Size(153, 26);
            this.LblNuevaContrasena.TabIndex = 54;
            this.LblNuevaContrasena.Text = "Nueva Contraseña:";
            // 
            // LblConfirmarContrasena
            // 
            this.LblConfirmarContrasena.AutoSize = true;
            this.LblConfirmarContrasena.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmarContrasena.Location = new System.Drawing.Point(45, 152);
            this.LblConfirmarContrasena.Name = "LblConfirmarContrasena";
            this.LblConfirmarContrasena.Size = new System.Drawing.Size(185, 26);
            this.LblConfirmarContrasena.TabIndex = 53;
            this.LblConfirmarContrasena.Text = "Confirmar Contraseña:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Teal;
            this.BtnActualizar.Location = new System.Drawing.Point(109, 230);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 27);
            this.BtnActualizar.TabIndex = 59;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // NuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 301);
            this.ControlBox = false;
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnVerConfirmarContrasena);
            this.Controls.Add(this.BtnVerNuevaContrasena);
            this.Controls.Add(this.TxtNuevaContrasena);
            this.Controls.Add(this.TxtConfirmarContrasena);
            this.Controls.Add(this.LblNuevaContrasena);
            this.Controls.Add(this.LblConfirmarContrasena);
            this.Name = "NuevaContraseña";
            this.Text = "NuevaContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerConfirmarContrasena;
        private System.Windows.Forms.Button BtnVerNuevaContrasena;
        private System.Windows.Forms.TextBox TxtNuevaContrasena;
        private System.Windows.Forms.TextBox TxtConfirmarContrasena;
        private System.Windows.Forms.Label LblNuevaContrasena;
        private System.Windows.Forms.Label LblConfirmarContrasena;
        private System.Windows.Forms.Button BtnActualizar;
    }
}