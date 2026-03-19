using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioStrategy
{
    internal class EnvioExpressStrategy : CosteEnvioStrategy
    {
        public double CalcularCoste(double precioProducto)
        {
            return precioProducto+12.0;
        }   
    
    }
}
