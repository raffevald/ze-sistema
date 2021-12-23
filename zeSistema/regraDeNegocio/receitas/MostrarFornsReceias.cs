using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zeSistema.regraDeNegocio.receitas;

namespace zeSistema.regraDeNegocio.receitas
{
    internal class MostrarFornsReceias
    {
        public MostrarFornsReceias()
        {

        }

        public void MostrarFornsReceitas()
        {
            Receitas receitas = new Receitas();
            receitas.ShowDialog();
        }

        public void VoltarFornsReceitasZe()
        {
            ReceitasZe receitasZe = new ReceitasZe();
            receitasZe.ShowDialog();
        }
    }
}
