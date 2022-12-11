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
        SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void Registrarse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prestamosDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.prestamosDataSet1.Clientes);
            // TODO: This line of code loads data into the 'prestamosDataSet.Servicios' table. You can move, or remove it, as needed.
            this.serviciosTableAdapter.Fill(this.prestamosDataSet.Servicios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Clientes (Cli_Nombre, Cli_Primer_Apellido, Cli_Segundo_Apellido, Cli_Cedula, Cli_Genero, Cli_Estado_Civil, Cli_Correo_Electronico, Cli_Direccion)" +
                                            "Values (@Cli_Nombre, @Cli_Primer_Apellido, @Cli_Segundo_Apellido, @Cli_Cedula, @Cli_Genero, @Cli_Estado_Civil, @Cli_Correo_Electronico, @Cli_Direccion)";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Cli_Nombre", Nombretxt);
                command.Parameters.AddWithValue("@Cli_Primer_Apellido", Apellido1txt);
                command.Parameters.AddWithValue("@Cli_Segundo_Apellido", Apellido2txt);
                command.Parameters.AddWithValue("@Cli_Cedula", CedulaDPtxt);
                command.Parameters.AddWithValue("@Cli_Genero", Generobox);
                command.Parameters.AddWithValue("@Cli_Estado_Civil", EstadoCivilbox);
                command.Parameters.AddWithValue("@Cli_Correo_Electronico", Correotxt);
                command.Parameters.AddWithValue("@Cli_Direccion", Direcciontxt);
                command.ExecuteNonQuery();

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
    }
}
