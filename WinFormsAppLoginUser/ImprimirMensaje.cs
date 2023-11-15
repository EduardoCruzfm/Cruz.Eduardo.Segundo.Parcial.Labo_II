using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLoginUser
{
    public delegate void ImprimirMensajeAtencion(string mensajeUno,string mensajeDos);

    public class ImprimirMensaje
    {
        // Declaración del evento utilizando el delegado
        public event ImprimirMensajeAtencion MensajeImpreso;


        public void ImprimirAtencion(string marca, string nChasis) => MensajeImpreso?.Invoke(marca, nChasis);
        

    }
}
