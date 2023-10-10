using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public class Automovil : Vehiculo
    {
        public string tipoDeCombustible;
        protected short cantidadPuertas;

        public Automovil(short cantidadRuedas, short cantidadMarchas, Colores color) 
            : base(cantidadRuedas, cantidadMarchas, color)
        {
        }

        public Automovil(short cantidadRuedas, short cantidadMarchas, Colores color, string tipoDeCombustible) 
            : this(cantidadRuedas, cantidadMarchas, color)
        {
            this.tipoDeCombustible = tipoDeCombustible;
        }

        public Automovil(short cantidadRuedas, short cantidadMarchas, Colores color, string tipoDeCombustible, short cantidadPuertas)
            : this(cantidadRuedas, cantidadMarchas, color, tipoDeCombustible)
        {   
            this.cantidadPuertas = cantidadPuertas;
        }

        protected override string TipoDeVeihculo()
        {
            return "AUTOMOVIL";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");
            sb.AppendLine($"Cantidad de puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Tipo de combustible: {this.tipoDeCombustible}");
            sb.AppendLine(base.ToString());

            return base.ToString();
        }





    }
}
