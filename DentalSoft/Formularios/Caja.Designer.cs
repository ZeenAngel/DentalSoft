namespace DentalSoft.Formularios
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnCargarPresupuesto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnCargarPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblErrorPresupuesto = new System.Windows.Forms.Label();
            this.lblErrorPaciente = new System.Windows.Forms.Label();
            this.btnBuscarPresupuesto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnBuscarPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtPresupuesto = new DentalSoft.TextboxPersonalizado();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaciente = new DentalSoft.TextboxPersonalizado();
            this.lblPacienteNuevaReserva = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOtros = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnImplante = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnCuretaje = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnOrtodoncia = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnExodoncia = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEndodoncia = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnObturacion = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnLimpieza = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrorEntrega = new System.Windows.Forms.Label();
            this.btnCobrar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblImporteCambio = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtEntrega = new DentalSoft.TextboxPersonalizado();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMetodosPago = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvCobro = new System.Windows.Forms.DataGridView();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.gbBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblNombrePaciente.Location = new System.Drawing.Point(179, 38);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(157, 23);
            this.lblNombrePaciente.TabIndex = 36;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscar.Controls.Add(this.btnCargarPresupuesto);
            this.gbBuscar.Controls.Add(this.btnCargarPaciente);
            this.gbBuscar.Controls.Add(this.lblErrorPresupuesto);
            this.gbBuscar.Controls.Add(this.lblErrorPaciente);
            this.gbBuscar.Controls.Add(this.btnBuscarPresupuesto);
            this.gbBuscar.Controls.Add(this.btnBuscarPaciente);
            this.gbBuscar.Controls.Add(this.txtPresupuesto);
            this.gbBuscar.Controls.Add(this.label4);
            this.gbBuscar.Controls.Add(this.txtPaciente);
            this.gbBuscar.Controls.Add(this.lblPacienteNuevaReserva);
            this.gbBuscar.Location = new System.Drawing.Point(25, 79);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(1114, 74);
            this.gbBuscar.TabIndex = 37;
            this.gbBuscar.TabStop = false;
            // 
            // btnCargarPresupuesto
            // 
            this.btnCargarPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCargarPresupuesto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargarPresupuesto.BordeRadio = 32;
            this.btnCargarPresupuesto.BordeTamaño = 0;
            this.btnCargarPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnCargarPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnCargarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPresupuesto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCargarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnCargarPresupuesto.Location = new System.Drawing.Point(973, 20);
            this.btnCargarPresupuesto.Name = "btnCargarPresupuesto";
            this.btnCargarPresupuesto.Size = new System.Drawing.Size(87, 34);
            this.btnCargarPresupuesto.TabIndex = 49;
            this.btnCargarPresupuesto.Text = "Cargar";
            this.btnCargarPresupuesto.TextoColor = System.Drawing.Color.White;
            this.btnCargarPresupuesto.UseVisualStyleBackColor = false;
            this.btnCargarPresupuesto.Click += new System.EventHandler(this.btnCargarPresupuesto_Click);
            // 
            // btnCargarPaciente
            // 
            this.btnCargarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCargarPaciente.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargarPaciente.BordeRadio = 32;
            this.btnCargarPaciente.BordeTamaño = 0;
            this.btnCargarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPaciente.FlatAppearance.BorderSize = 0;
            this.btnCargarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnCargarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPaciente.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCargarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnCargarPaciente.Location = new System.Drawing.Point(415, 17);
            this.btnCargarPaciente.Name = "btnCargarPaciente";
            this.btnCargarPaciente.Size = new System.Drawing.Size(87, 34);
            this.btnCargarPaciente.TabIndex = 48;
            this.btnCargarPaciente.Text = "Cargar";
            this.btnCargarPaciente.TextoColor = System.Drawing.Color.White;
            this.btnCargarPaciente.UseVisualStyleBackColor = false;
            this.btnCargarPaciente.Click += new System.EventHandler(this.btnCargarPaciente_Click);
            // 
            // lblErrorPresupuesto
            // 
            this.lblErrorPresupuesto.AutoSize = true;
            this.lblErrorPresupuesto.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPresupuesto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPresupuesto.Image")));
            this.lblErrorPresupuesto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPresupuesto.Location = new System.Drawing.Point(713, 54);
            this.lblErrorPresupuesto.Name = "lblErrorPresupuesto";
            this.lblErrorPresupuesto.Size = new System.Drawing.Size(85, 15);
            this.lblErrorPresupuesto.TabIndex = 47;
            this.lblErrorPresupuesto.Text = "Mensaje Error";
            this.lblErrorPresupuesto.Visible = false;
            // 
            // lblErrorPaciente
            // 
            this.lblErrorPaciente.AutoSize = true;
            this.lblErrorPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPaciente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPaciente.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPaciente.Image")));
            this.lblErrorPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPaciente.Location = new System.Drawing.Point(155, 54);
            this.lblErrorPaciente.Name = "lblErrorPaciente";
            this.lblErrorPaciente.Size = new System.Drawing.Size(85, 15);
            this.lblErrorPaciente.TabIndex = 46;
            this.lblErrorPaciente.Text = "Mensaje Error";
            this.lblErrorPaciente.Visible = false;
            // 
            // btnBuscarPresupuesto
            // 
            this.btnBuscarPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPresupuesto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarPresupuesto.BordeRadio = 32;
            this.btnBuscarPresupuesto.BordeTamaño = 0;
            this.btnBuscarPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnBuscarPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnBuscarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPresupuesto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPresupuesto.Location = new System.Drawing.Point(973, 20);
            this.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            this.btnBuscarPresupuesto.Size = new System.Drawing.Size(87, 34);
            this.btnBuscarPresupuesto.TabIndex = 43;
            this.btnBuscarPresupuesto.Text = "Buscar";
            this.btnBuscarPresupuesto.TextoColor = System.Drawing.Color.White;
            this.btnBuscarPresupuesto.UseVisualStyleBackColor = false;
            this.btnBuscarPresupuesto.Click += new System.EventHandler(this.btnBuscarPresupuesto_Click);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPaciente.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarPaciente.BordeRadio = 32;
            this.btnBuscarPaciente.BordeTamaño = 0;
            this.btnBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(415, 17);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(87, 34);
            this.btnBuscarPaciente.TabIndex = 41;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.TextoColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.BackColor = System.Drawing.SystemColors.Window;
            this.txtPresupuesto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPresupuesto.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPresupuesto.BordeRadio = 0;
            this.txtPresupuesto.BordeTamaño = 2;
            this.txtPresupuesto.Contraseña = false;
            this.txtPresupuesto.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.txtPresupuesto.Location = new System.Drawing.Point(716, 21);
            this.txtPresupuesto.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPresupuesto.MarcadorPosicionTexto = "";
            this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPresupuesto.Multilinea = false;
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPresupuesto.Size = new System.Drawing.Size(250, 30);
            this.txtPresupuesto.SubrayadoEstilo = true;
            this.txtPresupuesto.TabIndex = 42;
            this.txtPresupuesto.Texto = "";
            this.txtPresupuesto._TextChanged += new System.EventHandler(this.txtPresupuesto__TextChanged);
            this.txtPresupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresupuesto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(579, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Presupuesto";
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPaciente.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPaciente.BordeRadio = 0;
            this.txtPaciente.BordeTamaño = 2;
            this.txtPaciente.Contraseña = false;
            this.txtPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtPaciente.Location = new System.Drawing.Point(158, 21);
            this.txtPaciente.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPaciente.MarcadorPosicionTexto = "";
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPaciente.Multilinea = false;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPaciente.Size = new System.Drawing.Size(250, 30);
            this.txtPaciente.SubrayadoEstilo = true;
            this.txtPaciente.TabIndex = 40;
            this.txtPaciente.Texto = "";
            this.txtPaciente._TextChanged += new System.EventHandler(this.txtPaciente__TextChanged);
            this.txtPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaciente_KeyPress);
            // 
            // lblPacienteNuevaReserva
            // 
            this.lblPacienteNuevaReserva.AutoSize = true;
            this.lblPacienteNuevaReserva.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblPacienteNuevaReserva.ForeColor = System.Drawing.Color.Black;
            this.lblPacienteNuevaReserva.Location = new System.Drawing.Point(54, 25);
            this.lblPacienteNuevaReserva.Name = "lblPacienteNuevaReserva";
            this.lblPacienteNuevaReserva.Size = new System.Drawing.Size(83, 23);
            this.lblPacienteNuevaReserva.TabIndex = 44;
            this.lblPacienteNuevaReserva.Text = "Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnOtros);
            this.groupBox1.Controls.Add(this.btnImplante);
            this.groupBox1.Controls.Add(this.btnCuretaje);
            this.groupBox1.Controls.Add(this.btnOrtodoncia);
            this.groupBox1.Controls.Add(this.btnExodoncia);
            this.groupBox1.Controls.Add(this.btnEndodoncia);
            this.groupBox1.Controls.Add(this.btnObturacion);
            this.groupBox1.Controls.Add(this.btnLimpieza);
            this.groupBox1.Location = new System.Drawing.Point(25, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 511);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tratamientos";
            // 
            // btnOtros
            // 
            this.btnOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnOtros.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnOtros.BordeRadio = 32;
            this.btnOtros.BordeTamaño = 0;
            this.btnOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnOtros.ForeColor = System.Drawing.Color.White;
            this.btnOtros.Location = new System.Drawing.Point(277, 353);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(115, 106);
            this.btnOtros.TabIndex = 58;
            this.btnOtros.Text = "Otros";
            this.btnOtros.TextoColor = System.Drawing.Color.White;
            this.btnOtros.UseVisualStyleBackColor = false;
            this.btnOtros.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnImplante
            // 
            this.btnImplante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnImplante.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnImplante.BordeRadio = 32;
            this.btnImplante.BordeTamaño = 0;
            this.btnImplante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImplante.FlatAppearance.BorderSize = 0;
            this.btnImplante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnImplante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImplante.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnImplante.ForeColor = System.Drawing.Color.White;
            this.btnImplante.Location = new System.Drawing.Point(109, 353);
            this.btnImplante.Name = "btnImplante";
            this.btnImplante.Size = new System.Drawing.Size(115, 106);
            this.btnImplante.TabIndex = 57;
            this.btnImplante.Tag = "8";
            this.btnImplante.Text = "Implante retenedor";
            this.btnImplante.TextoColor = System.Drawing.Color.White;
            this.btnImplante.UseVisualStyleBackColor = false;
            this.btnImplante.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnCuretaje
            // 
            this.btnCuretaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCuretaje.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCuretaje.BordeRadio = 32;
            this.btnCuretaje.BordeTamaño = 0;
            this.btnCuretaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuretaje.FlatAppearance.BorderSize = 0;
            this.btnCuretaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnCuretaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuretaje.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCuretaje.ForeColor = System.Drawing.Color.White;
            this.btnCuretaje.Location = new System.Drawing.Point(350, 206);
            this.btnCuretaje.Name = "btnCuretaje";
            this.btnCuretaje.Size = new System.Drawing.Size(115, 106);
            this.btnCuretaje.TabIndex = 56;
            this.btnCuretaje.Tag = "7";
            this.btnCuretaje.Text = "Curetaje";
            this.btnCuretaje.TextoColor = System.Drawing.Color.White;
            this.btnCuretaje.UseVisualStyleBackColor = false;
            this.btnCuretaje.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnOrtodoncia
            // 
            this.btnOrtodoncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnOrtodoncia.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrtodoncia.BordeRadio = 32;
            this.btnOrtodoncia.BordeTamaño = 0;
            this.btnOrtodoncia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrtodoncia.FlatAppearance.BorderSize = 0;
            this.btnOrtodoncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnOrtodoncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrtodoncia.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnOrtodoncia.ForeColor = System.Drawing.Color.White;
            this.btnOrtodoncia.Location = new System.Drawing.Point(184, 206);
            this.btnOrtodoncia.Name = "btnOrtodoncia";
            this.btnOrtodoncia.Size = new System.Drawing.Size(115, 106);
            this.btnOrtodoncia.TabIndex = 55;
            this.btnOrtodoncia.Tag = "6";
            this.btnOrtodoncia.Text = "Ortodoncia";
            this.btnOrtodoncia.TextoColor = System.Drawing.Color.White;
            this.btnOrtodoncia.UseVisualStyleBackColor = false;
            this.btnOrtodoncia.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnExodoncia
            // 
            this.btnExodoncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnExodoncia.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnExodoncia.BordeRadio = 32;
            this.btnExodoncia.BordeTamaño = 0;
            this.btnExodoncia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExodoncia.FlatAppearance.BorderSize = 0;
            this.btnExodoncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnExodoncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExodoncia.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnExodoncia.ForeColor = System.Drawing.Color.White;
            this.btnExodoncia.Location = new System.Drawing.Point(22, 206);
            this.btnExodoncia.Name = "btnExodoncia";
            this.btnExodoncia.Size = new System.Drawing.Size(115, 106);
            this.btnExodoncia.TabIndex = 54;
            this.btnExodoncia.Tag = "5";
            this.btnExodoncia.Text = "Exodoncia";
            this.btnExodoncia.TextoColor = System.Drawing.Color.White;
            this.btnExodoncia.UseVisualStyleBackColor = false;
            this.btnExodoncia.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnEndodoncia
            // 
            this.btnEndodoncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEndodoncia.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEndodoncia.BordeRadio = 32;
            this.btnEndodoncia.BordeTamaño = 0;
            this.btnEndodoncia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndodoncia.FlatAppearance.BorderSize = 0;
            this.btnEndodoncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEndodoncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndodoncia.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEndodoncia.ForeColor = System.Drawing.Color.White;
            this.btnEndodoncia.Location = new System.Drawing.Point(350, 52);
            this.btnEndodoncia.Name = "btnEndodoncia";
            this.btnEndodoncia.Size = new System.Drawing.Size(115, 106);
            this.btnEndodoncia.TabIndex = 53;
            this.btnEndodoncia.Tag = "4";
            this.btnEndodoncia.Text = "Endodoncia";
            this.btnEndodoncia.TextoColor = System.Drawing.Color.White;
            this.btnEndodoncia.UseVisualStyleBackColor = false;
            this.btnEndodoncia.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnObturacion
            // 
            this.btnObturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnObturacion.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnObturacion.BordeRadio = 32;
            this.btnObturacion.BordeTamaño = 0;
            this.btnObturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObturacion.FlatAppearance.BorderSize = 0;
            this.btnObturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnObturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObturacion.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnObturacion.ForeColor = System.Drawing.Color.White;
            this.btnObturacion.Location = new System.Drawing.Point(184, 52);
            this.btnObturacion.Name = "btnObturacion";
            this.btnObturacion.Size = new System.Drawing.Size(115, 106);
            this.btnObturacion.TabIndex = 52;
            this.btnObturacion.Tag = "3";
            this.btnObturacion.Text = "Obturacion";
            this.btnObturacion.TextoColor = System.Drawing.Color.White;
            this.btnObturacion.UseVisualStyleBackColor = false;
            this.btnObturacion.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // btnLimpieza
            // 
            this.btnLimpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpieza.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpieza.BordeRadio = 32;
            this.btnLimpieza.BordeTamaño = 0;
            this.btnLimpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpieza.FlatAppearance.BorderSize = 0;
            this.btnLimpieza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimpieza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpieza.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpieza.ForeColor = System.Drawing.Color.White;
            this.btnLimpieza.Location = new System.Drawing.Point(22, 52);
            this.btnLimpieza.Name = "btnLimpieza";
            this.btnLimpieza.Size = new System.Drawing.Size(115, 106);
            this.btnLimpieza.TabIndex = 51;
            this.btnLimpieza.Tag = "2";
            this.btnLimpieza.Text = "Limpieza";
            this.btnLimpieza.TextoColor = System.Drawing.Color.White;
            this.btnLimpieza.UseVisualStyleBackColor = false;
            this.btnLimpieza.Click += new System.EventHandler(this.BotonesTratamientos);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblErrorEntrega);
            this.groupBox2.Controls.Add(this.btnCobrar);
            this.groupBox2.Controls.Add(this.lblImporteCambio);
            this.groupBox2.Controls.Add(this.lblCambio);
            this.groupBox2.Controls.Add(this.txtEntrega);
            this.groupBox2.Controls.Add(this.lblEntrega);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbMetodosPago);
            this.groupBox2.Controls.Add(this.lblImporteTotal);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.dgvCobro);
            this.groupBox2.Location = new System.Drawing.Point(543, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 511);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // lblErrorEntrega
            // 
            this.lblErrorEntrega.AutoSize = true;
            this.lblErrorEntrega.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEntrega.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorEntrega.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorEntrega.Image")));
            this.lblErrorEntrega.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorEntrega.Location = new System.Drawing.Point(161, 424);
            this.lblErrorEntrega.Name = "lblErrorEntrega";
            this.lblErrorEntrega.Size = new System.Drawing.Size(85, 15);
            this.lblErrorEntrega.TabIndex = 78;
            this.lblErrorEntrega.Text = "Mensaje Error";
            this.lblErrorEntrega.Visible = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCobrar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnCobrar.BordeRadio = 32;
            this.btnCobrar.BordeTamaño = 0;
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnCobrar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(206, 456);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(197, 44);
            this.btnCobrar.TabIndex = 77;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextoColor = System.Drawing.Color.White;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblImporteCambio
            // 
            this.lblImporteCambio.AutoSize = true;
            this.lblImporteCambio.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblImporteCambio.Location = new System.Drawing.Point(399, 393);
            this.lblImporteCambio.Name = "lblImporteCambio";
            this.lblImporteCambio.Size = new System.Drawing.Size(76, 23);
            this.lblImporteCambio.TabIndex = 73;
            this.lblImporteCambio.Text = "Importe";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblCambio.Location = new System.Drawing.Point(322, 393);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(81, 23);
            this.lblCambio.TabIndex = 72;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtEntrega
            // 
            this.txtEntrega.BackColor = System.Drawing.SystemColors.Window;
            this.txtEntrega.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtEntrega.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtEntrega.BordeRadio = 0;
            this.txtEntrega.BordeTamaño = 2;
            this.txtEntrega.Contraseña = false;
            this.txtEntrega.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrega.ForeColor = System.Drawing.Color.Black;
            this.txtEntrega.Location = new System.Drawing.Point(161, 391);
            this.txtEntrega.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtEntrega.MarcadorPosicionTexto = "";
            this.txtEntrega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEntrega.Multilinea = false;
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEntrega.Size = new System.Drawing.Size(110, 30);
            this.txtEntrega.SubrayadoEstilo = true;
            this.txtEntrega.TabIndex = 76;
            this.txtEntrega.Texto = "";
            this.txtEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrega_KeyPress);
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblEntrega.Location = new System.Drawing.Point(77, 393);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(79, 23);
            this.lblEntrega.TabIndex = 71;
            this.lblEntrega.Text = "Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F);
            this.label1.Location = new System.Drawing.Point(3, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Método de pago:";
            // 
            // cbMetodosPago
            // 
            this.cbMetodosPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMetodosPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbMetodosPago.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbMetodosPago.BordeTamaño = 1;
            this.cbMetodosPago.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbMetodosPago.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbMetodosPago.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbMetodosPago.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMetodosPago.ForeColor = System.Drawing.Color.Black;
            this.cbMetodosPago.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbMetodosPago.ListColorTexto = System.Drawing.Color.Black;
            this.cbMetodosPago.Location = new System.Drawing.Point(164, 335);
            this.cbMetodosPago.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMetodosPago.Name = "cbMetodosPago";
            this.cbMetodosPago.Padding = new System.Windows.Forms.Padding(1);
            this.cbMetodosPago.Size = new System.Drawing.Size(200, 30);
            this.cbMetodosPago.TabIndex = 75;
            this.cbMetodosPago.Textos = "";
            this.cbMetodosPago.OnSelectedIndexChanged += new System.EventHandler(this.cbMetodosPago_OnSelectedIndexChanged);
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblImporteTotal.Location = new System.Drawing.Point(463, 337);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(76, 23);
            this.lblImporteTotal.TabIndex = 68;
            this.lblImporteTotal.Text = "Importe";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTotal.Location = new System.Drawing.Point(409, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 23);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "Total:";
            // 
            // dgvCobro
            // 
            this.dgvCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tratamiento,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.dgvCobro.Location = new System.Drawing.Point(3, 11);
            this.dgvCobro.Name = "dgvCobro";
            this.dgvCobro.Size = new System.Drawing.Size(590, 309);
            this.dgvCobro.TabIndex = 66;
            // 
            // Tratamiento
            // 
            this.Tratamiento.Frozen = true;
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            this.Tratamiento.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.Frozen = true;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(25, 23);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TabStop = false;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblNombrePaciente);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.GroupBox gbBuscar;
        private ControlesPersonalizados.BotonPersonalizado btnCargarPresupuesto;
        private ControlesPersonalizados.BotonPersonalizado btnCargarPaciente;
        private System.Windows.Forms.Label lblErrorPresupuesto;
        private System.Windows.Forms.Label lblErrorPaciente;
        private ControlesPersonalizados.BotonPersonalizado btnBuscarPresupuesto;
        private ControlesPersonalizados.BotonPersonalizado btnBuscarPaciente;
        private TextboxPersonalizado txtPresupuesto;
        private System.Windows.Forms.Label label4;
        private TextboxPersonalizado txtPaciente;
        private System.Windows.Forms.Label lblPacienteNuevaReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private ControlesPersonalizados.BotonPersonalizado btnOtros;
        private ControlesPersonalizados.BotonPersonalizado btnImplante;
        private ControlesPersonalizados.BotonPersonalizado btnCuretaje;
        private ControlesPersonalizados.BotonPersonalizado btnOrtodoncia;
        private ControlesPersonalizados.BotonPersonalizado btnExodoncia;
        private ControlesPersonalizados.BotonPersonalizado btnEndodoncia;
        private ControlesPersonalizados.BotonPersonalizado btnObturacion;
        private ControlesPersonalizados.BotonPersonalizado btnLimpieza;
        private System.Windows.Forms.GroupBox groupBox2;
        private ControlesPersonalizados.BotonPersonalizado btnCobrar;
        private System.Windows.Forms.Label lblImporteCambio;
        private System.Windows.Forms.Label lblCambio;
        private TextboxPersonalizado txtEntrega;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.ComboBoxPersonalizado cbMetodosPago;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label lblErrorEntrega;
    }
}