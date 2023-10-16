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

        public Automovil() { }  

        public Automovil(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis) 
            : base(marca,cantidadRuedas, cantidadMarchas, color, nChasis)
        {
        }

        public Automovil(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis, string tipoDeCombustible) 
            : this(marca,cantidadRuedas, cantidadMarchas, color, nChasis)
        {
            this.tipoDeCombustible = tipoDeCombustible;
        }

        public Automovil(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis, string tipoDeCombustible, short cantidadPuertas)
            : this(marca, cantidadRuedas, cantidadMarchas, color, nChasis, tipoDeCombustible)
        {   
            this.cantidadPuertas = cantidadPuertas;
        }

        public string TipoDeCombustible
        {
            get { return this.tipoDeCombustible; }
            set { this.tipoDeCombustible = value; }
        }

        public short CantidadDePuertas
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; } 
        }

        protected override string TipoDeVeihculo()
        {
            return "AUTOMOVIL";
        }

        protected override bool VerificarCantRuedas()
        {
            return this.cantidadRuedas == 4;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            //sb.AppendLine($"Tipo de Vehiculo: {this.TipoDeVeihculo()}");
            sb.AppendLine($"Cantidad de puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Tipo de combustible: {this.tipoDeCombustible}");

            return sb.ToString();
        }





    }
}
