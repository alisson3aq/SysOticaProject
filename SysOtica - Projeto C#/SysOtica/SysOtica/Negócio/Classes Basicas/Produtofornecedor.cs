using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica
{
    public class ProdutoFornecedor
    {
        private int pf_qtd;
        private DateTime pf_dtentrada;
        private Produto pr_id;
        private Fornecedor fr_id;
        private string pf_tipo;
        private string pf_observacoes;

        
        public int Pf_qtd
        {
            get
            {
                return pf_qtd;
            }

            set
            {
                pf_qtd = value;
            }
        }

        public DateTime Pf_dtentrada
        {
            get
            {
                return pf_dtentrada;
            }

            set
            {
                pf_dtentrada = value;
            }
        }

        public Produto Pr_id
        {
            get
            {
                return pr_id;
            }

            set
            {
                pr_id = value;
            }
        }

        public Fornecedor Fr_id
        {
            get
            {
                return fr_id;
            }

            set
            {
                fr_id = value;
            }
        }

        public string Pf_tipo
        {
            get
            {
                return pf_tipo;
            }

            set
            {
                pf_tipo = value;
            }
        }

        public string Pf_observacoes
        {
            get
            {
                return pf_observacoes;
            }

            set
            {
                pf_observacoes = value;
            }
        }
    }
}
