namespace Avisador
{
    partial class frmAvisador
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTiempoParaSonar = new System.Windows.Forms.Label();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.btnAñadirTemp = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombreTono = new System.Windows.Forms.Label();
            this.listaTemporizadores1 = new Avisador.ListaTemporizadores();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempoParaSonar
            // 
            this.lblTiempoParaSonar.AutoSize = true;
            this.lblTiempoParaSonar.Location = new System.Drawing.Point(26, 24);
            this.lblTiempoParaSonar.Name = "lblTiempoParaSonar";
            this.lblTiempoParaSonar.Size = new System.Drawing.Size(92, 13);
            this.lblTiempoParaSonar.TabIndex = 0;
            this.lblTiempoParaSonar.Text = "TiempoParaSonar";
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.Location = new System.Drawing.Point(156, 24);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(83, 13);
            this.lblTiempoRestante.TabIndex = 1;
            this.lblTiempoRestante.Text = "Tiempo restante";
            // 
            // btnAñadirTemp
            // 
            this.btnAñadirTemp.Location = new System.Drawing.Point(195, 48);
            this.btnAñadirTemp.Name = "btnAñadirTemp";
            this.btnAñadirTemp.Size = new System.Drawing.Size(62, 19);
            this.btnAñadirTemp.TabIndex = 3;
            this.btnAñadirTemp.Text = "Añadir";
            this.btnAñadirTemp.UseVisualStyleBackColor = true;
            this.btnAñadirTemp.Click += new System.EventHandler(this.btnAñadirTemp_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(29, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(114, 48);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(87, 55);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(13, 13);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "h";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(172, 55);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(15, 13);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hora Siguiente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiempo restante";
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(247, 14);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(10, 23);
            this.btnSig.TabIndex = 11;
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tono";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblNombreTono
            // 
            this.lblNombreTono.AutoSize = true;
            this.lblNombreTono.Location = new System.Drawing.Point(131, 215);
            this.lblNombreTono.Name = "lblNombreTono";
            this.lblNombreTono.Size = new System.Drawing.Size(67, 13);
            this.lblNombreTono.TabIndex = 13;
            this.lblNombreTono.Text = "nombreTono";
            // 
            // listaTemporizadores1
            // 
            this.listaTemporizadores1.Location = new System.Drawing.Point(29, 85);
            this.listaTemporizadores1.Name = "listaTemporizadores1";
            this.listaTemporizadores1.Size = new System.Drawing.Size(228, 120);
            this.listaTemporizadores1.TabIndex = 8;
            this.listaTemporizadores1.Hora += new Avisador.HoraSiguienteEventHandler(this.listaTemporizadores1_Hora);
            // 
            // frmAvisador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.lblNombreTono);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaTemporizadores1);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAñadirTemp);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.lblTiempoParaSonar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAvisador";
            this.Text = "Avisador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAvisador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempoParaSonar;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Button btnAñadirTemp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private ListaTemporizadores listaTemporizadores1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombreTono;
    }
}

