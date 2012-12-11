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
    public partial class frmTelaSplash : frmModelo
    {
        public frmTelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 5;
            else if (progressBar1.Value == 100)
            {
                this.Visible = false;
                timer1.Enabled = false;
                telaLogin();
            }
        }
        private void telaLogin()
        {
            frmTelaLogin login = new frmTelaLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
