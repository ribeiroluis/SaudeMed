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
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDSAUDEMEDDataSet.FUNCIONARIO' table. You can move, or remove it, as needed.
            this.fUNCIONARIOTableAdapter.Fill(this.bDSAUDEMEDDataSet.FUNCIONARIO);
            // TODO: This line of code loads data into the 'bDSAUDEMEDDataSet.FUNCIONARIO' table. You can move, or remove it, as needed.
            //this.fUNCIONARIOTableAdapter.Fill(this.bDSAUDEMEDDataSet.FUNCIONARIO);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
   
        }
    }
}
