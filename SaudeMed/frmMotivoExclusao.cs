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
    public partial class frmMotivoExclusao : frmModelo
    {
        int _idproduto, _iditem, _quantidade, _idfuncionario;

        public frmMotivoExclusao(int idproduto, int iditem, int quantidade, int idfuncionario)
        {
            InitializeComponent();
            _idproduto = idproduto;
            _iditem = iditem;
            _quantidade = quantidade;
            _idfuncionario = idfuncionario;
        }

        public string retornaMotivo()
        {
            return txMotivo.Text;
        }

        private void BtnIncluirItens_Click(object sender, EventArgs e)
        {
            try
            {
                if (txMotivo.Text.Length < 3)
                    MessageBox.Show("Descreva melhor o motivo!");
                else
                {
                    AcessaDados acesso = new AcessaDados();
                    DateTime hoje = DateTime.Now;
                    acesso.ItensDescartados_InsereExclusao(_idproduto, _iditem, _quantidade, hoje, _idfuncionario, txMotivo.Text);
                    this.Close();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }            
        }

        private void txMotivo_TextChanged(object sender, EventArgs e)
        {
            BtnIncluirItens.Enabled = true;
        }

    }
}
