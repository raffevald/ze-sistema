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

            if (Usuario != "" && Senha != "") 
            { 

                strSQL = $"SELECT usuarios.nome_de_usuario_usua as 'username', usuarios.senha_usua as 'autentificacao',  usuarios.id_usua as 'codigo', usuarios.nome_usua as 'nome'  FROM usuarios WHERE usuarios.nome_de_usuario_usua = '{Usuario}'";

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
            } else
            {
                MessageBox.Show("Usuario ou senha não pode ser em branco.");
            }
        }

    }
}