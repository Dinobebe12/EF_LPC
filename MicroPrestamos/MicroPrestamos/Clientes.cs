using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Registrarse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prestamosDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.prestamosDataSet1.Clientes);
            // TODO: This line of code loads data into the 'prestamosDataSet.Servicios' table. You can move, or remove it, as needed.
            this.serviciosTableAdapter.Fill(this.prestamosDataSet.Servicios);

        }
    }
}
