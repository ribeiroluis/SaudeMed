using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SaudeMed
{
    public partial class ComponenteTextbox : Component
    {
        public ComponenteTextbox()
        {
            InitializeComponent();
        }

        public ComponenteTextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textBox1_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {

        }
    }
}
