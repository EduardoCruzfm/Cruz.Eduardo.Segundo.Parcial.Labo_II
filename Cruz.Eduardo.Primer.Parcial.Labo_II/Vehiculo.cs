using System.Drawing;
using System.Text;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public abstract class Vehiculo
    {   //Commit /tex/sincro/push
        protected short cantidadRuedas;
        protected short cantidadMarchas;
        protected Colores color;

        public Vehiculo(short cantidadRuedas, short cantidadMarchas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadMarchas = cantidadMarchas;
            this.color = color;
        }

        protected virtual string TipoDeVeihculo()
        {
            return "VEHICULO";
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad de ruedas: {this.cantidadMarchas}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();

        }

        
        public override bool Equals(object? obj)
        {
            //return this.GetType() == obj.GetType();
            return obj is Vehiculo;
        }

    }
}