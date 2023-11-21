using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Exepciones
{
    /// <summary>
    /// Representa una excepción personalizada para manejar errores de conexión a la base de datos.
    /// </summary>
    public class ConexionFallidaBDException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ConexionFallidaBDException"/>.
        /// </summary>
        public ConexionFallidaBDException() { }


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ConexionFallidaBDException"/> 
        /// con un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado que describe la excepción.</param>
        public ConexionFallidaBDException(string mensaje) : base(String.Format($"Conexion denegada. Por favor verifique CommandText y Parameters. Mas detalles: {mensaje}")) { }

    }
}
