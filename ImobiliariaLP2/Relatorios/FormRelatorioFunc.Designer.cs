namespace ImobiliariaLP2.Relatorios
{
    partial class FormRelatorioFunc
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.imobiliaria_lp2DataSet = new ImobiliariaLP2.imobiliaria_lp2DataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new ImobiliariaLP2.imobiliaria_lp2DataSetTableAdapters.funcionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliaria_lp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.funcionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ImobiliariaLP2.Relatorios.rptFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(638, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // imobiliaria_lp2DataSet
            // 
            this.imobiliaria_lp2DataSet.DataSetName = "imobiliaria_lp2DataSet";
            this.imobiliaria_lp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.imobiliaria_lp2DataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorioFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 417);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorioFunc";
            this.Text = "FormRelatorioFunc";
            this.Load += new System.EventHandler(this.FormRelatorioFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imobiliaria_lp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private imobiliaria_lp2DataSet imobiliaria_lp2DataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private imobiliaria_lp2DataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
    }
}