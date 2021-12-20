using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace zeSistema.dataBase
{
    internal class CadastrarCategoriasReceitas
    {
        MySqlCommand command;
        MySqlConnection connection;
        public void ExQuerySQL(string strSQL)
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();
                connection = conexao.Conexao();
                connection.Open();
                command = new MySqlCommand(strSQL, connection);
                command.ExecuteNonQuery();
            } catch (Exception error)
            {
                MessageBox.Show("Operação bloqueada.");
            }
        }
    }
}
