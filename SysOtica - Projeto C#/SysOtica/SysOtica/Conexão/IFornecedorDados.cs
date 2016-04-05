using System.Collections.Generic;

namespace SysOtica.Conexão
{
    public interface IFornecedorDados
    {
        void Alterar(Fornecedor fornecedor);
        void Excluir(int id);
        void Inserir(Fornecedor fornecedor);
        List<Fornecedor> listaFornecedor();
        Fornecedor RetornaFornecedor(Fornecedor filtro);
        void VerificaDuplicidade(Fornecedor fornecedor);
        Fornecedor GetFornecedor(int fr_id);
    }
}