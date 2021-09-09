using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTTCP
{
       //Clase capa acceso a datos y consultas
    public class Acess
    {
        //Conexion DB SQL
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TESTTCP;Data Source=DESKTOP-SUQ0NN2");
        public void InsertClients(Clients clients)
        {
            try
            {
                //cargar parametros del formulario clients  al SQL
                conn.Open();
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

        public void UpdateClients(Clients clients)
        {
            try
            {
                conn.Open();
                string Query = @"UPDATE Clients
                                 SET RazonSocial = @RazonSocial,
                                     direccion = @direccion,
                                     deshabilitado = @deshabilitado
                                     WHERE ID = @ID";

                SqlParameter ID = new SqlParameter("ID", clients.ID);
                SqlParameter RazonSocial = new SqlParameter("@RazonSocial", clients.RazonSocial);
                SqlParameter direccion = new SqlParameter("@direccion", clients.Direccion);
                SqlParameter deshabilitado = new SqlParameter("@deshabilitado", clients.Deshabilitado);
                

                SqlCommand command = new SqlCommand(Query, conn);
                command.Parameters.Add(ID);
                command.Parameters.Add(RazonSocial);
                command.Parameters.Add(direccion);
                command.Parameters.Add(deshabilitado);


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

        public void DeleteClients(int ID)
        {

            try
            {
                conn.Open();
                    string Query = @"DELETE FROM CLIENTS WHERE ID = @ID";

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
        public List<Clients> Ocho(string prueba = "8")
            {
            List<Clients> clients = new List<Clients>();
            try
            {
                conn.Open();
                String query = "SELECT ID, RazonSocial,Cuit, direccion, deshabilitado FROM Clients ";


                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(prueba))
                {
                    query += "WHERE Cuit LIKE @8 ";
                    command.Parameters.Add(new SqlParameter("8", $"%{8}"));


                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    clients.Add(new Clients
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        RazonSocial = reader["RazonSocial"].ToString(),
                        Cuit = reader["Cuit"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        Deshabilitado = bool.Parse(reader["deshabilitado"].ToString()),

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
            return clients;
        }
        public List<Clients> GetClients(string search = null)
        {

         //refesch lsita clients
            List<Clients> clients = new List<Clients>();
            try
            {
                conn.Open();
                String query = "SELECT ID, RazonSocial,Cuit, direccion, deshabilitado FROM Clients ";


                SqlCommand command = new SqlCommand();

                if(!string.IsNullOrEmpty(search))
                {
                    query += "WHERE Cuit LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));

                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
               
                    clients.Add(new Clients
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        RazonSocial = reader["RazonSocial"].ToString(),
                        Cuit = reader["Cuit"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        Deshabilitado = bool.Parse(reader["deshabilitado"].ToString()),

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
            return clients;
        }

        public List<Clients> GetClientsCab(string search = null)
        {

            //refesch lsita clients
            List<Clients> clients = new List<Clients>();
            try
            {
                conn.Open();
                String query = "SELECT ID, RazonSocial,Cuit, direccion, deshabilitado FROM Clients ";


                SqlCommand command = new SqlCommand();

                if (!string.IsNullOrEmpty(search))
                {
                    query += "WHERE ID LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));

                }
                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    clients.Add(new Clients
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        RazonSocial = reader["RazonSocial"].ToString(),
                        Cuit = reader["Cuit"].ToString(),
                        Direccion = reader["direccion"].ToString(),
                        Deshabilitado = bool.Parse(reader["deshabilitado"].ToString()),

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
            return clients;
        }

    }


}
