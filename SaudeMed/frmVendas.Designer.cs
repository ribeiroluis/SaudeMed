namespace SaudeMed
{
    partial class frmVendas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparItens = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.txEstoque = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.txSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLote = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCodBarras = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.txNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgItensVenda = new System.Windows.Forms.DataGridView();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECOUNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txNumerVenda = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.txDesconto = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimparItens);
            this.groupBox2.Controls.Add(this.btn_Excluir);
            this.groupBox2.Controls.Add(this.txEstoque);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btn_Incluir);
            this.groupBox2.Controls.Add(this.txSubtotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txPrecoUnitario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numQuantidade);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbLote);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txDescricao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txCodBarras);
            this.groupBox2.Location = new System.Drawing.Point(14, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1013, 127);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens";
            // 
            // btnLimparItens
            // 
            this.btnLimparItens.Image = global::SaudeMed.Properties.Resources.clear16x16;
            this.btnLimparItens.Location = new System.Drawing.Point(309, 88);
            this.btnLimparItens.Name = "btnLimparItens";
            this.btnLimparItens.Size = new System.Drawing.Size(42, 25);
            this.btnLimparItens.TabIndex = 10;
            this.btnLimparItens.UseVisualStyleBackColor = true;
            this.btnLimparItens.Click += new System.EventHandler(this.btnLimparItens_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Image = global::SaudeMed.Properties.Resources.cancel;
            this.btn_Excluir.Location = new System.Drawing.Point(260, 89);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(43, 25);
            this.btn_Excluir.TabIndex = 14;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // txEstoque
            // 
            this.txEstoque.Location = new System.Drawing.Point(895, 41);
            this.txEstoque.Name = "txEstoque";
            this.txEstoque.ReadOnly = true;
            this.txEstoque.Size = new System.Drawing.Size(95, 25);
            this.txEstoque.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(892, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Estoque:";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Image = global::SaudeMed.Properties.Resources._1356042729_1;
            this.btn_Incluir.Location = new System.Drawing.Point(211, 89);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(43, 25);
            this.btn_Incluir.TabIndex = 11;
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // txSubtotal
            // 
            this.txSubtotal.Location = new System.Drawing.Point(103, 89);
            this.txSubtotal.Name = "txSubtotal";
            this.txSubtotal.ReadOnly = true;
            this.txSubtotal.Size = new System.Drawing.Size(88, 25);
            this.txSubtotal.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Subtotal:";
            // 
            // txPrecoUnitario
            // 
            this.txPrecoUnitario.Location = new System.Drawing.Point(6, 89);
            this.txPrecoUnitario.Name = "txPrecoUnitario";
            this.txPrecoUnitario.ReadOnly = true;
            this.txPrecoUnitario.Size = new System.Drawing.Size(88, 25);
            this.txPrecoUnitario.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Preço Unit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(795, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Qtd:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(798, 41);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.ReadOnly = true;
            this.numQuantidade.Size = new System.Drawing.Size(69, 25);
            this.numQuantidade.TabIndex = 6;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged);
            this.numQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numQuantidade_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lote:";
            // 
            // cbLote
            // 
            this.cbLote.Enabled = false;
            this.cbLote.FormattingEnabled = true;
            this.cbLote.Location = new System.Drawing.Point(675, 41);
            this.cbLote.Name = "cbLote";
            this.cbLote.Size = new System.Drawing.Size(108, 25);
            this.cbLote.TabIndex = 4;
            this.cbLote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbLote_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Descrição:";
            // 
            // txDescricao
            // 
            this.txDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txDescricao.Location = new System.Drawing.Point(123, 41);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.ReadOnly = true;
            this.txDescricao.Size = new System.Drawing.Size(546, 25);
            this.txDescricao.TabIndex = 2;
            this.txDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDescricao_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cod. Barras:";
            // 
            // txCodBarras
            // 
            this.txCodBarras.Location = new System.Drawing.Point(6, 41);
            this.txCodBarras.Name = "txCodBarras";
            this.txCodBarras.ReadOnly = true;
            this.txCodBarras.Size = new System.Drawing.Size(111, 25);
            this.txCodBarras.TabIndex = 0;
            this.txCodBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodBarras_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txIdCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txTelefoneFixo);
            this.groupBox1.Controls.Add(this.txNomeCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txTelefoneCelular);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SaudeMed.Properties.Resources.clear16x16;
            this.btnLimpar.Location = new System.Drawing.Point(781, 42);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(42, 25);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(327, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Criar novo?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txIdCliente
            // 
            this.txIdCliente.Enabled = false;
            this.txIdCliente.Location = new System.Drawing.Point(6, 43);
            this.txIdCliente.Name = "txIdCliente";
            this.txIdCliente.ReadOnly = true;
            this.txIdCliente.Size = new System.Drawing.Size(43, 25);
            this.txIdCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone fixo:";
            // 
            // txTelefoneFixo
            // 
            this.txTelefoneFixo.Location = new System.Drawing.Point(67, 43);
            this.txTelefoneFixo.Mask = "0000-0000";
            this.txTelefoneFixo.Name = "txTelefoneFixo";
            this.txTelefoneFixo.Size = new System.Drawing.Size(86, 25);
            this.txTelefoneFixo.TabIndex = 3;
            this.txTelefoneFixo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefoneFixo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefoneFixo_KeyDown);
            // 
            // txNomeCliente
            // 
            this.txNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNomeCliente.Location = new System.Drawing.Point(274, 43);
            this.txNomeCliente.Name = "txNomeCliente";
            this.txNomeCliente.ReadOnly = true;
            this.txNomeCliente.Size = new System.Drawing.Size(489, 25);
            this.txNomeCliente.TabIndex = 7;
            this.txNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNomeCliente_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone celular:";
            // 
            // txTelefoneCelular
            // 
            this.txTelefoneCelular.Location = new System.Drawing.Point(168, 43);
            this.txTelefoneCelular.Mask = "0000-0000";
            this.txTelefoneCelular.Name = "txTelefoneCelular";
            this.txTelefoneCelular.ReadOnly = true;
            this.txTelefoneCelular.Size = new System.Drawing.Size(86, 25);
            this.txTelefoneCelular.TabIndex = 5;
            this.txTelefoneCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefoneCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefoneCelular_KeyDown_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgItensVenda);
            this.groupBox3.Location = new System.Drawing.Point(14, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 331);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medicamentos";
            // 
            // dtgItensVenda
            // 
            this.dtgItensVenda.AllowUserToAddRows = false;
            this.dtgItensVenda.AllowUserToDeleteRows = false;
            this.dtgItensVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM,
            this.DESCRICAO,
            this.LOTE,
            this.QUANTIDADE,
            this.PRECOUNITARIO,
            this.SUBTOTAL});
            this.dtgItensVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgItensVenda.Location = new System.Drawing.Point(3, 21);
            this.dtgItensVenda.Name = "dtgItensVenda";
            this.dtgItensVenda.ReadOnly = true;
            this.dtgItensVenda.Size = new System.Drawing.Size(1007, 307);
            this.dtgItensVenda.TabIndex = 0;
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "Item";
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            this.ITEM.Width = 58;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "Descrição medicamento";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 158;
            // 
            // LOTE
            // 
            this.LOTE.HeaderText = "Lote";
            this.LOTE.Name = "LOTE";
            this.LOTE.ReadOnly = true;
            this.LOTE.Width = 58;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 101;
            // 
            // PRECOUNITARIO
            // 
            this.PRECOUNITARIO.HeaderText = "Preço Unitário";
            this.PRECOUNITARIO.Name = "PRECOUNITARIO";
            this.PRECOUNITARIO.ReadOnly = true;
            this.PRECOUNITARIO.Width = 106;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "Subtotal";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            this.SUBTOTAL.Width = 81;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(936, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "VENDA nº:";
            // 
            // txNumerVenda
            // 
            this.txNumerVenda.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumerVenda.ForeColor = System.Drawing.Color.Red;
            this.txNumerVenda.BackColor = System.Drawing.Color.White;
            this.txNumerVenda.Location = new System.Drawing.Point(877, 45);
            this.txNumerVenda.Multiline = true;
            this.txNumerVenda.Name = "txNumerVenda";
            this.txNumerVenda.ReadOnly = true;
            this.txNumerVenda.Size = new System.Drawing.Size(150, 50);
            this.txNumerVenda.TabIndex = 12;
            this.txNumerVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(105, 567);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(90, 29);
            this.textBox4.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 570);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "SUBTOTAL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(208, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "DESCONTO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(445, 570);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "TOTAL:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(511, 567);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(90, 29);
            this.textBox6.TabIndex = 18;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Image = global::SaudeMed.Properties.Resources.sair;
            this.btn_Sair.Location = new System.Drawing.Point(874, 573);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(150, 29);
            this.btn_Sair.TabIndex = 11;
            this.btn_Sair.Text = "Sair/Cancelar";
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // txDesconto
            // 
            this.txDesconto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDesconto.ForeColor = System.Drawing.Color.Red;
            this.txDesconto.Location = new System.Drawing.Point(323, 567);
            this.txDesconto.Name = "txDesconto";
            this.txDesconto.ReadOnly = true;
            this.txDesconto.Size = new System.Drawing.Size(90, 29);
            this.txDesconto.TabIndex = 19;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(303, 573);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(14, 17);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "?";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 608);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.txDesconto);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txNumerVenda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txTelefoneFixo;
        private System.Windows.Forms.TextBox txNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txTelefoneCelular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCodBarras;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.TextBox txSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txPrecoUnitario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txNumerVenda;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.TextBox txEstoque;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.DataGridView dtgItensVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECOUNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.Button btnLimparItens;
        private System.Windows.Forms.TextBox txDesconto;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}