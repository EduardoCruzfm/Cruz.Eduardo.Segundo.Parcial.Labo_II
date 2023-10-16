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


        public Motocicleta () { }

        public Motocicleta(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis) 
            : base(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {
        }

        public Motocicleta(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis, short cilindrada) 
            : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.cilindrada = cilindrada;
        }

        public Motocicleta(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis, short cilindrada, string usoUrbano)
           : this(marca, cantidadRuedas,cantidadMarchas,color, nChasis, cilindrada)
        {
            
            this.usoUrbano = usoUrbano;
        }


        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public string Urbano
        {
            get { return this.usoUrbano; }
            set { this.usoUrbano = value; }
        }

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
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"De uso urbano: {this.usoUrbano}");

            return sb.ToString();
        }
    }
}
