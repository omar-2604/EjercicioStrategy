using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioStrategy
{
    internal interface CosteEnvioStrategy
    {
        double CalcularCoste(double precioProducto);
    }
}
