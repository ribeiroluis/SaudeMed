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
    public partial class frmRelatorioFechamentoDia : frmModelo
    {
        public frmRelatorioFechamentoDia()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaRelatorio();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void CarregaRelatorio()
        {
            VENDATableAdapter venda = new VENDATableAdapter();
            DtgDados.DataSource = venda.RetornaDatatableViewFechamentodoDia(DataMovimento.Value.ToShortDateString());

            for (int i = 0; i < DtgDados.Rows.Count; i++)
            {
                float valor = float.Parse(DtgDados["SUBTOTAL", i].Value.ToString());
                DtgDados["SUBTOTAL", i].Value = valor.ToString("f2");

                valor = float.Parse(DtgDados["DESCONTO", i].Value.ToString());
                DtgDados["DESCONTO", i].Value = valor.ToString("f2");

                valor = float.Parse(DtgDados["TOTALVENDA", i].Value.ToString());
                DtgDados["TOTALVENDA", i].Value = valor.ToString("f2");

            }




        }
    }
}
