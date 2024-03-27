namespace Apresentacao
{
    partial class FrmMenu
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
            barraStatusPrincipal = new StatusStrip();
            labelVersao = new ToolStripStatusLabel();
            menuPrincipal = new MenuStrip();
            menuCadastro = new ToolStripMenuItem();
            menuCadastroCliente = new ToolStripMenuItem();
            menuSair = new ToolStripMenuItem();
            barraStatusPrincipal.SuspendLayout();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            barraStatusPrincipal.ImageScalingSize = new Size(20, 20);
            barraStatusPrincipal.Items.AddRange(new ToolStripItem[] { labelVersao });
            barraStatusPrincipal.Location = new Point(0, 527);
            barraStatusPrincipal.Name = "barraStatusPrincipal";
            barraStatusPrincipal.Size = new Size(1006, 26);
            barraStatusPrincipal.TabIndex = 1;
            barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            labelVersao.Name = "labelVersao";
            labelVersao.Size = new Size(76, 20);
            labelVersao.Text = "Versão 1.0";
            // 
            // menuPrincipal
            // 
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuCadastro, menuSair });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(1006, 28);
            menuPrincipal.TabIndex = 3;
            menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            menuCadastro.DropDownItems.AddRange(new ToolStripItem[] { menuCadastroCliente });
            menuCadastro.Name = "menuCadastro";
            menuCadastro.Size = new Size(82, 24);
            menuCadastro.Text = "&Cadastro";
            // 
            // menuCadastroCliente
            // 
            menuCadastroCliente.Name = "menuCadastroCliente";
            menuCadastroCliente.Size = new Size(224, 26);
            menuCadastroCliente.Text = "&Cliente";
            menuCadastroCliente.Click += menuCadastroCliente_Click;
            // 
            // menuSair
            // 
            menuSair.Name = "menuSair";
            menuSair.Size = new Size(48, 24);
            menuSair.Text = "&Sair";
            menuSair.Click += menuSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 553);
            Controls.Add(barraStatusPrincipal);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGE - Sistema de Gestão Empresarial - Versão: 1.0";
            WindowState = FormWindowState.Maximized;
            barraStatusPrincipal.ResumeLayout(false);
            barraStatusPrincipal.PerformLayout();
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip barraStatusPrincipal;
        private ToolStripStatusLabel labelVersao;
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem menuCadastroCliente;
        private ToolStripMenuItem menuSair;
    }
}