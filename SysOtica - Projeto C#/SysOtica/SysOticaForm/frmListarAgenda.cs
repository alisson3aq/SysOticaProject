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
    public partial class frmListarAgenda : Form
    {
        public frmListarAgenda()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmListarAgenda_Load(object sender, EventArgs e)
        {
            dataGridViewAgenda.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
           // dataGridViewAgenda.DataSource = new AgendaDados().listarAgenda();
        }
    }
}
