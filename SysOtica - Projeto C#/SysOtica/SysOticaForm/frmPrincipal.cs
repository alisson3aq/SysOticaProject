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
    public partial class frmPrincipal : Form
    {
        public static frmPrincipal mdiobj;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsuario usuario = new frmUsuario();
            usuario.MdiParent = this;
            usuario.Show();


        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCliente cliente = new frmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFornecedor fornecedor = new frmFornecedor();
            fornecedor.MdiParent = this;
            fornecedor.Show();

        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedico1 medico = new frmMedico1();
            medico.MdiParent = this;
            medico.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProduto produto = new formProduto();
            produto.MdiParent = this;
            produto.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceita receita = new frmReceita();
            receita.MdiParent = this;
            receita.Show();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocal local = new frmLocal();
            local.MdiParent = this;
            local.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarClientes listarclientes = new frmListarClientes();
            listarclientes.MdiParent = this;
            listarclientes.Show();

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarFornecedor listarfornecedores = new frmListarFornecedor();
            listarfornecedores.MdiParent = this;
            listarfornecedores.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarUsuario listarUsuarios = new frmListarUsuario();
            listarUsuarios.MdiParent = this;
            listarUsuarios.Show();
        }

        private void locaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarLocal listarLocal = new frmListarLocal();
            listarLocal.MdiParent = this;
            listarLocal.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarMedico listarMedicos = new frmListarMedico();
            listarMedicos.MdiParent = this;
            listarMedicos.Show();
    
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProduto listarProdutos = new frmListarProduto();
            listarProdutos.MdiParent = this;
            listarProdutos.Show();
        }

        private void agendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarAgenda listarAgenda = new frmListarAgenda();
            listarAgenda.MdiParent = this;
            listarAgenda.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarConsulta listarConsulta = new frmListarConsulta();
            listarConsulta.MdiParent = this;
            listarConsulta.Show();
        }
    }
}
