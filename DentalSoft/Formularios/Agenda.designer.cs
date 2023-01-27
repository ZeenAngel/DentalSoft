namespace DentalSoft.Formularios
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.lvHorasConsulta = new System.Windows.Forms.ListView();
            this.lblNuevaHora = new System.Windows.Forms.Label();
            this.lblErrorHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbHorasConsulta = new System.Windows.Forms.GroupBox();
            this.btnNuevaHora = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtNuevaHora = new DentalSoft.TextboxPersonalizado();
            this.btnEliminar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.gbAgendar = new System.Windows.Forms.GroupBox();
            this.lblErrorGuardar = new System.Windows.Forms.Label();
            this.btnGuardarAgenda = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lvHorasAsignadas = new System.Windows.Forms.ListView();
            this.btnQuitarHora = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnQuitarTodasHora = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnAñadirTodasHora = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnAñadirHora = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lvHorasDisponibles = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorOdontologo = new System.Windows.Forms.Label();
            this.btnBuscarOdontologoNuevaReserva = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblOdontologoNuevaReserva = new System.Windows.Forms.Label();
            this.txtOdontologo = new DentalSoft.TextboxPersonalizado();
            this.mcFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbHorasConsulta.SuspendLayout();
            this.gbAgendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHorasConsulta
            // 
            this.lvHorasConsulta.HideSelection = false;
            this.lvHorasConsulta.Location = new System.Drawing.Point(23, 40);
            this.lvHorasConsulta.Name = "lvHorasConsulta";
            this.lvHorasConsulta.Size = new System.Drawing.Size(116, 526);
            this.lvHorasConsulta.TabIndex = 13;
            this.lvHorasConsulta.UseCompatibleStateImageBehavior = false;
            // 
            // lblNuevaHora
            // 
            this.lblNuevaHora.AutoSize = true;
            this.lblNuevaHora.Location = new System.Drawing.Point(155, 191);
            this.lblNuevaHora.Name = "lblNuevaHora";
            this.lblNuevaHora.Size = new System.Drawing.Size(112, 24);
            this.lblNuevaHora.TabIndex = 17;
            this.lblNuevaHora.Text = "Nueva hora";
            // 
            // lblErrorHora
            // 
            this.lblErrorHora.AutoSize = true;
            this.lblErrorHora.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHora.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorHora.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorHora.Image")));
            this.lblErrorHora.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorHora.Location = new System.Drawing.Point(160, 248);
            this.lblErrorHora.Name = "lblErrorHora";
            this.lblErrorHora.Size = new System.Drawing.Size(106, 19);
            this.lblErrorHora.TabIndex = 48;
            this.lblErrorHora.Text = "Mensaje Error";
            this.lblErrorHora.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbHorasConsulta
            // 
            this.gbHorasConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbHorasConsulta.Controls.Add(this.lvHorasConsulta);
            this.gbHorasConsulta.Controls.Add(this.btnNuevaHora);
            this.gbHorasConsulta.Controls.Add(this.txtNuevaHora);
            this.gbHorasConsulta.Controls.Add(this.lblNuevaHora);
            this.gbHorasConsulta.Controls.Add(this.lblErrorHora);
            this.gbHorasConsulta.Controls.Add(this.btnEliminar);
            this.gbHorasConsulta.Location = new System.Drawing.Point(121, 96);
            this.gbHorasConsulta.Name = "gbHorasConsulta";
            this.gbHorasConsulta.Size = new System.Drawing.Size(436, 591);
            this.gbHorasConsulta.TabIndex = 99;
            this.gbHorasConsulta.TabStop = false;
            this.gbHorasConsulta.Text = "Horas de consulta";
            // 
            // btnNuevaHora
            // 
            this.btnNuevaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevaHora.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevaHora.BordeRadio = 32;
            this.btnNuevaHora.BordeTamaño = 0;
            this.btnNuevaHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaHora.FlatAppearance.BorderSize = 0;
            this.btnNuevaHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevaHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaHora.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevaHora.ForeColor = System.Drawing.Color.White;
            this.btnNuevaHora.Location = new System.Drawing.Point(277, 210);
            this.btnNuevaHora.Name = "btnNuevaHora";
            this.btnNuevaHora.Size = new System.Drawing.Size(137, 34);
            this.btnNuevaHora.TabIndex = 16;
            this.btnNuevaHora.Text = "Añadir hora";
            this.btnNuevaHora.TextoColor = System.Drawing.Color.White;
            this.btnNuevaHora.UseVisualStyleBackColor = false;
            this.btnNuevaHora.Click += new System.EventHandler(this.btnNuevaHora_Click);
            // 
            // txtNuevaHora
            // 
            this.txtNuevaHora.BackColor = System.Drawing.Color.White;
            this.txtNuevaHora.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtNuevaHora.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtNuevaHora.BordeRadio = 0;
            this.txtNuevaHora.BordeTamaño = 2;
            this.txtNuevaHora.Contraseña = false;
            this.txtNuevaHora.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaHora.ForeColor = System.Drawing.Color.Black;
            this.txtNuevaHora.Location = new System.Drawing.Point(159, 214);
            this.txtNuevaHora.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtNuevaHora.MarcadorPosicionTexto = "";
            this.txtNuevaHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaHora.Multilinea = false;
            this.txtNuevaHora.Name = "txtNuevaHora";
            this.txtNuevaHora.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNuevaHora.PosicionSeleccion = 0;
            this.txtNuevaHora.Size = new System.Drawing.Size(111, 34);
            this.txtNuevaHora.SubrayadoEstilo = true;
            this.txtNuevaHora.TabIndex = 50;
            this.txtNuevaHora.TamañoMaximo = 30000;
            this.txtNuevaHora.Texto = "";
            this.txtNuevaHora._TextChanged += new System.EventHandler(this.txtNuevaHora__TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BordeRadio = 32;
            this.btnEliminar.BordeTamaño = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(159, 313);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(251, 34);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar hora seleccionada";
            this.btnEliminar.TextoColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbAgendar
            // 
            this.gbAgendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgendar.Controls.Add(this.lblErrorGuardar);
            this.gbAgendar.Controls.Add(this.btnGuardarAgenda);
            this.gbAgendar.Controls.Add(this.lvHorasAsignadas);
            this.gbAgendar.Controls.Add(this.btnQuitarHora);
            this.gbAgendar.Controls.Add(this.btnQuitarTodasHora);
            this.gbAgendar.Controls.Add(this.btnAñadirTodasHora);
            this.gbAgendar.Controls.Add(this.btnAñadirHora);
            this.gbAgendar.Controls.Add(this.lvHorasDisponibles);
            this.gbAgendar.Controls.Add(this.label1);
            this.gbAgendar.Controls.Add(this.lblErrorOdontologo);
            this.gbAgendar.Controls.Add(this.btnBuscarOdontologoNuevaReserva);
            this.gbAgendar.Controls.Add(this.lblOdontologoNuevaReserva);
            this.gbAgendar.Controls.Add(this.txtOdontologo);
            this.gbAgendar.Controls.Add(this.mcFecha);
            this.gbAgendar.Location = new System.Drawing.Point(589, 96);
            this.gbAgendar.Name = "gbAgendar";
            this.gbAgendar.Size = new System.Drawing.Size(444, 591);
            this.gbAgendar.TabIndex = 100;
            this.gbAgendar.TabStop = false;
            this.gbAgendar.Text = "Agendar horas";
            // 
            // lblErrorGuardar
            // 
            this.lblErrorGuardar.AutoSize = true;
            this.lblErrorGuardar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGuardar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorGuardar.Image")));
            this.lblErrorGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorGuardar.Location = new System.Drawing.Point(44, 569);
            this.lblErrorGuardar.Name = "lblErrorGuardar";
            this.lblErrorGuardar.Size = new System.Drawing.Size(106, 19);
            this.lblErrorGuardar.TabIndex = 45;
            this.lblErrorGuardar.Text = "Mensaje Error";
            this.lblErrorGuardar.Visible = false;
            // 
            // btnGuardarAgenda
            // 
            this.btnGuardarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarAgenda.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarAgenda.BordeRadio = 32;
            this.btnGuardarAgenda.BordeTamaño = 0;
            this.btnGuardarAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAgenda.FlatAppearance.BorderSize = 0;
            this.btnGuardarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAgenda.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarAgenda.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAgenda.Location = new System.Drawing.Point(41, 532);
            this.btnGuardarAgenda.Name = "btnGuardarAgenda";
            this.btnGuardarAgenda.Size = new System.Drawing.Size(370, 34);
            this.btnGuardarAgenda.TabIndex = 44;
            this.btnGuardarAgenda.Text = "Guardar Agenda";
            this.btnGuardarAgenda.TextoColor = System.Drawing.Color.White;
            this.btnGuardarAgenda.UseVisualStyleBackColor = false;
            this.btnGuardarAgenda.Click += new System.EventHandler(this.btnGuardarAgenda_Click);
            // 
            // lvHorasAsignadas
            // 
            this.lvHorasAsignadas.HideSelection = false;
            this.lvHorasAsignadas.Location = new System.Drawing.Point(295, 240);
            this.lvHorasAsignadas.Name = "lvHorasAsignadas";
            this.lvHorasAsignadas.Size = new System.Drawing.Size(116, 270);
            this.lvHorasAsignadas.TabIndex = 43;
            this.lvHorasAsignadas.UseCompatibleStateImageBehavior = false;
            // 
            // btnQuitarHora
            // 
            this.btnQuitarHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnQuitarHora.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarHora.BordeRadio = 32;
            this.btnQuitarHora.BordeTamaño = 0;
            this.btnQuitarHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarHora.FlatAppearance.BorderSize = 0;
            this.btnQuitarHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnQuitarHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarHora.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnQuitarHora.Font = new System.Drawing.Font("Roboto", 16F);
            this.btnQuitarHora.ForeColor = System.Drawing.Color.White;
            this.btnQuitarHora.Location = new System.Drawing.Point(199, 438);
            this.btnQuitarHora.Name = "btnQuitarHora";
            this.btnQuitarHora.Size = new System.Drawing.Size(51, 34);
            this.btnQuitarHora.TabIndex = 42;
            this.btnQuitarHora.Text = "<";
            this.btnQuitarHora.TextoColor = System.Drawing.Color.White;
            this.btnQuitarHora.UseVisualStyleBackColor = false;
            this.btnQuitarHora.Click += new System.EventHandler(this.btnQuitarHora_Click);
            // 
            // btnQuitarTodasHora
            // 
            this.btnQuitarTodasHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnQuitarTodasHora.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarTodasHora.BordeRadio = 32;
            this.btnQuitarTodasHora.BordeTamaño = 0;
            this.btnQuitarTodasHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarTodasHora.FlatAppearance.BorderSize = 0;
            this.btnQuitarTodasHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnQuitarTodasHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTodasHora.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnQuitarTodasHora.Font = new System.Drawing.Font("Roboto", 16F);
            this.btnQuitarTodasHora.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTodasHora.Location = new System.Drawing.Point(199, 389);
            this.btnQuitarTodasHora.Name = "btnQuitarTodasHora";
            this.btnQuitarTodasHora.Size = new System.Drawing.Size(51, 34);
            this.btnQuitarTodasHora.TabIndex = 41;
            this.btnQuitarTodasHora.Text = "<<";
            this.btnQuitarTodasHora.TextoColor = System.Drawing.Color.White;
            this.btnQuitarTodasHora.UseVisualStyleBackColor = false;
            this.btnQuitarTodasHora.Click += new System.EventHandler(this.btnQuitarTodasHora_Click);
            // 
            // btnAñadirTodasHora
            // 
            this.btnAñadirTodasHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadirTodasHora.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnAñadirTodasHora.BordeRadio = 32;
            this.btnAñadirTodasHora.BordeTamaño = 0;
            this.btnAñadirTodasHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirTodasHora.FlatAppearance.BorderSize = 0;
            this.btnAñadirTodasHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnAñadirTodasHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirTodasHora.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadirTodasHora.Font = new System.Drawing.Font("Roboto", 16F);
            this.btnAñadirTodasHora.ForeColor = System.Drawing.Color.White;
            this.btnAñadirTodasHora.Location = new System.Drawing.Point(199, 339);
            this.btnAñadirTodasHora.Name = "btnAñadirTodasHora";
            this.btnAñadirTodasHora.Size = new System.Drawing.Size(51, 34);
            this.btnAñadirTodasHora.TabIndex = 40;
            this.btnAñadirTodasHora.Text = ">>";
            this.btnAñadirTodasHora.TextoColor = System.Drawing.Color.White;
            this.btnAñadirTodasHora.UseVisualStyleBackColor = false;
            this.btnAñadirTodasHora.Click += new System.EventHandler(this.btnAñadirTodasHora_Click);
            // 
            // btnAñadirHora
            // 
            this.btnAñadirHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadirHora.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnAñadirHora.BordeRadio = 32;
            this.btnAñadirHora.BordeTamaño = 0;
            this.btnAñadirHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirHora.FlatAppearance.BorderSize = 0;
            this.btnAñadirHora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnAñadirHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirHora.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAñadirHora.Font = new System.Drawing.Font("Roboto", 16F);
            this.btnAñadirHora.ForeColor = System.Drawing.Color.White;
            this.btnAñadirHora.Location = new System.Drawing.Point(199, 290);
            this.btnAñadirHora.Name = "btnAñadirHora";
            this.btnAñadirHora.Size = new System.Drawing.Size(51, 34);
            this.btnAñadirHora.TabIndex = 39;
            this.btnAñadirHora.Text = ">";
            this.btnAñadirHora.TextoColor = System.Drawing.Color.White;
            this.btnAñadirHora.UseVisualStyleBackColor = false;
            this.btnAñadirHora.Click += new System.EventHandler(this.btnAñadirHora_Click);
            // 
            // lvHorasDisponibles
            // 
            this.lvHorasDisponibles.HideSelection = false;
            this.lvHorasDisponibles.Location = new System.Drawing.Point(41, 240);
            this.lvHorasDisponibles.Name = "lvHorasDisponibles";
            this.lvHorasDisponibles.Size = new System.Drawing.Size(116, 270);
            this.lvHorasDisponibles.TabIndex = 38;
            this.lvHorasDisponibles.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Seleccione una fecha";
            // 
            // lblErrorOdontologo
            // 
            this.lblErrorOdontologo.AutoSize = true;
            this.lblErrorOdontologo.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOdontologo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorOdontologo.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorOdontologo.Image")));
            this.lblErrorOdontologo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorOdontologo.Location = new System.Drawing.Point(38, 113);
            this.lblErrorOdontologo.Name = "lblErrorOdontologo";
            this.lblErrorOdontologo.Size = new System.Drawing.Size(106, 19);
            this.lblErrorOdontologo.TabIndex = 36;
            this.lblErrorOdontologo.Text = "Mensaje Error";
            this.lblErrorOdontologo.Visible = false;
            // 
            // btnBuscarOdontologoNuevaReserva
            // 
            this.btnBuscarOdontologoNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarOdontologoNuevaReserva.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarOdontologoNuevaReserva.BordeRadio = 32;
            this.btnBuscarOdontologoNuevaReserva.BordeTamaño = 0;
            this.btnBuscarOdontologoNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarOdontologoNuevaReserva.FlatAppearance.BorderSize = 0;
            this.btnBuscarOdontologoNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnBuscarOdontologoNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOdontologoNuevaReserva.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarOdontologoNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOdontologoNuevaReserva.Location = new System.Drawing.Point(298, 64);
            this.btnBuscarOdontologoNuevaReserva.Name = "btnBuscarOdontologoNuevaReserva";
            this.btnBuscarOdontologoNuevaReserva.Size = new System.Drawing.Size(115, 34);
            this.btnBuscarOdontologoNuevaReserva.TabIndex = 34;
            this.btnBuscarOdontologoNuevaReserva.Text = "Buscar";
            this.btnBuscarOdontologoNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.btnBuscarOdontologoNuevaReserva.UseVisualStyleBackColor = false;
            this.btnBuscarOdontologoNuevaReserva.Click += new System.EventHandler(this.btnBuscarOdontologoNuevaReserva_Click);
            // 
            // lblOdontologoNuevaReserva
            // 
            this.lblOdontologoNuevaReserva.AutoSize = true;
            this.lblOdontologoNuevaReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblOdontologoNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.lblOdontologoNuevaReserva.Location = new System.Drawing.Point(37, 46);
            this.lblOdontologoNuevaReserva.Name = "lblOdontologoNuevaReserva";
            this.lblOdontologoNuevaReserva.Size = new System.Drawing.Size(113, 24);
            this.lblOdontologoNuevaReserva.TabIndex = 35;
            this.lblOdontologoNuevaReserva.Text = "Odontologo";
            // 
            // txtOdontologo
            // 
            this.txtOdontologo.BackColor = System.Drawing.SystemColors.Window;
            this.txtOdontologo.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtOdontologo.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtOdontologo.BordeRadio = 0;
            this.txtOdontologo.BordeTamaño = 2;
            this.txtOdontologo.Contraseña = false;
            this.txtOdontologo.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdontologo.ForeColor = System.Drawing.Color.Black;
            this.txtOdontologo.Location = new System.Drawing.Point(41, 68);
            this.txtOdontologo.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtOdontologo.MarcadorPosicionTexto = "";
            this.txtOdontologo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOdontologo.Multilinea = false;
            this.txtOdontologo.Name = "txtOdontologo";
            this.txtOdontologo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOdontologo.PosicionSeleccion = 0;
            this.txtOdontologo.Size = new System.Drawing.Size(250, 34);
            this.txtOdontologo.SubrayadoEstilo = true;
            this.txtOdontologo.TabIndex = 33;
            this.txtOdontologo.TamañoMaximo = 30000;
            this.txtOdontologo.Texto = "";
            this.txtOdontologo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdontologo_KeyPress);
            // 
            // mcFecha
            // 
            this.mcFecha.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.mcFecha.BordeTamaño = 0;
            this.mcFecha.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.mcFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mcFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.mcFecha.IsDesplegado = false;
            this.mcFecha.Location = new System.Drawing.Point(41, 167);
            this.mcFecha.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.mcFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.Size = new System.Drawing.Size(270, 35);
            this.mcFecha.TabIndex = 1;
            this.mcFecha.TextoColor = System.Drawing.Color.White;
            this.mcFecha.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            this.mcFecha.ValueChanged += new System.EventHandler(this.mcFecha_ValueChanged);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.gbAgendar);
            this.Controls.Add(this.gbHorasConsulta);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Agenda";
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.Ajustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbHorasConsulta.ResumeLayout(false);
            this.gbHorasConsulta.PerformLayout();
            this.gbAgendar.ResumeLayout(false);
            this.gbAgendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvHorasConsulta;
        private ControlesPersonalizados.BotonPersonalizado btnNuevaHora;
        private System.Windows.Forms.Label lblNuevaHora;
        private ControlesPersonalizados.BotonPersonalizado btnEliminar;
        private System.Windows.Forms.Label lblErrorHora;
        private TextboxPersonalizado txtNuevaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbHorasConsulta;
        private System.Windows.Forms.GroupBox gbAgendar;
        private ControlesPersonalizados.SelectorFecha mcFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorOdontologo;
        private ControlesPersonalizados.BotonPersonalizado btnBuscarOdontologoNuevaReserva;
        private System.Windows.Forms.Label lblOdontologoNuevaReserva;
        private TextboxPersonalizado txtOdontologo;
        private System.Windows.Forms.ListView lvHorasAsignadas;
        private ControlesPersonalizados.BotonPersonalizado btnQuitarHora;
        private ControlesPersonalizados.BotonPersonalizado btnQuitarTodasHora;
        private ControlesPersonalizados.BotonPersonalizado btnAñadirTodasHora;
        private ControlesPersonalizados.BotonPersonalizado btnAñadirHora;
        private System.Windows.Forms.ListView lvHorasDisponibles;
        private ControlesPersonalizados.BotonPersonalizado btnGuardarAgenda;
        private System.Windows.Forms.Label lblErrorGuardar;
    }
}