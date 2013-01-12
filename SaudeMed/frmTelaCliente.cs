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
    public partial class frmTelaCliente : frmModelo
    {

        AcessaDados acessar = new AcessaDados();
        int IDFUNCIONARIO;
        private string UltimoNome;

        public string RetornaUltimoNome
        {
            get { return UltimoNome; }
            set { UltimoNome = value; }
        }

        public frmTelaCliente(int idfuncionario)
        {
            InitializeComponent();
            IDFUNCIONARIO = idfuncionario;
        }

        private void frmTelaVendas_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txTelefoneFixo;
        }

        public void RecebeDadosClientes(string cel, string tel, string nome)
        {
            txTelefoneCelular.Enabled = true;
            txTelefoneCelular.Text = cel;
            txTelefoneFixo.Enabled = true;
            txTelefoneFixo.Text = tel;
            txNomeCliente.Enabled = true;
            txNomeCliente.Text = nome.ToUpper();
            txCEP.Enabled = true;
            this.ActiveControl = txCEP;
        }

        private void txTelefoneFixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txTelefoneFixo.Text.Equals(""))
                    {
                        txTelefoneCelular.Enabled = true;
                        this.ActiveControl = txTelefoneCelular;
                    }
                    else
                    {
                        if (TestaClienteTelefone(txTelefoneFixo.Text))
                        {
                            DialogResult resultado = MessageBox.Show("Já exite telefone cadastrado.\nDeseja cadastrar outro usuário com o mesmo telefone?", 
                                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resultado == System.Windows.Forms.DialogResult.Yes)
                            {
                                txTelefoneCelular.Enabled = true;
                                this.ActiveControl = txTelefoneCelular;
                            }
                            else
                            {
                                PreencheCampos(txTelefoneFixo.Text, "");
                            }
                        }
                        else
                        {
                            txTelefoneCelular.Enabled = true;
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

        private void txTelefoneCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txTelefoneCelular.Text.Equals(""))
                    {
                        txNomeCliente.Enabled = true;
                        GeraCoustomSourceCliente();
                        this.ActiveControl = txNomeCliente;
                    }
                    else
                    {
                        if (TestaClienteTelefone(txTelefoneCelular.Text))
                        {
                             DialogResult resultado = MessageBox.Show("Já exite telefone cadastrado.\nDeseja cadastrar outro usuário com o mesmo telefone?", 
                                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                             if (resultado == System.Windows.Forms.DialogResult.Yes)
                             {
                                 txNomeCliente.Enabled = true;
                                 GeraCoustomSourceCliente();
                                 this.ActiveControl = txNomeCliente;
                             }
                             else
                                 PreencheCampos(txTelefoneCelular.Text, "");
                            
                        }
                        else
                        {
                            txNomeCliente.Enabled = true;
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

        private bool TestaCliente(string parametro)
        {
            try
            {
                var tabela = acessar.Cliente_RetornaTabelaClientePorNome(parametro);
                if (tabela.Rows.Count == 1)
                    return true;
                else
                {
                    btnGravar.Text = "Incluir";
                    btnGravar.Enabled = true;
                    return false;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return false;
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
                UltimoNome = txNomeCliente.Text;
                txCPF.Text = tabela.Rows[0][2].ToString();
                txTelefoneFixo.Text = tabela.Rows[0][3].ToString();
                txTelefoneCelular.Text = tabela.Rows[0][4].ToString();
                txCEP.Text = tabela.Rows[0][5].ToString();
                PreencheCamposCEP();
                txNumero.Text = tabela.Rows[0][6].ToString();
                txComplemento.Text = tabela.Rows[0][7].ToString();

                linkLabel1.Enabled = false;
                txIdCliente.Enabled = false;
                txNomeCliente.Enabled = false;
                txCPF.Enabled = false;
                txTelefoneFixo.Enabled = false;
                txTelefoneCelular.Enabled = false;
                txCEP.Enabled = false;
                txNumero.Enabled = false;
                txComplemento.Enabled = false;
                btnEditar.Enabled = true;
                //this.ActiveControl
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
                try
                {
                    txNumero.Enabled = true;
                    this.ActiveControl = txNumero;
                    PreencheCamposCEP();
                }
                catch (Exception err)
                {
                    MessageBox.Show("CEP não localizado!" + err.Message);
                    frmPesquisaCEP pesquisa = new frmPesquisaCEP();
                    pesquisa.ShowDialog();
                    txCEP.Text = pesquisa.CEP;
                    pesquisa.Close();
                    PreencheCamposCEP();
                }

            }
        }

        private void PreencheCamposCEP()
        {
            txEndereco.Text = acessar.Endereco_RetornaLogradouroporCEP(int.Parse(txCEP.Text));
            txBairro.Text = acessar.Endereco_RetornaBairroporCEP(int.Parse(txCEP.Text));
            txCidade.Text = acessar.Endereco_RetornaCidadeporCEP(int.Parse(txCEP.Text));
            this.ActiveControl = txNumero;
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

            linkLabel1.Enabled = true;

            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPesquisaCEP pesquisa = new frmPesquisaCEP();
            pesquisa.ShowDialog();
            txCEP.Text = pesquisa.CEP;
            PreencheCamposCEP();
            pesquisa.Close();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGravar.Enabled = true;
            btnGravar.Text = "Gravar";
            btnExcluir.Enabled = true;
            txTelefoneCelular.Enabled = true;
            txTelefoneFixo.Enabled = true;
            txNomeCliente.Enabled = true;
            txCPF.Enabled = true;
            txCEP.Enabled = true;
            txNumero.Enabled = true;
            txComplemento.Enabled = true;
            linkLabel1.Enabled = true;
            this.ActiveControl = btnGravar;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int idcliente = 0;
            
            if (!txIdCliente.Text.Equals(""))
                idcliente = int.Parse(txIdCliente.Text);

            string nomecliente = txNomeCliente.Text.ToUpper();
            UltimoNome = txNomeCliente.Text.ToUpper();
            string cpf = txCPF.Text;
            string telfixo = txTelefoneFixo.Text;
            string telcel = txTelefoneCelular.Text;
            int cep = int.Parse(txCEP.Text);            
            int numero = int.Parse(txNumero.Text);
            string complemento = txComplemento.Text.ToUpper();
            
            try
            {
                if (btnGravar.Text.Equals("Gravar"))
                    acessar.Cliente_AtualizarCliente(nomecliente, cpf, telfixo, telcel, numero, complemento, cep, idcliente);
                else
                    acessar.Cliente_IserirNovoCliente(nomecliente, cpf, telfixo, telcel, numero, complemento, cep);

                btnLimpar_Click(sender, e);
                PreencheCampos("", nomecliente);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                acessar.Cliente_ExcluirCliente(int.Parse(txIdCliente.Text));
                MessageBox.Show("Cliente excluido com sucesso!");
            }
            else
                MessageBox.Show("Operação cancelada pelo usuário");

            btnLimpar_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTelaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4: this.Close();
                    break;                
                default:
                    break;
            }
        }       

    }
}
