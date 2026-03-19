using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioStrategy
{
    internal class RecogidaEnTiendaStrategy: CosteEnvioStrategy
    {
        public double CalcularCoste(double precioProducto)
        {
            return precioProducto;
        }
    
    }
}
