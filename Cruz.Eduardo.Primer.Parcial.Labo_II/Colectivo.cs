using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public class Colectivo : Vehiculo
    {
        public string esAutomatico;
        public int cantidadDePasajeros;

        public Colectivo() {  }


        public Colectivo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis) 
            : base(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {

        }

        public Colectivo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis, string esAutomatico)
            : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.esAutomatico = esAutomatico;
        }

        public Colectivo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis, string esAutomatico, int cantidadDePasajeros)
           : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis, esAutomatico)
        {
            
            this.cantidadDePasajeros = cantidadDePasajeros;
        }

        public string EsAutomatico
        {
            get { return this.esAutomatico; }
            set { this.esAutomatico = value; }
        }

        public int CantidadDePasajeros
        {
            get { return this.cantidadDePasajeros; }
            set { this.cantidadDePasajeros = value; }
        }

        protected override string TipoDeVeihculo()
        {
            return "COLECTIVO";
        }

        protected override bool VerificarCantRuedas()
        {
            return this.cantidadRuedas == 6;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            //sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");
            sb.AppendLine($"Es automatico: {this.esAutomatico}");
            sb.AppendLine($"Cantidad de pasajeros: {this.cantidadDePasajeros}");

            return sb.ToString();
        }
    }
}
