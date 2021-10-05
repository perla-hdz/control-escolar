using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace control_escolar
{
    public partial class RegistroGeneral : control_escolar.FormBase
    {
        public RegistroGeneral()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Creamos un objeto o una ventana menu
            Menu menu = new Menu();
            this.Hide(); //ocultar la ventana actual (registro general)
            menu.Show(); //mostramos la nueva ventana menu
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiamos nuestros campos
            txtNombre.Clear();
            txtUsuario.Clear();
            txtCodigo.Clear();
            richTextBox1.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // creamos las cadenas de texto (donde voy a poner lo que se almacena en el cuadro de texto)
            string nombre, usuario, codigo;
            //leemos los datos de mi caja de texto y se lo cargamos a las cadenas
            nombre  = txtNombre.Text;
            usuario = txtUsuario.Text;
            codigo  = txtCodigo.Text;
            //pintamos o escribimos valores en la caja de texto enriquecida
            richTextBox1.AppendText(nombre  + System.Environment.NewLine); //perla = Txtnombre
            richTextBox1.AppendText(usuario + System.Environment.NewLine); //123 =Txtusuraio
            richTextBox1.AppendText(codigo  + System.Environment.NewLine); //987 =txtcodigo
        }

        private void btnModificar_Click(object sender, EventArgs e)
        { 
            //vamos a realizar una comparacion entre el contenido de mi richtextbox con mi txtbox
            if (richTextBox1.Text != "") //¿el richtextbox esta vacio?
            {
                String str1 = richTextBox1.Text; //perla
                String str2 = richTextBox1.Lines[2]; //123
                String str3 = richTextBox1.Lines[3]; //987

                string[] s = {txtNombre.Text, txtUsuario.Text, txtCodigo.Text};                
                
                Boolean res, res1, res2;
                     //perla.equals(samy)  =  false 
                res = str1.Equals(txtNombre.Text); //true o false
                res1 = str2.Equals(txtUsuario.Text); //true o false
                res2 = str3.Equals(txtCodigo.Text); //true o false
                
                //caso cierto (el richtextbox tiene datos, tiena algo la caja)
                if (res == false) //cuando todas las cadenas son iguales
                 {
                     richTextBox1.AppendText("str1 esta es la linea uno = " + str1);
                     richTextBox1.AppendText("str4 esta es la linea uno = " + str4 + System.Environment.NewLine); 
                    richTextBox1.AppendText("valor de res:               " + res  + System.Environment.NewLine); 
                 }
                else
                {
                    richTextBox1.AppendText("verdadero" + res);
                }
                                 
            }
            else
            {
                //caso falso (el richtextbox no tiene datos, no tiene nada esta limpia)
                richTextBox1.AppendText("no hay datos que modificar");
            }
        }    
    }
}
