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
    public partial class frmMenuPrincipal : frmModelo
    {
        bool acessoTotal;
        public frmMenuPrincipal(bool acesso, int idFuncionario)
        {
            InitializeComponent();
            acessoTotal = acesso;
            LiberaAcessos();
        }

        private void gerenciarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario usuarios = new frmCadastrarUsuario();            
            usuarios.ShowDialog();
        }

        private void gerenciarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraFuncionario funcionarios = new frmCadastraFuncionario();
            funcionarios.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LiberaAcessos()
        {
            if (acessoTotal == false)
            {
                SubMenuFechamentoDia.Enabled = false;
                SubMenuGerenciarFuncionarios.Enabled = false;
                SubMenuGerenciarProdutos.Enabled = false;
                SubMenuGerenciarUsuarios.Enabled = false;
                SubMenuQuantItens.Enabled = false;
            }
        }
    }
}
