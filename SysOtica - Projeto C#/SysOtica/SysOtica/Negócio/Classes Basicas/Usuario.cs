using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace SysOtica
{
    public class Usuario
    {

        private int us_id;
        private String us_senha;
        private String us_endereco;
        private String us_telefone;
        private String us_tipo;
        private String us_usuario;
        private String us_nome;

        public int Us_id
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

        public string Us_senha
        {
            get
            {
                return us_senha;
            }

            set
            {
                us_senha = value;
            }
        }

        public string Us_endereco
        {
            get
            {
                return us_endereco;
            }

            set
            {
                us_endereco = value;
            }
        }

        public string Us_telefone
        {
            get
            {
                return us_telefone;
            }

            set
            {
                us_telefone = value;
            }
        }

        public string Us_tipo
        {
            get
            {
                return us_tipo;
            }

            set
            {
                us_tipo = value;
            }
        }

        public string Us_usuario
        {
            get
            {
                return us_usuario;
            }

            set
            {
                us_usuario = value;
            }
        }

        public string Us_nome
        {
            get
            {
                return us_nome;
            }

            set
            {
                us_nome = value;
            }
        }
    }
}
