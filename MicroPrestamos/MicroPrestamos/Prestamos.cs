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
    public partial class PrestamoPant : Form
    {
        public PrestamoPant()
        {
            InitializeComponent();
        }
        //readonly SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
        private void PrestamoPant_Load(object sender, EventArgs e)
        {
            SqlDataAdapter MyDA = new SqlDataAdapter();
            string sqlSelectAll = "SELECT * from Servicios";
            MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource
            {
                DataSource = table
            };
            DgvServicios.DataSource = bSource;
        }

        private void AgregarPrestamosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query1 = "Insert Into Servicios (Cli_Cedula, Serv_Monto_Prestamo, Serv_Cuota, Serv_Tasa, Serv_Fecha_Inicio, Serv_Fecha_Fin, Serv_Total_Pagar)" +
                    "Values (@Cli_Cedula, @Serv_Monto_Prestamo, @Serv_Cuota, @Serv_Tasa, @Serv_Fecha_Inicio, @Serv_Fecha_Fin, @Serv_Total_Pagar)";


                SqlCommand command = new SqlCommand(query1, conn)
                {
                    CommandType = CommandType.Text
                };
                if (CedulaPrestamostxt.Text != "" && MontoPrestamotxt.Text != "")
                {
                    command.Parameters.AddWithValue("@Cli_Cedula", CedulaPrestamostxt.Text);
                    command.Parameters.AddWithValue("@Serv_Monto_Prestamo", MontoPrestamotxt.Text);
                    command.Parameters.AddWithValue("@Serv_Cuota", Cuotatxt.Text);
                    command.Parameters.AddWithValue("@Serv_Tasa", CbbTasa.Text);
                    command.Parameters.AddWithValue("@Serv_Fecha_Inicio", FechaInicioDataTime.Text);
                    command.Parameters.AddWithValue("@Serv_Fecha_Fin", FechaFinDataTime.Text);
                    command.Parameters.AddWithValue("@Serv_Total_Pagar", TotalPagartxt.Text);
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Campos obligatorios vacíos!!!");
                }
                MessageBox.Show("Se agrego el prestamo satisfactoriamente!");
                SqlDataAdapter MyDA = new SqlDataAdapter();
                string sqlSelectAll = "SELECT * from Servicios";
                MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource
                {
                    DataSource = table
                };
                DgvServicios.DataSource = bSource;


                PrestamoPant PrestamoPant = new PrestamoPant();
                this.Hide();
                PrestamoPant.ShowDialog();

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

        private void ActualizarPrestamosbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string cedula = $"Select Cli_Cedula From Servicios Where Cli_Cedula = '{CedulaPrestamostxt.Text}'";

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


                if (MontoPrestamotxt.Text != "")
                {
                    string query = $"Update Servicios Set Serv_Monto_Prestamo = @Serv_Monto_Prestamo Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Serv_Monto_Prestamo", MontoPrestamotxt.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();


                if (Cuotatxt.Text != "")
                {
                    string query = $"Update Servicios Set Serv_Cuota = @Serv_Cuota Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Serv_Cuota", Cuotatxt.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (CbbTasa.Text != "")
                {
                    string query = $"Update Servicios Set Serv_Tasa = @Serv_Tasa Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Serv_Tasa", CbbTasa.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (FechaInicioDataTime.Text != "")
                {
                    string query = $"Update Servicios Set Serv_Fecha_Inicio = @Serv_Fecha_Inicio Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Serv_Fecha_Inicio", FechaInicioDataTime.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (FechaFinDataTime.Text != "")
                {
                    string query = $"Update Servicios Set Serv_Fecha_Fin = @Serv_Fecha_Fin Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Serv_Fecha_Fin", FechaFinDataTime.Text);
                    command.ExecuteNonQuery();
                }
                conn.Close();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (TotalPagartxt.Text != "")
                {
                    string query = $"Update Servicios Set Serv_Total_Pagar = @Serv_Total_Pagar Where Cli_Cedula = '{cedulaSql}'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Serv_Total_Pagar", TotalPagartxt.Text);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Actualizados");
                SqlDataAdapter MyDA = new SqlDataAdapter();
                string sqlSelectAll = "SELECT * from Servicios";
                MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource
                {
                    DataSource = table
                };
                DgvServicios.DataSource = bSource;
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

        private void LimpiarPrestamosbtn_Click(object sender, EventArgs e)
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

        private void EliminarPrestamosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string queryCliente = $"Update Servicios Set Cli_Estado = @Cli_Estado Where Cli_Cedula = '{CedulaPrestamostxt.Text}'";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand command = new SqlCommand(queryCliente, conn);
                command.Parameters.AddWithValue("@Cli_Estado", "0");

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Datos Eliminados correctamente");
                    SqlDataAdapter MyDA = new SqlDataAdapter();
                    string sqlSelectAll = "SELECT * from Servicios";
                    MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                    DataTable table = new DataTable();
                    MyDA.Fill(table);
                    BindingSource bSource = new BindingSource
                    {
                        DataSource = table
                    };
                    DgvServicios.DataSource = bSource;
                }
                else
                {
                    MessageBox.Show("No se encontro el dato a Eliminar");
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

        private void VolverPrestamobtn_Click(object sender, EventArgs e)
        {
            MenuPant MenuPant = new MenuPant();
            this.Hide();
            MenuPant.ShowDialog();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = FechaInicioDataTime.Value;
            DateTime fechaFinal = FechaFinDataTime.Value;
            TimeSpan fechaTotal = fechaFinal.Subtract(fechaInicio);
            int cantidadMeses = Convert.ToInt32(fechaTotal.TotalDays / 30);

            Cuotatxt.Text = Convert.ToString(Convert.ToInt32(MontoPrestamotxt.Text) / cantidadMeses * Convert.ToDouble(CbbTasa.Text));
            TotalPagartxt.Text = Convert.ToString((Convert.ToInt32(MontoPrestamotxt.Text) + (Convert.ToInt32(MontoPrestamotxt.Text) * Convert.ToDouble(CbbTasa.Text))));
        }
    }


}
