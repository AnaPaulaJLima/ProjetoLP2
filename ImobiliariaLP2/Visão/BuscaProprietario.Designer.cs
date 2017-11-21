namespace ImobiliariaLP2.Visão
{
    partial class BuscaProprietario
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
            this.btnAlterarDeletar = new System.Windows.Forms.Button();
            this.dgvProprietario = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarDeletar
            // 
            this.btnAlterarDeletar.Location = new System.Drawing.Point(362, 10);
            this.btnAlterarDeletar.Name = "btnAlterarDeletar";
            this.btnAlterarDeletar.Size = new System.Drawing.Size(97, 23);
            this.btnAlterarDeletar.TabIndex = 12;
            this.btnAlterarDeletar.Text = "Vizualizar";
            this.btnAlterarDeletar.UseVisualStyleBackColor = true;
            this.btnAlterarDeletar.Click += new System.EventHandler(this.btnAlterarDeletar_Click);
            // 
            // dgvProprietario
            // 
            this.dgvProprietario.AllowUserToAddRows = false;
            this.dgvProprietario.AllowUserToDeleteRows = false;
            this.dgvProprietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProprietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProprietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnNome,
            this.columnCPF});
            this.dgvProprietario.Location = new System.Drawing.Point(15, 38);
            this.dgvProprietario.Name = "dgvProprietario";
            this.dgvProprietario.ReadOnly = true;
            this.dgvProprietario.Size = new System.Drawing.Size(525, 419);
            this.dgvProprietario.TabIndex = 11;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(54, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 20);
            this.textBoxNome.TabIndex = 10;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(41, 13);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome: ";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(465, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // columnID
            // 
            this.columnID.FillWeight = 50F;
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            // 
            // columnNome
            // 
            this.columnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            this.columnNome.ReadOnly = true;
            // 
            // columnCPF
            // 
            this.columnCPF.FillWeight = 80F;
            this.columnCPF.HeaderText = "CPF";
            this.columnCPF.Name = "columnCPF";
            this.columnCPF.ReadOnly = true;
            this.columnCPF.Width = 191;
            // 
            // BuscaProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 467);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterarDeletar);
            this.Controls.Add(this.dgvProprietario);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaProprietario";
            this.Load += new System.EventHandler(this.BuscaProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDeletar;
        private System.Windows.Forms.DataGridView dgvProprietario;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCPF;
    }
}