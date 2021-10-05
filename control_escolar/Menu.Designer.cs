namespace control_escolar
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntRegistro = new System.Windows.Forms.Button();
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(427, 126);
            this.btnSalir.Size = new System.Drawing.Size(122, 70);
            // 
            // bntRegistro
            // 
            this.bntRegistro.Location = new System.Drawing.Point(12, 126);
            this.bntRegistro.Name = "bntRegistro";
            this.bntRegistro.Size = new System.Drawing.Size(132, 70);
            this.bntRegistro.TabIndex = 1;
            this.bntRegistro.Text = "Registro General";
            this.bntRegistro.UseVisualStyleBackColor = true;
            this.bntRegistro.Click += new System.EventHandler(this.bntRegistro_Click);
            // 
            // btnDocente
            // 
            this.btnDocente.Location = new System.Drawing.Point(150, 126);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(132, 70);
            this.btnDocente.TabIndex = 2;
            this.btnDocente.Text = "Registro Docentes";
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Location = new System.Drawing.Point(289, 126);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(132, 70);
            this.btnEstudiante.TabIndex = 3;
            this.btnEstudiante.Text = "Registro Estudiantes";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.btnDocente);
            this.Controls.Add(this.bntRegistro);
            this.Name = "Menu";
            this.Text = "BIENVENIDOS SISTEMA DE CONTROL ESCOLAR";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.bntRegistro, 0);
            this.Controls.SetChildIndex(this.btnDocente, 0);
            this.Controls.SetChildIndex(this.btnEstudiante, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntRegistro;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnEstudiante;
    }
}
