using SysOtica.Conexão;
using SysOtica.Negócio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio.RegrasNegocio
{
    public class ClienteControlador
    {
        IClienteDados cl = new ClienteDados();

        public void verificaPreenchimento(Cliente cliente)
        {
            if (String.IsNullOrEmpty(cliente.Cl_nome))
            {
                throw new CampoVazioException("Nome Vazio!");
            }

            if (String.IsNullOrEmpty(Convert.ToDateTime((cliente.Cl_datanascimento)).ToString()))
            {
                throw new CampoVazioException("Campo Data está Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_cpf))
            {
                throw new CampoVazioException("CPF Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_rg))
            {
                throw new CampoVazioException("RG Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_telefone))
            {
                throw new CampoVazioException("Telefone Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_celular))
            {
                throw new CampoVazioException("Celular Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_telefone2))
            {
                throw new CampoVazioException("Telefone2 Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_cep))
            {
                throw new CampoVazioException("CEP Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_endereco))
            {
                throw new CampoVazioException("Endereço Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_numero))
            {
                throw new CampoVazioException("Número Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_bairro))
            {
                throw new CampoVazioException("Bairro Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_cidade))
            {
                throw new CampoVazioException("Cidade Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_email))
            {
                throw new CampoVazioException("Email Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_nomepai))
            {
                throw new CampoVazioException("Nome do Pai Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_nomemae))
            {
                throw new CampoVazioException("Nome da Mãe Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_profissao))
            {
                throw new CampoVazioException("Profissão Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_observacoes))
            {
                throw new CampoVazioException("Observação Vazio!");
            }
            if (String.IsNullOrEmpty(cliente.Cl_uf))
            {
                throw new CampoVazioException("UF Vazio!");
            }
        }

        public void Inserir(Cliente cliente)
        {
            //falta colocar o try junto com catch da exception - ainda vou fazer conexao  e geral exception
            cl.Inserir(cliente);
        }


    }
}
