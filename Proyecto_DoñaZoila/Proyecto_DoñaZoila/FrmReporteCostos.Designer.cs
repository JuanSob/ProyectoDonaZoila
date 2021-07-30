
namespace Proyecto_DoñaZoila
{
    partial class FrmReporteCostos
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
            this.View_ReporteCostosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCostos = new Proyecto_DoñaZoila.DataSetCostos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_ReporteCostosTableAdapter = new Proyecto_DoñaZoila.DataSetCostosTableAdapters.View_ReporteCostosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_ReporteCostosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCostos)).BeginInit();
            this.SuspendLayout();
            // 
            // View_ReporteCostosBindingSource
            // 
            this.View_ReporteCostosBindingSource.DataMember = "View_ReporteCostos";
            this.View_ReporteCostosBindingSource.DataSource = this.DataSetCostos;
            // 
            // DataSetCostos
            // 
            this.DataSetCostos.DataSetName = "DataSetCostos";
            this.DataSetCostos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCostos";
            reportDataSource1.Value = this.View_ReporteCostosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_DoñaZoila.ReporteCostos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(902, 658);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_ReporteCostosTableAdapter
            // 
            this.View_ReporteCostosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 658);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCostos";
            this.Text = "FrmReporteCostos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteCostos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_ReporteCostosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCostos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_ReporteCostosBindingSource;
        private DataSetCostos DataSetCostos;
        private DataSetCostosTableAdapters.View_ReporteCostosTableAdapter View_ReporteCostosTableAdapter;
    }
}