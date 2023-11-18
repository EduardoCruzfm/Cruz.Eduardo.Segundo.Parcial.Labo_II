using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Delegado para imprimir un mensaje de atención con dos cadenas de texto.
    /// </summary>
    /// <param name="mensajeUno">El primer mensaje a imprimir.</param>
    /// <param name="mensajeDos">El segundo mensaje a imprimir.</param>
    public delegate void ImprimirMensajeAtencion(string mensajeUno,string mensajeDos);

    /// <summary>
    /// Clase que gestiona un evento para imprimir mensajes de atención.
    /// </summary>
    public class DelegadoImprimirMensaje
    {
        /// <summary>
        /// Evento para imprimir mensajes de atención, utilizando el delegado ImprimirMensajeAtencion.
        /// </summary>
        public event ImprimirMensajeAtencion MensajeImpreso;

        /// <summary>
        /// Método para imprimir un mensaje de atención utilizando el evento MensajeImpreso.
        /// </summary>
        /// <param name="marca">Marca del vehículo o elemento a destacar.</param>
        /// <param name="nChasis">Número de chasis o identificación del elemento.</param>
        public void ImprimirMjsAtencion(string marca, string nChasis) => 
            MensajeImpreso?.Invoke(marca, nChasis);      
    }
}
