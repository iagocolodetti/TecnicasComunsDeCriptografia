using System;
using System.Windows.Forms;

namespace Técnicas_Comuns_de_Criptografia
{
    public partial class FormCC : Form
    {
        Criptografia criptografia = null;

        public FormCC()
        {
            InitializeComponent();
            criptografia = new Criptografia();
        }

        private void BtCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    if (int.TryParse(textBox2.Text, out int k))
                    {
                         textBox3.Text = criptografia.Cifrar(textBox1.Text, k);
                    }
                    else MessageBox.Show("Use um inteiro para deslocamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Digite um número inteiro para efetuar o deslocamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    if (int.TryParse(textBox2.Text, out int k))
                    {
                        textBox3.Text = criptografia.Decifrar(textBox1.Text, k);
                    }
                    else MessageBox.Show("Use um inteiro para deslocamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Digite um número inteiro para efetuar o deslocamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FormPrincipal fp = new FormPrincipal(1);
            fp.Closed += (s, args) => Close();
            fp.Show();
        }
    }
}
