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
    }
}
