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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPant));
            this.Consultaslbl = new System.Windows.Forms.Label();
            this.VolverConsultabtn = new System.Windows.Forms.Button();
            this.Imprimirbtn = new System.Windows.Forms.Button();
            this.BuscarConsultabtn = new System.Windows.Forms.Button();
            this.DgvConsultas = new System.Windows.Forms.DataGridView();
            this.cliCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servMontoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servCuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servTasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servTotalPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet2 = new MicroPrestamos.DataSetConsultas();
            this.serviciosTableAdapter = new MicroPrestamos.PrestamosDataSet2TableAdapters.ServiciosTableAdapter();
            this.CedulaConsultatxt = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.CedulaConsultalbl = new System.Windows.Forms.Label();
            this.ExcelConsultabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet2)).BeginInit();
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
            // Imprimirbtn
            // 
            this.Imprimirbtn.Location = new System.Drawing.Point(788, 87);
            this.Imprimirbtn.Name = "Imprimirbtn";
            this.Imprimirbtn.Size = new System.Drawing.Size(94, 28);
            this.Imprimirbtn.TabIndex = 6;
            this.Imprimirbtn.Text = "Imprimir";
            this.Imprimirbtn.UseVisualStyleBackColor = true;
            this.Imprimirbtn.Click += new System.EventHandler(this.Imprimirbtn_Click);
            // 
            // BuscarConsultabtn
            // 
            this.BuscarConsultabtn.Location = new System.Drawing.Point(537, 86);
            this.BuscarConsultabtn.Name = "BuscarConsultabtn";
            this.BuscarConsultabtn.Size = new System.Drawing.Size(77, 28);
            this.BuscarConsultabtn.TabIndex = 7;
            this.BuscarConsultabtn.Text = "Buscar";
            this.BuscarConsultabtn.UseVisualStyleBackColor = true;
            this.BuscarConsultabtn.Click += new System.EventHandler(this.BuscarConsultabtn_Click);
            // 
            // DgvConsultas
            // 
            this.DgvConsultas.AutoGenerateColumns = false;
            this.DgvConsultas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliCedulaDataGridViewTextBoxColumn,
            this.servMontoPrestamoDataGridViewTextBoxColumn,
            this.servCuotaDataGridViewTextBoxColumn,
            this.servTasaDataGridViewTextBoxColumn,
            this.servTotalPagarDataGridViewTextBoxColumn});
            this.DgvConsultas.Cursor = System.Windows.Forms.Cursors.Default;
            this.DgvConsultas.DataSource = this.serviciosBindingSource;
            this.DgvConsultas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvConsultas.Location = new System.Drawing.Point(205, 260);
            this.DgvConsultas.Name = "DgvConsultas";
            this.DgvConsultas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvConsultas.RowHeadersVisible = false;
            this.DgvConsultas.Size = new System.Drawing.Size(505, 187);
            this.DgvConsultas.TabIndex = 8;
            // 
            // cliCedulaDataGridViewTextBoxColumn
            // 
            this.cliCedulaDataGridViewTextBoxColumn.DataPropertyName = "Cli_Cedula";
            this.cliCedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cliCedulaDataGridViewTextBoxColumn.Name = "cliCedulaDataGridViewTextBoxColumn";
            // 
            // servMontoPrestamoDataGridViewTextBoxColumn
            // 
            this.servMontoPrestamoDataGridViewTextBoxColumn.DataPropertyName = "Serv_Monto_Prestamo";
            this.servMontoPrestamoDataGridViewTextBoxColumn.HeaderText = "Monto del Prestamo";
            this.servMontoPrestamoDataGridViewTextBoxColumn.Name = "servMontoPrestamoDataGridViewTextBoxColumn";
            // 
            // servCuotaDataGridViewTextBoxColumn
            // 
            this.servCuotaDataGridViewTextBoxColumn.DataPropertyName = "Serv_Cuota";
            this.servCuotaDataGridViewTextBoxColumn.HeaderText = "Cuota";
            this.servCuotaDataGridViewTextBoxColumn.Name = "servCuotaDataGridViewTextBoxColumn";
            // 
            // servTasaDataGridViewTextBoxColumn
            // 
            this.servTasaDataGridViewTextBoxColumn.DataPropertyName = "Serv_Tasa";
            this.servTasaDataGridViewTextBoxColumn.HeaderText = "Tasa";
            this.servTasaDataGridViewTextBoxColumn.Name = "servTasaDataGridViewTextBoxColumn";
            // 
            // servTotalPagarDataGridViewTextBoxColumn
            // 
            this.servTotalPagarDataGridViewTextBoxColumn.DataPropertyName = "Serv_Total_Pagar";
            this.servTotalPagarDataGridViewTextBoxColumn.HeaderText = "Total a Pagar";
            this.servTotalPagarDataGridViewTextBoxColumn.Name = "servTotalPagarDataGridViewTextBoxColumn";
            // 
            // serviciosBindingSource
            // 
            this.serviciosBindingSource.DataMember = "Servicios";
            this.serviciosBindingSource.DataSource = this.prestamosDataSet2;
            // 
            // prestamosDataSet2
            // 
            this.prestamosDataSet2.DataSetName = "PrestamosDataSet2";
            this.prestamosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviciosTableAdapter
            // 
            this.serviciosTableAdapter.ClearBeforeFill = true;
            // 
            // CedulaConsultatxt
            // 
            this.CedulaConsultatxt.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaConsultatxt.Location = new System.Drawing.Point(345, 86);
            this.CedulaConsultatxt.Name = "CedulaConsultatxt";
            this.CedulaConsultatxt.Size = new System.Drawing.Size(186, 27);
            this.CedulaConsultatxt.TabIndex = 9;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // CedulaConsultalbl
            // 
            this.CedulaConsultalbl.AutoSize = true;
            this.CedulaConsultalbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaConsultalbl.Location = new System.Drawing.Point(260, 82);
            this.CedulaConsultalbl.Name = "CedulaConsultalbl";
            this.CedulaConsultalbl.Size = new System.Drawing.Size(79, 33);
            this.CedulaConsultalbl.TabIndex = 10;
            this.CedulaConsultalbl.Text = "Cedula";
            // 
            // ExcelConsultabtn
            // 
            this.ExcelConsultabtn.Location = new System.Drawing.Point(788, 133);
            this.ExcelConsultabtn.Name = "ExcelConsultabtn";
            this.ExcelConsultabtn.Size = new System.Drawing.Size(94, 28);
            this.ExcelConsultabtn.TabIndex = 11;
            this.ExcelConsultabtn.Text = "Excel";
            this.ExcelConsultabtn.UseVisualStyleBackColor = true;
            this.ExcelConsultabtn.Click += new System.EventHandler(this.ExcelConsultabtn_Click);
            // 
            // ConsultaPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 459);
            this.Controls.Add(this.ExcelConsultabtn);
            this.Controls.Add(this.CedulaConsultalbl);
            this.Controls.Add(this.CedulaConsultatxt);
            this.Controls.Add(this.DgvConsultas);
            this.Controls.Add(this.BuscarConsultabtn);
            this.Controls.Add(this.Imprimirbtn);
            this.Controls.Add(this.VolverConsultabtn);
            this.Controls.Add(this.Consultaslbl);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ConsultaPant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.ConsultaPant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Consultaslbl;
        private System.Windows.Forms.Button VolverConsultabtn;
        private System.Windows.Forms.Button Imprimirbtn;
        private System.Windows.Forms.Button BuscarConsultabtn;
        private System.Windows.Forms.DataGridView DgvConsultas;
        private DataSetConsultas prestamosDataSet2;
        private System.Windows.Forms.BindingSource serviciosBindingSource;
        private PrestamosDataSet2TableAdapters.ServiciosTableAdapter serviciosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servMontoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servCuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servTasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servTotalPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox CedulaConsultatxt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label CedulaConsultalbl;
        private System.Windows.Forms.Button ExcelConsultabtn;
    }
}