using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoN1.Model;

namespace ProjetoN1.DAO
{
    class EscolaDAO
    {
        conexao con = new conexao();
        SqlCommand cmd = new SqlCommand();

        public void Gravar(Escola escola)
        {
            cmd.CommandText = "insert into Escola(nome_aluno, data_nasc, ano_escolar, nome_responsavel, cpf_responsavel, contato, email) values (@nome_aluno, @data_nasc, @ano_escolar, @nome_responsavel, @cpf_responsavel, @contato, @email)";
            cmd.Parameters.AddWithValue("@nome_aluno", escola.GetNomeAluno());
            cmd.Parameters.AddWithValue("@data_nasc", escola.GetDataNascimentoAluno());
            cmd.Parameters.AddWithValue("@ano_escolar", escola.GetAnoEscolar());
            cmd.Parameters.AddWithValue("@nome_responsavel", escola.GetNomeResponsavel());
            cmd.Parameters.AddWithValue("@cpf_responsavel", escola.GetCpfResponsavel());
            cmd.Parameters.AddWithValue("@contato", escola.GetContato());
            cmd.Parameters.AddWithValue("@email", escola.GetEmail());

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Escola PesquisarAluno(string cpf)
        {
            SqlCommand cmd = new SqlCommand();
            Escola escola = new Escola();
            cmd.CommandText = " select * from Escola where cpf_responsavel = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader dr;

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    escola.SetNomeAluno(dr.GetString(1));
                    escola.SetDataNascimentoAluno(dr.GetDateTime(2));
                    escola.SetAnoEscolar(dr.GetString(3));
                    escola.SetNomeResponsavel(dr.GetString(4));
                    escola.SetCpfResponsavel(dr.GetString(5));
                    escola.SetContato(dr.GetString(6));
                    escola.SetEmail(dr.GetString(7));
                    return escola;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
