namespace FinalSpinedi
{
    partial class FrmNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoUsuario));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txttel_fijo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbsexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha_nac = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(589, 436);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 20);
            this.btnBuscar.TabIndex = 132;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(441, 391);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(141, 21);
            this.cbLocalidad.TabIndex = 113;
            this.cbLocalidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbLocalidad_MouseClick);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(441, 354);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(141, 21);
            this.cbProvincia.TabIndex = 112;
            this.cbProvincia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbProvincia_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 23);
            this.label1.TabIndex = 131;
            this.label1.Text = "Asistente para crear clientes nuevos en el sistema";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(366, 441);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 119;
            this.label16.Text = "CP*";
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(441, 436);
            this.txtcp.MaxLength = 4;
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(141, 20);
            this.txtcp.TabIndex = 114;
            this.txtcp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcp_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 399);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 130;
            this.label15.Text = "Localidad*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "Provincia*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "Telefono";
            // 
            // txttel_fijo
            // 
            this.txttel_fijo.Location = new System.Drawing.Point(441, 278);
            this.txttel_fijo.MaxLength = 15;
            this.txttel_fijo.Name = "txttel_fijo";
            this.txttel_fijo.Size = new System.Drawing.Size(141, 20);
            this.txttel_fijo.TabIndex = 110;
            this.txttel_fijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_fijo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 127;
            this.label11.Text = "Sexo*";
            // 
            // cbsexo
            // 
            this.cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsexo.FormattingEnabled = true;
            this.cbsexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbsexo.Location = new System.Drawing.Point(172, 440);
            this.cbsexo.Name = "cbsexo";
            this.cbsexo.Size = new System.Drawing.Size(135, 21);
            this.cbsexo.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Fecha de Nacimiento*";
            // 
            // dtpfecha_nac
            // 
            this.dtpfecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha_nac.Location = new System.Drawing.Point(171, 399);
            this.dtpfecha_nac.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpfecha_nac.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfecha_nac.Name = "dtpfecha_nac";
            this.dtpfecha_nac.ShowUpDown = true;
            this.dtpfecha_nac.Size = new System.Drawing.Size(135, 20);
            this.dtpfecha_nac.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "* Son campos obligatorios";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(441, 481);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 41);
            this.txtEmail.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Domicilio*";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(441, 318);
            this.txtdomicilio.MaxLength = 50;
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(141, 20);
            this.txtdomicilio.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Celular";
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(171, 482);
            this.txtcel.MaxLength = 15;
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(135, 20);
            this.txtcel.TabIndex = 108;
            this.txtcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcel_KeyPress);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(43, 366);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(30, 13);
            this.DNI.TabIndex = 123;
            this.DNI.Text = "DNI*";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(171, 362);
            this.txtdni.MaxLength = 8;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(135, 20);
            this.txtdni.TabIndex = 105;
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Apellido*";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(171, 322);
            this.txtapellido.MaxLength = 20;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(135, 20);
            this.txtapellido.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Nombre*";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(171, 278);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(135, 20);
            this.txtnombre.TabIndex = 103;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(348, 559);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 118;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(471, 559);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 117;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(676, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 185);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta de Usuario";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(13, 131);
            this.txtPass.MaxLength = 10;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 136;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(13, 54);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Usuario";
            // 
            // FrmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttel_fijo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbsexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpfecha_nac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttel_fijo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbsexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfecha_nac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}