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

        /// <summary>
        /// Ordenar() Ordena segun el nombre del atributo recibido, determinado el tipo de
        /// atributo a ordenar.
        /// </summary>
        /// <param name="atributo">Por el cual va ordenar</param>
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
                        prop1 = long.Parse(listVehiculos[i].NChasis);
                        prop2 = long.Parse(listVehiculos[j].NChasis);
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


        /// <summary>
        /// "==" Verificar que se encuentre el Vehiculo en la lista.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            return e.listVehiculos.Contains(v);
        }

        /// <summary>
        /// "!=" Verificar que no se encuentre el Vehiculo en la lista.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        /// <summary>
        /// "+" Agrega un Vehiculo ala lista antes verificando que este no se escuentre.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
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

        /// <summary>
        /// "-" Elimina el Vehiculo de la lista, antes verificando que este se encuentre.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
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
