namespace ImobiliariaLP2.Visão
{
    partial class RelatorioVendaPeridoV
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDataI = new System.Windows.Forms.Label();
            this.lblDataF = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDataI = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataF = new System.Windows.Forms.MaskedTextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(35, 27);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo: ";
            // 
            // lblDataI
            // 
            this.lblDataI.AutoSize = true;
            this.lblDataI.Location = new System.Drawing.Point(35, 92);
            this.lblDataI.Name = "lblDataI";
            this.lblDataI.Size = new System.Drawing.Size(64, 13);
            this.lblDataI.TabIndex = 1;
            this.lblDataI.Text = "Data Inicio: ";
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.Location = new System.Drawing.Point(250, 92);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(55, 13);
            this.lblDataF.TabIndex = 2;
            this.lblDataF.Text = "Data Fim: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aluguel ",
            "Venda"});
            this.comboBox1.Location = new System.Drawing.Point(94, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // maskedTextBoxDataI
            // 
            this.maskedTextBoxDataI.Location = new System.Drawing.Point(105, 89);
            this.maskedTextBoxDataI.Mask = "00/00/0000";
            this.maskedTextBoxDataI.Name = "maskedTextBoxDataI";
            this.maskedTextBoxDataI.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBoxDataI.TabIndex = 4;
            // 
            // maskedTextBoxDataF
            // 
            this.maskedTextBoxDataF.Location = new System.Drawing.Point(311, 89);
            this.maskedTextBoxDataF.Mask = "00/00/0000";
            this.maskedTextBoxDataF.Name = "maskedTextBoxDataF";
            this.maskedTextBoxDataF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataF.TabIndex = 5;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(336, 153);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(38, 153);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // RelatorioVendaPeridoV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 199);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.maskedTextBoxDataF);
            this.Controls.Add(this.maskedTextBoxDataI);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDataF);
            this.Controls.Add(this.lblDataI);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RelatorioVendaPeridoV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioVendaPeridoV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDataI;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataI;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataF;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSair;
    }
}