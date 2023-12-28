namespace OnTour.Vistas
{
    partial class MenuCliente
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
            this.mtSalir = new MetroFramework.Controls.MetroTile();
            this.mtCliente = new MetroFramework.Controls.MetroTile();
            this.mtCorreo = new MetroFramework.Controls.MetroTile();
            this.mtContrato = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtSalir
            // 
            this.mtSalir.ActiveControl = null;
            this.mtSalir.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mtSalir.Location = new System.Drawing.Point(158, 249);
            this.mtSalir.Name = "mtSalir";
            this.mtSalir.Size = new System.Drawing.Size(166, 51);
            this.mtSalir.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtSalir.TabIndex = 3;
            this.mtSalir.Text = "Salir";
            this.mtSalir.TileImage = global::OnTour.Properties.Resources.icons8_despegue_64;
            this.mtSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSalir.UseSelectable = true;
            this.mtSalir.UseTileImage = true;
            this.mtSalir.Click += new System.EventHandler(this.mtSalir_Click);
            // 
            // mtCliente
            // 
            this.mtCliente.ActiveControl = null;
            this.mtCliente.Location = new System.Drawing.Point(158, 93);
            this.mtCliente.Name = "mtCliente";
            this.mtCliente.Size = new System.Drawing.Size(166, 149);
            this.mtCliente.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtCliente.TabIndex = 2;
            this.mtCliente.Text = "Cliente";
            this.mtCliente.TileImage = global::OnTour.Properties.Resources.icons8_usuario_64;
            this.mtCliente.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCliente.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCliente.UseSelectable = true;
            this.mtCliente.UseTileImage = true;
            this.mtCliente.Click += new System.EventHandler(this.mtCliente_Click);
            // 
            // mtCorreo
            // 
            this.mtCorreo.ActiveControl = null;
            this.mtCorreo.Location = new System.Drawing.Point(34, 211);
            this.mtCorreo.Name = "mtCorreo";
            this.mtCorreo.Size = new System.Drawing.Size(118, 89);
            this.mtCorreo.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtCorreo.TabIndex = 1;
            this.mtCorreo.Text = "Correo";
            this.mtCorreo.TileImage = global::OnTour.Properties.Resources.icons8_email_64;
            this.mtCorreo.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtCorreo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCorreo.UseSelectable = true;
            this.mtCorreo.UseTileImage = true;
            this.mtCorreo.Click += new System.EventHandler(this.mtCorreo_Click);
            // 
            // mtContrato
            // 
            this.mtContrato.ActiveControl = null;
            this.mtContrato.Location = new System.Drawing.Point(34, 93);
            this.mtContrato.Name = "mtContrato";
            this.mtContrato.Size = new System.Drawing.Size(118, 112);
            this.mtContrato.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtContrato.TabIndex = 0;
            this.mtContrato.Text = "Contrato";
            this.mtContrato.TileImage = global::OnTour.Properties.Resources.icons8_acuerdo_64;
            this.mtContrato.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtContrato.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtContrato.UseSelectable = true;
            this.mtContrato.UseTileImage = true;
            this.mtContrato.Click += new System.EventHandler(this.mtContrato_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 323);
            this.Controls.Add(this.mtSalir);
            this.Controls.Add(this.mtCliente);
            this.Controls.Add(this.mtCorreo);
            this.Controls.Add(this.mtContrato);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuCliente_FormClosed);
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtContrato;
        private MetroFramework.Controls.MetroTile mtCorreo;
        private MetroFramework.Controls.MetroTile mtCliente;
        private MetroFramework.Controls.MetroTile mtSalir;
    }
}