namespace FinalSpinedi
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnacceder = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuarioNuevo = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(274, 410);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnacceder
            // 
            this.btnacceder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnacceder.Location = new System.Drawing.Point(128, 410);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(75, 23);
            this.btnacceder.TabIndex = 33;
            this.btnacceder.Text = "Aceptar";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(90, 358);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(103, 305);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 16);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Usuario";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(175, 354);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(150, 20);
            this.txtpass.TabIndex = 32;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // txtusuario
            // 
            this.txtusuario.AcceptsTab = true;
            this.txtusuario.Location = new System.Drawing.Point(175, 305);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(150, 20);
            this.txtusuario.TabIndex = 31;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(56, 264);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(322, 13);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Ingrese el nombre de usuario y contraseña para acceder al sistema";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(175, 102);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(102, 134);
            this.PictureBox1.TabIndex = 35;
            this.PictureBox1.TabStop = false;
            // 
            // btnUsuarioNuevo
            // 
            this.btnUsuarioNuevo.Location = new System.Drawing.Point(322, 4);
            this.btnUsuarioNuevo.Name = "btnUsuarioNuevo";
            this.btnUsuarioNuevo.Size = new System.Drawing.Size(111, 23);
            this.btnUsuarioNuevo.TabIndex = 41;
            this.btnUsuarioNuevo.Text = "Crear Usuario";
            this.btnUsuarioNuevo.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label2.Location = new System.Drawing.Point(163, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 24);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "BIENVENIDOS";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(56, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(260, 13);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "La conexion con la base de datos es exitosa";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 456);
            this.Controls.Add(this.btnUsuarioNuevo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.Button btnacceder;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtusuario;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnUsuarioNuevo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}