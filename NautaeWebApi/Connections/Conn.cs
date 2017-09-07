using NautaeWebApi.Models;
using Pomelo.Data.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NautaeWebApi.Connections
{
    public class Conn
    {
        private string connStr;
        public Conn()
        {

            connStr = @"Database=nautae_sql;Data Source=eu-cdbr-azure-west-b.cloudapp.net;User Id=bbe1ad88d1e83f;Password=358165a5";
        }
        public List<users> userList()
        {

            List<users> allUsers = new List<users>();
            using (MySqlConnection connMySql = new MySqlConnection(connStr))
            {

                using (MySqlCommand cmd = connMySql.CreateCommand())
                {

                    cmd.CommandText = "Select * from userstable";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = connMySql;
                    connMySql.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allUsers.Add(new users { Id = reader.GetInt32(reader.GetOrdinal("Id")), userName = reader.GetString(reader.GetOrdinal("userName")), password = reader.GetString(reader.GetOrdinal("password")), email = reader.GetString(reader.GetOrdinal("email")) });


                        }
                    }
                }
                connMySql.Close();

            }
            return allUsers;
        }
    }
}