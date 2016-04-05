using SysOtica.Conexão;
using SysOtica.Negócio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio.RegrasNegocio
{
    public class LocalControlador
    {
        ILocalDados lc = new LocalDados();

        public void verificaPreenchimento(Local local)
        {
            if (String.IsNullOrEmpty(local.Lc_nomeclinica))
            {
                throw new CampoVazioException("Nome Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_endereco))
            {
                throw new CampoVazioException("Endereço Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_numero))
            {
                throw new CampoVazioException("Número Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_bairro))
            {
                throw new CampoVazioException("Bairro Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_cidade))
            {
                throw new CampoVazioException("Cidade Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_uf))
            {
                throw new CampoVazioException("UF Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_cep))
            {
                throw new CampoVazioException("CEP Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_telefone))
            {
                throw new CampoVazioException("Telefone Vazio!");
            }
            if (String.IsNullOrEmpty(local.Lc_email))
            {
                throw new CampoVazioException("Email Vazio!");
            }
           
        }

        public void Inserir(Local local)
        {
            //falta colocar o try junto com catch da exception - ainda vou fazer conexao  e geral exception
            lc.Inserir(local);
        }
    }
}
