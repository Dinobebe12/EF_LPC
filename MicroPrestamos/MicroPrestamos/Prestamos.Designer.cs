namespace MicroPrestamos
{
    partial class PrestamoPant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamoPant));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet = new MicroPrestamos.PrestamosDataSet();
            this.serviciosTableAdapter = new MicroPrestamos.PrestamosDataSetTableAdapters.ServiciosTableAdapter();
            this.Cedulalbl = new System.Windows.Forms.Label();
            this.MontoPrestamolbl = new System.Windows.Forms.Label();
            this.Cuotalbl = new System.Windows.Forms.Label();
            this.Tasalbl = new System.Windows.Forms.Label();
            this.FechaInicioDataTime = new System.Windows.Forms.DateTimePicker();
            this.FechaIniciolbl = new System.Windows.Forms.Label();
            this.CedulaPrestamostxt = new System.Windows.Forms.TextBox();
            this.MontoPrestamotxt = new System.Windows.Forms.TextBox();
            this.Cuotatxt = new System.Windows.Forms.TextBox();
            this.Tasatxt = new System.Windows.Forms.TextBox();
            this.AgregarPrestamosbtn = new System.Windows.Forms.Button();
            this.TotalPagarlbl = new System.Windows.Forms.Label();
            this.TotalPagartxt = new System.Windows.Forms.TextBox();
            this.FechaFinlbl = new System.Windows.Forms.Label();
            this.FechaFinDataTime = new System.Windows.Forms.DateTimePicker();
            this.ActualizarPrestamosbtn = new System.Windows.Forms.Button();
            this.LimpiarPrestamosbtn = new System.Windows.Forms.Button();
            this.EliminarPrestamosbtn = new System.Windows.Forms.Button();
            this.VolverPrestamobtn = new System.Windows.Forms.Button();
            this.cliCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servMontoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servCuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servTasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servFechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servFechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servTotalPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrestamosPantallalbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliCedulaDataGridViewTextBoxColumn,
            this.servMontoPrestamoDataGridViewTextBoxColumn,
            this.servCuotaDataGridViewTextBoxColumn,
            this.servTasaDataGridViewTextBoxColumn,
            this.servFechaInicioDataGridViewTextBoxColumn,
            this.servFechaFinDataGridViewTextBoxColumn,
            this.servTotalPagarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviciosBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(66, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(754, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // serviciosBindingSource
            // 
            this.serviciosBindingSource.DataMember = "Servicios";
            this.serviciosBindingSource.DataSource = this.prestamosDataSet;
            // 
            // prestamosDataSet
            // 
            this.prestamosDataSet.DataSetName = "PrestamosDataSet";
            this.prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviciosTableAdapter
            // 
            this.serviciosTableAdapter.ClearBeforeFill = true;
            // 
            // Cedulalbl
            // 
            this.Cedulalbl.AutoSize = true;
            this.Cedulalbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedulalbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Cedulalbl.Location = new System.Drawing.Point(22, 71);
            this.Cedulalbl.Name = "Cedulalbl";
            this.Cedulalbl.Size = new System.Drawing.Size(71, 28);
            this.Cedulalbl.TabIndex = 1;
            this.Cedulalbl.Text = "Cedula:";
            // 
            // MontoPrestamolbl
            // 
            this.MontoPrestamolbl.AutoSize = true;
            this.MontoPrestamolbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoPrestamolbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MontoPrestamolbl.Location = new System.Drawing.Point(273, 71);
            this.MontoPrestamolbl.Name = "MontoPrestamolbl";
            this.MontoPrestamolbl.Size = new System.Drawing.Size(179, 28);
            this.MontoPrestamolbl.TabIndex = 2;
            this.MontoPrestamolbl.Text = "Monto del Prestamo:";
            // 
            // Cuotalbl
            // 
            this.Cuotalbl.AutoSize = true;
            this.Cuotalbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuotalbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Cuotalbl.Location = new System.Drawing.Point(373, 124);
            this.Cuotalbl.Name = "Cuotalbl";
            this.Cuotalbl.Size = new System.Drawing.Size(63, 28);
            this.Cuotalbl.TabIndex = 3;
            this.Cuotalbl.Text = "Cuota:";
            // 
            // Tasalbl
            // 
            this.Tasalbl.AutoSize = true;
            this.Tasalbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasalbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Tasalbl.Location = new System.Drawing.Point(379, 175);
            this.Tasalbl.Name = "Tasalbl";
            this.Tasalbl.Size = new System.Drawing.Size(53, 28);
            this.Tasalbl.TabIndex = 4;
            this.Tasalbl.Text = "Tasa:";
            // 
            // FechaInicioDataTime
            // 
            this.FechaInicioDataTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicioDataTime.Location = new System.Drawing.Point(156, 184);
            this.FechaInicioDataTime.Name = "FechaInicioDataTime";
            this.FechaInicioDataTime.Size = new System.Drawing.Size(87, 20);
            this.FechaInicioDataTime.TabIndex = 11;
            // 
            // FechaIniciolbl
            // 
            this.FechaIniciolbl.AutoSize = true;
            this.FechaIniciolbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaIniciolbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FechaIniciolbl.Location = new System.Drawing.Point(15, 181);
            this.FechaIniciolbl.Name = "FechaIniciolbl";
            this.FechaIniciolbl.Size = new System.Drawing.Size(135, 28);
            this.FechaIniciolbl.TabIndex = 6;
            this.FechaIniciolbl.Text = "Fecha de inicio:";
            // 
            // CedulaPrestamostxt
            // 
            this.CedulaPrestamostxt.Location = new System.Drawing.Point(99, 77);
            this.CedulaPrestamostxt.Name = "CedulaPrestamostxt";
            this.CedulaPrestamostxt.Size = new System.Drawing.Size(118, 20);
            this.CedulaPrestamostxt.TabIndex = 7;
            // 
            // MontoPrestamotxt
            // 
            this.MontoPrestamotxt.Location = new System.Drawing.Point(460, 77);
            this.MontoPrestamotxt.Name = "MontoPrestamotxt";
            this.MontoPrestamotxt.Size = new System.Drawing.Size(110, 20);
            this.MontoPrestamotxt.TabIndex = 8;
            // 
            // Cuotatxt
            // 
            this.Cuotatxt.Location = new System.Drawing.Point(460, 130);
            this.Cuotatxt.Name = "Cuotatxt";
            this.Cuotatxt.Size = new System.Drawing.Size(110, 20);
            this.Cuotatxt.TabIndex = 9;
            // 
            // Tasatxt
            // 
            this.Tasatxt.Location = new System.Drawing.Point(460, 181);
            this.Tasatxt.Name = "Tasatxt";
            this.Tasatxt.Size = new System.Drawing.Size(110, 20);
            this.Tasatxt.TabIndex = 10;
            // 
            // AgregarPrestamosbtn
            // 
            this.AgregarPrestamosbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AgregarPrestamosbtn.Location = new System.Drawing.Point(637, 104);
            this.AgregarPrestamosbtn.Name = "AgregarPrestamosbtn";
            this.AgregarPrestamosbtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarPrestamosbtn.TabIndex = 12;
            this.AgregarPrestamosbtn.Text = "Agregar";
            this.AgregarPrestamosbtn.UseVisualStyleBackColor = true;
            this.AgregarPrestamosbtn.Click += new System.EventHandler(this.AgregarPrestamosbtn_Click);
            // 
            // TotalPagarlbl
            // 
            this.TotalPagarlbl.AutoSize = true;
            this.TotalPagarlbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagarlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TotalPagarlbl.Location = new System.Drawing.Point(320, 221);
            this.TotalPagarlbl.Name = "TotalPagarlbl";
            this.TotalPagarlbl.Size = new System.Drawing.Size(125, 28);
            this.TotalPagarlbl.TabIndex = 13;
            this.TotalPagarlbl.Text = "Total a Pagar:";
            // 
            // TotalPagartxt
            // 
            this.TotalPagartxt.Location = new System.Drawing.Point(459, 227);
            this.TotalPagartxt.Name = "TotalPagartxt";
            this.TotalPagartxt.Size = new System.Drawing.Size(110, 20);
            this.TotalPagartxt.TabIndex = 14;
            // 
            // FechaFinlbl
            // 
            this.FechaFinlbl.AutoSize = true;
            this.FechaFinlbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinlbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FechaFinlbl.Location = new System.Drawing.Point(40, 221);
            this.FechaFinlbl.Name = "FechaFinlbl";
            this.FechaFinlbl.Size = new System.Drawing.Size(106, 28);
            this.FechaFinlbl.TabIndex = 15;
            this.FechaFinlbl.Text = "Fecha Final:";
            // 
            // FechaFinDataTime
            // 
            this.FechaFinDataTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinDataTime.Location = new System.Drawing.Point(156, 224);
            this.FechaFinDataTime.Name = "FechaFinDataTime";
            this.FechaFinDataTime.Size = new System.Drawing.Size(87, 20);
            this.FechaFinDataTime.TabIndex = 16;
            // 
            // ActualizarPrestamosbtn
            // 
            this.ActualizarPrestamosbtn.ForeColor = System.Drawing.Color.Teal;
            this.ActualizarPrestamosbtn.Location = new System.Drawing.Point(637, 133);
            this.ActualizarPrestamosbtn.Name = "ActualizarPrestamosbtn";
            this.ActualizarPrestamosbtn.Size = new System.Drawing.Size(75, 23);
            this.ActualizarPrestamosbtn.TabIndex = 17;
            this.ActualizarPrestamosbtn.Text = "Actualizar";
            this.ActualizarPrestamosbtn.UseVisualStyleBackColor = true;
            this.ActualizarPrestamosbtn.Click += new System.EventHandler(this.ActualizarPrestamosbtn_Click);
            // 
            // LimpiarPrestamosbtn
            // 
            this.LimpiarPrestamosbtn.ForeColor = System.Drawing.Color.Magenta;
            this.LimpiarPrestamosbtn.Location = new System.Drawing.Point(637, 162);
            this.LimpiarPrestamosbtn.Name = "LimpiarPrestamosbtn";
            this.LimpiarPrestamosbtn.Size = new System.Drawing.Size(75, 23);
            this.LimpiarPrestamosbtn.TabIndex = 18;
            this.LimpiarPrestamosbtn.Text = "Limpiar";
            this.LimpiarPrestamosbtn.UseVisualStyleBackColor = true;
            this.LimpiarPrestamosbtn.Click += new System.EventHandler(this.LimpiarPrestamosbtn_Click);
            // 
            // EliminarPrestamosbtn
            // 
            this.EliminarPrestamosbtn.ForeColor = System.Drawing.Color.Crimson;
            this.EliminarPrestamosbtn.Location = new System.Drawing.Point(637, 191);
            this.EliminarPrestamosbtn.Name = "EliminarPrestamosbtn";
            this.EliminarPrestamosbtn.Size = new System.Drawing.Size(75, 23);
            this.EliminarPrestamosbtn.TabIndex = 19;
            this.EliminarPrestamosbtn.Text = "Eliminar";
            this.EliminarPrestamosbtn.UseVisualStyleBackColor = true;
            this.EliminarPrestamosbtn.Click += new System.EventHandler(this.EliminarPrestamosbtn_Click);
            // 
            // VolverPrestamobtn
            // 
            this.VolverPrestamobtn.BackColor = System.Drawing.Color.LightBlue;
            this.VolverPrestamobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VolverPrestamobtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverPrestamobtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.VolverPrestamobtn.Location = new System.Drawing.Point(809, 9);
            this.VolverPrestamobtn.Name = "VolverPrestamobtn";
            this.VolverPrestamobtn.Size = new System.Drawing.Size(70, 33);
            this.VolverPrestamobtn.TabIndex = 31;
            this.VolverPrestamobtn.Text = "Volver";
            this.VolverPrestamobtn.UseVisualStyleBackColor = false;
            this.VolverPrestamobtn.Click += new System.EventHandler(this.VolverPrestamobtn_Click);
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
            this.servMontoPrestamoDataGridViewTextBoxColumn.Width = 125;
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
            // servFechaInicioDataGridViewTextBoxColumn
            // 
            this.servFechaInicioDataGridViewTextBoxColumn.DataPropertyName = "Serv_Fecha_Inicio";
            this.servFechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.servFechaInicioDataGridViewTextBoxColumn.Name = "servFechaInicioDataGridViewTextBoxColumn";
            this.servFechaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // servFechaFinDataGridViewTextBoxColumn
            // 
            this.servFechaFinDataGridViewTextBoxColumn.DataPropertyName = "Serv_Fecha_Fin";
            this.servFechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            this.servFechaFinDataGridViewTextBoxColumn.Name = "servFechaFinDataGridViewTextBoxColumn";
            // 
            // servTotalPagarDataGridViewTextBoxColumn
            // 
            this.servTotalPagarDataGridViewTextBoxColumn.DataPropertyName = "Serv_Total_Pagar";
            this.servTotalPagarDataGridViewTextBoxColumn.HeaderText = "Total a Pagar";
            this.servTotalPagarDataGridViewTextBoxColumn.Name = "servTotalPagarDataGridViewTextBoxColumn";
            // 
            // PrestamosPantallalbl
            // 
            this.PrestamosPantallalbl.AutoSize = true;
            this.PrestamosPantallalbl.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrestamosPantallalbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrestamosPantallalbl.Location = new System.Drawing.Point(343, 9);
            this.PrestamosPantallalbl.Name = "PrestamosPantallalbl";
            this.PrestamosPantallalbl.Size = new System.Drawing.Size(160, 47);
            this.PrestamosPantallalbl.TabIndex = 32;
            this.PrestamosPantallalbl.Text = "Prestamos";
            // 
            // PrestamoPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.PrestamosPantallalbl);
            this.Controls.Add(this.VolverPrestamobtn);
            this.Controls.Add(this.EliminarPrestamosbtn);
            this.Controls.Add(this.LimpiarPrestamosbtn);
            this.Controls.Add(this.ActualizarPrestamosbtn);
            this.Controls.Add(this.FechaFinDataTime);
            this.Controls.Add(this.FechaFinlbl);
            this.Controls.Add(this.TotalPagartxt);
            this.Controls.Add(this.TotalPagarlbl);
            this.Controls.Add(this.AgregarPrestamosbtn);
            this.Controls.Add(this.Tasatxt);
            this.Controls.Add(this.Cuotatxt);
            this.Controls.Add(this.MontoPrestamotxt);
            this.Controls.Add(this.CedulaPrestamostxt);
            this.Controls.Add(this.FechaIniciolbl);
            this.Controls.Add(this.FechaInicioDataTime);
            this.Controls.Add(this.Tasalbl);
            this.Controls.Add(this.Cuotalbl);
            this.Controls.Add(this.MontoPrestamolbl);
            this.Controls.Add(this.Cedulalbl);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrestamoPant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.PrestamoPant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource serviciosBindingSource;
        private PrestamosDataSetTableAdapters.ServiciosTableAdapter serviciosTableAdapter;
        private System.Windows.Forms.Label Cedulalbl;
        private System.Windows.Forms.Label MontoPrestamolbl;
        private System.Windows.Forms.Label Cuotalbl;
        private System.Windows.Forms.Label Tasalbl;
        private System.Windows.Forms.DateTimePicker FechaInicioDataTime;
        private System.Windows.Forms.Label FechaIniciolbl;
        private System.Windows.Forms.TextBox CedulaPrestamostxt;
        private System.Windows.Forms.TextBox MontoPrestamotxt;
        private System.Windows.Forms.TextBox Cuotatxt;
        private System.Windows.Forms.TextBox Tasatxt;
        private System.Windows.Forms.Button AgregarPrestamosbtn;
        private System.Windows.Forms.Label TotalPagarlbl;
        private System.Windows.Forms.TextBox TotalPagartxt;
        private System.Windows.Forms.Label FechaFinlbl;
        private System.Windows.Forms.DateTimePicker FechaFinDataTime;
        private System.Windows.Forms.Button ActualizarPrestamosbtn;
        private System.Windows.Forms.Button LimpiarPrestamosbtn;
        private System.Windows.Forms.Button EliminarPrestamosbtn;
        private System.Windows.Forms.Button VolverPrestamobtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servMontoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servCuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servTasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servFechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servFechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servTotalPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label PrestamosPantallalbl;
    }
}

