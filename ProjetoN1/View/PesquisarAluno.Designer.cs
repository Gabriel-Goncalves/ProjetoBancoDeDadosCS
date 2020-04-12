namespace ProjetoN1.View
{
    partial class PesquisarAluno
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
            this.TextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.NomeAluno = new System.Windows.Forms.TextBox();
            this.DataNasc = new System.Windows.Forms.TextBox();
            this.AnoEscolar = new System.Windows.Forms.TextBox();
            this.NomeResp = new System.Windows.Forms.TextBox();
            this.Contato = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF Responsável:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano Escolar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome Responsável:";
            // 
            // TextBoxCpf
            // 
            this.TextBoxCpf.Location = new System.Drawing.Point(131, 31);
            this.TextBoxCpf.Mask = "999.999.999-99";
            this.TextBoxCpf.Name = "TextBoxCpf";
            this.TextBoxCpf.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCpf.TabIndex = 5;
            this.TextBoxCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextBoxCpf_MaskInputRejected);
            // 
            // NomeAluno
            // 
            this.NomeAluno.Location = new System.Drawing.Point(96, 118);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(347, 20);
            this.NomeAluno.TabIndex = 6;
            // 
            // DataNasc
            // 
            this.DataNasc.Location = new System.Drawing.Point(131, 161);
            this.DataNasc.Name = "DataNasc";
            this.DataNasc.Size = new System.Drawing.Size(144, 20);
            this.DataNasc.TabIndex = 7;
            this.DataNasc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AnoEscolar
            // 
            this.AnoEscolar.Location = new System.Drawing.Point(106, 200);
            this.AnoEscolar.Name = "AnoEscolar";
            this.AnoEscolar.Size = new System.Drawing.Size(184, 20);
            this.AnoEscolar.TabIndex = 8;
            this.AnoEscolar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // NomeResp
            // 
            this.NomeResp.Location = new System.Drawing.Point(142, 237);
            this.NomeResp.Name = "NomeResp";
            this.NomeResp.Size = new System.Drawing.Size(301, 20);
            this.NomeResp.TabIndex = 9;
            // 
            // Contato
            // 
            this.Contato.Location = new System.Drawing.Point(83, 286);
            this.Contato.Name = "Contato";
            this.Contato.Size = new System.Drawing.Size(155, 20);
            this.Contato.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(83, 331);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(279, 20);
            this.Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Nova Pesquisa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PesquisarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Contato);
            this.Controls.Add(this.NomeResp);
            this.Controls.Add(this.AnoEscolar);
            this.Controls.Add(this.DataNasc);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.TextBoxCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PesquisarAluno";
            this.Text = "PesquisarAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TextBoxCpf;
        private System.Windows.Forms.TextBox NomeAluno;
        private System.Windows.Forms.TextBox DataNasc;
        private System.Windows.Forms.TextBox AnoEscolar;
        private System.Windows.Forms.TextBox NomeResp;
        private System.Windows.Forms.TextBox Contato;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}