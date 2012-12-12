namespace SaudeMed
{
    partial class frmProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txIdProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txDescontoMaximo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txPrecoVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txCodigoBarras = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateValidade = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txLote = new System.Windows.Forms.TextBox();
            this.txIdItemProtudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txIdProduto
            // 
            this.txIdProduto.Location = new System.Drawing.Point(6, 44);
            this.txIdProduto.Name = "txIdProduto";
            this.txIdProduto.ReadOnly = true;
            this.txIdProduto.Size = new System.Drawing.Size(40, 25);
            this.txIdProduto.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txDescontoMaximo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txPrecoVenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txCodigoBarras);
            this.groupBox1.Controls.Add(this.txIdProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos Descrição";
            // 
            // txDescontoMaximo
            // 
            this.txDescontoMaximo.Location = new System.Drawing.Point(260, 102);
            this.txDescontoMaximo.Name = "txDescontoMaximo";
            this.txDescontoMaximo.Size = new System.Drawing.Size(116, 25);
            this.txDescontoMaximo.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Desconto máximo:";
            // 
            // txPrecoVenda
            // 
            this.txPrecoVenda.Location = new System.Drawing.Point(133, 102);
            this.txPrecoVenda.Name = "txPrecoVenda";
            this.txPrecoVenda.Size = new System.Drawing.Size(93, 25);
            this.txPrecoVenda.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Preço Venda:";
            // 
            // txCompra
            // 
            this.txCompra.Location = new System.Drawing.Point(6, 102);
            this.txCompra.Name = "txCompra";
            this.txCompra.Size = new System.Drawing.Size(93, 25);
            this.txCompra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição Detalhada:";
            // 
            // txDescricao
            // 
            this.txDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txDescricao.Location = new System.Drawing.Point(188, 44);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(592, 25);
            this.txDescricao.TabIndex = 4;
            this.txDescricao.Leave += new System.EventHandler(this.txDescricao_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de barras:";
            // 
            // txCodigoBarras
            // 
            this.txCodigoBarras.Location = new System.Drawing.Point(52, 44);
            this.txCodigoBarras.Name = "txCodigoBarras";
            this.txCodigoBarras.Size = new System.Drawing.Size(121, 25);
            this.txCodigoBarras.TabIndex = 2;
            this.txCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCodigoBarras_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txQuantidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DateValidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txLote);
            this.groupBox2.Controls.Add(this.txIdItemProtudo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamento Item";
            // 
            // txQuantidade
            // 
            this.txQuantidade.Location = new System.Drawing.Point(487, 44);
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.Size = new System.Drawing.Size(112, 25);
            this.txQuantidade.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Validade:";
            // 
            // DateValidade
            // 
            this.DateValidade.Location = new System.Drawing.Point(188, 44);
            this.DateValidade.Name = "DateValidade";
            this.DateValidade.Size = new System.Drawing.Size(277, 25);
            this.DateValidade.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lote:";
            // 
            // txLote
            // 
            this.txLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txLote.Location = new System.Drawing.Point(61, 44);
            this.txLote.Name = "txLote";
            this.txLote.Size = new System.Drawing.Size(112, 25);
            this.txLote.TabIndex = 2;
            // 
            // txIdItemProtudo
            // 
            this.txIdItemProtudo.Location = new System.Drawing.Point(6, 44);
            this.txIdItemProtudo.Name = "txIdItemProtudo";
            this.txIdItemProtudo.ReadOnly = true;
            this.txIdItemProtudo.Size = new System.Drawing.Size(40, 25);
            this.txIdItemProtudo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProdutos";
            this.Text = "SaudeMed - Gerenciar Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIdProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCodigoBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateValidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txLote;
        private System.Windows.Forms.TextBox txIdItemProtudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txDescontoMaximo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txPrecoVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txCompra;
        private System.Windows.Forms.Label label4;
    }
}