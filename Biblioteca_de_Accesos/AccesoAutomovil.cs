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

namespace Biblioteca_de_Accesos
{
    public class AccesoAutomovil : AccesoVehiculos, IConexiones<Automovil>
    {


        public bool PruebaConexion()
        {
            bool retorno = false;
            try
            {
                this.Conexion.Open();
                retorno = true;
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


        ///

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

        
        //-------------------------------------------------------------------------------

        public bool AgregarDato(Automovil a)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.CommandType = System.Data.CommandType.Text; 

                this.Comando.CommandText = "insert into tabla_automoviles (NUMERO_CHASIS,MARCA,CANT_RUEDAS,CANT_MARCHAS,COLOR,CANT_PUERTAS,COMBUSTIBLE) values (@numero_chasis,@marca,@cant_ruedas,@cant_marchas,@color,@cant_puertas,@combustible)";
                this.Comando.Connection = this.Conexion;

                string marca = (string)a.Marca;
                short cantRuedas = (short)a.CantidadRuedas;
                short cantMarchas = (short)a.CantidadMarchas;
                string color = (string)a.Color.ToString();
                string nChasis = (string)a.NChasis;
                short cantPuertas = (short)a.CantidadDePuertas;
                string combustible = (string)a.TipoDeCombustible;

                //string marca = "Torino";
                //short cantRuedas = 4;
                //short cantMarchas = 5;
                //string color = "Negro";
                //string nChasis = "232323";
                //short cantPuertas = 2;
                //string combustible = "Nafta";


                this.Comando.Parameters.AddWithValue(@"marca", marca);
                this.Comando.Parameters.AddWithValue(@"cant_ruedas", cantRuedas);
                this.Comando.Parameters.AddWithValue(@"cant_marchas", cantMarchas);
                this.Comando.Parameters.AddWithValue(@"color", color);
                this.Comando.Parameters.AddWithValue(@"numero_chasis", nChasis);
                this.Comando.Parameters.AddWithValue(@"cant_puertas", cantPuertas);
                this.Comando.Parameters.AddWithValue(@"combustible", combustible) ;


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
        //--------------------------------------------------------


        public bool ModificarDato(Automovil a)
        {
            bool retorno = false;

            try
            {
                this.Comando = new SqlCommand();

                this.Comando.Parameters.AddWithValue(@"marca", a.Marca);
                this.Comando.Parameters.AddWithValue(@"cant. ruedas", a.CantidadRuedas);
                this.Comando.Parameters.AddWithValue(@"cant. marchas", a.CantidadMarchas);
                this.Comando.Parameters.AddWithValue(@"color", a.Color);
                this.Comando.Parameters.AddWithValue(@"numero de chasis", a.NChasis);
                this.Comando.Parameters.AddWithValue(@"cant. puertas", a.CantidadDePuertas);
                this.Comando.Parameters.AddWithValue(@"combustible", a.TipoDeCombustible);

                this.Comando.CommandType = System.Data.CommandType.Text; //->Emun, inidca que va ejejcutar en el comand tex
                this.Comando.CommandText = "update tabla_automoviles set @marca = marca, @cant. ruedas = cant. ruedas, @cant. marchas = cant. marchas, @color = color, @numero de chasis = numero de chasis, @cant. puertas = cant. puertas ,@combustible = combustible where numero de chasis = @numero de chasis";
                this.Comando.Connection = this.Conexion;


                this.Conexion.Open();
                int filasAfectadas = this.Comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }

            }
            catch
            {

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
