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
        public bool usoUrbano;


        public Motocicleta(short cantidadRuedas, short cantidadMarchas, Colores color) 
            : base(cantidadRuedas, cantidadMarchas, color)
        {
        }

        public Motocicleta(short cantidadRuedas, short cantidadMarchas, Colores color, short cilindrada) 
            : this(cantidadRuedas, cantidadMarchas, color)
        {
            this.cilindrada = cilindrada;
        }

        public Motocicleta(short cantidadRuedas, short cantidadMarchas, Colores color, short cilindrada, bool usoUrbano)
           : this(cantidadRuedas,cantidadMarchas,color,cilindrada)
        {
            
            this.usoUrbano = usoUrbano;
        }

        protected override string TipoDeVeihculo()
        {
            return "MOTOCICLETA";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");
            sb.AppendLine($"Cilindrada: {this.cilindrada}");

            if (this.usoUrbano)
                sb.AppendLine($"De uso urbano: SI");
            else
                sb.AppendLine($"De uso urbano: NO");

            sb.AppendLine(base.ToString());

            return base.ToString();
        }
    }
}
