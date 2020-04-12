using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoN1.Model;
using ProjetoN1.DAO;

namespace ProjetoN1.Controller
{
    class EscolaController
    {
        EscolaDAO escolaDao = new EscolaDAO();

        public void Gravar(string NomeAluno, string NomeResponsavel, string CpfResponsavel, string AnoEscolar, DateTime DataNascimentoAluno, string Contato, string Email)
        {
            Escola escola = new Escola();
            try
            {
                escola.SetNomeAluno(NomeAluno);
                escola.SetNomeResponsavel(NomeResponsavel);
                escola.SetCpfResponsavel(CpfResponsavel);
                escola.SetAnoEscolar(AnoEscolar);
                escola.SetDataNascimentoAluno(DataNascimentoAluno);
                escola.SetContato(Contato);
                escola.SetEmail(Email);
                escolaDao.Gravar(escola);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

            //implementar pesquisar cliente
        }

        public Escola PesquisarAluno(string cpf)
        {
            Escola escola = new Escola();

            try
            {
                escola.SetCpfResponsavel(cpf);
                escola = escolaDao.PesquisarAluno(escola.GetCpfResponsavel());
                return escola;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
