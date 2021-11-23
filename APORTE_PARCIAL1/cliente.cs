using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_PARCIAL1
{
    class cliente: cine
    {
        public string NombreCliente { get; set; }
        public string peliculaSeleccionada { get; set; }
        public string salaSeleccionada { get; set; }


        //polimorfismo
        public override void mostrarDetallesCliente()
        {
            Console.WriteLine("Nombre Cliente: "+NombreCliente);
        }

    }
}
