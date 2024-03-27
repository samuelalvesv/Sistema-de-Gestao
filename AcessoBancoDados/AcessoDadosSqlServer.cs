//Namespace's que contém as classes que manipulam dados
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection("Data Source=LAPTOP-JNG5P2CP\\MSSQLSERVER01; Initial Catalog=SIGE; Integrated Security=SSPI; Persist Security Info=False");
        }

        //Parâmetros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistência - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Criar conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir conexão
                sqlConnection.Open();

                //Comando que vai levar informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocar coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 720; //Em segundos

                //Adicionar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar o comando, ou seja, mandar o comando ir até o banco
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Criar conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir conexão
                sqlConnection.Open();

                //Comando que vai levar informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocar coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 720; //Em segundos

                //Adicionar parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable vazio
                DataTable dataTable = new DataTable();

                 //Mandar comando ir até o banco buscar os dados e o adaptador preencher o DataTable
                 sqlDataAdapter.Fill(dataTable);
                 
                 return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
