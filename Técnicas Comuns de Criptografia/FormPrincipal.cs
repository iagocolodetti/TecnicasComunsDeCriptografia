using System;
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
                    RbCXOR.Checked = true;
                    RbCC.Checked = false;
                    RbCRF.Checked = false;
                    RbCM.Checked = false;
                    break;
                case 1:
                    RbCXOR.Checked = false;
                    RbCC.Checked = true;
                    RbCRF.Checked = false;
                    RbCM.Checked = false;
                    break;
                case 2:
                    RbCXOR.Checked = false;
                    RbCC.Checked = false;
                    RbCRF.Checked = true;
                    RbCM.Checked = false;
                    break;
                case 3:
                    RbCXOR.Checked = false;
                    RbCC.Checked = false;
                    RbCRF.Checked = false;
                    RbCM.Checked = true;
                    break;
                default:
                    RbCXOR.Checked = true;
                    RbCC.Checked = false;
                    RbCRF.Checked = false;
                    RbCM.Checked = false;
                    break;
            }
        }

        private void BtAbrir_Click(object sender, EventArgs e)
        {
            if (RbCXOR.Checked)
            {
                Hide();
                FormCXOR fcxor = new FormCXOR();
                fcxor.Closed += (s, args) => Close();
                fcxor.Show();
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
            else if (RbCM.Checked)
            {
                Hide();
                FormCM fcm = new FormCM();
                fcm.Closed += (s, args) => Close();
                fcm.Show();
            }
        }
    }
}
