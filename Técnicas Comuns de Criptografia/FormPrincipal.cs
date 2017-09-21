using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Técnicas_Comuns_de_Criptografia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(int rbCheck)
        {
            InitializeComponent();
            this.RbCheck(rbCheck);
        }

        private void RbCheck(int x)
        {
            switch (x)
            {
                case 0:
                    rbCA.Checked = true;
                    rbCC.Checked = false;
                    rbCRF.Checked = false;
                    break;
                case 1:
                    rbCA.Checked = false;
                    rbCC.Checked = true;
                    rbCRF.Checked = false;
                    break;
                case 2:
                    rbCA.Checked = false;
                    rbCC.Checked = false;
                    rbCRF.Checked = true;
                    break;
                default:
                    rbCA.Checked = true;
                    rbCC.Checked = false;
                    rbCRF.Checked = false;
                    break;
            }
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            if (rbCA.Checked)
            {
                Hide();
                FormCA fca = new FormCA();
                fca.Closed += (s, args) => Close();
                fca.Show();
            }
            else if (rbCC.Checked)
            {
                Hide();
                FormCC fcc = new FormCC();
                fcc.Closed += (s, args) => Close();
                fcc.Show();
            }
            else if (rbCRF.Checked)
            {
                Hide();
                FormCRF fcrf = new FormCRF();
                fcrf.Closed += (s, args) => Close();
                fcrf.Show();
            }
        }
    }
}
