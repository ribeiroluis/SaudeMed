namespace SaudeMed
{
    partial class frmLotes
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
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(0, 46);
            this.dtgDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.Size = new System.Drawing.Size(729, 379);
            this.dtgDados.TabIndex = 0;
            this.dtgDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDados_CellMouseClick);
            // 
            // txDescricao
            // 
            this.txDescricao.Location = new System.Drawing.Point(12, 13);
            this.txDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(648, 25);
            this.txDescricao.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::SaudeMed.Properties.Resources._out;
            this.button1.Location = new System.Drawing.Point(684, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.dtgDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmLotes";
            this.Text = "SAUDEMED - LOTES CADASTRADOS";
            this.Load += new System.EventHandler(this.frmLotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Button button1;
    }
}