namespace Soft_P3
{
    partial class frmFactura
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsu = new System.Windows.Forms.Button();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUsu = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNomClie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCFactura = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvFactura.Location = new System.Drawing.Point(6, 60);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowTemplate.Height = 24;
            this.dgvFactura.Size = new System.Drawing.Size(1325, 265);
            this.dgvFactura.TabIndex = 4;
            this.dgvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellClick);
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFactura_CellContentClick);
            this.dgvFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtBuscarVenta);
            this.groupBox4.Controls.Add(this.dgvFactura);
            this.groupBox4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(22, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1337, 331);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles de Facturas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(867, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Buscar Venta";
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.Location = new System.Drawing.Point(1043, 23);
            this.txtBuscarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Size = new System.Drawing.Size(288, 30);
            this.txtBuscarVenta.TabIndex = 45;
            this.txtBuscarVenta.TextChanged += new System.EventHandler(this.txtBuscarArti_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bell MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(547, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 46);
            this.label12.TabIndex = 34;
            this.label12.Text = "Facturacion";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaFactura.Location = new System.Drawing.Point(147, 137);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(232, 28);
            this.dtpFechaFactura.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnUsu);
            this.groupBox2.Controls.Add(this.btnBuscarCli);
            this.groupBox2.Controls.Add(this.cmbTipoPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.txtIdUsu);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.dtpFechaFactura);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNomClie);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCFactura);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtIdFactura);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(25, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 318);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Factura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(610, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(143, 36);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Aqua;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(804, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 36);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Aqua;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(610, 197);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 36);
            this.btnEditar.TabIndex = 65;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Aqua;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(804, 197);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(143, 36);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Soft_P3.Properties.Resources.pos_2;
            this.pictureBox1.Location = new System.Drawing.Point(981, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsu
            // 
            this.btnUsu.BackColor = System.Drawing.Color.Aqua;
            this.btnUsu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUsu.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsu.Location = new System.Drawing.Point(296, 275);
            this.btnUsu.Name = "btnUsu";
            this.btnUsu.Size = new System.Drawing.Size(87, 29);
            this.btnUsu.TabIndex = 62;
            this.btnUsu.Text = "Buscar";
            this.btnUsu.UseVisualStyleBackColor = false;
            this.btnUsu.Click += new System.EventHandler(this.btnUsu_Click);
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarCli.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCli.Location = new System.Drawing.Point(398, 87);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(87, 29);
            this.btnBuscarCli.TabIndex = 62;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = false;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCa_Click);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Credito",
            "Al contado"});
            this.cmbTipoPago.Location = new System.Drawing.Point(147, 184);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(232, 32);
            this.cmbTipoPago.TabIndex = 35;
            this.cmbTipoPago.Text = "Credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de Pago";
            // 
            // txtIdUsu
            // 
            this.txtIdUsu.Enabled = false;
            this.txtIdUsu.Location = new System.Drawing.Point(151, 274);
            this.txtIdUsu.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsu.Name = "txtIdUsu";
            this.txtIdUsu.Size = new System.Drawing.Size(48, 30);
            this.txtIdUsu.TabIndex = 30;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(147, 86);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(48, 30);
            this.txtIdCliente.TabIndex = 30;
            // 
            // txtNomClie
            // 
            this.txtNomClie.Enabled = false;
            this.txtNomClie.Location = new System.Drawing.Point(203, 86);
            this.txtNomClie.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.Size = new System.Drawing.Size(176, 30);
            this.txtNomClie.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "No. Factura";
            // 
            // txtCFactura
            // 
            this.txtCFactura.Location = new System.Drawing.Point(151, 233);
            this.txtCFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtCFactura.Name = "txtCFactura";
            this.txtCFactura.Size = new System.Drawing.Size(232, 30);
            this.txtCFactura.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(7, 37);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 24);
            this.label17.TabIndex = 15;
            this.label17.Text = "ID Fact";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Enabled = false;
            this.txtIdFactura.Location = new System.Drawing.Point(147, 30);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(232, 30);
            this.txtIdFactura.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuario";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(7, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 24);
            this.label18.TabIndex = 13;
            this.label18.Text = "Cliente";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(203, 274);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(86, 30);
            this.txtUsuario.TabIndex = 30;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1381, 721);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNomClie;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCFactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button btnUsu;
        private System.Windows.Forms.TextBox txtIdUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}

