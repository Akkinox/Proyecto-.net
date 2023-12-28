using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Cliente
{
    public partial class OpcionesCliente : MetroFramework.Forms.MetroForm
    {
        public OpcionesCliente()
        {
            InitializeComponent();
        }

        private void OpcionesCliente_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.bancoestado.cl/imagenes/comun2008/nuevo_paglg_pers2.html");
            }
            catch (Exception i)
            {
                MessageBox.Show("WOOPS, HA OCURRIDO UN ERROR");
            }
            }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Actividades a = new Actividades();
            a.Show();
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            MenuCliente m = new MenuCliente();
            m.Show();
            this.Close();

        }

        private void OpcionesCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
