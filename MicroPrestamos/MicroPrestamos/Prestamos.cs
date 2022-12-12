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
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        //readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");
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
            dataGridView1.DataSource = bSource;
        }

        private void AgregarPrestamosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query1 = "Insert Into Clientes (Cli_Cedula, Serv_Monto_Prestamo, Serv_Cuota, Serv_Tasa, Serv_Fecha_Inicio, Serv_Fecha_Fin, Serv_Total_Pagar)" +
                    "Values (@Cli_Cedula, @Serv_Monto_Prestamo, @Serv_Cuota, @Serv_Tasa, @Serv_Fecha_Inicio, @Serv_Fecha_Fin, @Serv_Total_Pagar)";


                SqlCommand command = new SqlCommand(query1, conn)
                {
                    CommandType = CommandType.Text
                };
                command.Parameters.AddWithValue("@Cli_Cedula", Cedulatxt.Text);
                command.Parameters.AddWithValue("@Serv_Monto_Prestamo", MontoPrestamotxt.Text);
                command.Parameters.AddWithValue("@Serv_Cuota", Cuotatxt.Text);
                command.Parameters.AddWithValue("@Serv_Tasa", Tasatxt.Text);
                command.Parameters.AddWithValue("@Serv_Fecha_Inicio", FechaInicioDataTime.Text);
                command.Parameters.AddWithValue("@Serv_Fecha_Fin", FechaFinDataTime.Text);
                command.Parameters.AddWithValue("@Serv_Total_Pagar", TotalPagartxt.Text);
                command.ExecuteNonQuery();


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
                dataGridView1.DataSource = bSource;


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
    }
    
}
