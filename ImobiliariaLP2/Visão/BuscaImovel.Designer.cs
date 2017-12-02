namespace ImobiliariaLP2.Visão
{
    partial class BuscaImovel
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
            this.dgvImovel = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMetragem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.labelValorIni = new System.Windows.Forms.Label();
            this.tbValorIni = new System.Windows.Forms.TextBox();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.tbValorFinal = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImovel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(443, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(97, 25);
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // btnAlterarDeletar
            // 
            this.btnAlterarDeletar.Location = new System.Drawing.Point(443, 43);
            this.btnAlterarDeletar.Name = "btnAlterarDeletar";
            this.btnAlterarDeletar.Size = new System.Drawing.Size(97, 25);
            this.btnAlterarDeletar.TabIndex = 13;
            this.btnAlterarDeletar.Text = "Vizualizar";
            this.btnAlterarDeletar.UseVisualStyleBackColor = true;
            this.btnAlterarDeletar.Click += new System.EventHandler(this.btnAlterarDeletar_Click);
            // 
            // dgvImovel
            // 
            this.dgvImovel.AllowUserToAddRows = false;
            this.dgvImovel.AllowUserToDeleteRows = false;
            this.dgvImovel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImovel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnBairro,
            this.ColumnMetragem,
            this.ColumnValor});
            this.dgvImovel.Location = new System.Drawing.Point(15, 74);
            this.dgvImovel.Name = "dgvImovel";
            this.dgvImovel.ReadOnly = true;
            this.dgvImovel.Size = new System.Drawing.Size(525, 383);
            this.dgvImovel.TabIndex = 12;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            // 
            // ColumnMetragem
            // 
            this.ColumnMetragem.FillWeight = 150F;
            this.ColumnMetragem.HeaderText = "Metragem (m²)";
            this.ColumnMetragem.Name = "ColumnMetragem";
            this.ColumnMetragem.ReadOnly = true;
            // 
            // ColumnValor
            // 
            this.ColumnValor.FillWeight = 150F;
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(55, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(382, 20);
            this.textBoxNome.TabIndex = 11;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            this.textBoxNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNome_KeyUp);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(37, 13);
            this.lbNome.TabIndex = 10;
            this.lbNome.Text = "Bairro:";
            // 
            // labelValorIni
            // 
            this.labelValorIni.AutoSize = true;
            this.labelValorIni.Location = new System.Drawing.Point(15, 43);
            this.labelValorIni.Name = "labelValorIni";
            this.labelValorIni.Size = new System.Drawing.Size(57, 13);
            this.labelValorIni.TabIndex = 15;
            this.labelValorIni.Text = "Valor - De:";
            // 
            // tbValorIni
            // 
            this.tbValorIni.Location = new System.Drawing.Point(79, 39);
            this.tbValorIni.Name = "tbValorIni";
            this.tbValorIni.Size = new System.Drawing.Size(100, 20);
            this.tbValorIni.TabIndex = 16;
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Location = new System.Drawing.Point(186, 43);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(25, 13);
            this.labelValorFinal.TabIndex = 17;
            this.labelValorFinal.Text = "até:";
            // 
            // tbValorFinal
            // 
            this.tbValorFinal.Location = new System.Drawing.Point(218, 38);
            this.tbValorFinal.Name = "tbValorFinal";
            this.tbValorFinal.Size = new System.Drawing.Size(109, 20);
            this.tbValorFinal.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(340, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 25);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BuscaImovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 467);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbValorFinal);
            this.Controls.Add(this.labelValorFinal);
            this.Controls.Add(this.tbValorIni);
            this.Controls.Add(this.labelValorIni);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.btnAlterarDeletar);
            this.Controls.Add(this.dgvImovel);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaImovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaImovel";
            this.Load += new System.EventHandler(this.BuscaImovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImovel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button btnAlterarDeletar;
        private System.Windows.Forms.DataGridView dgvImovel;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMetragem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.Label labelValorIni;
        private System.Windows.Forms.TextBox tbValorIni;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.TextBox tbValorFinal;
        private System.Windows.Forms.Button btnBuscar;
    }
}