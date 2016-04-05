using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SysOtica.Conexão;
using SysOtica.Negócio.Exception;

namespace SysOtica.Negócio.RegrasNegocio
{
    public class UsuarioControlador
    {
        IUsuarioDados user = new UsuarioDados();
        
        public void VerificaPreenchimento(Usuario usuario)
        {
            if (String.IsNullOrEmpty(usuario.Us_usuario)) { throw new CampoVazioException("Campo Usuario Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_senha)) { throw new CampoVazioException("Campo Senha Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_endereco)) { throw new CampoVazioException("Campo Endereço Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_nome)) { throw new CampoVazioException("Campo Nome Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_telefone)) { throw new CampoVazioException("Campo Telefone Vazio"); }
            if (String.IsNullOrEmpty(usuario.Us_tipo)) { throw new CampoVazioException("Campo Tipo Vazio"); }
           
        }

        public void Alterar(Usuario usuario)
        {
            user.Alterar(usuario);
        }
        public void Excluir(int id)
        {
            user.Excluir(id);
        }
        public void Inserir(Usuario usuario)
        {
            user.Inserir(usuario);
        }
        public List<Usuario> listaUsuario
        {
            get
            {
                return listaUsuario;
            }
        }

        public Usuario RetornaUsuario(Usuario filtro)
        {
            return filtro;
        }
    }
}
