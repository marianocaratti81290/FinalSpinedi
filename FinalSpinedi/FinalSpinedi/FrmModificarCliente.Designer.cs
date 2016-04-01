namespace FinalSpinedi
{
    partial class FrmModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flexGrillaCliente = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpfecha_nac = new System.Windows.Forms.DateTimePicker();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flexGrillaCliente);
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Clientes";
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
            this.flexGrillaCliente.Size = new System.Drawing.Size(849, 155);
            this.flexGrillaCliente.TabIndex = 1;
            this.flexGrillaCliente.SelChange += new System.EventHandler(this.flexGrillaCliente_SelChange);
            this.flexGrillaCliente.Click += new System.EventHandler(this.flexGrillaCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpfecha_nac);
            this.groupBox2.Controls.Add(this.cbLocalidad);
            this.groupBox2.Controls.Add(this.cbProvincia);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(this.txtDomicilio);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnMod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar clientes";
            // 
            // dtpfecha_nac
            // 
            this.dtpfecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha_nac.Location = new System.Drawing.Point(151, 142);
            this.dtpfecha_nac.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpfecha_nac.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfecha_nac.Name = "dtpfecha_nac";
            this.dtpfecha_nac.ShowUpDown = true;
            this.dtpfecha_nac.Size = new System.Drawing.Size(245, 20);
            this.dtpfecha_nac.TabIndex = 29;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(569, 103);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(245, 21);
            this.cbLocalidad.TabIndex = 28;
            this.cbLocalidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbLocalidad_MouseClick);
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(569, 63);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(245, 21);
            this.cbProvincia.TabIndex = 27;
            this.cbProvincia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbProvincia_MouseClick);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenimo"});
            this.cbSexo.Location = new System.Drawing.Point(151, 181);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(245, 21);
            this.cbSexo.TabIndex = 26;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(569, 141);
            this.txtDomicilio.MaxLength = 50;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(245, 20);
            this.txtDomicilio.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Domicilio";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(569, 177);
            this.txtCp.MaxLength = 4;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(245, 20);
            this.txtCp.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Codigo Postal";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(151, 219);
            this.txtCel.MaxLength = 20;
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(245, 20);
            this.txtCel.TabIndex = 21;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fecha Nacimiento";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(569, 213);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(569, 25);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(245, 20);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(151, 103);
            this.txtDni.MaxLength = 10;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(245, 20);
            this.txtDni.TabIndex = 11;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 65);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(245, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 25);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(602, 255);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(695, 255);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(119, 23);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Actualizar Datos";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 23);
            this.label9.TabIndex = 100;
            this.label9.Text = "Asistente para modificar usuarios en el sistema";
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 647);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Clientes";
            this.Load += new System.EventHandler(this.FrmModificarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGrillaCliente;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.DateTimePicker dtpfecha_nac;
    }
}