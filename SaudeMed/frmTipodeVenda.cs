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
    public partial class frmTipodeVenda : frmModelo
    {
        string TipoVenda;
        string PontodeReferencia;
        float ValorVenda;
        int IDVenda;

        public frmTipodeVenda(int IdVenda, float Valor)
        {
            InitializeComponent();
            ValorVenda = Valor;
            IDVenda = IdVenda;
        }

        private void frmTipodeVenda_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'bDSAUDEMEDDataSet.FORMAPAGAMENTO'. Você pode movê-la ou removê-la conforme necessário.
                this.fORMAPAGAMENTOTableAdapter.Fill(this.bDSAUDEMEDDataSet.FORMAPAGAMENTO);
                cbFormadePagamento.SelectedIndex = 0;
                label2.Visible = false;
                cbParcelas.Visible = false;
                this.ActiveControl = cbTipodeVenda;
                txValorVenda.Text = ValorVenda.ToString("c");
                cbTipodeVenda.SelectedText = "BALCAO";

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void cbTipodeVenda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.ActiveControl = cbFormadePagamento;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void cbTipodeVenda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbTipodeVenda.Text.Equals("VIAGEM"))
                {
                    label5.Visible = true;
                    txPontodeReferencia.Visible = true;
                }
                else
                {
                    label5.Visible = false;
                    txPontodeReferencia.Visible = false;
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int idpagamento = (int)cbFormadePagamento.SelectedValue;
                TIPOVENDATableAdapter venda = new TIPOVENDATableAdapter();
                PAGAMENTOTableAdapter pagamentoparcelado = new PAGAMENTOTableAdapter();


                DateTime hora = DateTime.Now;

                venda.InsereTipodeVenda(IDVenda, idpagamento, hora.ToShortDateString(), txPontodeReferencia.Text, ValorVenda);
                
                int parcelas = int.Parse(cbParcelas.Text);

                if (!cbFormadePagamento.Text.Equals("A VISTA"))
                    hora = hora.AddMonths(1);

                float valorparcelado = ValorVenda / parcelas;
                for (int i = 0; i < parcelas; i++)
                {
                    pagamentoparcelado.InserePagamentoParcelado(IDVenda, (i + 1), valorparcelado, ValorVenda, hora.ToShortDateString());                    
                    hora = hora.AddMonths(1);
                }
                this.Close();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void FormadePagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cbFormadePagamento.Text.Equals("A VISTA"))
                {
                    label2.Visible = true;
                    cbParcelas.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    cbParcelas.Visible = false;
                    cbParcelas.Text = "1";
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}


    
