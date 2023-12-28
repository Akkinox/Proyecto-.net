using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Cliente
{
    public partial class Contrato : MetroFramework.Forms.MetroForm
    {
        public Contrato()
        {
            InitializeComponent();
        }

        private void Contrato_Load(object sender, EventArgs e)
        {

        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            MenuCliente p = new MenuCliente();
            p.Show();
            this.Close();

        }

        private void Mostar_Click(object sender, EventArgs e)
        {
            MostrarContratos m = new MostrarContratos();
            m.Show();
            this.Close();
        }

        private void mtSeguros_Click(object sender, EventArgs e)
        {
            Seguros s = new Seguros();
            s.Show();
            this.Close();

        }

        private void Contrato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
