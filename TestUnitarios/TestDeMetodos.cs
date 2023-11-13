using Cruz.Eduardo.Primer.Parcial.Labo_II;
using Biblioteca_de_Accesos;

namespace TestUnitarios
{
    [TestClass]
    public class TestDeMetodos
    {
        [TestMethod]
        public void PruebaDeRetornoDeConexionBasaDeDatos()
        {
            //Arrange
            AccesoAutomovil ado = new AccesoAutomovil();
            //Act
            bool resultadoActual = ado.PruebaConexion();
            //Assert
            Assert.IsTrue(resultadoActual);
        }

        [TestMethod]
        public void CompararSiDosMotocicletassSonIguales()
        {
            Motocicleta m1 = new Motocicleta("Honda",2,6,Colores.Rojo,"321",250,"si");
            Motocicleta m2 = new Motocicleta("Honda",2,6,Colores.Rojo,"321",250,"si");

            bool resultadoActual = m1 == m2;

            Assert.IsTrue(resultadoActual);
        }

        [TestMethod]
        public void CompararSiDosColectivosSonDistintos()
        {
            Colectivo c1 = new Colectivo("Mercedes Benz",6,6,Colores.Gris,"45423512","si");
            Colectivo c2 = new Colectivo("Agrale",6,6,Colores.Negro,"5362072","si");
            
            bool resultadoActual = c1 != c2;

            Assert.IsFalse(resultadoActual);
        }
    }
}