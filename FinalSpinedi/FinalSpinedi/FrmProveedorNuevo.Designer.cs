namespace FinalSpinedi
{
    partial class FrmProveedorNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedorNuevo));
            this.label16 = new System.Windows.Forms.Label();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttel_fijo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 432);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 113;
            this.label16.Text = "Descripcion";
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(230, 429);
            this.txtdescrip.MaxLength = 4;
            this.txtdescrip.Multiline = true;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(162, 59);
            this.txtdescrip.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(456, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "Telefono";
            // 
            // txttel_fijo
            // 
            this.txttel_fijo.Location = new System.Drawing.Point(531, 345);
            this.txttel_fijo.MaxLength = 15;
            this.txttel_fijo.Name = "txttel_fijo";
            this.txttel_fijo.Size = new System.Drawing.Size(157, 20);
            this.txttel_fijo.TabIndex = 104;
            this.txttel_fijo.TextChanged += new System.EventHandler(this.txttel_fijo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 111;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbEstado.Location = new System.Drawing.Point(230, 385);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(162, 21);
            this.cbEstado.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "* Son campos obligatorios";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(532, 463);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Celular";
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(531, 385);
            this.txtcel.MaxLength = 15;
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(157, 20);
            this.txtcel.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Nombre*";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(230, 345);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(162, 20);
            this.txtnombre.TabIndex = 97;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(291, 608);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 112;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(414, 608);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 110;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 23);
            this.label1.TabIndex = 125;
            this.label1.Text = "Asistente para crear proveedor nuevos en el sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(531, 425);
            this.txtContacto.MaxLength = 15;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(157, 20);
            this.txtContacto.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "Contacto";
            // 
            // FrmProveedorNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttel_fijo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnaceptar);
            this.Name = "FrmProveedorNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmProveedorNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttel_fijo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label2;
    }
}