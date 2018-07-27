namespace System.XML_Exemple
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFoneResidencial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlIncluir = new System.Windows.Forms.Panel();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSAlterar = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoneComercial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTelaBusca = new System.Windows.Forms.Button();
            this.btnRemoveFiltro = new System.Windows.Forms.Button();
            this.pnlIncluir.SuspendLayout();
            this.pnlAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.Location = new System.Drawing.Point(18, 84);
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(141, 20);
            this.txtFoneResidencial.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fone Residencial";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(243, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 290);
            this.listBox1.TabIndex = 12;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(449, 322);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(72, 23);
            this.btnSelecionar.TabIndex = 14;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pnlIncluir
            // 
            this.pnlIncluir.Controls.Add(this.button1);
            this.pnlIncluir.Location = new System.Drawing.Point(18, 278);
            this.pnlIncluir.Name = "pnlIncluir";
            this.pnlIncluir.Size = new System.Drawing.Size(86, 34);
            this.pnlIncluir.TabIndex = 15;
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Controls.Add(this.btnSAlterar);
            this.pnlAlterar.Location = new System.Drawing.Point(18, 274);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(141, 41);
            this.pnlAlterar.TabIndex = 16;
            this.pnlAlterar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(69, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSAlterar
            // 
            this.btnSAlterar.Location = new System.Drawing.Point(0, 0);
            this.btnSAlterar.Name = "btnSAlterar";
            this.btnSAlterar.Size = new System.Drawing.Size(63, 23);
            this.btnSAlterar.TabIndex = 0;
            this.btnSAlterar.Text = "Alterar";
            this.btnSAlterar.UseVisualStyleBackColor = true;
            this.btnSAlterar.Click += new System.EventHandler(this.btnSAlterar_Click);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(18, 242);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(219, 20);
            this.txtObs.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Observação";
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.Location = new System.Drawing.Point(18, 138);
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(141, 20);
            this.txtFoneComercial.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fone Comercial";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(18, 188);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(141, 20);
            this.txtCelular.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Celular";
            // 
            // btnTelaBusca
            // 
            this.btnTelaBusca.Location = new System.Drawing.Point(18, 375);
            this.btnTelaBusca.Name = "btnTelaBusca";
            this.btnTelaBusca.Size = new System.Drawing.Size(75, 23);
            this.btnTelaBusca.TabIndex = 23;
            this.btnTelaBusca.Text = "Buscar";
            this.btnTelaBusca.UseVisualStyleBackColor = true;
            this.btnTelaBusca.Click += new System.EventHandler(this.btnTelaBusca_Click);
            // 
            // btnRemoveFiltro
            // 
            this.btnRemoveFiltro.Location = new System.Drawing.Point(243, 321);
            this.btnRemoveFiltro.Name = "btnRemoveFiltro";
            this.btnRemoveFiltro.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveFiltro.TabIndex = 24;
            this.btnRemoveFiltro.Text = "Remover Filtro";
            this.btnRemoveFiltro.UseVisualStyleBackColor = true;
            this.btnRemoveFiltro.Visible = false;
            this.btnRemoveFiltro.Click += new System.EventHandler(this.btnRemoveFiltro_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 457);
            this.Controls.Add(this.btnRemoveFiltro);
            this.Controls.Add(this.btnTelaBusca);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFoneComercial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlAlterar);
            this.Controls.Add(this.pnlIncluir);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtFoneResidencial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlIncluir.ResumeLayout(false);
            this.pnlAlterar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button button1;
        private Windows.Forms.TextBox txtFoneResidencial;
        private Windows.Forms.Label label2;
        private Windows.Forms.TextBox txtNome;
        private Windows.Forms.Label label1;
        private Windows.Forms.ListBox listBox1;
        private Windows.Forms.Button btnDelete;
        private Windows.Forms.Button btnSelecionar;
        private Windows.Forms.Panel pnlIncluir;
        private Windows.Forms.Panel pnlAlterar;
        private Windows.Forms.Button btnCancelar;
        private Windows.Forms.Button btnSAlterar;
        private Windows.Forms.TextBox txtObs;
        private Windows.Forms.Label label3;
        private Windows.Forms.TextBox txtFoneComercial;
        private Windows.Forms.Label label4;
        private Windows.Forms.TextBox txtCelular;
        private Windows.Forms.Label label5;
        private Windows.Forms.Button btnTelaBusca;
        private Windows.Forms.Button btnRemoveFiltro;
    }
}