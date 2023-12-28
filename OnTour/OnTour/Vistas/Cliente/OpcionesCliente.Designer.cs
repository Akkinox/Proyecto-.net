namespace OnTour.Vistas.Cliente
{
    partial class OpcionesCliente
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
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.mtDeposito = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(318, 80);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(75, 142);
            this.mtVolver.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtVolver.TabIndex = 4;
            this.mtVolver.Text = "Volver";
            this.mtVolver.TileImage = global::OnTour.Properties.Resources.icons8_volver_64;
            this.mtVolver.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtVolver.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtVolver.UseSelectable = true;
            this.mtVolver.UseTileImage = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(184, 136);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(128, 86);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Actividades";
            this.metroTile3.TileImage = global::OnTour.Properties.Resources.icons8_calendario_de_rasgar_las_hojas_64;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(184, 80);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(128, 50);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Monto";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileImage = global::OnTour.Properties.Resources.icons8_montón_de_dinero_64;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mtDeposito
            // 
            this.mtDeposito.ActiveControl = null;
            this.mtDeposito.Location = new System.Drawing.Point(34, 80);
            this.mtDeposito.Name = "mtDeposito";
            this.mtDeposito.Size = new System.Drawing.Size(144, 142);
            this.mtDeposito.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtDeposito.TabIndex = 1;
            this.mtDeposito.Text = "Realizar Deposito";
            this.mtDeposito.TileImage = global::OnTour.Properties.Resources.icons8_depósito_64;
            this.mtDeposito.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDeposito.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDeposito.UseSelectable = true;
            this.mtDeposito.UseTileImage = true;
            this.mtDeposito.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // OpcionesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 263);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtDeposito);
            this.Name = "OpcionesCliente";
            this.Text = "OpcionesCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpcionesCliente_FormClosed);
            this.Load += new System.EventHandler(this.OpcionesCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtDeposito;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}