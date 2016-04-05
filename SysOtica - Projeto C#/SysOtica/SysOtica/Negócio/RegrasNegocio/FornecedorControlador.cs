﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SysOtica.Conexão;
using SysOtica.Negócio.Exception;

namespace SysOtica.Negócio.RegrasNegocio
{
    public class FornecedorControlador
    {
        IFornecedorDados forn = new FornecedorDados();

        public void VerificaPreenchimento(Fornecedor fornecedor)
        {
            if (String.IsNullOrEmpty(fornecedor.Fr_bairro))                { throw new CampoVazioException("Campo Bairro Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_celularrepresentante))  { throw new CampoVazioException("Campo Celular Representante Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_cep))                   { throw new CampoVazioException("Campo CEP Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_cidade))                { throw new CampoVazioException("Campo Cidade Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_cnpj))                  { throw new CampoVazioException("Campo CNPJ Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_contato))               { throw new CampoVazioException("Campo Contato Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_email))                 { throw new CampoVazioException("Campo E-mail Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_endereco))              { throw new CampoVazioException("Campo Endereço Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_fantasia))              { throw new CampoVazioException("Campo Nome Fantasia Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_fax))                   { throw new CampoVazioException("Campo Fax Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_inscricaoestadual))     { throw new CampoVazioException("Campo Inscrição Estadual Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_nomerepresentante))     { throw new CampoVazioException("Campo Nome Representante Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_observacoes))           { throw new CampoVazioException("Campo Observações Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_razaosocial))           { throw new CampoVazioException("Campo Razão Social Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_telefone))              { throw new CampoVazioException("Campo Telefone Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_telefonerepresentante)) { throw new CampoVazioException("Campo Telefone Representante Vazio"); }
            if (String.IsNullOrEmpty(fornecedor.Fr_uf))                    { throw new CampoVazioException("Campo UF Vazio"); }

        }

        public void InserirFornecedor(Fornecedor fornecedor)
        {
            forn.Inserir(fornecedor);
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            forn.Alterar(fornecedor);

        }
        public void ExcluirFornecedor(int id)
        {
            forn.Excluir(id);
        }
        public void VerificaDuplicidadeFornecedor(Fornecedor fornecedor)
        {
            forn.VerificaDuplicidade(fornecedor);
        }
        public List<Fornecedor> listaFornecedor
        {
            get
            {
                return listaFornecedor;
            }
        }

        public Fornecedor RetornaFornecedor(Fornecedor filtro)
        {


            return filtro;

        }

        public Fornecedor GetFornecedor(int fr_id)
        {
          return forn.GetFornecedor(fr_id);
        }



    }
}
