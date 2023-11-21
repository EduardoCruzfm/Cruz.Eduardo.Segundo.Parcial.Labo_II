﻿using Biblioteca_de_Accesos;
using Cruz.Eduardo.Primer.Parcial.Labo_II;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Motocicleta honda = new Motocicleta("Honda", 2, 5, Colores.Negro, "1000");
            Motocicleta honda2 = new Motocicleta("Honda", 2, 5, Colores.Negro, "1000");
            Motocicleta benelli = new Motocicleta("Benelli", 2, 5, Colores.Rojo, "3000");
            Motocicleta yamaha = new Motocicleta("Yahama", 2, 5, Colores.Azul, "1500");
            Automovil renault = new Automovil("Renaul", 4, 6, Colores.Rojo, "400000","Diesel",4);
            Colectivo agrale = new Colectivo("Agrale", 6, 6, Colores.Blanco, "750000");
            Colectivo mercedes = new Colectivo("Mercedes benz", 6, 6, Colores.Blanco, "980000");
            Estacionamiento<Vehiculo> hs24 = new Estacionamiento<Vehiculo>("24 HORAS");

            _ = hs24 + honda;
            _ = hs24 + benelli;
            _ = hs24 + yamaha;
            _ = hs24 + renault;
            _ = hs24 + agrale;



            hs24.Ordenar("chasis");
            //hs24.Ordenar("marca");
            hs24.listVehiculos.Reverse();



            //AccesoAutomovil accesoAutomovil = new AccesoAutomovil();
            AccesoColectivo accesoMotocicleta = new AccesoColectivo();

            if (accesoMotocicleta.PruebaConexion())
            {
                Console.WriteLine("se conecto");
            }
            else
            {
                Console.WriteLine("no se conecto");
            }

            List<Colectivo> listaDatos = accesoMotocicleta.ObtenerListaDatos();


            foreach (Colectivo item in listaDatos)
            {
                Console.WriteLine(item.ToString());
            }


            Colectivo automovil = new Colectivo("Volvo", 6, 6, Colores.Rojo, "54545643", "si", 40);

            
                if (accesoMotocicleta.ModificarDato(automovil))
                {
                    Console.WriteLine("Se agredo");
                }
                else
                {
                    Console.WriteLine("No se agrego");

                }
        }
    }
}