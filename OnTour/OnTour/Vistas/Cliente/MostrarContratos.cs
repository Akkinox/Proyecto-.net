using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Cliente
{
    public partial class MostrarContratos : MetroFramework.Forms.MetroForm
    {
        public MostrarContratos()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Contrato a = new Contrato();
            a.Show();
            this.Close();
        }

        private void MostrarContratos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
