using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Clase que representa un usuario con información báse.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Apellido del usuario.
        /// </summary>
        public string apellido { get; set; }

        /// <summary>
        /// Número de legajo del usuario.
        /// </summary>
        public int legajo { get; set; }

        /// <summary>
        /// Correo electrónico del usuario.
        /// </summary>
        public string correo { get; set; }

        /// <summary>
        /// Clave de acceso del usuario.
        /// </summary>
        public string clave { get; set; }

        /// <summary>
        /// Perfil del usuario.
        /// </summary>
        public string perfil { get; set; }


        /// <summary>
        /// Convierte el objeto en una representación de cadena, incluyendo el nombre y el correo del usuario.
        /// </summary>
        /// <returns>Una cadena que representa el objeto.</returns>
        public override string ToString()
        {
            return $"Usuario: {this.nombre} - nombre: {this.correo}";
        }
    }
}
