using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoN1.DAO
{
    class conexao
    {
        SqlConnection con = new SqlConnection();

        public conexao()
        {
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Projetos\Faculdade\Banco de Dados\ProjetoN1\ProjetoN1\Escola.mdf; Integrated Security = True";
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message + "Falha de Conexão!");
                }
            }
            return con;
        }

        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Close();
                }
                catch(Exception e)
                {
                    throw new Exception("Falha ao fechar a Conexão" + e.Message);
                }
            }
        }
    }
}
