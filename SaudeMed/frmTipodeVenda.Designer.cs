namespace SaudeMed
{
    partial class frmTipodeVenda
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
            this.fORMAPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSAUDEMEDDataSet = new SaudeMed.BDSAUDEMEDDataSet();
            this.fORMAPAGAMENTOTableAdapter = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.FORMAPAGAMENTOTableAdapter();
            this.lbParcelas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txPontodeReferencia = new System.Windows.Forms.TextBox();
            this.txValorVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipodeVenda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParcelas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormadePagamento = new System.Windows.Forms.ComboBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSAUDEMEDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.fUNCIONARIOTableAdapter = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.FUNCIONARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fORMAPAGAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fORMAPAGAMENTOBindingSource
            // 
            this.fORMAPAGAMENTOBindingSource.DataMember = "FORMAPAGAMENTO";
            this.fORMAPAGAMENTOBindingSource.DataSource = this.bDSAUDEMEDDataSet;
            // 
            // bDSAUDEMEDDataSet
            // 
            this.bDSAUDEMEDDataSet.DataSetName = "BDSAUDEMEDDataSet";
            this.bDSAUDEMEDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORMAPAGAMENTOTableAdapter
            // 
            this.fORMAPAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // lbParcelas
            // 
            this.lbParcelas.AutoSize = true;
            this.lbParcelas.Location = new System.Drawing.Point(320, 46);
            this.lbParcelas.Name = "lbParcelas";
            this.lbParcelas.Size = new System.Drawing.Size(75, 17);
            this.lbParcelas.TabIndex = 11;
            this.lbParcelas.Text = "N x R$ 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ponto de referência:";
            this.label5.Visible = false;
            // 
            // txPontodeReferencia
            // 
            this.txPontodeReferencia.Location = new System.Drawing.Point(160, 178);
            this.txPontodeReferencia.Multiline = true;
            this.txPontodeReferencia.Name = "txPontodeReferencia";
            this.txPontodeReferencia.Size = new System.Drawing.Size(319, 81);
            this.txPontodeReferencia.TabIndex = 4;
            this.txPontodeReferencia.Visible = false;
            // 
            // txValorVenda
            // 
            this.txValorVenda.Enabled = false;
            this.txValorVenda.Location = new System.Drawing.Point(160, 43);
            this.txValorVenda.Name = "txValorVenda";
            this.txValorVenda.ReadOnly = true;
            this.txValorVenda.Size = new System.Drawing.Size(153, 25);
            this.txValorVenda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor venda:";
            // 
            // cbTipodeVenda
            // 
            this.cbTipodeVenda.FormattingEnabled = true;
            this.cbTipodeVenda.Items.AddRange(new object[] {
            "BALCAO",
            "VIAGEM"});
            this.cbTipodeVenda.Location = new System.Drawing.Point(160, 74);
            this.cbTipodeVenda.Name = "cbTipodeVenda";
            this.cbTipodeVenda.Size = new System.Drawing.Size(154, 25);
            this.cbTipodeVenda.TabIndex = 0;
            this.cbTipodeVenda.TextChanged += new System.EventHandler(this.cbTipodeVenda_TextChanged);
            this.cbTipodeVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipodeVenda_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Venda:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::SaudeMed.Properties.Resources._1357779861_printer;
            this.btnImprimir.Location = new System.Drawing.Point(180, 278);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(134, 29);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "F10 - Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parcelas:";
            this.label2.Visible = false;
            // 
            // cbParcelas
            // 
            this.cbParcelas.FormattingEnabled = true;
            this.cbParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbParcelas.Location = new System.Drawing.Point(385, 105);
            this.cbParcelas.Name = "cbParcelas";
            this.cbParcelas.Size = new System.Drawing.Size(94, 25);
            this.cbParcelas.TabIndex = 2;
            this.cbParcelas.Visible = false;
            this.cbParcelas.TextChanged += new System.EventHandler(this.cbParcelas_TextChanged);
            this.cbParcelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbParcelas_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // cbFormadePagamento
            // 
            this.cbFormadePagamento.DataSource = this.fORMAPAGAMENTOBindingSource;
            this.cbFormadePagamento.DisplayMember = "DESCRICAO";
            this.cbFormadePagamento.FormattingEnabled = true;
            this.cbFormadePagamento.Location = new System.Drawing.Point(160, 105);
            this.cbFormadePagamento.Name = "cbFormadePagamento";
            this.cbFormadePagamento.Size = new System.Drawing.Size(154, 25);
            this.cbFormadePagamento.TabIndex = 1;
            this.cbFormadePagamento.ValueMember = "IDTIPOPAGAMENTO";
            this.cbFormadePagamento.SelectedValueChanged += new System.EventHandler(this.FormadePagamento_SelectedValueChanged);
            this.cbFormadePagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFormadePagamento_KeyDown);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DataSource = this.fUNCIONARIOBindingSource;
            this.cbFuncionario.DisplayMember = "NOME";
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(160, 136);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(154, 25);
            this.cbFuncionario.TabIndex = 3;
            this.cbFuncionario.ValueMember = "IDFUNCIONARIO";
            this.cbFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFuncionario_KeyDown);
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.bDSAUDEMEDDataSetBindingSource;
            // 
            // bDSAUDEMEDDataSetBindingSource
            // 
            this.bDSAUDEMEDDataSetBindingSource.DataSource = this.bDSAUDEMEDDataSet;
            this.bDSAUDEMEDDataSetBindingSource.Position = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Funcionário:";
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmTipodeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 351);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.lbParcelas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPontodeReferencia);
            this.Controls.Add(this.txValorVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipodeVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormadePagamento);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipodeVenda";
            this.Text = "Saude Med - TipoVenda";
            this.Load += new System.EventHandler(this.frmTipodeVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTipodeVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fORMAPAGAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormadePagamento;
        private System.Windows.Forms.Label label1;
        private BDSAUDEMEDDataSet bDSAUDEMEDDataSet;
        private System.Windows.Forms.BindingSource fORMAPAGAMENTOBindingSource;
        private BDSAUDEMEDDataSetTableAdapters.FORMAPAGAMENTOTableAdapter fORMAPAGAMENTOTableAdapter;
        private System.Windows.Forms.ComboBox cbParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipodeVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txValorVenda;
        private System.Windows.Forms.TextBox txPontodeReferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbParcelas;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.BindingSource bDSAUDEMEDDataSetBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private BDSAUDEMEDDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
    }
}