namespace DentalSoft.Formularios
{
    partial class NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProducto));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblErrorGuardar = new System.Windows.Forms.Label();
            this.lblErrorCaducidad = new System.Windows.Forms.Label();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.lblErrorReferencia = new System.Windows.Forms.Label();
            this.lblErrorCategoria = new System.Windows.Forms.Label();
            this.lblErrorAlmacen = new System.Windows.Forms.Label();
            this.lblErrorLote = new System.Windows.Forms.Label();
            this.lblErrorCoste = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnGuardarProducto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.mcCaducidad = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.cbAlmacen = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.cbCategoria = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.txtLote = new DentalSoft.TextboxPersonalizado();
            this.txtCoste = new DentalSoft.TextboxPersonalizado();
            this.txtDescripcion = new DentalSoft.TextboxPersonalizado();
            this.txtCantidad = new DentalSoft.TextboxPersonalizado();
            this.txtReferencia = new DentalSoft.TextboxPersonalizado();
            this.lblTituloAlmacen = new System.Windows.Forms.Label();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.lblTituloLote = new System.Windows.Forms.Label();
            this.lblTituloCaducidad = new System.Windows.Forms.Label();
            this.lblTituloCoste = new System.Windows.Forms.Label();
            this.lblTituloCantidad = new System.Windows.Forms.Label();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblTituloReferencia = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(790, 38);
            this.pnlCabecera.TabIndex = 1;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 29);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "DentalSoft";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedimensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedimensionar.Image = ((System.Drawing.Image)(resources.GetObject("btnRedimensionar.Image")));
            this.btnRedimensionar.Location = new System.Drawing.Point(696, 3);
            this.btnRedimensionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(29, 27);
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
            this.btnMinimizar.Location = new System.Drawing.Point(648, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
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
            this.btnCerrar.Location = new System.Drawing.Point(746, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblEuro);
            this.panel1.Controls.Add(this.lblErrorGuardar);
            this.panel1.Controls.Add(this.lblErrorCaducidad);
            this.panel1.Controls.Add(this.lblErrorDescripcion);
            this.panel1.Controls.Add(this.lblErrorReferencia);
            this.panel1.Controls.Add(this.lblErrorCategoria);
            this.panel1.Controls.Add(this.lblErrorAlmacen);
            this.panel1.Controls.Add(this.lblErrorLote);
            this.panel1.Controls.Add(this.lblErrorCoste);
            this.panel1.Controls.Add(this.lblErrorCantidad);
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.btnGuardarProducto);
            this.panel1.Controls.Add(this.mcCaducidad);
            this.panel1.Controls.Add(this.cbAlmacen);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.txtLote);
            this.panel1.Controls.Add(this.txtCoste);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.lblTituloAlmacen);
            this.panel1.Controls.Add(this.lblTituloCategoria);
            this.panel1.Controls.Add(this.lblTituloLote);
            this.panel1.Controls.Add(this.lblTituloCaducidad);
            this.panel1.Controls.Add(this.lblTituloCoste);
            this.panel1.Controls.Add(this.lblTituloCantidad);
            this.panel1.Controls.Add(this.lblTituloDescripcion);
            this.panel1.Controls.Add(this.lblTituloReferencia);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 663);
            this.panel1.TabIndex = 2;
            // 
            // lblEuro
            // 
            this.lblEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblEuro.Location = new System.Drawing.Point(675, 310);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(26, 29);
            this.lblEuro.TabIndex = 121;
            this.lblEuro.Text = "€";
            // 
            // lblErrorGuardar
            // 
            this.lblErrorGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorGuardar.AutoSize = true;
            this.lblErrorGuardar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGuardar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorGuardar.Image")));
            this.lblErrorGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorGuardar.Location = new System.Drawing.Point(141, 629);
            this.lblErrorGuardar.Name = "lblErrorGuardar";
            this.lblErrorGuardar.Size = new System.Drawing.Size(106, 19);
            this.lblErrorGuardar.TabIndex = 120;
            this.lblErrorGuardar.Text = "Mensaje Error";
            this.lblErrorGuardar.Visible = false;
            // 
            // lblErrorCaducidad
            // 
            this.lblErrorCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCaducidad.AutoSize = true;
            this.lblErrorCaducidad.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCaducidad.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCaducidad.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCaducidad.Image")));
            this.lblErrorCaducidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCaducidad.Location = new System.Drawing.Point(141, 431);
            this.lblErrorCaducidad.Name = "lblErrorCaducidad";
            this.lblErrorCaducidad.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCaducidad.TabIndex = 119;
            this.lblErrorCaducidad.Text = "Mensaje Error";
            this.lblErrorCaducidad.Visible = false;
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorDescripcion.Image")));
            this.lblErrorDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(141, 267);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(106, 19);
            this.lblErrorDescripcion.TabIndex = 118;
            this.lblErrorDescripcion.Text = "Mensaje Error";
            this.lblErrorDescripcion.Visible = false;
            // 
            // lblErrorReferencia
            // 
            this.lblErrorReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorReferencia.AutoSize = true;
            this.lblErrorReferencia.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorReferencia.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorReferencia.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorReferencia.Image")));
            this.lblErrorReferencia.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorReferencia.Location = new System.Drawing.Point(141, 55);
            this.lblErrorReferencia.Name = "lblErrorReferencia";
            this.lblErrorReferencia.Size = new System.Drawing.Size(106, 19);
            this.lblErrorReferencia.TabIndex = 117;
            this.lblErrorReferencia.Text = "Mensaje Error";
            this.lblErrorReferencia.Visible = false;
            // 
            // lblErrorCategoria
            // 
            this.lblErrorCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCategoria.AutoSize = true;
            this.lblErrorCategoria.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCategoria.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCategoria.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCategoria.Image")));
            this.lblErrorCategoria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCategoria.Location = new System.Drawing.Point(141, 514);
            this.lblErrorCategoria.Name = "lblErrorCategoria";
            this.lblErrorCategoria.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCategoria.TabIndex = 116;
            this.lblErrorCategoria.Text = "Mensaje Error";
            this.lblErrorCategoria.Visible = false;
            // 
            // lblErrorAlmacen
            // 
            this.lblErrorAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorAlmacen.AutoSize = true;
            this.lblErrorAlmacen.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAlmacen.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorAlmacen.Image")));
            this.lblErrorAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorAlmacen.Location = new System.Drawing.Point(547, 514);
            this.lblErrorAlmacen.Name = "lblErrorAlmacen";
            this.lblErrorAlmacen.Size = new System.Drawing.Size(106, 19);
            this.lblErrorAlmacen.TabIndex = 115;
            this.lblErrorAlmacen.Text = "Mensaje Error";
            this.lblErrorAlmacen.Visible = false;
            // 
            // lblErrorLote
            // 
            this.lblErrorLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorLote.AutoSize = true;
            this.lblErrorLote.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLote.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorLote.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorLote.Image")));
            this.lblErrorLote.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorLote.Location = new System.Drawing.Point(547, 431);
            this.lblErrorLote.Name = "lblErrorLote";
            this.lblErrorLote.Size = new System.Drawing.Size(106, 19);
            this.lblErrorLote.TabIndex = 114;
            this.lblErrorLote.Text = "Mensaje Error";
            this.lblErrorLote.Visible = false;
            // 
            // lblErrorCoste
            // 
            this.lblErrorCoste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCoste.AutoSize = true;
            this.lblErrorCoste.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCoste.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCoste.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCoste.Image")));
            this.lblErrorCoste.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCoste.Location = new System.Drawing.Point(547, 349);
            this.lblErrorCoste.Name = "lblErrorCoste";
            this.lblErrorCoste.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCoste.TabIndex = 113;
            this.lblErrorCoste.Text = "Mensaje Error";
            this.lblErrorCoste.Visible = false;
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCantidad.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCantidad.Image")));
            this.lblErrorCantidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCantidad.Location = new System.Drawing.Point(141, 349);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCantidad.TabIndex = 112;
            this.lblErrorCantidad.Text = "Mensaje Error";
            this.lblErrorCantidad.Visible = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarCampos.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiarCampos.BordeRadio = 32;
            this.btnLimpiarCampos.BordeTamaño = 0;
            this.btnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(453, 584);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(256, 34);
            this.btnLimpiarCampos.TabIndex = 111;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.TextoColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarProducto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarProducto.BordeRadio = 32;
            this.btnGuardarProducto.BordeTamaño = 0;
            this.btnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProducto.Location = new System.Drawing.Point(138, 584);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(256, 34);
            this.btnGuardarProducto.TabIndex = 110;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.TextoColor = System.Drawing.Color.White;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // mcCaducidad
            // 
            this.mcCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcCaducidad.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.mcCaducidad.BordeTamaño = 0;
            this.mcCaducidad.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.mcCaducidad.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mcCaducidad.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcCaducidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.mcCaducidad.IsDesplegado = false;
            this.mcCaducidad.Location = new System.Drawing.Point(144, 387);
            this.mcCaducidad.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.mcCaducidad.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcCaducidad.Name = "mcCaducidad";
            this.mcCaducidad.Size = new System.Drawing.Size(271, 35);
            this.mcCaducidad.TabIndex = 106;
            this.mcCaducidad.TextoColor = System.Drawing.Color.White;
            this.mcCaducidad.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbAlmacen.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbAlmacen.BordeTamaño = 1;
            this.cbAlmacen.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbAlmacen.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbAlmacen.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbAlmacen.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbAlmacen.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlmacen.ForeColor = System.Drawing.Color.Black;
            this.cbAlmacen.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbAlmacen.ListColorTexto = System.Drawing.Color.Black;
            this.cbAlmacen.Location = new System.Drawing.Point(550, 471);
            this.cbAlmacen.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Padding = new System.Windows.Forms.Padding(1);
            this.cbAlmacen.Size = new System.Drawing.Size(200, 30);
            this.cbAlmacen.TabIndex = 109;
            this.cbAlmacen.Textos = "";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCategoria.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCategoria.BordeTamaño = 1;
            this.cbCategoria.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCategoria.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbCategoria.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCategoria.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cbCategoria.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCategoria.ListColorTexto = System.Drawing.Color.Black;
            this.cbCategoria.Location = new System.Drawing.Point(144, 471);
            this.cbCategoria.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategoria.Size = new System.Drawing.Size(271, 30);
            this.cbCategoria.TabIndex = 108;
            this.cbCategoria.Textos = "";
            // 
            // txtLote
            // 
            this.txtLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLote.BackColor = System.Drawing.SystemColors.Window;
            this.txtLote.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtLote.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtLote.BordeRadio = 0;
            this.txtLote.BordeTamaño = 2;
            this.txtLote.Contraseña = false;
            this.txtLote.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLote.ForeColor = System.Drawing.Color.Black;
            this.txtLote.Location = new System.Drawing.Point(550, 387);
            this.txtLote.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtLote.MarcadorPosicionTexto = "";
            this.txtLote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLote.Multilinea = false;
            this.txtLote.Name = "txtLote";
            this.txtLote.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLote.PosicionSeleccion = 0;
            this.txtLote.Size = new System.Drawing.Size(200, 39);
            this.txtLote.SubrayadoEstilo = true;
            this.txtLote.TabIndex = 107;
            this.txtLote.TamañoMaximo = 30000;
            this.txtLote.Texto = "";
            // 
            // txtCoste
            // 
            this.txtCoste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCoste.BackColor = System.Drawing.SystemColors.Window;
            this.txtCoste.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtCoste.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtCoste.BordeRadio = 0;
            this.txtCoste.BordeTamaño = 2;
            this.txtCoste.Contraseña = false;
            this.txtCoste.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCoste.ForeColor = System.Drawing.Color.Black;
            this.txtCoste.Location = new System.Drawing.Point(550, 305);
            this.txtCoste.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtCoste.MarcadorPosicionTexto = "";
            this.txtCoste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCoste.Multilinea = false;
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCoste.PosicionSeleccion = 0;
            this.txtCoste.Size = new System.Drawing.Size(118, 39);
            this.txtCoste.SubrayadoEstilo = true;
            this.txtCoste.TabIndex = 105;
            this.txtCoste.TamañoMaximo = 30000;
            this.txtCoste.Texto = "";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtDescripcion.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtDescripcion.BordeRadio = 0;
            this.txtDescripcion.BordeTamaño = 2;
            this.txtDescripcion.Contraseña = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(144, 92);
            this.txtDescripcion.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.MarcadorPosicionTexto = "";
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Multilinea = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PosicionSeleccion = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(606, 169);
            this.txtDescripcion.SubrayadoEstilo = true;
            this.txtDescripcion.TabIndex = 99;
            this.txtDescripcion.TamañoMaximo = 30000;
            this.txtDescripcion.Texto = "";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtCantidad.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtCantidad.BordeRadio = 0;
            this.txtCantidad.BordeTamaño = 2;
            this.txtCantidad.Contraseña = false;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(144, 305);
            this.txtCantidad.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.MarcadorPosicionTexto = "";
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Multilinea = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PosicionSeleccion = 0;
            this.txtCantidad.Size = new System.Drawing.Size(151, 39);
            this.txtCantidad.SubrayadoEstilo = true;
            this.txtCantidad.TabIndex = 104;
            this.txtCantidad.TamañoMaximo = 30000;
            this.txtCantidad.Texto = "";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReferencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtReferencia.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtReferencia.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtReferencia.BordeRadio = 0;
            this.txtReferencia.BordeTamaño = 2;
            this.txtReferencia.Contraseña = false;
            this.txtReferencia.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtReferencia.ForeColor = System.Drawing.Color.Black;
            this.txtReferencia.Location = new System.Drawing.Point(144, 14);
            this.txtReferencia.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtReferencia.MarcadorPosicionTexto = "";
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReferencia.Multilinea = false;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReferencia.PosicionSeleccion = 0;
            this.txtReferencia.Size = new System.Drawing.Size(250, 39);
            this.txtReferencia.SubrayadoEstilo = true;
            this.txtReferencia.TabIndex = 94;
            this.txtReferencia.TamañoMaximo = 30000;
            this.txtReferencia.Texto = "";
            // 
            // lblTituloAlmacen
            // 
            this.lblTituloAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloAlmacen.AutoSize = true;
            this.lblTituloAlmacen.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloAlmacen.Location = new System.Drawing.Point(449, 476);
            this.lblTituloAlmacen.Name = "lblTituloAlmacen";
            this.lblTituloAlmacen.Size = new System.Drawing.Size(114, 29);
            this.lblTituloAlmacen.TabIndex = 103;
            this.lblTituloAlmacen.Text = "Almacén:";
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloCategoria.Location = new System.Drawing.Point(17, 476);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(123, 29);
            this.lblTituloCategoria.TabIndex = 102;
            this.lblTituloCategoria.Text = "Categoría:";
            // 
            // lblTituloLote
            // 
            this.lblTituloLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloLote.AutoSize = true;
            this.lblTituloLote.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloLote.Location = new System.Drawing.Point(449, 393);
            this.lblTituloLote.Name = "lblTituloLote";
            this.lblTituloLote.Size = new System.Drawing.Size(67, 29);
            this.lblTituloLote.TabIndex = 101;
            this.lblTituloLote.Text = "Lote:";
            // 
            // lblTituloCaducidad
            // 
            this.lblTituloCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCaducidad.AutoSize = true;
            this.lblTituloCaducidad.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloCaducidad.Location = new System.Drawing.Point(17, 393);
            this.lblTituloCaducidad.Name = "lblTituloCaducidad";
            this.lblTituloCaducidad.Size = new System.Drawing.Size(141, 29);
            this.lblTituloCaducidad.TabIndex = 100;
            this.lblTituloCaducidad.Text = "Caducidad: ";
            // 
            // lblTituloCoste
            // 
            this.lblTituloCoste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCoste.AutoSize = true;
            this.lblTituloCoste.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloCoste.Location = new System.Drawing.Point(449, 310);
            this.lblTituloCoste.Name = "lblTituloCoste";
            this.lblTituloCoste.Size = new System.Drawing.Size(82, 29);
            this.lblTituloCoste.TabIndex = 98;
            this.lblTituloCoste.Text = "Coste:";
            // 
            // lblTituloCantidad
            // 
            this.lblTituloCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCantidad.AutoSize = true;
            this.lblTituloCantidad.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloCantidad.Location = new System.Drawing.Point(17, 310);
            this.lblTituloCantidad.Name = "lblTituloCantidad";
            this.lblTituloCantidad.Size = new System.Drawing.Size(116, 29);
            this.lblTituloCantidad.TabIndex = 97;
            this.lblTituloCantidad.Text = "Cantidad:";
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloDescripcion.Location = new System.Drawing.Point(17, 92);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(146, 29);
            this.lblTituloDescripcion.TabIndex = 96;
            this.lblTituloDescripcion.Text = "Descripción:";
            // 
            // lblTituloReferencia
            // 
            this.lblTituloReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloReferencia.AutoSize = true;
            this.lblTituloReferencia.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloReferencia.Location = new System.Drawing.Point(17, 18);
            this.lblTituloReferencia.Name = "lblTituloReferencia";
            this.lblTituloReferencia.Size = new System.Drawing.Size(140, 29);
            this.lblTituloReferencia.TabIndex = 95;
            this.lblTituloReferencia.Text = "Referencia: ";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(790, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProducto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblErrorGuardar;
        private System.Windows.Forms.Label lblErrorCaducidad;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorReferencia;
        private System.Windows.Forms.Label lblErrorCategoria;
        private System.Windows.Forms.Label lblErrorAlmacen;
        private System.Windows.Forms.Label lblErrorLote;
        private System.Windows.Forms.Label lblErrorCoste;
        private System.Windows.Forms.Label lblErrorCantidad;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiarCampos;
        private ControlesPersonalizados.BotonPersonalizado btnGuardarProducto;
        private ControlesPersonalizados.SelectorFecha mcCaducidad;
        private ControlesPersonalizados.ComboBoxPersonalizado cbAlmacen;
        private ControlesPersonalizados.ComboBoxPersonalizado cbCategoria;
        private TextboxPersonalizado txtLote;
        private TextboxPersonalizado txtCoste;
        private TextboxPersonalizado txtDescripcion;
        private TextboxPersonalizado txtCantidad;
        private TextboxPersonalizado txtReferencia;
        private System.Windows.Forms.Label lblTituloAlmacen;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Label lblTituloLote;
        private System.Windows.Forms.Label lblTituloCaducidad;
        private System.Windows.Forms.Label lblTituloCoste;
        private System.Windows.Forms.Label lblTituloCantidad;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblTituloReferencia;
    }
}