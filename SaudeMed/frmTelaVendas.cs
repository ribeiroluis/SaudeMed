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
    public partial class frmTelaVendas : frmModelo
    {
        int IDFUNCIONARIO;
        public frmTelaVendas( int idfuncionario)
        {
            InitializeComponent();
            IDFUNCIONARIO = idfuncionario;
        }      

        private void frmTelaVendas_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txTelefoneFixo;
        }

        private void txTelefoneFixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (TestaCliente(txTelefoneFixo.Text))
                    {
                        PreencheCampos();
                        //this.ActiveControl

                    }
                    else
                    {
                        txTelefoneCelular.Enabled = true;
                        this.ActiveControl = txTelefoneCelular;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txTelefoneCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (TestaCliente(txTelefoneCelular.Text))
                    {
                        PreencheCampos();
                        //this.ActiveControl 
                    }
                    else
                    {
                        txNomeCliente.Enabled = true;
                        this.ActiveControl = txNomeCliente;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private bool TestaCliente(string parametro)
        {
            
            try
            {
                //contar quantas linahs ira retornar
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            return false;
        }

        private void PreencheCampos()
        {
            try
            {
                btnEditar.Enabled = true;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (TestaCliente(txNomeCliente.Text))
                    {
                        PreencheCampos();
                        //this.ActiveControl 
                    }
                    else
                    {
                        txCPF.Enabled = true;
                        this.ActiveControl = txCPF;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txCEP.Enabled = true;
                this.ActiveControl = txCEP;
            }
        }

        private void txCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txNumero.Enabled = true;
                this.ActiveControl = txNumero;
                PreencheCamposCEP();
            }
        }

        private void PreencheCamposCEP()
        {
            try
            {

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
 
        }

        private void txNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txComplemento.Enabled = true;
                this.ActiveControl = txComplemento;
            }
        }

        private void txComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGravar.Enabled = true;
                this.ActiveControl = btnGravar;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txIdCliente.Enabled = false;            
            txIdCliente.Clear();

            txTelefoneCelular.Enabled = false;
            txTelefoneCelular.Clear();
            
            txTelefoneFixo.Enabled = true;
            txTelefoneFixo.Clear();
            this.ActiveControl = txTelefoneFixo;

            txNomeCliente.Clear();
            txNomeCliente.Enabled = false;

            txCPF.Clear();
            txCPF.Enabled = false;

            txCEP.Enabled = false;
            txCEP.Clear();

            txEndereco.Clear();
            txCidade.Clear();
            txBairro.Clear();

            txNumero.Enabled = false;
            txNumero.Clear();

            txComplemento.Clear();
            txComplemento.Enabled = false;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPesquisaCEP pesquisa = new frmPesquisaCEP();
            pesquisa.ShowDialog();
            txCEP.Text = pesquisa.CEP;
            pesquisa.Close();
        }
    }
}
