namespace Evaluacion5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNivelDificultad = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbNivelDificultad = new System.Windows.Forms.ComboBox();
            this.cmbAreaInteres = new System.Windows.Forms.ComboBox();
            this.btnTomarDecision = new System.Windows.Forms.Button();
            this.lblRecomendacion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVacante = new System.Windows.Forms.Label();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNivelDificultad
            // 
            this.lblNivelDificultad.AllowDrop = true;
            this.lblNivelDificultad.AutoSize = true;
            this.lblNivelDificultad.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelDificultad.Location = new System.Drawing.Point(46, 149);
            this.lblNivelDificultad.Name = "lblNivelDificultad";
            this.lblNivelDificultad.Size = new System.Drawing.Size(190, 23);
            this.lblNivelDificultad.TabIndex = 18;
            this.lblNivelDificultad.Text = "Nivel de dificultad";
            // 
            // lblMateria
            // 
            this.lblMateria.AllowDrop = true;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(46, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(98, 23);
            this.lblMateria.TabIndex = 17;
            this.lblMateria.Text = "Materias";
            // 
            // cmbNivelDificultad
            // 
            this.cmbNivelDificultad.FormattingEnabled = true;
            this.cmbNivelDificultad.Items.AddRange(new object[] {
            "Facil",
            "Intermedio",
            "Avanzado"});
            this.cmbNivelDificultad.Location = new System.Drawing.Point(265, 152);
            this.cmbNivelDificultad.Name = "cmbNivelDificultad";
            this.cmbNivelDificultad.Size = new System.Drawing.Size(148, 24);
            this.cmbNivelDificultad.TabIndex = 14;
            // 
            // cmbAreaInteres
            // 
            this.cmbAreaInteres.FormattingEnabled = true;
            this.cmbAreaInteres.Items.AddRange(new object[] {
            "Matematicas",
            "Ciencias Sociales",
            "Arte",
            "Programacion"});
            this.cmbAreaInteres.Location = new System.Drawing.Point(265, 83);
            this.cmbAreaInteres.Name = "cmbAreaInteres";
            this.cmbAreaInteres.Size = new System.Drawing.Size(148, 24);
            this.cmbAreaInteres.TabIndex = 13;
            // 
            // btnTomarDecision
            // 
            this.btnTomarDecision.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTomarDecision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTomarDecision.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarDecision.Location = new System.Drawing.Point(50, 211);
            this.btnTomarDecision.Name = "btnTomarDecision";
            this.btnTomarDecision.Size = new System.Drawing.Size(242, 36);
            this.btnTomarDecision.TabIndex = 16;
            this.btnTomarDecision.Text = "Recomendacion";
            this.btnTomarDecision.UseVisualStyleBackColor = false;
            this.btnTomarDecision.Click += new System.EventHandler(this.btnTomarDecision_Click);
            // 
            // lblRecomendacion
            // 
            this.lblRecomendacion.AutoSize = true;
            this.lblRecomendacion.Location = new System.Drawing.Point(47, 286);
            this.lblRecomendacion.Name = "lblRecomendacion";
            this.lblRecomendacion.Size = new System.Drawing.Size(0, 16);
            this.lblRecomendacion.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Bright", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(145, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 31);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Cursos gratuitos Instituto Cervantes";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(419, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 22);
            this.panel1.TabIndex = 21;
            // 
            // lblVacante
            // 
            this.lblVacante.AutoSize = true;
            this.lblVacante.Location = new System.Drawing.Point(50, 350);
            this.lblVacante.Name = "lblVacante";
            this.lblVacante.Size = new System.Drawing.Size(329, 16);
            this.lblVacante.TabIndex = 22;
            this.lblVacante.Text = "Esperando recomendación para determinar vacante...";
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Location = new System.Drawing.Point(386, 342);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(84, 23);
            this.btnInscribirse.TabIndex = 23;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInscribirse);
            this.Controls.Add(this.lblVacante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblRecomendacion);
            this.Controls.Add(this.lblNivelDificultad);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbNivelDificultad);
            this.Controls.Add(this.cmbAreaInteres);
            this.Controls.Add(this.btnTomarDecision);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivelDificultad;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbNivelDificultad;
        private System.Windows.Forms.ComboBox cmbAreaInteres;
        private System.Windows.Forms.Button btnTomarDecision;
        private System.Windows.Forms.Label lblRecomendacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVacante;
        private System.Windows.Forms.Button btnInscribirse;
    }
}

