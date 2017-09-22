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

        private void BtLimparResultado_Click(object sender, EventArgs e)
        {
            RtbResultado.Clear();
        }

        private void BtCifrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TbDeslocamento.Text))
                {
                    if (int.TryParse(TbDeslocamento.Text, out int k))
                    {
                         RtbResultado.Text = criptografia.Cifrar(RtbTexto.Text, k);
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
                if (!string.IsNullOrEmpty(TbDeslocamento.Text))
                {
                    if (int.TryParse(TbDeslocamento.Text, out int k))
                    {
                        RtbResultado.Text = criptografia.Decifrar(RtbTexto.Text, k);
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
