using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zeSistema.regraDeNegocio.receitas
{
    public partial class ReceitasZe : Form
    {
        public ReceitasZe()
        {
            InitializeComponent();
        }

        private void btCategoriaReceitas_Click(object sender, EventArgs e)
        {
            CategoriaDasReceitas categoriaReceitas = new CategoriaDasReceitas();
            this.Hide();
            categoriaReceitas.ShowDialog();
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

        private void btReceitas_Click(object sender, EventArgs e)
        {
            MostrarFornsReceias mostrarFornsReceias = new MostrarFornsReceias();
            this.Hide();
            mostrarFornsReceias.MostrarFornsReceitas();
        }

    }
}
