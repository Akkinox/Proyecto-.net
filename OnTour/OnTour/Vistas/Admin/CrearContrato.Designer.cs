namespace OnTour.Vistas.Admin
{
    partial class CrearContrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCondiciones = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cboCurso = new MetroFramework.Controls.MetroComboBox();
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.btnAgregarSeguro = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.cboModalidad = new MetroFramework.Controls.MetroComboBox();
            this.cboEjecutivo = new MetroFramework.Controls.MetroComboBox();
            this.cboPaquete = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(217, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nro Contrato";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(310, 60);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(115, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Id cliente";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Id estado";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 258);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Id modalidad";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 320);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Id ejecutivo";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 388);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Id Paquete";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(274, 128);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(171, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Fecha de inicio del contrato";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(274, 187);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(187, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Fecha de termino del contrato";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(274, 258);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(95, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Fecha del viaje";
            // 
            // txtCondiciones
            // 
            // 
            // 
            // 
            this.txtCondiciones.CustomButton.Image = null;
            this.txtCondiciones.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtCondiciones.CustomButton.Name = "";
            this.txtCondiciones.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCondiciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCondiciones.CustomButton.TabIndex = 1;
            this.txtCondiciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCondiciones.CustomButton.UseSelectable = true;
            this.txtCondiciones.CustomButton.Visible = false;
            this.txtCondiciones.Lines = new string[0];
            this.txtCondiciones.Location = new System.Drawing.Point(468, 316);
            this.txtCondiciones.MaxLength = 32767;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.PasswordChar = '\0';
            this.txtCondiciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCondiciones.SelectedText = "";
            this.txtCondiciones.SelectionLength = 0;
            this.txtCondiciones.SelectionStart = 0;
            this.txtCondiciones.ShortcutsEnabled = true;
            this.txtCondiciones.Size = new System.Drawing.Size(115, 23);
            this.txtCondiciones.TabIndex = 21;
            this.txtCondiciones.UseSelectable = true;
            this.txtCondiciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCondiciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(274, 320);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(80, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Condiciones";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.ItemHeight = 23;
            this.cboCurso.Location = new System.Drawing.Point(125, 125);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 29);
            this.cboCurso.TabIndex = 22;
            this.cboCurso.UseSelectable = true;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 23;
            this.cboEstado.Location = new System.Drawing.Point(125, 185);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 29);
            this.cboEstado.TabIndex = 23;
            this.cboEstado.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(467, 128);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 24;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(468, 185);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 25;
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Location = new System.Drawing.Point(468, 256);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime3.TabIndex = 26;
            // 
            // btnAgregarSeguro
            // 
            this.btnAgregarSeguro.Location = new System.Drawing.Point(370, 448);
            this.btnAgregarSeguro.Name = "btnAgregarSeguro";
            this.btnAgregarSeguro.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarSeguro.TabIndex = 27;
            this.btnAgregarSeguro.Text = "Agregar Seguro";
            this.btnAgregarSeguro.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(549, 448);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::OnTour.Properties.Resources.icons8_deshacer_96;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.Location = new System.Drawing.Point(13, 448);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = global::OnTour.Properties.Resources.icons8_volver_48;
            this.metroLink1.Size = new System.Drawing.Size(97, 41);
            this.metroLink1.TabIndex = 29;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            // 
            // cboModalidad
            // 
            this.cboModalidad.FormattingEnabled = true;
            this.cboModalidad.ItemHeight = 23;
            this.cboModalidad.Location = new System.Drawing.Point(125, 248);
            this.cboModalidad.Name = "cboModalidad";
            this.cboModalidad.Size = new System.Drawing.Size(121, 29);
            this.cboModalidad.TabIndex = 30;
            this.cboModalidad.UseSelectable = true;
            // 
            // cboEjecutivo
            // 
            this.cboEjecutivo.FormattingEnabled = true;
            this.cboEjecutivo.ItemHeight = 23;
            this.cboEjecutivo.Location = new System.Drawing.Point(125, 320);
            this.cboEjecutivo.Name = "cboEjecutivo";
            this.cboEjecutivo.Size = new System.Drawing.Size(121, 29);
            this.cboEjecutivo.TabIndex = 31;
            this.cboEjecutivo.UseSelectable = true;
            // 
            // cboPaquete
            // 
            this.cboPaquete.FormattingEnabled = true;
            this.cboPaquete.ItemHeight = 23;
            this.cboPaquete.Location = new System.Drawing.Point(125, 388);
            this.cboPaquete.Name = "cboPaquete";
            this.cboPaquete.Size = new System.Drawing.Size(121, 29);
            this.cboPaquete.TabIndex = 32;
            this.cboPaquete.UseSelectable = true;
            // 
            // CrearContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 494);
            this.Controls.Add(this.cboPaquete);
            this.Controls.Add(this.cboEjecutivo);
            this.Controls.Add(this.cboModalidad);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarSeguro);
            this.Controls.Add(this.metroDateTime3);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.txtCondiciones);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CrearContrato";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearContrato_FormClosed);
            this.Load += new System.EventHandler(this.CrearContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtCondiciones;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cboCurso;
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroButton btnAgregarSeguro;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroComboBox cboModalidad;
        private MetroFramework.Controls.MetroComboBox cboEjecutivo;
        private MetroFramework.Controls.MetroComboBox cboPaquete;
    }
}