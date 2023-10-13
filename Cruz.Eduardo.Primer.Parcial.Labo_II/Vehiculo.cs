using System.Drawing;
using System.Text;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public abstract class Vehiculo
    {   //Commit /tex/sincro/push
        protected short cantidadRuedas;
        protected short cantidadMarchas;
        protected Colores color;
        protected int nChasis;

        public Vehiculo(short cantidadRuedas, short cantidadMarchas, Colores color, int nChasis)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadMarchas = cantidadMarchas;
            this.color = color;
            this.nChasis = nChasis;
        }

        public int NChasis
        {
            get { return nChasis; }
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

            if ( obj == null || !(obj is Vehiculo) ) return false;


            Vehiculo objCasteo = (Vehiculo)obj;

            return this.nChasis == objCasteo.nChasis;
        }

        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}