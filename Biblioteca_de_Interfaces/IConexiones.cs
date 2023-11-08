using Cruz.Eduardo.Primer.Parcial.Labo_II;

namespace Biblioteca_de_Interfaces
{
    public interface IConexiones
    {

        bool PruebaConexion();

        List<Vehiculo> ObtenerListaDatos();

        bool AgregarDato(Vehiculo v);

        bool ModificarDato(Vehiculo v);

    }
}