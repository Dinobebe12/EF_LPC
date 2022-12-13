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
    public partial class MenuPant : Form
    {
        public MenuPant()
        {
            InitializeComponent();
        }
        private void PrestamosMenubtn_Click(object sender, EventArgs e)
        {
            PrestamoPant PrestamoPant = new PrestamoPant();
            this.Hide();
            PrestamoPant.ShowDialog();
        }
        private void ClientesMenubtn_Click(object sender, EventArgs e)
        {
            ClientesPant ClientesPant = new ClientesPant();
            this.Hide();
            ClientesPant.ShowDialog();
        }
        private void SalirMenubtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void UsuariosMenubtn_Click(object sender, EventArgs e)
        {
            UsuariosPant UsuariosPant = new UsuariosPant();
            this.Hide();
            UsuariosPant.ShowDialog();

        }

        private void ConsultaMenubtn_Click(object sender, EventArgs e)
        {
            ConsultaPant ConsultaPant = new ConsultaPant();
            this.Hide();
            ConsultaPant.ShowDialog();


        }

        

    }
}