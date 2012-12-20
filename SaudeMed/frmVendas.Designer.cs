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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.txNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.txCodBarras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txCodBarras);
            this.groupBox2.Location = new System.Drawing.Point(14, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venda";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(874, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
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
            this.txNomeCliente.Enabled = false;
            this.txNomeCliente.Location = new System.Drawing.Point(274, 43);
            this.txNomeCliente.Name = "txNomeCliente";
            this.txNomeCliente.ReadOnly = true;
            this.txNomeCliente.Size = new System.Drawing.Size(500, 25);
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
            // txCodBarras
            // 
            this.txCodBarras.Location = new System.Drawing.Point(6, 41);
            this.txCodBarras.Name = "txCodBarras";
            this.txCodBarras.Size = new System.Drawing.Size(144, 25);
            this.txCodBarras.TabIndex = 0;
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
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVendas";
            this.Text = "frmVendas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}