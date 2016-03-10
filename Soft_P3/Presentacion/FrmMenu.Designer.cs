namespace Soft_P3.Presentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitFromSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compañiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptInvioce = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCoprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserChangePass1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpTopics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.statMain = new System.Windows.Forms.StatusStrip();
            this.Desarrolladores = new System.Windows.Forms.ToolStripStatusLabel();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBilling,
            this.salesSeparator,
            this.comprasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnuLogOff,
            this.mnuExitFromSystem});
            this.mnuFile.Image = global::Soft_P3.Properties.Resources.home;
            this.mnuFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(78, 24);
            this.mnuFile.Text = "Inicio";
            // 
            // mnuBilling
            // 
            this.mnuBilling.Image = global::Soft_P3.Properties.Resources.pos_2;
            this.mnuBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBilling.Name = "mnuBilling";
            this.mnuBilling.Size = new System.Drawing.Size(188, 26);
            this.mnuBilling.Text = "Facturación";
            this.mnuBilling.Click += new System.EventHandler(this.mnuBilling_Click);
            // 
            // salesSeparator
            // 
            this.salesSeparator.Name = "salesSeparator";
            this.salesSeparator.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuLogOff
            // 
            this.mnuLogOff.Image = global::Soft_P3.Properties.Resources.logout;
            this.mnuLogOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuLogOff.Name = "mnuLogOff";
            this.mnuLogOff.Size = new System.Drawing.Size(188, 26);
            this.mnuLogOff.Text = "Cerrar Sesión";
            // 
            // mnuExitFromSystem
            // 
            this.mnuExitFromSystem.Image = global::Soft_P3.Properties.Resources.exit_96_192px_1143852_easyicon_net;
            this.mnuExitFromSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuExitFromSystem.Name = "mnuExitFromSystem";
            this.mnuExitFromSystem.Size = new System.Drawing.Size(188, 26);
            this.mnuExitFromSystem.Text = "Salir del Sistema";
            // 
            // mnuCatalog
            // 
            this.mnuCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatProduct,
            this.mnuCatClient,
            this.mnuCatProvider,
            this.empleadosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.compañiaToolStripMenuItem});
            this.mnuCatalog.Image = global::Soft_P3.Properties.Resources.folder;
            this.mnuCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuCatalog.Name = "mnuCatalog";
            this.mnuCatalog.Size = new System.Drawing.Size(105, 24);
            this.mnuCatalog.Text = "&Catálogos";
            // 
            // mnuCatProduct
            // 
            this.mnuCatProduct.Image = global::Soft_P3.Properties.Resources.product;
            this.mnuCatProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuCatProduct.Name = "mnuCatProduct";
            this.mnuCatProduct.Size = new System.Drawing.Size(162, 26);
            this.mnuCatProduct.Text = "Articulos";
            this.mnuCatProduct.Click += new System.EventHandler(this.mnuCatProduct_Click);
            // 
            // mnuCatClient
            // 
            this.mnuCatClient.Image = global::Soft_P3.Properties.Resources.customers;
            this.mnuCatClient.Name = "mnuCatClient";
            this.mnuCatClient.Size = new System.Drawing.Size(162, 26);
            this.mnuCatClient.Text = "Clientes";
            this.mnuCatClient.Click += new System.EventHandler(this.mnuCatClient_Click);
            // 
            // mnuCatProvider
            // 
            this.mnuCatProvider.Image = global::Soft_P3.Properties.Resources.suppliers;
            this.mnuCatProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuCatProvider.Name = "mnuCatProvider";
            this.mnuCatProvider.Size = new System.Drawing.Size(162, 26);
            this.mnuCatProvider.Text = "Proveedores";
            this.mnuCatProvider.Click += new System.EventHandler(this.mnuCatProvider_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = global::Soft_P3.Properties.Resources.hire_me;
            this.empleadosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = global::Soft_P3.Properties.Resources.category;
            this.categoriaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // compañiaToolStripMenuItem
            // 
            this.compañiaToolStripMenuItem.Image = global::Soft_P3.Properties.Resources.library;
            this.compañiaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compañiaToolStripMenuItem.Name = "compañiaToolStripMenuItem";
            this.compañiaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.compañiaToolStripMenuItem.Text = "Compañia";
            this.compañiaToolStripMenuItem.Click += new System.EventHandler(this.compañiaToolStripMenuItem_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRptInvioce,
            this.entradasToolStripMenuItem,
            this.salidasToolStripMenuItem,
            this.cuentasPorPagarToolStripMenuItem,
            this.cuentasPorCoprarToolStripMenuItem});
            this.mnuReports.Image = global::Soft_P3.Properties.Resources.publish;
            this.mnuReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(99, 24);
            this.mnuReports.Text = "&Reportes";
            // 
            // mnuRptInvioce
            // 
            this.mnuRptInvioce.Image = global::Soft_P3.Properties.Resources.bill_factura_invoice_72px_3656_easyicon_net;
            this.mnuRptInvioce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuRptInvioce.Name = "mnuRptInvioce";
            this.mnuRptInvioce.Size = new System.Drawing.Size(211, 26);
            this.mnuRptInvioce.Text = "Facturas";
            // 
            // cuentasPorPagarToolStripMenuItem
            // 
            this.cuentasPorPagarToolStripMenuItem.Name = "cuentasPorPagarToolStripMenuItem";
            this.cuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.cuentasPorPagarToolStripMenuItem.Text = "Cuentas Por Pagar";
            // 
            // cuentasPorCoprarToolStripMenuItem
            // 
            this.cuentasPorCoprarToolStripMenuItem.Name = "cuentasPorCoprarToolStripMenuItem";
            this.cuentasPorCoprarToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.cuentasPorCoprarToolStripMenuItem.Text = "Cuentas Por Cobrar";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers});
            this.mnuManage.Image = global::Soft_P3.Properties.Resources.administrative_docs;
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(118, 24);
            this.mnuManage.Text = "Ad&ministrar";
            // 
            // mnuUsers
            // 
            this.mnuUsers.Image = global::Soft_P3.Properties.Resources.user;
            this.mnuUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(156, 26);
            this.mnuUsers.Text = "Usuarios";
            this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserChangePass1});
            this.mnuOptions.Image = global::Soft_P3.Properties.Resources.settings;
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(101, 24);
            this.mnuOptions.Text = "Opciones";
            // 
            // mnuUserChangePass1
            // 
            this.mnuUserChangePass1.Name = "mnuUserChangePass1";
            this.mnuUserChangePass1.Size = new System.Drawing.Size(226, 24);
            this.mnuUserChangePass1.Text = "Cambiar mi contraseña";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowCascade,
            this.mnuWindowHorizontal,
            this.mnuWindowVertical});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(74, 24);
            this.mnuWindow.Text = "&Ventana";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(230, 24);
            this.mnuWindowCascade.Text = "Ventanas en Cascada";
            // 
            // mnuWindowHorizontal
            // 
            this.mnuWindowHorizontal.Name = "mnuWindowHorizontal";
            this.mnuWindowHorizontal.Size = new System.Drawing.Size(230, 24);
            this.mnuWindowHorizontal.Text = "Ventanas en Horizontal";
            // 
            // mnuWindowVertical
            // 
            this.mnuWindowVertical.Name = "mnuWindowVertical";
            this.mnuWindowVertical.Size = new System.Drawing.Size(230, 24);
            this.mnuWindowVertical.Text = "Ventanas en Vertical";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuHelpTopics});
            this.mnuHelp.Image = global::Soft_P3.Properties.Resources.consulting;
            this.mnuHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(82, 24);
            this.mnuHelp.Text = "A&yuda";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(185, 24);
            this.mnuAbout.Text = "Acerca de...";
            // 
            // mnuHelpTopics
            // 
            this.mnuHelpTopics.Name = "mnuHelpTopics";
            this.mnuHelpTopics.Size = new System.Drawing.Size(185, 24);
            this.mnuHelpTopics.Text = "Temas de Ayuda";
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnuMain.Font = new System.Drawing.Font("Bell MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCatalog,
            this.mnuReports,
            this.mnuManage,
            this.mnuOptions,
            this.mnuWindow,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(770, 28);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // statMain
            // 
            this.statMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Desarrolladores});
            this.statMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statMain.Location = new System.Drawing.Point(0, 392);
            this.statMain.Name = "statMain";
            this.statMain.Size = new System.Drawing.Size(770, 22);
            this.statMain.TabIndex = 6;
            this.statMain.Text = "statusStrip1";
            // 
            // Desarrolladores
            // 
            this.Desarrolladores.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desarrolladores.Name = "Desarrolladores";
            this.Desarrolladores.Size = new System.Drawing.Size(1041, 17);
            this.Desarrolladores.Text = resources.GetString("Desarrolladores.Text");
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Image = global::Soft_P3.Properties.Resources.basket;
            this.comprasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(770, 414);
            this.Controls.Add(this.statMain);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statMain.ResumeLayout(false);
            this.statMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuBilling;
        private System.Windows.Forms.ToolStripSeparator salesSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOff;
        private System.Windows.Forms.ToolStripMenuItem mnuExitFromSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuCatProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuCatClient;
        private System.Windows.Forms.ToolStripMenuItem mnuCatProvider;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compañiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuRptInvioce;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCoprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuUserChangePass1;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpTopics;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip statMain;
        private System.Windows.Forms.ToolStripStatusLabel Desarrolladores;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
    }
}