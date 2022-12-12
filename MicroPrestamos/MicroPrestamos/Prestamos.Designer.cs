﻿namespace MicroPrestamos
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
            this.Cedulatxt = new System.Windows.Forms.TextBox();
            this.MontoPrestamotxt = new System.Windows.Forms.TextBox();
            this.Cuotatxt = new System.Windows.Forms.TextBox();
            this.Tasatxt = new System.Windows.Forms.TextBox();
            this.servIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servMontoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servCuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servTasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servFechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servFechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servTotalPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servIDDataGridViewTextBoxColumn,
            this.cliCedulaDataGridViewTextBoxColumn,
            this.servMontoPrestamoDataGridViewTextBoxColumn,
            this.servCuotaDataGridViewTextBoxColumn,
            this.servTasaDataGridViewTextBoxColumn,
            this.servFechaInicioDataGridViewTextBoxColumn,
            this.servFechaFinDataGridViewTextBoxColumn,
            this.servTotalPagarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviciosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 165);
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
            this.Cedulalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedulalbl.ForeColor = System.Drawing.Color.Black;
            this.Cedulalbl.Location = new System.Drawing.Point(20, 44);
            this.Cedulalbl.Name = "Cedulalbl";
            this.Cedulalbl.Size = new System.Drawing.Size(60, 16);
            this.Cedulalbl.TabIndex = 1;
            this.Cedulalbl.Text = "Cedula:";
            // 
            // MontoPrestamolbl
            // 
            this.MontoPrestamolbl.AutoSize = true;
            this.MontoPrestamolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoPrestamolbl.ForeColor = System.Drawing.Color.Black;
            this.MontoPrestamolbl.Location = new System.Drawing.Point(434, 44);
            this.MontoPrestamolbl.Name = "MontoPrestamolbl";
            this.MontoPrestamolbl.Size = new System.Drawing.Size(149, 16);
            this.MontoPrestamolbl.TabIndex = 2;
            this.MontoPrestamolbl.Text = "Monto del Prestamo:";
            // 
            // Cuotalbl
            // 
            this.Cuotalbl.AutoSize = true;
            this.Cuotalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuotalbl.ForeColor = System.Drawing.Color.Black;
            this.Cuotalbl.Location = new System.Drawing.Point(534, 97);
            this.Cuotalbl.Name = "Cuotalbl";
            this.Cuotalbl.Size = new System.Drawing.Size(51, 16);
            this.Cuotalbl.TabIndex = 3;
            this.Cuotalbl.Text = "Cuota:";
            // 
            // Tasalbl
            // 
            this.Tasalbl.AutoSize = true;
            this.Tasalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasalbl.ForeColor = System.Drawing.Color.Black;
            this.Tasalbl.Location = new System.Drawing.Point(540, 148);
            this.Tasalbl.Name = "Tasalbl";
            this.Tasalbl.Size = new System.Drawing.Size(47, 16);
            this.Tasalbl.TabIndex = 4;
            this.Tasalbl.Text = "Tasa:";
            // 
            // FechaInicioDataTime
            // 
            this.FechaInicioDataTime.Location = new System.Drawing.Point(143, 124);
            this.FechaInicioDataTime.Name = "FechaInicioDataTime";
            this.FechaInicioDataTime.Size = new System.Drawing.Size(200, 20);
            this.FechaInicioDataTime.TabIndex = 11;
            // 
            // FechaIniciolbl
            // 
            this.FechaIniciolbl.AutoSize = true;
            this.FechaIniciolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaIniciolbl.ForeColor = System.Drawing.Color.Black;
            this.FechaIniciolbl.Location = new System.Drawing.Point(20, 124);
            this.FechaIniciolbl.Name = "FechaIniciolbl";
            this.FechaIniciolbl.Size = new System.Drawing.Size(117, 16);
            this.FechaIniciolbl.TabIndex = 6;
            this.FechaIniciolbl.Text = "Fecha de inicio:";
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.Location = new System.Drawing.Point(89, 43);
            this.Cedulatxt.Name = "Cedulatxt";
            this.Cedulatxt.Size = new System.Drawing.Size(118, 20);
            this.Cedulatxt.TabIndex = 7;
            // 
            // MontoPrestamotxt
            // 
            this.MontoPrestamotxt.Location = new System.Drawing.Point(594, 43);
            this.MontoPrestamotxt.Name = "MontoPrestamotxt";
            this.MontoPrestamotxt.Size = new System.Drawing.Size(110, 20);
            this.MontoPrestamotxt.TabIndex = 8;
            // 
            // Cuotatxt
            // 
            this.Cuotatxt.Location = new System.Drawing.Point(594, 97);
            this.Cuotatxt.Name = "Cuotatxt";
            this.Cuotatxt.Size = new System.Drawing.Size(110, 20);
            this.Cuotatxt.TabIndex = 9;
            // 
            // Tasatxt
            // 
            this.Tasatxt.Location = new System.Drawing.Point(594, 147);
            this.Tasatxt.Name = "Tasatxt";
            this.Tasatxt.Size = new System.Drawing.Size(110, 20);
            this.Tasatxt.TabIndex = 10;
            // 
            // servIDDataGridViewTextBoxColumn
            // 
            this.servIDDataGridViewTextBoxColumn.DataPropertyName = "Serv_ID";
            this.servIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.servIDDataGridViewTextBoxColumn.Name = "servIDDataGridViewTextBoxColumn";
            this.servIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.servIDDataGridViewTextBoxColumn.Width = 40;
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
            // PrestamoPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.Tasatxt);
            this.Controls.Add(this.Cuotatxt);
            this.Controls.Add(this.MontoPrestamotxt);
            this.Controls.Add(this.Cedulatxt);
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
        private System.Windows.Forms.TextBox Cedulatxt;
        private System.Windows.Forms.TextBox MontoPrestamotxt;
        private System.Windows.Forms.TextBox Cuotatxt;
        private System.Windows.Forms.TextBox Tasatxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn servIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servMontoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servCuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servTasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servFechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servFechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servTotalPagarDataGridViewTextBoxColumn;
    }
}
