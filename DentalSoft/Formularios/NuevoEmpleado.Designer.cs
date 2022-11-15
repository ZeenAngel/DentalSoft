namespace DentalSoft.Formularios
{
    partial class NuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEmpleado));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblTituloDni = new System.Windows.Forms.Label();
            this.lblTituloApellido1 = new System.Windows.Forms.Label();
            this.lblTituloApellido2 = new System.Windows.Forms.Label();
            this.lblTituloTelefono = new System.Windows.Forms.Label();
            this.lblTituloEmail = new System.Windows.Forms.Label();
            this.lblTituloPuesto = new System.Windows.Forms.Label();
            this.lblTituloColegiado = new System.Windows.Forms.Label();
            this.lblTituloCentro = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.cbVacaciones = new System.Windows.Forms.CheckBox();
            this.lblTituloEspecialidad = new System.Windows.Forms.Label();
            this.btnLimpiar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.cbEspecialidad = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.cbPuesto = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.btnGuardar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtColegiado = new DentalSoft.TextboxPersonalizado();
            this.txtTelefono = new DentalSoft.TextboxPersonalizado();
            this.txtApellido1 = new DentalSoft.TextboxPersonalizado();
            this.txtEmail = new DentalSoft.TextboxPersonalizado();
            this.txtApellido2 = new DentalSoft.TextboxPersonalizado();
            this.txtNombre = new DentalSoft.TextboxPersonalizado();
            this.txtDni = new DentalSoft.TextboxPersonalizado();
            this.cbCentro = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.lblErrorExiste = new System.Windows.Forms.Label();
            this.lblErrorCentro = new System.Windows.Forms.Label();
            this.lblErrorColegiado = new System.Windows.Forms.Label();
            this.lblErrorEspecialidad = new System.Windows.Forms.Label();
            this.lblErrorPuesto = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorTelefono = new System.Windows.Forms.Label();
            this.lblErrorApellido1 = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorDni = new System.Windows.Forms.Label();
            this.btnResetPasswordLogin = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
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
            this.pnlCabecera.Size = new System.Drawing.Size(800, 35);
            this.pnlCabecera.TabIndex = 2;
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
            this.btnRedimensionar.Location = new System.Drawing.Point(720, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(679, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(763, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(33, 184);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(69, 19);
            this.lblTituloNombre.TabIndex = 3;
            this.lblTituloNombre.Text = "Nombre:";
            // 
            // lblTituloDni
            // 
            this.lblTituloDni.AutoSize = true;
            this.lblTituloDni.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDni.Location = new System.Drawing.Point(33, 101);
            this.lblTituloDni.Name = "lblTituloDni";
            this.lblTituloDni.Size = new System.Drawing.Size(37, 19);
            this.lblTituloDni.TabIndex = 4;
            this.lblTituloDni.Text = "Dni:";
            // 
            // lblTituloApellido1
            // 
            this.lblTituloApellido1.AutoSize = true;
            this.lblTituloApellido1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApellido1.Location = new System.Drawing.Point(438, 184);
            this.lblTituloApellido1.Name = "lblTituloApellido1";
            this.lblTituloApellido1.Size = new System.Drawing.Size(83, 19);
            this.lblTituloApellido1.TabIndex = 5;
            this.lblTituloApellido1.Text = "Apellido 1:";
            // 
            // lblTituloApellido2
            // 
            this.lblTituloApellido2.AutoSize = true;
            this.lblTituloApellido2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApellido2.Location = new System.Drawing.Point(33, 275);
            this.lblTituloApellido2.Name = "lblTituloApellido2";
            this.lblTituloApellido2.Size = new System.Drawing.Size(83, 19);
            this.lblTituloApellido2.TabIndex = 6;
            this.lblTituloApellido2.Text = "Apellido 2:";
            // 
            // lblTituloTelefono
            // 
            this.lblTituloTelefono.AutoSize = true;
            this.lblTituloTelefono.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTelefono.Location = new System.Drawing.Point(438, 275);
            this.lblTituloTelefono.Name = "lblTituloTelefono";
            this.lblTituloTelefono.Size = new System.Drawing.Size(75, 19);
            this.lblTituloTelefono.TabIndex = 7;
            this.lblTituloTelefono.Text = "Teléfono:";
            // 
            // lblTituloEmail
            // 
            this.lblTituloEmail.AutoSize = true;
            this.lblTituloEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmail.Location = new System.Drawing.Point(33, 360);
            this.lblTituloEmail.Name = "lblTituloEmail";
            this.lblTituloEmail.Size = new System.Drawing.Size(140, 19);
            this.lblTituloEmail.TabIndex = 8;
            this.lblTituloEmail.Text = "Correo electrónico:";
            // 
            // lblTituloPuesto
            // 
            this.lblTituloPuesto.AutoSize = true;
            this.lblTituloPuesto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPuesto.Location = new System.Drawing.Point(33, 446);
            this.lblTituloPuesto.Name = "lblTituloPuesto";
            this.lblTituloPuesto.Size = new System.Drawing.Size(62, 19);
            this.lblTituloPuesto.TabIndex = 9;
            this.lblTituloPuesto.Text = "Puesto:";
            // 
            // lblTituloColegiado
            // 
            this.lblTituloColegiado.AutoSize = true;
            this.lblTituloColegiado.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColegiado.Location = new System.Drawing.Point(438, 535);
            this.lblTituloColegiado.Name = "lblTituloColegiado";
            this.lblTituloColegiado.Size = new System.Drawing.Size(106, 19);
            this.lblTituloColegiado.TabIndex = 10;
            this.lblTituloColegiado.Text = "Nº Colegiado:";
            // 
            // lblTituloCentro
            // 
            this.lblTituloCentro.AutoSize = true;
            this.lblTituloCentro.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCentro.Location = new System.Drawing.Point(33, 535);
            this.lblTituloCentro.Name = "lblTituloCentro";
            this.lblTituloCentro.Size = new System.Drawing.Size(59, 19);
            this.lblTituloCentro.TabIndex = 11;
            this.lblTituloCentro.Text = "Centro:";
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbActivo.Location = new System.Drawing.Point(282, 613);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(72, 23);
            this.cbActivo.TabIndex = 50;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // cbVacaciones
            // 
            this.cbVacaciones.AutoSize = true;
            this.cbVacaciones.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbVacaciones.Location = new System.Drawing.Point(388, 613);
            this.cbVacaciones.Name = "cbVacaciones";
            this.cbVacaciones.Size = new System.Drawing.Size(110, 23);
            this.cbVacaciones.TabIndex = 55;
            this.cbVacaciones.Text = "Vacaciones";
            this.cbVacaciones.UseVisualStyleBackColor = true;
            // 
            // lblTituloEspecialidad
            // 
            this.lblTituloEspecialidad.AutoSize = true;
            this.lblTituloEspecialidad.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEspecialidad.Location = new System.Drawing.Point(438, 445);
            this.lblTituloEspecialidad.Name = "lblTituloEspecialidad";
            this.lblTituloEspecialidad.Size = new System.Drawing.Size(103, 19);
            this.lblTituloEspecialidad.TabIndex = 45;
            this.lblTituloEspecialidad.Text = "Especialidad:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiar.BordeRadio = 29;
            this.btnLimpiar.BordeTamaño = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(308, 735);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 29);
            this.btnLimpiar.TabIndex = 65;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.TextoColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbEspecialidad.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbEspecialidad.BordeTamaño = 1;
            this.cbEspecialidad.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbEspecialidad.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbEspecialidad.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbEspecialidad.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.cbEspecialidad.ListaColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbEspecialidad.ListColorTexto = System.Drawing.Color.DimGray;
            this.cbEspecialidad.Location = new System.Drawing.Point(563, 438);
            this.cbEspecialidad.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Padding = new System.Windows.Forms.Padding(1);
            this.cbEspecialidad.Size = new System.Drawing.Size(200, 30);
            this.cbEspecialidad.TabIndex = 35;
            this.cbEspecialidad.Textos = "";
            // 
            // cbPuesto
            // 
            this.cbPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbPuesto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbPuesto.BordeTamaño = 1;
            this.cbPuesto.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbPuesto.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbPuesto.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPuesto.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuesto.ForeColor = System.Drawing.Color.Black;
            this.cbPuesto.ListaColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPuesto.ListColorTexto = System.Drawing.Color.DimGray;
            this.cbPuesto.Location = new System.Drawing.Point(187, 435);
            this.cbPuesto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Padding = new System.Windows.Forms.Padding(1);
            this.cbPuesto.Size = new System.Drawing.Size(200, 30);
            this.cbPuesto.TabIndex = 30;
            this.cbPuesto.Textos = "";
            this.cbPuesto.OnSelectedIndexChanged += new System.EventHandler(this.cbPuesto_OnSelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.BordeRadio = 40;
            this.btnGuardar.BordeTamaño = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(308, 676);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextoColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtColegiado
            // 
            this.txtColegiado.BackColor = System.Drawing.SystemColors.Window;
            this.txtColegiado.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtColegiado.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtColegiado.BordeRadio = 0;
            this.txtColegiado.BordeTamaño = 2;
            this.txtColegiado.Contraseña = false;
            this.txtColegiado.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColegiado.ForeColor = System.Drawing.Color.Black;
            this.txtColegiado.Location = new System.Drawing.Point(563, 529);
            this.txtColegiado.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtColegiado.MarcadorPosicionTexto = "";
            this.txtColegiado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtColegiado.Multilinea = false;
            this.txtColegiado.Name = "txtColegiado";
            this.txtColegiado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColegiado.Size = new System.Drawing.Size(200, 30);
            this.txtColegiado.SubrayadoEstilo = true;
            this.txtColegiado.TabIndex = 45;
            this.txtColegiado.Texto = "";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtTelefono.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtTelefono.BordeRadio = 0;
            this.txtTelefono.BordeTamaño = 2;
            this.txtTelefono.Contraseña = false;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(563, 264);
            this.txtTelefono.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.MarcadorPosicionTexto = "";
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Multilinea = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.Size = new System.Drawing.Size(200, 30);
            this.txtTelefono.SubrayadoEstilo = true;
            this.txtTelefono.TabIndex = 20;
            this.txtTelefono.Texto = "";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido1.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtApellido1.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtApellido1.BordeRadio = 0;
            this.txtApellido1.BordeTamaño = 2;
            this.txtApellido1.Contraseña = false;
            this.txtApellido1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.ForeColor = System.Drawing.Color.Black;
            this.txtApellido1.Location = new System.Drawing.Point(563, 175);
            this.txtApellido1.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtApellido1.MarcadorPosicionTexto = "";
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido1.Multilinea = false;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido1.Size = new System.Drawing.Size(200, 30);
            this.txtApellido1.SubrayadoEstilo = true;
            this.txtApellido1.TabIndex = 10;
            this.txtApellido1.Texto = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtEmail.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtEmail.BordeRadio = 0;
            this.txtEmail.BordeTamaño = 2;
            this.txtEmail.Contraseña = false;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(187, 353);
            this.txtEmail.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtEmail.MarcadorPosicionTexto = "";
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Multilinea = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.Size = new System.Drawing.Size(576, 30);
            this.txtEmail.SubrayadoEstilo = true;
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Texto = "";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido2.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtApellido2.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtApellido2.BordeRadio = 0;
            this.txtApellido2.BordeTamaño = 2;
            this.txtApellido2.Contraseña = false;
            this.txtApellido2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.ForeColor = System.Drawing.Color.Black;
            this.txtApellido2.Location = new System.Drawing.Point(187, 270);
            this.txtApellido2.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtApellido2.MarcadorPosicionTexto = "";
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido2.Multilinea = false;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido2.Size = new System.Drawing.Size(205, 30);
            this.txtApellido2.SubrayadoEstilo = true;
            this.txtApellido2.TabIndex = 15;
            this.txtApellido2.Texto = "";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtNombre.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtNombre.BordeRadio = 0;
            this.txtNombre.BordeTamaño = 2;
            this.txtNombre.Contraseña = false;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(187, 175);
            this.txtNombre.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtNombre.MarcadorPosicionTexto = "";
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Multilinea = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.Size = new System.Drawing.Size(205, 30);
            this.txtNombre.SubrayadoEstilo = true;
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Texto = "";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.Window;
            this.txtDni.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtDni.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtDni.BordeRadio = 0;
            this.txtDni.BordeTamaño = 2;
            this.txtDni.Contraseña = false;
            this.txtDni.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.Black;
            this.txtDni.Location = new System.Drawing.Point(187, 94);
            this.txtDni.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtDni.MarcadorPosicionTexto = "";
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Multilinea = false;
            this.txtDni.Name = "txtDni";
            this.txtDni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDni.Size = new System.Drawing.Size(205, 30);
            this.txtDni.SubrayadoEstilo = true;
            this.txtDni.TabIndex = 0;
            this.txtDni.Texto = "";
            // 
            // cbCentro
            // 
            this.cbCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCentro.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCentro.BordeTamaño = 1;
            this.cbCentro.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbCentro.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbCentro.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCentro.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCentro.ForeColor = System.Drawing.Color.Black;
            this.cbCentro.ListaColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCentro.ListColorTexto = System.Drawing.Color.DimGray;
            this.cbCentro.Location = new System.Drawing.Point(187, 531);
            this.cbCentro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCentro.Name = "cbCentro";
            this.cbCentro.Padding = new System.Windows.Forms.Padding(1);
            this.cbCentro.Size = new System.Drawing.Size(200, 30);
            this.cbCentro.TabIndex = 40;
            this.cbCentro.Textos = "";
            // 
            // lblErrorExiste
            // 
            this.lblErrorExiste.AutoSize = true;
            this.lblErrorExiste.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorExiste.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorExiste.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorExiste.Image")));
            this.lblErrorExiste.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorExiste.Location = new System.Drawing.Point(413, 102);
            this.lblErrorExiste.Name = "lblErrorExiste";
            this.lblErrorExiste.Size = new System.Drawing.Size(85, 15);
            this.lblErrorExiste.TabIndex = 56;
            this.lblErrorExiste.Text = "Mensaje Error";
            this.lblErrorExiste.Visible = false;
            // 
            // lblErrorCentro
            // 
            this.lblErrorCentro.AutoSize = true;
            this.lblErrorCentro.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCentro.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCentro.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCentro.Image")));
            this.lblErrorCentro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCentro.Location = new System.Drawing.Point(184, 575);
            this.lblErrorCentro.Name = "lblErrorCentro";
            this.lblErrorCentro.Size = new System.Drawing.Size(85, 15);
            this.lblErrorCentro.TabIndex = 54;
            this.lblErrorCentro.Text = "Mensaje Error";
            this.lblErrorCentro.Visible = false;
            // 
            // lblErrorColegiado
            // 
            this.lblErrorColegiado.AutoSize = true;
            this.lblErrorColegiado.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorColegiado.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorColegiado.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorColegiado.Image")));
            this.lblErrorColegiado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorColegiado.Location = new System.Drawing.Point(560, 577);
            this.lblErrorColegiado.Name = "lblErrorColegiado";
            this.lblErrorColegiado.Size = new System.Drawing.Size(85, 15);
            this.lblErrorColegiado.TabIndex = 53;
            this.lblErrorColegiado.Text = "Mensaje Error";
            this.lblErrorColegiado.Visible = false;
            // 
            // lblErrorEspecialidad
            // 
            this.lblErrorEspecialidad.AutoSize = true;
            this.lblErrorEspecialidad.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEspecialidad.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorEspecialidad.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorEspecialidad.Image")));
            this.lblErrorEspecialidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorEspecialidad.Location = new System.Drawing.Point(560, 482);
            this.lblErrorEspecialidad.Name = "lblErrorEspecialidad";
            this.lblErrorEspecialidad.Size = new System.Drawing.Size(85, 15);
            this.lblErrorEspecialidad.TabIndex = 52;
            this.lblErrorEspecialidad.Text = "Mensaje Error";
            this.lblErrorEspecialidad.Visible = false;
            // 
            // lblErrorPuesto
            // 
            this.lblErrorPuesto.AutoSize = true;
            this.lblErrorPuesto.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPuesto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPuesto.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPuesto.Image")));
            this.lblErrorPuesto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPuesto.Location = new System.Drawing.Point(184, 482);
            this.lblErrorPuesto.Name = "lblErrorPuesto";
            this.lblErrorPuesto.Size = new System.Drawing.Size(85, 15);
            this.lblErrorPuesto.TabIndex = 51;
            this.lblErrorPuesto.Text = "Mensaje Error";
            this.lblErrorPuesto.Visible = false;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorEmail.Image")));
            this.lblErrorEmail.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorEmail.Location = new System.Drawing.Point(184, 395);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(85, 15);
            this.lblErrorEmail.TabIndex = 50;
            this.lblErrorEmail.Text = "Mensaje Error";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorTelefono
            // 
            this.lblErrorTelefono.AutoSize = true;
            this.lblErrorTelefono.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTelefono.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorTelefono.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorTelefono.Image")));
            this.lblErrorTelefono.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorTelefono.Location = new System.Drawing.Point(560, 313);
            this.lblErrorTelefono.Name = "lblErrorTelefono";
            this.lblErrorTelefono.Size = new System.Drawing.Size(85, 15);
            this.lblErrorTelefono.TabIndex = 49;
            this.lblErrorTelefono.Text = "Mensaje Error";
            this.lblErrorTelefono.Visible = false;
            // 
            // lblErrorApellido1
            // 
            this.lblErrorApellido1.AutoSize = true;
            this.lblErrorApellido1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApellido1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorApellido1.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorApellido1.Image")));
            this.lblErrorApellido1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorApellido1.Location = new System.Drawing.Point(560, 226);
            this.lblErrorApellido1.Name = "lblErrorApellido1";
            this.lblErrorApellido1.Size = new System.Drawing.Size(85, 15);
            this.lblErrorApellido1.TabIndex = 48;
            this.lblErrorApellido1.Text = "Mensaje Error";
            this.lblErrorApellido1.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorNombre.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorNombre.Image")));
            this.lblErrorNombre.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorNombre.Location = new System.Drawing.Point(184, 226);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(85, 15);
            this.lblErrorNombre.TabIndex = 47;
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
            this.lblErrorDni.Location = new System.Drawing.Point(184, 136);
            this.lblErrorDni.Name = "lblErrorDni";
            this.lblErrorDni.Size = new System.Drawing.Size(85, 15);
            this.lblErrorDni.TabIndex = 46;
            this.lblErrorDni.Text = "Mensaje Error";
            this.lblErrorDni.Visible = false;
            // 
            // btnResetPasswordLogin
            // 
            this.btnResetPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnResetPasswordLogin.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnResetPasswordLogin.BordeRadio = 29;
            this.btnResetPasswordLogin.BordeTamaño = 0;
            this.btnResetPasswordLogin.FlatAppearance.BorderSize = 0;
            this.btnResetPasswordLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnResetPasswordLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPasswordLogin.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnResetPasswordLogin.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnResetPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.btnResetPasswordLogin.Location = new System.Drawing.Point(563, 97);
            this.btnResetPasswordLogin.Name = "btnResetPasswordLogin";
            this.btnResetPasswordLogin.Size = new System.Drawing.Size(200, 29);
            this.btnResetPasswordLogin.TabIndex = 66;
            this.btnResetPasswordLogin.Text = "Reiniciar Contraseña Login";
            this.btnResetPasswordLogin.TextoColor = System.Drawing.Color.White;
            this.btnResetPasswordLogin.UseVisualStyleBackColor = false;
            this.btnResetPasswordLogin.Click += new System.EventHandler(this.btnResetPasswordLogin_Click);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Location = new System.Drawing.Point(570, 136);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(35, 13);
            this.lblResetPassword.TabIndex = 67;
            this.lblResetPassword.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.btnResetPasswordLogin);
            this.Controls.Add(this.lblErrorExiste);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblErrorCentro);
            this.Controls.Add(this.lblErrorColegiado);
            this.Controls.Add(this.lblErrorEspecialidad);
            this.Controls.Add(this.lblErrorPuesto);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorTelefono);
            this.Controls.Add(this.lblErrorApellido1);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorDni);
            this.Controls.Add(this.lblTituloEspecialidad);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.cbVacaciones);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtColegiado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cbCentro);
            this.Controls.Add(this.lblTituloCentro);
            this.Controls.Add(this.lblTituloColegiado);
            this.Controls.Add(this.lblTituloPuesto);
            this.Controls.Add(this.lblTituloEmail);
            this.Controls.Add(this.lblTituloTelefono);
            this.Controls.Add(this.lblTituloApellido2);
            this.Controls.Add(this.lblTituloApellido1);
            this.Controls.Add(this.lblTituloDni);
            this.Controls.Add(this.lblTituloNombre);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarEmpleado";
            this.Load += new System.EventHandler(this.EditarEmpleado_Load);
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Label lblTituloDni;
        private System.Windows.Forms.Label lblTituloApellido1;
        private System.Windows.Forms.Label lblTituloApellido2;
        private System.Windows.Forms.Label lblTituloTelefono;
        private System.Windows.Forms.Label lblTituloEmail;
        private System.Windows.Forms.Label lblTituloPuesto;
        private System.Windows.Forms.Label lblTituloColegiado;
        private System.Windows.Forms.Label lblTituloCentro;
        private ControlesPersonalizados.ComboBoxPersonalizado cbCentro;
        private TextboxPersonalizado txtDni;
        private TextboxPersonalizado txtNombre;
        private TextboxPersonalizado txtApellido2;
        private TextboxPersonalizado txtEmail;
        private TextboxPersonalizado txtApellido1;
        private TextboxPersonalizado txtTelefono;
        private TextboxPersonalizado txtColegiado;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.CheckBox cbVacaciones;
        private ControlesPersonalizados.ComboBoxPersonalizado cbPuesto;
        private ControlesPersonalizados.ComboBoxPersonalizado cbEspecialidad;
        private System.Windows.Forms.Label lblTituloEspecialidad;
        private System.Windows.Forms.Label lblErrorDni;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorApellido1;
        private System.Windows.Forms.Label lblErrorTelefono;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPuesto;
        private System.Windows.Forms.Label lblErrorEspecialidad;
        private System.Windows.Forms.Label lblErrorColegiado;
        private System.Windows.Forms.Label lblErrorCentro;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiar;
        private System.Windows.Forms.Label lblErrorExiste;
        private ControlesPersonalizados.BotonPersonalizado btnResetPasswordLogin;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.Timer timer1;
    }
}