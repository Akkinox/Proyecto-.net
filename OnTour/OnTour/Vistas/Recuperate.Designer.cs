namespace OnTour.Vistas
{
    partial class Recuperate
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.mtRecuperar = new MetroFramework.Controls.MetroTile();
            this.txtRespuesta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Pregunta = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(153, 133);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(10, 13);
            this.lblPregunta.TabIndex = 17;
            this.lblPregunta.Text = ".";
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(321, 303);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(56, 35);
            this.mtVolver.Style = MetroFramework.MetroColorStyle.Red;
            this.mtVolver.TabIndex = 16;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // mtRecuperar
            // 
            this.mtRecuperar.ActiveControl = null;
            this.mtRecuperar.Location = new System.Drawing.Point(167, 226);
            this.mtRecuperar.Name = "mtRecuperar";
            this.mtRecuperar.Size = new System.Drawing.Size(83, 39);
            this.mtRecuperar.Style = MetroFramework.MetroColorStyle.Green;
            this.mtRecuperar.TabIndex = 15;
            this.mtRecuperar.Text = "Recuperar";
            this.mtRecuperar.UseSelectable = true;
            this.mtRecuperar.Click += new System.EventHandler(this.mtRecuperar_Click);
            // 
            // txtRespuesta
            // 
            // 
            // 
            // 
            this.txtRespuesta.CustomButton.Image = null;
            this.txtRespuesta.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtRespuesta.CustomButton.Name = "";
            this.txtRespuesta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRespuesta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRespuesta.CustomButton.TabIndex = 1;
            this.txtRespuesta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRespuesta.CustomButton.UseSelectable = true;
            this.txtRespuesta.CustomButton.Visible = false;
            this.txtRespuesta.Lines = new string[0];
            this.txtRespuesta.Location = new System.Drawing.Point(153, 180);
            this.txtRespuesta.MaxLength = 32767;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.PasswordChar = '\0';
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRespuesta.SelectedText = "";
            this.txtRespuesta.SelectionLength = 0;
            this.txtRespuesta.SelectionStart = 0;
            this.txtRespuesta.ShortcutsEnabled = true;
            this.txtRespuesta.Size = new System.Drawing.Size(163, 23);
            this.txtRespuesta.TabIndex = 14;
            this.txtRespuesta.UseSelectable = true;
            this.txtRespuesta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRespuesta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 180);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Respuesta";
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSize = true;
            this.Pregunta.Location = new System.Drawing.Point(133, 108);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(0, 0);
            this.Pregunta.TabIndex = 12;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Pregunta Secreta ";
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(153, 77);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(151, 23);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Ingrese su usuario";
            // 
            // Recuperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 361);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtRecuperar);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Recuperate";
            this.Text = "Recuperate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recuperate_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private MetroFramework.Controls.MetroTile mtVolver;
        private MetroFramework.Controls.MetroTile mtRecuperar;
        private MetroFramework.Controls.MetroTextBox txtRespuesta;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Pregunta;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}