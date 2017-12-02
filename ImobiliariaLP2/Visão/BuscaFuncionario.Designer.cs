namespace ImobiliariaLP2.Visão
{
    partial class BuscaFuncionario
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.btnAlterarDeletar = new System.Windows.Forms.Button();
            this.dgvFuncioario = new System.Windows.Forms.DataGridView();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncioario)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(465, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 19;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // btnAlterarDeletar
            // 
            this.btnAlterarDeletar.Location = new System.Drawing.Point(362, 10);
            this.btnAlterarDeletar.Name = "btnAlterarDeletar";
            this.btnAlterarDeletar.Size = new System.Drawing.Size(97, 23);
            this.btnAlterarDeletar.TabIndex = 18;
            this.btnAlterarDeletar.Text = "Vizualizar";
            this.btnAlterarDeletar.UseVisualStyleBackColor = true;
            this.btnAlterarDeletar.Click += new System.EventHandler(this.btnAlterarDeletar_Click);
            // 
            // dgvFuncioario
            // 
            this.dgvFuncioario.AllowUserToAddRows = false;
            this.dgvFuncioario.AllowUserToDeleteRows = false;
            this.dgvFuncioario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncioario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncioario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaID,
            this.colunaNome,
            this.colunaFuncao});
            this.dgvFuncioario.Location = new System.Drawing.Point(15, 38);
            this.dgvFuncioario.Name = "dgvFuncioario";
            this.dgvFuncioario.ReadOnly = true;
            this.dgvFuncioario.Size = new System.Drawing.Size(525, 419);
            this.dgvFuncioario.TabIndex = 17;
            // 
            // colunaID
            // 
            this.colunaID.HeaderText = "ID";
            this.colunaID.Name = "colunaID";
            this.colunaID.ReadOnly = true;
            // 
            // colunaNome
            // 
            this.colunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            // 
            // colunaFuncao
            // 
            this.colunaFuncao.HeaderText = "Função";
            this.colunaFuncao.Name = "colunaFuncao";
            this.colunaFuncao.ReadOnly = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(54, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 20);
            this.textBoxNome.TabIndex = 16;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            this.textBoxNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNome_KeyUp);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(41, 13);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "Nome: ";
            // 
            // BuscaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 467);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.btnAlterarDeletar);
            this.Controls.Add(this.dgvFuncioario);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaFuncionario";
            this.Load += new System.EventHandler(this.BuscaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncioario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button btnAlterarDeletar;
        private System.Windows.Forms.DataGridView dgvFuncioario;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaFuncao;
    }
}