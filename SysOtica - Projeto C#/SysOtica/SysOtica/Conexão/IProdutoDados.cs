using System.Collections.Generic;

namespace SysOtica.Conexão
{
    public interface IProdutoDados
    {
        void alterar(Produto produto);
        void excluir(Produto produto);
        void inserir(Produto produto);
        Produto retornarProduto(Produto filtro);
        List<Produto> listarProduto();
        void verificarDuplicidade(Produto produto);
    }
}