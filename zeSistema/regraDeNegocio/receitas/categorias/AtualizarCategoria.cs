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
    public partial class AtualizarCategoria : Form
    {
        public AtualizarCategoria()
        {
            InitializeComponent();
            ListarCategoriasList();
        }

        private void btConfirmarAtualizacao_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "")
            {
                if (tbDescricao.Text != "" & cbTipoDeCategoria.Text != "")
                {
                    int id_user_fk;
                    string categoriaDescricao;
                    string categoriaData;
                    string dataCategoria;
                    string strSQL;
                    string dataFormatForDB = "-";
                    int categoriaID;
                    string tipoDeCategoria;

                    Login login = new Login();
                    id_user_fk = Login.dbUserId;

                    categoriaDescricao = tbDescricao.Text;
                    categoriaID = Convert.ToInt32(tbCodigo.Text);
                    categoriaData = Convert.ToString(dtpDateTime.Value);
                    dataCategoria = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";
                    tipoDeCategoria = cbTipoDeCategoria.Text;

                    strSQL = $"UPDATE Categorias SET descricao_cat = '{categoriaDescricao}', data_de_atualizacao_cat = '{dataCategoria}', tipo_de_categoria_cat = '{tipoDeCategoria}' WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {Login.dbUserId};";
                    CadastrarCategoriasReceitas cadastrarCategoriasReceitas = new CadastrarCategoriasReceitas();
                    cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

                    tbDescricao.Text = "";
                    strSQL = "";

                } else
                {
                    if (tbDescricao.Text != "" & cbTipoDeCategoria.Text == "")
                    {
                        int id_user_fk;
                        string categoriaDescricao;
                        string categoriaData;
                        string dataCategoria;
                        string strSQL;
                        string dataFormatForDB = "-";
                        int categoriaID;

                        Login login = new Login();
                        id_user_fk = Login.dbUserId;

                        categoriaDescricao = tbDescricao.Text;
                        categoriaID = Convert.ToInt32(tbCodigo.Text);
                        categoriaData = Convert.ToString(dtpDateTime.Value);
                        dataCategoria = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";

                        strSQL = $"UPDATE Categorias SET descricao_cat = '{categoriaDescricao}', data_de_atualizacao_cat = '{dataCategoria}' WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {Login.dbUserId};";
                        CadastrarCategoriasReceitas cadastrarCategoriasReceitas = new CadastrarCategoriasReceitas();
                        cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

                        tbDescricao.Text = "";
                        strSQL = "";
                    } else
                    {
                        if(cbTipoDeCategoria.Text != "" & tbDescricao.Text == "")
                        {
                            int id_user_fk;
                            string categoriaData;
                            string dataCategoria;
                            string strSQL;
                            string dataFormatForDB = "-";
                            int categoriaID;
                            string tipoDeCategoria;

                            Login login = new Login();
                            id_user_fk = Login.dbUserId;

                            categoriaID = Convert.ToInt32(tbCodigo.Text);
                            categoriaData = Convert.ToString(dtpDateTime.Value);
                            dataCategoria = $"{categoriaData[6]}{categoriaData[7]}{categoriaData[8]}{categoriaData[9]}{dataFormatForDB}{categoriaData[3]}{categoriaData[4]}{dataFormatForDB}{categoriaData[0]}{categoriaData[1]}";
                            tipoDeCategoria = cbTipoDeCategoria.Text;

                            strSQL = $"UPDATE Categorias SET data_de_atualizacao_cat = '{dataCategoria}', tipo_de_categoria_cat = '{tipoDeCategoria}' WHERE Categorias.id_cat = {categoriaID} and Categorias.id_usuario_fk = {Login.dbUserId};";
                            CadastrarCategoriasReceitas cadastrarCategoriasReceitas = new CadastrarCategoriasReceitas();
                            cadastrarCategoriasReceitas.ExQuerySQL(strSQL);

                            tbDescricao.Text = "";
                            strSQL = "";
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Não é possivel atualisar a categoria sem informa seu codigo.");
            }

            CategoriaDasReceitas categoriaDasReceitas = new CategoriaDasReceitas();
            this.Hide();
            categoriaDasReceitas.ShowDialog();
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
