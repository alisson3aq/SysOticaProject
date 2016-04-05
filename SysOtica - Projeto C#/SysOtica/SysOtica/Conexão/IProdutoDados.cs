using System.Collections.Generic;

namespace SysOtica.Conexão
{
    public interface IProdutoDados
    {
        void alterar(Produto produto);
        void alterarProduto(Produto produto);
        void excluir(int id);
        void excluirProduto(Produto produto);
        void inserir(Produto produto);
        void inserirProduto(Produto produto);
        Produto retornarProduto(Produto filtro);
        List<Produto> listarProduto();
        void verificarDuplicidade(Produto produto);
    }
}