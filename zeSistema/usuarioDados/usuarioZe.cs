using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeSistema.usuarioDados
{
    internal class usuarioZe
    {
        public int UsuarioCodigoSistema;

        public usuarioZe(int usuarioCodigo)
       {
            UsuarioCodigoSistema = usuarioCodigo;
       }

        public int UsuarioCodSistema(int codigo)
        {
            UsuarioCodigoSistema = codigo;
            return UsuarioCodigoSistema;
        }
    }
}
