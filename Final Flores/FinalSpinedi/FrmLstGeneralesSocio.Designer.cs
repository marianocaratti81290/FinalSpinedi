namespace FinalSpinedi
{
    partial class FrmLstGeneralesSocio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BibliotecaDataSet = new FinalSpinedi.BibliotecaDataSet();
            this.SocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SocioTableAdapter = new FinalSpinedi.BibliotecaDataSetTableAdapters.SocioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SocioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalSpinedi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1330, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // BibliotecaDataSet
            // 
            this.BibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SocioBindingSource
            // 
            this.SocioBindingSource.DataMember = "Socio";
            this.SocioBindingSource.DataSource = this.BibliotecaDataSet;
            // 
            // SocioTableAdapter
            // 
            this.SocioTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta Generales de Socios";
            // 
            // FrmLstGeneralesSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmLstGeneralesSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Socios Generales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLstGeneralesSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SocioBindingSource;
        private BibliotecaDataSet BibliotecaDataSet;
        private BibliotecaDataSetTableAdapters.SocioTableAdapter SocioTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}