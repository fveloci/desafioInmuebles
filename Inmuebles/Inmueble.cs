using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmuebles
{
    abstract class Inmueble
    {
        private string direccion;
        private int metroscuadrados;
        private bool esNuevo;
        private int años;
        private float precioBase;

        public Inmueble(String direccion,int metroscuadrados,bool esNuevo, int años, float precioBase)
        {
            this.direccion = direccion;
            this.metroscuadrados = metroscuadrados;
            this.EsNuevo = esNuevo;
            this.Años = años;
            this.precioBase = precioBase;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public int Metroscuadrados { get => metroscuadrados; set => metroscuadrados = value; }
        public bool EsNuevo { get => esNuevo; set => esNuevo = value; }
        public int Años { get => años; set => años = value; }

        abstract public float calcularPrecioTotal();
    }
}
