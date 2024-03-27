using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class frmClienteCadastrar : Form
    {

        AcaoNaTela acaoNaTelaSelecionado;

        //Construtor
        public frmClienteCadastrar(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            InitializeComponent();

            acaoNaTelaSelecionado = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //Mudar texto da janela
                Text = "Inserir Cliente";
            }
                
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //Mudar texto da janela
                Text = "Alterar Cliente";
                
                //Recuperar dados do cliente ao clicar em editar
                textBoxCodigo.Text = cliente.IdCliente.ToString();
                textBoxNome.Text = cliente.Nome;
                dateTimePickerNascimento.Text = cliente.DataNascimento.ToString();

                if (cliente.Sexo == true) radioButtonMasculino.Checked = true;
                else radioButtonFeminino.Checked = true;
                
                textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();
            }                

            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //Mudar texto da janela
                Text = "Consultar Cliente";

                //Recuperar dados do cliente e desabilitar alterações, ao clicar em consultar
                textBoxCodigo.Text = cliente.IdCliente.ToString();

                textBoxNome.Text = cliente.Nome;
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;

                dateTimePickerNascimento.Text = cliente.DataNascimento.ToString();
                dateTimePickerNascimento.Enabled = false;

                if (cliente.Sexo == true) radioButtonMasculino.Checked = true;
                else radioButtonFeminino.Checked = true;
                radioButtonMasculino.Enabled = false;
                radioButtonFeminino.Enabled = false;

                textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();
                textBoxLimiteCompra.ReadOnly = true;
                textBoxLimiteCompra.TabStop = false;

                //Deixar botão salvar invisivel, mudar texto do botão cancelar para fechar, e colocar em foco
                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";
                buttonCancelar.Focus();
            }                
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            switch (acaoNaTelaSelecionado)
            {
                case AcaoNaTela.Inserir:
                    try
                    {
                        //Receber valores no cliente
                        Cliente cliente = new Cliente();
                        cliente.Nome = textBoxNome.Text;
                        cliente.DataNascimento = dateTimePickerNascimento.Value;
                        if (radioButtonMasculino.Checked == true) cliente.Sexo = true;
                        else if (radioButtonFeminino.Checked == true) cliente.Sexo = false;
                        cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                        //Inserir cliente na camada de negocios
                        ClienteNegocios clienteNegocios = new ClienteNegocios();
                        string retorno = clienteNegocios.Inserir(cliente);

                        //Teste para saber se foi cadastrado
                        Convert.ToInt32(retorno);
                        MessageBox.Show($"Cliente {cliente.Nome} cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        DialogResult = DialogResult.Yes;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Erro ao inserir cliente, detalhes: {exception}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                        throw;
                    }
                    break;
                case AcaoNaTela.Alterar:
                    try
                    {
                        //Receber valores no cliente
                        Cliente cliente = new Cliente();
                        cliente.IdCliente = Convert.ToInt32(textBoxCodigo.Text);
                        cliente.Nome = textBoxNome.Text;
                        cliente.DataNascimento = dateTimePickerNascimento.Value;
                        if (radioButtonMasculino.Checked == true) cliente.Sexo = true;
                        else if (radioButtonFeminino.Checked == true) cliente.Sexo = false;
                        cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                        //Inserir cliente na camada de negocios
                        ClienteNegocios clienteNegocios = new ClienteNegocios();
                        string retorno = clienteNegocios.Alterar(cliente);

                        //Teste para saber se foi cadastrado
                        Convert.ToInt32(retorno);
                        MessageBox.Show($"Cliente {cliente.Nome} editado com sucesso.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult = DialogResult.Yes;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Erro ao Editar cliente, detalhes: {exception}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                        throw;
                    }
                    break;
                case AcaoNaTela.Excluir:

                    break;
                case AcaoNaTela.Consultar:

                    break;
                default:
                    break;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
