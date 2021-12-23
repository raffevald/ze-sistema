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
using MySql.Data.MySqlClient;

namespace zeSistema.regraDeNegocio.receitas
{
    public partial class Receitas : Form
    {
        public Receitas()
        {
            InitializeComponent();
        }

        private void btCadastrarCategoria_Click(object sender, EventArgs e)
        {

        }

        public void ListarCategoriasList()
        {
            try
            {
                string strSQL;
                MySqlDataReader dr;

                Login login = new Login();
                ListarCategorias listarCategorias = new ListarCategorias();
                DataTable dt = new DataTable();


                strSQL = $"SELECT categorias.id_cat as 'Codigo', categorias.descricao_cat as 'Descrição' FROM categorias WHERE categorias.id_usuario_fk = '{Login.dbUserId}'";

                listarCategorias.ListagemDB(strSQL);

                listarCategorias.ListagemDB(strSQL).Fill(dt);
              //  dgvListagemDados.DataSource = dt["Descrição"];

                strSQL = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Não foi possivel completar a operação.");
            }

        }

        private void btVoltarParaReceitasZe_Click(object sender, EventArgs e)
        {
            MostrarFornsReceias mostrarFornsReceias = new MostrarFornsReceias();
            this.Hide();
            mostrarFornsReceias.VoltarFornsReceitasZe();
        }
    }s
}
