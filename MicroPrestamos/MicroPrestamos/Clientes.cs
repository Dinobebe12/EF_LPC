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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void Registrarse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prestamosDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.prestamosDataSet1.Clientes);
            // TODO: This line of code loads data into the 'prestamosDataSet.Servicios' table. You can move, or remove it, as needed.
            this.serviciosTableAdapter.Fill(this.prestamosDataSet.Servicios);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Clientes (Cli_Nombre, Cli_Primer_Apellido, Cli_Segundo_Apellido, Cli_Cedula, Cli_Genero, Cli_Estado_Civil, Cli_Correo_Electronico, Cli_Direccion)" +
                                            "Values (@Cli_Nombre, @Cli_Primer_Apellido, @Cli_Segundo_Apellido, @Cli_Cedula, @Cli_Genero, @Cli_Estado_Civil, @Cli_Correo_Electronico, @Cli_Direccion)";
                string query2 = "Insert Into Usuarios (Usu_Usuario, Usu_Contrasena, Usu_Nombre, Rol_ID, Usu_Estado)" +
                                            "Values (@Usu_Usuario, @Usu_Contrasena, @Usu_Nombre, @Rol_ID, @Usu_Estado)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand(query, conn)
                {
                    CommandType = CommandType.Text
                };
                command.Parameters.AddWithValue("@Cli_Nombre", Nombretxt.Text);
                command.Parameters.AddWithValue("@Cli_Primer_Apellido", Apellido1txt.Text);
                command.Parameters.AddWithValue("@Cli_Segundo_Apellido", Apellido2txt.Text);
                command.Parameters.AddWithValue("@Cli_Cedula", CedulaDPtxt.Text);
                command.Parameters.AddWithValue("@Cli_Genero", Generobox.Text);
                command.Parameters.AddWithValue("@Cli_Estado_Civil", EstadoCivilbox.Text);
                command.Parameters.AddWithValue("@Cli_Correo_Electronico", Correotxt.Text);
                command.Parameters.AddWithValue("@Cli_Direccion", Direcciontxt.Text);
                command.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(query2, conn)
                {
                    CommandType = CommandType.Text
                };
                command2.Parameters.AddWithValue("@Usu_Usuario", TxtUsuario.Text);
                command2.Parameters.AddWithValue("@Usu_Contrasena", TxtContrasena.Text);
                command2.Parameters.AddWithValue("@Usu_Nombre", $"{Nombretxt.Text} {Apellido1txt.Text}");
                command2.Parameters.AddWithValue("@Rol_ID", "5");
                command2.Parameters.AddWithValue("@Usu_Estado", "1");
                command2.ExecuteNonQuery();

                MessageBox.Show("Cuenta creada con satisfacción");
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string cedula = $"Select Cli_Cedula From Clientes Where Cli_Cedula = '{CedulaDPtxt.Text}'";
                SqlCommand cmdCedula = new SqlCommand(cedula, conn)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader reader = cmdCedula.ExecuteReader();
                string cedulaSql = "";
                while (reader.Read())
                {
                    cedulaSql = reader.GetString(0);
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (Nombretxt.Text != "")
                {
                    string query = $"Update Clientes Set Cli_Nombre = @Cli_Nombre Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Cli_Nombre", Nombretxt.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (Apellido1txt.Text != "")
                {
                    string query = $"Update Clientes Set Cli_Primer_Apellido = @Cli_Primer_Apellido Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Cli_Primer_Apellido", Apellido1txt.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (Apellido2txt.Text != "")
                {
                    string query = $"Update Clientes Set Cli_Segundo_Apellido = @Cli_Segundo_Apellido Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Cli_Segundo_Apellido", Apellido2txt.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (EstadoCivilbox.Text != "")
                {
                    string query = $"Update Clientes Set Cli_Estado_Civil = @Cli_Estado_Civil Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Cli_Estado_Civil", EstadoCivilbox.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (Correotxt.Text != "")
                {
                    string query = $"Update Clientes Set Cli_Correo_Electronico = @Cli_Correo_Electronico Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Cli_Correo_Electronico", Correotxt.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (Direcciontxt.Text != "")
                {
                    string query = $"Update Clientes Set Cli_Direccion = @Cli_Direccion Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Cli_Direccion", Direcciontxt.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Actualizados");
                SqlDataAdapter MyDA = new SqlDataAdapter();
                string sqlSelectAll = "SELECT * from Clientes";
                MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource
                {
                    DataSource = table
                };
                dgvDatosPersonales.DataSource = bSource;
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
