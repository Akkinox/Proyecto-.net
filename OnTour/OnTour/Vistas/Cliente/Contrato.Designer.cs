namespace OnTour.Vistas.Cliente
{
    partial class Contrato
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
            this.mtSeguros = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            this.Mostar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtSeguros
            // 
            this.mtSeguros.ActiveControl = null;
            this.mtSeguros.Location = new System.Drawing.Point(11, 186);
            this.mtSeguros.Name = "mtSeguros";
            this.mtSeguros.Size = new System.Drawing.Size(275, 75);
            this.mtSeguros.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtSeguros.TabIndex = 2;
            this.mtSeguros.Text = "Seguros";
            this.mtSeguros.TileImage = global::OnTour.Properties.Resources.icons8_seguridad_comprobado_64;
            this.mtSeguros.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSeguros.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSeguros.UseSelectable = true;
            this.mtSeguros.UseTileImage = true;
            this.mtSeguros.Click += new System.EventHandler(this.mtSeguros_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Location = new System.Drawing.Point(148, 63);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(138, 116);
            this.mtVolver.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtVolver.TabIndex = 1;
            this.mtVolver.Text = "Volver";
            this.mtVolver.TileImage = global::OnTour.Properties.Resources.icons8_volver_64;
            this.mtVolver.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtVolver.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtVolver.UseSelectable = true;
            this.mtVolver.UseTileImage = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Mostar
            // 
            this.Mostar.ActiveControl = null;
            this.Mostar.Location = new System.Drawing.Point(11, 63);
            this.Mostar.Name = "Mostar";
            this.Mostar.Size = new System.Drawing.Size(131, 116);
            this.Mostar.Style = MetroFramework.MetroColorStyle.Purple;
            this.Mostar.TabIndex = 0;
            this.Mostar.Text = "Mostrar Contratos";
            this.Mostar.TileImage = global::OnTour.Properties.Resources.icons8_mostrar_propiedad_64__1_;
            this.Mostar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mostar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Mostar.UseSelectable = true;
            this.Mostar.UseTileImage = true;
            this.Mostar.Click += new System.EventHandler(this.Mostar_Click);
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 273);
            this.Controls.Add(this.mtSeguros);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.Mostar);
            this.Name = "Contrato";
            this.Text = "Contrato";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contrato_FormClosed);
            this.Load += new System.EventHandler(this.Contrato_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Mostar;
        private MetroFramework.Controls.MetroTile mtVolver;
        private MetroFramework.Controls.MetroTile mtSeguros;
    }
}