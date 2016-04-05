namespace SysOticaForm
{
    partial class frmListarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewListarProduto = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_grife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_estoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewListarProduto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código do Produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListarProduto
            // 
            this.dataGridViewListarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_id,
            this.pr_descricao,
            this.pr_valor,
            this.pr_quantidade,
            this.pr_unidade,
            this.pr_grupo,
            this.pr_grife,
            this.fr_id,
            this.pr_estoqueMinimo});
            this.dataGridViewListarProduto.Location = new System.Drawing.Point(9, 95);
            this.dataGridViewListarProduto.Name = "dataGridViewListarProduto";
            this.dataGridViewListarProduto.Size = new System.Drawing.Size(941, 301);
            this.dataGridViewListarProduto.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(780, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pr_id
            // 
            this.pr_id.HeaderText = "Código";
            this.pr_id.Name = "pr_id";
            this.pr_id.ReadOnly = true;
            // 
            // pr_descricao
            // 
            this.pr_descricao.HeaderText = "Descrição";
            this.pr_descricao.Name = "pr_descricao";
            this.pr_descricao.ReadOnly = true;
            // 
            // pr_valor
            // 
            this.pr_valor.HeaderText = "Valor";
            this.pr_valor.Name = "pr_valor";
            this.pr_valor.ReadOnly = true;
            // 
            // pr_quantidade
            // 
            this.pr_quantidade.HeaderText = "Quantidade";
            this.pr_quantidade.Name = "pr_quantidade";
            this.pr_quantidade.ReadOnly = true;
            // 
            // pr_unidade
            // 
            this.pr_unidade.HeaderText = "Unidade";
            this.pr_unidade.Name = "pr_unidade";
            this.pr_unidade.ReadOnly = true;
            // 
            // pr_grupo
            // 
            this.pr_grupo.HeaderText = "Grupo";
            this.pr_grupo.Name = "pr_grupo";
            this.pr_grupo.ReadOnly = true;
            // 
            // pr_grife
            // 
            this.pr_grife.HeaderText = "Grife";
            this.pr_grife.Name = "pr_grife";
            this.pr_grife.ReadOnly = true;
            // 
            // fr_id
            // 
            this.fr_id.HeaderText = "Fornecedor";
            this.fr_id.Name = "fr_id";
            this.fr_id.ReadOnly = true;
            // 
            // pr_estoqueMinimo
            // 
            this.pr_estoqueMinimo.HeaderText = "Estoque Mínimo";
            this.pr_estoqueMinimo.Name = "pr_estoqueMinimo";
            this.pr_estoqueMinimo.ReadOnly = true;
=======
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.tbListarUsuario = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o Número do Produto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAtualizar);
            this.groupBox1.Controls.Add(this.dataGridViewProduto);
            this.groupBox1.Controls.Add(this.buttonSair);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Controls.Add(this.tbListarUsuario);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 406);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(419, 285);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 14;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewProduto.Location = new System.Drawing.Point(14, 56);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.Size = new System.Drawing.Size(480, 223);
            this.dataGridViewProduto.TabIndex = 11;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(419, 368);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 17;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(8, 368);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 15;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // tbListarUsuario
            // 
            this.tbListarUsuario.Location = new System.Drawing.Point(155, 20);
            this.tbListarUsuario.Name = "tbListarUsuario";
            this.tbListarUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbListarUsuario.TabIndex = 10;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(117, 368);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 16;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "pr_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "pr_descricao";
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "pr_unidade";
            this.Column3.HeaderText = "UND";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 56;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "pr_grupo";
            this.Column4.HeaderText = "Grupo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 61;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "pr_grife";
            this.Column5.HeaderText = "Grife";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 54;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "pr_valor";
            this.Column6.HeaderText = "Valor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 56;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "pr_qtd";
            this.Column7.HeaderText = "Quantidade";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 87;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "pr_estoqueminimo";
            this.Column8.HeaderText = "Estoque Mínimo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "fr_id";
            this.Column9.HeaderText = "Fornecedor";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 86;
>>>>>>> origin/master
            // 
            // frmListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(963, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
=======
            this.ClientSize = new System.Drawing.Size(534, 426);
>>>>>>> origin/master
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarProduto";
<<<<<<< HEAD
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarProduto)).EndInit();
=======
            this.Load += new System.EventHandler(this.frmListarProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
>>>>>>> origin/master
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewListarProduto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_grife;
        private System.Windows.Forms.DataGridViewTextBoxColumn fr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_estoqueMinimo;
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox tbListarUsuario;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
>>>>>>> origin/master
    }
}