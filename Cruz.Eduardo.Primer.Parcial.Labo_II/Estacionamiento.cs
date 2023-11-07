using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public class Estacionamiento<T>
        where T : Vehiculo
    {
        public string nombre;
        public List<T> listVehiculos;

        /// <summary>
        /// Constructor de la clase Estacionamiento.
        /// </summary>
        /// <param name="nombre">Nombre del estacionamiento.</param>
        public Estacionamiento(string nombre)
        {
            this.listVehiculos = new List<T>();
            this.nombre = nombre;
        }

        /// <summary>
        /// Ordenar() Ordena segun el nombre del atributo recibido, determinado el tipo de
        /// atributo a ordenar.
        /// </summary>
        /// <param name="atributo">Atributo por el cual va realizar el orden</param>
        public void Ordenar(string atributo)
        {
            T intercambio;
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
        /// "==" Verificar que se encuentre el Vehiculo en la lista, 
        /// reutilizando el == sobrecargado de la clase Vehiculo.
        /// </summary>
        /// <param name="e">Almacena un Estacionamiento para buscar si se encuentra o no el Vehiculo.</param>
        /// <param name="v">Almacena un Vehiculo para la comparacion.</param>
        /// <returns>Retorna un true si se encuentra el objeto, de lo contrario false.</returns>
        public static bool operator ==(Estacionamiento<T> e, T v)
        {
            bool retorno = false;

            foreach (Vehiculo item in e.listVehiculos)
            {
                if( item == v)
                //if(item.Equals(v))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// "!=" Verificar que no se encuentre el Vehiculo en la lista.
        /// </summary>
        /// <param name="e">Almacena un Estacionamiento para buscar si se encuentra o no el Vehiculo.</param>
        /// <param name="v">Almacena un Vehiculo para la comparacion.</param>
        /// <returns>Retorna true si nose encuentra Vehiculo, de lo contrario false.</returns>
        public static bool operator !=(Estacionamiento<T> e, T v)
        {
            return !(e == v);
        }

        /// <summary>
        /// "+" Agrega un Vehiculo ala lista antes verificando que este no se escuentre.
        /// </summary>
        /// <param name="e">Almacena un Estacionamiento para buscar si se encuentra o no el Vehiculo.</param>
        /// <param name="v">Almacena un Vehiculo para la comparacion.</param>
        /// <returns>Retorna true si agrega el Vehiculo ala lista, de lo contrario false</returns>
        public static bool operator +(Estacionamiento<T> e, T v)
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
        public static bool operator -(Estacionamiento<T> e, T v)
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
