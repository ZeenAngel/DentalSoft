namespace DentalSoft.Formularios
{
    partial class NuevoPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPresupuesto));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorCentro = new System.Windows.Forms.Label();
            this.cbCentros = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.lblCentro = new System.Windows.Forms.Label();
            this.lblErrorEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblErrorPaciente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblErrorGuardar = new System.Windows.Forms.Label();
            this.btnGuardar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.pnlContenedorDgv = new System.Windows.Forms.Panel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedorDetalle = new System.Windows.Forms.Panel();
            this.lblErrorTratamiento = new System.Windows.Forms.Label();
            this.btnAñadir = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new DentalSoft.TextboxPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTratamientos = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtPaciente = new DentalSoft.TextboxPersonalizado();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloPresupuesto = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlContenedorDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.pnlContenedorDetalle.SuspendLayout();
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
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(728, 35);
            this.pnlCabecera.TabIndex = 4;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
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
            this.btnRedimensionar.Location = new System.Drawing.Point(648, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(607, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(691, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
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
            this.panel1.Controls.Add(this.lblErrorCentro);
            this.panel1.Controls.Add(this.cbCentros);
            this.panel1.Controls.Add(this.lblCentro);
            this.panel1.Controls.Add(this.lblErrorEliminar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.lblErrorPaciente);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblPresupuesto);
            this.panel1.Controls.Add(this.lblErrorGuardar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.pnlContenedorDgv);
            this.panel1.Controls.Add(this.pnlContenedorDetalle);
            this.panel1.Controls.Add(this.btnBuscarPaciente);
            this.panel1.Controls.Add(this.txtPaciente);
            this.panel1.Controls.Add(this.lblPaciente);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblTituloPresupuesto);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 728);
            this.panel1.TabIndex = 100;
            // 
            // lblErrorCentro
            // 
            this.lblErrorCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCentro.AutoSize = true;
            this.lblErrorCentro.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCentro.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCentro.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCentro.Image")));
            this.lblErrorCentro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCentro.Location = new System.Drawing.Point(185, 93);
            this.lblErrorCentro.Name = "lblErrorCentro";
            this.lblErrorCentro.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCentro.TabIndex = 116;
            this.lblErrorCentro.Text = "Mensaje Error";
            this.lblErrorCentro.Visible = false;
            // 
            // cbCentros
            // 
            this.cbCentros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCentros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCentros.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCentros.BordeTamaño = 1;
            this.cbCentros.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCentros.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCentros.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbCentros.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCentros.ForeColor = System.Drawing.Color.Black;
            this.cbCentros.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCentros.ListColorTexto = System.Drawing.Color.Black;
            this.cbCentros.Location = new System.Drawing.Point(188, 60);
            this.cbCentros.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCentros.Name = "cbCentros";
            this.cbCentros.Padding = new System.Windows.Forms.Padding(1);
            this.cbCentros.Size = new System.Drawing.Size(200, 30);
            this.cbCentros.TabIndex = 100;
            this.cbCentros.Textos = "";
            // 
            // lblCentro
            // 
            this.lblCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCentro.AutoSize = true;
            this.lblCentro.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblCentro.Location = new System.Drawing.Point(52, 67);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(85, 29);
            this.lblCentro.TabIndex = 115;
            this.lblCentro.Text = "Centro";
            // 
            // lblErrorEliminar
            // 
            this.lblErrorEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorEliminar.AutoSize = true;
            this.lblErrorEliminar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEliminar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorEliminar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorEliminar.Image")));
            this.lblErrorEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorEliminar.Location = new System.Drawing.Point(27, 626);
            this.lblErrorEliminar.Name = "lblErrorEliminar";
            this.lblErrorEliminar.Size = new System.Drawing.Size(106, 19);
            this.lblErrorEliminar.TabIndex = 114;
            this.lblErrorEliminar.Text = "Mensaje Error";
            this.lblErrorEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.BordeRadio = 30;
            this.btnEliminar.BordeTamaño = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(24, 593);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 30);
            this.btnEliminar.TabIndex = 106;
            this.btnEliminar.Text = "Eliminar tratamiento";
            this.btnEliminar.TextoColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblErrorPaciente
            // 
            this.lblErrorPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorPaciente.AutoSize = true;
            this.lblErrorPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPaciente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPaciente.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPaciente.Image")));
            this.lblErrorPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPaciente.Location = new System.Drawing.Point(185, 155);
            this.lblErrorPaciente.Name = "lblErrorPaciente";
            this.lblErrorPaciente.Size = new System.Drawing.Size(106, 19);
            this.lblErrorPaciente.TabIndex = 113;
            this.lblErrorPaciente.Text = "Mensaje Error";
            this.lblErrorPaciente.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(537, 593);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 29);
            this.lblTotal.TabIndex = 112;
            this.lblTotal.Text = "Total: ";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblPresupuesto.Location = new System.Drawing.Point(184, 12);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(0, 29);
            this.lblPresupuesto.TabIndex = 111;
            // 
            // lblErrorGuardar
            // 
            this.lblErrorGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorGuardar.AutoSize = true;
            this.lblErrorGuardar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGuardar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorGuardar.Image")));
            this.lblErrorGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorGuardar.Location = new System.Drawing.Point(264, 698);
            this.lblErrorGuardar.Name = "lblErrorGuardar";
            this.lblErrorGuardar.Size = new System.Drawing.Size(106, 19);
            this.lblErrorGuardar.TabIndex = 110;
            this.lblErrorGuardar.Text = "Mensaje Error";
            this.lblErrorGuardar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeRadio = 35;
            this.btnGuardar.BordeTamaño = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(267, 644);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 42);
            this.btnGuardar.TabIndex = 107;
            this.btnGuardar.Text = "Guardar Presupuesto";
            this.btnGuardar.TextoColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenedorDgv
            // 
            this.pnlContenedorDgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenedorDgv.Controls.Add(this.dgvDetalles);
            this.pnlContenedorDgv.Location = new System.Drawing.Point(24, 337);
            this.pnlContenedorDgv.Name = "pnlContenedorDgv";
            this.pnlContenedorDgv.Size = new System.Drawing.Size(656, 240);
            this.pnlContenedorDgv.TabIndex = 109;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tratamiento,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(656, 240);
            this.dgvDetalles.TabIndex = 0;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.MinimumWidth = 6;
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            this.Tratamiento.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // pnlContenedorDetalle
            // 
            this.pnlContenedorDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContenedorDetalle.Controls.Add(this.lblErrorTratamiento);
            this.pnlContenedorDetalle.Controls.Add(this.btnAñadir);
            this.pnlContenedorDetalle.Controls.Add(this.lblErrorCantidad);
            this.pnlContenedorDetalle.Controls.Add(this.txtCantidad);
            this.pnlContenedorDetalle.Controls.Add(this.label1);
            this.pnlContenedorDetalle.Controls.Add(this.cbTratamientos);
            this.pnlContenedorDetalle.Controls.Add(this.lblTratamiento);
            this.pnlContenedorDetalle.Location = new System.Drawing.Point(24, 187);
            this.pnlContenedorDetalle.Name = "pnlContenedorDetalle";
            this.pnlContenedorDetalle.Size = new System.Drawing.Size(656, 123);
            this.pnlContenedorDetalle.TabIndex = 108;
            // 
            // lblErrorTratamiento
            // 
            this.lblErrorTratamiento.AutoSize = true;
            this.lblErrorTratamiento.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTratamiento.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorTratamiento.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorTratamiento.Image")));
            this.lblErrorTratamiento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorTratamiento.Location = new System.Drawing.Point(3, 96);
            this.lblErrorTratamiento.Name = "lblErrorTratamiento";
            this.lblErrorTratamiento.Size = new System.Drawing.Size(106, 19);
            this.lblErrorTratamiento.TabIndex = 90;
            this.lblErrorTratamiento.Text = "Mensaje Error";
            this.lblErrorTratamiento.Visible = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadir.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadir.BordeRadio = 30;
            this.btnAñadir.BordeTamaño = 0;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadir.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(470, 53);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(163, 30);
            this.btnAñadir.TabIndex = 25;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextoColor = System.Drawing.Color.White;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCantidad.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCantidad.Image")));
            this.lblErrorCantidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCantidad.Location = new System.Drawing.Point(294, 96);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCantidad.TabIndex = 89;
            this.lblErrorCantidad.Text = "Mensaje Error";
            this.lblErrorCantidad.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtCantidad.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtCantidad.BordeRadio = 0;
            this.txtCantidad.BordeTamaño = 2;
            this.txtCantidad.Contraseña = false;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(297, 53);
            this.txtCantidad.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.MarcadorPosicionTexto = "";
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Multilinea = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PosicionSeleccion = 0;
            this.txtCantidad.Size = new System.Drawing.Size(119, 34);
            this.txtCantidad.SubrayadoEstilo = true;
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.TamañoMaximo = 30000;
            this.txtCantidad.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F);
            this.label1.Location = new System.Drawing.Point(313, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad";
            // 
            // cbTratamientos
            // 
            this.cbTratamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTratamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbTratamientos.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbTratamientos.BordeTamaño = 1;
            this.cbTratamientos.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbTratamientos.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbTratamientos.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbTratamientos.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTratamientos.ForeColor = System.Drawing.Color.Black;
            this.cbTratamientos.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbTratamientos.ListColorTexto = System.Drawing.Color.Black;
            this.cbTratamientos.Location = new System.Drawing.Point(3, 53);
            this.cbTratamientos.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTratamientos.Name = "cbTratamientos";
            this.cbTratamientos.Padding = new System.Windows.Forms.Padding(1);
            this.cbTratamientos.Size = new System.Drawing.Size(250, 30);
            this.cbTratamientos.TabIndex = 15;
            this.cbTratamientos.Textos = "";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTratamiento.Location = new System.Drawing.Point(58, 11);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(143, 29);
            this.lblTratamiento.TabIndex = 6;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPaciente.BordeRadio = 35;
            this.btnBuscarPaciente.BordeTamaño = 0;
            this.btnBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(471, 120);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(173, 35);
            this.btnBuscarPaciente.TabIndex = 105;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextoColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPaciente.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPaciente.BordeRadio = 0;
            this.txtPaciente.BordeTamaño = 2;
            this.txtPaciente.Contraseña = false;
            this.txtPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtPaciente.Location = new System.Drawing.Point(188, 122);
            this.txtPaciente.MarcadorPosicionColor = System.Drawing.Color.Black;
            this.txtPaciente.MarcadorPosicionTexto = "";
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPaciente.Multilinea = false;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPaciente.PosicionSeleccion = 0;
            this.txtPaciente.Size = new System.Drawing.Size(266, 34);
            this.txtPaciente.SubrayadoEstilo = true;
            this.txtPaciente.TabIndex = 102;
            this.txtPaciente.TamañoMaximo = 30000;
            this.txtPaciente.Texto = "";
            // 
            // lblPaciente
            // 
            this.lblPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblPaciente.Location = new System.Drawing.Point(52, 129);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(113, 29);
            this.lblPaciente.TabIndex = 104;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblFecha.Location = new System.Drawing.Point(467, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 29);
            this.lblFecha.TabIndex = 103;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblTituloPresupuesto
            // 
            this.lblTituloPresupuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloPresupuesto.AutoSize = true;
            this.lblTituloPresupuesto.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloPresupuesto.Location = new System.Drawing.Point(52, 12);
            this.lblTituloPresupuesto.Name = "lblTituloPresupuesto";
            this.lblTituloPresupuesto.Size = new System.Drawing.Size(159, 29);
            this.lblTituloPresupuesto.TabIndex = 101;
            this.lblTituloPresupuesto.Text = "Presupuesto: ";
            // 
            // NuevoPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(728, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevoPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoPresupuesto";
            this.Load += new System.EventHandler(this.NuevoPresupuesto_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContenedorDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.pnlContenedorDetalle.ResumeLayout(false);
            this.pnlContenedorDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorCentro;
        private ControlesPersonalizados.ComboBoxPersonalizado cbCentros;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Label lblErrorEliminar;
        private ControlesPersonalizados.BotonPersonalizado btnEliminar;
        private System.Windows.Forms.Label lblErrorPaciente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblErrorGuardar;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.Panel pnlContenedorDgv;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Panel pnlContenedorDetalle;
        private System.Windows.Forms.Label lblErrorTratamiento;
        private ControlesPersonalizados.BotonPersonalizado btnAñadir;
        private System.Windows.Forms.Label lblErrorCantidad;
        private TextboxPersonalizado txtCantidad;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.ComboBoxPersonalizado cbTratamientos;
        private System.Windows.Forms.Label lblTratamiento;
        private ControlesPersonalizados.BotonPersonalizado btnBuscarPaciente;
        private TextboxPersonalizado txtPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloPresupuesto;
    }
}