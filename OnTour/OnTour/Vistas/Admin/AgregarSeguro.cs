using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Admin
{
    public partial class AgregarSeguro : MetroFramework.Forms.MetroForm
    {
        public AgregarSeguro()
        {
            InitializeComponent();
        }

        private void AgregarSeguro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
