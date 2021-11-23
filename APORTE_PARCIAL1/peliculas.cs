using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_PARCIAL1
{
    class peliculas: cine
    {
        public int numero_pelicula { get; set; }
        public string nombres_pelicula { get; set; }
        public double precio_pelicula { get; set; }

        //polimorfismo
        public override void mostrarDetallesCliente()
        {
            Console.WriteLine(numero_pelicula + ". Pelicula: " + nombres_pelicula+ "\nPrecio: $"+ precio_pelicula);
        }

    }
}
