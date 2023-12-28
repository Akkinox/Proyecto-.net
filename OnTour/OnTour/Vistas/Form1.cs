using OnTour.Datos;
using OnTour.Vistas;
using OnTour.Vistas.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Recuperate a = new Recuperate();
            a.Show();
            this.Hide();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (DAO.logear(txtUser.Text,txtPass.Text).Rows.Count == 1)
            {

                this.Hide();
                if (DAO.logear(txtUser.Text, txtPass.Text).Rows[0][4].ToString() == "admin")
                {
                    MenuAdmin me = new MenuAdmin();
                    me.Show();


                }
                else if (DAO.logear(txtUser.Text, txtPass.Text).Rows[0][4].ToString() == "cliente")
                {

                    MenuCliente a = new MenuCliente();
                    a.Show();

                }

            }
            else
            {

                MessageBox.Show("Usuario y/o contraseña incorrectos");

            }
          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
