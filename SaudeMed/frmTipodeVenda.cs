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
    public partial class frmTipodeVenda : frmModelo
    {
        string TipoVenda;
        string PontodeReferencia;
        double valorVenda;

        public frmTipodeVenda(int IdVenda, double Valor)
        {
            InitializeComponent();
            valorVenda = Valor;
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
                txValorVenda.Text = valorVenda.ToString("c");
                cbTipodeVenda.SelectedText = "BALCAO";

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
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
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = (int)cbFormadePagamento.SelectedValue;
            this.Close();
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
    }
}


    
