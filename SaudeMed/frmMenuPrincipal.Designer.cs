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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantidadeDeItensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(794, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarFuncionáriosToolStripMenuItem,
            this.gerenciarUsuáriosToolStripMenuItem,
            this.gerenciarProdutosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // gerenciarFuncionáriosToolStripMenuItem
            // 
            this.gerenciarFuncionáriosToolStripMenuItem.Name = "gerenciarFuncionáriosToolStripMenuItem";
            this.gerenciarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gerenciarFuncionáriosToolStripMenuItem.Text = "Gerenciar Funcionários";
            this.gerenciarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFuncionáriosToolStripMenuItem_Click);
            // 
            // gerenciarUsuáriosToolStripMenuItem
            // 
            this.gerenciarUsuáriosToolStripMenuItem.Name = "gerenciarUsuáriosToolStripMenuItem";
            this.gerenciarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar Usuários";
            this.gerenciarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuáriosToolStripMenuItem_Click);
            // 
            // gerenciarProdutosToolStripMenuItem
            // 
            this.gerenciarProdutosToolStripMenuItem.Name = "gerenciarProdutosToolStripMenuItem";
            this.gerenciarProdutosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gerenciarProdutosToolStripMenuItem.Text = "Gerenciar Produtos";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechamentoDoDiaToolStripMenuItem,
            this.quantidadeDeItensToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // fechamentoDoDiaToolStripMenuItem
            // 
            this.fechamentoDoDiaToolStripMenuItem.Name = "fechamentoDoDiaToolStripMenuItem";
            this.fechamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fechamentoDoDiaToolStripMenuItem.Text = "Fechamento do dia";
            // 
            // quantidadeDeItensToolStripMenuItem
            // 
            this.quantidadeDeItensToolStripMenuItem.Name = "quantidadeDeItensToolStripMenuItem";
            this.quantidadeDeItensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quantidadeDeItensToolStripMenuItem.Text = "Quantidade de Itens";
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
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaudeMed.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(794, 571);
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
        private System.Windows.Forms.ToolStripMenuItem gerenciarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantidadeDeItensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}