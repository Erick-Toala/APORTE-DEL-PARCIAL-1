using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_PARCIAL1
{
    class comida: cine
    {
        public string comestibles { get; set; }
        public double precio_comi { get; set; }

        //polimorfismo
        public override void mostrarDetallesCliente()
        {
            Console.WriteLine("Productos comestibles: "+comestibles + "\nPrecio: $" + precio_comi);
        }
    }
}
