using Cruz.Eduardo.Primer.Parcial.Labo_II;

namespace Biblioteca_de_Interfaces
{
    /// <summary>
    /// Interfaz para definir operaciones de conexión y manipulación de datos para un tipo específico de vehículo.
    /// </summary>
    /// <typeparam name="T">Tipo de vehículo que se manipulará.</typeparam>
    public interface IConexiones<T>
        where T : Vehiculo
    {
        /// <summary>
        /// Realiza una prueba de conexión a la base de datos.
        /// </summary>
        /// <returns>True si la conexión es exitosa; de lo contrario, false.</returns>
        bool PruebaConexion();

        /// <summary>
        /// Obtiene una lista de datos del tipo de vehículo especificado.
        /// </summary>
        /// <returns>Lista de vehículos.</returns>
        List<T> ObtenerListaDatos();

        /// <summary>
        /// Agrega un nuevo vehículo a la fuente de datos.
        /// </summary>
        /// <param name="v">Vehículo a agregar.</param>
        /// <returns>True si la operación fue exitosa; de lo contrario, false.</returns>
        bool AgregarDato(T v);

        /// <summary>
        /// Modifica un vehículo existente en la fuente de datos.
        /// </summary>
        /// <param name="v">Vehículo a modificar.</param>
        /// <returns>True si la operación fue exitosa; de lo contrario, false.</returns>
        bool ModificarDato(T v);

        /// <summary>
        /// Elimina un vehículo de la fuente de datos.
        /// </summary>
        /// <param name="v">Vehículo a eliminar.</param>
        /// <returns>True si la operación fue exitosa; de lo contrario, false.</returns>
        bool EliminarDato(T v);

    }
}