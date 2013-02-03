namespace SaudeMed
{
    partial class frmFechamentoPeriodo
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
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Período";
            // 
            // DataInicio
            // 
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(68, 29);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(136, 25);
            this.DataInicio.TabIndex = 1;
            this.DataInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataInicio_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fim:";
            // 
            // DataFim
            // 
            this.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFim.Location = new System.Drawing.Point(265, 29);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(136, 25);
            this.DataFim.TabIndex = 3;
            this.DataFim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataFim_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::SaudeMed.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(424, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 25);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "F3 - Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDados.Location = new System.Drawing.Point(0, 116);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.Size = new System.Drawing.Size(968, 399);
            this.dtgDados.TabIndex = 6;
            this.dtgDados.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total:";
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(67, 67);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(100, 25);
            this.txTotal.TabIndex = 8;
            // 
            // frmFechamentoPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 515);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmFechamentoPeriodo";
            this.Text = "SaudeMed - Fechamento Período";
            this.Load += new System.EventHandler(this.frmFechamentoPeriodo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFechamentoPeriodo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTotal;
    }
}