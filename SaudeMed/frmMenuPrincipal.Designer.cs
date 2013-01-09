namespace SaudeMed
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuGerenciarFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuGerenciarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuGerenciarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFechamentoDia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuQuantItens = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.lbDataHora = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuGerenciarFuncionarios,
            this.SubMenuGerenciarUsuarios,
            this.SubMenuGerenciarProdutos,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // SubMenuGerenciarFuncionarios
            // 
            this.SubMenuGerenciarFuncionarios.Name = "SubMenuGerenciarFuncionarios";
            this.SubMenuGerenciarFuncionarios.Size = new System.Drawing.Size(195, 22);
            this.SubMenuGerenciarFuncionarios.Text = "Gerenciar Funcionários";
            this.SubMenuGerenciarFuncionarios.Click += new System.EventHandler(this.gerenciarFuncionáriosToolStripMenuItem_Click);
            // 
            // SubMenuGerenciarUsuarios
            // 
            this.SubMenuGerenciarUsuarios.Name = "SubMenuGerenciarUsuarios";
            this.SubMenuGerenciarUsuarios.Size = new System.Drawing.Size(195, 22);
            this.SubMenuGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.SubMenuGerenciarUsuarios.Click += new System.EventHandler(this.gerenciarUsuáriosToolStripMenuItem_Click);
            // 
            // SubMenuGerenciarProdutos
            // 
            this.SubMenuGerenciarProdutos.Name = "SubMenuGerenciarProdutos";
            this.SubMenuGerenciarProdutos.Size = new System.Drawing.Size(195, 22);
            this.SubMenuGerenciarProdutos.Text = "Gerenciar Produtos";
            this.SubMenuGerenciarProdutos.Click += new System.EventHandler(this.SubMenuGerenciarProdutos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuFechamentoDia,
            this.SubMenuQuantItens});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // SubMenuFechamentoDia
            // 
            this.SubMenuFechamentoDia.Name = "SubMenuFechamentoDia";
            this.SubMenuFechamentoDia.Size = new System.Drawing.Size(180, 22);
            this.SubMenuFechamentoDia.Text = "Fechamento do dia";
            // 
            // SubMenuQuantItens
            // 
            this.SubMenuQuantItens.Name = "SubMenuQuantItens";
            this.SubMenuQuantItens.Size = new System.Drawing.Size(180, 22);
            this.SubMenuQuantItens.Text = "Quantidade de Itens";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(12, 535);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(62, 17);
            this.lbNomeUsuario.TabIndex = 1;
            this.lbNomeUsuario.Text = "Olá ?????";
            // 
            // lbDataHora
            // 
            this.lbDataHora.AutoSize = true;
            this.lbDataHora.Location = new System.Drawing.Point(476, 535);
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(62, 17);
            this.lbDataHora.TabIndex = 2;
            this.lbDataHora.Text = "Olá ?????";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaudeMed.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbDataHora);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaudeMed - \"De mãos dadas com a saúde\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubMenuGerenciarFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem SubMenuGerenciarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem SubMenuGerenciarProdutos;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFechamentoDia;
        private System.Windows.Forms.ToolStripMenuItem SubMenuQuantItens;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.Label lbDataHora;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}