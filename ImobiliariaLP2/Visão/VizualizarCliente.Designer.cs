namespace ImobiliariaLP2.Visão
{
    partial class VizualizarCliente
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.maskedTextBoxDataN = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletar.Location = new System.Drawing.Point(448, 167);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 21);
            this.btnDeletar.TabIndex = 54;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlterar.Location = new System.Drawing.Point(219, 167);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 21);
            this.btnAlterar.TabIndex = 53;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSair.Location = new System.Drawing.Point(15, 167);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 21);
            this.btnSair.TabIndex = 49;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // maskedTextBoxDataN
            // 
            this.maskedTextBoxDataN.Location = new System.Drawing.Point(437, 74);
            this.maskedTextBoxDataN.Mask = "00/00/0000";
            this.maskedTextBoxDataN.Name = "maskedTextBoxDataN";
            this.maskedTextBoxDataN.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxDataN.TabIndex = 3;
            this.maskedTextBoxDataN.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDataN.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(320, 77);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(108, 13);
            this.lblDataNasc.TabIndex = 68;
            this.lblDataNasc.Text = "Data de nascimento: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxID.Location = new System.Drawing.Point(39, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(34, 20);
            this.textBoxID.TabIndex = 67;
            this.textBoxID.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 33);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 66;
            this.lbID.Text = "ID:";
            // 
            // textBoxRg
            // 
            this.textBoxRg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxRg.Location = new System.Drawing.Point(185, 74);
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(118, 20);
            this.textBoxRg.TabIndex = 2;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(70, 118);
            this.maskedTextBoxTelefone.Mask = "(00) 0000-00009";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBoxTelefone.TabIndex = 4;
            this.maskedTextBoxTelefone.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(47, 74);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(89, 20);
            this.maskedTextBoxCpf.TabIndex = 1;
            this.maskedTextBoxCpf.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNome.Location = new System.Drawing.Point(123, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(400, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxEmail.Location = new System.Drawing.Point(210, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(313, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(174, 121);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 65;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(12, 121);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 64;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbRg
            // 
            this.lbRg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(153, 77);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(26, 13);
            this.lbRg.TabIndex = 63;
            this.lbRg.Text = "RG:";
            // 
            // lbCpf
            // 
            this.lbCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(12, 77);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(30, 13);
            this.lbCpf.TabIndex = 62;
            this.lbCpf.Text = "CPF:";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(79, 33);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 61;
            this.lbNome.Text = "Nome:";
            // 
            // VizualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 211);
            this.Controls.Add(this.maskedTextBoxDataN);
            this.Controls.Add(this.lblDataNasc);
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
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "VizualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizarCliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VizualizarCliente_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataN;
        private System.Windows.Forms.Label lblDataNasc;
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
    }
}