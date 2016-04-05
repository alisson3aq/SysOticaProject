using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio
{
    public class Consulta
    {
        private int co_id;
        private Cliente cl_id;
        private Medico md_id;
        private Agenda ag_id;
        private Local lc_id;
        private DateTime co_data;


        public int Co_id
        {
            get
            {
                return co_id;
            }

            set
            {
                co_id = value;
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

        public DateTime Co_data
        {
            get
            {
                return co_data;
            }

            set
            {
                co_data = value;
            }
        }

        public Medico Md_id
        {
            get
            {
                return md_id;
            }

            set
            {
                md_id = value;
            }
        }

        public Agenda Ag_id
        {
            get
            {
                return ag_id;
            }

            set
            {
                ag_id = value;
            }
        }

        internal Local Lc_id
        {
            get
            {
                return lc_id;
            }

            set
            {
                lc_id = value;
            }
        }
    }
}
