using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica
{
    public class Medico
    {
        private int md_id;
        private String md_nome;
        private String md_crm;
        private String md_email;
        private String md_telefone;

        public int Md_id
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

        public string Md_nome
        {
            get
            {
                return md_nome;
            }

            set
            {
                md_nome = value;
            }
        }

        public string Md_crm
        {
            get
            {
                return md_crm;
            }

            set
            {
                md_crm = value;
            }
        }

        public string Md_email
        {
            get
            {
                return md_email;
            }

            set
            {
                md_email = value;
            }
        }

        public string Md_telefone
        {
            get
            {
                return md_telefone;
            }

            set
            {
                md_telefone = value;
            }
        }
    }
}
