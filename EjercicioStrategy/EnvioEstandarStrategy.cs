
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioStrategy {
internal class EnvioEstandarStrategy : CosteEnvioStrategy
{
    public double CalcularCoste(double precioProducto)
    {
        return precioProducto+5.0; 
    }
}
}