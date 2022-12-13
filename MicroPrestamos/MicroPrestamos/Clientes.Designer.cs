namespace MicroPrestamos
{
    partial class ClientesPant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesPant));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Apellido1txt = new System.Windows.Forms.TextBox();
            this.Apellido2txt = new System.Windows.Forms.TextBox();
            this.CedulaDPtxt = new System.Windows.Forms.TextBox();
            this.Generobox = new System.Windows.Forms.ComboBox();
            this.EstadoCivilbox = new System.Windows.Forms.ComboBox();
            this.Correotxt = new System.Windows.Forms.TextBox();
            this.Direcciontxt = new System.Windows.Forms.TextBox();
            this.prestamosDataSet = new MicroPrestamos.PrestamosDataSet();
            this.prestamosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosTableAdapter = new MicroPrestamos.PrestamosDataSetTableAdapters.ServiciosTableAdapter();
            this.dgvDatosPersonales = new System.Windows.Forms.DataGridView();
            this.cliNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliPrimerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliSegundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliEstadoCivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliCorreoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet1 = new MicroPrestamos.PrestamosDataSet1();
            this.clientesTableAdapter = new MicroPrestamos.PrestamosDataSet1TableAdapters.ClientesTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.VolverRegistrobtn = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.VolverPrestamobtn = new System.Windows.Forms.Button();
            this.ClientesPantallalbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersonales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNombre.Location = new System.Drawing.Point(9, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 28);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrimerApellido.Location = new System.Drawing.Point(171, 75);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(144, 28);
            this.lblPrimerApellido.TabIndex = 1;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSegundoApellido.Location = new System.Drawing.Point(342, 75);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(156, 28);
            this.lblSegundoApellido.TabIndex = 2;
            this.lblSegundoApellido.Text = "Segundo Apelldio:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCedula.Location = new System.Drawing.Point(9, 131);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(71, 28);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGenero.Location = new System.Drawing.Point(171, 131);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(73, 28);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEstadoCivil.Location = new System.Drawing.Point(342, 131);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(112, 28);
            this.lblEstadoCivil.TabIndex = 5;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(9, 193);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(165, 28);
            this.lblCorreoElectronico.TabIndex = 6;
            this.lblCorreoElectronico.Text = "Correo Electrónico:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDireccion.Location = new System.Drawing.Point(7, 251);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(92, 28);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección:";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(12, 102);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(147, 20);
            this.Nombretxt.TabIndex = 8;
            // 
            // Apellido1txt
            // 
            this.Apellido1txt.Location = new System.Drawing.Point(174, 102);
            this.Apellido1txt.Name = "Apellido1txt";
            this.Apellido1txt.Size = new System.Drawing.Size(142, 20);
            this.Apellido1txt.TabIndex = 9;
            // 
            // Apellido2txt
            // 
            this.Apellido2txt.Location = new System.Drawing.Point(345, 102);
            this.Apellido2txt.Name = "Apellido2txt";
            this.Apellido2txt.Size = new System.Drawing.Size(142, 20);
            this.Apellido2txt.TabIndex = 10;
            // 
            // CedulaDPtxt
            // 
            this.CedulaDPtxt.Location = new System.Drawing.Point(12, 157);
            this.CedulaDPtxt.MaxLength = 13;
            this.CedulaDPtxt.Name = "CedulaDPtxt";
            this.CedulaDPtxt.Size = new System.Drawing.Size(147, 20);
            this.CedulaDPtxt.TabIndex = 11;
            // 
            // Generobox
            // 
            this.Generobox.FormattingEnabled = true;
            this.Generobox.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.Generobox.Location = new System.Drawing.Point(174, 157);
            this.Generobox.Name = "Generobox";
            this.Generobox.Size = new System.Drawing.Size(142, 21);
            this.Generobox.TabIndex = 12;
            // 
            // EstadoCivilbox
            // 
            this.EstadoCivilbox.FormattingEnabled = true;
            this.EstadoCivilbox.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Divorciado/a"});
            this.EstadoCivilbox.Location = new System.Drawing.Point(345, 157);
            this.EstadoCivilbox.Name = "EstadoCivilbox";
            this.EstadoCivilbox.Size = new System.Drawing.Size(142, 21);
            this.EstadoCivilbox.TabIndex = 13;
            // 
            // Correotxt
            // 
            this.Correotxt.Location = new System.Drawing.Point(12, 224);
            this.Correotxt.Name = "Correotxt";
            this.Correotxt.Size = new System.Drawing.Size(304, 20);
            this.Correotxt.TabIndex = 14;
            // 
            // Direcciontxt
            // 
            this.Direcciontxt.Location = new System.Drawing.Point(10, 282);
            this.Direcciontxt.Name = "Direcciontxt";
            this.Direcciontxt.Size = new System.Drawing.Size(475, 20);
            this.Direcciontxt.TabIndex = 15;
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
            // dgvDatosPersonales
            // 
            this.dgvDatosPersonales.AutoGenerateColumns = false;
            this.dgvDatosPersonales.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosPersonales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosPersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPersonales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliNombreDataGridViewTextBoxColumn,
            this.cliPrimerApellidoDataGridViewTextBoxColumn,
            this.cliSegundoApellidoDataGridViewTextBoxColumn,
            this.cliCedulaDataGridViewTextBoxColumn,
            this.cliGeneroDataGridViewTextBoxColumn,
            this.cliEstadoCivilDataGridViewTextBoxColumn,
            this.cliCorreoElectronicoDataGridViewTextBoxColumn,
            this.cliDireccionDataGridViewTextBoxColumn});
            this.dgvDatosPersonales.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosPersonales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosPersonales.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDatosPersonales.Location = new System.Drawing.Point(500, 102);
            this.dgvDatosPersonales.Name = "dgvDatosPersonales";
            this.dgvDatosPersonales.RowHeadersVisible = false;
            this.dgvDatosPersonales.Size = new System.Drawing.Size(344, 210);
            this.dgvDatosPersonales.TabIndex = 17;
            // 
            // cliNombreDataGridViewTextBoxColumn
            // 
            this.cliNombreDataGridViewTextBoxColumn.DataPropertyName = "Cli_Nombre";
            this.cliNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.cliNombreDataGridViewTextBoxColumn.Name = "cliNombreDataGridViewTextBoxColumn";
            this.cliNombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliNombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliPrimerApellidoDataGridViewTextBoxColumn
            // 
            this.cliPrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Primer_Apellido";
            this.cliPrimerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            this.cliPrimerApellidoDataGridViewTextBoxColumn.Name = "cliPrimerApellidoDataGridViewTextBoxColumn";
            this.cliPrimerApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliPrimerApellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliSegundoApellidoDataGridViewTextBoxColumn
            // 
            this.cliSegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Segundo_Apellido";
            this.cliSegundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo Apellido";
            this.cliSegundoApellidoDataGridViewTextBoxColumn.Name = "cliSegundoApellidoDataGridViewTextBoxColumn";
            this.cliSegundoApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cliSegundoApellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cliCedulaDataGridViewTextBoxColumn
            // 
            this.cliCedulaDataGridViewTextBoxColumn.DataPropertyName = "Cli_Cedula";
            this.cliCedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cliCedulaDataGridViewTextBoxColumn.Name = "cliCedulaDataGridViewTextBoxColumn";
            this.cliCedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliGeneroDataGridViewTextBoxColumn
            // 
            this.cliGeneroDataGridViewTextBoxColumn.DataPropertyName = "Cli_Genero";
            this.cliGeneroDataGridViewTextBoxColumn.HeaderText = "Género";
            this.cliGeneroDataGridViewTextBoxColumn.Name = "cliGeneroDataGridViewTextBoxColumn";
            this.cliGeneroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliEstadoCivilDataGridViewTextBoxColumn
            // 
            this.cliEstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Cli_Estado_Civil";
            this.cliEstadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.cliEstadoCivilDataGridViewTextBoxColumn.Name = "cliEstadoCivilDataGridViewTextBoxColumn";
            this.cliEstadoCivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliCorreoElectronicoDataGridViewTextBoxColumn
            // 
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Cli_Correo_Electronico";
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.Name = "cliCorreoElectronicoDataGridViewTextBoxColumn";
            this.cliCorreoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cliDireccionDataGridViewTextBoxColumn
            // 
            this.cliDireccionDataGridViewTextBoxColumn.DataPropertyName = "Cli_Direccion";
            this.cliDireccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.cliDireccionDataGridViewTextBoxColumn.Name = "cliDireccionDataGridViewTextBoxColumn";
            this.cliDireccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.prestamosDataSet1;
            // 
            // prestamosDataSet1
            // 
            this.prestamosDataSet1.DataSetName = "PrestamosDataSet1";
            this.prestamosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Location = new System.Drawing.Point(25, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnLimpiar.Location = new System.Drawing.Point(26, 335);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 20;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.ForeColor = System.Drawing.Color.Crimson;
            this.BtnDeshabilitar.Location = new System.Drawing.Point(254, 364);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeshabilitar.TabIndex = 21;
            this.BtnDeshabilitar.Text = "Deshabilitar";
            this.BtnDeshabilitar.UseVisualStyleBackColor = true;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.BtnDeshabilitar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ForeColor = System.Drawing.Color.Teal;
            this.BtnActualizar.Location = new System.Drawing.Point(147, 364);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 22;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(592, 68);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(142, 20);
            this.txtBuscar.TabIndex = 23;
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.ForeColor = System.Drawing.Color.Crimson;
            this.BtnHabilitar.Location = new System.Drawing.Point(254, 335);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.BtnHabilitar.TabIndex = 29;
            this.BtnHabilitar.Text = "Habilitar";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // VolverRegistrobtn
            // 
            this.VolverRegistrobtn.BackColor = System.Drawing.Color.LightBlue;
            this.VolverRegistrobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VolverRegistrobtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverRegistrobtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.VolverRegistrobtn.Location = new System.Drawing.Point(774, 417);
            this.VolverRegistrobtn.Name = "VolverRegistrobtn";
            this.VolverRegistrobtn.Size = new System.Drawing.Size(70, 33);
            this.VolverRegistrobtn.TabIndex = 30;
            this.VolverRegistrobtn.Text = "Volver";
            this.VolverRegistrobtn.UseVisualStyleBackColor = false;
            this.VolverRegistrobtn.Click += new System.EventHandler(this.VolverRegistrobtn_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(740, 68);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 31;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // VolverPrestamobtn
            // 
            this.VolverPrestamobtn.BackColor = System.Drawing.Color.LightBlue;
            this.VolverPrestamobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.VolverPrestamobtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverPrestamobtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.VolverPrestamobtn.Location = new System.Drawing.Point(774, 364);
            this.VolverPrestamobtn.Name = "VolverPrestamobtn";
            this.VolverPrestamobtn.Size = new System.Drawing.Size(70, 33);
            this.VolverPrestamobtn.TabIndex = 32;
            this.VolverPrestamobtn.Text = "Volver";
            this.VolverPrestamobtn.UseVisualStyleBackColor = false;
            this.VolverPrestamobtn.Click += new System.EventHandler(this.VolverPrestamobtn_Click);
            // 
            // ClientesPantallalbl
            // 
            this.ClientesPantallalbl.AutoSize = true;
            this.ClientesPantallalbl.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesPantallalbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClientesPantallalbl.Location = new System.Drawing.Point(338, 9);
            this.ClientesPantallalbl.Name = "ClientesPantallalbl";
            this.ClientesPantallalbl.Size = new System.Drawing.Size(125, 47);
            this.ClientesPantallalbl.TabIndex = 33;
            this.ClientesPantallalbl.Text = "Clientes";
            // 
            // ClientesPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 409);
            this.Controls.Add(this.ClientesPantallalbl);
            this.Controls.Add(this.VolverPrestamobtn);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.VolverRegistrobtn);
            this.Controls.Add(this.BtnHabilitar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnDeshabilitar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDatosPersonales);
            this.Controls.Add(this.Direcciontxt);
            this.Controls.Add(this.Correotxt);
            this.Controls.Add(this.EstadoCivilbox);
            this.Controls.Add(this.Generobox);
            this.Controls.Add(this.CedulaDPtxt);
            this.Controls.Add(this.Apellido2txt);
            this.Controls.Add(this.Apellido1txt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientesPant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersonales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1)).EndInit();
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
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Apellido1txt;
        private System.Windows.Forms.TextBox Apellido2txt;
        private System.Windows.Forms.TextBox CedulaDPtxt;
        private System.Windows.Forms.ComboBox Generobox;
        private System.Windows.Forms.ComboBox EstadoCivilbox;
        private System.Windows.Forms.TextBox Correotxt;
        private System.Windows.Forms.TextBox Direcciontxt;
        private System.Windows.Forms.BindingSource prestamosDataSetBindingSource;
        private PrestamosDataSet prestamosDataSet;
        private System.Windows.Forms.BindingSource serviciosBindingSource;
        private PrestamosDataSetTableAdapters.ServiciosTableAdapter serviciosTableAdapter;
        private System.Windows.Forms.DataGridView dgvDatosPersonales;
        private PrestamosDataSet1 prestamosDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private PrestamosDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnDeshabilitar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnHabilitar;
        private System.Windows.Forms.Button VolverRegistrobtn;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliPrimerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliSegundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliEstadoCivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliCorreoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button VolverPrestamobtn;
        private System.Windows.Forms.Label ClientesPantallalbl;
    }
}