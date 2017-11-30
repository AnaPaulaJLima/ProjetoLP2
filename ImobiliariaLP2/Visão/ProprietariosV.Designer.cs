namespace ImobiliariaLP2.Visão
{
    partial class ProprietariosV
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.textBoxRg = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.maskedTextBoxDataN = new System.Windows.Forms.MaskedTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(470, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 26);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(24, 204);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(342, 124);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(203, 20);
            this.textBoxCidade.TabIndex = 7;
            this.textBoxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(64, 124);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(182, 20);
            this.textBoxBairro.TabIndex = 6;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(480, 89);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(65, 20);
            this.textBoxNumero.TabIndex = 5;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(58, 88);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(372, 20);
            this.textBoxRua.TabIndex = 4;
            this.textBoxRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(290, 127);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 60;
            this.lblCidade.Text = "Cidade: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(21, 128);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 59;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(436, 92);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 58;
            this.lblNumero.Text = "Número:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(23, 92);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 57;
            this.lblRua.Text = "Rua:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(58, 17);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(41, 20);
            this.textBoxID.TabIndex = 56;
            this.textBoxID.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 55;
            this.lbID.Text = "ID:";
            // 
            // textBoxRg
            // 
            this.textBoxRg.Location = new System.Drawing.Point(189, 51);
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(127, 20);
            this.textBoxRg.TabIndex = 2;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(79, 159);
            this.maskedTextBoxTelefone.Mask = "(00) 0000-00009";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxTelefone.TabIndex = 8;
            this.maskedTextBoxTelefone.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(58, 51);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBoxCpf.TabIndex = 1;
            this.maskedTextBoxCpf.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(150, 17);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(395, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(206, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(339, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(171, 162);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 49;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(23, 162);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 48;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(157, 54);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(26, 13);
            this.lbRg.TabIndex = 47;
            this.lbRg.Text = "RG:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(22, 54);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 46;
            this.lbCpf.Text = "CPF:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(114, 20);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 45;
            this.lbNome.Text = "Nome:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(331, 54);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(108, 13);
            this.lblDataNasc.TabIndex = 65;
            this.lblDataNasc.Text = "Data de nascimento: ";
            // 
            // maskedTextBoxDataN
            // 
            this.maskedTextBoxDataN.Location = new System.Drawing.Point(445, 51);
            this.maskedTextBoxDataN.Mask = "00/00/0000";
            this.maskedTextBoxDataN.Name = "maskedTextBoxDataN";
            this.maskedTextBoxDataN.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataN.TabIndex = 3;
            this.maskedTextBoxDataN.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataN.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // ProprietariosV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 245);
            this.Controls.Add(this.maskedTextBoxDataN);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.textBoxRg);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ProprietariosV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProprietariosV";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProprietariosV_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox textBoxRg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataN;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}