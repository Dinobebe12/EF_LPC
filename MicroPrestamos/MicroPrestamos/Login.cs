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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //readonly SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string queryNo = $"Select Usu_Estado From Usuarios Where Usu_Usuario = '{TxtUsuario.Text}'";
                SqlCommand commandNo = new SqlCommand(queryNo, conn)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader readerNo = commandNo.ExecuteReader();
                string no = "";
                while (readerNo.Read())
                {
                    no = readerNo.GetInt32(0).ToString();
                }
                if (no == "1")
                {
                    conn.Close();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE Usu_Usuario = @Usu_Usuario AND Usu_Contrasena = @Usu_Contrasena";
                    SqlCommand Command = new SqlCommand(query, conn)
                    {
                        CommandType = CommandType.Text
                    };
                    Command.Parameters.AddWithValue("@Usu_Usuario", TxtUsuario.Text);
                    Command.Parameters.AddWithValue("@Usu_Contrasena", TxtContrasena.Text);
                    int count = Convert.ToInt32(Command.ExecuteScalar());
                    int cont = 0;
                    if (count == 1)
                    {
                        if (count == 1)
                        {
                            string frole = $"Select Rol_ID From Usuarios Where Usu_Usuario='{TxtUsuario.Text}'";
                            SqlCommand cmdRole = new SqlCommand(frole, conn)
                            {
                                CommandType = CommandType.Text
                            };
                            SqlDataReader reader2 = cmdRole.ExecuteReader();
                            reader2.Read();
                            MenuPant MenuPant = new MenuPant(reader2.GetInt32(0));
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrecto.");
                        }
                        conn.Close();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string queryCambio = $"Select Usu_LoginVencido From Usuarios Where Usu_Usuario = '{TxtUsuario.Text}'";
                        SqlCommand commandCambio = new SqlCommand(queryCambio, conn);
                        SqlDataReader reader = commandCambio.ExecuteReader();
                        string idRol = "";
                        while (reader.Read())
                        {
                            idRol = reader.GetInt32(0).ToString();
                        }
                        conn.Close();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string queryTemp = $"Insert Into LoginTemporal (Lt_Usuario) Values (@Lt_Usuario)";
                        SqlCommand commandTemp = new SqlCommand(queryTemp, conn)
                        {
                            CommandType = CommandType.Text
                        };
                        commandTemp.Parameters.AddWithValue("@Lt_Usuario", TxtUsuario.Text);
                        commandTemp.ExecuteNonQuery();
                        if (idRol == "3")
                        {
                            MessageBox.Show("\tAlerta!!!\n\nCambio de contraseña requerido");
                            conn.Close();
                            if (conn.State == ConnectionState.Closed)
                                conn.Open();
                            idRol = "0";
                            string queryReinicio = $"Update Usuarios Set Usu_LoginVencido = @Usu_LoginVencido Where Usu_Usuario = '{TxtUsuario.Text}'";
                            SqlCommand commandReinicio = new SqlCommand(queryReinicio, conn);
                            commandReinicio.Parameters.AddWithValue("@Usu_LoginVencido", idRol);
                            commandReinicio.ExecuteNonQuery();
                            NuevaContraseña nuevaContraseña = new NuevaContraseña();
                            this.Hide();
                            nuevaContraseña.ShowDialog();

                        }
                        else
                        {
                            idRol = Convert.ToString(Convert.ToInt32(idRol) + 1);
                            conn.Close();
                            if (conn.State == ConnectionState.Closed)
                                conn.Open();
                            string queryLogin = $"Update Usuarios Set Usu_LoginVencido = @Usu_LoginVencido Where Usu_Usuario = '{TxtUsuario.Text}'";
                            SqlCommand commandLogin = new SqlCommand(queryLogin, conn);
                            commandLogin.Parameters.AddWithValue("@Usu_LoginVencido", idRol);
                            commandLogin.ExecuteNonQuery();

                            MenuPant MenuPant = new MenuPant();
                            this.Hide();
                            MenuPant.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecto.");
                        cont++;
                        if (cont == 3)
                        {
                            string queryCont = $"Update Usuarios Set Usu_Estado = @Usu_Estado Where Usu_Usuario = '{TxtUsuario.Text}'";
                            SqlCommand commandCont = new SqlCommand(queryCont, conn);
                            commandCont.Parameters.AddWithValue("@Usu_Estado", "0");
                            commandCont.ExecuteNonQuery();
                            cont = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("\tUsuario bloqueado\n\nContactarse con un supervisor");
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
        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            ClientesPant registrarse = new ClientesPant();
            this.Hide();
            registrarse.ShowDialog();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}