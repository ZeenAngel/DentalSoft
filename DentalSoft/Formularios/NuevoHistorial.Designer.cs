namespace DentalSoft.Formularios
{
    partial class NuevoHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoHistorial));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtFecha = new DentalSoft.TextboxPersonalizado();
            this.txtPaciente = new DentalSoft.TextboxPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnLimipar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.txtMedicacion = new System.Windows.Forms.RichTextBox();
            this.txtAlergias = new System.Windows.Forms.RichTextBox();
            this.lblTituloObservaciones = new System.Windows.Forms.Label();
            this.lblTituloMedicacion = new System.Windows.Forms.Label();
            this.lblTituloAlergias = new System.Windows.Forms.Label();
            this.lblErrorAlergias = new System.Windows.Forms.Label();
            this.lblErrorMedicacion = new System.Windows.Forms.Label();
            this.lblErrorGuardar = new System.Windows.Forms.Label();
            this.btnImprimir = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.pnlCabecera.Controls.Add(this.label1);
            this.pnlCabecera.Controls.Add(this.btnRedimensionar);
            this.pnlCabecera.Controls.Add(this.btnMinimizar);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1207, 35);
            this.pnlCabecera.TabIndex = 11;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "DentalSoft";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedimensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedimensionar.Image = ((System.Drawing.Image)(resources.GetObject("btnRedimensionar.Image")));
            this.btnRedimensionar.Location = new System.Drawing.Point(1127, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1086, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(1170, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.BackColor = System.Drawing.SystemColors.Window;
            this.txtFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtFecha.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtFecha.BordeRadio = 0;
            this.txtFecha.BordeTamaño = 2;
            this.txtFecha.Contraseña = false;
            this.txtFecha.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(748, 65);
            this.txtFecha.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtFecha.MarcadorPosicionTexto = "";
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFecha.Multilinea = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFecha.PosicionSeleccion = 0;
            this.txtFecha.Size = new System.Drawing.Size(250, 39);
            this.txtFecha.SubrayadoEstilo = true;
            this.txtFecha.TabIndex = 30;
            this.txtFecha.TamañoMaximo = 30000;
            this.txtFecha.Texto = "";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPaciente.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPaciente.BordeRadio = 0;
            this.txtPaciente.BordeTamaño = 2;
            this.txtPaciente.Contraseña = false;
            this.txtPaciente.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtPaciente.Location = new System.Drawing.Point(199, 65);
            this.txtPaciente.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPaciente.MarcadorPosicionTexto = "";
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPaciente.Multilinea = false;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPaciente.PosicionSeleccion = 0;
            this.txtPaciente.Size = new System.Drawing.Size(250, 39);
            this.txtPaciente.SubrayadoEstilo = true;
            this.txtPaciente.TabIndex = 29;
            this.txtPaciente.TamañoMaximo = 30000;
            this.txtPaciente.Texto = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Paciente";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(657, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 29);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Fecha";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BordeRadio = 32;
            this.btnGuardar.BordeTamaño = 0;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(802, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(281, 34);
            this.btnGuardar.TabIndex = 97;
            this.btnGuardar.Text = "Guardar Historial";
            this.btnGuardar.TextoColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimipar
            // 
            this.btnLimipar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimipar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimipar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimipar.BordeRadio = 32;
            this.btnLimipar.BordeTamaño = 0;
            this.btnLimipar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimipar.FlatAppearance.BorderSize = 0;
            this.btnLimipar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimipar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimipar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimipar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimipar.ForeColor = System.Drawing.Color.White;
            this.btnLimipar.Location = new System.Drawing.Point(802, 521);
            this.btnLimipar.Name = "btnLimipar";
            this.btnLimipar.Size = new System.Drawing.Size(281, 34);
            this.btnLimipar.TabIndex = 96;
            this.btnLimipar.Text = "Limpiar Campos";
            this.btnLimipar.TextoColor = System.Drawing.Color.White;
            this.btnLimipar.UseVisualStyleBackColor = false;
            this.btnLimipar.Click += new System.EventHandler(this.btnLimipar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObservaciones.Location = new System.Drawing.Point(63, 450);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(601, 168);
            this.txtObservaciones.TabIndex = 92;
            this.txtObservaciones.Text = "";
            // 
            // txtMedicacion
            // 
            this.txtMedicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicacion.Location = new System.Drawing.Point(661, 148);
            this.txtMedicacion.Name = "txtMedicacion";
            this.txtMedicacion.Size = new System.Drawing.Size(512, 207);
            this.txtMedicacion.TabIndex = 91;
            this.txtMedicacion.Text = "";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAlergias.Location = new System.Drawing.Point(59, 148);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(521, 207);
            this.txtAlergias.TabIndex = 90;
            this.txtAlergias.Text = "";
            // 
            // lblTituloObservaciones
            // 
            this.lblTituloObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloObservaciones.AutoSize = true;
            this.lblTituloObservaciones.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloObservaciones.Location = new System.Drawing.Point(59, 418);
            this.lblTituloObservaciones.Name = "lblTituloObservaciones";
            this.lblTituloObservaciones.Size = new System.Drawing.Size(178, 29);
            this.lblTituloObservaciones.TabIndex = 95;
            this.lblTituloObservaciones.Text = "Observaciones:";
            // 
            // lblTituloMedicacion
            // 
            this.lblTituloMedicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloMedicacion.AutoSize = true;
            this.lblTituloMedicacion.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloMedicacion.Location = new System.Drawing.Point(657, 122);
            this.lblTituloMedicacion.Name = "lblTituloMedicacion";
            this.lblTituloMedicacion.Size = new System.Drawing.Size(145, 29);
            this.lblTituloMedicacion.TabIndex = 94;
            this.lblTituloMedicacion.Text = "Medicación:";
            // 
            // lblTituloAlergias
            // 
            this.lblTituloAlergias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloAlergias.AutoSize = true;
            this.lblTituloAlergias.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloAlergias.Location = new System.Drawing.Point(55, 122);
            this.lblTituloAlergias.Name = "lblTituloAlergias";
            this.lblTituloAlergias.Size = new System.Drawing.Size(106, 29);
            this.lblTituloAlergias.TabIndex = 93;
            this.lblTituloAlergias.Text = "Alergias:";
            // 
            // lblErrorAlergias
            // 
            this.lblErrorAlergias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblErrorAlergias.AutoSize = true;
            this.lblErrorAlergias.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAlergias.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorAlergias.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorAlergias.Image")));
            this.lblErrorAlergias.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorAlergias.Location = new System.Drawing.Point(60, 358);
            this.lblErrorAlergias.Name = "lblErrorAlergias";
            this.lblErrorAlergias.Size = new System.Drawing.Size(106, 19);
            this.lblErrorAlergias.TabIndex = 98;
            this.lblErrorAlergias.Text = "Mensaje Error";
            this.lblErrorAlergias.Visible = false;
            // 
            // lblErrorMedicacion
            // 
            this.lblErrorMedicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMedicacion.AutoSize = true;
            this.lblErrorMedicacion.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMedicacion.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorMedicacion.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMedicacion.Image")));
            this.lblErrorMedicacion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMedicacion.Location = new System.Drawing.Point(658, 358);
            this.lblErrorMedicacion.Name = "lblErrorMedicacion";
            this.lblErrorMedicacion.Size = new System.Drawing.Size(106, 19);
            this.lblErrorMedicacion.TabIndex = 99;
            this.lblErrorMedicacion.Text = "Mensaje Error";
            this.lblErrorMedicacion.Visible = false;
            // 
            // lblErrorGuardar
            // 
            this.lblErrorGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorGuardar.AutoSize = true;
            this.lblErrorGuardar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGuardar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorGuardar.Image")));
            this.lblErrorGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorGuardar.Location = new System.Drawing.Point(809, 487);
            this.lblErrorGuardar.Name = "lblErrorGuardar";
            this.lblErrorGuardar.Size = new System.Drawing.Size(106, 19);
            this.lblErrorGuardar.TabIndex = 101;
            this.lblErrorGuardar.Text = "Mensaje Error";
            this.lblErrorGuardar.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnImprimir.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnImprimir.BordeRadio = 32;
            this.btnImprimir.BordeTamaño = 0;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnImprimir.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(802, 584);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(281, 34);
            this.btnImprimir.TabIndex = 102;
            this.btnImprimir.Text = " Imprimir Documento Historial";
            this.btnImprimir.TextoColor = System.Drawing.Color.White;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // NuevoHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1207, 638);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblErrorGuardar);
            this.Controls.Add(this.lblErrorMedicacion);
            this.Controls.Add(this.lblErrorAlergias);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimipar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtMedicacion);
            this.Controls.Add(this.txtAlergias);
            this.Controls.Add(this.lblTituloObservaciones);
            this.Controls.Add(this.lblTituloMedicacion);
            this.Controls.Add(this.lblTituloAlergias);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoHistorial";
            this.Load += new System.EventHandler(this.NuevoHistorial_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private TextboxPersonalizado txtFecha;
        private TextboxPersonalizado txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private ControlesPersonalizados.BotonPersonalizado btnLimipar;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.RichTextBox txtMedicacion;
        private System.Windows.Forms.RichTextBox txtAlergias;
        private System.Windows.Forms.Label lblTituloObservaciones;
        private System.Windows.Forms.Label lblTituloMedicacion;
        private System.Windows.Forms.Label lblTituloAlergias;
        private System.Windows.Forms.Label lblErrorAlergias;
        private System.Windows.Forms.Label lblErrorMedicacion;
        private System.Windows.Forms.Label lblErrorGuardar;
        private ControlesPersonalizados.BotonPersonalizado btnImprimir;
    }
}