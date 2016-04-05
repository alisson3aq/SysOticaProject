using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio
{
    public class Venda
    {
        private int vn_id;
        private Cliente cl_id;
        private Usuario us_id;

        public int Vn_id
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

        public Cliente Cl_id
        {
            get
            {
                return cl_id;
            }

            set
            {
                cl_id = value;
            }
        }

        public Usuario Us_id
        {
            get
            {
                return us_id;
            }

            set
            {
                us_id = value;
            }
        }
    }
}
