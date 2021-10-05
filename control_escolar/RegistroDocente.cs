using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace control_escolar
{
    public partial class RegistroDocente : control_escolar.RegistroGeneral
    {
        public RegistroDocente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMateria.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string materia;
            materia = txtMateria.Text;
            richTextBox1.AppendText("Materia: " + materia + System.Environment.NewLine);
        }
    }
}
