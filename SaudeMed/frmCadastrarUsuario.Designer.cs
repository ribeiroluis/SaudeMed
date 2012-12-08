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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSAUDEMEDDataSet = new SaudeMed.BDSAUDEMEDDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fUNCIONARIOTableAdapter = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.FUNCIONARIOTableAdapter();
            this.tableAdapterManager = new SaudeMed.BDSAUDEMEDDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DataSource = this.fUNCIONARIOBindingSource;
            this.cbFuncionario.DisplayMember = "NOME";
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(123, 58);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(278, 25);
            this.cbFuncionario.TabIndex = 1;
            this.cbFuncionario.ValueMember = "IDFUNCIONARIO";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 126);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 159);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(140, 25);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 192);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(140, 25);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar Senha:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::SaudeMed.Properties.Resources.confirmar1;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(162, 239);
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
            this.btnCancelar.Location = new System.Drawing.Point(269, 239);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "IDFUNCIONARIO";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.comboBox2.Location = new System.Drawing.Point(123, 93);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 25);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "IDFUNCIONARIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Controle total:";
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.ENDERECOTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOTableAdapter = this.fUNCIONARIOTableAdapter;
            this.tableAdapterManager.ITEMPRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENSDEVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SaudeMed.BDSAUDEMEDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.URUARIOSTableAdapter = null;
            this.tableAdapterManager.VENDATableAdapter = null;
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 407);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmCadastrarUsuario";
            this.Text = "SaudeMed - Gerenciar Usuario";
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSAUDEMEDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private BDSAUDEMEDDataSet bDSAUDEMEDDataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private BDSAUDEMEDDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
        private BDSAUDEMEDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}