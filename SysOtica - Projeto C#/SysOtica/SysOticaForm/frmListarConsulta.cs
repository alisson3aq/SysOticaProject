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
    public partial class frmListarConsulta : Form
    {
        public frmListarConsulta()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmListarConsulta_Load(object sender, EventArgs e)
        {
            dataGridViewConsulta.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            //dataGridViewConsulta.DataSource = new ConsultaDados().listarConsulta();
        }
    }
}
