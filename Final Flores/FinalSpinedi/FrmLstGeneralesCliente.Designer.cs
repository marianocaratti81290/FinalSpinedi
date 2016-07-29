namespace FinalSpinedi
{
    partial class FrmLstGeneralesCliente
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
            this.LoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BibliotecaDataSet1 = new FinalSpinedi.BibliotecaDataSet1();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BibliotecaDataSet = new FinalSpinedi.BibliotecaDataSet();
            this.SocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SocioTableAdapter = new FinalSpinedi.BibliotecaDataSetTableAdapters.SocioTableAdapter();
            this.LoginTableAdapter = new FinalSpinedi.BibliotecaDataSet1TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBindingSource
            // 
            this.LoginBindingSource.DataMember = "Login";
            this.LoginBindingSource.DataSource = this.BibliotecaDataSet1;
            // 
            // BibliotecaDataSet1
            // 
            this.BibliotecaDataSet1.DataSetName = "BibliotecaDataSet1";
            this.BibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1280, 695);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consulta Generales de Clientes";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ds2";
            reportDataSource1.Value = this.LoginBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalSpinedi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1330, 606);
            this.reportViewer1.TabIndex = 5;
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
            // LoginTableAdapter
            // 
            this.LoginTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLstGeneralesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmLstGeneralesCliente";
            this.Text = "Consulta generales clientes";
            this.Load += new System.EventHandler(this.FrmLstGeneralesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SocioBindingSource;
        private BibliotecaDataSet BibliotecaDataSet;
        private BibliotecaDataSetTableAdapters.SocioTableAdapter SocioTableAdapter;
        private System.Windows.Forms.BindingSource LoginBindingSource;
        private BibliotecaDataSet1 BibliotecaDataSet1;
        private BibliotecaDataSet1TableAdapters.LoginTableAdapter LoginTableAdapter;
    }
}