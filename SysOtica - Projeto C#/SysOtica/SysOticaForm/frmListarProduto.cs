using SysOtica;
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
    public partial class frmListarProduto : Form
    {
        public frmListarProduto()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }

        private void frmListarProduto_Load(object sender, EventArgs e)
        {
            dataGridViewProduto.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            dataGridViewProduto.DataSource = new ProdutoDados().listarProduto();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                //verifica se tem alguma linha seleciona
                if (dataGridViewProduto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione a linha para excluir");
                    return;
                }
                //Pergunta se realmente quer excluir
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esse produto?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                Produto produto;
                //pega o cliente no grid
                produto = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);
                Fachada fac = new Fachada();
                fac.ExcluirProduto(produto);
                MessageBox.Show("Cliente excluido com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex.Message);
            }

        }
    }
}
