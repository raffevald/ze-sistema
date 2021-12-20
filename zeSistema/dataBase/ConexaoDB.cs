using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace zeSistema.dataBase
{
    internal class ConexaoDB
    {
        private static string host = "localhost";
        private static string port = "3306";
        private static string user = "root";
        private static string password = "2078";
        private static string dbName = "ze_sistema";
        private MySqlConnection connection;
        private MySqlCommand command;
       // private MySqlDataAdapter dataAdapter;

        public ConexaoDB()
        {
            try
            {
                connection = new MySqlConnection($"server={host};database={dbName};port={port};user={user};password={password}");
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public MySqlConnection Conexao ()
        {
            try
            {
                connection = new MySqlConnection($"server={host};database={dbName};port={port};user={user};password={password}");
                return connection;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void Close()
        {
            connection.Close();
        }
    }
}
