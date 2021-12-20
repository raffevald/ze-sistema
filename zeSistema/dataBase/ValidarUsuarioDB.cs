using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using zeSistema.dataBase;
using MySql.Data;

namespace zeSistema.dataBase
{
    internal class ValidarUsuarioDB
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        

        public ValidarUsuarioDB()
        {

        }
        public MySqlCommand ListagemDB(string strSQL)
        {
            ConexaoDB conexao = new ConexaoDB();
            connection = conexao.Conexao();
            connection.Open();

            command = new MySqlCommand(strSQL, connection);
            return command;
        }
    }
}
