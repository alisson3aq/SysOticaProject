using ClassLibrary1;
using SysOtica.Conexão;
using SysOtica.Negócio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmLocal : Form
    {
        public frmLocal()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Local local = new Local();
                {
                    local.Lc_nomeclinica = textBoxNomeclinica.Text;
                    local.Lc_endereco = textBoxEndereco.Text;
                    local.Lc_numero = textBoxNumero.Text;
                    local.Lc_bairro = textBoxBairro.Text;
                    local.Lc_cidade = textBoxCidade.Text;
                    local.Lc_uf = textBoxUF.Text;
                    local.Lc_cep = maskedTextBoxCEP.Text;
                    local.Lc_telefone = maskedTextBoxTelefone.Text;
                    local.Lc_email = textBoxEmail.Text;
                }

                Fachada fachada = new Fachada();
                fachada.IncluirLocal(local);
                new LocalDados().Inserir(local);
                //new LocalDados().Inserir(local);
                MessageBox.Show("Local cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro" + ex.Message);
            }
        }


        public void LimparCampos()
        {
            textBoxNomeclinica.Text = "";
            textBoxEndereco.Text = ""; 
            textBoxNumero.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            textBoxUF.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEmail.Text = "";

        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
