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

        private Boolean validar(string dato, string tipo)
        {            

            switch (tipo)
            {
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                    break;

                case "float":
                    try
                    {
                        Convert.ToSingle(dato);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                    break;

                default:
                    return false;
                    break;
            }
           
        }

        private void limpiarTextBoxGenerales()
        {
            //Se usa porque no importa que inmueble elija,
            //estos textbox siempre se van a tener que vaciar
            //despues de calcular un precio
            inputDireccion.Text = "";
            inputTamanio.Text = "";
            inputPrecioBase.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            bool esNuevo;
            bool validarPrecioBase;
            bool validarTamanio;
            

            if (radioNuevo.Checked) //Si el inmueble es nuevo
                esNuevo = true;
            else
                esNuevo = false;

            //Validando atributos del objeto
            validarPrecioBase = validar(inputPrecioBase.Text, "float");
            validarTamanio = validar(inputTamanio.Text, "float");

            if(radioPiso.Checked)  //Si es un piso
             {               
                #region CREAR Y OBTENER EL PRECIO DEL PISO
                    
                bool validarNroPiso = validar(inputPiso.Text, "int");

                if (validarNroPiso && validarPrecioBase && validarTamanio)
                {
                    //Creando objeto de tipo Piso
                    Piso piso1 = new Piso(Convert.ToInt32(inputPiso.Text), inputDireccion.Text, Convert.ToInt32(inputTamanio.Text), esNuevo, Convert.ToSingle(inputPrecioBase.Text));
                    MessageBox.Show("El valor total del inmueble es: $" + piso1.calcularPrecioTotal(), "Precio calculado");
                    //Limpiando los textbox
                    inputPiso.Text = "";
                    limpiarTextBoxGenerales();
                    //Pintando de blanco el color del textbox
                    inputPiso.BackColor = System.Drawing.Color.White;
                    inputPrecioBase.BackColor = System.Drawing.Color.White;
                    inputTamanio.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    #region PINTAR DE NARANJA LOS CAMPOS INVALIDOS, Y DE BLANCO LOS VALIDOS
                    //Pintar campo numero de piso
                    if (!validarNroPiso)
                        inputPiso.BackColor = System.Drawing.Color.Orange;
                    else
                        inputPiso.BackColor = System.Drawing.Color.White;

                    //Pintar campo precio base
                    if (!validarPrecioBase)
                        inputPrecioBase.BackColor = System.Drawing.Color.Orange;
                    else
                        inputPrecioBase.BackColor = System.Drawing.Color.White;

                    //Pintar campo tamaño
                    if (!validarTamanio)
                        inputTamanio.BackColor = System.Drawing.Color.Orange;
                    else
                        inputTamanio.BackColor = System.Drawing.Color.White;

                    #endregion
                }

                #endregion

            }
             else   //Si es un local
             {               
                #region CREAR Y OBTENER EL PRECIO DEL LOCAL

                bool validarVentanales = validar(inputVentanales.Text, "int");

                if (validarVentanales && validarPrecioBase && validarTamanio)  //Si se valida el numero de vantanas
                {
                    //Creando objeto de tipo Local
                    Local inmueble = new Local(Convert.ToInt32(inputVentanales.Text), inputDireccion.Text, Convert.ToInt32(inputTamanio.Text), esNuevo, Convert.ToSingle(inputPrecioBase.Text));
                    MessageBox.Show("El valor total del inmueble es: $" + inmueble.calcularPrecioTotal(), "Precio calculado");
                    //Limpiando los textbox
                    inputVentanales.Text = "";
                    limpiarTextBoxGenerales();
                    //Pintando de blanco el color del textbox
                    inputVentanales.BackColor = System.Drawing.Color.White;
                    inputPrecioBase.BackColor = System.Drawing.Color.White;
                    inputTamanio.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    #region PINTAR DE NARANJA LOS CAMPOS INVALIDOS, Y DE BLANCO LOS VALIDOS

                    //Pintando campo ventanales
                    if (!validarVentanales)
                        inputVentanales.BackColor = System.Drawing.Color.Orange;
                    else
                        inputVentanales.BackColor = System.Drawing.Color.White;

                    //Pintando campo precio base
                    if (!validarPrecioBase)
                        inputPrecioBase.BackColor = System.Drawing.Color.Orange;
                    else
                        inputPrecioBase.BackColor = System.Drawing.Color.White;

                    //PPintando campo tamaño
                    if (!validarTamanio)
                        inputTamanio.BackColor = System.Drawing.Color.Orange;
                    else
                        inputTamanio.BackColor = System.Drawing.Color.White;

                    #endregion
                }

                #endregion
            }                                   

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
