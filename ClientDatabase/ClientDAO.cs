using ClientDatabase.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDatabase
{
    public class ClientsDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public void AddNewClient(Client client)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand("CreateClient", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", client.Name));
                command.Parameters.Add(new SqlParameter("@Password", client.Password));
                command.Parameters.Add(new SqlParameter("@Email", client.Email));
                command.Parameters.Add(new SqlParameter("@Address", client.Address));
                command.Parameters.Add(new SqlParameter("@City", client.City));
                command.Parameters.Add(new SqlParameter("@Postcode", client.Postcode));
                command.Parameters.Add(new SqlParameter("@Phone", client.Phone));

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error with inserting data into the database");
            }
        }

        public async Task<List<Client>> GetAllClients(string keyword = "") // Default value set to return all clients
        {
            List<Client> output = new List<Client>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SearchClients", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Keyword", keyword);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client client = new Client
                    (
                        name: reader.GetString(1),
                        password: reader.GetString(2),
                        email: reader.GetString(3),
                        address: reader.GetString(4),
                        city: reader.GetString(5),
                        postcode: reader.GetInt32(6),
                        phone: reader.GetInt32(7)
                    );
                    output.Add(client);
                }
            }
            connection.Close();

            await Task.Factory.StartNew(() => Task.Delay(10));

            return output;
        }
    }
}
