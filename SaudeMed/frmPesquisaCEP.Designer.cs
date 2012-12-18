namespace SaudeMed
{
    partial class frmPesquisaCEP
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
            this.dtgCep = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCep)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCep
            // 
            this.dtgCep.AllowUserToAddRows = false;
            this.dtgCep.AllowUserToDeleteRows = false;
            this.dtgCep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgCep.Location = new System.Drawing.Point(0, 105);
            this.dtgCep.Name = "dtgCep";
            this.dtgCep.ReadOnly = true;
            this.dtgCep.Size = new System.Drawing.Size(694, 410);
            this.dtgCep.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtgCep, "Clique na linha desejada");
            this.dtgCep.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgCep_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereco, ou parte dele:";
            // 
            // txEndereco
            // 
            this.txEndereco.Location = new System.Drawing.Point(12, 45);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.Size = new System.Drawing.Size(670, 25);
            this.txEndereco.TabIndex = 0;
            this.txEndereco.TextChanged += new System.EventHandler(this.txEndereco_TextChanged);
            // 
            // frmPesquisaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 515);
            this.Controls.Add(this.dtgCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txEndereco);
            this.Name = "frmPesquisaCEP";
            this.Text = "SAUDEMED - PESQUISAR CEP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCep;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}