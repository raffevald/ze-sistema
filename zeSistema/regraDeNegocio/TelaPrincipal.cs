using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zeSistema;
using zeSistema.regraDeNegocio.receitas;

namespace zeSistema.regraDeNegocio
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            tbNome.Text = Login.dbUserName;

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btReceitas_Click(object sender, EventArgs e)
        {
            ReceitasZe receitas = new ReceitasZe();
            this.Hide();
            receitas.ShowDialog();
        }

        private void btCategoriaReceitas_Click(object sender, EventArgs e)
        {
            CategoriaDasReceitas categoriaReceitas = new CategoriaDasReceitas();
            this.Hide();
            categoriaReceitas.ShowDialog();
        }
    }
}
