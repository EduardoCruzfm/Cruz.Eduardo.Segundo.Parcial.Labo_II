namespace Biblioteca_Exepciones
{
    /// <summary>
    /// Excepción que indica que se ha superado el límite de interacciones.
    /// </summary>
    public class IntereaccionesSuperadasException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="IntereaccionesSuperadasException"/>.
        /// </summary>
        public IntereaccionesSuperadasException() { }


        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="IntereaccionesSuperadasException"/> 
        /// con un mensaje personalizado.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado que describe la excepción.</param>
        public IntereaccionesSuperadasException(string mensaje) : base(String.Format($"El usuario {mensaje} es invalido. Has superado el limite de interaccion")) { }

    }
}
