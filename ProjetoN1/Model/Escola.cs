using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoN1.Model
{
    class Escola
    {
        private string NomeAluno;
        private string NomeResponsavel;
        private string CpfResponsavel;
        private string AnoEscolar;
        private DateTime DataNascimentoAluno;
        private string Contato;
        private string Email;

        // Getters 
        public string GetNomeAluno()
        {
            return this.NomeAluno;
        }

        public string GetNomeResponsavel()
        {
            return this.NomeResponsavel;
        }

        public string GetCpfResponsavel()
        {
            return this.CpfResponsavel;
        }

        public string GetAnoEscolar()
        {
            return this.AnoEscolar;
        }

        public DateTime GetDataNascimentoAluno()
        {
            return this.DataNascimentoAluno;
        }

        public string GetContato()
        {
            return this.Contato;
        }

        public string GetEmail()
        {
            return this.Email;
        }


        //Setters

        public void SetNomeAluno(string NomeAluno)
        {
            this.NomeAluno = NomeAluno;
        }

        public void SetNomeResponsavel(string NomeResponsavel)
        {
            this.NomeResponsavel = NomeResponsavel;
        }

        public void SetCpfResponsavel(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            String tempCpf;
            String digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                throw new Exception("CPF INVALIDO!");
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            if (cpf.EndsWith(digito))
                this.CpfResponsavel = cpf;
            else
                throw new Exception("CPF INVALIDO!");
        }

        public void SetAnoEscolar(string ano)
        {
            this.AnoEscolar = ano;
        }

        public void SetDataNascimentoAluno(DateTime dataNascimentoAluno)
        {
            if (dataNascimentoAluno <= DateTime.Today)
            {
                this.DataNascimentoAluno = dataNascimentoAluno;
            }
            else
            {
                throw new Exception("DATA DE NASCIMENTO INVÁLIDA!");
            }
        }

        public void SetContato(string contato)
        {
            string modelo = "^[0-9]{2}-([0-9]{8}|[0-9]{9})";
            if(System.Text.RegularExpressions.Regex.IsMatch(contato, modelo)){
                this.Contato = contato;
            }
            else
            {
                throw new Exception("Contato Inválido");
            }
        }

        public void SetEmail(string email)
        {
            string modelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, modelo))
            {
                this.Email = email;
            }
            else
            {
                throw new Exception("EMAIL INVÁLIDO");
            }
        }

       
    }
}
