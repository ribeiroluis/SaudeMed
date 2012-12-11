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
    public partial class frmCadastrarUsuario : frmModelo
    {

        AcessaDados acessar = new AcessaDados();

        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txSenha.Text.Equals(txConfirmarSenha.Text))
                {
                    if (acessar.Usuarios_RetornaLoginUsuario(txLogin.Text))
                    {
                        if (cbControleTotal.SelectedItem.ToString().Equals("SIM"))
                        {
                            DialogResult Resultado2 = MessageBox.Show("Liberar total acesso?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (Resultado2 == System.Windows.Forms.DialogResult.Yes)
                            {
                                acessar.Usuarios_Editar((int)cb_fucionario.SelectedValue, txLogin.Text, txSenha.Text, true);
                            }
                            else
                            {
                                acessar.Usuarios_Editar((int)cb_fucionario.SelectedValue, txLogin.Text, txSenha.Text, false);
                            }
                            //fim if5
                        }//fim if4
                        else
                        {
                            acessar.Usuarios_Editar((int)cb_fucionario.SelectedValue, txLogin.Text, txSenha.Text, false);
                        }
                    }//fim if3
                    //fim if 
                    else
                    {
                        if (cbControleTotal.SelectedItem.ToString().Equals("SIM"))
                        {
                            DialogResult Resultado3 = MessageBox.Show("Liberar total acesso?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (Resultado3 == System.Windows.Forms.DialogResult.Yes)
                            {
                                acessar.Usuarios_Gravar((int)cb_fucionario.SelectedValue, txLogin.Text, txSenha.Text, true);
                            }
                            else
                            {
                                acessar.Usuarios_Gravar((int)cb_fucionario.SelectedValue, txLogin.Text, txSenha.Text, false);
                            }
                        }
                        else
                        {
                            acessar.Usuarios_Gravar((int)cb_fucionario.SelectedValue, txLogin.Text, txSenha.Text, false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não conferem, verifique!");
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            finally
            {
                txLogin.Clear();
                txConfirmarSenha.Clear();
                txSenha.Clear();
                cbControleTotal.Refresh();
            }
            
        }

        public void verificaUsuarioCadastrado()
        {
            txLogin.Text = acessar.Usuarios_RetornaLoginPorIDFuncionario((int)cb_fucionario.SelectedValue);
            if (!txLogin.Text.Equals(""))
            {
                MessageBox.Show("Já existe este login cadastrado, para o selecionado", "Atenção");
                txIDLogin.Text = acessar.Usuarios_RetornaIDLogin((int)cb_fucionario.SelectedValue).ToString();
            }
        }
        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSAUDEMEDDataSet.FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOTableAdapter.Fill(this.bDSAUDEMEDDataSet.FUNCIONARIO);
            verificaUsuarioCadastrado();
        }

        private void cb_fucionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificaUsuarioCadastrado();
        }
    }
}