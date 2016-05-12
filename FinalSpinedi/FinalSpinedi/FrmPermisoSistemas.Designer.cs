namespace FinalSpinedi
{
    partial class FrmPermisoSistemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisoSistemas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flexGrillaCliente = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBorrarCliente = new System.Windows.Forms.CheckBox();
            this.chkModificarCliente = new System.Windows.Forms.CheckBox();
            this.chkNuevoCliente = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBorrarProducto = new System.Windows.Forms.CheckBox();
            this.chkModificarProducto = new System.Windows.Forms.CheckBox();
            this.chkNuevoProducto = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkBorrarProveedor = new System.Windows.Forms.CheckBox();
            this.chkModificarProveedor = new System.Windows.Forms.CheckBox();
            this.chkNuevoProveedor = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkHabUsuario = new System.Windows.Forms.CheckBox();
            this.chkInUsuario = new System.Windows.Forms.CheckBox();
            this.chkBorrarUsuario = new System.Windows.Forms.CheckBox();
            this.chkModificarUsuario = new System.Windows.Forms.CheckBox();
            this.chkNuevoUsuario = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkSalir = new System.Windows.Forms.CheckBox();
            this.chkAcercaDe = new System.Windows.Forms.CheckBox();
            this.chkPermisosSistema = new System.Windows.Forms.CheckBox();
            this.chkLstUsuarios = new System.Windows.Forms.CheckBox();
            this.chkLstProveedor = new System.Windows.Forms.CheckBox();
            this.chkLstCliente = new System.Windows.Forms.CheckBox();
            this.chkLstProducto = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flexGrillaCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de permisos de usuario";
            // 
            // flexGrillaCliente
            // 
            this.flexGrillaCliente.AllowEditing = false;
            this.flexGrillaCliente.ColumnInfo = resources.GetString("flexGrillaCliente.ColumnInfo");
            this.flexGrillaCliente.Location = new System.Drawing.Point(19, 60);
            this.flexGrillaCliente.Name = "flexGrillaCliente";
            this.flexGrillaCliente.Rows.DefaultSize = 19;
            this.flexGrillaCliente.Size = new System.Drawing.Size(849, 155);
            this.flexGrillaCliente.TabIndex = 2;
            this.flexGrillaCliente.SelChange += new System.EventHandler(this.flexGrillaCliente_SelChange);
            this.flexGrillaCliente.Click += new System.EventHandler(this.flexGrillaCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBorrarCliente);
            this.groupBox2.Controls.Add(this.chkModificarCliente);
            this.groupBox2.Controls.Add(this.chkNuevoCliente);
            this.groupBox2.Location = new System.Drawing.Point(30, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // chkBorrarCliente
            // 
            this.chkBorrarCliente.AutoSize = true;
            this.chkBorrarCliente.Location = new System.Drawing.Point(19, 101);
            this.chkBorrarCliente.Name = "chkBorrarCliente";
            this.chkBorrarCliente.Size = new System.Drawing.Size(89, 17);
            this.chkBorrarCliente.TabIndex = 2;
            this.chkBorrarCliente.Text = "Borrar Cliente";
            this.chkBorrarCliente.UseVisualStyleBackColor = true;
            this.chkBorrarCliente.Click += new System.EventHandler(this.chkBorrarCliente_Click);
            // 
            // chkModificarCliente
            // 
            this.chkModificarCliente.AutoSize = true;
            this.chkModificarCliente.Location = new System.Drawing.Point(19, 66);
            this.chkModificarCliente.Name = "chkModificarCliente";
            this.chkModificarCliente.Size = new System.Drawing.Size(104, 17);
            this.chkModificarCliente.TabIndex = 1;
            this.chkModificarCliente.Text = "Modificar Cliente";
            this.chkModificarCliente.UseVisualStyleBackColor = true;
            this.chkModificarCliente.Click += new System.EventHandler(this.chkModificarCliente_Click);
            // 
            // chkNuevoCliente
            // 
            this.chkNuevoCliente.AutoSize = true;
            this.chkNuevoCliente.Location = new System.Drawing.Point(19, 33);
            this.chkNuevoCliente.Name = "chkNuevoCliente";
            this.chkNuevoCliente.Size = new System.Drawing.Size(93, 17);
            this.chkNuevoCliente.TabIndex = 0;
            this.chkNuevoCliente.Text = "Nuevo Cliente";
            this.chkNuevoCliente.UseVisualStyleBackColor = true;
            this.chkNuevoCliente.CheckedChanged += new System.EventHandler(this.chkNuevoCliente_CheckedChanged);
            this.chkNuevoCliente.Click += new System.EventHandler(this.chkNuevoCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBorrarProducto);
            this.groupBox3.Controls.Add(this.chkModificarProducto);
            this.groupBox3.Controls.Add(this.chkNuevoProducto);
            this.groupBox3.Location = new System.Drawing.Point(260, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // chkBorrarProducto
            // 
            this.chkBorrarProducto.AutoSize = true;
            this.chkBorrarProducto.Location = new System.Drawing.Point(24, 101);
            this.chkBorrarProducto.Name = "chkBorrarProducto";
            this.chkBorrarProducto.Size = new System.Drawing.Size(100, 17);
            this.chkBorrarProducto.TabIndex = 5;
            this.chkBorrarProducto.Text = "Borrar Producto";
            this.chkBorrarProducto.UseVisualStyleBackColor = true;
            this.chkBorrarProducto.Click += new System.EventHandler(this.chkBorrarProducto_Click);
            // 
            // chkModificarProducto
            // 
            this.chkModificarProducto.AutoSize = true;
            this.chkModificarProducto.Location = new System.Drawing.Point(24, 66);
            this.chkModificarProducto.Name = "chkModificarProducto";
            this.chkModificarProducto.Size = new System.Drawing.Size(115, 17);
            this.chkModificarProducto.TabIndex = 4;
            this.chkModificarProducto.Text = "Modificar Producto";
            this.chkModificarProducto.UseVisualStyleBackColor = true;
            this.chkModificarProducto.Click += new System.EventHandler(this.chkModificarProducto_Click);
            // 
            // chkNuevoProducto
            // 
            this.chkNuevoProducto.AutoSize = true;
            this.chkNuevoProducto.Location = new System.Drawing.Point(24, 33);
            this.chkNuevoProducto.Name = "chkNuevoProducto";
            this.chkNuevoProducto.Size = new System.Drawing.Size(104, 17);
            this.chkNuevoProducto.TabIndex = 3;
            this.chkNuevoProducto.Text = "Nuevo Producto";
            this.chkNuevoProducto.UseVisualStyleBackColor = true;
            this.chkNuevoProducto.Click += new System.EventHandler(this.chkNuevoProducto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkBorrarProveedor);
            this.groupBox4.Controls.Add(this.chkModificarProveedor);
            this.groupBox4.Controls.Add(this.chkNuevoProveedor);
            this.groupBox4.Location = new System.Drawing.Point(492, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedores";
            // 
            // chkBorrarProveedor
            // 
            this.chkBorrarProveedor.AutoSize = true;
            this.chkBorrarProveedor.Location = new System.Drawing.Point(23, 101);
            this.chkBorrarProveedor.Name = "chkBorrarProveedor";
            this.chkBorrarProveedor.Size = new System.Drawing.Size(106, 17);
            this.chkBorrarProveedor.TabIndex = 8;
            this.chkBorrarProveedor.Text = "Borrar Proveedor";
            this.chkBorrarProveedor.UseVisualStyleBackColor = true;
            this.chkBorrarProveedor.Click += new System.EventHandler(this.chkBorrarProveedor_Click);
            // 
            // chkModificarProveedor
            // 
            this.chkModificarProveedor.AutoSize = true;
            this.chkModificarProveedor.Location = new System.Drawing.Point(23, 66);
            this.chkModificarProveedor.Name = "chkModificarProveedor";
            this.chkModificarProveedor.Size = new System.Drawing.Size(121, 17);
            this.chkModificarProveedor.TabIndex = 7;
            this.chkModificarProveedor.Text = "Modificar Proveedor";
            this.chkModificarProveedor.UseVisualStyleBackColor = true;
            this.chkModificarProveedor.Click += new System.EventHandler(this.chkModificarProveedor_Click);
            // 
            // chkNuevoProveedor
            // 
            this.chkNuevoProveedor.AutoSize = true;
            this.chkNuevoProveedor.Location = new System.Drawing.Point(23, 33);
            this.chkNuevoProveedor.Name = "chkNuevoProveedor";
            this.chkNuevoProveedor.Size = new System.Drawing.Size(110, 17);
            this.chkNuevoProveedor.TabIndex = 6;
            this.chkNuevoProveedor.Text = "Nuevo Proveedor";
            this.chkNuevoProveedor.UseVisualStyleBackColor = true;
            this.chkNuevoProveedor.Click += new System.EventHandler(this.chkNuevoProveedor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkHabUsuario);
            this.groupBox5.Controls.Add(this.chkInUsuario);
            this.groupBox5.Controls.Add(this.chkBorrarUsuario);
            this.groupBox5.Controls.Add(this.chkModificarUsuario);
            this.groupBox5.Controls.Add(this.chkNuevoUsuario);
            this.groupBox5.Location = new System.Drawing.Point(727, 300);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 215);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Usuario";
            // 
            // chkHabUsuario
            // 
            this.chkHabUsuario.AutoSize = true;
            this.chkHabUsuario.Location = new System.Drawing.Point(25, 170);
            this.chkHabUsuario.Name = "chkHabUsuario";
            this.chkHabUsuario.Size = new System.Drawing.Size(103, 17);
            this.chkHabUsuario.TabIndex = 13;
            this.chkHabUsuario.Text = "Habilitar Usuario";
            this.chkHabUsuario.UseVisualStyleBackColor = true;
            this.chkHabUsuario.Click += new System.EventHandler(this.chkHabUsuario_Click);
            // 
            // chkInUsuario
            // 
            this.chkInUsuario.AutoSize = true;
            this.chkInUsuario.Location = new System.Drawing.Point(25, 135);
            this.chkInUsuario.Name = "chkInUsuario";
            this.chkInUsuario.Size = new System.Drawing.Size(110, 17);
            this.chkInUsuario.TabIndex = 12;
            this.chkInUsuario.Text = "Inhabilitar Usuario";
            this.chkInUsuario.UseVisualStyleBackColor = true;
            this.chkInUsuario.CheckedChanged += new System.EventHandler(this.chkInUsuario_CheckedChanged);
            this.chkInUsuario.Click += new System.EventHandler(this.chkInUsuario_Click);
            // 
            // chkBorrarUsuario
            // 
            this.chkBorrarUsuario.AutoSize = true;
            this.chkBorrarUsuario.Location = new System.Drawing.Point(25, 101);
            this.chkBorrarUsuario.Name = "chkBorrarUsuario";
            this.chkBorrarUsuario.Size = new System.Drawing.Size(93, 17);
            this.chkBorrarUsuario.TabIndex = 11;
            this.chkBorrarUsuario.Text = "Borrar Usuario";
            this.chkBorrarUsuario.UseVisualStyleBackColor = true;
            this.chkBorrarUsuario.Click += new System.EventHandler(this.chkBorrarUsuario_Click);
            // 
            // chkModificarUsuario
            // 
            this.chkModificarUsuario.AutoSize = true;
            this.chkModificarUsuario.Location = new System.Drawing.Point(25, 66);
            this.chkModificarUsuario.Name = "chkModificarUsuario";
            this.chkModificarUsuario.Size = new System.Drawing.Size(108, 17);
            this.chkModificarUsuario.TabIndex = 10;
            this.chkModificarUsuario.Text = "Modificar Usuario";
            this.chkModificarUsuario.UseVisualStyleBackColor = true;
            this.chkModificarUsuario.Click += new System.EventHandler(this.chkModificarUsuario_Click);
            // 
            // chkNuevoUsuario
            // 
            this.chkNuevoUsuario.AutoSize = true;
            this.chkNuevoUsuario.Location = new System.Drawing.Point(25, 33);
            this.chkNuevoUsuario.Name = "chkNuevoUsuario";
            this.chkNuevoUsuario.Size = new System.Drawing.Size(97, 17);
            this.chkNuevoUsuario.TabIndex = 9;
            this.chkNuevoUsuario.Text = "Nuevo Usuario";
            this.chkNuevoUsuario.UseVisualStyleBackColor = true;
            this.chkNuevoUsuario.Click += new System.EventHandler(this.chkNuevoUsuario_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkSalir);
            this.groupBox6.Controls.Add(this.chkAcercaDe);
            this.groupBox6.Controls.Add(this.chkPermisosSistema);
            this.groupBox6.Controls.Add(this.chkLstUsuarios);
            this.groupBox6.Controls.Add(this.chkLstProveedor);
            this.groupBox6.Controls.Add(this.chkLstCliente);
            this.groupBox6.Controls.Add(this.chkLstProducto);
            this.groupBox6.Location = new System.Drawing.Point(30, 454);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(662, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otros";
            // 
            // chkSalir
            // 
            this.chkSalir.AutoSize = true;
            this.chkSalir.Location = new System.Drawing.Point(560, 29);
            this.chkSalir.Name = "chkSalir";
            this.chkSalir.Size = new System.Drawing.Size(46, 17);
            this.chkSalir.TabIndex = 10;
            this.chkSalir.Text = "Salir";
            this.chkSalir.UseVisualStyleBackColor = true;
            this.chkSalir.Click += new System.EventHandler(this.chkSalir_Click);
            // 
            // chkAcercaDe
            // 
            this.chkAcercaDe.AutoSize = true;
            this.chkAcercaDe.Location = new System.Drawing.Point(376, 62);
            this.chkAcercaDe.Name = "chkAcercaDe";
            this.chkAcercaDe.Size = new System.Drawing.Size(78, 17);
            this.chkAcercaDe.TabIndex = 9;
            this.chkAcercaDe.Text = "Acerca de ";
            this.chkAcercaDe.UseVisualStyleBackColor = true;
            this.chkAcercaDe.Click += new System.EventHandler(this.chkAcercaDe_Click);
            // 
            // chkPermisosSistema
            // 
            this.chkPermisosSistema.AutoSize = true;
            this.chkPermisosSistema.Location = new System.Drawing.Point(376, 29);
            this.chkPermisosSistema.Name = "chkPermisosSistema";
            this.chkPermisosSistema.Size = new System.Drawing.Size(108, 17);
            this.chkPermisosSistema.TabIndex = 8;
            this.chkPermisosSistema.Text = "Permisos Sistema";
            this.chkPermisosSistema.UseVisualStyleBackColor = true;
            this.chkPermisosSistema.Click += new System.EventHandler(this.chkPermisosSistema_Click);
            // 
            // chkLstUsuarios
            // 
            this.chkLstUsuarios.AutoSize = true;
            this.chkLstUsuarios.Location = new System.Drawing.Point(178, 62);
            this.chkLstUsuarios.Name = "chkLstUsuarios";
            this.chkLstUsuarios.Size = new System.Drawing.Size(119, 17);
            this.chkLstUsuarios.TabIndex = 7;
            this.chkLstUsuarios.Text = "Listado de Usuarios";
            this.chkLstUsuarios.UseVisualStyleBackColor = true;
            this.chkLstUsuarios.Click += new System.EventHandler(this.chkLstUsuarios_Click);
            // 
            // chkLstProveedor
            // 
            this.chkLstProveedor.AutoSize = true;
            this.chkLstProveedor.Location = new System.Drawing.Point(178, 29);
            this.chkLstProveedor.Name = "chkLstProveedor";
            this.chkLstProveedor.Size = new System.Drawing.Size(138, 17);
            this.chkLstProveedor.TabIndex = 5;
            this.chkLstProveedor.Text = "Listado de Proveedores";
            this.chkLstProveedor.UseVisualStyleBackColor = true;
            this.chkLstProveedor.Click += new System.EventHandler(this.chkLstProveedor_Click);
            // 
            // chkLstCliente
            // 
            this.chkLstCliente.AutoSize = true;
            this.chkLstCliente.Location = new System.Drawing.Point(19, 62);
            this.chkLstCliente.Name = "chkLstCliente";
            this.chkLstCliente.Size = new System.Drawing.Size(115, 17);
            this.chkLstCliente.TabIndex = 4;
            this.chkLstCliente.Text = "Listado de Clientes";
            this.chkLstCliente.UseVisualStyleBackColor = true;
            this.chkLstCliente.Click += new System.EventHandler(this.chkLstCliente_Click);
            // 
            // chkLstProducto
            // 
            this.chkLstProducto.AutoSize = true;
            this.chkLstProducto.Location = new System.Drawing.Point(19, 29);
            this.chkLstProducto.Name = "chkLstProducto";
            this.chkLstProducto.Size = new System.Drawing.Size(126, 17);
            this.chkLstProducto.TabIndex = 3;
            this.chkLstProducto.Text = "Listado de Productos";
            this.chkLstProducto.UseVisualStyleBackColor = true;
            this.chkLstProducto.Click += new System.EventHandler(this.chkLstProducto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(787, 531);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmPermisoSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 578);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPermisoSistemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos para usuarios del sistema";
            this.Load += new System.EventHandler(this.FrmPermisoSistemas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGrillaCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBorrarCliente;
        private System.Windows.Forms.CheckBox chkModificarCliente;
        private System.Windows.Forms.CheckBox chkNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkBorrarProducto;
        private System.Windows.Forms.CheckBox chkModificarProducto;
        private System.Windows.Forms.CheckBox chkNuevoProducto;
        private System.Windows.Forms.CheckBox chkBorrarProveedor;
        private System.Windows.Forms.CheckBox chkModificarProveedor;
        private System.Windows.Forms.CheckBox chkNuevoProveedor;
        private System.Windows.Forms.CheckBox chkBorrarUsuario;
        private System.Windows.Forms.CheckBox chkModificarUsuario;
        private System.Windows.Forms.CheckBox chkNuevoUsuario;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkLstCliente;
        private System.Windows.Forms.CheckBox chkLstProducto;
        private System.Windows.Forms.CheckBox chkLstProveedor;
        private System.Windows.Forms.CheckBox chkPermisosSistema;
        private System.Windows.Forms.CheckBox chkLstUsuarios;
        private System.Windows.Forms.CheckBox chkSalir;
        private System.Windows.Forms.CheckBox chkAcercaDe;
        private System.Windows.Forms.CheckBox chkHabUsuario;
        private System.Windows.Forms.CheckBox chkInUsuario;
        private System.Windows.Forms.Button btnVolver;
    }
}