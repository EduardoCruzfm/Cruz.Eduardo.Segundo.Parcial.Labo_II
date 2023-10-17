using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLoginUser
{
    public class UsuarioLog : Usuario
    {
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {this.Fecha}");
            sb.AppendLine($"Usuario: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Correo: {this.correo}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Perfil: {this.perfil}");

            return sb.ToString();
        }
    }
}
