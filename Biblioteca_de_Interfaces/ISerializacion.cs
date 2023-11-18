using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Interfaces
{
    /// <summary>
    /// Interfaz para proporcionar métodos de serialización y deserialización.
    /// </summary>
    public interface ISerializacion
    {
        /// <summary>
        /// Serializa datos y los guarda en un archivo en la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta donde se guardará el archivo.</param>
        void Serializar(string path);

        /// <summary>
        /// Deserializa datos desde un archivo en la ruta especificada.
        /// </summary>
        /// <param name="path">Ruta del archivo a deserializar.</param>
        void Deserializar(string path);
    }
}
