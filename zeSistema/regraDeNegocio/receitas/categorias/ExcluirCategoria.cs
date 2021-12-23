using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zeSistema.dataBase;

namespace zeSistema.regraDeNegocio.receitas.categorias
{
    public partial class ExcluirCategoria : Form
    {
        public ExcluirCategoria()
        {
            InitializeComponent();
            ListarCategoriasList();
        }

        private void btConfirmarEsclusao_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "")
            {
                int id_user_fk;
                string strSQL;
                int categoriaID;

                Login login = new Login();
                id_user_fk = Login.dbUserId;

                categoriaID = Convert.ToInt32(tbCodigo.Text);

                strSQL = $"DELETE from Categorias WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {Login.dbUserId};";
                CadastrarCategoriasReceitas cadastrarCategoriasReceitas = new CadastrarCategoriasReceitas();
                cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

                CategoriaDasReceitas categoriaDasReceitas = new CategoriaDasReceitas();
                this.Hide();
                categoriaDasReceitas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não é possivel deletar a categoria sem informa seu codigo.");
            }
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
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possivel completar a operação.");
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            CategoriaDasReceitas categoriaDasReceitas = new CategoriaDasReceitas();
            this.Hide();
            categoriaDasReceitas.ShowDialog();
        }
    }
}
