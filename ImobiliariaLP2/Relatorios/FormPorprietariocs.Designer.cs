namespace ImobiliariaLP2.Relatorios
{
    partial class FormPorprietariocs
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
            this.proprietarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proprietarioTableAdapter = new ImobiliariaLP2.imobiliaria_lp2DataSetTableAdapters.proprietarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imobiliaria_lp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.proprietarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ImobiliariaLP2.Relatorios.rptProprietario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(551, 344);
            this.reportViewer1.TabIndex = 0;
            // 
            // imobiliaria_lp2DataSet
            // 
            this.imobiliaria_lp2DataSet.DataSetName = "imobiliaria_lp2DataSet";
            this.imobiliaria_lp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proprietarioBindingSource
            // 
            this.proprietarioBindingSource.DataMember = "proprietario";
            this.proprietarioBindingSource.DataSource = this.imobiliaria_lp2DataSet;
            // 
            // proprietarioTableAdapter
            // 
            this.proprietarioTableAdapter.ClearBeforeFill = true;
            // 
            // FormPorprietariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 344);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPorprietariocs";
            this.Text = "FormPorprietariocs";
            this.Load += new System.EventHandler(this.FormPorprietariocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imobiliaria_lp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private imobiliaria_lp2DataSet imobiliaria_lp2DataSet;
        private System.Windows.Forms.BindingSource proprietarioBindingSource;
        private imobiliaria_lp2DataSetTableAdapters.proprietarioTableAdapter proprietarioTableAdapter;
    }
}