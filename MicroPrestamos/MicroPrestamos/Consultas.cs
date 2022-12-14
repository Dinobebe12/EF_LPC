using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroPrestamos
{
    public partial class ConsultaPant : Form
    {
        public ConsultaPant()
        {
            InitializeComponent();
        }
        //readonly SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-TKG1DP2; Initial Catalog = Prestamos; Integrated Security=True;");
        readonly SqlConnection conn = new SqlConnection(@"Data Source = DINO\SQLEXPRESS; Initial Catalog = Prestamos; Integrated Security=True;");

        private void VolverConsultabtn_Click(object sender, EventArgs e)
        {
            MenuPant MenuPant = new MenuPant();
            this.Hide();
            MenuPant.ShowDialog();
        }

        private void ConsultaPant_Load(object sender, EventArgs e)
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
            DgvConsultas.DataSource = bSource;
        }

        private void BuscarConsultabtn_Click(object sender, EventArgs e)
        {


            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlDataAdapter MyDA = new SqlDataAdapter();
                    string sqlSelectAll = $"Select * From Servicios Where Cli_Cedula = '{CedulaConsultatxt.Text}'";
                    MyDA.SelectCommand = new SqlCommand(sqlSelectAll, conn);
                    DataTable table = new DataTable();
                    MyDA.Fill(table);
                    BindingSource bSource = new BindingSource
                    {
                        DataSource = table
                    };
                    DgvConsultas.DataSource = bSource;
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

        private void Imprimirbtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        public int i = 0;

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // La fuente que vamos a usar para imprimir.
            Font printFont = new Font("Arial", 10);
            float topMargin = e.MarginBounds.Top;
            float yPos;
            float linesPerPage;
            int count = 0;
            string texto;
            DataGridViewRow row;

            // Calculamos el número de líneas que caben en cada página.
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);


            // Recorremos las filas del DataGridView hasta que llegemos
            // a las líneas que nos caben en cada página o al final del grid.
            while (count < linesPerPage && i < this.DgvConsultas.Rows.Count)
            {
                row = DgvConsultas.Rows[0];
                texto = "";

                foreach (DataGridViewCell celda in row.Cells)
                {
                    texto += "\t" + celda.Value.ToString();
                }

                // Calculamos la posición en la que se escribe la línea
                yPos = topMargin + (count * printFont.GetHeight(e.Graphics));

                // Escribimos la línea con el objeto Graphics
                e.Graphics.DrawString(texto, printFont, Brushes.Black, 10, yPos);

                count++;
                i++;
            }

            // Una vez fuera del bucle comprobamos si nos quedan más filas 
            // por imprimir, si quedan saldrán en la siguente página
            if (i < this.DgvConsultas.Rows.Count)
                e.HasMorePages = true;
            else
            {
                // si llegamos al final, se establece HasMorePages a 
                // false para que se acabe la impresión
                e.HasMorePages = false;

                // Es necesario poner el contador a 0 porque, por ejemplo si se hace 
                // una impresión desde PrintPreviewDialog, se vuelve disparar este 
                // evento como si fuese la primera vez, y si i está con el valor de la
                // última fila del grid no se imprime nada
                i = 0;
            }

        }

        public void ExcelConsulta(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Application.Workbooks.Add(true);
            int indexColumna = 0;
            foreach (DataGridViewColumn columna in dataGridView.Columns)
            {
                indexColumna++;
                application.Cells[1, indexColumna] = columna.Name;
            }
            int indexFila = 0;
            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                indexFila++;
                indexColumna = 0;
                foreach (DataGridViewColumn columna in dataGridView.Columns)
                {
                    indexColumna++;
                    application.Cells[indexFila + 1, indexColumna] = fila.Cells[columna.Name].Value;
                }
            }
            application.Visible = true;
        }

        private void ExcelConsultabtn_Click(object sender, EventArgs e)
        {
            ExcelConsulta(DgvConsultas);
        }
    }
    
}
