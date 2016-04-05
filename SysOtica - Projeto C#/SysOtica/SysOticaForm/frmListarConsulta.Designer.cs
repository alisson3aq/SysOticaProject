namespace SysOticaForm
{
    partial class frmListarConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o Número da Consulta";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(275, 18);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 6;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAtualizar);
            this.groupBox1.Controls.Add(this.dataGridViewConsulta);
            this.groupBox1.Controls.Add(this.buttonSair);
            this.groupBox1.Controls.Add(this.buttonAlterar);
            this.groupBox1.Controls.Add(this.tbListarUsuario);
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 406);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(466, 285);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 14;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToAddRows = false;
            this.dataGridViewConsulta.AllowUserToDeleteRows = false;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewConsulta.Location = new System.Drawing.Point(14, 56);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(527, 223);
            this.dataGridViewConsulta.TabIndex = 11;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(466, 368);
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
            this.tbListarUsuario.Location = new System.Drawing.Point(156, 19);
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
            this.Column1.DataPropertyName = "co_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "co_data";
            this.Column2.HeaderText = "Data da Consulta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "cl_id";
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 64;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "md_id";
            this.Column4.HeaderText = "Médico";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 67;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "ag_id";
            this.Column5.HeaderText = "Agenda Identificador";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 119;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "lc_id";
            this.Column6.HeaderText = "Local";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 58;
            // 
            // frmListarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 431);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarConsulta";
            this.Text = "frmListarConsulta";
            this.Load += new System.EventHandler(this.frmListarConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox tbListarUsuario;
        private System.Windows.Forms.Button buttonExcluir;
    }
}