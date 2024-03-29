﻿namespace DentalSoft.Formularios
{
    partial class TratamientoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TratamientoPaciente));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlHistorialPieza = new System.Windows.Forms.Panel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.btnConsentimiento = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblTituloGenero = new System.Windows.Forms.Label();
            this.lblTituloEdad = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbTratamiento = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.cbDiagnostico = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.cbPieza = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.lblPieza = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.gbSeccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarTodo = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnLimpiar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnRaizDerecha = new System.Windows.Forms.Button();
            this.btnRaizCentral = new System.Windows.Forms.Button();
            this.btnRaizIzquierda = new System.Windows.Forms.Button();
            this.btnLingual = new System.Windows.Forms.Button();
            this.btnOclusal = new System.Windows.Forms.Button();
            this.btnMesial = new System.Windows.Forms.Button();
            this.btnDistal = new System.Windows.Forms.Button();
            this.btnVestibular = new System.Windows.Forms.Button();
            this.btnGuardar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlHistorialPieza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.gbPaciente.SuspendLayout();
            this.gbSeccion.SuspendLayout();
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
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1942, 43);
            this.pnlCabecera.TabIndex = 1;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 29);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "DentalSoft";
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedimensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedimensionar.Image = ((System.Drawing.Image)(resources.GetObject("btnRedimensionar.Image")));
            this.btnRedimensionar.Location = new System.Drawing.Point(1835, 4);
            this.btnRedimensionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(33, 31);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1781, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 31);
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
            this.btnCerrar.Location = new System.Drawing.Point(1893, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlHistorialPieza
            // 
            this.pnlHistorialPieza.Controls.Add(this.dgvHistorial);
            this.pnlHistorialPieza.Location = new System.Drawing.Point(51, 475);
            this.pnlHistorialPieza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHistorialPieza.Name = "pnlHistorialPieza";
            this.pnlHistorialPieza.Size = new System.Drawing.Size(1876, 485);
            this.pnlHistorialPieza.TabIndex = 6;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(0, 0);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.Size = new System.Drawing.Size(1876, 485);
            this.dgvHistorial.TabIndex = 30;
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.btnConsentimiento);
            this.gbPaciente.Controls.Add(this.lblTituloGenero);
            this.gbPaciente.Controls.Add(this.lblTituloEdad);
            this.gbPaciente.Controls.Add(this.lblTituloNombre);
            this.gbPaciente.Controls.Add(this.lblGenero);
            this.gbPaciente.Controls.Add(this.lblEdad);
            this.gbPaciente.Controls.Add(this.lblNombre);
            this.gbPaciente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaciente.Location = new System.Drawing.Point(51, 94);
            this.gbPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPaciente.Size = new System.Drawing.Size(891, 293);
            this.gbPaciente.TabIndex = 7;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // btnConsentimiento
            // 
            this.btnConsentimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnConsentimiento.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnConsentimiento.BordeRadio = 29;
            this.btnConsentimiento.BordeTamaño = 0;
            this.btnConsentimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsentimiento.FlatAppearance.BorderSize = 0;
            this.btnConsentimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnConsentimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsentimiento.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnConsentimiento.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsentimiento.ForeColor = System.Drawing.Color.White;
            this.btnConsentimiento.Location = new System.Drawing.Point(596, 203);
            this.btnConsentimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsentimiento.Name = "btnConsentimiento";
            this.btnConsentimiento.Size = new System.Drawing.Size(267, 49);
            this.btnConsentimiento.TabIndex = 61;
            this.btnConsentimiento.Text = "Imprimir consentimiento";
            this.btnConsentimiento.TextoColor = System.Drawing.Color.White;
            this.btnConsentimiento.UseVisualStyleBackColor = false;
            this.btnConsentimiento.Click += new System.EventHandler(this.btnConsentimiento_Click);
            // 
            // lblTituloGenero
            // 
            this.lblTituloGenero.AutoSize = true;
            this.lblTituloGenero.Location = new System.Drawing.Point(41, 220);
            this.lblTituloGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloGenero.Name = "lblTituloGenero";
            this.lblTituloGenero.Size = new System.Drawing.Size(75, 24);
            this.lblTituloGenero.TabIndex = 5;
            this.lblTituloGenero.Text = "Genero";
            // 
            // lblTituloEdad
            // 
            this.lblTituloEdad.AutoSize = true;
            this.lblTituloEdad.Location = new System.Drawing.Point(41, 138);
            this.lblTituloEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEdad.Name = "lblTituloEdad";
            this.lblTituloEdad.Size = new System.Drawing.Size(54, 24);
            this.lblTituloEdad.TabIndex = 4;
            this.lblTituloEdad.Text = "Edad";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Location = new System.Drawing.Point(41, 57);
            this.lblTituloNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(82, 24);
            this.lblTituloNombre.TabIndex = 3;
            this.lblTituloNombre.Text = "Nombre";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(168, 220);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(96, 24);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "lblGenero";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(168, 138);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(75, 24);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "lblEdad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 57);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "lblNombre";
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbTratamiento.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbTratamiento.BordeTamaño = 1;
            this.cbTratamiento.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbTratamiento.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbTratamiento.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTratamiento.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTratamiento.ForeColor = System.Drawing.Color.DimGray;
            this.cbTratamiento.ListaColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTratamiento.ListColorTexto = System.Drawing.Color.DimGray;
            this.cbTratamiento.Location = new System.Drawing.Point(1152, 290);
            this.cbTratamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTratamiento.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Padding = new System.Windows.Forms.Padding(1);
            this.cbTratamiento.Size = new System.Drawing.Size(267, 37);
            this.cbTratamiento.TabIndex = 10;
            this.cbTratamiento.Textos = "";
            this.cbTratamiento.OnSelectedIndexChanged += new System.EventHandler(this.cbTratamiento_OnSelectedIndexChanged);
            // 
            // cbDiagnostico
            // 
            this.cbDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbDiagnostico.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbDiagnostico.BordeTamaño = 1;
            this.cbDiagnostico.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbDiagnostico.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbDiagnostico.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiagnostico.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiagnostico.ForeColor = System.Drawing.Color.DimGray;
            this.cbDiagnostico.ListaColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbDiagnostico.ListColorTexto = System.Drawing.Color.DimGray;
            this.cbDiagnostico.Location = new System.Drawing.Point(1152, 193);
            this.cbDiagnostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDiagnostico.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbDiagnostico.Name = "cbDiagnostico";
            this.cbDiagnostico.Padding = new System.Windows.Forms.Padding(1);
            this.cbDiagnostico.Size = new System.Drawing.Size(267, 37);
            this.cbDiagnostico.TabIndex = 5;
            this.cbDiagnostico.Textos = "";
            // 
            // cbPieza
            // 
            this.cbPieza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbPieza.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbPieza.BordeTamaño = 1;
            this.cbPieza.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbPieza.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbPieza.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPieza.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPieza.ForeColor = System.Drawing.Color.DimGray;
            this.cbPieza.ListaColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPieza.ListColorTexto = System.Drawing.Color.DimGray;
            this.cbPieza.Location = new System.Drawing.Point(1152, 94);
            this.cbPieza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPieza.MinimumSize = new System.Drawing.Size(267, 37);
            this.cbPieza.Name = "cbPieza";
            this.cbPieza.Padding = new System.Windows.Forms.Padding(1);
            this.cbPieza.Size = new System.Drawing.Size(267, 37);
            this.cbPieza.TabIndex = 0;
            this.cbPieza.Textos = "";
            this.cbPieza.OnSelectedIndexChanged += new System.EventHandler(this.cbPieza_OnSelectedIndexChanged);
            // 
            // lblPieza
            // 
            this.lblPieza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPieza.AutoSize = true;
            this.lblPieza.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieza.Location = new System.Drawing.Point(1016, 102);
            this.lblPieza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(60, 24);
            this.lblPieza.TabIndex = 8;
            this.lblPieza.Text = "Pieza";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(1015, 199);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(115, 24);
            this.lblDiagnostico.TabIndex = 9;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(1015, 298);
            this.lblTratamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(120, 24);
            this.lblTratamiento.TabIndex = 10;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // gbSeccion
            // 
            this.gbSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSeccion.Controls.Add(this.btnSeleccionarTodo);
            this.gbSeccion.Controls.Add(this.btnLimpiar);
            this.gbSeccion.Controls.Add(this.btnRaiz);
            this.gbSeccion.Controls.Add(this.btnRaizDerecha);
            this.gbSeccion.Controls.Add(this.btnRaizCentral);
            this.gbSeccion.Controls.Add(this.btnRaizIzquierda);
            this.gbSeccion.Controls.Add(this.btnLingual);
            this.gbSeccion.Controls.Add(this.btnOclusal);
            this.gbSeccion.Controls.Add(this.btnMesial);
            this.gbSeccion.Controls.Add(this.btnDistal);
            this.gbSeccion.Controls.Add(this.btnVestibular);
            this.gbSeccion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeccion.Location = new System.Drawing.Point(1501, 94);
            this.gbSeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeccion.Name = "gbSeccion";
            this.gbSeccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeccion.Size = new System.Drawing.Size(425, 332);
            this.gbSeccion.TabIndex = 11;
            this.gbSeccion.TabStop = false;
            this.gbSeccion.Text = "Sección";
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnSeleccionarTodo.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnSeleccionarTodo.BordeRadio = 29;
            this.btnSeleccionarTodo.BordeTamaño = 0;
            this.btnSeleccionarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarTodo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodo.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnSeleccionarTodo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarTodo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(104, 283);
            this.btnSeleccionarTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(219, 36);
            this.btnSeleccionarTodo.TabIndex = 15;
            this.btnSeleccionarTodo.Text = "Seleccionar Todo";
            this.btnSeleccionarTodo.TextoColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiar.BordeRadio = 29;
            this.btnLimpiar.BordeTamaño = 0;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(104, 32);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(219, 36);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar Selección";
            this.btnLimpiar.TextoColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnRaiz.Location = new System.Drawing.Point(284, 100);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(60, 159);
            this.btnRaiz.TabIndex = 50;
            this.btnRaiz.Tag = "Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnRaizDerecha
            // 
            this.btnRaizDerecha.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnRaizDerecha.Location = new System.Drawing.Point(352, 97);
            this.btnRaizDerecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaizDerecha.Name = "btnRaizDerecha";
            this.btnRaizDerecha.Size = new System.Drawing.Size(44, 159);
            this.btnRaizDerecha.TabIndex = 65;
            this.btnRaizDerecha.Tag = "Raiz derecha";
            this.btnRaizDerecha.UseVisualStyleBackColor = true;
            this.btnRaizDerecha.Click += new System.EventHandler(this.btnRaizDerecha_Click);
            // 
            // btnRaizCentral
            // 
            this.btnRaizCentral.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnRaizCentral.Location = new System.Drawing.Point(300, 97);
            this.btnRaizCentral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaizCentral.Name = "btnRaizCentral";
            this.btnRaizCentral.Size = new System.Drawing.Size(44, 159);
            this.btnRaizCentral.TabIndex = 60;
            this.btnRaizCentral.Tag = "Raiz central";
            this.btnRaizCentral.UseVisualStyleBackColor = true;
            this.btnRaizCentral.Click += new System.EventHandler(this.btnRaizCentral_Click_1);
            // 
            // btnRaizIzquierda
            // 
            this.btnRaizIzquierda.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnRaizIzquierda.Location = new System.Drawing.Point(248, 97);
            this.btnRaizIzquierda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRaizIzquierda.Name = "btnRaizIzquierda";
            this.btnRaizIzquierda.Size = new System.Drawing.Size(44, 159);
            this.btnRaizIzquierda.TabIndex = 55;
            this.btnRaizIzquierda.Tag = "Raiz izquierda";
            this.btnRaizIzquierda.UseVisualStyleBackColor = true;
            this.btnRaizIzquierda.Click += new System.EventHandler(this.btnRaizIzquierda_Click);
            // 
            // btnLingual
            // 
            this.btnLingual.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnLingual.Location = new System.Drawing.Point(92, 203);
            this.btnLingual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLingual.Name = "btnLingual";
            this.btnLingual.Size = new System.Drawing.Size(61, 53);
            this.btnLingual.TabIndex = 45;
            this.btnLingual.Tag = "Lingual";
            this.btnLingual.UseVisualStyleBackColor = true;
            this.btnLingual.Click += new System.EventHandler(this.btnLingual_Click);
            // 
            // btnOclusal
            // 
            this.btnOclusal.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnOclusal.Location = new System.Drawing.Point(92, 149);
            this.btnOclusal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOclusal.Name = "btnOclusal";
            this.btnOclusal.Size = new System.Drawing.Size(61, 53);
            this.btnOclusal.TabIndex = 35;
            this.btnOclusal.Tag = "Oclusal";
            this.btnOclusal.UseVisualStyleBackColor = true;
            this.btnOclusal.Click += new System.EventHandler(this.btnOclusal_Click);
            // 
            // btnMesial
            // 
            this.btnMesial.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnMesial.Location = new System.Drawing.Point(156, 149);
            this.btnMesial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMesial.Name = "btnMesial";
            this.btnMesial.Size = new System.Drawing.Size(61, 53);
            this.btnMesial.TabIndex = 40;
            this.btnMesial.Tag = "Mesial";
            this.btnMesial.UseVisualStyleBackColor = true;
            this.btnMesial.Click += new System.EventHandler(this.btnMesial_Click);
            // 
            // btnDistal
            // 
            this.btnDistal.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnDistal.Location = new System.Drawing.Point(28, 149);
            this.btnDistal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDistal.Name = "btnDistal";
            this.btnDistal.Size = new System.Drawing.Size(61, 53);
            this.btnDistal.TabIndex = 30;
            this.btnDistal.Tag = "Distal";
            this.btnDistal.UseVisualStyleBackColor = true;
            this.btnDistal.Click += new System.EventHandler(this.btnDistal_Click);
            // 
            // btnVestibular
            // 
            this.btnVestibular.Font = new System.Drawing.Font("Roboto", 14F);
            this.btnVestibular.Location = new System.Drawing.Point(92, 95);
            this.btnVestibular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVestibular.Name = "btnVestibular";
            this.btnVestibular.Size = new System.Drawing.Size(61, 53);
            this.btnVestibular.TabIndex = 25;
            this.btnVestibular.Tag = "Vestibular";
            this.btnVestibular.UseVisualStyleBackColor = true;
            this.btnVestibular.Click += new System.EventHandler(this.btnVestibular_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeRadio = 29;
            this.btnGuardar.BordeTamaño = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1152, 385);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(267, 49);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextoColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblHistorial.Location = new System.Drawing.Point(57, 426);
            this.lblHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(257, 29);
            this.lblHistorial.TabIndex = 13;
            this.lblHistorial.Text = "Historial Odontograma";
            // 
            // TratamientoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 985);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.gbSeccion);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblPieza);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.pnlHistorialPieza);
            this.Controls.Add(this.cbTratamiento);
            this.Controls.Add(this.cbDiagnostico);
            this.Controls.Add(this.cbPieza);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TratamientoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TratamientoPaciente";
            this.Load += new System.EventHandler(this.TratamientoPaciente_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlHistorialPieza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbSeccion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private ControlesPersonalizados.ComboBoxPersonalizado cbPieza;
        private ControlesPersonalizados.ComboBoxPersonalizado cbDiagnostico;
        private ControlesPersonalizados.ComboBoxPersonalizado cbTratamiento;
        private System.Windows.Forms.Panel pnlHistorialPieza;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPieza;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.GroupBox gbSeccion;
        private System.Windows.Forms.Button btnRaizDerecha;
        private System.Windows.Forms.Button btnRaizCentral;
        private System.Windows.Forms.Button btnRaizIzquierda;
        private System.Windows.Forms.Button btnLingual;
        private System.Windows.Forms.Button btnOclusal;
        private System.Windows.Forms.Button btnMesial;
        private System.Windows.Forms.Button btnDistal;
        private System.Windows.Forms.Button btnVestibular;
        private System.Windows.Forms.Button btnRaiz;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiar;
        private ControlesPersonalizados.BotonPersonalizado btnSeleccionarTodo;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblTituloGenero;
        private System.Windows.Forms.Label lblTituloEdad;
        private System.Windows.Forms.Label lblTituloNombre;
        private ControlesPersonalizados.BotonPersonalizado btnConsentimiento;
    }
}