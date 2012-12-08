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
    public partial class frmCadastraFuncionario : frmModelo
    {

        AcessaDados acessar = new AcessaDados();

        public frmCadastraFuncionario()
        {
            InitializeComponent();
        }

        private void mskCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int cep = int.Parse(mskCEP.Text);
                    txEndereco.Text = acessar.RetornaLogradouroporCEP(cep);
                    txCidade.Text = acessar.RetornaCidadeporCEP(cep);
                    txBairro.Text = acessar.RetornaBairroporCEP(cep);
                    this.SelectNextControl(this.ActiveControl, false, true, true, true);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message); ;
            }
        }

        private void frmCadastraFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDados.DataSource = acessar.RetornaTabelaFuncionarios();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txNomeFuncionario.Text.Equals(acessar.RetornaNomeJaCadastrado(txNomeFuncionario.Text)))
                {
                    MessageBox.Show("Nome já casatrado, experimente editar");
                }
                else
                {
                    string _nome = txNomeFuncionario.Text.ToUpper();
                    int _cep = int.Parse(mskCEP.Text);
                    int _numero = int.Parse(txNumero.Text);
                    string _complemento = txComplemento.Text.ToUpper();
                    string _telfixo = mskTelefoneFixo.Text;
                    string _telcel = mskTelefoneCelular.Text;
                    string _cpf = mskCPF.Text;
                    string _id = txIdentidade.Text.ToUpper();
                    string _dtNascimento = dateDataNascimento.Value.ToShortDateString();
                    string _dtAdmissao = dateAdmissao.Value.ToShortDateString();
                    string _funcao = txFuncao.Text.ToUpper();
                    string _regprof = txRegistroProfissional.Text.ToUpper();
                    acessar.Gravar(_nome, _cep, _numero, _complemento, _telfixo, _telcel, _cpf, _id, _dtNascimento, _dtAdmissao, _funcao, _regprof);
                    btnGravar.Enabled = false;
                    txNomeFuncionario.Clear();
                    mskCEP.Clear();
                    //continuar
                    frmCadastraFuncionario_Load(sender, e); 
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString()); ;
            }
        }

        private bool VerificaCampos()
        {
            if (txNomeFuncionario.Text != null)
                return false;
            else
                return true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgDados.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); ;
            }

        }

        private void txNomeFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string nome = txNomeFuncionario.Text;
                txNomeFuncionario.Clear();
                txNomeFuncionario.Text = nome.ToUpper();
                string testanome = acessar.RetornaNomeJaCadastrado(nome);
                if (testanome.Equals(txNomeFuncionario.Text))
                {
                    if (btnExcluir.Enabled || btnEditar.Enabled)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nome já cadastrado! Experimente listar.");
                    }
                }
                else
                {
                    if (txNomeFuncionario.Text.Equals(""))
                    {
                        MessageBox.Show("Digite o nome!");
                    }
                    else
                    {
                        this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                        if (btnExcluir.Enabled || btnEditar.Enabled)
                            btnGravar.Enabled = false;
                        else                       
                            btnGravar.Enabled = true;
                    }
                }

            }
        }

        private void txNomeFuncionario_Leave(object sender, EventArgs e)
        {
            try
            {
                string nome = txNomeFuncionario.Text;
                txNomeFuncionario.Clear();
                txNomeFuncionario.Text = nome.ToUpper();
                string testanome = acessar.RetornaNomeJaCadastrado(nome);
                if (testanome.Equals(txNomeFuncionario.Text))
                {
                    if (btnExcluir.Enabled || btnEditar.Enabled)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nome já cadastrado! Experimente listar.");
                    }
                }
                else
                {
                    if (txNomeFuncionario.Text.Equals(""))
                    {
                        MessageBox.Show("Digite o nome!");
                    }
                    else
                    {
                        btnGravar.Enabled = true;
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dtgDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            txBairro.Text = dtgDados.CurrentRow.Cells["Bairro"].Value.ToString();
            txCidade.Text = dtgDados.CurrentRow.Cells["Cidade"].Value.ToString();
            txComplemento.Text = dtgDados.CurrentRow.Cells["Comp"].Value.ToString();
            txEndereco.Text = dtgDados.CurrentRow.Cells["End"].Value.ToString();
            txFuncao.Text = dtgDados.CurrentRow.Cells["Função"].Value.ToString();
            txIdentidade.Text = dtgDados.CurrentRow.Cells["Identidade"].Value.ToString();
            txIdFuncionario.Text = dtgDados.CurrentRow.Cells["Id"].Value.ToString();
            txNomeFuncionario.Text = dtgDados.CurrentRow.Cells["Nome"].Value.ToString();
            txNumero.Text = dtgDados.CurrentRow.Cells[5].Value.ToString();
            txRegistroProfissional.Text = dtgDados.CurrentRow.Cells["Reg Profissional"].Value.ToString();
            mskCEP.Text = dtgDados.CurrentRow.Cells["CEP"].Value.ToString();
            mskCPF.Text = dtgDados.CurrentRow.Cells["CPF"].Value.ToString();
            mskTelefoneCelular.Text = dtgDados.CurrentRow.Cells["Tel Celular"].Value.ToString();
            mskTelefoneFixo.Text = dtgDados.CurrentRow.Cells["Tel Fixo"].Value.ToString();
        }
        private void LimparCampos()
        {   
            txBairro.Clear();
            txCidade.Clear();
            txComplemento.Clear();
            txEndereco.Clear();
            txFuncao.Clear();
            txIdentidade.Clear();
            txIdFuncionario.Clear();
            txNomeFuncionario.Clear();
            txNumero.Clear();
            txRegistroProfissional.Clear();
            mskCEP.Clear();
            mskCPF.Clear();
            mskTelefoneCelular.Clear();
            mskTelefoneFixo.Clear();              
 
        }
    }
}
