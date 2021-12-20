using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using zeSistema.dataBase;
using MySql.Data;
using System.Data;

namespace zeSistema.dataBase
{
    internal class ListarCategorias
    {
        private MySqlConnection connection;
        MySqlDataAdapter dataAdapter;

        public MySqlDataAdapter ListagemDB(string strSQL)
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();
                connection = conexao.Conexao();
                connection.Open();

                dataAdapter = new MySqlDataAdapter(strSQL, connection);
                return dataAdapter;
            } catch (Exception error)
            {
                return null;
            }
        }
    }
}
