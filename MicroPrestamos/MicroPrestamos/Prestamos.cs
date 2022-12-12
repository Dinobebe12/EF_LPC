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
        //SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
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
            dataGridView1.DataSource = bSource;
        }
    }
}
