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
    public partial class frmRelatorioFechamentoDia : frmModelo
    {
        public frmRelatorioFechamentoDia()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaRelatorio();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        private void CarregaRelatorio()
        {
            try
            {
                ViewRelatorioVendasTableAdapter relatorio = new ViewRelatorioVendasTableAdapter();

                string data = DataMovimento.Value.ToShortDateString();

                DataTable _tabela = relatorio.RetornaTabelaRelatorioVendaPorDia(data);
                DtgDados.DataSource = _tabela;

                float Subtotal = 0;
                float Desconto = 0;
                float TotalVenda = 0;

                for (int i = 0; i < DtgDados.Rows.Count; i++)
                {
                    float valor = float.Parse(DtgDados["SUBTOTAL", i].Value.ToString());
                    DtgDados["SUBTOTAL", i].Value = valor.ToString("f2");
                    Subtotal += valor;

                    valor = float.Parse(DtgDados["DESCONTO", i].Value.ToString());
                    DtgDados["DESCONTO", i].Value = valor.ToString("f2");
                    Desconto += valor;


                    valor = float.Parse(DtgDados["TOTALVENDA", i].Value.ToString());
                    DtgDados["TOTALVENDA", i].Value = valor.ToString("f2");
                    TotalVenda += valor;

                    valor = float.Parse(DtgDados["VALORPARCELADO",i].Value.ToString());
                    DtgDados["VALORPARCELADO", i].Value = valor.ToString("f2");

                }

                txTotal.Text = TotalVenda.ToString("c");
                txDesconto.Text = Desconto.ToString("c");
                txSubtotal.Text = Subtotal.ToString("c");




            }
            catch (Exception)
            {
                
                throw;
            }
            
            
        }
    }
}
