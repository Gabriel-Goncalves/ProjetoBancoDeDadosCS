using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoN1.Controller;
using ProjetoN1.View;

namespace ProjetoN1.View
{
    public partial class CadastroAlunos : Form
    {
        EscolaController escolaCont = new EscolaController();

        public CadastroAlunos()
        {
            InitializeComponent();
        }

        private void CadastroAlunos_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataNasc;
            string nomeAluno, nomeResponsavel, cpf, contato, email;
            string anoEscolar;

            dataNasc = data_nascimento.Value;
            nomeAluno = nome_aluno.Text;
            cpf = cpf_responsavel.Text;
            nomeResponsavel = nome_responsavel.Text;
            contato = Contato.Text;
            email = Email.Text;
            anoEscolar = ano_escolar.Text;

            try
            {
                if(MessageBox.Show("Deseja Cadastrar o Aluno?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    escolaCont.Gravar(nomeAluno, nomeResponsavel, cpf, anoEscolar, dataNasc, contato, email);
                    data_nascimento.Value = DateTime.Today;
                    nome_aluno.Text = "";
                    cpf_responsavel.Text = "";
                    nome_responsavel.Text = "";
                    Contato.Text = "";
                    Email.Text = "";
                    ano_escolar.Text = "";

                    MessageBox.Show("Aluno Cadastrado com sucesso!");
                }
            }catch(Exception m)
            {
                MessageBox.Show(m.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarAluno pesquisar = new PesquisarAluno();
            pesquisar.Show();
        }
    }
}
