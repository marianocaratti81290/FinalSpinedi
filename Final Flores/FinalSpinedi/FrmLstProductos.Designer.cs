namespace FinalSpinedi
{
    partial class FrmLstProductos
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
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockDataSet2 = new FinalSpinedi.StockDataSet2();
            this.btnVolver = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductosTableAdapter = new FinalSpinedi.StockDataSet2TableAdapters.ProductosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.StockDataSet2;
            // 
            // StockDataSet2
            // 
            this.StockDataSet2.DataSetName = "StockDataSet2";
            this.StockDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(730, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DsProductos";
            reportDataSource2.Value = this.ProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalSpinedi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(780, 271);
            this.reportViewer1.TabIndex = 1;
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Productos - Sistema de Stock";
            // 
            // FrmLstProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmLstProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.FrmLstProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private StockDataSet2 StockDataSet2;
        private StockDataSet2TableAdapters.ProductosTableAdapter ProductosTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}