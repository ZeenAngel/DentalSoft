namespace DentalSoft
{
    partial class NuevaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaReserva));
            this.gbFechaReserva = new System.Windows.Forms.GroupBox();
            this.lblErrorHoras = new System.Windows.Forms.Label();
            this.lblErrorOdontologoNuevaReserva = new System.Windows.Forms.Label();
            this.lblErrorPacienteNuevaReserva = new System.Windows.Forms.Label();
            this.btnBuscarOdontologoNuevaReserva = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnBuscarPacienteNuevaReserva = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblOdontologoNuevaReserva = new System.Windows.Forms.Label();
            this.lblPacienteNuevaReserva = new System.Windows.Forms.Label();
            this.btnLimpiarDatosNuevaReserva = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblHoraNuevaReserva = new System.Windows.Forms.Label();
            this.txtPacienteNuevaReserva = new DentalSoft.TextboxPersonalizado();
            this.txtOdontologoNuevaReserva = new DentalSoft.TextboxPersonalizado();
            this.btnGuardarNuevaReserva = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.mcCalendarioNuevaReserva = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.cbHoraNuevaReserva = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.lblSeleccionarFechaNuevaReserva = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFechaReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFechaReserva
            // 
            this.gbFechaReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFechaReserva.Controls.Add(this.lblErrorHoras);
            this.gbFechaReserva.Controls.Add(this.lblErrorOdontologoNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.lblErrorPacienteNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.btnBuscarOdontologoNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.btnBuscarPacienteNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.lblOdontologoNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.lblPacienteNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.btnLimpiarDatosNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.lblHoraNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.txtPacienteNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.txtOdontologoNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.btnGuardarNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.mcCalendarioNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.cbHoraNuevaReserva);
            this.gbFechaReserva.Controls.Add(this.lblSeleccionarFechaNuevaReserva);
            this.gbFechaReserva.Font = new System.Drawing.Font("Roboto", 14F);
            this.gbFechaReserva.ForeColor = System.Drawing.Color.Black;
            this.gbFechaReserva.Location = new System.Drawing.Point(25, 92);
            this.gbFechaReserva.Name = "gbFechaReserva";
            this.gbFechaReserva.Size = new System.Drawing.Size(1091, 598);
            this.gbFechaReserva.TabIndex = 39;
            this.gbFechaReserva.TabStop = false;
            this.gbFechaReserva.Text = "Nueva Reserva";
            // 
            // lblErrorHoras
            // 
            this.lblErrorHoras.AutoSize = true;
            this.lblErrorHoras.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHoras.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorHoras.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorHoras.Image")));
            this.lblErrorHoras.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorHoras.Location = new System.Drawing.Point(665, 380);
            this.lblErrorHoras.Name = "lblErrorHoras";
            this.lblErrorHoras.Size = new System.Drawing.Size(85, 15);
            this.lblErrorHoras.TabIndex = 36;
            this.lblErrorHoras.Text = "Mensaje Error";
            this.lblErrorHoras.Visible = false;
            // 
            // lblErrorOdontologoNuevaReserva
            // 
            this.lblErrorOdontologoNuevaReserva.AutoSize = true;
            this.lblErrorOdontologoNuevaReserva.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOdontologoNuevaReserva.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorOdontologoNuevaReserva.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorOdontologoNuevaReserva.Image")));
            this.lblErrorOdontologoNuevaReserva.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorOdontologoNuevaReserva.Location = new System.Drawing.Point(665, 281);
            this.lblErrorOdontologoNuevaReserva.Name = "lblErrorOdontologoNuevaReserva";
            this.lblErrorOdontologoNuevaReserva.Size = new System.Drawing.Size(85, 15);
            this.lblErrorOdontologoNuevaReserva.TabIndex = 32;
            this.lblErrorOdontologoNuevaReserva.Text = "Mensaje Error";
            this.lblErrorOdontologoNuevaReserva.Visible = false;
            // 
            // lblErrorPacienteNuevaReserva
            // 
            this.lblErrorPacienteNuevaReserva.AutoSize = true;
            this.lblErrorPacienteNuevaReserva.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPacienteNuevaReserva.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPacienteNuevaReserva.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPacienteNuevaReserva.Image")));
            this.lblErrorPacienteNuevaReserva.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPacienteNuevaReserva.Location = new System.Drawing.Point(665, 147);
            this.lblErrorPacienteNuevaReserva.Name = "lblErrorPacienteNuevaReserva";
            this.lblErrorPacienteNuevaReserva.Size = new System.Drawing.Size(85, 15);
            this.lblErrorPacienteNuevaReserva.TabIndex = 31;
            this.lblErrorPacienteNuevaReserva.Text = "Mensaje Error";
            this.lblErrorPacienteNuevaReserva.Visible = false;
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
            this.btnBuscarOdontologoNuevaReserva.Location = new System.Drawing.Point(947, 222);
            this.btnBuscarOdontologoNuevaReserva.Name = "btnBuscarOdontologoNuevaReserva";
            this.btnBuscarOdontologoNuevaReserva.Size = new System.Drawing.Size(115, 34);
            this.btnBuscarOdontologoNuevaReserva.TabIndex = 25;
            this.btnBuscarOdontologoNuevaReserva.Text = "Buscar";
            this.btnBuscarOdontologoNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.btnBuscarOdontologoNuevaReserva.UseVisualStyleBackColor = false;
            this.btnBuscarOdontologoNuevaReserva.Click += new System.EventHandler(this.btnBuscarOdontologoNuevaReserva_Click);
            // 
            // btnBuscarPacienteNuevaReserva
            // 
            this.btnBuscarPacienteNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPacienteNuevaReserva.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarPacienteNuevaReserva.BordeRadio = 32;
            this.btnBuscarPacienteNuevaReserva.BordeTamaño = 0;
            this.btnBuscarPacienteNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPacienteNuevaReserva.FlatAppearance.BorderSize = 0;
            this.btnBuscarPacienteNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnBuscarPacienteNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPacienteNuevaReserva.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPacienteNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPacienteNuevaReserva.Location = new System.Drawing.Point(947, 90);
            this.btnBuscarPacienteNuevaReserva.Name = "btnBuscarPacienteNuevaReserva";
            this.btnBuscarPacienteNuevaReserva.Size = new System.Drawing.Size(115, 34);
            this.btnBuscarPacienteNuevaReserva.TabIndex = 15;
            this.btnBuscarPacienteNuevaReserva.Text = "Buscar";
            this.btnBuscarPacienteNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.btnBuscarPacienteNuevaReserva.UseVisualStyleBackColor = false;
            this.btnBuscarPacienteNuevaReserva.Click += new System.EventHandler(this.btnBuscarPacienteNuevaReserva_Click);
            // 
            // lblOdontologoNuevaReserva
            // 
            this.lblOdontologoNuevaReserva.AutoSize = true;
            this.lblOdontologoNuevaReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblOdontologoNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.lblOdontologoNuevaReserva.Location = new System.Drawing.Point(569, 231);
            this.lblOdontologoNuevaReserva.Name = "lblOdontologoNuevaReserva";
            this.lblOdontologoNuevaReserva.Size = new System.Drawing.Size(92, 19);
            this.lblOdontologoNuevaReserva.TabIndex = 28;
            this.lblOdontologoNuevaReserva.Text = "Odontologo";
            // 
            // lblPacienteNuevaReserva
            // 
            this.lblPacienteNuevaReserva.AutoSize = true;
            this.lblPacienteNuevaReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblPacienteNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.lblPacienteNuevaReserva.Location = new System.Drawing.Point(569, 99);
            this.lblPacienteNuevaReserva.Name = "lblPacienteNuevaReserva";
            this.lblPacienteNuevaReserva.Size = new System.Drawing.Size(70, 19);
            this.lblPacienteNuevaReserva.TabIndex = 27;
            this.lblPacienteNuevaReserva.Text = "Paciente";
            // 
            // btnLimpiarDatosNuevaReserva
            // 
            this.btnLimpiarDatosNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarDatosNuevaReserva.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiarDatosNuevaReserva.BordeRadio = 32;
            this.btnLimpiarDatosNuevaReserva.BordeTamaño = 0;
            this.btnLimpiarDatosNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatosNuevaReserva.FlatAppearance.BorderSize = 0;
            this.btnLimpiarDatosNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimpiarDatosNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatosNuevaReserva.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarDatosNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarDatosNuevaReserva.Location = new System.Drawing.Point(534, 534);
            this.btnLimpiarDatosNuevaReserva.Name = "btnLimpiarDatosNuevaReserva";
            this.btnLimpiarDatosNuevaReserva.Size = new System.Drawing.Size(196, 34);
            this.btnLimpiarDatosNuevaReserva.TabIndex = 35;
            this.btnLimpiarDatosNuevaReserva.Text = "Limpiar Datos";
            this.btnLimpiarDatosNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.btnLimpiarDatosNuevaReserva.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosNuevaReserva.Click += new System.EventHandler(this.btnLimpiarDatosNuevaReserva_Click);
            // 
            // lblHoraNuevaReserva
            // 
            this.lblHoraNuevaReserva.AutoSize = true;
            this.lblHoraNuevaReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblHoraNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.lblHoraNuevaReserva.Location = new System.Drawing.Point(569, 343);
            this.lblHoraNuevaReserva.Name = "lblHoraNuevaReserva";
            this.lblHoraNuevaReserva.Size = new System.Drawing.Size(43, 19);
            this.lblHoraNuevaReserva.TabIndex = 25;
            this.lblHoraNuevaReserva.Text = "Hora";
            // 
            // txtPacienteNuevaReserva
            // 
            this.txtPacienteNuevaReserva.BackColor = System.Drawing.SystemColors.Window;
            this.txtPacienteNuevaReserva.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPacienteNuevaReserva.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPacienteNuevaReserva.BordeRadio = 0;
            this.txtPacienteNuevaReserva.BordeTamaño = 2;
            this.txtPacienteNuevaReserva.Contraseña = false;
            this.txtPacienteNuevaReserva.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.txtPacienteNuevaReserva.Location = new System.Drawing.Point(668, 92);
            this.txtPacienteNuevaReserva.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPacienteNuevaReserva.MarcadorPosicionTexto = "";
            this.txtPacienteNuevaReserva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPacienteNuevaReserva.Multilinea = false;
            this.txtPacienteNuevaReserva.Name = "txtPacienteNuevaReserva";
            this.txtPacienteNuevaReserva.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPacienteNuevaReserva.PosicionSeleccion = 0;
            this.txtPacienteNuevaReserva.Size = new System.Drawing.Size(250, 30);
            this.txtPacienteNuevaReserva.SubrayadoEstilo = true;
            this.txtPacienteNuevaReserva.TabIndex = 10;
            this.txtPacienteNuevaReserva.TamañoMaximo = 30000;
            this.txtPacienteNuevaReserva.Texto = "";
            // 
            // txtOdontologoNuevaReserva
            // 
            this.txtOdontologoNuevaReserva.BackColor = System.Drawing.SystemColors.Window;
            this.txtOdontologoNuevaReserva.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtOdontologoNuevaReserva.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtOdontologoNuevaReserva.BordeRadio = 0;
            this.txtOdontologoNuevaReserva.BordeTamaño = 2;
            this.txtOdontologoNuevaReserva.Contraseña = false;
            this.txtOdontologoNuevaReserva.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdontologoNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.txtOdontologoNuevaReserva.Location = new System.Drawing.Point(668, 225);
            this.txtOdontologoNuevaReserva.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtOdontologoNuevaReserva.MarcadorPosicionTexto = "";
            this.txtOdontologoNuevaReserva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOdontologoNuevaReserva.Multilinea = false;
            this.txtOdontologoNuevaReserva.Name = "txtOdontologoNuevaReserva";
            this.txtOdontologoNuevaReserva.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOdontologoNuevaReserva.PosicionSeleccion = 0;
            this.txtOdontologoNuevaReserva.Size = new System.Drawing.Size(250, 30);
            this.txtOdontologoNuevaReserva.SubrayadoEstilo = true;
            this.txtOdontologoNuevaReserva.TabIndex = 20;
            this.txtOdontologoNuevaReserva.TamañoMaximo = 30000;
            this.txtOdontologoNuevaReserva.Texto = "";
            this.txtOdontologoNuevaReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOdontologoNuevaReserva_KeyPress);
            // 
            // btnGuardarNuevaReserva
            // 
            this.btnGuardarNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarNuevaReserva.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarNuevaReserva.BordeRadio = 32;
            this.btnGuardarNuevaReserva.BordeTamaño = 0;
            this.btnGuardarNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNuevaReserva.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardarNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevaReserva.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNuevaReserva.Location = new System.Drawing.Point(312, 534);
            this.btnGuardarNuevaReserva.Name = "btnGuardarNuevaReserva";
            this.btnGuardarNuevaReserva.Size = new System.Drawing.Size(196, 34);
            this.btnGuardarNuevaReserva.TabIndex = 30;
            this.btnGuardarNuevaReserva.Text = "Guardar";
            this.btnGuardarNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.btnGuardarNuevaReserva.UseVisualStyleBackColor = false;
            this.btnGuardarNuevaReserva.Click += new System.EventHandler(this.btnGuardarNuevaReserva_Click);
            // 
            // mcCalendarioNuevaReserva
            // 
            this.mcCalendarioNuevaReserva.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.mcCalendarioNuevaReserva.BordeTamaño = 0;
            this.mcCalendarioNuevaReserva.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.mcCalendarioNuevaReserva.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mcCalendarioNuevaReserva.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcCalendarioNuevaReserva.Font = new System.Drawing.Font("Roboto", 11F);
            this.mcCalendarioNuevaReserva.IsDesplegado = false;
            this.mcCalendarioNuevaReserva.Location = new System.Drawing.Point(78, 220);
            this.mcCalendarioNuevaReserva.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.mcCalendarioNuevaReserva.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcCalendarioNuevaReserva.Name = "mcCalendarioNuevaReserva";
            this.mcCalendarioNuevaReserva.Size = new System.Drawing.Size(270, 35);
            this.mcCalendarioNuevaReserva.TabIndex = 0;
            this.mcCalendarioNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.mcCalendarioNuevaReserva.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            this.mcCalendarioNuevaReserva.ValueChanged += new System.EventHandler(this.mcCalendarioNuevaReserva_ValueChanged);
            // 
            // cbHoraNuevaReserva
            // 
            this.cbHoraNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbHoraNuevaReserva.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbHoraNuevaReserva.BordeTamaño = 1;
            this.cbHoraNuevaReserva.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbHoraNuevaReserva.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbHoraNuevaReserva.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.cbHoraNuevaReserva.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbHoraNuevaReserva.ListColorTexto = System.Drawing.Color.Black;
            this.cbHoraNuevaReserva.Location = new System.Drawing.Point(668, 335);
            this.cbHoraNuevaReserva.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbHoraNuevaReserva.Name = "cbHoraNuevaReserva";
            this.cbHoraNuevaReserva.Padding = new System.Windows.Forms.Padding(1);
            this.cbHoraNuevaReserva.Size = new System.Drawing.Size(200, 30);
            this.cbHoraNuevaReserva.TabIndex = 5;
            this.cbHoraNuevaReserva.Textos = "";
            // 
            // lblSeleccionarFechaNuevaReserva
            // 
            this.lblSeleccionarFechaNuevaReserva.AutoSize = true;
            this.lblSeleccionarFechaNuevaReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblSeleccionarFechaNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionarFechaNuevaReserva.Location = new System.Drawing.Point(125, 175);
            this.lblSeleccionarFechaNuevaReserva.Name = "lblSeleccionarFechaNuevaReserva";
            this.lblSeleccionarFechaNuevaReserva.Size = new System.Drawing.Size(160, 19);
            this.lblSeleccionarFechaNuevaReserva.TabIndex = 10;
            this.lblSeleccionarFechaNuevaReserva.Text = "Seleccione una fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.gbFechaReserva);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaReserva";
            this.Text = "NuevaReserva";
            this.Load += new System.EventHandler(this.NuevaReserva_Load);
            this.gbFechaReserva.ResumeLayout(false);
            this.gbFechaReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ControlesPersonalizados.ComboBoxPersonalizado cbHoraNuevaReserva;
        private TextboxPersonalizado txtPacienteNuevaReserva;
        private TextboxPersonalizado txtOdontologoNuevaReserva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbFechaReserva;
        private ControlesPersonalizados.BotonPersonalizado btnBuscarOdontologoNuevaReserva;
        private ControlesPersonalizados.BotonPersonalizado btnBuscarPacienteNuevaReserva;
        private System.Windows.Forms.Label lblOdontologoNuevaReserva;
        private System.Windows.Forms.Label lblPacienteNuevaReserva;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiarDatosNuevaReserva;
        private System.Windows.Forms.Label lblHoraNuevaReserva;
        private ControlesPersonalizados.BotonPersonalizado btnGuardarNuevaReserva;
        private ControlesPersonalizados.SelectorFecha mcCalendarioNuevaReserva;
        private System.Windows.Forms.Label lblSeleccionarFechaNuevaReserva;
        private System.Windows.Forms.Label lblErrorOdontologoNuevaReserva;
        private System.Windows.Forms.Label lblErrorPacienteNuevaReserva;
        private System.Windows.Forms.Label lblErrorHoras;
    }
}