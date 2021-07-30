
namespace Proyecto_DoñaZoila
{
    partial class FrmReporteOrdenes
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
            this.DataSetReportes = new Proyecto_DoñaZoila.DataSetReportes();
            this.View_ReporteOrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_ReporteOrdenesTableAdapter = new Proyecto_DoñaZoila.DataSetReportesTableAdapters.View_ReporteOrdenesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ReporteOrdenesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrdenes";
            reportDataSource1.Value = this.View_ReporteOrdenesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_DoñaZoila.ReporteOrdenes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1227, 677);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReportes
            // 
            this.DataSetReportes.DataSetName = "DataSetReportes";
            this.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_ReporteOrdenesBindingSource
            // 
            this.View_ReporteOrdenesBindingSource.DataMember = "View_ReporteOrdenes";
            this.View_ReporteOrdenesBindingSource.DataSource = this.DataSetReportes;
            // 
            // View_ReporteOrdenesTableAdapter
            // 
            this.View_ReporteOrdenesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 677);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteOrdenes";
            this.Text = "FrmReporteOrdenes";
            this.Load += new System.EventHandler(this.FrmReporteOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ReporteOrdenesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_ReporteOrdenesBindingSource;
        private DataSetReportes DataSetReportes;
        private DataSetReportesTableAdapters.View_ReporteOrdenesTableAdapter View_ReporteOrdenesTableAdapter;
    }
}