﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using SysOtica.Negócio;
using SysOtica;
using SysOtica.Conexão;

namespace SysOticaForm
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
        public void LimpaCampos()
        {
            tbUsuario.Text = "";
            tbSenha.Text = "";
            tbTipo.Text = "";
            tbNome.Text = "";
            tbEndereco.Text = "";
            maskedTextBoxTelefone.Text = "";

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                {
                    usuario.Us_usuario = tbUsuario.Text;
                    usuario.Us_senha = tbSenha.Text;
                    usuario.Us_tipo = tbTipo.Text;
                    usuario.Us_nome = tbNome.Text;
                    usuario.Us_endereco = tbEndereco.Text;
                    usuario.Us_telefone = maskedTextBoxTelefone.Text;
                };
                new UsuarioDados().Inserir(usuario);
                MessageBox.Show("Cadastro feito com Sucesso !");


                LimpaCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar com o Banco de Dados! " + ex.Message);
            }
        }
        private void buttonLimpar_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
