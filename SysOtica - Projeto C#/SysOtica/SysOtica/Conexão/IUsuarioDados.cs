using System.Collections.Generic;

namespace SysOtica.Conexão
{
    public interface IUsuarioDados
    {
        void Alterar(Usuario usuario);
        void Excluir(int id);
        void Inserir(Usuario usuario);
        List<Usuario> listaUsuario();
        Usuario RetornaUsuario(Usuario filtro);
    }
}