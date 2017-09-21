using System;
using System.Windows.Forms;

namespace Técnicas_Comuns_de_Criptografia
{
    public partial class FormCA : Form
    {
        Criptografia criptografia = null;

        public FormCA()
        {
            InitializeComponent();
            criptografia = new Criptografia();
        }

        private void BtCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = criptografia.Cifrar(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FormPrincipal fp = new FormPrincipal(0);
            fp.Closed += (s, args) => Close();
            fp.Show();
        }
    }
}
