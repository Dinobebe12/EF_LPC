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
    }
}
