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

        public Piso(int numPiso,
                    string direccion, 
                    int metroscuadrados, 
                    bool esNuevo, 
                    int años,
                    float precioBase) : base(direccion, metroscuadrados, esNuevo, años, precioBase)
        {
            this.NumPiso = numPiso;
        }

        public int NumPiso { get => numPiso; set => numPiso = value; }

        public override float calcularPrecioTotal()
        {
            float resul = 0;
            return resul;
        }
    }
}
