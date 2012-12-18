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
    public partial class frmPesquisaCEP : frmModelo
    {
        public string CEP;
        AcessaDados acessar = new AcessaDados();
        
        public frmPesquisaCEP()
        {
            InitializeComponent();
        }

        private void txEndereco_TextChanged(object sender, EventArgs e)
        {
            try
            {

                dtgCep.DataSource = acessar.CEP_RetornCEPEnderecoCidadeBairroPorEndereco(txEndereco.Text);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void dtgCep_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CEP = dtgCep.CurrentRow.Cells["CEP"].Value.ToString();            
            
            DialogResult resultado = MessageBox.Show("Confirmar endereço?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); ;
            }
        }

        
    }
}
