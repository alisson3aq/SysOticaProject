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
    public partial class frmListarMedico : Form
    {
        public frmListarMedico()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmListarMedico_Load(object sender, EventArgs e)
        {

            dataGridViewMedico.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            dataGridViewMedico.DataSource = new MedicoDados().listarMedico();
        }
    }
}
