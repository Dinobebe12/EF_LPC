﻿using System;
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
    public partial class PrestamoPant : Form
    {
        public PrestamoPant()
        {
            InitializeComponent();
        }

        private void PrestamoPant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prestamosDataSet.Servicios' table. You can move, or remove it, as needed.
            this.serviciosTableAdapter.Fill(this.prestamosDataSet.Servicios);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
