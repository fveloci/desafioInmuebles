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

        public Local(int numVentanas, 
                     string direccion, 
                     int metroscuadrados, 
                     bool esNuevo, 
                     int años,
                     float precioBase): base(direccion, metroscuadrados, esNuevo, años, precioBase)
        {           
            this.numVentanas = numVentanas;
        }
        

        public int NumVentanas { get => numVentanas; set => numVentanas = value; }

        

        public override float calcularPrecioTotal()
        {
            float resul = 0;
            return resul;
        }
    }
}
