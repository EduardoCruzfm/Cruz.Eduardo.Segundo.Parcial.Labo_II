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


        public void Ordenar(string atributo)
        {
            Vehiculo intercambio;
            int rango = listaVehiculos.Count;
            var prop1 = 0;
            var prop2 = 0;

            for (int i = 0; i < rango - 1; i++) 
            {
                for (int j = i + 1; j < rango; j++)
                {
                    if(atributo == "chasis")
                    {
                        prop1 = listaVehiculos[i].NChasis;
                        prop2 = listaVehiculos[j].NChasis;
                    }
                    else
                    {
                        prop1 = listaVehiculos[i].CantidadRuedas;
                        prop2 = listaVehiculos[j].CantidadRuedas;
                    }

                    if (prop1 > prop2)
                    {
                        intercambio = listaVehiculos[i];
                        listaVehiculos[i] = listaVehiculos[j];
                        listaVehiculos[j] = intercambio;
                    }
                }                 
            }
        }



        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            return e.listaVehiculos.Contains(v);
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }


        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;

            if (e != v)
            {
                e.listaVehiculos.Add(v);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;

            if ( e == v )
            {
                e.listaVehiculos.Remove(v);
                retorno = true;
            }
            return retorno;
        }

        
    }
}
