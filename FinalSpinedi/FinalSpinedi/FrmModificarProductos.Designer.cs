namespace FinalSpinedi
{
    partial class FrmModificarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProductos));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbuscarCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flexProductos = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpfecha_nac = new System.Windows.Forms.DateTimePicker();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtPrecioProveedor = new System.Windows.Forms.TextBox();
            this.txtPrecioPublico = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 23);
            this.label9.TabIndex = 101;
            this.label9.Text = "Asistente para modificar productos en el sistema";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtbuscarCod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.flexProductos);
            this.groupBox1.Location = new System.Drawing.Point(25, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 213);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos ";
            // 
            // txtbuscarCod
            // 
            this.txtbuscarCod.Location = new System.Drawing.Point(195, 25);
            this.txtbuscarCod.Name = "txtbuscarCod";
            this.txtbuscarCod.Size = new System.Drawing.Size(316, 20);
            this.txtbuscarCod.TabIndex = 2;
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
            // flexProductos
            // 
            this.flexProductos.ColumnInfo = resources.GetString("flexProductos.ColumnInfo");
            this.flexProductos.Location = new System.Drawing.Point(26, 64);
            this.flexProductos.Name = "flexProductos";
            this.flexProductos.Rows.DefaultSize = 19;
            this.flexProductos.Size = new System.Drawing.Size(698, 129);
            this.flexProductos.TabIndex = 0;
            this.flexProductos.SelChange += new System.EventHandler(this.flexProductos_SelChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.txtbarra);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpfecha_nac);
            this.groupBox2.Controls.Add(this.cbProveedor);
            this.groupBox2.Controls.Add(this.cbEstado);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.txtDescrip);
            this.groupBox2.Controls.Add(this.txtPrecioProveedor);
            this.groupBox2.Controls.Add(this.txtPrecioPublico);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(25, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 249);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Producto";
            // 
            // txtbarra
            // 
            this.txtbarra.Location = new System.Drawing.Point(510, 164);
            this.txtbarra.Name = "txtbarra";
            this.txtbarra.Size = new System.Drawing.Size(196, 20);
            this.txtbarra.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Codigo de barras";
            // 
            // dtpfecha_nac
            // 
            this.dtpfecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha_nac.Location = new System.Drawing.Point(510, 126);
            this.dtpfecha_nac.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpfecha_nac.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfecha_nac.Name = "dtpfecha_nac";
            this.dtpfecha_nac.ShowUpDown = true;
            this.dtpfecha_nac.Size = new System.Drawing.Size(196, 20);
            this.dtpfecha_nac.TabIndex = 7;
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(112, 94);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(196, 21);
            this.cbProveedor.TabIndex = 2;
            this.cbProveedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbProveedor_MouseClick);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(112, 64);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(196, 21);
            this.cbEstado.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(535, 209);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(631, 209);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(510, 64);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(196, 46);
            this.txtDescrip.TabIndex = 6;
            // 
            // txtPrecioProveedor
            // 
            this.txtPrecioProveedor.Location = new System.Drawing.Point(510, 32);
            this.txtPrecioProveedor.Name = "txtPrecioProveedor";
            this.txtPrecioProveedor.Size = new System.Drawing.Size(196, 20);
            this.txtPrecioProveedor.TabIndex = 5;
            this.txtPrecioProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProveedor_KeyPress);
            // 
            // txtPrecioPublico
            // 
            this.txtPrecioPublico.Location = new System.Drawing.Point(112, 129);
            this.txtPrecioPublico.Name = "txtPrecioPublico";
            this.txtPrecioPublico.Size = new System.Drawing.Size(196, 20);
            this.txtPrecioPublico.TabIndex = 3;
            this.txtPrecioPublico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioPublico_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precio al publico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(112, 161);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(196, 20);
            this.txtcantidad.TabIndex = 12;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // FrmModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Name = "FrmModificarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Productos";
            this.Load += new System.EventHandler(this.FrmModificarClientecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbuscarCod;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1FlexGrid.C1FlexGrid flexProductos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpfecha_nac;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtPrecioProveedor;
        private System.Windows.Forms.TextBox txtPrecioPublico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcantidad;
    }
}