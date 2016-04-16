using ClassLibrary1;
using SysOtica.Negócio;
using SysOtica.Conexão;
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
    public partial class frmListarClientes : Form
    {
        List<Cliente> listaCliente;
       
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            //Desabilito a geração automática de colunas
            dataGridViewCliente.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            listaCliente = new ClienteDados().listaCliente();
            dataGridViewCliente.DataSource = listaCliente;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewCliente.SelectedRows[0].Index >= 0)
            {
                Cliente clienteSelecionado = listaCliente.ElementAt(dataGridViewCliente.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Clique em pesquisar");
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            IClienteDados dc = new ClienteDados();
            string cl_cpf = textBoxPesqCPF.Text;
            dataGridViewCliente.DataSource = dc.pesquisarCliente(cl_cpf);

        }
    }
}
