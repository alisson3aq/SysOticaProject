using SysOtica;
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
    public partial class frmListarFornecedor : Form
    {
        List<Fornecedor> listaFornecedor;
        Int32 selectedRowCount;
        Int32 linha;
        public frmListarFornecedor()
        {
            InitializeComponent();
        }

        public void frmListarFornecedor_Load(object sender, EventArgs e)
        {
            dataGridViewFornecedor.AutoGenerateColumns = false;
            //Atribuo o list retornado pelo método ao DataSource do grid
            listaFornecedor = new FornecedorDados().listaFornecedor();
            dataGridViewFornecedor.DataSource = listaFornecedor;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            //FornecedorDados fd = new FornecedorDados();
            //fd.Excluir(int.Parse(dataGridViewFornecedor.SelectedRows[0].Index.ToString()));

            //if (selectedRowCount > 0)
            //{
            //    Fachada fachada = new Fachada();
            //    fachada.ExcluirFornecedor(selectedRowCount);

            //}


        }


        public void dataGridViewFornecedor_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Fachada fachada = new Fachada();
            
        }
    }
}




//Fornecedor f = listaFornecedor.ElementAt(dataGridViewFornecedor.CurrentRow.Index);
//// MessageBox.Show(f.Fr_nomerepresentante.ToString(), "Linhas Selecionadas");
//Int32 selectedCellCount = dataGridViewFornecedor.GetCellCount(DataGridViewElementStates.Selected);
//            if (selectedCellCount > 0)
//            {
//                selectedRowCount = dataGridViewFornecedor.Rows.GetRowCount(DataGridViewElementStates.Selected);

//                if (selectedRowCount > 0)
//                {


//                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

//                    for (int i = 0; i<selectedRowCount; i++)
//                    {

//                        sb.Append("Linha: ");
//                        sb.Append(dataGridViewFornecedor.SelectedRows[i].Index.ToString());
//                        sb.Append(Environment.NewLine);

//                    }

//                    //sb.Append("Total: " + selectedRowCount.ToString());

//                }


//            }
//        }
//    }
//}