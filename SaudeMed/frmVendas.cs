using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SaudeMed
{
    public partial class frmVendas : frmModelo
    {
        AcessaDados acessar = new AcessaDados();
        int IdFuncionario;
        int IDProduto;
        int IDItemProtudo;
        float PrecoUnitario;
        float Subtotal;
        float Quantidade;
        int item = 0;

        public frmVendas(int idfuncionario)
        {
            InitializeComponent();
            IdFuncionario = idfuncionario;
        }

        private void txTelefoneFixo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txTelefoneFixo.Text.Equals(""))
                    {
                        txTelefoneCelular.ReadOnly = false;
                        this.ActiveControl = txTelefoneCelular;
                    }
                    else
                    {
                        if (TestaClienteTelefone(txTelefoneFixo.Text))
                        {
                            PreencheCampos(txTelefoneFixo.Text, "");
                        }

                        else
                        {
                            txTelefoneCelular.ReadOnly = false;
                            this.ActiveControl = txTelefoneCelular;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txTelefoneCelular_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txTelefoneCelular.Text.Equals(""))
                    {
                        txNomeCliente.ReadOnly = false;
                        GeraCoustomSourceCliente();
                        this.ActiveControl = txNomeCliente;
                    }
                    else
                    {
                        if (TestaClienteTelefone(txTelefoneCelular.Text))
                        {
                            PreencheCampos(txTelefoneCelular.Text, "");
                        }
                        else
                        {
                            txNomeCliente.ReadOnly = false;
                            GeraCoustomSourceCliente();
                            this.ActiveControl = txNomeCliente;
                        }
                    }

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private bool TestaClienteTelefone(string parametro)
        {

            try
            {
                var testa = acessar.Cliente_RetornDataTablePorTelefone(parametro);
                if (testa.Rows.Count > 1)
                {
                    MessageBox.Show("Mais de um cliente cadastrado para o telefone, procure pelo nome ou celular.");
                    txNomeCliente.Enabled = true;
                    GeraCoustomSourceCliente();
                    this.ActiveControl = txNomeCliente;
                    return false;
                }
                else if (testa.Rows.Count == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return false;
            }
        }

        private void GeraCoustomSourceCliente()
        {
            txNomeCliente.AutoCompleteCustomSource.Clear();
            try
            {
                DataTable table = acessar.Cliente_RetornaTabelaCliente();
                foreach (DataRow row in table.Rows)
                {
                    string aux = (string)row[1];
                    txNomeCliente.AutoCompleteCustomSource.Add(aux);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PreencheCampos(string telefone, string nome)
        {
            try
            {
                DataTable tabela = new DataTable();

                if (!telefone.Equals(""))
                {
                    tabela = acessar.Cliente_RetornDataTablePorTelefone(telefone);
                }
                else
                    tabela = acessar.Cliente_RetornaTabelaClientePorNome(nome);

                txIdCliente.Text = tabela.Rows[0][0].ToString();
                txNomeCliente.Text = tabela.Rows[0][1].ToString();
                txTelefoneFixo.Text = tabela.Rows[0][3].ToString();
                txTelefoneCelular.Text = tabela.Rows[0][4].ToString();
                txIdCliente.ReadOnly = true;
                txNomeCliente.ReadOnly = true;
                txTelefoneFixo.ReadOnly = true;
                txTelefoneCelular.ReadOnly = true;
                txCodBarras.ReadOnly = false;
                this.ActiveControl = txCodBarras;
                acessar.Venda_InsereVendaTemporaria(int.Parse(txIdCliente.Text), IdFuncionario);
                txNumerVenda.Text = acessar.Venda_RetornaUltimaVenda().PadLeft(6, '0'); //numeros a esquerda

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
                        PreencheCampos("", txNomeCliente.Text);
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Cliente não cadastrado, realizar cadastro?", "Aviso", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (resultado == System.Windows.Forms.DialogResult.Yes)
                        {
                            frmTelaCliente cliente = new frmTelaCliente(IdFuncionario);
                            cliente.RecebeDadosClientes(txTelefoneCelular.Text, txTelefoneFixo.Text, txNomeCliente.Text);
                            cliente.ShowDialog();
                            if (TestaCliente(txNomeCliente.Text))
                                PreencheCampos("", txNomeCliente.Text);
                        }
                        else
                        {
                            txIdCliente.Clear();
                            txTelefoneCelular.Clear();
                            txTelefoneFixo.Clear();
                            txNomeCliente.Clear();
                            txTelefoneFixo.ReadOnly = false;
                            this.ActiveControl = txTelefoneFixo;
                        }

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
                var tabela = acessar.Cliente_RetornaTabelaClientePorNome(parametro);
                if (tabela.Rows.Count == 1)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTelaCliente cliente = new frmTelaCliente(IdFuncionario);
            cliente.ShowDialog();
            string nome = cliente.RetornaUltimoNome;

            if (TestaCliente(nome))
                PreencheCampos("", nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Cancelar venda atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    txIdCliente.Clear();
                    txTelefoneCelular.Clear();
                    txTelefoneFixo.Clear();
                    txNomeCliente.Clear();
                    txTelefoneFixo.ReadOnly = false;
                    this.ActiveControl = txTelefoneFixo;
                    acessar.Venda_DeletaVendaPorID(int.Parse(txNumerVenda.Text));
                    acessar.ItensVenda_DeletarVendaPorID(int.Parse(txNumerVenda.Text));
                    for (int i = 0; i < DtgDados.Rows.Count; i++)
                    {
                        string lote = DtgDados["LOTE",i].Value.ToString();
                        string descricao = DtgDados["DESCRICAO",i].Value.ToString();
                        int quantEstoque = acessar.ItensVenda_RetornaQuantidadeEstoque(lote,descricao);
                        int valor = (int)DtgDados["QUANTIDADE",i].Value;
                        int idproduto = acessar.ItensVenda_RetornaIDProduto(descricao);
                        int iditemproduto = acessar.ItensVenda_RetornaIDItemProduto(lote,idproduto);
                        AtualizaEstoque(valor, iditemproduto, quantEstoque);
                    }
                    
                    txNumerVenda.Clear();
                    MessageBox.Show("Venda excluida com sucesso");
                    btnLimparItens_Click(sender, e);
                    this.ActiveControl = txTelefoneFixo;

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txNumerVenda.Text.Equals(""))
                    this.Close();
                else
                {
                    btnLimpar_Click(sender, e);
                    this.Close();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }


        }

        private void txCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txCodBarras.Text.Equals(""))
                    {
                        txDescricao.ReadOnly = false;
                        this.ActiveControl = txDescricao;
                        GeraCustomSourceDescricao();
                    }
                    else
                    {
                        if (acessar.Produtos_RetornaSeExisteCodBarras(txCodBarras.Text))
                        {
                            DataTable tabela = acessar.Produtos_RetornaDatatableBuscaCodBarras(txCodBarras.Text);
                            DataRow linhaProduto = tabela.Rows[0];
                            txDescricao.Text = linhaProduto["DESCRICAO"].ToString();
                            PrecoUnitario = float.Parse(linhaProduto["PRECOVENDA"].ToString());
                            txPrecoUnitario.Text = PrecoUnitario.ToString("f2");
                            PrecoUnitario = float.Parse(txPrecoUnitario.Text);
                            cbLote.Enabled = true;
                            IDProduto = (int)linhaProduto["IDPRODUTO"];
                            PreencheLote((int)linhaProduto["IDPRODUTO"]);
                            this.ActiveControl = cbLote;
                        }
                        else
                        {
                            MessageBox.Show("Produto não cadastrado.");
                            txCodBarras.Clear();
                            this.ActiveControl = txCodBarras;
                        }
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txCodBarras;
            txCodBarras.Clear();
            txDescricao.Clear();
            txDescricao.ReadOnly = true;
            cbLote.Items.Clear();
            cbLote.Refresh();
            cbLote.Enabled = false;
            numQuantidade.Value = 1;
            numQuantidade.ReadOnly = true;
            txEstoque.Clear();
            txPrecoUnitario.Clear();
            txSubtotal.Clear();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            try
            {
                txDesconto.ReadOnly = false;
                InsereItemDataGridView();
                btnLimparItens_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PreencheLote(int idproduto)
        {
            try
            {
                cbLote.Items.Clear();
                DataTable Lotes = acessar.ItensProduto_RetornaLotes(idproduto);
                for (int i = 0; i < Lotes.Rows.Count; i++)
                {
                    DataRow linha = Lotes.Rows[i];
                    cbLote.Items.Add(linha["LOTE"].ToString());
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void cbLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable tabela = acessar.ItensProduto_RetornaDataTablePorLoteIDProduto(cbLote.SelectedText, IDProduto);
                    DataRow linha = tabela.Rows[0];
                    txEstoque.Text = linha["QUANTIDADE"].ToString();
                    IDItemProtudo = (int)linha["IDITEM"];
                    numQuantidade.ReadOnly = false;
                    this.ActiveControl = numQuantidade;
                    numQuantidade.Maximum = decimal.Parse(txEstoque.Text);
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Subtotal = PrecoUnitario * (float)numQuantidade.Value;
                txSubtotal.Text = Subtotal.ToString("f2");
                Quantidade = (float)numQuantidade.Value;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void numQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Subtotal = PrecoUnitario * (float)numQuantidade.Value;
                    txSubtotal.Text = Subtotal.ToString("f2");
                    this.ActiveControl = btn_Incluir;
                    Quantidade = (float)numQuantidade.Value;
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
                    if (acessar.Produtos_RetornaSeExisteDescricao(txDescricao.Text))
                    {
                        DataTable tabela = acessar.Produtos_RetornaDatatableDescricao(txDescricao.Text);
                        DataRow linhaProduto = tabela.Rows[0];

                        txCodBarras.Text = linhaProduto["CODBARRAS"].ToString();
                        txDescricao.Text = linhaProduto["DESCRICAO"].ToString();
                        PrecoUnitario = float.Parse(linhaProduto["PRECOVENDA"].ToString());
                        txPrecoUnitario.Text = PrecoUnitario.ToString("f2");
                        PrecoUnitario = float.Parse(txPrecoUnitario.Text);
                        cbLote.Enabled = true;
                        IDProduto = (int)linhaProduto["IDPRODUTO"];
                        PreencheLote((int)linhaProduto["IDPRODUTO"]);
                        this.ActiveControl = cbLote;
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado.");
                        txCodBarras.Clear();
                        this.ActiveControl = txCodBarras;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void GeraCustomSourceDescricao()
        {
            txDescricao.AutoCompleteCustomSource.Clear();
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

        private void InsereItemDataGridView()
        {
            try
            {   
                acessar.ItensVenda_InserirVenda(int.Parse(txNumerVenda.Text), IDProduto, IDItemProtudo, PrecoUnitario, (int)Quantidade);                
                AtualizaEstoque(((int)Quantidade*(-1)), IDItemProtudo, int.Parse(txEstoque.Text));
                DataTable tabela = acessar.ItensVenda_RetornaDatatableListadeVenda(int.Parse(txNumerVenda.Text));
                
              nao limpou a tabela 
                DtgDados.Rows.Clear();
                DtgDados.DataSource = tabela;
                
                /*
                DtgDados.Rows.Add();
                DtgDados["dtgDESCRICAO", item].Value = txDescricao.Text;
                DtgDados["dtgQUANTIDADE", item].Value = (int)numQuantidade.Value;
                DtgDados["dtgPRECOUNITARIO", item].Value = txPrecoUnitario.Text;
                DtgDados["dtgSUBTOTAL", item].Value = Subtotal;
                 */
                



                item++;
                




            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


        private void AtualizaEstoque(int value, int iditemproduto, int quantidadeEstoque)
        {
            try
            {
                int valor = value + quantidadeEstoque;
                acessar.ItensVenda_AtualizaEstoquePorIdItemProduto(iditemproduto, valor);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        
    }
}
        