using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    /// <summary>
    /// Clase que representa un Colectivo, que hereda de la clase Vehiculo.
    /// </summary>
    public class Colectivo : Vehiculo
    {
        public string esAutomatico;
        public int cantidadDePasajeros;

        /// <summary>
        /// Constructor predeterminado de la clase Colectivo.
        /// Inicializa una nueva instancia de Colectivo sin valores iniciales.
        /// </summary>
        public Colectivo() {  }

        /// <summary>
        /// Constructor de la clase Colectivo que inicializa una nueva instancia de 
        /// Colectivo con los parámetros especificados.
        /// </summary>
        /// <param name="marca">La marca del colectivo.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del colectivo.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del colectivo.</param>
        /// <param name="color">El color del colectivo.</param>
        /// <param name="nChasis">El número de chasis del colectivo.</param>
        public Colectivo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis) 
            : base(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {

        }

        /// <summary>
        /// Constructor de la clase Colectivo que inicializa una nueva instancia de 
        /// Colectivo que permite especificar si es automatico.
        /// </summary>
        /// <param name="marca">La marca del colectivo.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del colectivo.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del colectivo.</param>
        /// <param name="color">El color del colectivo.</param>
        /// <param name="nChasis">El número de chasis del colectivo.</param>
        /// <param name="esAutomatico"></param>
        public Colectivo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis, string esAutomatico)
            : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.esAutomatico = esAutomatico;
        }

        /// <summary>
        /// Constructor de la clase Colectivo que inicializa una nueva instancia de 
        /// Colectivo que permite especificar la cantidad de pasajeros.
        /// </summary>
        /// <param name="marca">La marca del colectivo.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del colectivo.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del colectivo.</param>
        /// <param name="color">El color del colectivo.</param>
        /// <param name="nChasis">El número de chasis del colectivo.</param>
        /// <param name="esAutomatico">Indica si el colectivo es automatico.</param>
        /// <param name="cantidadDePasajeros">La cantidad de pasajeros del colectivo</param>
        public Colectivo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis, string esAutomatico, int cantidadDePasajeros)
           : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis, esAutomatico)
        {
            
            this.cantidadDePasajeros = cantidadDePasajeros;
        }

        #region  Propiedades
        /// <summary>
        /// Representa si es automatico la transmision del colectivo.
        /// </summary>
        public string EsAutomatico
        {
            get { return this.esAutomatico; }
            set { this.esAutomatico = value; }
        }

        /// <summary>
        /// Representa la cantidad de pasajeros del colectivo.
        /// </summary>
        public int CantidadDePasajeros
        {
            get { return this.cantidadDePasajeros; }
            set { this.cantidadDePasajeros = value; }
        }
        #endregion

        protected override string TipoDeVeihculo()
        {
            return "COLECTIVO";
        }

        protected override bool VerificarCantRuedas()
        {
            return this.cantidadRuedas == 6;
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
            sb.AppendLine($"Es automatico: {this.esAutomatico} -");
            sb.AppendLine($"Cantidad de pasajeros: {this.cantidadDePasajeros} -");

            return sb.ToString();
        }
    }
}
