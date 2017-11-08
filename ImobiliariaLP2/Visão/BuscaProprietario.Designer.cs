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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxCPF = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 400);
            this.dataGridView1.TabIndex = 11;
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
            // checkBoxNome
            // 
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.Checked = true;
            this.checkBoxNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNome.Location = new System.Drawing.Point(74, 38);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNome.TabIndex = 14;
            this.checkBoxNome.Text = "Nome";
            this.checkBoxNome.UseVisualStyleBackColor = true;
            // 
            // checkBoxCPF
            // 
            this.checkBoxCPF.AutoSize = true;
            this.checkBoxCPF.Location = new System.Drawing.Point(221, 38);
            this.checkBoxCPF.Name = "checkBoxCPF";
            this.checkBoxCPF.Size = new System.Drawing.Size(46, 17);
            this.checkBoxCPF.TabIndex = 15;
            this.checkBoxCPF.Text = "CPF";
            this.checkBoxCPF.UseVisualStyleBackColor = true;
            // 
            // BuscaProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 467);
            this.Controls.Add(this.checkBoxCPF);
            this.Controls.Add(this.checkBoxNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterarDeletar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscaProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscaProprietario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDeletar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox checkBoxNome;
        private System.Windows.Forms.CheckBox checkBoxCPF;
    }
}