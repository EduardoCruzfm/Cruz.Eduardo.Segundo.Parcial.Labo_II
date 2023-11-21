using Biblioteca_de_Interfaces;
using Cruz.Eduardo.Primer.Parcial.Labo_II;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Exepciones;
using Azure.Messaging;

namespace Biblioteca_de_Accesos
{
    /// <summary>
    /// Clase AccesoAutomovil() proporciona métodos para acceder y manipular datos de la tabla de automóviles en la base de datos.
    /// Implementa la interfaz IConexiones.
    /// </summary>
    public class AccesoAutomovil : AccesoVehiculos, IConexiones<Automovil>
    {
        /// <summary>
        /// Obtiene una lista de objetos Automovil desde la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Automovil.</returns>
        public List<Automovil> ObtenerListaDatos()
        {
            List<Automovil> lista = new List<Automovil>();

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text; //->Emun, inidca que va ejejcutar en el comand tex
                this.Comando.CommandText = "select [NUMERO_CHASIS], [MARCA], [CANT_RUEDAS], [CANT_MARCHAS], [COLOR], [CANT_PUERTAS], [COMBUSTIBLE]  from tabla_automoviles";
                this.Comando.Connection = this.Conexion;

                this.Conexion.Open();

                this.Lector = this.Comando.ExecuteReader(); //consulta de tipo selec

                while (this.Lector.Read()) //devuelve true cuando tiene para leer
                {
                    Automovil a = new Automovil();

                    a.Marca = this.Lector["MARCA"].ToString();
                    a.CantidadRuedas = (short)this.Lector["CANT_RUEDAS"];
                    a.CantidadMarchas = (short)this.Lector["CANT_MARCHAS"];
                    a.Color = (Colores)Enum.Parse(typeof(Colores), this.Lector["COLOR"].ToString());
                    a.NChasis = this.Lector["NUMERO_CHASIS"].ToString(); 
                    a.CantidadDePuertas = (short)this.Lector["CANT_PUERTAS"];
                    a.TipoDeCombustible = this.Lector["COMBUSTIBLE"].ToString(); 

                   
                    lista.Add(a);
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
        /// Agrega un objeto Automovil a la base de datos.
        /// </summary>
        /// <param name="a">Objeto Automovil a agregar.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool AgregarDato(Automovil a)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text; 

                this.Comando.CommandText = "insert into tabla_automoviles (NUMERO_CHASIS,MARCA,CANT_RUEDAS,CANT_MARCHAS,COLOR,CANT_PUERTAS,COMBUSTIBLE) values (@numero_chasis,@marca,@cant_ruedas,@cant_marchas,@color,@cant_puertas,@combustible)";
                this.Comando.Connection = this.Conexion;


                this.Comando.Parameters.AddWithValue(@"marca", a.Marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", a.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", a.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", a.Color.ToString());
                this.Comando.Parameters.AddWithValue(@"numero_chasis", a.NChasis);
                this.Comando.Parameters.AddWithValue(@"cant_puertas", a.CantidadDePuertas);
                this.Comando.Parameters.AddWithValue(@"combustible", a.tipoDeCombustible) ;


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
        /// Modifica un registro de la tabla de automóviles en la base de datos.
        /// </summary>
        /// <param name="a">Objeto Automovil con los nuevos datos.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool ModificarDato(Automovil a)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"marca", a.Marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", a.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", a.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", a.Color.ToString());
                this.Comando.Parameters.AddWithValue(@"numero_chasis", a.NChasis);
                this.Comando.Parameters.AddWithValue(@"cant_puertas", a.CantidadDePuertas);
                this.Comando.Parameters.AddWithValue(@"combustible", a.tipoDeCombustible);

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "update tabla_automoviles set NUMERO_CHASIS = @numero_chasis , MARCA = @marca , CANT_RUEDAS = @cant_ruedas , CANT_MARCHAS = @cant_marchas , COLOR = @color, CANT_PUERTAS = @cant_puertas , COMBUSTIBLE = @combustible  where NUMERO_CHASIS = @numero_chasis";
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
        /// Elimina un registro de la tabla de automóviles en la base de datos.
        /// </summary>
        /// <param name="a">Objeto Automovil a eliminar.</param>
        /// <returns>True si la operación fue exitosa, de lo contrario False.</returns>
        public bool EliminarDato(Automovil a)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"numero_chasis", a.NChasis);

                this.Comando.CommandType = System.Data.CommandType.Text;
                this.Comando.CommandText = "delete from tabla_automoviles where NUMERO_CHASIS = @numero_chasis";
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
