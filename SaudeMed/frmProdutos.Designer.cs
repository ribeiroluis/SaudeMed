﻿namespace SaudeMed
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txIdProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txDescontoMaximo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.txPrecoVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txCodigoBarras = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txQuantidade = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DateValidade = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txLote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txIdItemProtudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewTabelaItensProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSAUDEMEDDataSet = new SaudeMed.BDSAUDEMEDDataSet();
            this.viewTabelaItensProdutoTableAdapter = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.ViewTabelaItensProdutoTableAdapter();
            this.tableAdapterManager = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelaItensProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).BeginInit();
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
            this.txIdProduto.Enabled = false;
            this.txIdProduto.Location = new System.Drawing.Point(6, 44);
            this.txIdProduto.Name = "txIdProduto";
            this.txIdProduto.Size = new System.Drawing.Size(40, 25);
            this.txIdProduto.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txDescontoMaximo);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.txPrecoVenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.txCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txCodigoBarras);
            this.groupBox1.Controls.Add(this.txIdProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos Descrição";
            // 
            // txDescontoMaximo
            // 
            this.txDescontoMaximo.Enabled = false;
            this.txDescontoMaximo.Location = new System.Drawing.Point(260, 102);
            this.txDescontoMaximo.Name = "txDescontoMaximo";
            this.txDescontoMaximo.Size = new System.Drawing.Size(116, 25);
            this.txDescontoMaximo.TabIndex = 11;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::SaudeMed.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(493, 95);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 36);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // btnListar
            // 
            this.btnListar.Image = global::SaudeMed.Properties.Resources.clear;
            this.btnListar.Location = new System.Drawing.Point(587, 95);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 36);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Limpar";
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txPrecoVenda
            // 
            this.txPrecoVenda.Location = new System.Drawing.Point(133, 102);
            this.txPrecoVenda.Name = "txPrecoVenda";
            this.txPrecoVenda.Size = new System.Drawing.Size(93, 25);
            this.txPrecoVenda.TabIndex = 9;
            this.txPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPrecoVenda_KeyDown);
            this.txPrecoVenda.Leave += new System.EventHandler(this.txPrecoVenda_Leave);
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
            // btnIncluir
            // 
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Image = global::SaudeMed.Properties.Resources.salvar;
            this.btnIncluir.Location = new System.Drawing.Point(399, 95);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(88, 36);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txCompra
            // 
            this.txCompra.Location = new System.Drawing.Point(6, 102);
            this.txCompra.Name = "txCompra";
            this.txCompra.Size = new System.Drawing.Size(93, 25);
            this.txCompra.TabIndex = 7;
            this.txCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCompra_KeyDown);
            this.txCompra.Leave += new System.EventHandler(this.txCompra_Leave);
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
            this.txDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDescricao_KeyDown);
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
            this.txCodigoBarras.Leave += new System.EventHandler(this.txCodigoBarras_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txQuantidade);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DateValidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txLote);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txIdItemProtudo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamento Item";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Image = global::SaudeMed.Properties.Resources.cancelar;
            this.button4.Location = new System.Drawing.Point(117, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "Excluir";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txQuantidade
            // 
            this.txQuantidade.Location = new System.Drawing.Point(471, 44);
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.Size = new System.Drawing.Size(112, 25);
            this.txQuantidade.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::SaudeMed.Properties.Resources.editar;
            this.button2.Location = new System.Drawing.Point(229, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantidade:";
            // 
            // button3
            // 
            this.button3.Image = global::SaudeMed.Properties.Resources.clear;
            this.button3.Location = new System.Drawing.Point(338, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Limpar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnListar_Click);
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
            this.DateValidade.Location = new System.Drawing.Point(179, 44);
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
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::SaudeMed.Properties.Resources.salvar;
            this.button1.Location = new System.Drawing.Point(10, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Incluir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txIdItemProtudo
            // 
            this.txIdItemProtudo.Enabled = false;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDITEMDataGridViewTextBoxColumn,
            this.cODBARRASDataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.lOTEDataGridViewTextBoxColumn,
            this.vALIDADEDataGridViewTextBoxColumn,
            this.qUANTIDADEDataGridViewTextBoxColumn,
            this.pRECOCOMPRADataGridViewTextBoxColumn,
            this.pRECOVENDADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewTabelaItensProdutoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 264);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDITEMDataGridViewTextBoxColumn
            // 
            this.iDITEMDataGridViewTextBoxColumn.DataPropertyName = "IDITEM";
            this.iDITEMDataGridViewTextBoxColumn.HeaderText = "IDITEM";
            this.iDITEMDataGridViewTextBoxColumn.Name = "iDITEMDataGridViewTextBoxColumn";
            // 
            // cODBARRASDataGridViewTextBoxColumn
            // 
            this.cODBARRASDataGridViewTextBoxColumn.DataPropertyName = "CODBARRAS";
            this.cODBARRASDataGridViewTextBoxColumn.HeaderText = "CODBARRAS";
            this.cODBARRASDataGridViewTextBoxColumn.Name = "cODBARRASDataGridViewTextBoxColumn";
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            // 
            // lOTEDataGridViewTextBoxColumn
            // 
            this.lOTEDataGridViewTextBoxColumn.DataPropertyName = "LOTE";
            this.lOTEDataGridViewTextBoxColumn.HeaderText = "LOTE";
            this.lOTEDataGridViewTextBoxColumn.Name = "lOTEDataGridViewTextBoxColumn";
            // 
            // vALIDADEDataGridViewTextBoxColumn
            // 
            this.vALIDADEDataGridViewTextBoxColumn.DataPropertyName = "VALIDADE";
            this.vALIDADEDataGridViewTextBoxColumn.HeaderText = "VALIDADE";
            this.vALIDADEDataGridViewTextBoxColumn.Name = "vALIDADEDataGridViewTextBoxColumn";
            // 
            // qUANTIDADEDataGridViewTextBoxColumn
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn.Name = "qUANTIDADEDataGridViewTextBoxColumn";
            // 
            // pRECOCOMPRADataGridViewTextBoxColumn
            // 
            this.pRECOCOMPRADataGridViewTextBoxColumn.DataPropertyName = "PRECOCOMPRA";
            this.pRECOCOMPRADataGridViewTextBoxColumn.HeaderText = "PRECOCOMPRA";
            this.pRECOCOMPRADataGridViewTextBoxColumn.Name = "pRECOCOMPRADataGridViewTextBoxColumn";
            // 
            // pRECOVENDADataGridViewTextBoxColumn
            // 
            this.pRECOVENDADataGridViewTextBoxColumn.DataPropertyName = "PRECOVENDA";
            this.pRECOVENDADataGridViewTextBoxColumn.HeaderText = "PRECOVENDA";
            this.pRECOVENDADataGridViewTextBoxColumn.Name = "pRECOVENDADataGridViewTextBoxColumn";
            // 
            // viewTabelaItensProdutoBindingSource
            // 
            this.viewTabelaItensProdutoBindingSource.DataMember = "ViewTabelaItensProduto";
            this.viewTabelaItensProdutoBindingSource.DataSource = this.bDSAUDEMEDDataSet;
            // 
            // bDSAUDEMEDDataSet
            // 
            this.bDSAUDEMEDDataSet.DataSetName = "BDSAUDEMEDDataSet";
            this.bDSAUDEMEDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewTabelaItensProdutoTableAdapter
            // 
            this.viewTabelaItensProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ENDERECOTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = null;
            this.tableAdapterManager.ITEMPRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENSDEVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOSDESCARTADOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaudeMed.BDSAUDEMEDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            this.tableAdapterManager.VENDATableAdapter = null;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProdutos";
            this.Text = "SaudeMed - Gerenciar Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTabelaItensProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).EndInit();
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
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDSAUDEMEDDataSet bDSAUDEMEDDataSet;
        private System.Windows.Forms.BindingSource viewTabelaItensProdutoBindingSource;
        private BDSAUDEMEDDataSetTableAdapters.ViewTabelaItensProdutoTableAdapter viewTabelaItensProdutoTableAdapter;
        private BDSAUDEMEDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}