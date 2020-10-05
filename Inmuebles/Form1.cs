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
            float precioTotal = 0;
            if (radioPiso.Checked)
            {
                Piso inmueble = new Piso(Convert.ToInt32(inputPiso.Text) ,inputDireccion.Text,Convert.ToInt32(inputTamanio.Text), true,Convert.ToInt32(inputVejez.Text),float.Parse(inputPrecioBase.Text));
                MessageBox.Show("El valor total del inmueble es: "+ inmueble.calcularPrecioTotal());
            }else if (radioLocal.Checked)
            {
                Local inmueble = new Local(Convert.ToInt32(inputVentanales.Text), inputDireccion.Text, Convert.ToInt32(inputTamanio.Text), true, Convert.ToInt32(inputVejez.Text), float.Parse(inputPrecioBase.Text));
                MessageBox.Show("El valor total del inmueble es: "+ inmueble.calcularPrecioTotal());
            }

            
        }
    }
}
