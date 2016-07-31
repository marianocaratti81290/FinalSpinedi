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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLstGeneralesSocio));
            this.SocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BibliotecaDataSet = new FinalSpinedi.BibliotecaDataSet();
            this.SocioTableAdapter = new FinalSpinedi.BibliotecaDataSetTableAdapters.SocioTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.socioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BibliotecaDataSet2 = new FinalSpinedi.BibliotecaDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flexGrillaSocio = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // SocioBindingSource
            // 
            this.SocioBindingSource.DataMember = "Socio";
            this.SocioBindingSource.DataSource = this.BibliotecaDataSet;
            // 
            // BibliotecaDataSet
            // 
            this.BibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // socioBindingSource1
            // 
            this.socioBindingSource1.DataMember = "Socio";
            this.socioBindingSource1.DataSource = this.BibliotecaDataSet;
            // 
            // BibliotecaDataSet2
            // 
            this.BibliotecaDataSet2.DataSetName = "BibliotecaDataSet2";
            this.BibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flexGrillaSocio);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1317, 638);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // flexGrillaSocio
            // 
            this.flexGrillaSocio.AllowEditing = false;
            this.flexGrillaSocio.ColumnInfo = resources.GetString("flexGrillaSocio.ColumnInfo");
            this.flexGrillaSocio.Location = new System.Drawing.Point(16, 19);
            this.flexGrillaSocio.Name = "flexGrillaSocio";
            this.flexGrillaSocio.Rows.DefaultSize = 19;
            this.flexGrillaSocio.Size = new System.Drawing.Size(1285, 619);
            this.flexGrillaSocio.TabIndex = 1;
            // 
            // FrmLstGeneralesSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmLstGeneralesSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Socios Generales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLstGeneralesSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SocioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotecaDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaSocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource SocioBindingSource;
        private BibliotecaDataSet BibliotecaDataSet;
        private BibliotecaDataSetTableAdapters.SocioTableAdapter SocioTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource socioBindingSource1;
        private BibliotecaDataSet2 BibliotecaDataSet2;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGrillaSocio;
    }
}