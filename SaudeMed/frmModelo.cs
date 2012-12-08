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
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario cadastrarUsuario = new frmCadastrarUsuario();
            cadastrarUsuario.MdiParent = this;
            cadastrarUsuario.Show();
        }
    }
}
