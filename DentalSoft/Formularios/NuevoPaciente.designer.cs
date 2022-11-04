namespace DentalSoft
{
    partial class NuevoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPaciente));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chConsentimiento = new System.Windows.Forms.CheckBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorDni = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.lblErrorCp = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.txtDni = new DentalSoft.TextboxPersonalizado();
            this.btnLimpiarCampos = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnGuardarPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtEmail = new DentalSoft.TextboxPersonalizado();
            this.txtApellido2 = new DentalSoft.TextboxPersonalizado();
            this.txtCp = new DentalSoft.TextboxPersonalizado();
            this.txtTelefono = new DentalSoft.TextboxPersonalizado();
            this.txtApellido1 = new DentalSoft.TextboxPersonalizado();
            this.txtNombre = new DentalSoft.TextboxPersonalizado();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new DentalSoft.TextboxPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new DentalSoft.TextboxPersonalizado();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.lblErrorEdad = new System.Windows.Forms.Label();
            this.lblErrorGenero = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbGenero.SuspendLayout();
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
            this.pnlCabecera.Size = new System.Drawing.Size(1083, 35);
            this.pnlCabecera.TabIndex = 10;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "DentalSoft";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedimensionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedimensionar.Image = ((System.Drawing.Image)(resources.GetObject("btnRedimensionar.Image")));
            this.btnRedimensionar.Location = new System.Drawing.Point(1003, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(962, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(1046, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(483, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 23);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido1
            // 
            this.lblApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(55, 179);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(141, 23);
            this.lblApellido1.TabIndex = 12;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // lblApellido2
            // 
            this.lblApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(483, 179);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(159, 23);
            this.lblApellido2.TabIndex = 13;
            this.lblApellido2.Text = "Segundo Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(55, 279);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(84, 23);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(483, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(166, 23);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // chConsentimiento
            // 
            this.chConsentimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chConsentimiento.AutoSize = true;
            this.chConsentimiento.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chConsentimiento.Location = new System.Drawing.Point(199, 565);
            this.chConsentimiento.Name = "chConsentimiento";
            this.chConsentimiento.Size = new System.Drawing.Size(486, 23);
            this.chConsentimiento.TabIndex = 35;
            this.chConsentimiento.Text = "El paciente ha aceptado el consentimiento de contacto comercial";
            this.chConsentimiento.UseVisualStyleBackColor = true;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(55, 371);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(130, 23);
            this.lblCodigoPostal.TabIndex = 22;
            this.lblCodigoPostal.Text = "Código Postal";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "DNI";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorNombre.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorNombre.Image")));
            this.lblErrorNombre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorNombre.Location = new System.Drawing.Point(658, 128);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(85, 15);
            this.lblErrorNombre.TabIndex = 46;
            this.lblErrorNombre.Text = "Mensaje Error";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorDni
            // 
            this.lblErrorDni.AutoSize = true;
            this.lblErrorDni.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDni.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorDni.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorDni.Image")));
            this.lblErrorDni.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorDni.Location = new System.Drawing.Point(200, 128);
            this.lblErrorDni.Name = "lblErrorDni";
            this.lblErrorDni.Size = new System.Drawing.Size(85, 15);
            this.lblErrorDni.TabIndex = 47;
            this.lblErrorDni.Text = "Mensaje Error";
            this.lblErrorDni.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApellido.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorApellido.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorApellido.Image")));
            this.lblErrorApellido.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorApellido.Location = new System.Drawing.Point(196, 226);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(85, 15);
            this.lblErrorApellido.TabIndex = 48;
            this.lblErrorApellido.Text = "Mensaje Error";
            this.lblErrorApellido.Visible = false;
            // 
            // lblErrorCp
            // 
            this.lblErrorCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblErrorCp.AutoSize = true;
            this.lblErrorCp.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCp.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCp.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCp.Image")));
            this.lblErrorCp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCp.Location = new System.Drawing.Point(200, 420);
            this.lblErrorCp.Name = "lblErrorCp";
            this.lblErrorCp.Size = new System.Drawing.Size(85, 15);
            this.lblErrorCp.TabIndex = 49;
            this.lblErrorCp.Text = "Mensaje Error";
            this.lblErrorCp.Visible = false;
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorTelefono.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorTelefono.Image")));
            this.lblErrorTelefono.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorTelefono.Location = new System.Drawing.Point(200, 324);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(85, 15);
            this.lblErrorTelefono.TabIndex = 50;
            this.lblErrorTelefono.Text = "Mensaje Error";
            this.lblErrorTelefono.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.Window;
            this.txtDni.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtDni.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtDni.BordeRadio = 0;
            this.txtDni.BordeTamaño = 2;
            this.txtDni.Contraseña = false;
            this.txtDni.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDni.ForeColor = System.Drawing.Color.Black;
            this.txtDni.Location = new System.Drawing.Point(199, 84);
            this.txtDni.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtDni.MarcadorPosicionTexto = "";
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Multilinea = false;
            this.txtDni.Name = "txtDni";
            this.txtDni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDni.Size = new System.Drawing.Size(250, 34);
            this.txtDni.SubrayadoEstilo = true;
            this.txtDni.TabIndex = 51;
            this.txtDni.Texto = "";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(554, 638);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(281, 34);
            this.btnLimpiarCampos.TabIndex = 45;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.TextoColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarPaciente.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarPaciente.BordeRadio = 32;
            this.btnGuardarPaciente.BordeTamaño = 0;
            this.btnGuardarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPaciente.FlatAppearance.BorderSize = 0;
            this.btnGuardarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPaciente.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarPaciente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPaciente.Location = new System.Drawing.Point(243, 638);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(281, 34);
            this.btnGuardarPaciente.TabIndex = 40;
            this.btnGuardarPaciente.Text = "Guardar Paciente";
            this.btnGuardarPaciente.TextoColor = System.Drawing.Color.White;
            this.btnGuardarPaciente.UseVisualStyleBackColor = false;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.btnGuardarPaciente_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtEmail.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtEmail.BordeRadio = 0;
            this.txtEmail.BordeTamaño = 2;
            this.txtEmail.Contraseña = false;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(661, 272);
            this.txtEmail.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtEmail.MarcadorPosicionTexto = "";
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Multilinea = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.Size = new System.Drawing.Size(369, 34);
            this.txtEmail.SubrayadoEstilo = true;
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Texto = "";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido2.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido2.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtApellido2.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtApellido2.BordeRadio = 0;
            this.txtApellido2.BordeTamaño = 2;
            this.txtApellido2.Contraseña = false;
            this.txtApellido2.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtApellido2.ForeColor = System.Drawing.Color.Black;
            this.txtApellido2.Location = new System.Drawing.Point(661, 176);
            this.txtApellido2.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtApellido2.MarcadorPosicionTexto = "";
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido2.Multilinea = false;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido2.Size = new System.Drawing.Size(261, 34);
            this.txtApellido2.SubrayadoEstilo = true;
            this.txtApellido2.TabIndex = 15;
            this.txtApellido2.Texto = "";
            // 
            // txtCp
            // 
            this.txtCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCp.BackColor = System.Drawing.SystemColors.Window;
            this.txtCp.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtCp.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtCp.BordeRadio = 0;
            this.txtCp.BordeTamaño = 2;
            this.txtCp.Contraseña = false;
            this.txtCp.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCp.ForeColor = System.Drawing.Color.Black;
            this.txtCp.Location = new System.Drawing.Point(203, 368);
            this.txtCp.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtCp.MarcadorPosicionTexto = "";
            this.txtCp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCp.Multilinea = false;
            this.txtCp.Name = "txtCp";
            this.txtCp.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCp.Size = new System.Drawing.Size(136, 34);
            this.txtCp.SubrayadoEstilo = true;
            this.txtCp.TabIndex = 30;
            this.txtCp.Texto = "";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtTelefono.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtTelefono.BordeRadio = 0;
            this.txtTelefono.BordeTamaño = 2;
            this.txtTelefono.Contraseña = false;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(203, 272);
            this.txtTelefono.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.MarcadorPosicionTexto = "";
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Multilinea = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.Size = new System.Drawing.Size(261, 34);
            this.txtTelefono.SubrayadoEstilo = true;
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.Texto = "";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido1.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido1.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtApellido1.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtApellido1.BordeRadio = 0;
            this.txtApellido1.BordeTamaño = 2;
            this.txtApellido1.Contraseña = false;
            this.txtApellido1.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtApellido1.ForeColor = System.Drawing.Color.Black;
            this.txtApellido1.Location = new System.Drawing.Point(203, 176);
            this.txtApellido1.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtApellido1.MarcadorPosicionTexto = "";
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido1.Multilinea = false;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido1.Size = new System.Drawing.Size(261, 34);
            this.txtApellido1.SubrayadoEstilo = true;
            this.txtApellido1.TabIndex = 10;
            this.txtApellido1.Texto = "";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtNombre.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtNombre.BordeRadio = 0;
            this.txtNombre.BordeTamaño = 2;
            this.txtNombre.Contraseña = false;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(661, 84);
            this.txtNombre.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtNombre.MarcadorPosicionTexto = "";
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Multilinea = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.Size = new System.Drawing.Size(250, 34);
            this.txtNombre.SubrayadoEstilo = true;
            this.txtNombre.TabIndex = 52;
            this.txtNombre.Texto = "";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorEmail.Image")));
            this.lblErrorEmail.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorEmail.Location = new System.Drawing.Point(658, 324);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(85, 15);
            this.lblErrorEmail.TabIndex = 53;
            this.lblErrorEmail.Text = "Mensaje Error";
            this.lblErrorEmail.Visible = false;
            // 
            // gbGenero
            // 
            this.gbGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGenero.Controls.Add(this.lblErrorGenero);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Font = new System.Drawing.Font("Roboto", 12F);
            this.gbGenero.Location = new System.Drawing.Point(487, 445);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(348, 90);
            this.gbGenero.TabIndex = 77;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(189, 30);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(97, 23);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(32, 30);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(101, 23);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtDireccion.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtDireccion.BordeRadio = 0;
            this.txtDireccion.BordeTamaño = 2;
            this.txtDireccion.Contraseña = false;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(661, 368);
            this.txtDireccion.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtDireccion.MarcadorPosicionTexto = "";
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Multilinea = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDireccion.Size = new System.Drawing.Size(369, 34);
            this.txtDireccion.SubrayadoEstilo = true;
            this.txtDireccion.TabIndex = 79;
            this.txtDireccion.Texto = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 78;
            this.label4.Text = "Dirección";
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtEdad.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtEdad.BordeRadio = 0;
            this.txtEdad.BordeTamaño = 2;
            this.txtEdad.Contraseña = false;
            this.txtEdad.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(203, 459);
            this.txtEdad.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtEdad.MarcadorPosicionTexto = "";
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEdad.Multilinea = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEdad.Size = new System.Drawing.Size(136, 34);
            this.txtEdad.SubrayadoEstilo = true;
            this.txtEdad.TabIndex = 81;
            this.txtEdad.Texto = "";
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(55, 462);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(53, 23);
            this.lblEdad.TabIndex = 80;
            this.lblEdad.Text = "Edad";
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorDireccion.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorDireccion.Image")));
            this.lblErrorDireccion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorDireccion.Location = new System.Drawing.Point(658, 417);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(85, 15);
            this.lblErrorDireccion.TabIndex = 82;
            this.lblErrorDireccion.Text = "Mensaje Error";
            this.lblErrorDireccion.Visible = false;
            // 
            // lblErrorEdad
            // 
            this.lblErrorEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblErrorEdad.AutoSize = true;
            this.lblErrorEdad.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEdad.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorEdad.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorEdad.Image")));
            this.lblErrorEdad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorEdad.Location = new System.Drawing.Point(200, 510);
            this.lblErrorEdad.Name = "lblErrorEdad";
            this.lblErrorEdad.Size = new System.Drawing.Size(85, 15);
            this.lblErrorEdad.TabIndex = 83;
            this.lblErrorEdad.Text = "Mensaje Error";
            this.lblErrorEdad.Visible = false;
            // 
            // lblErrorGenero
            // 
            this.lblErrorGenero.AutoSize = true;
            this.lblErrorGenero.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGenero.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorGenero.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorGenero.Image")));
            this.lblErrorGenero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorGenero.Location = new System.Drawing.Point(6, 65);
            this.lblErrorGenero.Name = "lblErrorGenero";
            this.lblErrorGenero.Size = new System.Drawing.Size(85, 15);
            this.lblErrorGenero.TabIndex = 84;
            this.lblErrorGenero.Text = "Mensaje Error";
            this.lblErrorGenero.Visible = false;
            // 
            // NuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 722);
            this.Controls.Add(this.lblErrorEdad);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblErrorTelefono);
            this.Controls.Add(this.lblErrorCp);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.lblErrorDni);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.chConsentimiento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoPaciente";
            this.Load += new System.EventHandler(this.NuevoPaciente_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chConsentimiento;
        private System.Windows.Forms.Label lblCodigoPostal;
        private TextboxPersonalizado txtApellido1;
        private TextboxPersonalizado txtTelefono;
        private TextboxPersonalizado txtCp;
        private TextboxPersonalizado txtApellido2;
        private TextboxPersonalizado txtEmail;
        private System.Windows.Forms.Label label2;
        private ControlesPersonalizados.BotonPersonalizado btnGuardarPaciente;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiarCampos;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorDni;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.Label lblErrorCp;
        private System.Windows.Forms.Label lblErrorTelefono;
        private TextboxPersonalizado txtDni;
        private TextboxPersonalizado txtNombre;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.Label lblErrorGenero;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private TextboxPersonalizado txtDireccion;
        private System.Windows.Forms.Label label4;
        private TextboxPersonalizado txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblErrorDireccion;
        private System.Windows.Forms.Label lblErrorEdad;
    }
}