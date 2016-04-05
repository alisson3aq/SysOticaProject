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
    public partial class frmListarLocal : Form
    {
        public frmListarLocal()
        {
            InitializeComponent();
        }

        private void frmListarLocal_Load(object sender, EventArgs e)
        {
            //Desabilito a geração automática de colunas
            dataGridViewLocal.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            dataGridViewLocal.DataSource = new LocalDados().listaLocal();
        }
    }
}
