using System.Collections.Generic;
using SysOtica.Negócio;

namespace SysOtica.Conexão
{
    public interface ILocalDados
    {
        void Alterar(Local local);
        void Excluir(Local local);
        void Excluir(int id);
        void Inserir(Local local);
        List<Local> listaLocal();
    }
}