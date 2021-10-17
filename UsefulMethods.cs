using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace Shop
{
    static class UsefulMethods
    {
        public static void LoadTable(string query, DataGridView dgw)
        {
            var conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = Shop; User Id = postgres; Password = 3Jebenesifre;");

            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand(query, conn);
                var da = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();

                da.Fill(dt);
                dgw.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
