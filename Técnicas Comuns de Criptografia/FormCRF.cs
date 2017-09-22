using System;
using System.Windows.Forms;

namespace Técnicas_Comuns_de_Criptografia
{
    public partial class FormCRF : Form
    {
        Criptografia criptografia = null;

        public FormCRF()
        {
            InitializeComponent();
            criptografia = new Criptografia();
        }

        private void BtInverter_Click(object sender, EventArgs e)
        {
            string aux = RtbTexto.Text;
            RtbTexto.Text = RtbResultado.Text;
            RtbResultado.Text = aux;
        }

        private void BtLimparTexto_Click(object sender, EventArgs e)
        {
            RtbTexto.Clear();
        }

        private void BtCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                RtbResultado.Text = criptografia.Cifrar(RtbTexto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDecifrar_Click(object sender, EventArgs e)
        {
            try
            {
                RtbResultado.Text = criptografia.Decifrar(RtbTexto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtLimparResultado_Click(object sender, EventArgs e)
        {
            RtbResultado.Clear();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FormPrincipal fp = new FormPrincipal(2);
            fp.Closed += (s, args) => Close();
            fp.Show();
        }
    }
}
