namespace SaudeMed
{
    partial class frmRelatorioFechamentoDia
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
            this.DtgDados = new System.Windows.Forms.DataGridView();
            this.DataMovimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txSubtotal = new System.Windows.Forms.TextBox();
            this.txDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDados
            // 
            this.DtgDados.AllowUserToAddRows = false;
            this.DtgDados.AllowUserToDeleteRows = false;
            this.DtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgDados.Location = new System.Drawing.Point(0, 94);
            this.DtgDados.Name = "DtgDados";
            this.DtgDados.ReadOnly = true;
            this.DtgDados.Size = new System.Drawing.Size(978, 573);
            this.DtgDados.TabIndex = 0;
            // 
            // DataMovimento
            // 
            this.DataMovimento.Location = new System.Drawing.Point(118, 12);
            this.DataMovimento.Name = "DataMovimento";
            this.DataMovimento.Size = new System.Drawing.Size(302, 25);
            this.DataMovimento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o dia:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::SaudeMed.Properties.Resources._1357951992_tick_circle;
            this.btnConfirmar.Location = new System.Drawing.Point(440, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(99, 27);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sub Total:";
            // 
            // txSubtotal
            // 
            this.txSubtotal.Location = new System.Drawing.Point(84, 57);
            this.txSubtotal.Name = "txSubtotal";
            this.txSubtotal.ReadOnly = true;
            this.txSubtotal.Size = new System.Drawing.Size(100, 25);
            this.txSubtotal.TabIndex = 5;
            // 
            // txDesconto
            // 
            this.txDesconto.Location = new System.Drawing.Point(287, 57);
            this.txDesconto.Name = "txDesconto";
            this.txDesconto.ReadOnly = true;
            this.txDesconto.Size = new System.Drawing.Size(100, 25);
            this.txDesconto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descontos:";
            // 
            // txTotal
            // 
            this.txTotal.Location = new System.Drawing.Point(464, 57);
            this.txTotal.Name = "txTotal";
            this.txTotal.ReadOnly = true;
            this.txTotal.Size = new System.Drawing.Size(100, 25);
            this.txTotal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // frmRelatorioFechamentoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 667);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataMovimento);
            this.Controls.Add(this.DtgDados);
            this.Name = "frmRelatorioFechamentoDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaudeMed - Fechamento Dia";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDados;
        private System.Windows.Forms.DateTimePicker DataMovimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txSubtotal;
        private System.Windows.Forms.TextBox txDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txTotal;
        private System.Windows.Forms.Label label4;
    }
}