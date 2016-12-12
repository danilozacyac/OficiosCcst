using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficiosCcst.Model
{
    public class DestinatarioModel
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Base"].ConnectionString;

        public bool InsertaTitular(Titular titular)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool insertCompleted = false;

            titular.IdTitular = DataBaseUtilities.GetNextIdForUse("C_Titular", "IdTitular", connection);
            titular.QuiereDistribucion = 1;
            try
            {
                connection.Open();

                string sqlQuery = "INSERT INTO C_Titular(IdTitular, Nombre,Apellidos,IdTitulo,NombMay,IdUsr,Fecha,Obs,QuiereDist,IdEstatus,Correo,Genero)" +
                                  "VALUES (@IdTitular, @Nombre,@Apellidos,@IdTitulo,@NombMay,@IdUsr,@Fecha,@Obs,@QuiereDist,@IdEstatus,@Correo,@Genero)";

                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@IdTitular", titular.IdTitular);
                cmd.Parameters.AddWithValue("@Nombre", titular.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", titular.Apellidos);
                cmd.Parameters.AddWithValue("@IdTitulo", titular.IdTitulo);
                cmd.Parameters.AddWithValue("@NombMay", titular.NombreStr);
                cmd.Parameters.AddWithValue("@IdUsr", AccesoUsuario.Llave);
                cmd.Parameters.AddWithValue("@Fecha", DateTimeUtilities.DateToInt(DateTime.Now));

                if (titular.Observaciones == null)
                {
                    cmd.Parameters.AddWithValue("@Obs", String.Empty);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Obs", titular.Observaciones);
                }

                cmd.Parameters.AddWithValue("@QuiereDist", titular.QuiereDistribucion);
                cmd.Parameters.AddWithValue("@IdEstatus", titular.Estado);
                cmd.Parameters.AddWithValue("@Correo", titular.Correo);
                cmd.Parameters.AddWithValue("@Genero", titular.Genero);

                cmd.ExecuteNonQuery();
                cmd.Dispose();


                foreach (Adscripcion adscripcion in titular.Adscripciones)
                {
                    adscripcion.Titular = titular;

                    foreach (TirajePersonal tiraje in adscripcion.Tirajes)
                    {
                        if (tiraje.IsChecked == true)
                            this.EstableceAdscripcion(adscripcion, tiraje, true);
                    }

                    this.InsertaHistoricoFechaAlta(adscripcion);
                }

                insertCompleted = true;
            }
            catch (SqlException ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,TitularModel", "PadronApi");
            }
            catch (Exception ex)
            {
                string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                ErrorUtilities.SetNewErrorMessage(ex, methodName + " Exception,TitularModel", "PadronApi");
            }
            finally
            {
                connection.Close();
            }

            return insertCompleted;
        }


    }
}
