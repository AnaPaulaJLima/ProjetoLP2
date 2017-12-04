namespace ImobiliariaLP2.Visão
{
    partial class BuscaVendas
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
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.lbNomeCorretor = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.ColumnIdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdImovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdVenda,
            this.ColumnIdImovel,
            this.ColumnCorretor,
            this.ColumnCliente});
            this.dgvVenda.Location = new System.Drawing.Point(12, 42);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(550, 429);
            this.dgvVenda.TabIndex = 0;
            // 
            // lbNomeCorretor
            // 
            this.lbNomeCorretor.AutoSize = true;
            this.lbNomeCorretor.Location = new System.Drawing.Point(13, 19);
            this.lbNomeCorretor.Name = "lbNomeCorretor";
            this.lbNomeCorretor.Size = new System.Drawing.Size(92, 13);
            this.lbNomeCorretor.TabIndex = 1;
            this.lbNomeCorretor.Text = "Nome do corretor:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(111, 16);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(288, 20);
            this.txtBoxNome.TabIndex = 2;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBoxNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxNome_KeyUp);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(486, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(405, 13);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // ColumnIdVenda
            // 
            this.ColumnIdVenda.FillWeight = 25F;
            this.ColumnIdVenda.HeaderText = "ID";
            this.ColumnIdVenda.Name = "ColumnIdVenda";
            this.ColumnIdVenda.ReadOnly = true;
            // 
            // ColumnIdImovel
            // 
            this.ColumnIdImovel.FillWeight = 25F;
            this.ColumnIdImovel.HeaderText = "ID Imóvel";
            this.ColumnIdImovel.Name = "ColumnIdImovel";
            this.ColumnIdImovel.ReadOnly = true;
            // 
            // ColumnCorretor
            // 
            this.ColumnCorretor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCorretor.HeaderText = "Corretor";
            this.ColumnCorretor.Name = "ColumnCorretor";
            this.ColumnCorretor.ReadOnly = true;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            // 
            // BuscaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 483);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lbNomeCorretor);
            this.Controls.Add(this.dgvVenda);
            this.Name = "BuscaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaVendas";
            this.Load += new System.EventHandler(this.BuscaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdImovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorretor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.Label lbNomeCorretor;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisualizar;
    }
}