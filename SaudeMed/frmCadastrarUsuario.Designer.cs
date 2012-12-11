namespace SaudeMed
{
    partial class frmCadastrarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbControleTotal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txIDLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_fucionario = new System.Windows.Forms.ComboBox();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSAUDEMEDDataSet = new SaudeMed.BDSAUDEMEDDataSet();
            this.fUNCIONARIOTableAdapter = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.FUNCIONARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // txLogin
            // 
            this.txLogin.Location = new System.Drawing.Point(123, 93);
            this.txLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(327, 25);
            this.txLogin.TabIndex = 3;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(123, 126);
            this.txSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(193, 25);
            this.txSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // txConfirmarSenha
            // 
            this.txConfirmarSenha.Location = new System.Drawing.Point(123, 159);
            this.txConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txConfirmarSenha.Name = "txConfirmarSenha";
            this.txConfirmarSenha.PasswordChar = '*';
            this.txConfirmarSenha.Size = new System.Drawing.Size(193, 25);
            this.txConfirmarSenha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar Senha:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::SaudeMed.Properties.Resources.confirmar1;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(162, 192);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 30);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SaudeMed.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(269, 192);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbControleTotal
            // 
            this.cbControleTotal.DisplayMember = "IDFUNCIONARIO";
            this.cbControleTotal.FormattingEnabled = true;
            this.cbControleTotal.Items.AddRange(new object[] {
            "NAO",
            "SIM"});
            this.cbControleTotal.Location = new System.Drawing.Point(123, 60);
            this.cbControleTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbControleTotal.Name = "cbControleTotal";
            this.cbControleTotal.Size = new System.Drawing.Size(193, 25);
            this.cbControleTotal.TabIndex = 2;
            this.cbControleTotal.ValueMember = "IDFUNCIONARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Controle total:";
            // 
            // txIDLogin
            // 
            this.txIDLogin.Location = new System.Drawing.Point(56, 25);
            this.txIDLogin.Name = "txIDLogin";
            this.txIDLogin.ReadOnly = true;
            this.txIDLogin.Size = new System.Drawing.Size(34, 25);
            this.txIDLogin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Funcionário:";
            // 
            // cb_fucionario
            // 
            this.cb_fucionario.DataSource = this.fUNCIONARIOBindingSource;
            this.cb_fucionario.DisplayMember = "NOME";
            this.cb_fucionario.FormattingEnabled = true;
            this.cb_fucionario.Location = new System.Drawing.Point(204, 25);
            this.cb_fucionario.Name = "cb_fucionario";
            this.cb_fucionario.Size = new System.Drawing.Size(246, 25);
            this.cb_fucionario.TabIndex = 14;
            this.cb_fucionario.ValueMember = "IDFUNCIONARIO";
            this.cb_fucionario.SelectedIndexChanged += new System.EventHandler(this.cb_fucionario_SelectedIndexChanged);
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.bDSAUDEMEDDataSet;
            // 
            // bDSAUDEMEDDataSet
            // 
            this.bDSAUDEMEDDataSet.DataSetName = "BDSAUDEMEDDataSet";
            this.bDSAUDEMEDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 407);
            this.Controls.Add(this.cb_fucionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txIDLogin);
            this.Controls.Add(this.cbControleTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txConfirmarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaudeMed - Gerenciar Usuario";
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txConfirmarSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbControleTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txIDLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_fucionario;
        private BDSAUDEMEDDataSet bDSAUDEMEDDataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private BDSAUDEMEDDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
    }
}