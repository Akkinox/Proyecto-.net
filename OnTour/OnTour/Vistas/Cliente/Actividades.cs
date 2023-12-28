using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Cliente
{
    public partial class Actividades :  MetroFramework.Forms.MetroForm
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            OpcionesCliente p = new OpcionesCliente();
            p.Show();
            this.Close();
        }

        private void Actividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
