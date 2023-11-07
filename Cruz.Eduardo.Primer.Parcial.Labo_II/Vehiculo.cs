using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;

namespace Cruz.Eduardo.Primer.Parcial.Labo_II
{
    /// <summary>
    /// Clase abstracta que representa un vehículo genérico.
    /// </summary>
    public abstract class Vehiculo
    {   //Commit /tex/sincro/push
        protected string marca;
        protected short cantidadRuedas;
        protected short cantidadMarchas;
        protected Colores color;
        protected string nChasis;
        protected bool mantenimiento;

        /// <summary>
        /// Constructor vacío la clase abstracta Vehículo.
        /// </summary>
        public Vehiculo()
        {

        }

        /// <summary>
        /// Constructor de la clase Vehiculo que permite inicializar los atributos básicos del vehículo.
        /// </summary>
        /// <param name="marca">La marca del vehículo.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del vehículo.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del vehículo.</param>
        public Vehiculo(string marca, short cantidadRuedas, short cantidadMarchas)
        {
            this.marca = marca;
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadMarchas = cantidadMarchas;
        }

        /// <summary>
        /// Constructor de la clase Vehiculo que permite especificar un color.
        /// </summary>
        /// <param name="marca">La marca del vehículo.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del vehículo.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del vehículo.</param>
        /// <param name="color">El color del vehículo.</param>
        public Vehiculo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color) 
            :this(marca,cantidadRuedas,cantidadMarchas)
        {
            this.color = color;
        }
        /// <summary>
        /// Constructor de la clase Vehiculo que permite especificar un número de chasis adicionalmente.
        /// </summary>
        /// <param name="marca">La marca del vehículo.</param>
        /// <param name="cantidadRuedas">La cantidad de ruedas del vehículo.</param>
        /// <param name="cantidadMarchas">La cantidad de marchas del vehículo.</param>
        /// <param name="color">El color del vehículo.</param>
        /// <param name="nChasis">El número de chasis del vehículo.</param>
        public Vehiculo(string marca, short cantidadRuedas, short cantidadMarchas, Colores color, string nChasis)
            :this(marca,cantidadRuedas,cantidadMarchas,color)
        {
            this.nChasis = nChasis;
        }

        #region   Propiedaes
        /// <summary>
        /// Representa la marca del vehículo.
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        /// <summary>
        ///  Representa el N° de chasis del vehículo.
        /// </summary>
        public string NChasis
        {
            get { return this.nChasis; }
            set { this.nChasis = value; }
        }

        /// <summary>
        ///  Representa la cantidad de marchas del vehículo.
        /// </summary>
        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }

        /// <summary>
        ///  Representa la cantidad de ruedas del vehículo.
        /// </summary>
        public short CantidadRuedas
        {
            get { return this.cantidadRuedas; }
            set { this.cantidadRuedas = value; }
        }

        /// <summary>
        ///  Representa el color del vehículo.
        /// </summary>
        public Colores Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        #endregion

        #region Vitual & Abstracto
        /// <summary>
        /// Devuelve el tipo de vehiculo.
        /// </summary>
        /// <returns>Retorna una string con el tipo de vehiculo</returns>
        protected virtual string TipoDeVeihculo()
        {
            return "VEHICULO";
        }

        /// <summary>
        /// Verifica si la cantidad de ruedas del vehículo cumple con ciertos criterios específicos
        /// dependiendo de la subclase que implementa este método.
        /// </summary>
        /// <returns> Retorna true si la cantidad de ruedas cumple con los criterios específicos; de lo contrario, false.</returns>
        protected abstract bool VerificarCantRuedas();
        #endregion


        #region            Implicito
        /// <summary>
        ///  Convierte un objeto de la clase Vehiculo en una cadena, utilizando la propiedad marca.
        /// </summary>
        /// <param name="v">El objeto Vehiculo a convertir en string.</param>
        public static implicit operator string(Vehiculo v)
        {
            return v.marca;
        }
        #endregion


        #region             Metodos
        /// <summary>
        /// Mantenimiento() Setea el valor del atributo mantenimiento
        /// </summary>
        /// <param name="service">Almacena el valor booleano</param>
        /// <returns>Retorna un string con la marca y si se realizo el mantenimiento</returns>
        public string Mantenimiento(bool service)
        {
            this.mantenimiento = service;

            return $"{this.marca} Se hizo mantenimiento";
        }

        /// <summary>
        /// Mantenimiento() Setea el valor del atributo mantenimiento y muestra la fecha en el que se realizo.
        /// </summary>
        /// <param name="service">Almacena el valor booleano.</param>
        /// <param name="fecha">Almacena la fecha.</param>
        /// <returns>Retorna un string con la marca y si se realizo el mantenimiento y la fecha.</returns>
        public string Mantenimiento(bool service, DateTime fecha)
        {
            this.mantenimiento = service;

            return $"{this.marca} Se hizo mantenimiento en la fecha {fecha}";
        }
        #endregion

        #region         ToString & Equals
        /// <summary>
        /// ToString() Devuelve los datos de los atributos del objeto.
        /// </summary>
        /// <returns>Retorna una string con los datos del Objeto.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca} -");
            sb.AppendLine($"Cantidad de ruedas: {this.cantidadRuedas} -");
            sb.AppendLine($"Cantidad de marchas: {this.cantidadMarchas} -");
            sb.AppendLine($"Color: {this.color} -");
            sb.AppendLine($"N° Chasis: {this.NChasis} -");

            return sb.ToString();
        }

        /// <summary>
        /// Equals() Determina si el objeto actual es igual a otro objeto.
        /// </summary>
        /// <param name="obj">El objeto que se va a comparar con el objeto actual.</param>
        /// <returns>Retorna true si el objeto actual es igual al parámetro obj; de lo contrario, false.</returns>
        public override bool Equals(object? obj)
        {

            if (obj == null || !(obj is Vehiculo))
                return false;

            Vehiculo objCasteo = (Vehiculo)obj;

            return this == objCasteo;
        }
        #endregion

        #region             Operador
        /// <summary>
        /// == Compara dos Vehiculos si son iguales por sus atributos :  NChasis y marca.
        /// </summary>
        /// <param name="v1">Almacena un Vehiculo para la igualacion.</param>
        /// <param name="v2">Almacena otro Vehiculo para la igualacion.</param>
        /// <returns>Retorna true cuando son igualaes, de lo contrario false.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.NChasis == v2.NChasis && v1.marca == v2.marca;
        }

        /// <summary>
        /// != Compara dos Vehicules si son distintos por sus atributos :  NChasis y marca.
        /// </summary>
        /// <param name="v1">Almacena un Vehiculo para la comparacion.</param>
        /// <param name="v2">Almacena otro Vehiculo para la comparacion.</param>
        /// <returns>Retorna true cuando son distintos, de lo contrario false.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion

       

    }//f.rocha@sistemas-utnfra.com.ar //m.neiner@sistemas-utnfra.com.ar
}