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
    public partial class frmListarUsuario : Form
    {
        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            dataGridViewUsuario.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            dataGridViewUsuario.DataSource = new UsuarioDados().listaUsuario();
        }
    }
}
