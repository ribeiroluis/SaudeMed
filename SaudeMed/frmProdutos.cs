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
    public partial class frmProdutos : frmModelo
    {
        private bool EstatusProduto = false;
        AcessaDados acessar = new AcessaDados();

        public frmProdutos()
        {
            InitializeComponent();
            
        }

        private void txCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    if (txCodigoBarras.Equals(""))
                    {

                    }
                    else
                    {
                        string _codbarras = txCodigoBarras.Text;

                        if (acessar.Produtos_RetornaSeExisteCodBarras(_codbarras))
                        {
                            DataTable tabela = acessar.Produtos_RetornaDatatableBuscaCodBarras(_codbarras);
                            DataRow linha = tabela.Rows[0];
                            txIdProduto.Text = linha[0].ToString();
                            txDescricao.Text = linha[1].ToString();
                            txCompra.Text = linha[3].ToString();
                            txPrecoVenda.Text = linha[4].ToString();
                            txDescontoMaximo.Text = linha[5].ToString();
                            txDescricao.ReadOnly = true;
                            EstatusProduto = true;
                            txDescricao.ReadOnly = true;
                        }
                        else
                        {
                            EstatusProduto = false;
                            txDescricao.ReadOnly = false;
                            //this.SelectNextControl(this.ActiveControl, true, true, true, true);
                            this.ActiveControl = txDescricao;
                        }
                    }
                }

                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }                
            }
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            GeraCustomSource();
            
        }
        
        private void GeraCustomSource()
        {
            try
            {

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
            DataTable table = acessar.Produtos_RetornaDescricao();

            foreach (DataRow row in table.Rows)
            {   
                string aux = (string)row[1];
                txDescricao.AutoCompleteCustomSource.Add(aux);
            }
        }

        private void txDescricao_Leave(object sender, EventArgs e)
        {
            try
            {

                if (txIdProduto.Equals(""))
                {

                }
                else
                {
                    int _idProtuto = int.Parse(txIdProduto.Text);
                    DataTable table = acessar.ItensProduto_RetornaLote(_idProtuto);
                    foreach (DataRow row in table.Rows)
                    {
                        string aux = (string)row[2];
                        txLote.AutoCompleteCustomSource.Add(aux);
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
            
            
            if (true)
            {
                EstatusProduto = true;
            }
            else
                EstatusProduto = false;

        }
    }
}
