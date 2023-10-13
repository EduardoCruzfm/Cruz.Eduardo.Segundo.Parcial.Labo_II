using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public class Estacionamiento
    {
        public string nombre;
        public List<Vehiculo> listaVehiculos;

        public Estacionamiento(string nombre)
        {
            this.listaVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
        }


        public void Ordenar()
        {
            int rango = listaVehiculos.Count;
            Vehiculo intercambio;

            for (int i = 0; i < rango - 1; i++) 
            {
            
                for (int j = i+1 ; j < rango; j++)
                {
                    if (listaVehiculos[i].NChasis > listaVehiculos[j].NChasis)
                    {
                        intercambio = listaVehiculos[i];
                        listaVehiculos[i] = listaVehiculos[j];
                        listaVehiculos[j] = intercambio;
                    }
                }
                  
            }

        }




        public static bool operator +(Estacionamiento e,Vehiculo v)
        {
            bool retorno = false;

            if ( !(e.listaVehiculos.Contains(v)) )
            {
                e.listaVehiculos.Add(v);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;

            if ( e.listaVehiculos.Contains(v) )
            {
                e.listaVehiculos.Remove(v);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            return e.listaVehiculos.Contains(v);
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
    }
}
