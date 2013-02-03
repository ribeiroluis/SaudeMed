using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SaudeMed.BDSAUDEMEDDataSetTableAdapters;

namespace SaudeMed
{
    public partial class frmFechamentoPeriodo : frmModelo
    {
        public frmFechamentoPeriodo()
        {
            InitializeComponent();
        }

        private void frmFechamentoPeriodo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close();
                    break;
                case Keys.F3: button1_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dtgDados.Visible = true;
                ViewRelatorioVendasPeriodoDataSetTableAdapterTableAdapter viewperidovendas = new ViewRelatorioVendasPeriodoDataSetTableAdapterTableAdapter();
                DataTable tabela = viewperidovendas.RetornaDataTablePeridodo(DataInicio.Value.ToShortDateString(),DataFim.Value.ToShortDateString());
                dtgDados.DataSource = tabela;
                ViewRelatorioVendasTableAdapter relatorio = new ViewRelatorioVendasTableAdapter();

                double total = (double)relatorio.RetornaTotalVendaPeriodo(DataInicio.Value.ToShortDateString(), DataFim.Value.ToShortDateString());
                txTotal.Text = total.ToString("c");
                
                int rowNumber = 1;
                foreach (DataGridViewRow row in dtgDados.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.HeaderCell.Value = rowNumber.ToString();
                    rowNumber++;
                }
                dtgDados.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message + "\nNão há vendas para o período selecionado!");
                dtgDados.Visible = false;
            }
        }

        private void frmFechamentoPeriodo_Load(object sender, EventArgs e)
        {
            
            this.ActiveControl = DataInicio;
        }

        private void DataInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ActiveControl = DataFim;
        }

        private void DataFim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ActiveControl = btnPesquisar;
        }
    }
}
