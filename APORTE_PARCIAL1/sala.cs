using System;
using System.Collections.Generic;
using System.Text;

namespace APORTE_PARCIAL1
{
    class sala: cine
    {
        public int numero_sala { get; set; }
        public int asientos { get; set; }
        public int asientosSelec { get; set; }
        public string aperitivosGratis { get; set; }
        public string accesoriosGratis { get; set; }

        //polimorfismo
        public override void mostrarDetallesCliente()
        {
            Console.WriteLine("Sala "+numero_sala+" ("+ asientos+" asientos disponibles)");
            Console.WriteLine("Asiento/s comprados: " + asientosSelec);
            Console.WriteLine("Aperitivo gratis: " + aperitivosGratis);
            Console.WriteLine("Accesorio gratis: " + accesoriosGratis);
        }
    }
}
