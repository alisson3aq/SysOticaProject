using System.Collections.Generic;
using SysOtica.Negócio;

namespace SysOtica.Conexão
{
    public interface IClienteDados
    {
        void Alterar(Cliente cliente);
        void Excluir(int id);
        void Excluir(Cliente cliente);
        void Inserir(Cliente cliente);
        List<Cliente> listaCliente();
        Cliente RetornaCliente(Cliente filtro);
        List<Cliente> Select(Cliente filtro);
    }
}