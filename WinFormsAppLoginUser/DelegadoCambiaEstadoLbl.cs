using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Delegado para cambiar el estado de un control Label, incluyendo texto y color.
    /// </summary>
    /// <param name="mensaje">Mensaje a mostrar en el control Label.</param>
    /// <param name="color">Color a aplicar al texto del control Label.</param>
    public delegate void CambiaEstadoLbl(string mensaje, Color color);

    /// <summary>
    /// Clase que gestiona un evento para modificar un control Label con texto y color.
    /// </summary>
    public class DelegadoCambiaEstadoLbl
    {
        /// <summary>
        /// Evento para modificar el control Label, utilizando el delegado CambiaEstadoLbl.
        /// </summary>
        public event CambiaEstadoLbl MoficarLbl;

        /// <summary>
        /// Método para cambiar el texto y color del control Label utilizando el evento MoficarLbl.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar en el control Label.</param>
        /// <param name="color">Color a aplicar al texto del control Label.</param>
        public void CambiaTextoYColorLbl(string marca, Color color) =>
            MoficarLbl?.Invoke(marca, color);
    }
}
