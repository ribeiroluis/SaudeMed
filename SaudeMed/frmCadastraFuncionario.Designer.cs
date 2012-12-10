namespace SaudeMed
{
    partial class frmCadastraFuncionario
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
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txIdFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.mskTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txIdentidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dateAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txFuncao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txRegistroProfissional = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(51, 88);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 25);
            this.mskCEP.TabIndex = 7;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCEP_KeyPress);
            this.mskCEP.Leave += new System.EventHandler(this.mskCEP_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "CEP:";
            // 
            // txNomeFuncionario
            // 
            this.txNomeFuncionario.Location = new System.Drawing.Point(271, 54);
            this.txNomeFuncionario.Name = "txNomeFuncionario";
            this.txNomeFuncionario.Size = new System.Drawing.Size(478, 25);
            this.txNomeFuncionario.TabIndex = 5;
            this.txNomeFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNomeFuncionario_KeyDown);
            this.txNomeFuncionario.Leave += new System.EventHandler(this.txNomeFuncionario_Leave);
            // 
            // txIdFuncionario
            // 
            this.txIdFuncionario.Location = new System.Drawing.Point(112, 54);
            this.txIdFuncionario.Name = "txIdFuncionario";
            this.txIdFuncionario.ReadOnly = true;
            this.txIdFuncionario.Size = new System.Drawing.Size(100, 25);
            this.txIdFuncionario.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Funcionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Endereço:";
            // 
            // txEndereco
            // 
            this.txEndereco.Location = new System.Drawing.Point(229, 88);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.ReadOnly = true;
            this.txEndereco.Size = new System.Drawing.Size(411, 25);
            this.txEndereco.TabIndex = 19;
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(679, 88);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(70, 25);
            this.txNumero.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nº:";
            // 
            // txComplemento
            // 
            this.txComplemento.Location = new System.Drawing.Point(64, 125);
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.Size = new System.Drawing.Size(87, 25);
            this.txComplemento.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Comp:";
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(209, 125);
            this.txBairro.Name = "txBairro";
            this.txBairro.ReadOnly = true;
            this.txBairro.Size = new System.Drawing.Size(278, 25);
            this.txBairro.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cidade:";
            // 
            // txCidade
            // 
            this.txCidade.Location = new System.Drawing.Point(551, 125);
            this.txCidade.Name = "txCidade";
            this.txCidade.ReadOnly = true;
            this.txCidade.Size = new System.Drawing.Size(198, 25);
            this.txCidade.TabIndex = 21;
            // 
            // mskTelefoneFixo
            // 
            this.mskTelefoneFixo.Location = new System.Drawing.Point(106, 161);
            this.mskTelefoneFixo.Mask = "(00)0000-0000";
            this.mskTelefoneFixo.Name = "mskTelefoneFixo";
            this.mskTelefoneFixo.Size = new System.Drawing.Size(100, 25);
            this.mskTelefoneFixo.TabIndex = 10;
            this.mskTelefoneFixo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Telefone Fixo:";
            // 
            // mskTelefoneCelular
            // 
            this.mskTelefoneCelular.Location = new System.Drawing.Point(323, 161);
            this.mskTelefoneCelular.Mask = "(00)0000-0000";
            this.mskTelefoneCelular.Name = "mskTelefoneCelular";
            this.mskTelefoneCelular.Size = new System.Drawing.Size(100, 25);
            this.mskTelefoneCelular.TabIndex = 11;
            this.mskTelefoneCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Telefone Celular:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(467, 161);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 25);
            this.mskCPF.TabIndex = 12;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "CPF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Identidade:";
            // 
            // txIdentidade
            // 
            this.txIdentidade.Location = new System.Drawing.Point(649, 161);
            this.txIdentidade.Name = "txIdentidade";
            this.txIdentidade.Size = new System.Drawing.Size(100, 25);
            this.txIdentidade.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Data de Nascimento:";
            // 
            // dateDataNascimento
            // 
            this.dateDataNascimento.Location = new System.Drawing.Point(148, 197);
            this.dateDataNascimento.Name = "dateDataNascimento";
            this.dateDataNascimento.Size = new System.Drawing.Size(275, 25);
            this.dateDataNascimento.TabIndex = 14;
            // 
            // dateAdmissao
            // 
            this.dateAdmissao.Location = new System.Drawing.Point(496, 197);
            this.dateAdmissao.Name = "dateAdmissao";
            this.dateAdmissao.Size = new System.Drawing.Size(266, 25);
            this.dateAdmissao.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Admissão:";
            // 
            // txFuncao
            // 
            this.txFuncao.Location = new System.Drawing.Point(70, 237);
            this.txFuncao.Name = "txFuncao";
            this.txFuncao.Size = new System.Drawing.Size(353, 25);
            this.txFuncao.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Função:";
            // 
            // txRegistroProfissional
            // 
            this.txRegistroProfissional.Location = new System.Drawing.Point(566, 237);
            this.txRegistroProfissional.Name = "txRegistroProfissional";
            this.txRegistroProfissional.Size = new System.Drawing.Size(183, 25);
            this.txRegistroProfissional.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(429, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Registro Profissional:";
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDados.Location = new System.Drawing.Point(0, 268);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.Size = new System.Drawing.Size(774, 260);
            this.dtgDados.TabIndex = 38;
            this.dtgDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDados_CellMouseClick);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SaudeMed.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(661, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListar
            // 
            this.btnListar.Image = global::SaudeMed.Properties.Resources.atualizar;
            this.btnListar.Location = new System.Drawing.Point(284, 5);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 36);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Atualizar";
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::SaudeMed.Properties.Resources.cancelar;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(190, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 36);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::SaudeMed.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(96, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 36);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = global::SaudeMed.Properties.Resources.salvar;
            this.btnGravar.Location = new System.Drawing.Point(2, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 36);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmCadastraFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 528);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.txRegistroProfissional);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txFuncao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateAdmissao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateDataNascimento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txIdentidade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskTelefoneCelular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskTelefoneFixo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txComplemento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNomeFuncionario);
            this.Controls.Add(this.txIdFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmCadastraFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaudeMed - Cadastrar Funcionário";
            this.Load += new System.EventHandler(this.frmCadastraFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txIdFuncionario;
        private System.Windows.Forms.TextBox txNomeFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.MaskedTextBox mskTelefoneFixo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txIdentidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateDataNascimento;
        private System.Windows.Forms.DateTimePicker dateAdmissao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txFuncao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txRegistroProfissional;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button btnSair;
    }
}