using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public class Motocicleta : Vehiculo
    {
        public short cilindrada;
        public string usoUrbano;

        /// <summary>
        /// Constructor predeterminado de la clase Motocicleta.
        /// Inicializa una nueva instancia de Motocicleta sin valores iniciales.
        /// </summary>
        public Motocicleta () { }

        /// <summary>
        ///  Constructor de la clase Motocicleta que inicializa una nueva instancia de 
        ///  Motocicleta con los parámetros especificados.
        /// </summary>
        /// <param name="marca">La marca de la motocicleta.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas de la motocicleta.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas de la motocicleta.</param>
        /// <param name="color">El color de la motocicleta.</param>
        /// <param name="nChasis">El número de chasis de la motocicleta.</param>
        public Motocicleta(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis) 
            : base(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {
        }

        /// <summary>
        /// Constructor de la clase Motocicleta que inicializa una nueva instancia de 
        /// Motocicleta que permite especificar la cilindrada.
        /// </summary>
        /// <param name="marca">La marca de la motocicleta.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas de la motocicleta.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas de la motocicleta.</param>
        /// <param name="color">El color de la motocicleta.</param>
        /// <param name="nChasis">El número de chasis de la motocicleta.</param>
        /// <param name="cilindrada">La cilindrada de la motocicleta en centímetros cúbicos.</param>
        public Motocicleta(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis, short cilindrada) 
            : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.cilindrada = cilindrada;
        }

        /// <summary>
        /// Constructor de la clase Motocicleta que inicializa una nueva instancia de 
        /// Motocicleta que permite especificar el uso urbano.
        /// </summary>
        /// <param name="marca">La marca de la motocicleta.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas de la motocicleta.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas de la motocicleta.</param>
        /// <param name="color">El color de la motocicleta.</param>
        /// <param name="nChasis">El número de chasis de la motocicleta.</param>
        /// <param name="cilindrada">La cilindrada de la motocicleta en centímetros cúbicos.</param>
        /// <param name="usoUrbano">Indica si la motocicleta se utiliza en entornos urbanos.</param>
        public Motocicleta(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis, short cilindrada, string usoUrbano)
           : this(marca, cantidadRuedas,cantidadMarchas,color, nChasis, cilindrada)
        {
            
            this.usoUrbano = usoUrbano;
        }

        #region Pripiedades
        /// <summary>
        /// Representa la cilindrada de la motocicleta.
        /// </summary>
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        /// <summary>
        /// Representa el uso urbano de la motocicleta.
        /// </summary>
        public string Urbano
        {
            get { return this.usoUrbano; }
            set { this.usoUrbano = value; }
        }
        #endregion

        protected override string TipoDeVeihculo()
        {
            return "MOTOCICLETA";
        }

        protected override bool VerificarCantRuedas()
        {
            return this.cantidadRuedas == 2;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            //sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");
            sb.AppendLine($"Cilindrada: {this.cilindrada} -");
            sb.AppendLine($"De uso urbano: {this.usoUrbano} -");

            return sb.ToString();
        }
    }
}
