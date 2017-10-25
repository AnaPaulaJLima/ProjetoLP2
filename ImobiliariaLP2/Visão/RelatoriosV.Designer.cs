namespace ImobiliariaLP2.Visão
{
    partial class RelatoriosV
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
            this.btnRltImoveisDisp = new System.Windows.Forms.Button();
            this.btnRltVendasF = new System.Windows.Forms.Button();
            this.RltVendasP = new System.Windows.Forms.Button();
            this.btn_voltarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRltImoveisDisp
            // 
            this.btnRltImoveisDisp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRltImoveisDisp.Location = new System.Drawing.Point(65, 253);
            this.btnRltImoveisDisp.Name = "btnRltImoveisDisp";
            this.btnRltImoveisDisp.Size = new System.Drawing.Size(131, 75);
            this.btnRltImoveisDisp.TabIndex = 10;
            this.btnRltImoveisDisp.Text = "Relatorio - Imoveis Disponivel";
            this.btnRltImoveisDisp.UseVisualStyleBackColor = true;
            this.btnRltImoveisDisp.Click += new System.EventHandler(this.btnRltImoveisDisp_Click);
            // 
            // btnRltVendasF
            // 
            this.btnRltVendasF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRltVendasF.Location = new System.Drawing.Point(314, 116);
            this.btnRltVendasF.Name = "btnRltVendasF";
            this.btnRltVendasF.Size = new System.Drawing.Size(131, 75);
            this.btnRltVendasF.TabIndex = 9;
            this.btnRltVendasF.Text = "Relatorio - Vendas Por Func";
            this.btnRltVendasF.UseVisualStyleBackColor = true;
            this.btnRltVendasF.Click += new System.EventHandler(this.btnRltVendasF_Click);
            // 
            // RltVendasP
            // 
            this.RltVendasP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RltVendasP.Location = new System.Drawing.Point(65, 116);
            this.RltVendasP.Name = "RltVendasP";
            this.RltVendasP.Size = new System.Drawing.Size(131, 75);
            this.RltVendasP.TabIndex = 8;
            this.RltVendasP.Text = "Relatorio - Vendas Por Periodo";
            this.RltVendasP.UseVisualStyleBackColor = true;
            this.RltVendasP.Click += new System.EventHandler(this.RltVendasP_Click);
            // 
            // btn_voltarMenu
            // 
            this.btn_voltarMenu.Location = new System.Drawing.Point(314, 253);
            this.btn_voltarMenu.Name = "btn_voltarMenu";
            this.btn_voltarMenu.Size = new System.Drawing.Size(131, 75);
            this.btn_voltarMenu.TabIndex = 11;
            this.btn_voltarMenu.Text = "Voltar";
            this.btn_voltarMenu.UseVisualStyleBackColor = true;
            this.btn_voltarMenu.Click += new System.EventHandler(this.btn_voltarMenu_Click);
            // 
            // RelatoriosV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 471);
            this.Controls.Add(this.btn_voltarMenu);
            this.Controls.Add(this.btnRltImoveisDisp);
            this.Controls.Add(this.btnRltVendasF);
            this.Controls.Add(this.RltVendasP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatoriosV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatoriosV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRltImoveisDisp;
        private System.Windows.Forms.Button btnRltVendasF;
        private System.Windows.Forms.Button RltVendasP;
        private System.Windows.Forms.Button btn_voltarMenu;
    }
}