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

        private void frmListarProduto_Load(object sender, EventArgs e)
        {
            dataGridViewProduto.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            dataGridViewProduto.DataSource = new ProdutoDados().listarProduto();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
