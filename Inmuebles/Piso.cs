using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    class Piso : Inmueble
    {
        private int numPiso;

        public Piso(int numPiso,string direccion,int metroscuadrados, bool esNuevo, float precioBase) 
            : base(direccion, metroscuadrados, esNuevo, precioBase)
        {
            this.numPiso = numPiso;
        }     

        
        public override float calcularPrecioTotal()
        {
            float resul = precioBase;

            //Obteniendo el precio segun la antiguedad
            if (esNuevo)            
                resul *= 0.99f;
            else
                resul *= 0.98f;

            //Obteniendo el precio segun el numero de piso
            if (numPiso >= 3)
                resul += (precioBase * 0.03f);
            
            return resul;
        }
    }
}
