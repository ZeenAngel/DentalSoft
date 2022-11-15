namespace DentalSoft.Formularios
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblColegiado = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlContenedorEmpleados = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.pnlContenedorFichajes = new System.Windows.Forms.Panel();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.lblFichajes = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.cbVacaciones = new System.Windows.Forms.CheckBox();
            this.cbOdontologos = new System.Windows.Forms.CheckBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblErrorFichar = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.lblFichajeCorrecto = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mcFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.btnControlHorario = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevoEmpleado = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnFichar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnTodasFechas = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.gbDatosEmpleado.SuspendLayout();
            this.pnlContenedorEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pnlContenedorFichajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.lblColegiado);
            this.gbDatosEmpleado.Controls.Add(this.lblEspecialidad);
            this.gbDatosEmpleado.Controls.Add(this.lblPuesto);
            this.gbDatosEmpleado.Controls.Add(this.lblEmail);
            this.gbDatosEmpleado.Controls.Add(this.lblTelefono);
            this.gbDatosEmpleado.Controls.Add(this.lblDni);
            this.gbDatosEmpleado.Controls.Add(this.lblNombre);
            this.gbDatosEmpleado.Font = new System.Drawing.Font("Roboto", 12F);
            this.gbDatosEmpleado.Location = new System.Drawing.Point(25, 99);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(825, 248);
            this.gbDatosEmpleado.TabIndex = 13;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "Datos Empleado";
            // 
            // lblColegiado
            // 
            this.lblColegiado.AutoSize = true;
            this.lblColegiado.Location = new System.Drawing.Point(497, 197);
            this.lblColegiado.Name = "lblColegiado";
            this.lblColegiado.Size = new System.Drawing.Size(102, 19);
            this.lblColegiado.TabIndex = 6;
            this.lblColegiado.Text = "Nº Colegiado";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(264, 197);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(99, 19);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(35, 197);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(58, 19);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(497, 102);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 19);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(35, 54);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 19);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "Dni";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlContenedorEmpleados
            // 
            this.pnlContenedorEmpleados.Controls.Add(this.dgvEmpleados);
            this.pnlContenedorEmpleados.Location = new System.Drawing.Point(25, 409);
            this.pnlContenedorEmpleados.Name = "pnlContenedorEmpleados";
            this.pnlContenedorEmpleados.Size = new System.Drawing.Size(1096, 270);
            this.pnlContenedorEmpleados.TabIndex = 15;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1096, 270);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentDoubleClick);
            // 
            // pnlContenedorFichajes
            // 
            this.pnlContenedorFichajes.Controls.Add(this.dgvFichajes);
            this.pnlContenedorFichajes.Location = new System.Drawing.Point(25, 409);
            this.pnlContenedorFichajes.Name = "pnlContenedorFichajes";
            this.pnlContenedorFichajes.Size = new System.Drawing.Size(1096, 283);
            this.pnlContenedorFichajes.TabIndex = 20;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFichajes.Location = new System.Drawing.Point(0, 0);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.Size = new System.Drawing.Size(1096, 283);
            this.dgvFichajes.TabIndex = 0;
            // 
            // lblFichajes
            // 
            this.lblFichajes.AutoSize = true;
            this.lblFichajes.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFichajes.Location = new System.Drawing.Point(25, 369);
            this.lblFichajes.Name = "lblFichajes";
            this.lblFichajes.Size = new System.Drawing.Size(131, 19);
            this.lblFichajes.TabIndex = 22;
            this.lblFichajes.Text = "Historial Fichajes";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblEmpleados.Location = new System.Drawing.Point(25, 368);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(145, 19);
            this.lblEmpleados.TabIndex = 23;
            this.lblEmpleados.Text = "Listado Empleados";
            // 
            // cbActivos
            // 
            this.cbActivos.AutoSize = true;
            this.cbActivos.Location = new System.Drawing.Point(327, 372);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Size = new System.Drawing.Size(207, 19);
            this.cbActivos.TabIndex = 24;
            this.cbActivos.Text = "Mostrar solo empleados activos";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // cbVacaciones
            // 
            this.cbVacaciones.AutoSize = true;
            this.cbVacaciones.Location = new System.Drawing.Point(564, 372);
            this.cbVacaciones.Name = "cbVacaciones";
            this.cbVacaciones.Size = new System.Drawing.Size(221, 19);
            this.cbVacaciones.TabIndex = 25;
            this.cbVacaciones.Text = "Mostrar empleados en vacaciones";
            this.cbVacaciones.UseVisualStyleBackColor = true;
            this.cbVacaciones.CheckedChanged += new System.EventHandler(this.cbVacaciones_CheckedChanged);
            // 
            // cbOdontologos
            // 
            this.cbOdontologos.AutoSize = true;
            this.cbOdontologos.Location = new System.Drawing.Point(809, 372);
            this.cbOdontologos.Name = "cbOdontologos";
            this.cbOdontologos.Size = new System.Drawing.Size(170, 19);
            this.cbOdontologos.TabIndex = 26;
            this.cbOdontologos.Text = "Mostrar solo odontologos";
            this.cbOdontologos.UseVisualStyleBackColor = true;
            this.cbOdontologos.CheckedChanged += new System.EventHandler(this.cbOdontologos_CheckedChanged);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Location = new System.Drawing.Point(264, 372);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(45, 15);
            this.lblFiltros.TabIndex = 27;
            this.lblFiltros.Text = "Filtros:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(440, 373);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Filtrar por fecha:";
            // 
            // lblErrorFichar
            // 
            this.lblErrorFichar.AutoSize = true;
            this.lblErrorFichar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFichar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorFichar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorFichar.Image")));
            this.lblErrorFichar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorFichar.Location = new System.Drawing.Point(898, 169);
            this.lblErrorFichar.Name = "lblErrorFichar";
            this.lblErrorFichar.Size = new System.Drawing.Size(85, 15);
            this.lblErrorFichar.TabIndex = 17;
            this.lblErrorFichar.Text = "Mensaje Error";
            this.lblErrorFichar.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(25, 23);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblFichajeCorrecto
            // 
            this.lblFichajeCorrecto.AutoSize = true;
            this.lblFichajeCorrecto.Location = new System.Drawing.Point(901, 169);
            this.lblFichajeCorrecto.Name = "lblFichajeCorrecto";
            this.lblFichajeCorrecto.Size = new System.Drawing.Size(41, 15);
            this.lblFichajeCorrecto.TabIndex = 29;
            this.lblFichajeCorrecto.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mcFecha
            // 
            this.mcFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFecha.BordeTamaño = 0;
            this.mcFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFecha.Font = new System.Drawing.Font("Roboto", 9.5F);
            this.mcFecha.IsDesplegado = false;
            this.mcFecha.Location = new System.Drawing.Point(546, 362);
            this.mcFecha.MinDate = new System.DateTime(2022, 11, 5, 13, 26, 37, 263);
            this.mcFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.Size = new System.Drawing.Size(264, 35);
            this.mcFecha.TabIndex = 28;
            this.mcFecha.TextoColor = System.Drawing.Color.White;
            this.mcFecha.Value = new System.DateTime(2022, 11, 5, 13, 26, 37, 263);
            this.mcFecha.CloseUp += new System.EventHandler(this.mcFecha_CloseUp);
            // 
            // btnControlHorario
            // 
            this.btnControlHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnControlHorario.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnControlHorario.BordeRadio = 40;
            this.btnControlHorario.BordeTamaño = 0;
            this.btnControlHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlHorario.FlatAppearance.BorderSize = 0;
            this.btnControlHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnControlHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlHorario.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnControlHorario.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnControlHorario.ForeColor = System.Drawing.Color.White;
            this.btnControlHorario.Location = new System.Drawing.Point(890, 306);
            this.btnControlHorario.Name = "btnControlHorario";
            this.btnControlHorario.Size = new System.Drawing.Size(171, 40);
            this.btnControlHorario.TabIndex = 21;
            this.btnControlHorario.Text = "Control Horario";
            this.btnControlHorario.TextoColor = System.Drawing.Color.White;
            this.btnControlHorario.UseVisualStyleBackColor = false;
            this.btnControlHorario.Click += new System.EventHandler(this.btnControlHorario_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoEmpleado.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoEmpleado.BordeRadio = 40;
            this.btnNuevoEmpleado.BordeTamaño = 0;
            this.btnNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnNuevoEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleado.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(890, 214);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(171, 40);
            this.btnNuevoEmpleado.TabIndex = 18;
            this.btnNuevoEmpleado.Text = "Nuevo Empleado";
            this.btnNuevoEmpleado.TextoColor = System.Drawing.Color.White;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnFichar
            // 
            this.btnFichar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFichar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFichar.BordeRadio = 40;
            this.btnFichar.BordeTamaño = 0;
            this.btnFichar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFichar.FlatAppearance.BorderSize = 0;
            this.btnFichar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnFichar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFichar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnFichar.ForeColor = System.Drawing.Color.White;
            this.btnFichar.Location = new System.Drawing.Point(890, 112);
            this.btnFichar.Name = "btnFichar";
            this.btnFichar.Size = new System.Drawing.Size(150, 40);
            this.btnFichar.TabIndex = 14;
            this.btnFichar.Text = "Fichar Entrada";
            this.btnFichar.TextoColor = System.Drawing.Color.White;
            this.btnFichar.UseVisualStyleBackColor = false;
            this.btnFichar.Click += new System.EventHandler(this.btnFichar_Click);
            // 
            // btnTodasFechas
            // 
            this.btnTodasFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodasFechas.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodasFechas.BordeRadio = 25;
            this.btnTodasFechas.BordeTamaño = 0;
            this.btnTodasFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodasFechas.FlatAppearance.BorderSize = 0;
            this.btnTodasFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnTodasFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodasFechas.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodasFechas.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnTodasFechas.ForeColor = System.Drawing.Color.White;
            this.btnTodasFechas.Location = new System.Drawing.Point(844, 369);
            this.btnTodasFechas.Name = "btnTodasFechas";
            this.btnTodasFechas.Size = new System.Drawing.Size(150, 26);
            this.btnTodasFechas.TabIndex = 30;
            this.btnTodasFechas.Text = "Mostrar todas las fechas";
            this.btnTodasFechas.TextoColor = System.Drawing.Color.White;
            this.btnTodasFechas.UseVisualStyleBackColor = false;
            this.btnTodasFechas.Click += new System.EventHandler(this.btnTodasFechas_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.btnTodasFechas);
            this.Controls.Add(this.lblFichajeCorrecto);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.pnlContenedorFichajes);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.cbOdontologos);
            this.Controls.Add(this.cbVacaciones);
            this.Controls.Add(this.cbActivos);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.lblFichajes);
            this.Controls.Add(this.btnControlHorario);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.lblErrorFichar);
            this.Controls.Add(this.pnlContenedorEmpleados);
            this.Controls.Add(this.btnFichar);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.gbDatosEmpleado.ResumeLayout(false);
            this.gbDatosEmpleado.PerformLayout();
            this.pnlContenedorEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pnlContenedorFichajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private ControlesPersonalizados.BotonPersonalizado btnFichar;
        private System.Windows.Forms.Panel pnlContenedorEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblErrorFichar;
        private ControlesPersonalizados.BotonPersonalizado btnNuevoEmpleado;
        private System.Windows.Forms.Panel pnlContenedorFichajes;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private ControlesPersonalizados.BotonPersonalizado btnControlHorario;
        private System.Windows.Forms.Label lblFichajes;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.CheckBox cbVacaciones;
        private System.Windows.Forms.CheckBox cbOdontologos;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblFecha;
        private ControlesPersonalizados.SelectorFecha mcFecha;
        private System.Windows.Forms.Label lblFichajeCorrecto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblColegiado;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private ControlesPersonalizados.BotonPersonalizado btnTodasFechas;
    }
}