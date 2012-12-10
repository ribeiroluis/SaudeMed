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

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'bDSAUDEMEDDataSet.FUNCIONARIO' table. You can move, or remove it, as needed.
                this.fUNCIONARIOTableAdapter.Fill(this.bDSAUDEMEDDataSet.FUNCIONARIO);
                // TODO: This line of code loads data into the 'bDSAUDEMEDDataSet.FUNCIONARIO' table. You can move, or remove it, as needed.
                //this.fUNCIONARIOTableAdapter.Fill(this.bDSAUDEMEDDataSet.FUNCIONARIO);

                int _idfuncionario = (int)cbFuncionario.SelectedValue;

                if (acessar.RetornaseUsuarioCadastrado(_idfuncionario) == 0)
                {
                    MessageBox.Show("Usuario não cadastrado, cadastre-o!");
                }
                else
                {
                    txLogin.Text = acessar.RetornaLoginUsuario(_idfuncionario);
                    //cbControleTotal.SelectedValue = acessar.login
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja descartar as alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        public void GravarUsuario()
        {

        }

        public void AlterarUsuario()
        {

        }

        private void cbFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int _idfuncionario = (int)cbFuncionario.SelectedValue;

                if (acessar.RetornaseUsuarioCadastrado(_idfuncionario) == 0)
                {
                    MessageBox.Show("Usuario não cadastrado, cadastre-o!");
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}