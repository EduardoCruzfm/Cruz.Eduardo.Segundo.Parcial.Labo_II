using Biblioteca_de_Interfaces;
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
    /// Clase AccesoColectivo() proporciona métodos para acceder y manipular datos de la tabla de automóviles en la base de datos.
    /// Implementa la interfaz IConexiones.
    /// </summary>
    public class AccesoColectivo : AccesoVehiculos, IConexiones<Colectivo>
    {
        /// <summary>
        /// Obtiene una lista de objetos Motocicleta desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Motocicleta.</returns>
        public List<Colectivo> ObtenerListaDatos()
        {
            List<Colectivo> lista = new List<Colectivo>();

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "select [NUMERO_CHASIS], [MARCA], [CANT_RUEDAS], [CANT_MARCHAS], [COLOR], [AUTOMATICO], [CANT_PASAJEROS]  from tabla_colectivos";
                this.Comando.Connection = this.Conexion;

                this.Conexion.Open();

                this.Lector = this.Comando.ExecuteReader();

                while (this.Lector.Read())
                {
                    Colectivo c = new Colectivo();

                    c.Marca = this.Lector["MARCA"].ToString();
                    c.CantidadRuedas = (short)this.Lector["CANT_RUEDAS"];
                    c.CantidadMarchas = (short)this.Lector["CANT_MARCHAS"];
                    c.Color = (Colores)Enum.Parse(typeof(Colores), this.Lector["COLOR"].ToString());
                    c.NChasis = this.Lector["NUMERO_CHASIS"].ToString();
                    c.EsAutomatico = this.Lector["AUTOMATICO"].ToString();
                    c.CantidadDePasajeros = (int)this.Lector["CANT_PASAJEROS"];


                    lista.Add(c);
                }

                this.Lector.Close();


            }
            catch (Exception ex)
            {

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
        /// Agrega un objeto Colectivo a la base de datos.
        /// </summary>
        /// <param name="c">Objeto Colectivo a agregar.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool AgregarDato(Colectivo c)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text;

                this.Comando.CommandText = "insert into tabla_colectivos (NUMERO_CHASIS,MARCA,CANT_RUEDAS,CANT_MARCHAS,COLOR,AUTOMATICO,CANT_PASAJEROS) values (@numero_chasis,@marca,@cant_ruedas,@cant_marchas,@color,@automatico,@cant_pasajeros)";
                this.Comando.Connection = this.Conexion;


                this.Comando.Parameters.AddWithValue(@"marca", c.Marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", c.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", c.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", c.Color.ToString());
                this.Comando.Parameters.AddWithValue(@"numero_chasis", c.NChasis);
                this.Comando.Parameters.AddWithValue(@"automatico", c.EsAutomatico);
                this.Comando.Parameters.AddWithValue(@"cant_pasajeros", c.CantidadDePasajeros);


                this.Conexion.Open();

                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }

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
        /// <param name="c">Objeto Motocicleta con los nuevos datos.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool ModificarDato(Colectivo c)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"marca", c.Marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", c.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", c.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", c.Color.ToString());
                this.Comando.Parameters.AddWithValue(@"numero_chasis", c.NChasis);
                this.Comando.Parameters.AddWithValue(@"automatico", c.EsAutomatico);
                this.Comando.Parameters.AddWithValue(@"cant_pasajeros", c.CantidadDePasajeros);

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "update tabla_colectivos set NUMERO_CHASIS = @numero_chasis , MARCA = @marca , CANT_RUEDAS = @cant_ruedas , CANT_MARCHAS = @cant_marchas , COLOR = @color, AUTOMATICO = @automatico , CANT_PASAJEROS = @cant_pasajeros  where NUMERO_CHASIS = @numero_chasis";
                this.Comando.Connection = this.Conexion;


                this.Conexion.Open();
                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }

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
        /// Elimina un registro de la tabla de colectivos en la base de datos.
        /// </summary>
        /// <param name="c">Objeto Colectivo a eliminar.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool EliminarDato(Colectivo c)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"numero_chasis", c.NChasis);

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "delete from tabla_colectivos where NUMERO_CHASIS = @numero_chasis";
                this.Comando.Connection = this.Conexion;


                this.Conexion.Open();
                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
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
