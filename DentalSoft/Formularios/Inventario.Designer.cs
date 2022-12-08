namespace DentalSoft.Formularios
{
    partial class Inventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInventario = new DentalSoft.Datos.DataSetInventario();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.rvInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblErrorFiltro = new System.Windows.Forms.Label();
            this.btnTodos = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnFiltrar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.mcFechaFin = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.mcFechaInicio = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.cbAlmacen = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.cbCategorias = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.cbFiltros = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.productoTableAdapter = new DentalSoft.Datos.DataSetInventarioTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).BeginInit();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dataSetInventario;
            // 
            // dataSetInventario
            // 
            this.dataSetInventario.DataSetName = "DataSetInventario";
            this.dataSetInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.btnRedimensionar);
            this.pnlCabecera.Controls.Add(this.btnMinimizar);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1214, 35);
            this.pnlCabecera.TabIndex = 10;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 23);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "DentalSoft";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedimensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedimensionar.Image = ((System.Drawing.Image)(resources.GetObject("btnRedimensionar.Image")));
            this.btnRedimensionar.Location = new System.Drawing.Point(1134, 3);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(25, 25);
            this.btnRedimensionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRedimensionar.TabIndex = 10;
            this.btnRedimensionar.TabStop = false;
            this.btnRedimensionar.Click += new System.EventHandler(this.btnRedimensionar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1093, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1177, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.rvInventario);
            this.pnlContenedor.Location = new System.Drawing.Point(25, 62);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(794, 577);
            this.pnlContenedor.TabIndex = 11;
            // 
            // rvInventario
            // 
            this.rvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetInventario";
            reportDataSource1.Value = this.productoBindingSource;
            this.rvInventario.LocalReport.DataSources.Add(reportDataSource1);
            this.rvInventario.LocalReport.ReportEmbeddedResource = "DentalSoft.Informes.InformeInventarios.rdlc";
            this.rvInventario.Location = new System.Drawing.Point(0, 0);
            this.rvInventario.Name = "rvInventario";
            this.rvInventario.ServerReport.BearerToken = null;
            this.rvInventario.Size = new System.Drawing.Size(794, 577);
            this.rvInventario.TabIndex = 0;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(854, 121);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(97, 23);
            this.lblFiltrar.TabIndex = 13;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(854, 212);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(106, 23);
            this.lblCategorias.TabIndex = 15;
            this.lblCategorias.Text = "Categorías:";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacen.Location = new System.Drawing.Point(854, 212);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(109, 23);
            this.lblAlmacen.TabIndex = 17;
            this.lblAlmacen.Text = "Almacenes:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(854, 212);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(117, 23);
            this.lblFechaInicio.TabIndex = 22;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(855, 353);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(92, 23);
            this.lblFechaFin.TabIndex = 23;
            this.lblFechaFin.Text = "Fecha fin:";
            // 
            // lblErrorFiltro
            // 
            this.lblErrorFiltro.AutoSize = true;
            this.lblErrorFiltro.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFiltro.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorFiltro.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorFiltro.Image")));
            this.lblErrorFiltro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorFiltro.Location = new System.Drawing.Point(903, 607);
            this.lblErrorFiltro.Name = "lblErrorFiltro";
            this.lblErrorFiltro.Size = new System.Drawing.Size(85, 15);
            this.lblErrorFiltro.TabIndex = 90;
            this.lblErrorFiltro.Text = "Mensaje Error";
            this.lblErrorFiltro.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodos.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnTodos.BordeRadio = 32;
            this.btnTodos.BordeTamaño = 0;
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodos.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(1062, 560);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(114, 34);
            this.btnTodos.TabIndex = 30;
            this.btnTodos.Text = "Ver Todos";
            this.btnTodos.TextoColor = System.Drawing.Color.White;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltrar.BordeRadio = 32;
            this.btnFiltrar.BordeTamaño = 0;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(906, 560);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(114, 34);
            this.btnFiltrar.TabIndex = 25;
            this.btnFiltrar.Text = "Aplicar Filtro";
            this.btnFiltrar.TextoColor = System.Drawing.Color.White;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // mcFechaFin
            // 
            this.mcFechaFin.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.mcFechaFin.BordeTamaño = 0;
            this.mcFechaFin.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.mcFechaFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mcFechaFin.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFechaFin.Font = new System.Drawing.Font("Roboto", 11F);
            this.mcFechaFin.IsDesplegado = false;
            this.mcFechaFin.Location = new System.Drawing.Point(907, 379);
            this.mcFechaFin.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.mcFechaFin.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFechaFin.Name = "mcFechaFin";
            this.mcFechaFin.Size = new System.Drawing.Size(270, 35);
            this.mcFechaFin.TabIndex = 20;
            this.mcFechaFin.TextoColor = System.Drawing.Color.White;
            this.mcFechaFin.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            // 
            // mcFechaInicio
            // 
            this.mcFechaInicio.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.mcFechaInicio.BordeTamaño = 0;
            this.mcFechaInicio.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.mcFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mcFechaInicio.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.mcFechaInicio.IsDesplegado = false;
            this.mcFechaInicio.Location = new System.Drawing.Point(906, 243);
            this.mcFechaInicio.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.mcFechaInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFechaInicio.Name = "mcFechaInicio";
            this.mcFechaInicio.Size = new System.Drawing.Size(270, 35);
            this.mcFechaInicio.TabIndex = 15;
            this.mcFechaInicio.TextoColor = System.Drawing.Color.White;
            this.mcFechaInicio.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbAlmacen.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbAlmacen.BordeTamaño = 1;
            this.cbAlmacen.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbAlmacen.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbAlmacen.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAlmacen.ForeColor = System.Drawing.Color.Black;
            this.cbAlmacen.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbAlmacen.ListColorTexto = System.Drawing.Color.Black;
            this.cbAlmacen.Location = new System.Drawing.Point(976, 214);
            this.cbAlmacen.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Padding = new System.Windows.Forms.Padding(1);
            this.cbAlmacen.Size = new System.Drawing.Size(200, 30);
            this.cbAlmacen.TabIndex = 5;
            this.cbAlmacen.Textos = "";
            // 
            // cbCategorias
            // 
            this.cbCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCategorias.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCategorias.BordeTamaño = 1;
            this.cbCategorias.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCategorias.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCategorias.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCategorias.ForeColor = System.Drawing.Color.Black;
            this.cbCategorias.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCategorias.ListColorTexto = System.Drawing.Color.Black;
            this.cbCategorias.Location = new System.Drawing.Point(976, 214);
            this.cbCategorias.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategorias.Size = new System.Drawing.Size(200, 30);
            this.cbCategorias.TabIndex = 10;
            this.cbCategorias.Textos = "";
            // 
            // cbFiltros
            // 
            this.cbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.BordeTamaño = 1;
            this.cbFiltros.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltros.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltros.ForeColor = System.Drawing.Color.Black;
            this.cbFiltros.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltros.ListColorTexto = System.Drawing.Color.Black;
            this.cbFiltros.Location = new System.Drawing.Point(976, 116);
            this.cbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Padding = new System.Windows.Forms.Padding(1);
            this.cbFiltros.Size = new System.Drawing.Size(200, 30);
            this.cbFiltros.TabIndex = 0;
            this.cbFiltros.Textos = "";
            this.cbFiltros.OnSelectedIndexChanged += new System.EventHandler(this.cbFiltros_OnSelectedIndexChanged);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1214, 669);
            this.Controls.Add(this.lblErrorFiltro);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.mcFechaFin);
            this.Controls.Add(this.mcFechaInicio);
            this.Controls.Add(this.lblAlmacen);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cbFiltros);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInventario)).EndInit();
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private ControlesPersonalizados.ComboBoxPersonalizado cbFiltros;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblCategorias;
        private ControlesPersonalizados.ComboBoxPersonalizado cbCategorias;
        private System.Windows.Forms.Label lblAlmacen;
        private ControlesPersonalizados.ComboBoxPersonalizado cbAlmacen;
        private ControlesPersonalizados.SelectorFecha mcFechaInicio;
        private ControlesPersonalizados.SelectorFecha mcFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private ControlesPersonalizados.BotonPersonalizado btnFiltrar;
        private ControlesPersonalizados.BotonPersonalizado btnTodos;
        private System.Windows.Forms.Label lblErrorFiltro;
        private Microsoft.Reporting.WinForms.ReportViewer rvInventario;
        private Datos.DataSetInventario dataSetInventario;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Datos.DataSetInventarioTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}