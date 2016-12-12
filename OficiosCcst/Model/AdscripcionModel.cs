using OficiosCcst.Dto;
using ScjnUtilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficiosCcst.Model
{
    public class AdscripcionModel
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Base"].ConnectionString;

        public List<char> GetLibros()
        {
            List<char> libros = new List<char>();

            string sqlQuery = "SELECT Libro FROM C_Adscripcion GROUP BY Libro ORDER BY Libro ";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection.Open();

                cmd = new SqlCommand(sqlQuery, connection);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        libros.Add(Convert.ToChar(reader["Libro"]));
                    }
                }
                cmd.Dispose();
                reader.Close();

            }
            catch (SqlException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AdscripcionModel", "OficiosCCST");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AdscripcionModel", "OficiosCCST");
            }
            finally
            {
                connection.Close();
            }

            return libros;
        }



        public List<Adscripcion> GetAdscripcionByLibro(char libro)
        {
            List<Adscripcion> adscripciones = new List<Adscripcion>();

            string sqlQuery = "SELECT * FROM C_Adscripcion WHERE Libro = @Libro";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection.Open();

                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@Libro", libro);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Adscripcion adscripcion = new Adscripcion();
                        adscripcion.IdAdscripcion = Convert.ToInt32(reader["IdAdscripcion"]);
                        adscripcion.Adscripcions = reader["Adscripcion"].ToString();
                        adscripcion.AdscripcionStr = reader["AdscripcionStr"].ToString();

                        adscripciones.Add(adscripcion);
                    }
                }
                cmd.Dispose();
                reader.Close();

            }
            catch (SqlException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AdscripcionModel", "OficiosCCST");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AdscripcionModel", "OficiosCCST");
            }
            finally
            {
                connection.Close();
            }

            return adscripciones;
        }


        public List<Adscripcion> GetAdscripciones()
        {
            List<Adscripcion> adscripciones = new List<Adscripcion>();

            string sqlQuery = "SELECT * FROM C_Adscripcion ORDER BY Libro ";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection.Open();

                cmd = new SqlCommand(sqlQuery, connection);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Adscripcion adscripcion = new Adscripcion();
                        adscripcion.IdAdscripcion = Convert.ToInt32(reader["IdAdscripcion"]);
                        adscripcion.Adscripcions = reader["Adscripcion"].ToString();
                        adscripcion.AdscripcionStr = reader["AdscripcionStr"].ToString();

                        adscripciones.Add(adscripcion);
                    }
                }
                cmd.Dispose();
                reader.Close();

            }
            catch (SqlException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AdscripcionModel", "OficiosCCST");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,AdscripcionModel", "OficiosCCST");
            }
            finally
            {
                connection.Close();
            }

            return adscripciones;
        }


    }
}
