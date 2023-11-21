using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLoginUser
{
    /// <summary>
    /// Delegado para imprimir un mensaje de error con dos cadenas de texto.
    /// </summary>
    /// <param name="mensajeUno">El primer mensaje de error.</param>
    /// <param name="mensajeDos">El segundo mensaje de error.</param>
    public delegate void ImprimirMensajeError(string mensajeUno, string mensajeDos);

    /// <summary>
    /// Clase que gestiona un evento para imprimir mensajes de error.
    /// </summary>
    public class DelegadoImprimirMensajeError
    {
        /// <summary>
        /// Evento para imprimir mensajes de error, utilizando el delegado ImprimirMensajeError.
        /// </summary>
        public event ImprimirMensajeError MensajeImpresoDeError;

        /// <summary>
        /// Método para imprimir un mensaje de error utilizando el evento MensajeImpresoDeError.
        /// </summary>
        /// <param name="mensaje">Mensaje de error a imprimir.</param>
        /// <param name="tituloForm">Título del formulario o contexto asociado al error.</param>
        public void ImprimirMjsError(string mensaje, string tituloForm) =>
            MensajeImpresoDeError?.Invoke(mensaje, tituloForm);

    }
}
