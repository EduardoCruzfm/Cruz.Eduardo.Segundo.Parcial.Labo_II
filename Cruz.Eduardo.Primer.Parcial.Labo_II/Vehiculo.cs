using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    public abstract class Vehiculo
    {   //Commit /tex/sincro/push
        protected string marca;
        protected short cantidadRuedas;
        protected short cantidadMarchas;
        protected Colores color;
        protected long nChasis;
        protected bool mantenimiento;

        
        public Vehiculo()
        {

        }
        //[JsonConstructor]
        public Vehiculo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, long nChasis)
        {
            this.marca = marca;
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadMarchas = cantidadMarchas;
            this.color = color;
            this.nChasis = nChasis;
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public long NChasis
        {
            get { return this.nChasis; }
        }


        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }

        public short CantidadRuedas
        {
            get { return this.cantidadRuedas; }
            set { this.cantidadRuedas = value; }
        }

        public Colores Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


        #region Vitual & Abstracto
        protected virtual string TipoDeVeihculo()
        {
            return "VEHICULO";
        }

        
        protected abstract bool VerificarCantRuedas();
        #endregion



        #region            Implicito
        public static implicit operator string(Vehiculo v)
        {
            return v.marca;
        }
        #endregion


        #region             Metodos
        public string Mantenimiento(bool service)
        {
            this.mantenimiento = service;

            return $"{this.marca} Se hizo mantenimiento";
        }

        public string Mantenimiento(bool service, DateTime fecha)
        {
            this.mantenimiento = service;

            return $"{this.marca} Se hizo mantenimiento en la fecha {fecha}";
        }
        #endregion

        #region             Operador
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            //return v1.Equals(v2);
            return v1.NChasis == v2.NChasis && v1.marca == v2.marca;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion

        #region         ToString & Equals
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Cantidad de ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad de marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"N° Chasis: {this.NChasis}");

            return sb.ToString();
        }


        public override bool Equals(object? obj)
        {

            if (obj == null || !(obj is Vehiculo))
                return false;

            Vehiculo objCasteo = (Vehiculo)obj;

            return this == objCasteo;
        }
        #endregion

    }
}