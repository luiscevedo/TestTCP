using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTCP
{
    //Clase capa acceso a datos y consultas
    public class AcessCab
    {
        //Conexion DB SQL
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TESTTCP;Data Source=DESKTOP-SUQ0NN2");
        public void InsertCabecera(Cabecera cabecera)
        {
            try
            {
                //cargar parametros del formulario clients  al SQL
                conn.Open();
                string Query = @" 
                INSERT INTO Cabecera (FechaAlta, Estado)
                VALUES(@FechaAlta,@Cli_ID @Estado)";
                //definir parametros
                SqlParameter FechaAlta = new SqlParameter("@FechaAlta", cabecera.FechaAlta);
                SqlParameter Cli_ID = new SqlParameter("@cli_ID", cabecera.Cli_ID);
                SqlParameter Estado = new SqlParameter("@Estado", cabecera.Estado);
              
                //agregar parametros
                SqlCommand command = new SqlCommand(Query, conn);
                command.Parameters.Add(FechaAlta);
                command.Parameters.Add(Cli_ID);
                command.Parameters.Add(Estado);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateCabecera(Cabecera cabecera)
        {
            try
            {
                conn.Open();
                string Query = @"UPDATE Cabecera
                                 SET FechaAlta = @FechaAlta,
                                     Estado = @Estado
                                     WHERE ID = @ID";

                SqlParameter ID = new SqlParameter("ID", cabecera.ID);
                SqlParameter FechaAlta = new SqlParameter("@FechaAlta", cabecera.FechaAlta);
                SqlParameter Estado = new SqlParameter("@Estado", cabecera.Estado);
            

                SqlCommand command = new SqlCommand(Query, conn);
                command.Parameters.Add(ID);
                command.Parameters.Add(FechaAlta);
                command.Parameters.Add(Estado);
        


                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteCabecera(int ID)
        {

            try
            {
                conn.Open();
                string Query = @"DELETE FROM CABECERA WHERE ID = @ID";

                SqlCommand command = new SqlCommand(Query, conn);
                command.Parameters.Add(new SqlParameter("@ID", ID));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        //         public void ClientsSelection(Int32 NumCliente)

        public List<Cabecera> ClientsSelection(Int32 NumCliente)
        {
            /* 
                                string Query = @" 
                INSERT INTO Clients (RazonSocial, Cuit, direccion, deshabilitado)
                VALUES(@RazonSocial, @Cuit, @direccion, @deshabilitado)";
                //definir parametros
                SqlParameter RazonSocial = new SqlParameter("@RazonSocial", clients.RazonSocial);
                SqlParameter Cuit = new SqlParameter("@Cuit", clients.Cuit);
                SqlParameter direccion = new SqlParameter("@direccion", clients.Direccion);
                SqlParameter deshabilitado = new SqlParameter("@deshabilitado", clients.Deshabilitado);

                //agregar parametros
                SqlCommand command = new SqlCommand(Query, conn);
                command.Parameters.Add(RazonSocial);
                command.Parameters.Add(Cuit);
                command.Parameters.Add(direccion);
                command.Parameters.Add(deshabilitado);

                command.ExecuteNonQuery();*/
            //refesch lsita clients
            List<Cabecera> cabecera = new List<Cabecera>();
            try
            {
                conn.Open();
                String query = @" 
                                    Insert to Cabecera (FechaAlta,Cli_ID, Estado FROM Cabecera)
                                    VALUES (@FechaAlta, Cli_ID, @Estado)";



                SqlCommand command = new SqlCommand();
             //   SqlParameter RazonSocial = new SqlParameter("@FechaAlta", cabecera.FechaAlta);


                query += "WHERE ID LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{NumCliente}%"));

               
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    cabecera.Add(new Cabecera
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        FechaAlta = reader["FechaAlta"].ToString(),
                        Cli_ID = int.Parse(reader["CLI_ID"].ToString()),
                        Estado = reader["Estado"].ToString(), 

                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();

            }
            return cabecera;
        }

    }


}
