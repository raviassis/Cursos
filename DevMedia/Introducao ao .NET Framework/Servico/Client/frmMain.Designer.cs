namespace Client
{
    partial class frmMain
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnInvocarServico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(34, 86);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(218, 20);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnInvocarServico
            // 
            this.btnInvocarServico.Location = new System.Drawing.Point(34, 34);
            this.btnInvocarServico.Name = "btnInvocarServico";
            this.btnInvocarServico.Size = new System.Drawing.Size(101, 23);
            this.btnInvocarServico.TabIndex = 1;
            this.btnInvocarServico.Text = "Invocar Servico";
            this.btnInvocarServico.UseVisualStyleBackColor = true;
            this.btnInvocarServico.Click += new System.EventHandler(this.btnInvocarServico_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 134);
            this.Controls.Add(this.btnInvocarServico);
            this.Controls.Add(this.txtMensagem);
            this.Name = "frmMain";
            this.Text = "Cliente - WCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnInvocarServico;
    }
}

