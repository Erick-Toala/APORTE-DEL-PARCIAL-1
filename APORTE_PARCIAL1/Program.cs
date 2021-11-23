using System;
using System.Collections.Generic;

namespace APORTE_PARCIAL1
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente1 = new cliente();
            cliente1.NombreCliente = "Erick Toala";

            peliculas pelicula1 = new peliculas();
            pelicula1.nombres_pelicula = "John Wick 3";
            pelicula1.numero_pelicula = 1;
            pelicula1.precio_pelicula = 5.50;

            peliculas pelicula2 = new peliculas();
            pelicula2.nombres_pelicula = "Aladdin";
            pelicula2.numero_pelicula = 2;
            pelicula2.precio_pelicula = 5.50;

            peliculas pelicula3 = new peliculas();
            pelicula3.nombres_pelicula = "Avengers";
            pelicula3.numero_pelicula = 3;
            pelicula3.precio_pelicula = 5.50;

            peliculas pelicula4 = new peliculas();
            pelicula4.nombres_pelicula = "Pikachu";
            pelicula4.numero_pelicula = 4;
            pelicula4.precio_pelicula = 5.50;

            //lista para almacenar cada pelicula
            List<peliculas> lista_peliculas = new List<peliculas>();
            lista_peliculas.Add(pelicula1);
            lista_peliculas.Add(pelicula2);
            lista_peliculas.Add(pelicula3);
            lista_peliculas.Add(pelicula4);

            foreach (peliculas item in lista_peliculas)
            {    
                item.mostrarDetallesCliente();
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine("Ingrese el numero de la pelicula que desea ver: ");
            int opPelicula;
            opPelicula = int.Parse(Console.ReadLine());

            //cracion objeto salas
            sala sala1 = new sala();
            sala1.numero_sala = 1;
            sala1.asientos = 20;
            sala1.aperitivosGratis = "Refresco";
            sala1.accesoriosGratis = "Gorra";

            sala sala2 = new sala();
            sala2.numero_sala = 2;
            sala2.asientos = 20;
            sala2.aperitivosGratis = "Palomitas pequenas";
            sala2.accesoriosGratis = "Juguete";

            sala sala3 = new sala();
            sala3.numero_sala = 3;
            sala3.asientos = 20;
            sala3.aperitivosGratis = "Barra de chocolate";
            sala3.accesoriosGratis = "Gafas";

            sala sala4 = new sala();
            sala4.numero_sala = 4;
            sala4.asientos = 20;
            sala4.aperitivosGratis = "Piruleta";
            sala4.accesoriosGratis = "Poster";

            comida comida1 = new comida();
            comida1.comestibles = "";
            List<sala> lista_salas = new List<sala>();
            lista_salas.Add(sala1);
            lista_salas.Add(sala2);
            lista_salas.Add(sala3);
            lista_salas.Add(sala4);

            List<cine> lista_todoCine = new List<cine>();
            lista_todoCine.Add(cliente1);
            List<string> lista_comida = new List<string>();
            List<int> lista_asientos = new List<int>();
            //inicio
            foreach (peliculas itemPeli in lista_peliculas)
            {

                //condicion para las peliculas
                if (itemPeli.numero_pelicula== opPelicula)
                {
                    Console.WriteLine("Pelicula seleccionada: "+ itemPeli.nombres_pelicula);
                    //condicion para la primer pelicula
                    if (opPelicula==1)
                    {
                        lista_todoCine.Add(pelicula1);
                        Console.WriteLine("Salas disponibles: \nSala 1 \nSala 4\nSeleccione numero de sala: ");
                        int opSala = int.Parse(Console.ReadLine());
                        foreach (sala itemSala in lista_salas)
                        {
                            //condicion para la sala
                            if (itemSala.numero_sala == opSala)
                            {                               
                                Console.WriteLine("Sala seleccionada: " + itemSala.numero_sala);
                                Console.WriteLine("Asientos Disponibles(" + itemSala.asientos + ")");
                                Console.WriteLine("Ingrese numero de entradas: ");
                                itemSala.asientosSelec = int.Parse(Console.ReadLine());
                                itemSala.asientos = itemSala.asientos - itemSala.asientosSelec;
                                int selcAsiento = 0;
                                int acum = 0;
                                do
                                {
                                    acum++;
                                    
                                    Console.WriteLine("Seleccione asiento " + acum + ":");
                                    selcAsiento = int.Parse(Console.ReadLine());
                                    lista_asientos.Add(selcAsiento);
                                } while (acum != itemSala.asientosSelec);
                                Console.WriteLine("Compra de productos comestibles\nSeleccione cuantos productos desea comprar");
                                int n_productos = int.Parse(Console.ReadLine());
                                int acum2 = 0;
                                do
                                {
                                    acum2++;
                                    Console.WriteLine("Ingrese comestible" + acum2 + ":");
                                    string comidaPedir = Console.ReadLine();
                                    lista_comida.Add(comidaPedir);
                                } while (acum2 != n_productos);
                                lista_todoCine.Add(itemSala);
                            }
                            
                        }
                    }

                    //condicion para la segunda pelicula
                    if (opPelicula == 2)
                    {
                        lista_todoCine.Add(pelicula1);
                        Console.WriteLine("Salas disponibles: \nSala 1 \nSala 2\nSeleccione numero de sala: ");
                        int opSala = int.Parse(Console.ReadLine());
                        foreach (sala itemSala in lista_salas)
                        {
                            //condicion para la sala
                            if (itemSala.numero_sala == opSala)
                            {
                                Console.WriteLine("Sala seleccionada: " + itemSala.numero_sala);
                                Console.WriteLine("Asientos Disponibles(" + itemSala.asientos + ")");
                                Console.WriteLine("Ingrese numero de entradas: ");
                                itemSala.asientosSelec = int.Parse(Console.ReadLine());
                                itemSala.asientos = itemSala.asientos - itemSala.asientosSelec;
                                int selcAsiento = 0;
                                int acum = 0;
                                do
                                {
                                    acum++;
                                    
                                    Console.WriteLine("Seleccione asiento " + acum + ":");
                                    selcAsiento = int.Parse(Console.ReadLine());
                                    lista_asientos.Add(selcAsiento);
                                } while (acum != itemSala.asientosSelec);
                                Console.WriteLine("Compra de productos comestibles\nSeleccione cuantos productos desea comprar");
                                int n_productos = int.Parse(Console.ReadLine());
                                int acum2 = 0;
                                do
                                {
                                    acum2++;
                                    Console.WriteLine("Ingrese comestible" + acum2 + ":");
                                    string comidaPedir = Console.ReadLine();
                                    lista_comida.Add(comidaPedir);
                                } while (acum2 != n_productos);
                                lista_todoCine.Add(itemSala);
                            }

                        }
                    }
                    //condicion para la tercer pelicula
                    if (opPelicula == 3)
                    {
                        lista_todoCine.Add(pelicula1);
                        Console.WriteLine("Salas disponibles: \nSala 2 \nSala 3\nSeleccione numero de sala: ");
                        int opSala = int.Parse(Console.ReadLine());
                        foreach (sala itemSala in lista_salas)
                        {
                            //condicion para la sala
                            if (itemSala.numero_sala == opSala)
                            {
                                Console.WriteLine("Sala seleccionada: " + itemSala.numero_sala);
                                Console.WriteLine("Asientos Disponibles(" + itemSala.asientos + ")");
                                Console.WriteLine("Ingrese numero de entradas: ");
                                itemSala.asientosSelec = int.Parse(Console.ReadLine());
                                itemSala.asientos = itemSala.asientos - itemSala.asientosSelec;
                                int selcAsiento = 0;
                                int acum = 0;
                                do
                                {
                                    acum++;
                                    
                                    Console.WriteLine("Seleccione asiento " + acum + ":");
                                    selcAsiento = int.Parse(Console.ReadLine());
                                    lista_asientos.Add(selcAsiento);
                                } while (acum != itemSala.asientosSelec);
                                Console.WriteLine("Compra de productos comestibles\nSeleccione cuantos productos desea comprar");
                                int n_productos = int.Parse(Console.ReadLine());
                                int acum2 = 0;
                                do
                                {
                                    acum2++;
                                    Console.WriteLine("Ingrese comestible" + acum2 + ":");
                                    string comidaPedir = Console.ReadLine();
                                    lista_comida.Add(comidaPedir);
                                } while (acum2 != n_productos);
                                lista_todoCine.Add(itemSala);
                            }

                        }
                    }
                    //condicion para la cuarta pelicula
                    if (opPelicula == 4)
                    {
                        lista_todoCine.Add(pelicula1);
                        Console.WriteLine("Salas disponibles: \nSala 3 \nSala 4\nSeleccione numero de sala: ");
                        int opSala = int.Parse(Console.ReadLine());
                        foreach (sala itemSala in lista_salas)
                        {
                            //condicion para la sala
                            if (itemSala.numero_sala == opSala)
                            {
                                Console.WriteLine("Sala seleccionada: " + itemSala.numero_sala);
                                Console.WriteLine("Asientos Disponibles(" + itemSala.asientos + ")");
                                Console.WriteLine("Ingrese numero de entradas: ");
                                itemSala.asientosSelec = int.Parse(Console.ReadLine());
                                itemSala.asientos = itemSala.asientos - itemSala.asientosSelec;
                                int selcAsiento = 0;
                                int acum = 0;
                                do
                                {
                                    acum++;
                                   
                                    Console.WriteLine("Seleccione asiento " + acum + ":");
                                    selcAsiento = int.Parse(Console.ReadLine());
                                    lista_asientos.Add(selcAsiento);
                                } while (acum != itemSala.asientosSelec);
                                Console.WriteLine("Compra de productos comestibles\nSeleccione cuantos productos desea comprar");
                                int n_productos = int.Parse(Console.ReadLine());
                                int acum2 = 0;
                                do
                                {
                                    acum2++;
                                    Console.WriteLine("Ingrese comestible " + acum2 + ":");
                                    string comidaPedir = Console.ReadLine();
                                    lista_comida.Add(comidaPedir);
                                } while (acum2 != n_productos);
                                lista_todoCine.Add(itemSala);
                            }

                        }
                    }
                    //

                }
                //condicion final de pelicula


            }
            //fin

            Console.WriteLine("");

            //metodo imprimir todo
            foreach (cine item in lista_todoCine)
            {
                item.mostrarDetallesCliente();
            }
            int num=0;
            Console.WriteLine("Los asientos seleccionados son: ");
            foreach (int item in lista_asientos)
            {
                Console.WriteLine("Asiento "+item);
            }
            Console.WriteLine("Los comestibles comprados son: ");
            foreach (string item in lista_comida)
            {
                num++;
                Console.WriteLine(num+". "+item);
                
            }
        }
    }
}
