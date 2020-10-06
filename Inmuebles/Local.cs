using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Local: Inmueble
    {
        private int numVentanas;

        public Local(int numVentanas, string direccion, int metroscuadrados, bool esNuevo, float precioBase)
            : base(direccion, metroscuadrados, esNuevo, precioBase)
        {           
            this.numVentanas = numVentanas;
        }
        

        public override float calcularPrecioTotal()
        {
            float resul = precioBase;

            //Obteniendo precio segun la antiguedad
            if (esNuevo)
                resul *= 0.99f;
            else
                resul *= 0.98f;

            //Obteniendo precio segun los metros cuadrados
            if (metroscuadrados > 50)
                resul += (precioBase * 0.01f);

            //Obteniendo precio segun el numero de ventanas
            if (numVentanas <= 1)
                resul -= (precioBase * 0.02f);
            else if (numVentanas > 4)
                resul += (precioBase * 0.02f);

            return resul;
        }
    }
}
