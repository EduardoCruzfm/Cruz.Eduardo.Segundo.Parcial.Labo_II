using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Clase que representa un registro de usuario con información adicional de fecha.
    /// </summary>
    public class UsuarioLog : Usuario
    {
        /// <summary>
        /// Fecha del registro.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Convierte el objeto en una representación de cadena, incluyendo la fecha y los atributos del usuario.
        /// </summary>
        /// <returns>Una cadena que representa el objeto.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {this.Fecha} -");
            sb.AppendLine($"Usuario: {this.nombre} -");
            sb.AppendLine($"Apellido: {this.apellido} -");
            sb.AppendLine($"Correo: {this.correo} -");
            sb.AppendLine($"Legajo: {this.legajo} -");
            sb.AppendLine($"Perfil: {this.perfil}");

            return sb.ToString();
        }
    }
}
