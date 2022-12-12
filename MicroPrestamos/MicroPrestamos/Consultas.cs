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
    public partial class ConsultaPant : Form
    {
        public ConsultaPant()
        {
            InitializeComponent();
        }

        private void VolverConsultabtn_Click(object sender, EventArgs e)
        {
            MenuPant MenuPant = new MenuPant();
            this.Hide();
            MenuPant.ShowDialog();
        }

        private void ConsultaPant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prestamosDataSet2.Servicios' table. You can move, or remove it, as needed.
            this.serviciosTableAdapter.Fill(this.prestamosDataSet2.Servicios);

        }
    }
}
