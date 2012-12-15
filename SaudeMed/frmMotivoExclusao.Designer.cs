namespace SaudeMed
{
    partial class frmMotivoExclusao
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
            this.txMotivo = new System.Windows.Forms.TextBox();
            this.BtnIncluirItens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o motivo da baixa:";
            // 
            // txMotivo
            // 
            this.txMotivo.Location = new System.Drawing.Point(59, 55);
            this.txMotivo.Name = "txMotivo";
            this.txMotivo.Size = new System.Drawing.Size(538, 25);
            this.txMotivo.TabIndex = 1;
            this.txMotivo.TextChanged += new System.EventHandler(this.txMotivo_TextChanged);
            // 
            // BtnIncluirItens
            // 
            this.BtnIncluirItens.Enabled = false;
            this.BtnIncluirItens.Image = global::SaudeMed.Properties.Resources.confirmar1;
            this.BtnIncluirItens.Location = new System.Drawing.Point(498, 99);
            this.BtnIncluirItens.Name = "BtnIncluirItens";
            this.BtnIncluirItens.Size = new System.Drawing.Size(99, 36);
            this.BtnIncluirItens.TabIndex = 6;
            this.BtnIncluirItens.Text = "Confirma";
            this.BtnIncluirItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncluirItens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIncluirItens.UseVisualStyleBackColor = true;
            this.BtnIncluirItens.Click += new System.EventHandler(this.BtnIncluirItens_Click);
            // 
            // frmMotivoExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 179);
            this.ControlBox = false;
            this.Controls.Add(this.BtnIncluirItens);
            this.Controls.Add(this.txMotivo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMotivoExclusao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAUDEMED - Exclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txMotivo;
        private System.Windows.Forms.Button BtnIncluirItens;
    }
}