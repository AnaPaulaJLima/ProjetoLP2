namespace ImobiliariaLP2.Visão
{
    partial class RelatorioContratoscs
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
            this.crvRelatorio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRelatorio
            // 
            this.crvRelatorio.ActiveViewIndex = -1;
            this.crvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorio.Name = "crvRelatorio";
            this.crvRelatorio.Size = new System.Drawing.Size(1025, 505);
            this.crvRelatorio.TabIndex = 0;
            // 
            // RelatorioContratoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 505);
            this.Controls.Add(this.crvRelatorio);
            this.Name = "RelatorioContratoscs";
            this.Text = "RelatorioContratoscs";
            this.Load += new System.EventHandler(this.RelatorioContratoscs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorio;
    }
}