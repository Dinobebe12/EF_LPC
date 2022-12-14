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
    public partial class NuevaContraseña : Form
    {
        public NuevaContraseña()
        {
            InitializeComponent();
        }
        //readonly SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryTemp = $"SELECT Lt_Usuario FROM LoginTemporal WHERE Lt_ID=(SELECT max(Lt_ID) FROM LoginTemporal)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand commandTemp = new SqlCommand(queryTemp, conn)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader readerTemp = commandTemp.ExecuteReader();
                string temp = "";
                while (readerTemp.Read())
                {
                    temp = readerTemp.GetString(0);
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string usuario = $"Select Usu_Usuario From Usuarios Where Usu_Usuario = '{temp}'";

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
                        MenuPant MenuPant = new MenuPant();
                        this.Hide();
                        MenuPant.ShowDialog();
                    }
                }
                else
                {
                    if ((TxtConfirmarContrasena.Text == "" && TxtNuevaContrasena.Text != "") || (TxtConfirmarContrasena.Text != "" && TxtNuevaContrasena.Text == "")
                        || (TxtConfirmarContrasena.Text != TxtNuevaContrasena.Text) || TxtNuevaContrasena.Text == "" || TxtConfirmarContrasena.Text == "")
                    {
                        MessageBox.Show("Verifique nueva contraseña");
                    }
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
