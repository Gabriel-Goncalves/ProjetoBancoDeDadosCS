using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoN1.Model;
using ProjetoN1.Controller;

namespace ProjetoN1.View
{
    public partial class PesquisarAluno : Form
    {
        public PesquisarAluno()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = TextBoxCpf.Text;
            EscolaController ec = new EscolaController();
            Escola escola = new Escola();

            try
            {
                escola = ec.PesquisarAluno(cpf);
                if (escola == null)
                {
                    MessageBox.Show("Cliente não foi encontrado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NomeAluno.Text = escola.GetNomeAluno();
                    DataNasc.Text = Convert.ToString(escola.GetDataNascimentoAluno());
                    AnoEscolar.Text = escola.GetAnoEscolar();
                    NomeResp.Text = escola.GetNomeResponsavel();
                    Contato.Text = escola.GetContato();
                    Email.Text = escola.GetEmail();
                    button1.Enabled = false;
                    TextBoxCpf.Enabled = false;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NomeAluno.Clear();
            DataNasc.Clear();
            AnoEscolar.Clear();
            NomeResp.Clear();
            Contato.Clear();
            Email.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            TextBoxCpf.Enabled = true;
            TextBoxCpf.Text = "";
        }

        private void TextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    } 
}