using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Shop.Repositories
{
    class InventoryRepository
    {
        public void Insert(Inventory inventory)
        {
            var conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Shop; User Id = postgres; Password = 3Jebenesifre;");
            string query = "INSERT INTO inventory (store_id, item_id, quantity) VALUES ('" + inventory.Store_Name + "','" + inventory.Item_Name + "','" + inventory.Quantity + "')";

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
