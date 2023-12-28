using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Cliente
{
    public partial class Seguros : MetroFramework.Forms.MetroForm
    {
        public Seguros()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Contrato a = new Contrato();
            a.Show();
            this.Hide();

        }

        private void Seguros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
