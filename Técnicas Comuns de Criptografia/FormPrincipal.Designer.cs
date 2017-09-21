namespace Técnicas_Comuns_de_Criptografia
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCA = new System.Windows.Forms.RadioButton();
            this.rbCC = new System.Windows.Forms.RadioButton();
            this.rbCRF = new System.Windows.Forms.RadioButton();
            this.btAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbCA
            // 
            this.rbCA.Checked = true;
            this.rbCA.Location = new System.Drawing.Point(61, 16);
            this.rbCA.Name = "rbCA";
            this.rbCA.Size = new System.Drawing.Size(225, 29);
            this.rbCA.TabIndex = 0;
            this.rbCA.TabStop = true;
            this.rbCA.Text = "Cifra Aditiva [Substituição]";
            this.rbCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCA.UseVisualStyleBackColor = true;
            // 
            // rbCC
            // 
            this.rbCC.Location = new System.Drawing.Point(61, 67);
            this.rbCC.Name = "rbCC";
            this.rbCC.Size = new System.Drawing.Size(225, 29);
            this.rbCC.TabIndex = 1;
            this.rbCC.Text = "Cifra de César [Substituição]";
            this.rbCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCC.UseVisualStyleBackColor = true;
            // 
            // rbCRF
            // 
            this.rbCRF.Location = new System.Drawing.Point(61, 109);
            this.rbCRF.Name = "rbCRF";
            this.rbCRF.Size = new System.Drawing.Size(225, 48);
            this.rbCRF.TabIndex = 2;
            this.rbCRF.Text = "Cifra Rail Fence (Zig Zag) [Transposição]";
            this.rbCRF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCRF.UseVisualStyleBackColor = true;
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(116, 182);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(118, 30);
            this.btAbrir.TabIndex = 3;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(351, 231);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.rbCRF);
            this.Controls.Add(this.rbCC);
            this.Controls.Add(this.rbCA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Técnicas Comuns de Criptografia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCA;
        private System.Windows.Forms.RadioButton rbCC;
        private System.Windows.Forms.RadioButton rbCRF;
        private System.Windows.Forms.Button btAbrir;
    }
}