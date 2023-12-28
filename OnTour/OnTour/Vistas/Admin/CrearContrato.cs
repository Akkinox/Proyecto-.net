using OnTour.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnTour.Vistas.Admin
{
    public partial class CrearContrato : MetroFramework.Forms.MetroForm
    {
        public CrearContrato()
        {
            InitializeComponent();
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void CrearContrato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CrearContrato_Load(object sender, EventArgs e)
        {
            cboCurso.DataSource = DAO.getClientes();
            cboCurso.ValueMember = "id_cliente";
            cboCurso.DisplayMember = "id_colegio";
            cboEjecutivo.DataSource = DAO.getEjecutivos();
            cboEjecutivo.ValueMember = "id_ejecutivo";
            cboEjecutivo.DisplayMember = "nom_ejecutivo";
            cboEstado.DataSource = DAO.getEstado();
            cboEstado.ValueMember = "id_estado";
            cboEstado.DisplayMember = "nom_estado";
            cboModalidad.DataSource = DAO.getModalidad();
            cboModalidad.ValueMember = "id_modalidad";
            cboModalidad.DisplayMember = "nom_modalidad";
            cboPaquete.DataSource = DAO.getPaquetes();
            cboPaquete.ValueMember = "id_paquete";
            cboPaquete.DisplayMember = "nom_paquete";

        }
    }
}
