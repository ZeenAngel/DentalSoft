namespace DentalSoft.Formularios
{
    partial class ControlHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlHorario));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.lblTituloBuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorIncidencias = new System.Windows.Forms.Label();
            this.btnIncidencias = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnLimpiarFecha = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.selectorFecha1 = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.txtBuscar = new DentalSoft.TextboxPersonalizado();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
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
            this.pnlCabecera.Size = new System.Drawing.Size(1090, 35);
            this.pnlCabecera.TabIndex = 3;
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
            this.btnRedimensionar.Location = new System.Drawing.Point(1010, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(969, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(1053, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Controls.Add(this.dgvFichajes);
            this.pnlContenedor.Location = new System.Drawing.Point(16, 160);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1062, 437);
            this.pnlContenedor.TabIndex = 4;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Location = new System.Drawing.Point(0, 0);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.Size = new System.Drawing.Size(1062, 437);
            this.dgvFichajes.TabIndex = 0;
            this.dgvFichajes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFichajes_CellContentDoubleClick);
            this.dgvFichajes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFichajes_CellFormatting);
            // 
            // lblTituloBuscar
            // 
            this.lblTituloBuscar.AutoSize = true;
            this.lblTituloBuscar.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblTituloBuscar.Location = new System.Drawing.Point(24, 100);
            this.lblTituloBuscar.Name = "lblTituloBuscar";
            this.lblTituloBuscar.Size = new System.Drawing.Size(76, 24);
            this.lblTituloBuscar.TabIndex = 7;
            this.lblTituloBuscar.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.Location = new System.Drawing.Point(480, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrar por fecha:";
            // 
            // lblErrorIncidencias
            // 
            this.lblErrorIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorIncidencias.AutoSize = true;
            this.lblErrorIncidencias.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblErrorIncidencias.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorIncidencias.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorIncidencias.Image")));
            this.lblErrorIncidencias.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorIncidencias.Location = new System.Drawing.Point(325, 138);
            this.lblErrorIncidencias.Name = "lblErrorIncidencias";
            this.lblErrorIncidencias.Size = new System.Drawing.Size(134, 24);
            this.lblErrorIncidencias.TabIndex = 49;
            this.lblErrorIncidencias.Text = "Mensaje Error";
            this.lblErrorIncidencias.Visible = false;
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIncidencias.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIncidencias.BordeRadio = 31;
            this.btnIncidencias.BordeTamaño = 0;
            this.btnIncidencias.FlatAppearance.BorderSize = 0;
            this.btnIncidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIncidencias.ForeColor = System.Drawing.Color.White;
            this.btnIncidencias.Location = new System.Drawing.Point(941, 110);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(116, 31);
            this.btnIncidencias.TabIndex = 11;
            this.btnIncidencias.Text = "Ver incidencias";
            this.btnIncidencias.TextoColor = System.Drawing.Color.White;
            this.btnIncidencias.UseVisualStyleBackColor = false;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnLimpiarFecha
            // 
            this.btnLimpiarFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarFecha.BordeRadio = 31;
            this.btnLimpiarFecha.BordeTamaño = 0;
            this.btnLimpiarFecha.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnLimpiarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnLimpiarFecha.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFecha.Location = new System.Drawing.Point(941, 61);
            this.btnLimpiarFecha.Name = "btnLimpiarFecha";
            this.btnLimpiarFecha.Size = new System.Drawing.Size(116, 31);
            this.btnLimpiarFecha.TabIndex = 10;
            this.btnLimpiarFecha.Text = "Todas las fechas";
            this.btnLimpiarFecha.TextoColor = System.Drawing.Color.White;
            this.btnLimpiarFecha.UseVisualStyleBackColor = false;
            this.btnLimpiarFecha.Click += new System.EventHandler(this.btnLimpiarFecha_Click);
            // 
            // selectorFecha1
            // 
            this.selectorFecha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectorFecha1.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.selectorFecha1.BordeTamaño = 0;
            this.selectorFecha1.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.selectorFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.selectorFecha1.IsDesplegado = false;
            this.selectorFecha1.Location = new System.Drawing.Point(634, 91);
            this.selectorFecha1.MinDate = new System.DateTime(2022, 11, 7, 20, 1, 22, 400);
            this.selectorFecha1.MinimumSize = new System.Drawing.Size(4, 35);
            this.selectorFecha1.Name = "selectorFecha1";
            this.selectorFecha1.Size = new System.Drawing.Size(271, 35);
            this.selectorFecha1.TabIndex = 5;
            this.selectorFecha1.TextoColor = System.Drawing.Color.White;
            this.selectorFecha1.Value = new System.DateTime(2022, 12, 8, 12, 44, 53, 478);
            this.selectorFecha1.CloseUp += new System.EventHandler(this.selectorFecha1_CloseUp);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtBuscar.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtBuscar.BordeRadio = 0;
            this.txtBuscar.BordeTamaño = 2;
            this.txtBuscar.Contraseña = false;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(93, 95);
            this.txtBuscar.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.MarcadorPosicionTexto = "Introduce el Dni del empleado a buscar";
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Multilinea = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscar.PosicionSeleccion = 0;
            this.txtBuscar.Size = new System.Drawing.Size(338, 34);
            this.txtBuscar.SubrayadoEstilo = true;
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TamañoMaximo = 30000;
            this.txtBuscar.Texto = "";
            this.txtBuscar._TextChanged += new System.EventHandler(this.txtBuscar__TextChanged);
            // 
            // ControlHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 609);
            this.Controls.Add(this.lblErrorIncidencias);
            this.Controls.Add(this.btnIncidencias);
            this.Controls.Add(this.btnLimpiarFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectorFecha1);
            this.Controls.Add(this.lblTituloBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ControlHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlHorario";
            this.Load += new System.EventHandler(this.ControlHorario_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private TextboxPersonalizado txtBuscar;
        private System.Windows.Forms.Label lblTituloBuscar;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private ControlesPersonalizados.SelectorFecha selectorFecha1;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiarFecha;
        private ControlesPersonalizados.BotonPersonalizado btnIncidencias;
        private System.Windows.Forms.Label lblErrorIncidencias;
    }
}