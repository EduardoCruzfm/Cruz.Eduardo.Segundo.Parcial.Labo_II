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
        public List<Vehiculo> listVehiculos;

        public Estacionamiento(string nombre)
        {
            this.listVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
        }


        public void Ordenar(string atributo)
        {
            Vehiculo intercambio;
            int rango = listVehiculos.Count;
            long prop1;
            long prop2;

            for (int i = 0; i < rango - 1; i++) 
            {
                for (int j = i + 1; j < rango; j++)
                {
                    if(atributo == "chasis")
                    {
                        prop1 = listVehiculos[i].NChasis;
                        prop2 = listVehiculos[j].NChasis;
                    }
                    else
                    {
                        prop1 = listVehiculos[i].CantidadRuedas;
                        prop2 = listVehiculos[j].CantidadRuedas;
                    }

                    if (prop1 > prop2)
                    {
                        intercambio = listVehiculos[i];
                        listVehiculos[i] = listVehiculos[j];
                        listVehiculos[j] = intercambio;
                    }
                }                 
            }
        }



        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            return e.listVehiculos.Contains(v);
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
                e.listVehiculos.Add(v);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;

            if ( e == v )
            {
                e.listVehiculos.Remove(v);
                retorno = true;
            }
            return retorno;
        }

        
    }
}
