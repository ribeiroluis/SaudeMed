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
        AcessaDados acessar = new AcessaDados();
        DataTable TabelaRecebida;
        DataRow Linhas;
        
        #region Produtos
        
        public frmProdutos(int idFuncionario)
        {
            InitializeComponent();
            this.ActiveControl = txCodigoBarras;

        }

        private void txCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    if (txCodigoBarras.Equals(""))
                    {
                        this.ActiveControl = txDescricao;

                    }
                    else
                    {
                        string _codbarras = txCodigoBarras.Text.ToUpper();

                        if (acessar.Produtos_RetornaSeExisteCodBarras(_codbarras))
                        {
                            PreencheCamposCodBarras(_codbarras);
                            LiberaCamposItens();
                            this.ActiveControl = txLote;
                            GeracustomSourceLote();
                        }
                        else
                        {
                            LiberaCampos();
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

        /*private void txCodigoBarras_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txCodigoBarras.Equals(""))
                {
                    //this.ActiveControl = txDescricao;
                }                
                else
                {

                    string _codbarras = txCodigoBarras.Text.ToUpper();

                    if (acessar.Produtos_RetornaSeExisteCodBarras(_codbarras))
                    {
                        PreencheCamposCodBarras(_codbarras);
                    }
                    else
                    {
                        LiberaCampos();
                        //this.ActiveControl = txDescricao;
                    }
                }
            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txDescricao_Leave(object sender, EventArgs e)
        {
            
            try
            {
                string _descricao = txDescricao.Text.ToUpper();
                if (acessar.Produtos_RetornaSeExisteDescricao(_descricao))
                {
                    PreencheCamposDescricao(_descricao);
                }
                else
                {
                    LiberaCampos();
                    //this.ActiveControl = txCompra;

                    if (TestaseExiste())
                        btnIncluir.Text = "Salvar";
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }*/

        private void txDescricao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string _descricao = txDescricao.Text.ToUpper();
                    if (acessar.Produtos_RetornaSeExisteDescricao(_descricao))
                    {
                        PreencheCamposDescricao(_descricao);
                        if (txDescricao.Text.Equals(""))
                            MessageBox.Show("Digite o nome corretamente");
                        else
                        {
                            this.ActiveControl = txLote;
                            LiberaCamposItens();
                            GeracustomSourceLote();
                        }
                    }
                    else
                    {
                        if (txDescricao.Text.Equals(""))
                            MessageBox.Show("Digite o nome corretamente");
                        else
                        {
                            LiberaCampos();
                            this.ActiveControl = txCompra;
                        }
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }   
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LiberaCampos();
                btnIncluir.Text = "Salvar";
                //this.ActiveControl = btnIncluir;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void BloqueiaCampos()
        {
            try
            {
                txDescricao.Enabled = false;
                txPrecoVenda.Enabled = false;
                txDescontoMaximo.Enabled = false;
                txCompra.Enabled = false;
                txCodigoBarras.Enabled = false;
                btnEditar.Enabled = true;
                btnIncluir.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);   
            }
        }

        private void LiberaCampos()
        {
            try
            {
                txDescricao.Enabled = true;
                txPrecoVenda.Enabled = true;
                txCodigoBarras.Enabled = true;
                txCompra.Enabled = true;
                btnIncluir.Enabled = true;
                btnIncluir.Text = "Incluir";
                btnEditar.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);                
            }
            
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            try
            {

                txDescricao.AutoCompleteCustomSource.Clear();
                // TODO: esta linha de código carrega dados na tabela 'bDSAUDEMEDDataSet.ViewTabelaItensProduto'. Você pode movê-la ou removê-la conforme necessário.
                this.viewTabelaItensProdutoTableAdapter.Fill(this.bDSAUDEMEDDataSet.ViewTabelaItensProduto);
                GeraCustomSource();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }         

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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TestaseExiste())
                {
                    int idProduto = int.Parse(txIdProduto.Text);
                    string descricao = txDescricao.Text.ToUpper();
                    string codbarras = txCodigoBarras.Text.ToUpper();
                    if (codbarras.Equals(""))
                        codbarras = "##########";
                    float compra = float.Parse(txCompra.Text);
                    float venda = float.Parse(txPrecoVenda.Text);
                    float desconto = venda - compra;
                    acessar.Produtos_AtualizarProduto(idProduto, descricao, codbarras, compra, venda, desconto);
                    btnListar_Click(sender, e);
                }
                else
                {
                    string descricao = txDescricao.Text.ToUpper();
                    string codbarras = txCodigoBarras.Text.ToUpper();
                    if (codbarras.Equals(""))
                        codbarras = "##########";
                    float compra = float.Parse(txCompra.Text);
                    float venda = float.Parse(txPrecoVenda.Text);
                    float desconto = venda - compra;
                    acessar.Produtos_InserirNovo(descricao, codbarras, compra, venda, desconto);
                    btnListar_Click(sender, e);
                }

                //this.ActiveControl = txCodigoBarras;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //LiberaCampos();
            BloqueiaCampos();
            txCodigoBarras.Enabled = true;
            btnIncluir.Enabled = false;
            txCodigoBarras.Clear();
            txDescricao.Clear();
            txIdProduto.Clear();
            txCompra.Clear();
            txPrecoVenda.Clear();
            txDescontoMaximo.Clear();
            frmProdutos_Load(sender, e);
        }

        private void PreencheCamposCodBarras(string Codbarras)
        {
            try
            {
                TabelaRecebida = acessar.Produtos_RetornaDatatableBuscaCodBarras(Codbarras);
                Linhas = TabelaRecebida.Rows[0];

                txIdProduto.Text = Linhas[0].ToString();
                txDescricao.Text = Linhas[1].ToString();
                txCodigoBarras.Text = Linhas[2].ToString();

                float valor = float.Parse(Linhas[3].ToString());
                txCompra.Text = valor.ToString("f2");

                valor = float.Parse(Linhas[4].ToString());
                txPrecoVenda.Text = valor.ToString("f2");

                valor = float.Parse(Linhas[5].ToString());
                txDescontoMaximo.Text = valor.ToString("f2");

                BloqueiaCampos();
                //this.ActiveControl = txLote;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
            
        }

        private void PreencheCamposDescricao(string descricao)
        {
            try
            {
                TabelaRecebida = acessar.Produtos_RetornaDatatableDescricao(descricao);
                Linhas = TabelaRecebida.Rows[0];

                txIdProduto.Text = Linhas[0].ToString();
                txDescricao.Text = Linhas[1].ToString();
                txCodigoBarras.Text = Linhas[2].ToString();

                float valor = float.Parse(Linhas[3].ToString());
                txCompra.Text = valor.ToString("f2");

                valor = float.Parse(Linhas[4].ToString());
                txPrecoVenda.Text = valor.ToString("f2");

                valor = float.Parse(Linhas[5].ToString());
                txDescontoMaximo.Text = valor.ToString("f2");

                BloqueiaCampos();
               // this.ActiveControl = txLote;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        

        private bool TestaseExiste()
        {
            if (txIdProduto.Text.Equals(""))
                return false;
            else
                return true;
        }

        private void txCompra_Leave(object sender, EventArgs e)
        {
            //this.ActiveControl = txPrecoVenda;
        }
        
        private void txCompra_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
                //this.ActiveControl = txPrecoVenda;
        }

        private void txPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
               // this.ActiveControl = btnIncluir;
        }

        private void txPrecoVenda_Leave(object sender, EventArgs e)
        {
            //this.ActiveControl = btnIncluir;
        }

        #endregion Produtos

        

        

        

        

        #region ItensProduto

        private void GeracustomSourceLote()
        {
            try
            {
                DataTable table = acessar.ItensProduto_RetornaLotes();

                foreach (DataRow row in table.Rows)
                {
                    string aux = (string)row[2];
                    txLote.AutoCompleteCustomSource.Add(aux);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TestaSeExiteLote())
                {
                    PreencheCamposItens();                    
                }
                else
                {   
                    LiberaCamposItens();
                    this.ActiveControl = DateValidade;
                }
            }


        }

        private bool TestaSeExiteLote()
        {
            try
            {
                if (acessar.ItensProduto_RetornaSeExisteLote(txLote.Text))
                    return true;
                else
                    return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }            
        }

        private void PreencheCamposItens()
        {
            try
            {
                BloqueiaCampos();
                btnEditar.Enabled = true;                
                TabelaRecebida = acessar.ItensProduto_RetornaDataTablePorLote(txLote.Text, int.Parse(txIdProduto.Text));                
                Linhas = TabelaRecebida.Rows[0];
                txIdItemProtudo.Text = Linhas[0].ToString();
                DateValidade.Value = (DateTime)Linhas[3];
                txQuantidade.Text = Linhas[4].ToString();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void DateValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txQuantidade;
            }
        }

        private void txQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = BtnIncluirItens;
            }
        }

        private void BloqueiaCamposItens()
        {
            txLote.Enabled = false;
            txLote.Clear();
            txQuantidade.Enabled = false;
            txQuantidade.Clear();
            DateValidade.Enabled = false;
            DateValidade.Refresh();
            btnEditarItens.Enabled = false;
            btnExcluirItens.Enabled = false;            
            BtnIncluirItens.Enabled = false;

        }

        private void LiberaCamposItens()
        {
            txLote.Enabled = true;
            txQuantidade.Enabled = true;
            DateValidade.Enabled = true;
            //btnEditarItens.Enabled = true;
            //btnExcluirItens.Enabled = true;
            BtnIncluirItens.Enabled = true;
        }

        #endregion ItensProduto

        

       

        
    }
}
