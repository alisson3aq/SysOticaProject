using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio
{
    public class ProdutoVenda
    {
        private int pv_id;
        private List<Produto> pr_id;
        private Venda vn_id;
        private DateTime pv_dtsaida;

        public ProdutoVenda(int pv_id, Produto pr_id, Venda vn_id, DateTime pv_dtsaida)
        {
            this.pv_id = pv_id;
            this.pr_id = new List<Produto>();
            this.vn_id = new Venda();
            this.pv_dtsaida = pv_dtsaida;
        }

        public ProdutoVenda()
        {
        }

        public int Pv_id
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

        public Venda Vn_id
        {
            get
            {
                return vn_id;
            }

            set
            {
                vn_id = value;
            }
        }

        public DateTime Pv_dtsaida
        {
            get
            {
                return pv_dtsaida;
            }

            set
            {
                pv_dtsaida = value;
            }
        }
    }
}