using OnTour.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas
{
    public partial class Recuperate : MetroFramework.Forms.MetroForm
    {
        public Recuperate()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            DataTable tabl = DAO.Recuperar(txtUsuario.Text);
            if (DAO.Recuperar(txtUsuario.Text).Rows.Count > 0)
            {
                DataRow row = tabl.Rows[0];
                MessageBox.Show("preg :" + row["PREG_SECRETA"].ToString());
                lblPregunta.Text = row["PREG_SECRETA"].ToString();
            }
        }

        private void mtRecuperar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text.Length > 0)
            {
                DataTable tabl = DAO.Recuperar(txtUsuario.Text);
                DataRow row = tabl.Rows[0];
                if (txtRespuesta.Text == row["respuesta"].ToString())
                {

                    MessageBox.Show("Respuesta correcta. Su contraseña es: " + row["contrasena"].ToString());
                    
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta. Intente de nuevo.");
                }


            }
        }

        private void Recuperate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mtVolver_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
