namespace MicroPrestamos
{
    partial class Clientes
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Apellido1txt = new System.Windows.Forms.TextBox();
            this.Apellido2txt = new System.Windows.Forms.TextBox();
            this.CedulaDPtxt = new System.Windows.Forms.TextBox();
            this.Generobox = new System.Windows.Forms.ComboBox();
            this.EstadoCivilbox = new System.Windows.Forms.ComboBox();
            this.Correotxt = new System.Windows.Forms.TextBox();
            this.Direcciontxt = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.prestamosDataSet = new MicroPrestamos.PrestamosDataSet();
            this.prestamosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosTableAdapter = new MicroPrestamos.PrestamosDataSetTableAdapters.ServiciosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prestamosDataSet1 = new MicroPrestamos.PrestamosDataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new MicroPrestamos.PrestamosDataSet1TableAdapters.ClientesTableAdapter();
            this.cliIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliPrimerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliSegundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliEstadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCorreoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(171, 69);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(79, 13);
            this.lblPrimerApellido.TabIndex = 1;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(342, 69);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(93, 13);
            this.lblSegundoApellido.TabIndex = 2;
            this.lblSegundoApellido.Text = "Segundo Apelldio:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(9, 125);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(171, 125);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(342, 125);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 5;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(9, 187);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(97, 13);
            this.lblCorreoElectronico.TabIndex = 6;
            this.lblCorreoElectronico.Text = "Correo Electrónico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección:";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(12, 96);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(147, 20);
            this.Nombretxt.TabIndex = 8;
            // 
            // Apellido1txt
            // 
            this.Apellido1txt.Location = new System.Drawing.Point(174, 96);
            this.Apellido1txt.Name = "Apellido1txt";
            this.Apellido1txt.Size = new System.Drawing.Size(142, 20);
            this.Apellido1txt.TabIndex = 9;
            // 
            // Apellido2txt
            // 
            this.Apellido2txt.Location = new System.Drawing.Point(345, 96);
            this.Apellido2txt.Name = "Apellido2txt";
            this.Apellido2txt.Size = new System.Drawing.Size(142, 20);
            this.Apellido2txt.TabIndex = 10;
            // 
            // CedulaDPtxt
            // 
            this.CedulaDPtxt.Location = new System.Drawing.Point(12, 151);
            this.CedulaDPtxt.Name = "CedulaDPtxt";
            this.CedulaDPtxt.Size = new System.Drawing.Size(147, 20);
            this.CedulaDPtxt.TabIndex = 11;
            // 
            // Generobox
            // 
            this.Generobox.FormattingEnabled = true;
            this.Generobox.Location = new System.Drawing.Point(174, 151);
            this.Generobox.Name = "Generobox";
            this.Generobox.Size = new System.Drawing.Size(142, 21);
            this.Generobox.TabIndex = 12;
            // 
            // EstadoCivilbox
            // 
            this.EstadoCivilbox.FormattingEnabled = true;
            this.EstadoCivilbox.Location = new System.Drawing.Point(345, 150);
            this.EstadoCivilbox.Name = "EstadoCivilbox";
            this.EstadoCivilbox.Size = new System.Drawing.Size(142, 21);
            this.EstadoCivilbox.TabIndex = 13;
            // 
            // Correotxt
            // 
            this.Correotxt.Location = new System.Drawing.Point(12, 203);
            this.Correotxt.Name = "Correotxt";
            this.Correotxt.Size = new System.Drawing.Size(313, 20);
            this.Correotxt.TabIndex = 14;
            // 
            // Direcciontxt
            // 
            this.Direcciontxt.Location = new System.Drawing.Point(12, 251);
            this.Direcciontxt.Name = "Direcciontxt";
            this.Direcciontxt.Size = new System.Drawing.Size(409, 20);
            this.Direcciontxt.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(132, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 26);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Datos Personales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prestamosDataSet
            // 
            this.prestamosDataSet.DataSetName = "PrestamosDataSet";
            this.prestamosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosDataSetBindingSource
            // 
            this.prestamosDataSetBindingSource.DataSource = this.prestamosDataSet;
            this.prestamosDataSetBindingSource.Position = 0;
            // 
            // serviciosBindingSource
            // 
            this.serviciosBindingSource.DataMember = "Servicios";
            this.serviciosBindingSource.DataSource = this.prestamosDataSetBindingSource;
            // 
            // serviciosTableAdapter
            // 
            this.serviciosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliIDDataGridViewTextBoxColumn,
            this.cliNombreDataGridViewTextBoxColumn,
            this.cliPrimerApellidoDataGridViewTextBoxColumn,
            this.cliSegundoApellidoDataGridViewTextBoxColumn,
            this.cliCedulaDataGridViewTextBoxColumn,
            this.cliGeneroDataGridViewTextBoxColumn,
            this.cliEstadoCivilDataGridViewTextBoxColumn,
            this.cliCorreoElectronicoDataGridViewTextBoxColumn,
            this.cliDireccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(493, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 179);
            this.dataGridView1.TabIndex = 17;
            // 
            // prestamosDataSet1
            // 
            this.prestamosDataSet1.DataSetName = "PrestamosDataSet1";
            this.prestamosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.prestamosDataSet1;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cliIDDataGridViewTextBoxColumn
            // 
            this.cliIDDataGridViewTextBoxColumn.DataPropertyName = "Cli_ID";
            this.cliIDDataGridViewTextBoxColumn.HeaderText = "Cli_ID";
            this.cliIDDataGridViewTextBoxColumn.Name = "cliIDDataGridViewTextBoxColumn";
            this.cliIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliNombreDataGridViewTextBoxColumn
            // 
            this.cliNombreDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.HeaderText = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.Name = "cliNombreDataGridViewTextBoxColumn";
            // 
            // cliPrimerApellidoDataGridViewTextBoxColumn
            // 
            this.cliPrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Primer_Apellido";
            this.cliPrimerApellidoDataGridViewTextBoxColumn.HeaderText = "Cli_Primer_Apellido";
            this.cliPrimerApellidoDataGridViewTextBoxColumn.Name = "cliPrimerApellidoDataGridViewTextBoxColumn";
            // 
            // cliSegundoApellidoDataGridViewTextBoxColumn
            // 
            this.cliSegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Segundo_Apellido";
            this.cliSegundoApellidoDataGridViewTextBoxColumn.HeaderText = "Cli_Segundo_Apellido";
            this.cliSegundoApellidoDataGridViewTextBoxColumn.Name = "cliSegundoApellidoDataGridViewTextBoxColumn";
            // 
            // cliCedulaDataGridViewTextBoxColumn
            // 
            this.cliCedulaDataGridViewTextBoxColumn.DataPropertyName = "Cli_Cedula";
            this.cliCedulaDataGridViewTextBoxColumn.HeaderText = "Cli_Cedula";
            this.cliCedulaDataGridViewTextBoxColumn.Name = "cliCedulaDataGridViewTextBoxColumn";
            // 
            // cliGeneroDataGridViewTextBoxColumn
            // 
            this.cliGeneroDataGridViewTextBoxColumn.DataPropertyName = "Cli_Genero";
            this.cliGeneroDataGridViewTextBoxColumn.HeaderText = "Cli_Genero";
            this.cliGeneroDataGridViewTextBoxColumn.Name = "cliGeneroDataGridViewTextBoxColumn";
            // 
            // cliEstadoCivilDataGridViewTextBoxColumn
            // 
            this.cliEstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Cli_Estado_Civil";
            this.cliEstadoCivilDataGridViewTextBoxColumn.HeaderText = "Cli_Estado_Civil";
            this.cliEstadoCivilDataGridViewTextBoxColumn.Name = "cliEstadoCivilDataGridViewTextBoxColumn";
            // 
            // cliCorreoElectronicoDataGridViewTextBoxColumn
            // 
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Correo_Electronico";
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.HeaderText = "Cli_Correo_Electronico";
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.Name = "cliCorreoElectronicoDataGridViewTextBoxColumn";
            // 
            // cliDireccionDataGridViewTextBoxColumn
            // 
            this.cliDireccionDataGridViewTextBoxColumn.DataPropertyName = "Cli_Direccion";
            this.cliDireccionDataGridViewTextBoxColumn.HeaderText = "Cli_Direccion";
            this.cliDireccionDataGridViewTextBoxColumn.Name = "cliDireccionDataGridViewTextBoxColumn";
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Direcciontxt);
            this.Controls.Add(this.Correotxt);
            this.Controls.Add(this.EstadoCivilbox);
            this.Controls.Add(this.Generobox);
            this.Controls.Add(this.CedulaDPtxt);
            this.Controls.Add(this.Apellido2txt);
            this.Controls.Add(this.Apellido1txt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Apellido1txt;
        private System.Windows.Forms.TextBox Apellido2txt;
        private System.Windows.Forms.TextBox CedulaDPtxt;
        private System.Windows.Forms.ComboBox Generobox;
        private System.Windows.Forms.ComboBox EstadoCivilbox;
        private System.Windows.Forms.TextBox Correotxt;
        private System.Windows.Forms.TextBox Direcciontxt;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.BindingSource prestamosDataSetBindingSource;
        private PrestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource serviciosBindingSource;
        private PrestamosDataSetTableAdapters.ServiciosTableAdapter serviciosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PrestamosDataSet1 prestamosDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private PrestamosDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliPrimerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliSegundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliEstadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCorreoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDireccionDataGridViewTextBoxColumn;
    }
}