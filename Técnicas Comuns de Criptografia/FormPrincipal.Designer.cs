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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.RbCA = new System.Windows.Forms.RadioButton();
            this.RbCC = new System.Windows.Forms.RadioButton();
            this.RbCRF = new System.Windows.Forms.RadioButton();
            this.btAbrir = new System.Windows.Forms.Button();
            this.RbM = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RbCA
            // 
            this.RbCA.Checked = true;
            this.RbCA.Location = new System.Drawing.Point(61, 16);
            this.RbCA.Name = "RbCA";
            this.RbCA.Size = new System.Drawing.Size(225, 29);
            this.RbCA.TabIndex = 0;
            this.RbCA.TabStop = true;
            this.RbCA.Text = "Cifra Aditiva [Substituição]";
            this.RbCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbCA.UseVisualStyleBackColor = true;
            // 
            // RbCC
            // 
            this.RbCC.Location = new System.Drawing.Point(61, 67);
            this.RbCC.Name = "RbCC";
            this.RbCC.Size = new System.Drawing.Size(225, 29);
            this.RbCC.TabIndex = 1;
            this.RbCC.Text = "Cifra de César [Substituição]";
            this.RbCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbCC.UseVisualStyleBackColor = true;
            // 
            // RbCRF
            // 
            this.RbCRF.Location = new System.Drawing.Point(61, 109);
            this.RbCRF.Name = "RbCRF";
            this.RbCRF.Size = new System.Drawing.Size(225, 48);
            this.RbCRF.TabIndex = 2;
            this.RbCRF.Text = "Cifra Rail Fence (Zig Zag) [Transposição]";
            this.RbCRF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbCRF.UseVisualStyleBackColor = true;
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(111, 221);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(118, 30);
            this.btAbrir.TabIndex = 3;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // RbM
            // 
            this.RbM.Location = new System.Drawing.Point(61, 163);
            this.RbM.Name = "RbM";
            this.RbM.Size = new System.Drawing.Size(225, 48);
            this.RbM.TabIndex = 2;
            this.RbM.Text = "Cifra Matemática";
            this.RbM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RbM.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(338, 270);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.RbM);
            this.Controls.Add(this.RbCRF);
            this.Controls.Add(this.RbCC);
            this.Controls.Add(this.RbCA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 309);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Técnicas Comuns de Criptografia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RbCA;
        private System.Windows.Forms.RadioButton RbCC;
        private System.Windows.Forms.RadioButton RbCRF;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.RadioButton RbM;
    }
}