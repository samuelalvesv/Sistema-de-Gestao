namespace Apresentacao
{
    partial class frmClienteCadastrar
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
            labelCodigo = new Label();
            labelNome = new Label();
            labelDataNascimento = new Label();
            labelSexo = new Label();
            labelLimiteCompra = new Label();
            textBoxCodigo = new TextBox();
            textBoxNome = new TextBox();
            textBoxLimiteCompra = new TextBox();
            dateTimePickerNascimento = new DateTimePicker();
            radioButtonMasculino = new RadioButton();
            radioButtonFeminino = new RadioButton();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            SuspendLayout();
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(12, 11);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(58, 20);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(112, 11);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(12, 84);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(145, 20);
            labelDataNascimento.TabIndex = 4;
            labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.Location = new Point(216, 84);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(41, 20);
            labelSexo.TabIndex = 6;
            labelSexo.Text = "Sexo";
            // 
            // labelLimiteCompra
            // 
            labelLimiteCompra.AutoSize = true;
            labelLimiteCompra.Location = new Point(469, 84);
            labelLimiteCompra.Name = "labelLimiteCompra";
            labelLimiteCompra.Size = new Size(128, 20);
            labelLimiteCompra.TabIndex = 9;
            labelLimiteCompra.Text = "Limite de Compra";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(12, 34);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.ReadOnly = true;
            textBoxCodigo.Size = new Size(85, 27);
            textBoxCodigo.TabIndex = 1;
            textBoxCodigo.TabStop = false;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(112, 34);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(485, 27);
            textBoxNome.TabIndex = 3;
            // 
            // textBoxLimiteCompra
            // 
            textBoxLimiteCompra.Location = new Point(469, 107);
            textBoxLimiteCompra.Name = "textBoxLimiteCompra";
            textBoxLimiteCompra.Size = new Size(128, 27);
            textBoxLimiteCompra.TabIndex = 10;
            textBoxLimiteCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerNascimento.Location = new Point(12, 107);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(145, 27);
            dateTimePickerNascimento.TabIndex = 5;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Checked = true;
            radioButtonMasculino.Location = new Point(216, 107);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(97, 24);
            radioButtonMasculino.TabIndex = 7;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFeminino
            // 
            radioButtonFeminino.AutoSize = true;
            radioButtonFeminino.Location = new Point(319, 107);
            radioButtonFeminino.Name = "radioButtonFeminino";
            radioButtonFeminino.Size = new Size(91, 24);
            radioButtonFeminino.TabIndex = 8;
            radioButtonFeminino.Text = "Feminino";
            radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(503, 181);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(393, 181);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // frmClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 222);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(radioButtonFeminino);
            Controls.Add(radioButtonMasculino);
            Controls.Add(dateTimePickerNascimento);
            Controls.Add(textBoxLimiteCompra);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxCodigo);
            Controls.Add(labelLimiteCompra);
            Controls.Add(labelSexo);
            Controls.Add(labelDataNascimento);
            Controls.Add(labelNome);
            Controls.Add(labelCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClienteCadastrar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCodigo;
        private Label labelNome;
        private Label labelDataNascimento;
        private Label labelSexo;
        private Label labelLimiteCompra;
        private TextBox textBoxCodigo;
        private TextBox textBoxNome;
        private TextBox textBoxLimiteCompra;
        private DateTimePicker dateTimePickerNascimento;
        private RadioButton radioButtonMasculino;
        private RadioButton radioButtonFeminino;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}