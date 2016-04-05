using Npgsql;
using SysOtica.Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ConexaoBD : ConexaoBDInterface
    {

        public NpgsqlConnection conexao;
        private string url = @"Server=127.0.0.1;Port=5432;Database=sysOtica;User Id=postgres;Password=123456;";

        public void Conectar()
        {

            conexao = new NpgsqlConnection(url);
            conexao.Open();
        }

        public void Desconectar()
        {
            conexao.Clone();
            conexao.Dispose();
        }

    }
}
