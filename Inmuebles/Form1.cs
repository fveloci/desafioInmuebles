using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmuebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            bool bandera;

            if (radioNuevo.Checked) //Si es nuevo
                bandera = true;
            else 
                bandera = false;

            if (radioPiso.Checked)  //Si es un piso
            {                
                //Creando objeto de tipo Piso
                Piso piso1 = new Piso(Convert.ToInt32(inputPiso.Text) ,inputDireccion.Text,Convert.ToInt32(inputTamanio.Text), bandera,float.Parse(inputPrecioBase.Text));
                MessageBox.Show("El valor total del inmueble es: $"+ piso1.calcularPrecioTotal(), "Precio calculado");
                //Limpiando los textbox
                inputPiso.Text = "";
            }
            else if (radioLocal.Checked)    //Si es un local
            {
                //Creando objeto de tipo Local
                Local inmueble = new Local(Convert.ToInt32(inputVentanales.Text), inputDireccion.Text, Convert.ToInt32(inputTamanio.Text), bandera, float.Parse(inputPrecioBase.Text));
                MessageBox.Show("El valor total del inmueble es: $"+ inmueble.calcularPrecioTotal(), "Precio calculado");
                //Limpiando los textbox
                inputVentanales.Text = "";
            }

            //Limpiando los textos
            inputDireccion.Text = "";
            inputTamanio.Text = "";
            inputPrecioBase.Text = "";

        }

        private void radioPiso_CheckedChanged(object sender, EventArgs e)
        {
            //Si el RadioButtos es "Piso"
            //ocultamos los textbox del numero de ventanas
            if (radioPiso.Checked)
            {
                inputVentanales.Visible = false;
                lblVentanales.Visible = false;
            }else //Sino, los mostramos
            {
                inputVentanales.Visible = true;
                lblVentanales.Visible = true;
            }

        }

        private void radioLocal_CheckedChanged(object sender, EventArgs e)
        {
            //Si el RadioButtos es "Local"
            //ocultamos los textbox del numero de piso
            if (radioLocal.Checked)
            {
                inputPiso.Visible = false;
                lblNPiso.Visible = false;
            }
            else  //Sino, los mostramos
            {
                inputPiso.Visible = true;
                lblNPiso.Visible = true;
            }
        }

        private void radioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioPiso.Checked)
            {
                inputVentanales.Visible = false;
                lblVentanales.Visible = false;
            }
            else
            {
                inputVentanales.Visible = true;
                lblVentanales.Visible = true;
            }
        }
    }
}
