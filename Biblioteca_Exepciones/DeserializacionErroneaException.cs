using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Exepciones
{
    /// <summary>
    /// Excepción lanzada cuando se produce un error en el proceso de serialización.
    /// </summary>
    public class DeserializacionErroneaException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DeserializacionErroneaException"/>.
        /// </summary>
        public DeserializacionErroneaException() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DeserializacionErroneaException"/> 
        /// con un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado que describe el error de serialización.</param>
        public DeserializacionErroneaException(string mensaje) : base(String.Format($"Se ha producido un error en el proceso. Detalles: {mensaje}")) { }

    }
}
