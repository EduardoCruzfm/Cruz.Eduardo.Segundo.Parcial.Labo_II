using Biblioteca_de_Interfaces;
using Biblioteca_Exepciones;
using Cruz.Eduardo.Primer.Parcial.Labo_II;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Accesos
{
    /// <summary>
    /// Clase AccesoMotocicleta() proporciona métodos para acceder y manipular datos de la tabla de motocicletas en la base de datos.
    /// Implementa la interfaz IConexiones.
    /// </summary>
    public class AccesoMotocicleta : AccesoVehiculos, IConexiones<Motocicleta>
    {
        /// <summary>
        /// Obtiene una lista de objetos Motocicleta desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Motocicleta.</returns>
        public List<Motocicleta> ObtenerListaDatos()
        {
            List<Motocicleta> lista = new List<Motocicleta>();

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text; //->Emun, inidca que va ejejcutar en el comand tex
                this.Comando.CommandText = "select [NUMERO_CHASIS], [MARCA], [CANT_RUEDAS], [CANT_MARCHAS], [COLOR], [CILINDRADA], [USO_URBANO]  from tabla_motocicletas";
                this.Comando.Connection = this.Conexion;

                this.Conexion.Open();

                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read()) 
                {
                    Motocicleta m = new Motocicleta();

                    m.Marca = this.Lector["MARCA"].ToString();
                    m.CantidadRuedas = (short)this.Lector["CANT_RUEDAS"];
                    m.CantidadMarchas = (short)this.Lector["CANT_MARCHAS"];
                    m.Color = (Colores)Enum.Parse(typeof(Colores), this.Lector["COLOR"].ToString());
                    m.NChasis = this.Lector["NUMERO_CHASIS"].ToString();
                    m.Cilindrada = (short)this.Lector["CILINDRADA"];
                    m.Urbano = this.Lector["USO_URBANO"].ToString();


                    lista.Add(m);
                }

                this.Lector.Close();


            }
            catch (ConexionFallidaBDException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.Conexion.State == System.Data.ConnectionState.Open)
                {
                    this.Conexion.Close();
                }

            }
            return lista;
        }

        /// <summary>
        /// Agrega un objeto Motocicleta a la base de datos.
        /// </summary>
        /// <param name="m">Objeto Motocicleta a agregar.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool AgregarDato(Motocicleta m)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text;

                this.Comando.CommandText = "insert into tabla_motocicletas (NUMERO_CHASIS,MARCA,CANT_RUEDAS,CANT_MARCHAS,COLOR,CILINDRADA,USO_URBANO) values (@numero_chasis,@marca,@cant_ruedas,@cant_marchas,@color,@cilindrada,@uso_urbano)";
                this.Comando.Connection = this.Conexion;


                this.Comando.Parameters.AddWithValue(@"marca", m.Marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", m.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", m.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", m.Color.ToString());
                this.Comando.Parameters.AddWithValue(@"numero_chasis", m.NChasis);
                this.Comando.Parameters.AddWithValue(@"cilindrada", m.Cilindrada);
                this.Comando.Parameters.AddWithValue(@"uso_urbano", m.usoUrbano);


                this.Conexion.Open();

                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }

            }
            catch (ConexionFallidaBDException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.Conexion.State == System.Data.ConnectionState.Open)
                {
                    this.Conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Modifica un registro de la tabla de motocicletas en la base de datos.
        /// </summary>
        /// <param name="m">Objeto Motocicleta con los nuevos datos.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool ModificarDato(Motocicleta m)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"marca", m.Marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", m.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", m.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", m.Color.ToString());
                this.Comando.Parameters.AddWithValue(@"numero_chasis", m.NChasis);
                this.Comando.Parameters.AddWithValue(@"cilindrada", m.Cilindrada);
                this.Comando.Parameters.AddWithValue(@"uso_urbano", m.usoUrbano);

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "update tabla_motocicletas set NUMERO_CHASIS = @numero_chasis , MARCA = @marca , CANT_RUEDAS = @cant_ruedas , CANT_MARCHAS = @cant_marchas , COLOR = @color, CILINDRADA = @cilindrada , USO_URBANO = @uso_urbano  where NUMERO_CHASIS = @numero_chasis";
                this.Comando.Connection = this.Conexion;


                this.Conexion.Open();
                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }

            }
            catch (ConexionFallidaBDException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.Conexion.State == System.Data.ConnectionState.Open)
                {
                    this.Conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Elimina un registro de la tabla de motocicletas en la base de datos.
        /// </summary>
        /// <param name="m">Objeto Motocicleta a eliminar.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool EliminarDato(Motocicleta m)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"numero_chasis", m.NChasis);

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "delete from tabla_motocicletas where NUMERO_CHASIS = @numero_chasis";
                this.Comando.Connection = this.Conexion;


                this.Conexion.Open();
                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (ConexionFallidaBDException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.Conexion.State == System.Data.ConnectionState.Open)
                {
                    this.Conexion.Close();
                }
            }

            return retorno;
        }
    }
}
