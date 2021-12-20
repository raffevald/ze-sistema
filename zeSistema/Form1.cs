using System.Data;
using zeSistema.dataBase;
using MySql.Data.MySqlClient;
using zeSistema.regraDeNegocio;
using zeSistema.regraDeNegocio.receitas;
using zeSistema.usuarioDados;

namespace zeSistema
{
    public partial class Login : Form
    {
        public static String dbUserName { get; set; }
        public static int dbUserId { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            String Usuario;
            String Senha;
            string strSQL;

            String dbUser = "";
            String dbSenha = "";

            MySqlDataReader dr;

            Usuario = tbUsuario.Text;
            Senha = tbSenha.Text;

            strSQL = $"SELECT usuarios.nomeDeUsuario as 'username', usuarios.senha as 'autentificacao',  usuarios.id_usuario as 'codigo', usuarios.nome as 'nome'  FROM usuarios WHERE usuarios.nomeDeUsuario = '{Usuario}'";

            ValidarUsuarioDB validarUser = new ValidarUsuarioDB();

            validarUser.ListagemDB(strSQL);

            dr = validarUser.ListagemDB(strSQL).ExecuteReader();

            while (dr.Read())
            {
                dbSenha = Convert.ToString(dr["autentificacao"]);
                dbUser = Convert.ToString(dr["username"]);
                dbUserId = Convert.ToInt16(dr["codigo"]);
                dbUserName = Convert.ToString(dr["nome"]);
            }

            if ((dbUser == Usuario) && (dbSenha == Senha))
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                this.Hide();
                telaPrincipal.ShowDialog();
            } else
            {
                MessageBox.Show("Usuario ou senha incorreto.");
            }

        }

    }
}