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

        //SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String query = "SELECT COUNT(1) FROM Usuarios WHERE Usu_Usuario = @Usu_Usuario AND Usu_Contrasena = @Usu_Contrasena";
                SqlCommand Command = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.Text
                };
                Command.Parameters.AddWithValue("@Usu_Usuario", TxtUsuario.Text);
                Command.Parameters.AddWithValue("@Usu_Contrasena", TxtContrasena.Text);
                int count = Convert.ToInt32(Command.ExecuteScalar());
                if (count == 1)
                {
                    PrestamoPant prestamoPant = new PrestamoPant();
                    this.Hide();
                    prestamoPant.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto.");
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
            Clientes registrarse = new Clientes();
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
    }
}
