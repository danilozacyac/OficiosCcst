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
    public class ArchivisticaModel
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Base"].ConnectionString;

        /// <summary>
        /// Obtiene el árbol del catálogo general de clasificación archivística
        /// </summary>
        /// <param name="idPadre"></param>
        /// <returns></returns>
        public List<Archivistica> GetCatArchivistica(int idPadre)
        {
            List<Archivistica> catalogoArchivistica = new List<Archivistica>();

            string sqlQuery = "SELECT * FROM C_Archivistica WHERE IdPadre = @IdPadre ORDER BY IdArchivistica";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection.Open();

                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("IdPadre", idPadre);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Archivistica seccion = new Archivistica()
                        {
                            IdArchivistica = Convert.ToInt32(reader["IdArchivistica"]),
                            IdPadre = Convert.ToInt32(reader["IdPadre"]),
                            Clave = reader["Clave"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            DescripcionStr = StringUtilities.PrepareToAlphabeticalOrder( reader["Descripcion"].ToString()),
                            Observaciones = reader["Observaciones"].ToString()
                        };

                        seccion.Child = GetCatArchivistica(seccion.IdArchivistica);

                        catalogoArchivistica.Add(seccion);
                    }
                }
                cmd.Dispose();
                reader.Close();

            }
            catch (SqlException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,ArchivisticaModel", "OficiosCCST");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,ArchivisticaModel", "OficiosCCST");
            }
            finally
            {
                connection.Close();
            }

            return catalogoArchivistica;
        }

        /// <summary>
        /// Obtiene el listado de clasificaciones Archivisticas
        /// </summary>
        /// <returns></returns>
        public List<Archivistica> GetArchivistica()
        {
            List<Archivistica> catalogoArchivistica = new List<Archivistica>();

            string sqlQuery = "SELECT * FROM C_Archivistica WHERE ORDER BY IdArchivistica";

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
                        Archivistica seccion = new Archivistica()
                        {
                            IdArchivistica = Convert.ToInt32(reader["IdArchivistica"]),
                            IdPadre = Convert.ToInt32(reader["IdPadre"]),
                            Clave = reader["Clave"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            DescripcionStr = StringUtilities.PrepareToAlphabeticalOrder(reader["Descripcion"].ToString()),
                            Observaciones = reader["Observaciones"].ToString()
                        };

                        catalogoArchivistica.Add(seccion);
                    }
                }
                cmd.Dispose();
                reader.Close();

            }
            catch (SqlException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,ArchivisticaModel", "OficiosCCST");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,ArchivisticaModel", "OficiosCCST");
            }
            finally
            {
                connection.Close();
            }

            return catalogoArchivistica;
        }

    }
}
