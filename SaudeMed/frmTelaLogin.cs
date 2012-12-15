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
    public partial class frmTelaLogin : frmModelo
    {

        AcessaDados acessar = new AcessaDados();

        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (acessar.Usuarios_RetornaUsuarioValido(txLogin.Text, txSenha.Text))
                {
                    bool acesso = acessar.Usuarios_RetornaAcessoUsuario(txLogin.Text);
                    int IdFuncionario = acessar.Usuarios_RetornaIDFuncionario(txLogin.Text);
                    this.Visible = false;
                    string nome = acessar.Usuarios_RetornaNome(IdFuncionario);
                    frmMenuPrincipal menu = new frmMenuPrincipal(acesso, IdFuncionario, nome);
                    menu.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Usuário ou senha incorreta!");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
