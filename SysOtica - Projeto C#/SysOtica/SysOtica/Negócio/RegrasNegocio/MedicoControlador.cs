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
    class MedicoControlador
    {
        string modelo_Email = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        string caracteres = "^[ a-zA-Z]+$";
        string numeros = "^[ 0-9-]+$";
       // ^[A-Za-z]+


        IMedicoDados ControladorMedico = new MedicoDados();

          public Boolean VerificaPreenchimento(Medico medico) 
         {
                if (String.IsNullOrEmpty(medico.Md_nome))
                {
                    throw new CampoVazioException("Campo nome Vazio");
                }
                if (String.IsNullOrEmpty(medico.Md_crm))
                {
                    throw new CampoVazioException("Campo CRM Vazio");
                }
                if (String.IsNullOrEmpty(medico.Md_telefone))
                {
                    throw new CampoVazioException("Campo Telefone Vazio");
                }
                if (String.IsNullOrEmpty(medico.Md_email))
                {
                    throw new CampoVazioException("Campo Email Vazio");
                }

            return true;
        }



        public void ValidaMedico(Medico medico)
        {
                if (medico.Md_nome.Length < 3 || medico.Md_crm.Length < 5 || medico.Md_telefone.Length < 11)
                {
                throw new CampoVazioException("numero inferior de caracteres");
                }
            
                else if (!Regex.IsMatch(medico.Md_nome, caracteres) || (Regex.IsMatch(medico.Md_nome, numeros)))
                {
                    throw new CampoVazioException("campo nome invalido");
                }
                else if (!Regex.IsMatch(medico.Md_crm, numeros) || (Regex.IsMatch(medico.Md_crm, caracteres)))
                {
                    throw new CampoVazioException("campo CRM Invalido");
                }
                else if (!Regex.IsMatch(medico.Md_email, modelo_Email))
                {
                   throw new CampoVazioException("campo Email Invalido");
                }

        }

        public void Inserir(Medico medico)
        {
            ControladorMedico.Inserir(medico);
        }

        public void Alterar(Medico medico)
        {
            ControladorMedico.Alterar(medico);

        }
        public void Excluir(int id)
        {
            ControladorMedico.Excluir(id);
        }
       



    }
}
