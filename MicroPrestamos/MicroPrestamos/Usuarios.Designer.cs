namespace MicroPrestamos
{
    partial class UsuariosPant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosPant));
            this.Usuarioslbl = new System.Windows.Forms.Label();
            this.VolverUsuariosbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuarioslbl
            // 
            this.Usuarioslbl.AutoSize = true;
            this.Usuarioslbl.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarioslbl.Location = new System.Drawing.Point(254, 22);
            this.Usuarioslbl.Name = "Usuarioslbl";
            this.Usuarioslbl.Size = new System.Drawing.Size(395, 47);
            this.Usuarioslbl.TabIndex = 0;
            this.Usuarioslbl.Text = "Administracion de Usuarios";
            // 
            // VolverUsuariosbtn
            // 
            this.VolverUsuariosbtn.BackColor = System.Drawing.Color.LightBlue;
            this.VolverUsuariosbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VolverUsuariosbtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverUsuariosbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.VolverUsuariosbtn.Location = new System.Drawing.Point(849, 421);
            this.VolverUsuariosbtn.Name = "VolverUsuariosbtn";
            this.VolverUsuariosbtn.Size = new System.Drawing.Size(70, 33);
            this.VolverUsuariosbtn.TabIndex = 6;
            this.VolverUsuariosbtn.Text = "Volver";
            this.VolverUsuariosbtn.UseVisualStyleBackColor = false;
            this.VolverUsuariosbtn.Click += new System.EventHandler(this.VolverUsuariosbtn_Click);
            // 
            // UsuariosPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 466);
            this.Controls.Add(this.VolverUsuariosbtn);
            this.Controls.Add(this.Usuarioslbl);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsuariosPant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuarioslbl;
        private System.Windows.Forms.Button VolverUsuariosbtn;
    }
}