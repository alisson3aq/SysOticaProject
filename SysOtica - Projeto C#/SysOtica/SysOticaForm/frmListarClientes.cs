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
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            //Desabilito a geração automática de colunas
            dataGridViewCliente.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            dataGridViewCliente.DataSource = new ClienteDados().listaCliente();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewCliente.Rows.Count > 1)
            {
                dataGridViewCliente.SelectedRows[0].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[1].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[2].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[3].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[4].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[5].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[6].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[7].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[8].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[9].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[10].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[11].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[12].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[13].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[14].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[15].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[16].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[17].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[18].Cells[0].Value.ToString();
                dataGridViewCliente.SelectedRows[19].Cells[0].Value.ToString();
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
            string cl_cpf = maskedTextBoxCPF.Text;
            dataGridViewCliente.DataSource = dc.pesquisarCliente(cl_cpf);

        }
    }
}
