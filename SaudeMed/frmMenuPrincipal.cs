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
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void gerenciarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario usuarios = new frmCadastrarUsuario();            
            usuarios.Show();
        }

        private void gerenciarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraFuncionario funcionarios = new frmCadastraFuncionario();
            funcionarios.Show();
        }
    }
}
