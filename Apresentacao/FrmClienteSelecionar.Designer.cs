namespace Apresentacao
{
    partial class FrmClienteSelecionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            buttonPesquisa = new Button();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonExcluir = new Button();
            buttonConsultar = new Button();
            buttonFechar = new Button();
            dataGridViewPrincipal = new DataGridView();
            ColIdCliente = new DataGridViewTextBoxColumn();
            ColNome = new DataGridViewTextBoxColumn();
            ColDataNascimento = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            ColLimiteCompra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisa
            // 
            buttonPesquisa.Location = new Point(511, 16);
            buttonPesquisa.Name = "buttonPesquisa";
            buttonPesquisa.Size = new Size(94, 29);
            buttonPesquisa.TabIndex = 2;
            buttonPesquisa.Text = "&Pesquisar";
            buttonPesquisa.UseVisualStyleBackColor = true;
            buttonPesquisa.Click += buttonPesquisa_Click;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(15, 20);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(116, 20);
            labelPesquisa.TabIndex = 0;
            labelPesquisa.Text = "Código / Nome:";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(135, 17);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(360, 27);
            textBoxPesquisa.TabIndex = 1;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInserir.Location = new Point(426, 502);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 4;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAlterar.Location = new Point(536, 502);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 5;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExcluir.Location = new Point(646, 502);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConsultar.Location = new Point(756, 502);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(94, 29);
            buttonConsultar.TabIndex = 7;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonFechar.Location = new Point(866, 502);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(94, 29);
            buttonFechar.TabIndex = 8;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = true;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPrincipal.BackgroundColor = SystemColors.Window;
            dataGridViewPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrincipal.Columns.AddRange(new DataGridViewColumn[] { ColIdCliente, ColNome, ColDataNascimento, colSexo, ColLimiteCompra });
            dataGridViewPrincipal.Location = new Point(17, 65);
            dataGridViewPrincipal.MultiSelect = false;
            dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            dataGridViewPrincipal.RowHeadersWidth = 51;
            dataGridViewPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrincipal.Size = new Size(943, 427);
            dataGridViewPrincipal.TabIndex = 3;
            dataGridViewPrincipal.CellFormatting += dataGridViewPrincipal_CellFormatting;
            // 
            // ColIdCliente
            // 
            ColIdCliente.DataPropertyName = "IdCliente";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            ColIdCliente.DefaultCellStyle = dataGridViewCellStyle2;
            ColIdCliente.HeaderText = "Código";
            ColIdCliente.MinimumWidth = 6;
            ColIdCliente.Name = "ColIdCliente";
            ColIdCliente.ReadOnly = true;
            ColIdCliente.Resizable = DataGridViewTriState.False;
            ColIdCliente.Width = 75;
            // 
            // ColNome
            // 
            ColNome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColNome.DefaultCellStyle = dataGridViewCellStyle3;
            ColNome.HeaderText = "Nome";
            ColNome.MinimumWidth = 6;
            ColNome.Name = "ColNome";
            ColNome.ReadOnly = true;
            ColNome.Resizable = DataGridViewTriState.False;
            ColNome.Width = 300;
            // 
            // ColDataNascimento
            // 
            ColDataNascimento.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            ColDataNascimento.DefaultCellStyle = dataGridViewCellStyle4;
            ColDataNascimento.HeaderText = "Data de Nascimento";
            ColDataNascimento.MinimumWidth = 6;
            ColDataNascimento.Name = "ColDataNascimento";
            ColDataNascimento.ReadOnly = true;
            ColDataNascimento.Resizable = DataGridViewTriState.False;
            ColDataNascimento.Width = 180;
            // 
            // colSexo
            // 
            colSexo.DataPropertyName = "Sexo";
            colSexo.HeaderText = "Sexo";
            colSexo.MinimumWidth = 6;
            colSexo.Name = "colSexo";
            colSexo.Width = 125;
            // 
            // ColLimiteCompra
            // 
            ColLimiteCompra.DataPropertyName = "LimiteCompra";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "R$ 0.00";
            ColLimiteCompra.DefaultCellStyle = dataGridViewCellStyle5;
            ColLimiteCompra.HeaderText = "Limite de Compra";
            ColLimiteCompra.MinimumWidth = 6;
            ColLimiteCompra.Name = "ColLimiteCompra";
            ColLimiteCompra.ReadOnly = true;
            ColLimiteCompra.Resizable = DataGridViewTriState.False;
            ColLimiteCompra.Width = 160;
            // 
            // FrmClienteSelecionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 543);
            Controls.Add(dataGridViewPrincipal);
            Controls.Add(buttonFechar);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonInserir);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(buttonPesquisa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClienteSelecionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisa;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonExcluir;
        private Button buttonConsultar;
        private Button buttonFechar;
        private Button button7;
        private DataGridView dataGridViewPrincipal;
        private DataGridViewTextBoxColumn ColIdCliente;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn ColDataNascimento;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn ColLimiteCompra;
    }
}