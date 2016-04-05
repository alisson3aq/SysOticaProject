﻿using SysOtica.Conexão;
using SysOtica.Negócio.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio.RegrasNegocio
{
    class ReceitaControlador
    {
        IReceitaDados ControladorReceita = new ReceitaDados();


        public void VerificaPreenchimento(Receita receita)
        {
            if (receita.Rc_lodesferico.Equals("") || receita.Rc_loeesferico.Equals("") || receita.Rc_podesferico.Equals("") || receita.Rc_poeesferico.Equals(""))
            {
                throw new CampoVazioException("Campos Esfericos Vazios");
            }
            if (receita.Rc_lodcilindrico.Equals("") || receita.Rc_loecilindrico.Equals("") || receita.Rc_podcilindrico.Equals("") || receita.Rc_poecilindrico.Equals(""))

            {
                throw new CampoVazioException("Campos cilindricos Vazios");
            }
            if (receita.Rc_lodeixo.Equals("") || receita.Rc_loeeixo.Equals("") || receita.Rc_podeixo.Equals("") || receita.Rc_poeeixo.Equals(""))
            {
                throw new CampoVazioException("Campos eixos Vazios");
            }
            if (receita.Rc_lodaltura.Equals("") || receita.Rc_loealtura.Equals("") || receita.Rc_podaltura.Equals("") || receita.Rc_poealtura.Equals(""))
            {

                throw new CampoVazioException("Campos alturas Vazios");
            }
            if (String.IsNullOrEmpty(Convert.ToDateTime(receita.Rc_data).ToString()))
            {
                throw new CampoVazioException("Campo data da receita Vazio");
            }
            if (String.IsNullOrEmpty(receita.Rc_nomemedico))
            {
                throw new CampoVazioException("Campo nome do médico Vazio");
            }
            if (String.IsNullOrEmpty(receita.Rc_observacoes))
            {
                throw new CampoVazioException("Campo observação vazio");
            }

        }
        // ainda faltam data da validade e o campo adição

        public void Inserir(Receita receita)
        {
            // ControladorReceita(receita);
        }

    }
}

