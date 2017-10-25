namespace ImobiliariaLP2.Visão
{
    partial class ImovelV
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lbMetragem = new System.Windows.Forms.Label();
            this.textBoxMetragem = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(55, 24);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID: ";
            // 
            // lbTipo
            // 
            this.lbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(45, 71);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(34, 13);
            this.lbTipo.TabIndex = 1;
            this.lbTipo.Text = "Tipo: ";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(338, 24);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(58, 13);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxID.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxID.Location = new System.Drawing.Point(85, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(33, 20);
            this.textBoxID.TabIndex = 18;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Casa",
            "Apartemento",
            "Terreno"});
            this.comboBoxTipo.Location = new System.Drawing.Point(85, 68);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipo.TabIndex = 4;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Venda",
            "Aluguel"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(402, 20);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // lbMetragem
            // 
            this.lbMetragem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbMetragem.AutoSize = true;
            this.lbMetragem.Location = new System.Drawing.Point(191, 73);
            this.lbMetragem.Name = "lbMetragem";
            this.lbMetragem.Size = new System.Drawing.Size(60, 13);
            this.lbMetragem.TabIndex = 19;
            this.lbMetragem.Text = "Metragem: ";
            // 
            // textBoxMetragem
            // 
            this.textBoxMetragem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxMetragem.Location = new System.Drawing.Point(257, 69);
            this.textBoxMetragem.Name = "textBoxMetragem";
            this.textBoxMetragem.Size = new System.Drawing.Size(87, 20);
            this.textBoxMetragem.TabIndex = 20;
            // 
            // lbValor
            // 
            this.lbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(359, 71);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(37, 13);
            this.lbValor.TabIndex = 21;
            this.lbValor.Text = "Valor: ";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxValor.Location = new System.Drawing.Point(402, 70);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(107, 20);
            this.textBoxValor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "CPF Proprietario: ";
            // 
            // lbRua
            // 
            this.lbRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(46, 115);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(33, 13);
            this.lbRua.TabIndex = 25;
            this.lbRua.Text = "Rua: ";
            // 
            // textBoxRua
            // 
            this.textBoxRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxRua.Location = new System.Drawing.Point(85, 112);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(424, 20);
            this.textBoxRua.TabIndex = 26;
            // 
            // lbNumero
            // 
            this.lbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(46, 161);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(47, 13);
            this.lbNumero.TabIndex = 27;
            this.lbNumero.Text = "Número:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNumero.Location = new System.Drawing.Point(99, 158);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(90, 20);
            this.textBoxNumero.TabIndex = 28;
            // 
            // lbBairro
            // 
            this.lbBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(198, 165);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(40, 13);
            this.lbBairro.TabIndex = 29;
            this.lbBairro.Text = "Bairro: ";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxBairro.Location = new System.Drawing.Point(244, 161);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(265, 20);
            this.textBoxBairro.TabIndex = 30;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.Location = new System.Drawing.Point(232, 217);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(216, 21);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxCpf.TabIndex = 35;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.Location = new System.Drawing.Point(48, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 36;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ImovelV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 260);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.textBoxMetragem);
            this.Controls.Add(this.lbMetragem);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImovelV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImovelV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label lbMetragem;
        private System.Windows.Forms.TextBox textBoxMetragem;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Button btnSair;
    }
}