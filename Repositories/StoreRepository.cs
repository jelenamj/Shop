using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Shop.Repositories
{
    class StoreRepository
    {
        public void Insert(Store store)
        {
            var conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Shop; User Id = postgres; Password = 3Jebenesifre;");
            string query = "INSERT INTO store (name, city, address) VALUES ('" + store.Name + "','" + store.City + "','" + store.Address + "')";

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
