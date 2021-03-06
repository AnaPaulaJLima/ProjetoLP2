﻿namespace ImobiliariaLP2.Visão
{
    partial class BuscaCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarDeletar
            // 
            this.btnAlterarDeletar.Location = new System.Drawing.Point(359, 8);
            this.btnAlterarDeletar.Name = "btnAlterarDeletar";
            this.btnAlterarDeletar.Size = new System.Drawing.Size(97, 23);
            this.btnAlterarDeletar.TabIndex = 8;
            this.btnAlterarDeletar.Text = "Vizualizar";
            this.btnAlterarDeletar.UseVisualStyleBackColor = true;
            this.btnAlterarDeletar.Click += new System.EventHandler(this.btnAlterarDeletar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.ColunaNome,
            this.colunaCpf});
            this.dgvCliente.Location = new System.Drawing.Point(12, 37);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(525, 418);
            this.dgvCliente.TabIndex = 7;
            // 
            // colunaId
            // 
            this.colunaId.FillWeight = 50F;
            this.colunaId.HeaderText = "ID";
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            // 
            // ColunaNome
            // 
            this.ColunaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.ReadOnly = true;
            // 
            // colunaCpf
            // 
            this.colunaCpf.FillWeight = 80F;
            this.colunaCpf.HeaderText = "CPF";
            this.colunaCpf.Name = "colunaCpf";
            this.colunaCpf.ReadOnly = true;
            this.colunaCpf.Width = 191;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(51, 10);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 20);
            this.textBoxNome.TabIndex = 6;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            this.textBoxNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNome_KeyPress);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 13);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(41, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome: ";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(462, 8);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 9;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 467);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.btnAlterarDeletar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaCliente";
            this.Load += new System.EventHandler(this.BuscaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlterarDeletar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCpf;
    }
}