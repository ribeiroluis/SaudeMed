namespace SaudeMed
{
    partial class frmTelaCliente
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txIdCliente = new System.Windows.Forms.TextBox();
            this.txTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.txNomeCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 229);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(885, 337);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(871, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Sem histórico registrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Cliente:";
            // 
            // txIdCliente
            // 
            this.txIdCliente.Enabled = false;
            this.txIdCliente.Location = new System.Drawing.Point(6, 43);
            this.txIdCliente.Name = "txIdCliente";
            this.txIdCliente.Size = new System.Drawing.Size(62, 25);
            this.txIdCliente.TabIndex = 2;
            // 
            // txTelefoneFixo
            // 
            this.txTelefoneFixo.Location = new System.Drawing.Point(99, 43);
            this.txTelefoneFixo.Mask = "0000-0000";
            this.txTelefoneFixo.Name = "txTelefoneFixo";
            this.txTelefoneFixo.Size = new System.Drawing.Size(86, 25);
            this.txTelefoneFixo.TabIndex = 3;
            this.txTelefoneFixo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefoneFixo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefoneFixo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone fixo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone celular:";
            // 
            // txTelefoneCelular
            // 
            this.txTelefoneCelular.Location = new System.Drawing.Point(227, 43);
            this.txTelefoneCelular.Mask = "0000-0000";
            this.txTelefoneCelular.Name = "txTelefoneCelular";
            this.txTelefoneCelular.Size = new System.Drawing.Size(100, 25);
            this.txTelefoneCelular.TabIndex = 5;
            this.txTelefoneCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txTelefoneCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txTelefoneCelular_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.txCidade);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.txCEP);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txBairro);
            this.groupBox1.Controls.Add(this.txCPF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txIdCliente);
            this.groupBox1.Controls.Add(this.txComplemento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txTelefoneFixo);
            this.groupBox1.Controls.Add(this.txEndereco);
            this.groupBox1.Controls.Add(this.txNomeCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txTelefoneCelular);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(165, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 17);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SaudeMed.Properties.Resources.clear;
            this.btnLimpar.Location = new System.Drawing.Point(753, 132);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 36);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txCidade
            // 
            this.txCidade.Location = new System.Drawing.Point(269, 139);
            this.txCidade.Name = "txCidade";
            this.txCidade.ReadOnly = true;
            this.txCidade.Size = new System.Drawing.Size(198, 25);
            this.txCidade.TabIndex = 34;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::SaudeMed.Properties.Resources.cancelar;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(659, 132);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 36);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txCEP
            // 
            this.txCEP.Enabled = false;
            this.txCEP.Location = new System.Drawing.Point(130, 91);
            this.txCEP.Mask = "00000-000";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(100, 25);
            this.txCEP.TabIndex = 35;
            this.txCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCEP_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::SaudeMed.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(565, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 36);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = global::SaudeMed.Properties.Resources.salvar;
            this.btnGravar.Location = new System.Drawing.Point(471, 132);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 36);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "CEP:";
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(6, 139);
            this.txBairro.Name = "txBairro";
            this.txBairro.ReadOnly = true;
            this.txBairro.Size = new System.Drawing.Size(243, 25);
            this.txBairro.TabIndex = 33;
            // 
            // txCPF
            // 
            this.txCPF.Enabled = false;
            this.txCPF.Location = new System.Drawing.Point(6, 91);
            this.txCPF.Mask = "000,000,000-00";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(100, 25);
            this.txCPF.TabIndex = 33;
            this.txCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCPF_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bairro:";
            // 
            // txComplemento
            // 
            this.txComplemento.Enabled = false;
            this.txComplemento.Location = new System.Drawing.Point(747, 91);
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.Size = new System.Drawing.Size(120, 25);
            this.txComplemento.TabIndex = 31;
            this.txComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txComplemento_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Comp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "CPF:";
            // 
            // txNumero
            // 
            this.txNumero.Enabled = false;
            this.txNumero.Location = new System.Drawing.Point(659, 91);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(70, 25);
            this.txNumero.TabIndex = 30;
            this.txNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNumero_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nº:";
            // 
            // txEndereco
            // 
            this.txEndereco.Location = new System.Drawing.Point(239, 91);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.ReadOnly = true;
            this.txEndereco.Size = new System.Drawing.Size(411, 25);
            this.txEndereco.TabIndex = 32;
            // 
            // txNomeCliente
            // 
            this.txNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txNomeCliente.Enabled = false;
            this.txNomeCliente.Location = new System.Drawing.Point(354, 43);
            this.txNomeCliente.Name = "txNomeCliente";
            this.txNomeCliente.Size = new System.Drawing.Size(513, 25);
            this.txNomeCliente.TabIndex = 7;
            this.txNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNomeCliente_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome:";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SaudeMed.Properties.Resources._out;
            this.btnSair.Location = new System.Drawing.Point(811, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 32);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "F4 - Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 578);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabControl);
            this.KeyPreview = true;
            this.Name = "frmTelaCliente";
            this.Text = "SAUDEMED - CLIENTES";
            this.Load += new System.EventHandler(this.frmTelaVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaCliente_KeyDown);
            this.TabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIdCliente;
        private System.Windows.Forms.MaskedTextBox txTelefoneFixo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txTelefoneCelular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNomeCliente;
        private System.Windows.Forms.MaskedTextBox txCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSair;

    }
}