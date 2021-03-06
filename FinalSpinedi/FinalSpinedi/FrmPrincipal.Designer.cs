﻿namespace FinalSpinedi
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flexGrillaClientes = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbuscarCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flexProductosCod = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.menuStrip1.SuspendLayout();
            this.Grupo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexProductosCod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(219, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistemas de Gestion de Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.permisosSistemaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // crearClienteToolStripMenuItem
            // 
            this.crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            this.crearClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.crearClienteToolStripMenuItem.Text = "Crear Cliente";
            this.crearClienteToolStripMenuItem.Click += new System.EventHandler(this.crearClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // modificarProveedorToolStripMenuItem
            // 
            this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificarProveedorToolStripMenuItem.Text = "Modificar Proveedor";
            this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminar Proveedor";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.inhabilitarUsuariosToolStripMenuItem,
            this.habilitarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // inhabilitarUsuariosToolStripMenuItem
            // 
            this.inhabilitarUsuariosToolStripMenuItem.Name = "inhabilitarUsuariosToolStripMenuItem";
            this.inhabilitarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.inhabilitarUsuariosToolStripMenuItem.Text = "Inhabilitar Usuarios";
            this.inhabilitarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarUsuariosToolStripMenuItem_Click);
            // 
            // habilitarUsuariosToolStripMenuItem
            // 
            this.habilitarUsuariosToolStripMenuItem.Name = "habilitarUsuariosToolStripMenuItem";
            this.habilitarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.habilitarUsuariosToolStripMenuItem.Text = "Habilitar Usuarios";
            this.habilitarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.habilitarUsuariosToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProductosToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeProveedoresToolStripMenuItem,
            this.listadoDeUsuarioToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de Productos";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeProveedoresToolStripMenuItem
            // 
            this.listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            this.listadoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores";
            this.listadoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProveedoresToolStripMenuItem_Click);
            // 
            // listadoDeUsuarioToolStripMenuItem
            // 
            this.listadoDeUsuarioToolStripMenuItem.Name = "listadoDeUsuarioToolStripMenuItem";
            this.listadoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeUsuarioToolStripMenuItem.Text = "Listado de Usuario";
            this.listadoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeUsuarioToolStripMenuItem_Click);
            // 
            // permisosSistemaToolStripMenuItem
            // 
            this.permisosSistemaToolStripMenuItem.Name = "permisosSistemaToolStripMenuItem";
            this.permisosSistemaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.permisosSistemaToolStripMenuItem.Text = "Permisos Sistema";
            this.permisosSistemaToolStripMenuItem.Click += new System.EventHandler(this.permisosSistemaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.txtBuscar1);
            this.Grupo2.Controls.Add(this.label3);
            this.Grupo2.Controls.Add(this.flexGrillaClientes);
            this.Grupo2.Location = new System.Drawing.Point(27, 331);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(725, 208);
            this.Grupo2.TabIndex = 3;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Clientes";
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(166, 25);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(316, 20);
            this.txtBuscar1.TabIndex = 2;
            this.txtBuscar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar Clientes";
            // 
            // flexGrillaClientes
            // 
            this.flexGrillaClientes.ColumnInfo = resources.GetString("flexGrillaClientes.ColumnInfo");
            this.flexGrillaClientes.Location = new System.Drawing.Point(27, 64);
            this.flexGrillaClientes.Name = "flexGrillaClientes";
            this.flexGrillaClientes.Rows.DefaultSize = 19;
            this.flexGrillaClientes.Size = new System.Drawing.Size(677, 127);
            this.flexGrillaClientes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtbuscarCod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.flexProductosCod);
            this.groupBox1.Location = new System.Drawing.Point(29, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 213);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos ";
            // 
            // txtbuscarCod
            // 
            this.txtbuscarCod.Location = new System.Drawing.Point(195, 25);
            this.txtbuscarCod.Name = "txtbuscarCod";
            this.txtbuscarCod.Size = new System.Drawing.Size(316, 20);
            this.txtbuscarCod.TabIndex = 2;
            this.txtbuscarCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarCod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Busqueda por Codigo de barra";
            // 
            // flexProductosCod
            // 
            this.flexProductosCod.ColumnInfo = resources.GetString("flexProductosCod.ColumnInfo");
            this.flexProductosCod.Location = new System.Drawing.Point(27, 64);
            this.flexProductosCod.Name = "flexProductosCod";
            this.flexProductosCod.Rows.DefaultSize = 19;
            this.flexProductosCod.Size = new System.Drawing.Size(675, 129);
            this.flexProductosCod.TabIndex = 0;
            this.flexProductosCod.SelChange += new System.EventHandler(this.flexProductosCod_SelChange);
            this.flexProductosCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flexProductosCod_KeyPress);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grupo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Stock";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Grupo2.ResumeLayout(false);
            this.Grupo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrillaClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexProductosCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGrillaClientes;
        private System.Windows.Forms.ToolStripMenuItem crearClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarUsuariosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbuscarCod;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1FlexGrid.C1FlexGrid flexProductosCod;
        private System.Windows.Forms.ToolStripMenuItem permisosSistemaToolStripMenuItem;
    }
}

