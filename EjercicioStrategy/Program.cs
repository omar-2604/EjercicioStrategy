using System;

namespace EjercicioStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creamos el objeto pedido
            Pedido miPedido = new Pedido();

            // 2. Le asignamos el valor de 100€
            miPedido.precioProducto = 100;

            // --- PRUEBA 1: ENVÍO ESTÁNDAR ---
            miPedido.SetCoste(new EnvioEstandarStrategy());
            Console.WriteLine(" Envío Estándar...\n" + miPedido.MostrarTotal()+" euros");
           
        

            // --- PRUEBA 2: ENVÍO INTERNACIONAL ---
            miPedido.SetCoste(new EnvioInternacionalStrategy());
            Console.WriteLine(" Envío Internacional...\n" + miPedido.MostrarTotal()+" euros");
     

            // --- PRUEBA 3: RECOGIDA EN TIENDA ---
            miPedido.SetCoste(new RecogidaEnTiendaStrategy());
            Console.WriteLine(" Recogida en Tienda... \n" + miPedido.MostrarTotal() + " euros");
         
            Console.ReadLine();
        }
    }
}