namespace Soft_P3.Presentacion
{
    partial class frmDetalleFactura
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
            this.label12 = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClieNom = new System.Windows.Forms.TextBox();
            this.txtIdUsu = new System.Windows.Forms.TextBox();
            this.txtClieId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtItbis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscArt = new System.Windows.Forms.Button();
            this.txtArtId = new System.Windows.Forms.TextBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtArtDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnRegFact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bell MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(406, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 37);
            this.label12.TabIndex = 39;
            this.label12.Text = "Detalles Facturas";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvFactura.Location = new System.Drawing.Point(4, 23);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.RowTemplate.Height = 24;
            this.dgvFactura.Size = new System.Drawing.Size(994, 196);
            this.dgvFactura.TabIndex = 4;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFactura);
            this.groupBox4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 266);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(1000, 227);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles de Facturas";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::Soft_P3.Properties.Resources.user1;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(376, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::Soft_P3.Properties.Resources.customers1;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(201, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Enabled = false;
            this.txtIdFactura.Location = new System.Drawing.Point(126, 24);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(185, 26);
            this.txtIdFactura.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(5, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 15;
            this.label17.Text = "ID Fact";
            // 
            // txtCFactura
            // 
            this.txtCFactura.Enabled = false;
            this.txtCFactura.Location = new System.Drawing.Point(126, 56);
            this.txtCFactura.Name = "txtCFactura";
            this.txtCFactura.Size = new System.Drawing.Size(185, 26);
            this.txtCFactura.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Soft_P3.Properties.Resources.invoice1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(5, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "No. Factura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClieNom
            // 
            this.txtClieNom.Enabled = false;
            this.txtClieNom.Location = new System.Drawing.Point(246, 125);
            this.txtClieNom.Name = "txtClieNom";
            this.txtClieNom.Size = new System.Drawing.Size(299, 26);
            this.txtClieNom.TabIndex = 16;
            this.txtClieNom.TextChanged += new System.EventHandler(this.txtClieNom_TextChanged);
            // 
            // txtIdUsu
            // 
            this.txtIdUsu.Enabled = false;
            this.txtIdUsu.Location = new System.Drawing.Point(468, 60);
            this.txtIdUsu.Name = "txtIdUsu";
            this.txtIdUsu.Size = new System.Drawing.Size(37, 26);
            this.txtIdUsu.TabIndex = 30;
            // 
            // txtClieId
            // 
            this.txtClieId.Enabled = false;
            this.txtClieId.Location = new System.Drawing.Point(204, 125);
            this.txtClieId.Name = "txtClieId";
            this.txtClieId.Size = new System.Drawing.Size(37, 26);
            this.txtClieId.TabIndex = 30;
            this.txtClieId.TextChanged += new System.EventHandler(this.txtClieId_TextChanged);
            // 
            // label4
            // 
            this.label4.Image = global::Soft_P3.Properties.Resources.payment_card1;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de Pago";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.Enabled = false;
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Credito",
            "Al contado"});
            this.cmbTipoPago.Location = new System.Drawing.Point(9, 125);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(185, 27);
            this.cmbTipoPago.TabIndex = 35;
            this.cmbTipoPago.Text = "Credito";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtItbis);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPrecioVenta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnBuscArt);
            this.groupBox2.Controls.Add(this.cmbTipoPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtArtId);
            this.groupBox2.Controls.Add(this.txtClieId);
            this.groupBox2.Controls.Add(this.txtIdUsu);
            this.groupBox2.Controls.Add(this.dtpFechaFactura);
            this.groupBox2.Controls.Add(this.txtArtDes);
            this.groupBox2.Controls.Add(this.txtClieNom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCFactura);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIdFactura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 39);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1000, 223);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de Facturas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtItbis
            // 
            this.txtItbis.Enabled = false;
            this.txtItbis.Location = new System.Drawing.Point(416, 186);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(76, 26);
            this.txtItbis.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(412, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 74;
            this.label11.Text = "ITBIS";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Location = new System.Drawing.Point(303, 186);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(107, 26);
            this.txtPrecioVenta.TabIndex = 73;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 72;
            this.label9.Text = "Precio Venta";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(498, 186);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(47, 26);
            this.txtStock.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(495, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Stock";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(205, 186);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(92, 26);
            this.txtCantidad.TabIndex = 69;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 68;
            this.label7.Text = "Cantidad";
            // 
            // btnBuscArt
            // 
            this.btnBuscArt.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscArt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscArt.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscArt.Location = new System.Drawing.Point(550, 186);
            this.btnBuscArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscArt.Name = "btnBuscArt";
            this.btnBuscArt.Size = new System.Drawing.Size(65, 26);
            this.btnBuscArt.TabIndex = 62;
            this.btnBuscArt.Text = "Buscar";
            this.btnBuscArt.UseVisualStyleBackColor = false;
            this.btnBuscArt.Click += new System.EventHandler(this.btnBuscArt_Click);
            // 
            // txtArtId
            // 
            this.txtArtId.Enabled = false;
            this.txtArtId.Location = new System.Drawing.Point(9, 186);
            this.txtArtId.Name = "txtArtId";
            this.txtArtId.Size = new System.Drawing.Size(37, 26);
            this.txtArtId.TabIndex = 30;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Enabled = false;
            this.dtpFechaFactura.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaFactura.Location = new System.Drawing.Point(468, 22);
            this.dtpFechaFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(185, 24);
            this.dtpFechaFactura.TabIndex = 33;
            // 
            // txtArtDes
            // 
            this.txtArtDes.Enabled = false;
            this.txtArtDes.Location = new System.Drawing.Point(51, 186);
            this.txtArtDes.Name = "txtArtDes";
            this.txtArtDes.Size = new System.Drawing.Size(143, 26);
            this.txtArtDes.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::Soft_P3.Properties.Resources.date1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(390, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::Soft_P3.Properties.Resources.product1;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Articulo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(550, 125);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 26);
            this.btnBuscarCliente.TabIndex = 76;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(11, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 113);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Bruto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Impuestos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "Descuento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 19);
            this.label15.TabIndex = 17;
            this.label15.Text = "Total a Pagar: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Soft_P3.Properties.Resources.pos_2;
            this.pictureBox1.Location = new System.Drawing.Point(758, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Soft_P3.Properties.Resources.plus;
            this.btnGuardar.Location = new System.Drawing.Point(632, 166);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 46);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::Soft_P3.Properties.Resources.busy;
            this.btnQuitar.Location = new System.Drawing.Point(697, 166);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(59, 46);
            this.btnQuitar.TabIndex = 78;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnRegFact
            // 
            this.btnRegFact.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRegFact.Image = global::Soft_P3.Properties.Resources.issue;
            this.btnRegFact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegFact.Location = new System.Drawing.Point(876, 552);
            this.btnRegFact.Name = "btnRegFact";
            this.btnRegFact.Size = new System.Drawing.Size(135, 59);
            this.btnRegFact.TabIndex = 18;
            this.btnRegFact.Text = "Registrar";
            this.btnRegFact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegFact.UseVisualStyleBackColor = true;
            // 
            // frmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 619);
            this.Controls.Add(this.btnRegFact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Factura";
            this.Load += new System.EventHandler(this.frmDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClieNom;
        private System.Windows.Forms.TextBox txtIdUsu;
        private System.Windows.Forms.TextBox txtClieId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtItbis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscArt;
        private System.Windows.Forms.TextBox txtArtId;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.TextBox txtArtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegFact;
    }
}