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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosPant));
            this.Usuarioslbl = new System.Windows.Forms.Label();
            this.VolverUsuariosbtn = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.BtnVerContrasena = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblRol = new System.Windows.Forms.Label();
            this.CbbRol = new System.Windows.Forms.ComboBox();
            this.CkbCambiarDatos = new System.Windows.Forms.CheckBox();
            this.LblConfirmarContrasena = new System.Windows.Forms.Label();
            this.LblNuevaContrasena = new System.Windows.Forms.Label();
            this.LblNuevoUsuario = new System.Windows.Forms.Label();
            this.TxtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.TxtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.TxtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuContrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet3 = new MicroPrestamos.PrestamosDataSet3();
            this.usuariosTableAdapter = new MicroPrestamos.PrestamosDataSet3TableAdapters.UsuariosTableAdapter();
            this.BtnVerNuevaContrasena = new System.Windows.Forms.Button();
            this.BtnVerConfirmarContrasena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet3)).BeginInit();
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
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(109, 84);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(54, 19);
            this.LblUsuario.TabIndex = 26;
            this.LblUsuario.Text = "Usuario:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(113, 106);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(170, 27);
            this.TxtUsuario.TabIndex = 28;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(109, 144);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(74, 19);
            this.lblContrasena.TabIndex = 29;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // BtnVerContrasena
            // 
            this.BtnVerContrasena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVerContrasena.Location = new System.Drawing.Point(289, 169);
            this.BtnVerContrasena.Name = "BtnVerContrasena";
            this.BtnVerContrasena.Size = new System.Drawing.Size(71, 27);
            this.BtnVerContrasena.TabIndex = 30;
            this.BtnVerContrasena.Text = "Ver";
            this.BtnVerContrasena.UseVisualStyleBackColor = true;
            this.BtnVerContrasena.Click += new System.EventHandler(this.BtnVerContrasena_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(113, 169);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(170, 27);
            this.TxtContrasena.TabIndex = 31;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnLimpiar.Location = new System.Drawing.Point(208, 262);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpiar.TabIndex = 32;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Location = new System.Drawing.Point(113, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.ForeColor = System.Drawing.Color.Teal;
            this.BtnActualizar.Location = new System.Drawing.Point(596, 385);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 27);
            this.BtnActualizar.TabIndex = 34;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.ForeColor = System.Drawing.Color.Crimson;
            this.BtnHabilitar.Location = new System.Drawing.Point(366, 224);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(75, 32);
            this.BtnHabilitar.TabIndex = 35;
            this.BtnHabilitar.Text = "Habilitar";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.ForeColor = System.Drawing.Color.Crimson;
            this.BtnDeshabilitar.Location = new System.Drawing.Point(366, 262);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(86, 31);
            this.BtnDeshabilitar.TabIndex = 36;
            this.BtnDeshabilitar.Text = "Deshabilitar";
            this.BtnDeshabilitar.UseVisualStyleBackColor = true;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.BtnDeshabilitar_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(362, 144);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(56, 19);
            this.LblApellido.TabIndex = 37;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(362, 84);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 19);
            this.LblNombre.TabIndex = 38;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(366, 106);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(166, 27);
            this.TxtNombre.TabIndex = 39;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(366, 169);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(166, 27);
            this.TxtApellido.TabIndex = 40;
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Location = new System.Drawing.Point(109, 202);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(29, 19);
            this.LblRol.TabIndex = 41;
            this.LblRol.Text = "Rol:";
            // 
            // CbbRol
            // 
            this.CbbRol.FormattingEnabled = true;
            this.CbbRol.Items.AddRange(new object[] {
            "Admin",
            "Soporte",
            "Servicio",
            "Supervisor",
            "Nose"});
            this.CbbRol.Location = new System.Drawing.Point(113, 224);
            this.CbbRol.Name = "CbbRol";
            this.CbbRol.Size = new System.Drawing.Size(170, 27);
            this.CbbRol.TabIndex = 42;
            // 
            // CkbCambiarDatos
            // 
            this.CkbCambiarDatos.AutoSize = true;
            this.CkbCambiarDatos.Location = new System.Drawing.Point(113, 307);
            this.CkbCambiarDatos.Name = "CkbCambiarDatos";
            this.CkbCambiarDatos.Size = new System.Drawing.Size(109, 23);
            this.CkbCambiarDatos.TabIndex = 43;
            this.CkbCambiarDatos.Text = "Cambiar Datos";
            this.CkbCambiarDatos.UseVisualStyleBackColor = true;
            this.CkbCambiarDatos.CheckedChanged += new System.EventHandler(this.CkbCambiarDatos_CheckedChanged);
            // 
            // LblConfirmarContrasena
            // 
            this.LblConfirmarContrasena.AutoSize = true;
            this.LblConfirmarContrasena.Location = new System.Drawing.Point(248, 360);
            this.LblConfirmarContrasena.Name = "LblConfirmarContrasena";
            this.LblConfirmarContrasena.Size = new System.Drawing.Size(135, 19);
            this.LblConfirmarContrasena.TabIndex = 44;
            this.LblConfirmarContrasena.Text = "Confirmar Contraseña:";
            // 
            // LblNuevaContrasena
            // 
            this.LblNuevaContrasena.AutoSize = true;
            this.LblNuevaContrasena.Location = new System.Drawing.Point(248, 308);
            this.LblNuevaContrasena.Name = "LblNuevaContrasena";
            this.LblNuevaContrasena.Size = new System.Drawing.Size(112, 19);
            this.LblNuevaContrasena.TabIndex = 45;
            this.LblNuevaContrasena.Text = "Nueva Contraseña:";
            // 
            // LblNuevoUsuario
            // 
            this.LblNuevoUsuario.AutoSize = true;
            this.LblNuevoUsuario.Location = new System.Drawing.Point(501, 308);
            this.LblNuevoUsuario.Name = "LblNuevoUsuario";
            this.LblNuevoUsuario.Size = new System.Drawing.Size(92, 19);
            this.LblNuevoUsuario.TabIndex = 46;
            this.LblNuevoUsuario.Text = "Nuevo Usuario:";
            // 
            // TxtNuevoUsuario
            // 
            this.TxtNuevoUsuario.Location = new System.Drawing.Point(505, 333);
            this.TxtNuevoUsuario.Name = "TxtNuevoUsuario";
            this.TxtNuevoUsuario.Size = new System.Drawing.Size(166, 27);
            this.TxtNuevoUsuario.TabIndex = 47;
            // 
            // TxtConfirmarContrasena
            // 
            this.TxtConfirmarContrasena.Location = new System.Drawing.Point(252, 382);
            this.TxtConfirmarContrasena.Name = "TxtConfirmarContrasena";
            this.TxtConfirmarContrasena.PasswordChar = '*';
            this.TxtConfirmarContrasena.Size = new System.Drawing.Size(170, 27);
            this.TxtConfirmarContrasena.TabIndex = 48;
            // 
            // TxtNuevaContrasena
            // 
            this.TxtNuevaContrasena.Location = new System.Drawing.Point(252, 330);
            this.TxtNuevaContrasena.Name = "TxtNuevaContrasena";
            this.TxtNuevaContrasena.PasswordChar = '*';
            this.TxtNuevaContrasena.Size = new System.Drawing.Size(170, 27);
            this.TxtNuevaContrasena.TabIndex = 49;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AutoGenerateColumns = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuIDDataGridViewTextBoxColumn,
            this.usuUsuarioDataGridViewTextBoxColumn,
            this.usuContrasenaDataGridViewTextBoxColumn,
            this.usuNombreDataGridViewTextBoxColumn,
            this.rolIDDataGridViewTextBoxColumn,
            this.usuEstadoDataGridViewTextBoxColumn});
            this.DgvUsuarios.DataSource = this.usuariosBindingSource;
            this.DgvUsuarios.Location = new System.Drawing.Point(555, 106);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.Size = new System.Drawing.Size(354, 187);
            this.DgvUsuarios.TabIndex = 50;
            // 
            // usuIDDataGridViewTextBoxColumn
            // 
            this.usuIDDataGridViewTextBoxColumn.DataPropertyName = "Usu_ID";
            this.usuIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.usuIDDataGridViewTextBoxColumn.Name = "usuIDDataGridViewTextBoxColumn";
            this.usuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuUsuarioDataGridViewTextBoxColumn
            // 
            this.usuUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usu_Usuario";
            this.usuUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuUsuarioDataGridViewTextBoxColumn.Name = "usuUsuarioDataGridViewTextBoxColumn";
            // 
            // usuContrasenaDataGridViewTextBoxColumn
            // 
            this.usuContrasenaDataGridViewTextBoxColumn.DataPropertyName = "Usu_Contrasena";
            this.usuContrasenaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.usuContrasenaDataGridViewTextBoxColumn.Name = "usuContrasenaDataGridViewTextBoxColumn";
            // 
            // usuNombreDataGridViewTextBoxColumn
            // 
            this.usuNombreDataGridViewTextBoxColumn.DataPropertyName = "Usu_Nombre";
            this.usuNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.usuNombreDataGridViewTextBoxColumn.Name = "usuNombreDataGridViewTextBoxColumn";
            // 
            // rolIDDataGridViewTextBoxColumn
            // 
            this.rolIDDataGridViewTextBoxColumn.DataPropertyName = "Rol_ID";
            this.rolIDDataGridViewTextBoxColumn.HeaderText = "Rol_ID";
            this.rolIDDataGridViewTextBoxColumn.Name = "rolIDDataGridViewTextBoxColumn";
            this.rolIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuEstadoDataGridViewTextBoxColumn
            // 
            this.usuEstadoDataGridViewTextBoxColumn.DataPropertyName = "Usu_Estado";
            this.usuEstadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.usuEstadoDataGridViewTextBoxColumn.Name = "usuEstadoDataGridViewTextBoxColumn";
            this.usuEstadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.prestamosDataSet3;
            // 
            // prestamosDataSet3
            // 
            this.prestamosDataSet3.DataSetName = "PrestamosDataSet3";
            this.prestamosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnVerNuevaContrasena
            // 
            this.BtnVerNuevaContrasena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVerNuevaContrasena.Location = new System.Drawing.Point(428, 333);
            this.BtnVerNuevaContrasena.Name = "BtnVerNuevaContrasena";
            this.BtnVerNuevaContrasena.Size = new System.Drawing.Size(71, 27);
            this.BtnVerNuevaContrasena.TabIndex = 51;
            this.BtnVerNuevaContrasena.Text = "Ver";
            this.BtnVerNuevaContrasena.UseVisualStyleBackColor = true;
            this.BtnVerNuevaContrasena.Click += new System.EventHandler(this.BtnVerNuevaContrasena_Click);
            // 
            // BtnVerConfirmarContrasena
            // 
            this.BtnVerConfirmarContrasena.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnVerConfirmarContrasena.Location = new System.Drawing.Point(428, 385);
            this.BtnVerConfirmarContrasena.Name = "BtnVerConfirmarContrasena";
            this.BtnVerConfirmarContrasena.Size = new System.Drawing.Size(71, 27);
            this.BtnVerConfirmarContrasena.TabIndex = 52;
            this.BtnVerConfirmarContrasena.Text = "Ver";
            this.BtnVerConfirmarContrasena.UseVisualStyleBackColor = true;
            this.BtnVerConfirmarContrasena.Click += new System.EventHandler(this.BtnVerConfirmarContrasena_Click);
            // 
            // UsuariosPant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 466);
            this.Controls.Add(this.BtnVerConfirmarContrasena);
            this.Controls.Add(this.BtnVerNuevaContrasena);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.TxtNuevaContrasena);
            this.Controls.Add(this.TxtConfirmarContrasena);
            this.Controls.Add(this.TxtNuevoUsuario);
            this.Controls.Add(this.LblNuevoUsuario);
            this.Controls.Add(this.LblNuevaContrasena);
            this.Controls.Add(this.LblConfirmarContrasena);
            this.Controls.Add(this.CkbCambiarDatos);
            this.Controls.Add(this.CbbRol);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.BtnDeshabilitar);
            this.Controls.Add(this.BtnHabilitar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.BtnVerContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.VolverUsuariosbtn);
            this.Controls.Add(this.Usuarioslbl);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "UsuariosPant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosPant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuarioslbl;
        private System.Windows.Forms.Button VolverUsuariosbtn;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button BtnVerContrasena;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnHabilitar;
        private System.Windows.Forms.Button BtnDeshabilitar;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.ComboBox CbbRol;
        private System.Windows.Forms.CheckBox CkbCambiarDatos;
        private System.Windows.Forms.Label LblConfirmarContrasena;
        private System.Windows.Forms.Label LblNuevaContrasena;
        private System.Windows.Forms.Label LblNuevoUsuario;
        private System.Windows.Forms.TextBox TxtNuevoUsuario;
        private System.Windows.Forms.TextBox TxtConfirmarContrasena;
        private System.Windows.Forms.TextBox TxtNuevaContrasena;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private PrestamosDataSet3 prestamosDataSet3;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private PrestamosDataSet3TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuContrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnVerNuevaContrasena;
        private System.Windows.Forms.Button BtnVerConfirmarContrasena;
    }
}