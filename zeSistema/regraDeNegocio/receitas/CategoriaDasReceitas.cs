using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zeSistema.usuarioDados;
using zeSistema.dataBase;
using MySql.Data.MySqlClient;
using MySql.Data;
using zeSistema.regraDeNegocio.receitas.categorias;

namespace zeSistema.regraDeNegocio.receitas
{
    public partial class CategoriaDasReceitas : Form
    {
        public CategoriaDasReceitas()
        {
            InitializeComponent();
            ListarCategoriasList();
        }

        private void CategoriaDasReceitas_Load(object sender, EventArgs e)
        {
            
        }

        private void btCadastrarCategoria_Click(object sender, EventArgs e)
        {
            if(tbDescricao.Text != "")
            {
                int id_user_fk;
                string categoriaDescricao;
                string categoriaData;
                string dataCategoria;
                string strSQL;
                string dataFormatForDB = "-";
                string tipoDeCategoria;

                Login login = new Login();
                id_user_fk = Login.dbUserId;

                categoriaDescricao = tbDescricao.Text;
                categoriaData = Convert.ToString(dtpDateTime.Value);
                dataCategoria = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";
                tipoDeCategoria = cbTipoDeCategoria.Text; 

                strSQL = $"INSERT INTO Categorias(descricao_cat, data_de_insercao_cat, id_usuario_fk, tipo_de_categoria_cat) VALUES ('{categoriaDescricao}', '{dataCategoria}', {id_user_fk}, '{tipoDeCategoria}');";

                CadastrarCategoriasReceitas cadastrarCategoriasReceitas = new CadastrarCategoriasReceitas();
                cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

                tbDescricao.Text = "";
                strSQL = "";

                ListarCategoriasList();

            } else
            {
                MessageBox.Show("Não é possivel cadastrar categoria com descrição vasia.");
            }

        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Hide();
            telaPrincipal.ShowDialog();
        }

        private void btTrocarDeUsuario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();

        }

        private void btListarCategoriasReceitas_Click(object sender, EventArgs e)
        {
            ListarCategoriasList();

            ListarCategoriaPorTipo listarCategoriaPorTipo = new ListarCategoriaPorTipo();
            this.Hide();
            listarCategoriaPorTipo.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarCategoria atualizarCategoria = new AtualizarCategoria();
            this.Hide();
            atualizarCategoria.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirCategoria excluirCategoria = new ExcluirCategoria();
            this.Hide();
            excluirCategoria.ShowDialog();
        }

        public void ListarCategoriasList()
        {
            try
            {
                string strSQL;
                int id_user_fk;

                Login login = new Login();
                ListarCategorias listarCategorias = new ListarCategorias();
                DataTable dt = new DataTable();

                id_user_fk = Login.dbUserId;

                strSQL = $"SELECT categorias.id_cat as 'Codigo', categorias.descricao_cat as 'Descrição', categorias.tipo_de_categoria_cat as 'Tipo de categoria', categorias.data_de_insercao_cat 'Data de cadastro', categorias.data_de_atualizacao_cat as 'Data de atualização' FROM categorias WHERE categorias.id_usuario_fk = '{id_user_fk}'";

                listarCategorias.ListagemDB(strSQL);

                listarCategorias.ListagemDB(strSQL).Fill(dt);
                dgvListagemDados.DataSource = dt;

                strSQL = "";
            } catch (Exception error)
            {
                MessageBox.Show("Não foi possivel completar a operação.");
            }

        }
    }
}
