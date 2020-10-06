using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    abstract class Inmueble
    {
        protected string direccion;
        protected int metroscuadrados;
        protected bool esNuevo;
        protected float precioBase;

        public Inmueble(string direccion,int metroscuadrados,bool esNuevo, float precioBase)
        {
            this.direccion = direccion;
            this.metroscuadrados = metroscuadrados;
            this.esNuevo = esNuevo;
            this.precioBase = precioBase;
        }

        abstract public float calcularPrecioTotal();
    }
}
