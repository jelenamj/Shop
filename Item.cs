﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Shop
{
    class Item
    {
        public string Name { get; set; }
        public string UnitOfItem { get; set; }

        public void SaveItem()
        {
            var conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Shop; User Id = postgres; Password = 3Jebenesifre;");
            string query = "INSERT INTO item (name, unitofitem) VALUES ('" + Name + "','" + UnitOfItem + "')";
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
