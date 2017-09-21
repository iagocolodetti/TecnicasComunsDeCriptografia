namespace Técnicas_Comuns_de_Criptografia
{
    partial class FormCRF
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRF));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btCifrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btDecifrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCifrar
            // 
            this.btCifrar.Location = new System.Drawing.Point(39, 65);
            this.btCifrar.Name = "btCifrar";
            this.btCifrar.Size = new System.Drawing.Size(132, 27);
            this.btCifrar.TabIndex = 2;
            this.btCifrar.Text = "Cifrar";
            this.btCifrar.UseVisualStyleBackColor = true;
            this.btCifrar.Click += new System.EventHandler(this.BtCifrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(314, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDecifrar
            // 
            this.btDecifrar.Location = new System.Drawing.Point(221, 65);
            this.btDecifrar.Name = "btDecifrar";
            this.btDecifrar.Size = new System.Drawing.Size(132, 27);
            this.btDecifrar.TabIndex = 3;
            this.btDecifrar.Text = "Decifrar";
            this.btDecifrar.UseVisualStyleBackColor = true;
            this.btDecifrar.Click += new System.EventHandler(this.BtDecifrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(132, 157);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(132, 27);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // FormCRF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(394, 204);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btDecifrar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btCifrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCRF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifra Rail Fence (Zig Zag)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btCifrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btDecifrar;
        private System.Windows.Forms.Button btVoltar;
    }
}

