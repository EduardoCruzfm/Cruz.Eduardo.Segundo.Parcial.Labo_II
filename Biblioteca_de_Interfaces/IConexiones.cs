using Cruz.Eduardo.Primer.Parcial.Labo_II;

namespace Biblioteca_de_Interfaces
{
    public interface IConexiones<T>
        where T : Vehiculo
    {

        bool PruebaConexion();

        List<T> ObtenerListaDatos();

        bool AgregarDato(T v);

        bool ModificarDato(T v);

        bool EliminarDato(T v);

    }
}