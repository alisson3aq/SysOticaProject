using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negócio
{
    public class Agenda
    {
        private int ag_id;
        private Medico md_id;
        private Consulta co_id;
        private Local lc_id;
        private DateTime ag_diasemana;
        private string ag_horario;

        public int Ag_id
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

        public Consulta Co_id
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

        public DateTime Ag_diasemana
        {
            get
            {
                return ag_diasemana;
            }

            set
            {
                ag_diasemana = value;
            }
        }

        public string Ag_horario
        {
            get
            {
                return ag_horario;
            }

            set
            {
                ag_horario = value;
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
