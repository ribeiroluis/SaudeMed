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
        int IDFUNCIONARIO;

        #region Produtos

        public frmProdutos(int idFuncionario)
        {
            InitializeComponent();
            this.ActiveControl = txCodigoBarras;
            IDFUNCIONARIO = idFuncionario;

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
                            dtgDadosProdutos.DataSource = acessar.ItensProdutos_ViewitensProdutosPorDescricao(txDescricao.Text);
                            for (int i = 0; i < dtgDadosProdutos.Rows.Count; i++)
                            {
                                float valor = float.Parse(dtgDadosProdutos["PRECOCOMPRA", i].Value.ToString());
                                dtgDadosProdutos["PRECOCOMPRA", i].Value = valor.ToString("f2");

                                valor = float.Parse(dtgDadosProdutos["PRECOVENDA", i].Value.ToString());
                                dtgDadosProdutos["PRECOVENDA", i].Value = valor.ToString("f2");
                            }
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
                            dtgDadosProdutos.DataSource = acessar.ItensProdutos_ViewitensProdutosPorDescricao(txDescricao.Text);
                            for (int i = 0; i < dtgDadosProdutos.Rows.Count; i++)
                            {
                                float valor = float.Parse(dtgDadosProdutos["PRECOCOMPRA", i].Value.ToString());
                                dtgDadosProdutos["PRECOCOMPRA", i].Value = valor.ToString("f2");

                                valor = float.Parse(dtgDadosProdutos["PRECOVENDA", i].Value.ToString());
                                dtgDadosProdutos["PRECOVENDA", i].Value = valor.ToString("f2");
                            }
                        }
                    }
                    else
                    {
                        if (txDescricao.Text.Equals(""))
                            MessageBox.Show("Digite o nome corretamente");
                        else
                        {
                            LiberaCampos();
                            btnIncluir.Text = "Salvar";
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

        private void CarregaProdutosPorDescricao()
        {
 
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDadosProdutos.DataSource = acessar.ItensProtutos_ViewItensProdutos();
                for (int i = 0; i < dtgDadosProdutos.Rows.Count; i++)
                {
                    float valor = float.Parse(dtgDadosProdutos["PRECOCOMPRA", i].Value.ToString());
                    dtgDadosProdutos["PRECOCOMPRA", i].Value = valor.ToString("f2");

                    valor = float.Parse(dtgDadosProdutos["PRECOVENDA", i].Value.ToString());
                    dtgDadosProdutos["PRECOVENDA", i].Value = valor.ToString("f2");
                }
                txDescricao.AutoCompleteCustomSource.Clear();
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
                DataTable table = acessar.Produtos_RetornaDescricao();

                foreach (DataRow row in table.Rows)
                {
                    string aux = (string)row[1];
                    txDescricao.AutoCompleteCustomSource.Add(aux);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (TestaseExiste())
                {
                    DialogResult resultato = MessageBox.Show("Deseja realizar alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultato == System.Windows.Forms.DialogResult.Yes)
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
                        MessageBox.Show("Alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cancelado pelo usuário!");
                        btnListar_Click(sender, e);
                    }
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
                    MessageBox.Show("Inserido com sucesso!");
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
            //BloqueiaCampos();
            txCodigoBarras.Enabled = true;
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            txDescricao.Enabled = false;
            txPrecoVenda.Enabled = false;
            txCompra.Enabled = false;
            txCodigoBarras.Clear();
            txDescricao.Clear();
            txIdProduto.Clear();
            txCompra.Clear();
            txPrecoVenda.Clear();
            txDescontoMaximo.Clear();
            frmProdutos_Load(sender, e);
            txLote.Enabled = false;
            txQuantidade.Enabled = false;
            DateValidade.Enabled = false;
            this.ActiveControl = txCodigoBarras;
            txLote.Clear();
            txQuantidade.Clear();
            txIdItemProtudo.Clear();
            btnEditarItens.Enabled = false;
        }

        private void PreencheCamposCodBarras(string Codbarras)
        {
            try
            {
                TabelaRecebida = new DataTable();
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
        private void txCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ActiveControl = txPrecoVenda;
        }

        private void txPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ActiveControl = btnIncluir;
        }

        #endregion Produtos









        #region ItensProduto

        private void GeracustomSourceLote()
        {
            try
            {
                txLote.AutoCompleteCustomSource.Clear();
                DataTable table = acessar.ItensProduto_RetornaLotes(int.Parse(txIdProduto.Text));

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
                    PreencheCamposItens(txLote.Text, int.Parse(txIdProduto.Text));
                    btnEditarItens.Enabled = true;
                    btnExcluirItens.Enabled = true;
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
                if (acessar.ItensProduto_RetornaSeExisteLote(txLote.Text, int.Parse(txIdProduto.Text)))
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

        private void PreencheCamposItens(string lote, int idproduto)
        {
            try
            {
                BloqueiaCamposItens();
                TabelaRecebida = new DataTable();
                TabelaRecebida = acessar.ItensProduto_RetornaDataTablePorLoteIDProduto(lote, idproduto);
                Linhas = TabelaRecebida.Rows[0];
                txIdItemProtudo.Text = Linhas[0].ToString();
                txLote.Text = Linhas[2].ToString();
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
            //txLote.Clear();
            txQuantidade.Enabled = false;
            //txQuantidade.Clear();
            DateValidade.Enabled = false;
            //DateValidade.Refresh();
            btnEditarItens.Enabled = true;
            btnExcluirItens.Enabled = false;
            BtnIncluirItens.Enabled = false;

        }

        private void LiberaCamposItens()
        {
            this.ActiveControl = txLote;
            txLote.Enabled = true;
            txQuantidade.Enabled = true;
            DateValidade.Enabled = true;
            btnEditarItens.Enabled = false;            
            BtnIncluirItens.Enabled = true;
        }

        private void BtnIncluirItens_Click(object sender, EventArgs e)
        {
            try
            {
                int _idProduto = int.Parse(txIdProduto.Text);
                string _lote = txLote.Text;
                DateTime _validade = DateValidade.Value;
                int _quantidade = int.Parse(txQuantidade.Text);


                if (TestaSeExiteLote())
                {
                    DialogResult resultato = MessageBox.Show("Deseja realizar alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultato == System.Windows.Forms.DialogResult.Yes)
                    {
                        int _idItemProduto = int.Parse(txIdItemProtudo.Text);
                        acessar.ItensProduto_AtualizarLote(_validade, _quantidade, _idItemProduto);
                        MessageBox.Show("Alterado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cancelado pelo usuário");
                    }

                }
                else
                {
                    acessar.ItensProduto_Incluir(_idProduto, _lote, _validade, _quantidade);
                    MessageBox.Show("Item inserido com sucesso!");
                }
                GeracustomSourceLote();
                frmProdutos_Load(sender, e);
                BtnIncluirItens.Text = "Incluir";
                BtnIncluirItens.Enabled = false;
                btnLimparItens_Click(sender, e);
                this.ActiveControl = txLote;

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnEditarItens_Click(object sender, EventArgs e)
        {
            BtnIncluirItens.Text = "Salvar";
            btnExcluirItens.Enabled = true;
            LiberaCamposItens();
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            txLote.Clear();
            txIdItemProtudo.Clear();
            txQuantidade.Clear();
            btnEditarItens.Enabled = false;
            btnExcluirItens.Enabled = false;
            txLote.Enabled = true;
            txQuantidade.Enabled = true;
            DateValidade.Enabled = true;
            this.ActiveControl = txLote;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                PreencheCamposDescricao(dtgDadosProdutos.CurrentRow.Cells[2].Value.ToString());
                PreencheCamposItens(dtgDadosProdutos.CurrentRow.Cells[3].Value.ToString(), int.Parse(txIdProduto.Text));
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnExcluirItens_Click(object sender, EventArgs e)
        {

            try
            {
                if (TestaSeExiteLote())
                {
                    DialogResult resultato = MessageBox.Show("Deseja exluir o item do estoque" +
                        "\nA exlusão eliminará todos os itens salvos deste lote solicitado", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resultato == System.Windows.Forms.DialogResult.Yes)
                    {
                        int _idProduto = int.Parse(txIdProduto.Text);
                        int _quantidade = int.Parse(txQuantidade.Text);
                        int _idItemProduto = int.Parse(txIdItemProtudo.Text);


                        frmMotivoExclusao excluir = new frmMotivoExclusao(_idProduto, _idItemProduto, _quantidade, IDFUNCIONARIO);
                        excluir.ShowDialog();
                       
                        acessar.ItensProduto_Excluir(_idItemProduto);
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cancelado pelo usuário");
                    }
                    GeracustomSourceLote();
                    BtnIncluirItens.Text = "Incluir";
                    BtnIncluirItens.Enabled = false;
                    btnExcluirItens.Enabled = false;
                    btnLimparItens_Click(sender, e);
                    this.ActiveControl = txLote;
                    frmProdutos_Load(sender, e);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        #endregion ItensProduto

        private void button1_Click(object sender, EventArgs e)
        {
            frmLotes frm = new frmLotes(txDescricao.Text);
            frm.ShowDialog();
            txLote.Text = frm.Lote;
            PreencheCamposItens(txLote.Text, int.Parse(txIdProduto.Text));
        }
    }
}