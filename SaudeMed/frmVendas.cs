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
    public partial class frmVendas : frmModelo
    {
        AcessaDados acessar = new AcessaDados();
        int IdFuncionario;
        public frmVendas( int idfuncionario)
        {
            InitializeComponent();
            IdFuncionario = idfuncionario;
        }

        private void txTelefoneFixo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txTelefoneFixo.Text.Equals(""))
                {
                    txTelefoneCelular.ReadOnly = false;
                    this.ActiveControl = txTelefoneCelular;
                }
                else
                {
                    if (TestaClienteTelefone(txTelefoneFixo.Text))
                    {
                        PreencheCampos(txTelefoneFixo.Text, "");
                    }

                    else
                    {
                        txTelefoneCelular.ReadOnly = false;
                        this.ActiveControl = txTelefoneCelular;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txTelefoneCelular_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txTelefoneCelular.Text.Equals(""))
                    {
                        txNomeCliente.ReadOnly = false;
                        GeraCoustomSourceCliente();
                        this.ActiveControl = txNomeCliente;
                    }
                    else
                    {
                        if (TestaClienteTelefone(txTelefoneCelular.Text))
                        {
                            PreencheCampos(txTelefoneCelular.Text, "");
                        }
                        else
                        {
                            txNomeCliente.ReadOnly = false;
                            GeraCoustomSourceCliente();
                            this.ActiveControl = txNomeCliente;
                        }
                    }

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private bool TestaClienteTelefone(string parametro)
        {

            try
            {
                var testa = acessar.Cliente_RetornDataTablePorTelefone(parametro);
                if (testa.Rows.Count > 1)
                {
                    MessageBox.Show("Mais de um cliente cadastrado para o telefone, procure pelo nome ou celular.");
                    txNomeCliente.Enabled = true;
                    GeraCoustomSourceCliente();
                    this.ActiveControl = txNomeCliente;
                    return false;
                }
                else if (testa.Rows.Count == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return false;
            }
        }

        private void GeraCoustomSourceCliente()
        {
            txNomeCliente.AutoCompleteCustomSource.Clear();
            try
            {
                DataTable table = acessar.Cliente_RetornaTabelaCliente();
                foreach (DataRow row in table.Rows)
                {
                    string aux = (string)row[1];
                    txNomeCliente.AutoCompleteCustomSource.Add(aux);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PreencheCampos(string telefone, string nome)
        {
            try
            {
                DataTable tabela = new DataTable();


                if (!telefone.Equals(""))
                {
                    tabela = acessar.Cliente_RetornDataTablePorTelefone(telefone);
                }
                else
                    tabela = acessar.Cliente_RetornaTabelaClientePorNome(nome);

                txIdCliente.Text = tabela.Rows[0][0].ToString();
                txNomeCliente.Text = tabela.Rows[0][1].ToString();
                txTelefoneFixo.Text = tabela.Rows[0][3].ToString();
                txTelefoneCelular.Text = tabela.Rows[0][4].ToString();
                txIdCliente.Enabled = false;
                txNomeCliente.Enabled = false;
                txTelefoneFixo.Enabled = false;
                txTelefoneCelular.Enabled = false;
                this.ActiveControl = txCodBarras;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (TestaCliente(txNomeCliente.Text))
                    {
                        PreencheCampos("", txNomeCliente.Text);                        
                    }
                    else
                    {

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        private bool TestaCliente(string parametro)
        {
            try
            {
                var tabela = acessar.Cliente_RetornaTabelaClientePorNome(parametro);
                if (tabela.Rows.Count == 1)
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return false;
            }
        }


        


    }
}
