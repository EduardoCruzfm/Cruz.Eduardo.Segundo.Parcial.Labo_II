using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace Biblioteca_de_Accesos
{
    public class AccesoVehiculos
    {

        private SqlConnection conexion;
        private static string cadena_conexion;

        private SqlCommand comando; //lo que realiza la consulta
        private SqlDataReader lector; //contiene lo que te devuelve la consulta sql

        protected SqlConnection Conexion { get => conexion; set => conexion = value; }
        protected static string Cadena_conexion { get => cadena_conexion; set => cadena_conexion = value; }
        protected SqlCommand Comando { get => comando; set => comando = value; }
        protected SqlDataReader Lector { get => lector; set => lector = value; }
        public static object AccesoDatos { get; }

        static AccesoVehiculos()
        {
            AccesoVehiculos.Cadena_conexion = Properties.Resources.miConexionSP;
        }

        public AccesoVehiculos()
        {
            this.Conexion = new SqlConnection(AccesoVehiculos.Cadena_conexion);
        }

    }
}