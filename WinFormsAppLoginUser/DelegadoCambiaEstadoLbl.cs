using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLoginUser
{
    public delegate void CambiaEstadoLbl(string mensaje, Color color);
    public class DelegadoCambiaEstadoLbl
    {
        // Declaración del evento utilizando el delegado 
        public event CambiaEstadoLbl MoficarLbl;

        public void CambiaTextoYColorLbl(string marca, Color color) =>
            MoficarLbl?.Invoke(marca, color);

    }
}
