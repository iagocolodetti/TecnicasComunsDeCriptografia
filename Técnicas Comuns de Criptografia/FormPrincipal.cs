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
            RbCheck(rbCheck);
        }

        private void RbCheck(int x)
        {
            switch (x)
            {
                case 0:
                    RbCA.Checked = true;
                    RbCC.Checked = false;
                    RbCRF.Checked = false;
                    RbM.Checked = false;
                    break;
                case 1:
                    RbCA.Checked = false;
                    RbCC.Checked = true;
                    RbCRF.Checked = false;
                    RbM.Checked = false;
                    break;
                case 2:
                    RbCA.Checked = false;
                    RbCC.Checked = false;
                    RbCRF.Checked = true;
                    RbM.Checked = false;
                    break;
                case 3:
                    RbCA.Checked = false;
                    RbCC.Checked = false;
                    RbCRF.Checked = false;
                    RbM.Checked = true;
                    break;
                default:
                    RbCA.Checked = true;
                    RbCC.Checked = false;
                    RbCRF.Checked = false;
                    RbM.Checked = false;
                    break;
            }
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            if (RbCA.Checked)
            {
                Hide();
                FormCA fca = new FormCA();
                fca.Closed += (s, args) => Close();
                fca.Show();
            }
            else if (RbCC.Checked)
            {
                Hide();
                FormCC fcc = new FormCC();
                fcc.Closed += (s, args) => Close();
                fcc.Show();
            }
            else if (RbCRF.Checked)
            {
                Hide();
                FormCRF fcrf = new FormCRF();
                fcrf.Closed += (s, args) => Close();
                fcrf.Show();
            }
            else if (RbM.Checked)
            {
                Hide();
                FormM fm = new FormM();
                fm.Closed += (s, args) => Close();
                fm.Show();
            }
        }
    }
}
