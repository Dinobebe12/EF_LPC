namespace MicroPrestamos
{
    partial class ConsultaPant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPant));
            this.Consultaslbl = new System.Windows.Forms.Label();
            this.VolverConsultabtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Consultaslbl
            // 
            this.Consultaslbl.AutoSize = true;
            this.Consultaslbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultaslbl.Location = new System.Drawing.Point(360, 19);
            this.Consultaslbl.Name = "Consultaslbl";
            this.Consultaslbl.Size = new System.Drawing.Size(158, 51);
            this.Consultaslbl.TabIndex = 0;
            this.Consultaslbl.Text = "Consultas";
            // 
            // VolverConsultabtn
            // 
            this.VolverConsultabtn.BackColor = System.Drawing.Color.LightBlue;
            this.VolverConsultabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VolverConsultabtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverConsultabtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.VolverConsultabtn.Location = new System.Drawing.Point(834, 414);
            this.VolverConsultabtn.Name = "VolverConsultabtn";
            this.VolverConsultabtn.Size = new System.Drawing.Size(70, 33);
            this.VolverConsultabtn.TabIndex = 5;
            this.VolverConsultabtn.Text = "Volver";
            this.VolverConsultabtn.UseVisualStyleBackColor = false;
            this.VolverConsultabtn.Click += new System.EventHandler(this.VolverConsultabtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ConsultaPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VolverConsultabtn);
            this.Controls.Add(this.Consultaslbl);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultaPant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Consultaslbl;
        private System.Windows.Forms.Button VolverConsultabtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}