using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir (Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("LimiteCompra", cliente.LimiteCompra);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar (Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir (Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.IdCliente);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ClienteCollection ConsultarPorNome (string nome)
        {
            try
            {
                ClienteCollection clienteCollection = new ObjetoTransferencia.ClienteCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                DataTable dataTableCliente =  acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                foreach (DataRow row in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();
                    
                    cliente.IdCliente = Convert.ToInt32(row["IdCliente"]);
                    cliente.Nome = Convert.ToString(row["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(row["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(row["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(row["LimiteCompra"]);
                    
                    clienteCollection.Add(cliente);
                }

                return clienteCollection;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o cliente por nome. Detalhes: " + exception.Message);
            }
        }

        public ClienteCollection ConsultarPorId(int IdCliente)
        {
            try
            {
                ClienteCollection clienteCollection = new ObjetoTransferencia.ClienteCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", IdCliente);
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorId");

                foreach (DataRow row in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(row["IdCliente"]);
                    cliente.Nome = Convert.ToString(row["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(row["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(row["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(row["LimiteCompra"]);

                    clienteCollection.Add(cliente);
                }

                return clienteCollection;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o cliente por código. Detalhes: " + exception.Message);
            }
        }
    }
}
