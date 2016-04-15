using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using SysOtica.Negócio;

namespace SysOtica
{
    public class Produto
    {

        private int pr_id;
        private String pr_descricao;
        private String pr_unidade;
        private String pr_grupo;
        private String pr_grife;
        private int pr_valor;
        private int pr_qtd;
        private int pr_estoqueminimo;
        private Fornecedor fr_id;
        private ProdutoVenda pv_id;
        private ProdutoFornecedor pf_id;

        public Produto(int pr_id, string pr_descricao, string pr_unidade, string pr_grupo, string pr_grife, int pr_valor, int pr_qtd, int pr_estoqueminimo, Fornecedor fr_id, ProdutoVenda pv_id, ProdutoFornecedor pf_id)
        {
            this.pr_id = pr_id;
            this.pr_descricao = pr_descricao;
            this.pr_unidade = pr_unidade;
            this.pr_grupo = pr_grupo;
            this.pr_grife = pr_grife;
            this.pr_valor = pr_valor;
            this.pr_qtd = pr_qtd;
            this.pr_estoqueminimo = pr_estoqueminimo;
            this.fr_id = new Fornecedor();
            this.pv_id = new ProdutoVenda();
            this.pf_id = new ProdutoFornecedor();
        }

        public int Pr_id
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

        public string Pr_descricao
        {
            get
            {
                return pr_descricao;
            }

            set
            {
                pr_descricao = value;
            }
        }

        public string Pr_unidade
        {
            get
            {
                return pr_unidade;
            }

            set
            {
                pr_unidade = value;
            }
        }

        public string Pr_grupo
        {
            get
            {
                return pr_grupo;
            }

            set
            {
                pr_grupo = value;
            }
        }

        public string Pr_grife
        {
            get
            {
                return pr_grife;
            }

            set
            {
                pr_grife = value;
            }
        }

        public int Pr_valor
        {
            get
            {
                return pr_valor;
            }

            set
            {
                pr_valor = value;
            }
        }

        public int Pr_qtd
        {
            get
            {
                return pr_qtd;
            }

            set
            {
                pr_qtd = value;
            }
        }

        public int Pr_estoqueminimo
        {
            get
            {
                return pr_estoqueminimo;
            }

            set
            {
                pr_estoqueminimo = value;
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

        public ProdutoVenda Pv_id
        {
            get
            {
                return pv_id;
            }

            set
            {
                pv_id = value;
            }
        }

        public ProdutoFornecedor Pf_id
        {
            get
            {
                return pf_id;
            }

            set
            {
                pf_id = value;
            }
        }
    }
}