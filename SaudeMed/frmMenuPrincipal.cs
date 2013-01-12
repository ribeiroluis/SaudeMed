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
        int IDFUNCIONARIO;
        AcessaDados acessar = new AcessaDados();

        public frmMenuPrincipal(bool acesso, int idFuncionario, string nome)
        {
            InitializeComponent();
            acessoTotal = acesso;
            LiberaAcessos();
            IDFUNCIONARIO = idFuncionario;
            lbNomeUsuario.Text = "Olá  " + nome;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            lbDataHora.Text = hora.ToLongDateString() + " - "+hora.ToLongTimeString();
        }

        private void SubMenuGerenciarProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos(IDFUNCIONARIO);
            produtos.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas venda = new frmVendas(IDFUNCIONARIO);
            venda.ShowDialog();
        }

        private void SubMenuFechamentoDia_Click(object sender, EventArgs e)
        {
            frmRelatorioFechamentoDia relatoriodia = new frmRelatorioFechamentoDia();
            relatoriodia.ShowDialog();
        }

        private void frmMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10: vendaToolStripMenuItem_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
