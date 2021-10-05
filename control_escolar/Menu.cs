using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace control_escolar
{
    public partial class Menu : control_escolar.FormBase
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bntRegistro_Click(object sender, EventArgs e)
        {
            //Creamos un objeto o una ventana registro general
            RegistroGeneral general = new RegistroGeneral();
            this.Hide(); //ocultar la ventana actual (menu)
            general.Show(); //mostramos la nueva ventana registro general
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            //Creamos un objeto o una ventana registro general
            RegistroDocente docente = new RegistroDocente();
            this.Hide(); //ocultar la ventana actual (menu)
            docente.Show(); //mostramos la nueva ventana registro general
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            //Creamos un objeto o una ventana registro general
            RegistroEstudiante estudiante = new RegistroEstudiante();
            this.Hide(); //ocultar la ventana actual (menu)
            estudiante.Show(); //mostramos la nueva ventana registro general
        }
    }
}
