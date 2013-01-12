using SaudeMed.BDSAUDEMEDDataSetTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                VizualizaDataGridView();

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
                    if (txNomeCliente.Text.Equals(""))
                        MessageBox.Show("Digite algo...");

                    else
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
                                txTelefoneCelular.ReadOnly = true;
                                txNomeCliente.ReadOnly = true;
                                txTelefoneFixo.ReadOnly = false;
                                this.ActiveControl = txTelefoneFixo;
                            }

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

                if (txNumerVenda.Text.Equals(""))
                {
                    MessageBox.Show("Não há venda para ser cancelada");
                    btnLimparItens_Click(sender, e);
                    txIdCliente.Clear();
                    txTelefoneCelular.Clear();
                    txTelefoneFixo.Clear();
                    txNomeCliente.Clear();
                    txTelefoneFixo.ReadOnly = false;
                    this.ActiveControl = txTelefoneFixo;
                    txTelefoneCelular.ReadOnly = true;
                    txNomeCliente.ReadOnly = true;

                    
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Cancelar venda atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        txSubtotalGeral.Clear();
                        txTotalGeral.Clear();
                        txDesconto.Clear();
                        txIdCliente.Clear();
                        txTelefoneCelular.Clear();
                        txTelefoneFixo.Clear();
                        txNomeCliente.Clear();
                        txTelefoneFixo.ReadOnly = false;
                        this.ActiveControl = txTelefoneFixo;
                        txDesconto.Clear();

                        //deleta tabela venda
                        acessar.Venda_DeletaVendaPorID(int.Parse(txNumerVenda.Text));

                        //deleta tabela itens venda
                        acessar.ItensVenda_DeletarVendaPorID(int.Parse(txNumerVenda.Text));
                        for (int i = 0; i < DtgDadosVenda.Rows.Count; i++)
                        {
                            int _valor = int.Parse(DtgDadosVenda["QUANTIDADE", i].Value.ToString());
                            int _idproduto = acessar.ItensVenda_RetornaIDProduto(DtgDadosVenda["DESCRICAO", i].Value.ToString());
                            int _iditemproduto = acessar.ItensVenda_RetornaIDItemProduto(DtgDadosVenda["LOTE", i].Value.ToString(), _idproduto);
                            int _quantidadeEstoque = acessar.ItensVenda_RetornaQuantidadeEstoque(DtgDadosVenda["LOTE", i].Value.ToString(), DtgDadosVenda["DESCRICAO", i].Value.ToString());
                            AtualizaEstoque(_valor, _iditemproduto, _quantidadeEstoque);
                        }

                        DataTable tabelaVazia = new DataTable();

                        DtgDadosVenda.DataSource = tabelaVazia;
                        txNumerVenda.Clear();

                        MessageBox.Show("Venda excluida com sucesso");
                        btnLimparItens_Click(sender, e);
                        this.ActiveControl = txTelefoneFixo;

                    }
                }
             
                
                
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


        /// <summary>
        /// Botao sair e cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txNumerVenda.Text.Equals(""))
                {
                    this.Close();
                }
                else
                {
                    btnLimpar_Click(sender, e);                    
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
                        CarregaQuantidade();
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
                            CarregaQuantidade();
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


        private void CarregaQuantidade()
        {
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txCodBarras;
            txCodBarras.Clear();
            txDescricao.Clear();
            txDescricao.ReadOnly = true;
            cbLote.Items.Clear();
            cbLote.ResetText();
            cbLote.SelectedText = "";
            cbLote.Enabled = false;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
                cbLote.ResetText();
                cbLote.SelectedText = "";

                DataTable Lotes = acessar.ItensProduto_RetornaLotes(idproduto);

                for (int i = 0; i < Lotes.Rows.Count; i++)
                {
                    DataRow linha = Lotes.Rows[i];
                    cbLote.Items.Add(linha["LOTE"].ToString());
                }
                if (Lotes.Rows.Count < 1)
                {
                    MessageBox.Show("Não há itens cadastrado para o produto.");
                    txCodBarras.Clear();
                    txDescricao.Clear();
                    txPrecoUnitario.Clear();
                    cbLote.Items.Clear();
                    cbLote.SelectedText = "";
                    this.ActiveControl = txCodBarras;
                }
                else
                {
                    string lote = cbLote.Items[0].ToString();
                    cbLote.SelectedText = lote;
                    this.ActiveControl = cbLote;

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

                    if(int.Parse(txEstoque.Text)<1)
                    {
                        MessageBox.Show("Não há itens em estoque para o lote selecionado");
                        btnLimparItens_Click(sender, e);

                    }
                    else
                    {
                        numQuantidade.ReadOnly = false;
                        this.ActiveControl = numQuantidade;
                        this.numQuantidade.Value = new decimal(new int[] {1,0,0,0});
                        numQuantidade.Maximum = decimal.Parse(txEstoque.Text);
                    }
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

                    if (txEstoque.Text.Equals("0"))
                    {
                        MessageBox.Show("Não há itens em estoque.");
                        btn_Incluir.Enabled = false;
                        txCodBarras.Clear();
                        txDescricao.Clear();
                        numQuantidade.Minimum = 1;
                        numQuantidade.Value = 1;
                        txEstoque.Clear();
                        cbLote.Items.Clear();
                        cbLote.ResetText();
                        cbLote.SelectedText = "";
                        cbLote.Enabled = false;
                        txPrecoUnitario.Clear();
                        txSubtotal.Clear();
                        this.ActiveControl = txCodBarras;
                        txCodBarras.ReadOnly = false;
                        txDescricao.ReadOnly = true;

                    }
                    else
                    {
                        Subtotal = PrecoUnitario * (float)numQuantidade.Value;
                        txSubtotal.Text = Subtotal.ToString("f2");
                        this.ActiveControl = btn_Incluir;
                        Quantidade = (float)numQuantidade.Value;
                        btn_Incluir.Enabled = true;
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
                        CarregaQuantidade();
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado.");
                        txCodBarras.Clear();
                        this.ActiveControl = txCodBarras;
                        CarregaQuantidade();
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


        /// <summary>
        /// Insere itens no data grind e insere na tabela vendas, atualiza estoque
        /// </summary>
        private void InsereItemDataGridView()
        {
            try
            {
                acessar.ItensVenda_InserirVenda(int.Parse(txNumerVenda.Text), IDProduto, IDItemProtudo, PrecoUnitario, (int)Quantidade);
                AtualizaEstoque(((int)Quantidade * (-1)), IDItemProtudo, int.Parse(txEstoque.Text));
                VizualizaDataGridView();
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

        private void VizualizaDataGridView()
        {
            try
            {
                float soma = 0;
                ViewTabeladeVendasTableAdapter vendas = new ViewTabeladeVendasTableAdapter();
                DtgDadosVenda.DataSource = vendas.RetornaViewTabelaDeVenda(int.Parse(txNumerVenda.Text));

                int rowNumber = 1;
                foreach (DataGridViewRow row in DtgDadosVenda.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.HeaderCell.Value = rowNumber.ToString();
                    rowNumber++;
                }
                DtgDadosVenda.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                
                DtgDadosVenda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                DtgDadosVenda.Columns["IDITENSVENDA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DtgDadosVenda.Columns["IDITENSVENDA"].Width = 0;
                DataGridViewColumn coluna = DtgDadosVenda.Columns["IDITENSVENDA"];
                coluna.Width = 0;
                

                for (int i = 0; i < DtgDadosVenda.Rows.Count; i++)
                {
                    float valor = float.Parse(DtgDadosVenda["PRECOUNITARIO", i].Value.ToString());
                    DtgDadosVenda["PRECOUNITARIO", i].Value = valor.ToString("f2");

                    valor = float.Parse(DtgDadosVenda["SUBTOTAL", i].Value.ToString());
                    DtgDadosVenda["SUBTOTAL", i].Value = valor.ToString("f2");
                    soma = soma + valor;
                }

                txSubtotalGeral.Text = soma.ToString("c");
                txTotalGeral.Text = soma.ToString("c");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void DtgDadosVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btn_Excluir.Enabled = true;
                int num = DtgDadosVenda.CurrentRow.Index +1;

                MessageBox.Show("Item selecionado: " + num.ToString() + "\n" + DtgDadosVenda.CurrentRow.Cells["DESCRICAO"].Value.ToString());
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F10: btnEncerrarVenda_Click(sender, e);
                        break;
                    case Keys.F4: button1_Click(sender,e);
                        break;
                    case Keys.F7: LinkLabelDesconto();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btnEncerrarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (txIdCliente.Text.Equals("") || DtgDadosVenda.Rows.Count < 1)
                {
                    MessageBox.Show("Não há venda para ser encerrada, verifique o nome ou itens...");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Deseja encerrar a venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                        double subtotal = 0;
                        for (int i = 0; i < DtgDadosVenda.Rows.Count; i++)
                        {
                            subtotal = subtotal + double.Parse(DtgDadosVenda["SUBTOTAL", i].Value.ToString());
                        }
                        int idvenda = int.Parse(txNumerVenda.Text);

                        double _desconto;

                        
                        if (txDesconto.Text.Equals(""))
                            _desconto = 0;
                        else
                            _desconto = double.Parse(txDesconto.Text);

                        int _idcliente = int.Parse(txIdCliente.Text);

                        acessar.Venda_AtualizaVendaFinalizaPorIDVenda(idvenda, subtotal, _desconto, _idcliente);
                        

                        float totalcompra = ((float)subtotal -(float)_desconto);

                        frmTipodeVenda venda = new frmTipodeVenda(idvenda, totalcompra);
                        
                        venda.ShowDialog();
                        
                        MessageBox.Show("Venda Registrada com sucesso!");
                        
                        LimpaVenda();                        
                    }
                    else
                    {
                        MessageBox.Show("Cancelado pelo usuário");
                        this.ActiveControl = txCodBarras;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Excluir item selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    int idproduto = acessar.ItensVenda_RetornaIDProduto(DtgDadosVenda.CurrentRow.Cells["DESCRICAO"].Value.ToString());
                    int quantidade = int.Parse(DtgDadosVenda.CurrentRow.Cells["QUANTIDADE"].Value.ToString());
                    string lote = DtgDadosVenda.CurrentRow.Cells["LOTE"].Value.ToString();
                    int estoque = acessar.ItensVenda_RetornaQuantidadeEstoque(lote, DtgDadosVenda.CurrentRow.Cells["DESCRICAO"].Value.ToString());
                    int iditemproduto = acessar.ItensVenda_RetornaIDItemProduto(lote,idproduto);
                    int iditensvena = int.Parse(DtgDadosVenda.CurrentRow.Cells["IDITENSVENDA"].Value.ToString());
                    AtualizaEstoque(quantidade, iditemproduto, estoque);
                    acessar.ItensVenda_DeletaItensVendaIDItemVenda(iditensvena);
                    MessageBox.Show("Item excluido.");
                    btn_Excluir.Enabled = false;
                }
                VizualizaDataGridView();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabelDesconto();
        }

        private void LinkLabelDesconto()
        {
            try
            {
                float total = 0;
                for (int i = 0; i < DtgDadosVenda.Rows.Count; i++)
                {
                    total = total + float.Parse(DtgDadosVenda["SUBTOTAL", i].Value.ToString());
                }

                float porcento = PesquisaDesconto() / total;

                MessageBox.Show("O desconto máximo nesta compra é de: \n" + PesquisaDesconto().ToString("c") + " ou " + porcento.ToString("P"));
                this.ActiveControl = txDesconto;
                txDesconto.Text = "0,00";                    
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
 
        }

        private float PesquisaDesconto()
        {
            float soma = 0;
            for (int i = 0; i < DtgDadosVenda.Rows.Count; i++)
            {
                string lote = DtgDadosVenda["LOTE",i].Value.ToString();
                int idproduto = acessar.ItensVenda_RetornaIDProduto(DtgDadosVenda["DESCRICAO",i].Value.ToString());
                int iditemproduto = acessar.ItensVenda_RetornaIDItemProduto(lote, idproduto);
                int quantidade = int.Parse(DtgDadosVenda["QUANTIDADE", i].Value.ToString());
                soma = soma + (acessar.ItensVenda_RetornaDescontoMaximoPorIDITemProduto(iditemproduto) * quantidade);
            }

            return soma;

        }

        private void txDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    float total = 0;
                    for (int i = 0; i < DtgDadosVenda.Rows.Count; i++)
                    {
                        total = total + float.Parse(DtgDadosVenda["SUBTOTAL", i].Value.ToString());
                    }

                    float desconto = float.Parse(txDesconto.Text);

                    float descontomaximo = PesquisaDesconto();

                    float verificardesconto = descontomaximo - desconto;

                    int valor = Convert.ToInt32(verificardesconto);

                    if (valor < 0)
                    {
                        DialogResult resultado = MessageBox.Show("Desconto superior ao pré-estabelecido. Confirmar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (resultado == System.Windows.Forms.DialogResult.Yes)
                        {
                            txTotalGeral.Text = (total - desconto).ToString("c");
                            this.ActiveControl = btnEncerrarVenda;
                        }
                        else
                        {
                            txDesconto.Clear();
                            txTotalGeral.Text = total.ToString("c");
                        }
                    }
                    else
                    {
                        txTotalGeral.Text = (total - desconto).ToString("c");
                        this.ActiveControl = btnEncerrarVenda;
                    }

                    
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void LimpaVenda()
        {
            txSubtotalGeral.Clear();
            txTotalGeral.Clear();
            txDesconto.Clear();
            txIdCliente.Clear();
            txTelefoneCelular.Clear();
            txTelefoneFixo.Clear();
            txNomeCliente.Clear();
            txTelefoneFixo.ReadOnly = false;
            this.ActiveControl = txTelefoneFixo;
            txNomeCliente.ReadOnly = true;
            txTelefoneCelular.ReadOnly = true;
            txDescricao.ReadOnly = true;
            cbLote.Enabled = false;
            txCodBarras.ReadOnly = true;
            numQuantidade.ReadOnly = true;
            txEstoque.ReadOnly = true;
            txCodBarras.Clear();
            txEstoque.Clear();
            cbLote.ResetText();
            numQuantidade.ResetText();
            txPrecoUnitario.Clear();
            txPrecoUnitario.ReadOnly = true;
            txSubtotal.Clear();
            txSubtotal.ReadOnly = true;
            DataTable tabelaVazia = new DataTable();
            DtgDadosVenda.DataSource = tabelaVazia;
            txNumerVenda.Clear();
            this.ActiveControl = txTelefoneFixo;
        }
    }
}
                    
                