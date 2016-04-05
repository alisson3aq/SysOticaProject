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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewListarProduto = new System.Windows.Forms.DataGridView();
            this.pr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_grife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_estoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 1;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // frmListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarProduto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


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

    }
}