using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaudeMed
{
    public partial class frmLotes : frmModelo
    {

        string Descricao = "";
        public string Lote = "";
        public frmLotes(string descricao)
        {
            InitializeComponent();
            Descricao = descricao;
        }

        private void frmLotes_Load(object sender, EventArgs e)
        {
            txDescricao.Text = Descricao;
            txDescricao.ReadOnly = true;
            AcessaDados acessar = new AcessaDados();
            dtgDados.DataSource = acessar.ItensProdutos_ViewLotesPorDescricao(Descricao);
        }

        private void dtgDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             DialogResult resultado = MessageBox.Show("Confirmar seleção de Lote?", 
                                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

             if (resultado == System.Windows.Forms.DialogResult.Yes)
             {
                 Lote = dtgDados.CurrentRow.Cells[2].Value.ToString();
                 this.Close();
             }
             else
                 this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
