using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioStrategy
{
    internal class Pedido
    {
        public double PrecioProducto;
        private CosteEnvioStrategy coste;
        public void SetCoste(CosteEnvioStrategy coste)
        {
            this.coste = coste;
        }
        public double MostrarTotal()
        {
            return coste.CalcularCoste(PrecioProducto);
            Console.WriteLine("Precio: " + precioProducto);
            Console.WriteLine("Envío: " + envio);
            Console.WriteLine("Total: " + (precioProducto + envio));
        }

    }
}
