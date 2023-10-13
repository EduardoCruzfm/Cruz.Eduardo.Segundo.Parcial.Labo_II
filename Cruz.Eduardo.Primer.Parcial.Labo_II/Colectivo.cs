using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public class Colectivo : Vehiculo
    {
        public bool esAutomatico;
        public int cantidadDePasajeros;

        public Colectivo(short cantidadRuedas, short cantidadMarchas, Colores color, int nChasis) 
            : base(cantidadRuedas, cantidadMarchas, color, nChasis)
        {
        }

        public Colectivo(short cantidadRuedas, short cantidadMarchas, Colores color, int nChasis, bool esAutomatico)
            : this(cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.esAutomatico = esAutomatico;
        }

        public Colectivo(short cantidadRuedas, short cantidadMarchas, Colores color, int nChasis, bool esAutomatico, int cantidadDePasajeros)
           : this(cantidadRuedas, cantidadMarchas, color, nChasis, esAutomatico)
        {
            this.cantidadDePasajeros = cantidadDePasajeros;
        }

        protected override string TipoDeVeihculo()
        {
            return "COLECTIVO";
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");

            if (this.esAutomatico) 
                sb.AppendLine($"Es automatico: SI");
            else
                sb.AppendLine($"Es automatico: NO");

            sb.AppendLine($"Cantidad de pasajeros: {this.cantidadDePasajeros}");
            sb.AppendLine(base.ToString());

            return base.ToString();
        }
    }
}
