using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio
{
   public class ProdutoVenda
    {
        private Produto pr_id;
        private Venda vn_id;
        private DateTime pv_dtsaida;

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
