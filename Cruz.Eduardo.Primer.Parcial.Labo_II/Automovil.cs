﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    /// <summary>
    /// Clase que representa un Automovil, que hereda de la clase Vehiculo.
    /// </summary>
    public class Automovil : Vehiculo
    {
        public string tipoDeCombustible;
        protected short cantidadPuertas;

        /// <summary>
        /// Constructor predeterminado de la clase Automovil.
        /// Inicializa una nueva instancia de Automovil sin valores iniciales.
        /// </summary>
        public Automovil() { }

        /// <summary>
        ///  Constructor de la clase Automovil que inicializa una nueva instancia de 
        ///  Automovil con los parámetros especificados.
        /// </summary>
        /// <param name="marca">La marca del automóvil.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del automóvil.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del automóvil.</param>
        /// <param name="color">El color del automóvil.</param>
        /// <param name="nChasis">El número de chasis del automóvil.</param>
        public Automovil(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis) 
            : base(marca,cantidadRuedas, cantidadMarchas, color, nChasis)
        {
        }

        /// <summary>
        /// Constructor de la clase Automovil que inicializa una nueva instancia de 
        /// Automovil que permite especificar el tipo de combustible.
        /// </summary>
        /// <param name="marca">La marca del automóvil.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del automóvil.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del automóvil.</param>
        /// <param name="color">El color del automóvil.</param>
        /// <param name="nChasis">El número de chasis del automóvil.</param>
        /// <param name="tipoDeCombustible">El tipo de combustible utilizado por el automóvil.</param>
        public Automovil(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis, string tipoDeCombustible) 
            : this(marca,cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.tipoDeCombustible = tipoDeCombustible;
        }

        /// <summary>
        /// Constructor de la clase Automovil que inicializa una nueva instancia de 
        /// Automovil que permite especificar la cantidad de puertas.
        /// </summary>
        /// <param name="marca">La marca del automóvil.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del automóvil.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del automóvil.</param>
        /// <param name="color">El color del automóvil.</param>
        /// <param name="nChasis">El número de chasis del automóvil.</param>
        /// <param name="tipoDeCombustible">El tipo de combustible utilizado por el automóvil.</param>
        /// <param name="cantidadPuertas">La cantidad de puertas del automóvil.</param>
        public Automovil(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis, string tipoDeCombustible, short cantidadPuertas)
            : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis, tipoDeCombustible)
        {   
            this.cantidadPuertas = cantidadPuertas;
        }


        #region Propiedades
        /// <summary>
        /// Representa el tipo de combustible del automovil.
        /// </summary>
        public string TipoDeCombustible
        {
            get { return this.tipoDeCombustible; }
            set { this.tipoDeCombustible = value; }
        }

        /// <summary>
        /// Representa la cantidad de puertas del automovil.
        /// </summary>
        public short CantidadDePuertas
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; } 
        }
        #endregion

        protected override string TipoDeVeihculo()
        {
            return "AUTOMOVIL";
        }

        protected override bool VerificarCantRuedas()
        {
            return this.cantidadRuedas == 4;
        }

        /// <summary>
        /// ToString() Devuelve los datos de los atributos del objeto.
        /// </summary>
        /// <returns>Retorna una string con los datos del Objeto.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            //sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");
            sb.AppendLine($"Cantidad de puertas: {this.cantidadPuertas} -");
            sb.AppendLine($"Combustible: {this.tipoDeCombustible} -");

            return sb.ToString();
        }

        /// <summary>
        /// Equals() Determina si el objeto actual es igual a Automovil.
        /// </summary>
        /// <param name="obj">El objeto que se va a comparar con el objeto actual.</param>
        /// <returns>Retorna true si el objeto actual es igual al parámetro obj; de lo contrario, false.</returns>
        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Automovil)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// == Compara dos Automoviles si son iguales por sus atributos :  NChasis y marca.
        /// </summary>
        /// <param name="v1">Almacena un Automovil para la igualacion.</param>
        /// <param name="v2">Almacena otro Automovil para la igualacion.</param>
        /// <returns>Retorna true cuando son igualaes, de lo contrario false.</returns>
        public static bool operator ==(Automovil a1, Automovil a2)
        {
            return ((Vehiculo)a1).Equals(a2);
        }

        /// <summary>
        /// != Compara dos Automoviles si son distintos por sus atributos :  NChasis y marca.
        /// </summary>
        /// <param name="v1">Almacena un Automovil para la comparacion.</param>
        /// <param name="v2">Almacena otro Automovil para la comparacion.</param>
        /// <returns>Retorna true cuando son distintos, de lo contrario false.</returns>
        public static bool operator !=(Automovil a1, Automovil a2)
        {
            return !(a1 == a2);
        }
    }
}
