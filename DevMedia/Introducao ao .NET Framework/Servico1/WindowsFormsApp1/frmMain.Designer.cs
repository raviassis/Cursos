namespace WindowsFormsApp1
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
            this.btnInvocarWebService = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvocarWebService
            // 
            this.btnInvocarWebService.Location = new System.Drawing.Point(12, 12);
            this.btnInvocarWebService.Name = "btnInvocarWebService";
            this.btnInvocarWebService.Size = new System.Drawing.Size(141, 23);
            this.btnInvocarWebService.TabIndex = 0;
            this.btnInvocarWebService.Text = "Invocar Web Service";
            this.btnInvocarWebService.UseVisualStyleBackColor = true;
            this.btnInvocarWebService.Click += new System.EventHandler(this.btnInvocarWebService_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(13, 64);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(217, 20);
            this.txtMensagem.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 248);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnInvocarWebService);
            this.Name = "frmMain";
            this.Text = "Cliente Web Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvocarWebService;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

