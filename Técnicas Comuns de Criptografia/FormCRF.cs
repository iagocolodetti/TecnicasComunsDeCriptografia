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

        private void BtCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = criptografia.Cifrar(textBox1.Text);
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
                textBox2.Text = criptografia.Decifrar(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
