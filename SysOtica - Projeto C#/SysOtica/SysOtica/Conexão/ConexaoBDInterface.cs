using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexão
{
    interface ConexaoBDInterface
    {
        //Estabelece uma conexão com o banco de dados
         void Conectar();

        //Desconecta do Banco de Dados
         void Desconectar();
    }
}
