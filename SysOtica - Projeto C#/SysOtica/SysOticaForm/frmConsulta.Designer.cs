namespace SysOticaForm
{
    partial class frmConsulta
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.comboPaciente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDiasemDisponivel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDiasemDisponivel);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.comboMedico);
            this.groupBox1.Controls.Add(this.comboPaciente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(36, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(426, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dias da semana disponivel";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 162);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08h00  - 11h00",
            "13h00  - 16h00"});
            this.comboBox1.Location = new System.Drawing.Point(453, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Horario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecione uma data: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Médico :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(483, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // comboMedico
            // 
            this.comboMedico.FormattingEnabled = true;
            this.comboMedico.Location = new System.Drawing.Point(36, 56);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(426, 21);
            this.comboMedico.TabIndex = 1;
            // 
            // comboPaciente
            // 
            this.comboPaciente.FormattingEnabled = true;
            this.comboPaciente.Location = new System.Drawing.Point(36, 16);
            this.comboPaciente.Name = "comboPaciente";
            this.comboPaciente.Size = new System.Drawing.Size(426, 21);
            this.comboPaciente.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxDiasemDisponivel
            // 
            this.comboBoxDiasemDisponivel.FormattingEnabled = true;
            this.comboBoxDiasemDisponivel.Location = new System.Drawing.Point(288, 161);
            this.comboBoxDiasemDisponivel.Name = "comboBoxDiasemDisponivel";
            this.comboBoxDiasemDisponivel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiasemDisponivel.TabIndex = 17;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcação de Consulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboMedico;
        private System.Windows.Forms.ComboBox comboPaciente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDiasemDisponivel;
    }
}