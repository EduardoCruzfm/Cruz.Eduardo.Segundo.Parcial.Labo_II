using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace Biblioteca_de_Accesos
{
    /// <summary>
    /// Clase base para el acceso a datos de vehículos.
    /// </summary>
    public class AccesoVehiculos
    {

        private SqlConnection conexion;
        private static string cadena_conexion;

        private SqlCommand comando;
        private SqlDataReader lector;

        /// <summary>
        /// Obtiene o establece la conexión a la base de datos.
        /// </summary>
        protected SqlConnection Conexion { get => conexion; set => conexion = value; }

        /// <summary>
        /// Obtiene o establece la cadena de conexión a la base de datos.
        /// </summary>
        protected static string Cadena_conexion { get => cadena_conexion; set => cadena_conexion = value; }

        /// <summary>
        /// Obtiene o establece el comando SQL a ejecutar.
        /// </summary>
        protected SqlCommand Comando { get => comando; set => comando = value; }

        /// <summary>
        /// Obtiene o establece el lector de resultados de la consulta SQL.
        /// </summary>
        protected SqlDataReader Lector { get => lector; set => lector = value; }

        /// <summary>
        /// Inicializa la cadena de conexión estática para la clase <see cref="AccesoVehiculos"/>.
        /// </summary>
        static AccesoVehiculos()
        {
            AccesoVehiculos.Cadena_conexion = Properties.Resources.miConexionSP;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AccesoVehiculos"/>.
        /// </summary>
        public AccesoVehiculos()
        {
            this.Conexion = new SqlConnection(AccesoVehiculos.Cadena_conexion);
        }

    }
}