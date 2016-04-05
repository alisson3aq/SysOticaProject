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
    public class LocalControlador
    {

        string modelo_Email = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        string caracteres = "^[ a-zA-Z]+$";
        string numeros = "^[ 0-9-]+$";
        string LetraseNum = "^[0-9a-zA-Z.-]+$";

        ILocalDados lc = new LocalDados();

        public Boolean verificaPreenchimento(Local local)
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

            return true;
        }


        public void ValidaLocal(Local local)
        {
            if (local.Lc_nomeclinica.Length < 3 || (!Regex.IsMatch(local.Lc_nomeclinica, caracteres)))
            {
                throw new CampoVazioException("Numero de caracteres inferior ou dados do Nome invalidos, favor tente novamente");
            }
            if (local.Lc_endereco.Length < 7 || (!Regex.IsMatch(local.Lc_endereco, LetraseNum)))
            {
                throw new CampoVazioException("Numero de caracteres inferior ou dados do Local invalidos, favor tente novamente");
            }
            if (local.Lc_numero.Equals("0") || local.Lc_numero.Length > 5 || (!Regex.IsMatch(local.Lc_numero, numeros)))
            {
                throw new CampoVazioException("Campo numero Invalido, favor tente novamente");
            }
            if (local.Lc_bairro.Length < 4 || (!Regex.IsMatch(local.Lc_bairro, LetraseNum)))
            {
                throw new CampoVazioException("Campo bairro Invalido, favor tente novamente");
            }
            if (local.Lc_uf.Length > 2 || (!Regex.IsMatch(local.Lc_uf, caracteres)))
            {
                throw new CampoVazioException("Campo UF Invalido, favor tente novamente");
            }
            if (local.Lc_cidade.Length < 4 || (!Regex.IsMatch(local.Lc_cidade, caracteres)))
            {
                throw new CampoVazioException("Campo Cidade Invalido, favor tente novamente");
            }
            if (!Regex.IsMatch(local.Lc_email, modelo_Email))
            {
                throw new CampoVazioException("Campo Email Invalido, favor tente novamente");
            }

           

        }


        public void Inserir(Local local)
        {
            //falta colocar o try junto com catch da exception - ainda vou fazer conexao  e geral exception


           lc.Inserir(local);
        }
    }
}
