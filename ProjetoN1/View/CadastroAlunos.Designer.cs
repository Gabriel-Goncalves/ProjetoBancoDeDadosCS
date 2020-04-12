namespace ProjetoN1.View
{
    partial class CadastroAlunos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nome_aluno = new System.Windows.Forms.TextBox();
            this.data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ano_escolar = new System.Windows.Forms.ComboBox();
            this.nome_responsavel = new System.Windows.Forms.ComboBox();
            this.cpf_responsavel = new System.Windows.Forms.MaskedTextBox();
            this.Contato = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano Escolar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "RESPONSÁVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contato:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nome_aluno
            // 
            this.nome_aluno.Location = new System.Drawing.Point(104, 56);
            this.nome_aluno.Name = "nome_aluno";
            this.nome_aluno.Size = new System.Drawing.Size(462, 20);
            this.nome_aluno.TabIndex = 9;
            // 
            // data_nascimento
            // 
            this.data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimento.Location = new System.Drawing.Point(149, 92);
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Size = new System.Drawing.Size(97, 20);
            this.data_nascimento.TabIndex = 10;
            // 
            // ano_escolar
            // 
            this.ano_escolar.FormattingEnabled = true;
            this.ano_escolar.Items.AddRange(new object[] {
            "1 Ano",
            "2 Ano",
            "3 Ano",
            "4 Ano",
            "5 Ano",
            "6 Ano",
            "7 Ano",
            "8 Ano",
            "9 Ano"});
            this.ano_escolar.Location = new System.Drawing.Point(134, 123);
            this.ano_escolar.Name = "ano_escolar";
            this.ano_escolar.Size = new System.Drawing.Size(121, 21);
            this.ano_escolar.TabIndex = 11;
            this.ano_escolar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nome_responsavel
            // 
            this.nome_responsavel.FormattingEnabled = true;
            this.nome_responsavel.Location = new System.Drawing.Point(104, 222);
            this.nome_responsavel.Name = "nome_responsavel";
            this.nome_responsavel.Size = new System.Drawing.Size(462, 21);
            this.nome_responsavel.TabIndex = 12;
            this.nome_responsavel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cpf_responsavel
            // 
            this.cpf_responsavel.Location = new System.Drawing.Point(104, 262);
            this.cpf_responsavel.Mask = "999.999.999-99";
            this.cpf_responsavel.Name = "cpf_responsavel";
            this.cpf_responsavel.Size = new System.Drawing.Size(91, 20);
            this.cpf_responsavel.TabIndex = 13;
            this.cpf_responsavel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Contato
            // 
            this.Contato.Location = new System.Drawing.Point(104, 302);
            this.Contato.Mask = "99-999999999";
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(160, 20);
            this.Contato.TabIndex = 14;
            // 
            // Email
            // 
            this.Email.FormattingEnabled = true;
            this.Email.Location = new System.Drawing.Point(104, 340);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(365, 21);
            this.Email.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "GRAVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // CadastroAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.cpf_responsavel);
            this.Controls.Add(this.nome_responsavel);
            this.Controls.Add(this.ano_escolar);
            this.Controls.Add(this.data_nascimento);
            this.Controls.Add(this.nome_aluno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroAlunos";
            this.Text = "CadastroAlunos";
            this.Load += new System.EventHandler(this.CadastroAlunos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nome_aluno;
        private System.Windows.Forms.DateTimePicker data_nascimento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox ano_escolar;
        private System.Windows.Forms.ComboBox nome_responsavel;
        private System.Windows.Forms.MaskedTextBox cpf_responsavel;
        private System.Windows.Forms.MaskedTextBox Contato;
        private System.Windows.Forms.ComboBox Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
    }
}