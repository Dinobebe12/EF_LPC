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
        SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String query = "SELECT COUNT(1) FROM Usuarios WHERE Usu_Usuario = @Usu_Usuario AND Usu_Contrasena = @Usu_Contrasena";
                SqlCommand Command = new SqlCommand(query, conn);
                Command.CommandType = CommandType.Text;
                Command.Parameters.AddWithValue("@Usu_Usuario", txtUsuario.Text);
                Command.Parameters.AddWithValue("@Usu_Contrasena", txtContrasena.Text);
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
    }
}
