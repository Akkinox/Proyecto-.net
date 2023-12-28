using OnTour.Vistas.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas
{
    public partial class MenuCliente : MetroFramework.Forms.MetroForm
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void mtCliente_Click(object sender, EventArgs e)
        {
            OpcionesCliente a = new OpcionesCliente();
            a.Show();
            this.Hide();
        }

        private void mtCorreo_Click(object sender, EventArgs e)
        {
            Correo a = new Correo();
            a.Show();
            this.Hide();
        }

        private void mtContrato_Click(object sender, EventArgs e)
        {
            Contrato a = new Contrato();
            a.Show();
            this.Close();

        }

        private void mtSalir_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void MenuCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
