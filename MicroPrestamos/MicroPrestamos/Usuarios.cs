using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroPrestamos
{
    public partial class UsuariosPant : Form
    {
        public UsuariosPant()
        {
            InitializeComponent();
        }
        //readonly SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");

        private void UsuariosPant_Load(object sender, EventArgs e)
        {
            LblNuevoUsuario.Visible = false;
            TxtNuevoUsuario.Visible = false;
            LblNuevaContrasena.Visible = false;
            TxtNuevaContrasena.Visible = false;
            LblConfirmarContrasena.Visible = false;
            TxtConfirmarContrasena.Visible = false;
            BtnActualizar.Visible = false;
            BtnVerNuevaContrasena.Visible = false;
            BtnVerConfirmarContrasena.Visible = false;
            SqlDataAdapter MyDA = new SqlDataAdapter();
            string sqlSelectAll = "SELECT * from Usuarios";
            MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource
            {
                DataSource = table
            };
            DgvUsuarios.DataSource = bSource;
        }

        private void VolverUsuariosbtn_Click(object sender, EventArgs e)
        {
            MenuPant MenuPant = new MenuPant();
            this.Hide();
            MenuPant.ShowDialog();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string query = "Select Rol_ID From Roles Where Rol_Descripcion = '"+CbbRol.Text+"'";
            string query2 = "Insert Into Usuarios (Usu_Usuario, Usu_Contrasena, Usu_Nombre, Rol_ID, Usu_Estado)" +
                                        "Values (@Usu_Usuario, @Usu_Contrasena, @Usu_Nombre, @Rol_ID, @Usu_Estado)";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            string idRol = "";
            while (reader.Read())
            {
                idRol = reader.GetInt32(0).ToString();
            }
            conn.Close();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command2 = new SqlCommand(query2, conn)
            {
                CommandType = CommandType.Text
            };
            if (TxtUsuario.Text != "" && TxtContrasena.Text != "" && TxtNombre.Text != "" && TxtApellido.Text != "" && CbbRol.Text != "")
            {
                command2.Parameters.AddWithValue("@Usu_Usuario", TxtUsuario.Text);
                command2.Parameters.AddWithValue("@Usu_Contrasena", TxtContrasena.Text);
                command2.Parameters.AddWithValue("@Usu_Nombre", $"{TxtNombre.Text} {TxtApellido.Text}");
                command2.Parameters.AddWithValue("@Rol_ID", idRol);
                command2.Parameters.AddWithValue("@Usu_Estado", "1");
                command2.ExecuteNonQuery();
                MessageBox.Show("Cuenta creada con satisfacción");
            }
            else
            {
                MessageBox.Show("Campos vacíos!!!");
            }
            SqlDataAdapter MyDA = new SqlDataAdapter();
            string sqlSelectAll = "SELECT * from Usuarios";
            MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource
            {
                DataSource = table
            };
            DgvUsuarios.DataSource = bSource;
        }

        private void BtnVerContrasena_Click(object sender, EventArgs e)
        {
            if (TxtContrasena.PasswordChar == '*')
            {
                TxtContrasena.PasswordChar = '\0';
                BtnVerContrasena.Text = "Ocultar";
            }
            else
            {
                TxtContrasena.PasswordChar = '*';
                BtnVerContrasena.Text = "Ver";
            }
        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryCliente = $"Update Usuarios Set Usu_Estado = @Usu_Estado Where Usu_Usuario = '"+ TxtUsuario.Text +"'";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand(queryCliente, conn);
                command.Parameters.AddWithValue("@Usu_Estado", "1");
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dato habilitado correctamente");
                    SqlDataAdapter MyDA = new SqlDataAdapter();
                    string sqlSelectAll = "SELECT * from Usuarios";
                    MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                    DataTable table = new DataTable();
                    MyDA.Fill(table);
                    BindingSource bSource = new BindingSource
                    {
                        DataSource = table
                    };
                    DgvUsuarios.DataSource = bSource;
                }
                else
                {
                    MessageBox.Show("No se encontro el dato a habilitar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryCliente = $"Update Usuarios Set Usu_Estado = @Usu_Estado Where Usu_Usuario = '" + TxtUsuario.Text + "'";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand(queryCliente, conn);
                command.Parameters.AddWithValue("@Usu_Estado", "0");
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dato deshabilitado correctamente");
                    SqlDataAdapter MyDA = new SqlDataAdapter();
                    string sqlSelectAll = "SELECT * from Usuarios";
                    MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                    DataTable table = new DataTable();
                    MyDA.Fill(table);
                    BindingSource bSource = new BindingSource
                    {
                        DataSource = table
                    };
                    DgvUsuarios.DataSource = bSource;
                }
                else
                {
                    MessageBox.Show("No se encontro el dato a deshabilitar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in ActiveForm.Controls)
            {
                if (item.GetType() == new TextBox().GetType())
                {
                    TextBox obj = (TextBox)item;
                    obj.Clear();
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = "";
                if (TxtUsuario.Text != "")
                {
                    usuario = $"Select Usu_Usuario From Usuarios Where Usu_Usuario = '{TxtUsuario.Text}'";
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    SqlCommand cmdUsuario = new SqlCommand(usuario, conn)
                    {
                        CommandType = CommandType.Text
                    };
                    SqlDataReader reader = cmdUsuario.ExecuteReader();
                    string usuarioSql = "";
                    while (reader.Read())
                    {
                        usuarioSql = reader.GetString(0);
                    }
                    conn.Close();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (TxtNuevoUsuario.Text != "")
                    {
                        string query = $"Update Usuarios Set Usu_Usuario = @Usu_Usuario Where Usu_Usuario = '{usuarioSql}'";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Usu_Usuario", TxtNuevoUsuario.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Usuario Actualizado");
                    }
                    if (TxtNuevaContrasena.Text == TxtConfirmarContrasena.Text && TxtConfirmarContrasena.Text != "" && TxtNuevaContrasena.Text != "")
                    {
                        conn.Close();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        if (TxtNuevaContrasena.Text != "")
                        {
                            string query = $"Update Usuarios Set Usu_Contrasena = @Usu_Contrasena Where Usu_Usuario = '{usuarioSql}'";
                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue("@Usu_Contrasena", TxtNuevaContrasena.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Contraseña Actualizada");
                        }
                    }
                    else
                    {
                        if ((TxtConfirmarContrasena.Text == "" && TxtNuevaContrasena.Text != "") || (TxtConfirmarContrasena.Text != "" && TxtNuevaContrasena.Text == "")
                            || (TxtConfirmarContrasena.Text != TxtNuevaContrasena.Text))
                        {
                            MessageBox.Show("Verifique nueva contraseña");
                        }
                    }
                    SqlDataAdapter MyDA = new SqlDataAdapter();
                    string sqlSelectAll = "SELECT * from Usuarios";
                    MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                    DataTable table = new DataTable();
                    MyDA.Fill(table);
                    BindingSource bSource = new BindingSource
                    {
                        DataSource = table
                    };
                    DgvUsuarios.DataSource = bSource;
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario a modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CkbCambiarDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCambiarDatos.Checked == true)
            {
                LblNuevoUsuario.Visible = true;
                TxtNuevoUsuario.Visible = true;
                LblNuevaContrasena.Visible = true;
                TxtNuevaContrasena.Visible = true;
                LblConfirmarContrasena.Visible = true;
                TxtConfirmarContrasena.Visible = true;
                BtnActualizar.Visible = true;
                BtnVerNuevaContrasena.Visible = true;
                BtnVerConfirmarContrasena.Visible = true;
            }
            else
            {
                if (CkbCambiarDatos.Checked == false)
                {
                    LblNuevoUsuario.Visible = false;
                    TxtNuevoUsuario.Visible = false;
                    LblNuevaContrasena.Visible = false;
                    TxtNuevaContrasena.Visible = false;
                    LblConfirmarContrasena.Visible = false;
                    TxtConfirmarContrasena.Visible = false;
                    BtnActualizar.Visible = false;
                    BtnVerNuevaContrasena.Visible = false;
                    BtnVerConfirmarContrasena.Visible = false;
                }
            }
        }

        private void BtnVerNuevaContrasena_Click(object sender, EventArgs e)
        {
            if (TxtNuevaContrasena.PasswordChar == '*')
            {
                TxtNuevaContrasena.PasswordChar = '\0';
                BtnVerNuevaContrasena.Text = "Ocultar";
            }
            else
            {
                TxtNuevaContrasena.PasswordChar = '*';
                BtnVerNuevaContrasena.Text = "Ver";
            }
        }

        private void BtnVerConfirmarContrasena_Click(object sender, EventArgs e)
        {
            if (TxtConfirmarContrasena.PasswordChar == '*')
            {
                TxtConfirmarContrasena.PasswordChar = '\0';
                BtnVerConfirmarContrasena.Text = "Ocultar";
            }
            else
            {
                TxtConfirmarContrasena.PasswordChar = '*';
                BtnVerConfirmarContrasena.Text = "Ver";
            }
        }
    }
}
