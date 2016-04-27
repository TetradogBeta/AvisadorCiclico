namespace Avisador
{
    partial class ListaTemporizadores
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTemporizadores = new System.Windows.Forms.GroupBox();
            this.pnlTemp = new System.Windows.Forms.Panel();
            this.gbTemporizadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTemporizadores
            // 
            this.gbTemporizadores.Controls.Add(this.pnlTemp);
            this.gbTemporizadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTemporizadores.Location = new System.Drawing.Point(0, 0);
            this.gbTemporizadores.Name = "gbTemporizadores";
            this.gbTemporizadores.Size = new System.Drawing.Size(150, 150);
            this.gbTemporizadores.TabIndex = 0;
            this.gbTemporizadores.TabStop = false;
            this.gbTemporizadores.Text = "Temporizadores";
            // 
            // pnlTemp
            // 
            this.pnlTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTemp.Location = new System.Drawing.Point(3, 16);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(144, 131);
            this.pnlTemp.TabIndex = 0;
            // 
            // ListaTemporizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTemporizadores);
            this.Name = "ListaTemporizadores";
            this.gbTemporizadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTemporizadores;
        private System.Windows.Forms.Panel pnlTemp;
    }
}
