using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    interface IReceitaDados
    {
        void Alterar(Receita receita);
        void Excluir(int id);
        void Inserir(Receita receita);
    }
}
