namespace FinalSpinedi
{
    partial class FrmInhabilitarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInhabilitarUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flexGrillaCliente = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btndesHabilitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flexGrillaCliente);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 251);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilitar e Inhabilitar Usuarios del sistema";
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(174, 29);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(316, 20);
            this.txtBuscar1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar Clientes";
            // 
            // flexGrillaCliente
            // 
            this.flexGrillaCliente.AllowEditing = false;
            this.flexGrillaCliente.ColumnInfo = resources.GetString("flexGrillaCliente.ColumnInfo");
            this.flexGrillaCliente.Location = new System.Drawing.Point(16, 75);
            this.flexGrillaCliente.Name = "flexGrillaCliente";
            this.flexGrillaCliente.Rows.DefaultSize = 19;
            this.flexGrillaCliente.Size = new System.Drawing.Size(585, 155);
            this.flexGrillaCliente.TabIndex = 1;
            this.flexGrillaCliente.SelChange += new System.EventHandler(this.flexGrillaCliente_SelChange);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(569, 284);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnhabilitar.TabIndex = 109;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // btndesHabilitar
            // 
            this.btndesHabilitar.Location = new System.Drawing.Point(569, 284);
            this.btndesHabilitar.Name = "btndesHabilitar";
            this.btndesHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btndesHabilitar.TabIndex = 110;
            this.btndesHabilitar.Text = "Deshabilitar";
            this.btndesHabilitar.UseVisualStyleBackColor = true;
            this.btndesHabilitar.Click += new System.EventHandler(this.btndesHabilitar_Click);
            // 
            // FrmInhabilitarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 336);
            this.Controls.Add(this.btndesHabilitar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInhabilitarUsuarios";
            this.Text = "Habilitar/Inhabilitar Usuarios";
            this.Load += new System.EventHandler(this.FrmInhabilitarUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGrillaCliente;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btndesHabilitar;
    }
}