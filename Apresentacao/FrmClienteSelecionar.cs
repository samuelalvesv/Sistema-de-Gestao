using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            InitializeComponent();

            //Não gerar colunas automaticamente
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void AtualizarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            ClienteCollection clienteCollection = new ClienteCollection();

            clienteCollection = clienteNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = clienteCollection;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Verificar se uma linha foi selecionada
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente foi selecionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmação de exclusão
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                return;
            }

            //Selecionar cliente
            Cliente clienteSelecionado = new Cliente();
            clienteSelecionado = dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente;

            //Exclusão do cliente
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            string retorno = clienteNegocios.Excluir(clienteSelecionado);

            try
            {
                int idClienteExcluido = Convert.ToInt32(retorno);

                MessageBox.Show("Cliente excluído com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir, detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            //Atualizar Grid
            AtualizarGrid();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            //Instanciar formulárop de cadastro
            frmClienteCadastrar frmClienteCadastrar = new frmClienteCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmClienteCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes) AtualizarGrid();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //Verificar se uma linha foi selecionada
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente foi selecionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Selecionar cliente
            Cliente clienteSelecionado = new Cliente();
            clienteSelecionado = dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente;

            //Instanciar formulário de cadastro
            frmClienteCadastrar frmClienteCadastrar = new frmClienteCadastrar(AcaoNaTela.Alterar, clienteSelecionado);
            DialogResult dialogResult = frmClienteCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes) AtualizarGrid();

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //Verificar se uma linha foi selecionada
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente foi selecionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Selecionar cliente
            Cliente clienteSelecionado = new Cliente();
            clienteSelecionado = dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Cliente;

            //Instanciar formulárop de cadastro
            frmClienteCadastrar frmClienteCadastrar = new frmClienteCadastrar(AcaoNaTela.Consultar, clienteSelecionado);
            frmClienteCadastrar.ShowDialog();
        }
    }
}
