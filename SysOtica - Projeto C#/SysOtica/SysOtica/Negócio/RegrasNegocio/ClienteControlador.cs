using SysOtica.Conexão;
using SysOtica.Negócio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SysOtica.Negócio.RegrasNegocio
{
    public class ClienteControlador
    {
        string modelo_Email = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        string caracteres = @"[a-zA-Z]+$";
        string numeros = @"[0-9]+$";
        string LetraseNum = "[^0-9a-zA-Z]+";

        IClienteDados cl = new ClienteDados();


        
        public Boolean verificaPreenchimento(Cliente cliente)
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
            return true;
        }


        //public void ValidaCliente(Cliente cliente)
        //{
        //    if (cliente.Cl_bairro.Length < 3 || (!Regex.IsMatch(cliente.Cl_bairro, caracteres)))
        //    {
        //        throw new CampoVazioException("Numero de caracteres inferior ou dados do Bairro inválidos, favor tente novamente");
        //    }
        //    if (cliente.Cl_celular.Length < 7 || (!Regex.IsMatch(cliente.Cl_celular, LetraseNum)))
        //    {
        //        throw new CampoVazioException("Numero de caracteres inferior ou dados do Local invalidos, favor tente novamente");
        //    }
        //    if (local.Lc_numero.Equals("0") || local.Lc_numero.Length > 5 || (!Regex.IsMatch(local.Lc_numero, numeros)))
        //    {
        //        throw new CampoVazioException("Campo numero Invalido, favor tente novamente");
        //    }
        //    if (local.Lc_bairro.Length < 4 || (!Regex.IsMatch(local.Lc_bairro, LetraseNum)))
        //    {
        //        throw new CampoVazioException("Campo bairro Invalido, favor tente novamente");
        //    }
        //    if (local.Lc_uf.Length > 2 || (!Regex.IsMatch(local.Lc_uf, caracteres)))
        //    {
        //        throw new CampoVazioException("Campo UF Invalido, favor tente novamente");
        //    }
        //    if (local.Lc_cidade.Length < 4 || (!Regex.IsMatch(local.Lc_cidade, caracteres)))
        //    {
        //        throw new CampoVazioException("Campo Cidade Invalido, favor tente novamente");
        //    }
        //    if (!Regex.IsMatch(local.Lc_email, modelo_Email))
        //    {
        //        throw new CampoVazioException("Campo Email Invalido, favor tente novamente");
        //    }



        //}



        public void Inserir(Cliente cliente)
        {
            //falta colocar o try junto com catch da exception - ainda vou fazer conexao  e geral exception
            cl.Inserir(cliente);
        }


    }
}
