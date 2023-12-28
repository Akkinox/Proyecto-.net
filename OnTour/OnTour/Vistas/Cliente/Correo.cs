using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace OnTour.Vistas.Cliente
{
    public partial class Correo : MetroFramework.Forms.MetroForm
    {
        public Correo()
        {
            InitializeComponent();
        }

        private void Correo_Load(object sender, EventArgs e)
        {

        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            enviar_correo("smtp.gmail.com", 587, txtRemitente.Text,txtContraseña.Text,txtNombre.Text, txtTo.Text,txtCC.Text,txtSubject.Text,txtMensaje.Text);
            Cursor = Cursors.WaitCursor;
        }
        public void enviar_correo(string host, int puerto, string remitente, string contraseña, string nombre, string destinatario , string cc, string asunto,
            string cuerpo)
        {
            char[] delimitador_cc = { ',' };
            
            try
            {
                SmtpClient cliente = new SmtpClient(host,puerto);
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(remitente, nombre);
                correo.Body = cuerpo;
                correo.Subject = asunto;
                if (destinatario == "") { }
                else
                {
                    string[] cadena = destinatario.Split(delimitador_cc);
                    foreach (string word in cadena) correo.To.Add(word.Trim());
                }
                cliente.Credentials = new NetworkCredential(remitente,contraseña);
                cliente.EnableSsl = true;
                cliente.Send(correo);

                MessageBox.Show("Correo enviado correctamente");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Cursor = Cursors.Arrow;
        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            MenuCliente A = new MenuCliente();
            A.Show();
            this.Close();
        }

        private void Correo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
