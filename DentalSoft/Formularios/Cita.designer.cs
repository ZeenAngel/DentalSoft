namespace DentalSoft
{
    partial class Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cita));
            this.lblSeleccionarAgenda = new System.Windows.Forms.Label();
            this.gbFechaReserva = new System.Windows.Forms.GroupBox();
            this.btnRecordar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEliminarAgenda = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEditarAgenda = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevaAgenda = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.selectorFecha1 = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblErrorModificarCita = new System.Windows.Forms.Label();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.gbDatosReserva = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFechaReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.pnlDgv.SuspendLayout();
            this.gbDatosReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionarAgenda
            // 
            this.lblSeleccionarAgenda.AutoSize = true;
            this.lblSeleccionarAgenda.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblSeleccionarAgenda.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionarAgenda.Location = new System.Drawing.Point(119, 169);
            this.lblSeleccionarAgenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionarAgenda.Name = "lblSeleccionarAgenda";
            this.lblSeleccionarAgenda.Size = new System.Drawing.Size(200, 24);
            this.lblSeleccionarAgenda.TabIndex = 10;
            this.lblSeleccionarAgenda.Text = "Seleccione una fecha";
            // 
            // gbFechaReserva
            // 
            this.gbFechaReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFechaReserva.Controls.Add(this.btnRecordar);
            this.gbFechaReserva.Controls.Add(this.btnEliminarAgenda);
            this.gbFechaReserva.Controls.Add(this.btnEditarAgenda);
            this.gbFechaReserva.Controls.Add(this.btnNuevaAgenda);
            this.gbFechaReserva.Controls.Add(this.selectorFecha1);
            this.gbFechaReserva.Controls.Add(this.lblSeleccionarAgenda);
            this.gbFechaReserva.Font = new System.Drawing.Font("Roboto", 14F);
            this.gbFechaReserva.ForeColor = System.Drawing.Color.Black;
            this.gbFechaReserva.Location = new System.Drawing.Point(33, 119);
            this.gbFechaReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFechaReserva.Name = "gbFechaReserva";
            this.gbFechaReserva.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFechaReserva.Size = new System.Drawing.Size(477, 746);
            this.gbFechaReserva.TabIndex = 38;
            this.gbFechaReserva.TabStop = false;
            this.gbFechaReserva.Text = "Fecha Reserva";
            // 
            // btnRecordar
            // 
            this.btnRecordar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnRecordar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnRecordar.BordeRadio = 32;
            this.btnRecordar.BordeTamaño = 0;
            this.btnRecordar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordar.FlatAppearance.BorderSize = 0;
            this.btnRecordar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnRecordar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnRecordar.ForeColor = System.Drawing.Color.White;
            this.btnRecordar.Location = new System.Drawing.Point(52, 686);
            this.btnRecordar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecordar.Name = "btnRecordar";
            this.btnRecordar.Size = new System.Drawing.Size(360, 42);
            this.btnRecordar.TabIndex = 16;
            this.btnRecordar.Text = "Recordar cita";
            this.btnRecordar.TextoColor = System.Drawing.Color.White;
            this.btnRecordar.UseVisualStyleBackColor = false;
            this.btnRecordar.Click += new System.EventHandler(this.btnRecordar_Click);
            // 
            // btnEliminarAgenda
            // 
            this.btnEliminarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarAgenda.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarAgenda.BordeRadio = 32;
            this.btnEliminarAgenda.BordeTamaño = 0;
            this.btnEliminarAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAgenda.FlatAppearance.BorderSize = 0;
            this.btnEliminarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEliminarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAgenda.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarAgenda.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAgenda.Location = new System.Drawing.Point(260, 610);
            this.btnEliminarAgenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarAgenda.Name = "btnEliminarAgenda";
            this.btnEliminarAgenda.Size = new System.Drawing.Size(152, 42);
            this.btnEliminarAgenda.TabIndex = 15;
            this.btnEliminarAgenda.Text = "Eliminar";
            this.btnEliminarAgenda.TextoColor = System.Drawing.Color.White;
            this.btnEliminarAgenda.UseVisualStyleBackColor = false;
            this.btnEliminarAgenda.Click += new System.EventHandler(this.btnEliminarAgenda_Click);
            // 
            // btnEditarAgenda
            // 
            this.btnEditarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarAgenda.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarAgenda.BordeRadio = 32;
            this.btnEditarAgenda.BordeTamaño = 0;
            this.btnEditarAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAgenda.FlatAppearance.BorderSize = 0;
            this.btnEditarAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEditarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAgenda.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarAgenda.ForeColor = System.Drawing.Color.White;
            this.btnEditarAgenda.Location = new System.Drawing.Point(52, 610);
            this.btnEditarAgenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarAgenda.Name = "btnEditarAgenda";
            this.btnEditarAgenda.Size = new System.Drawing.Size(152, 42);
            this.btnEditarAgenda.TabIndex = 10;
            this.btnEditarAgenda.Text = "Editar";
            this.btnEditarAgenda.TextoColor = System.Drawing.Color.White;
            this.btnEditarAgenda.UseVisualStyleBackColor = false;
            this.btnEditarAgenda.Click += new System.EventHandler(this.btnEditarAgenda_Click);
            // 
            // btnNuevaAgenda
            // 
            this.btnNuevaAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevaAgenda.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevaAgenda.BordeRadio = 32;
            this.btnNuevaAgenda.BordeTamaño = 0;
            this.btnNuevaAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaAgenda.FlatAppearance.BorderSize = 0;
            this.btnNuevaAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevaAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaAgenda.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevaAgenda.ForeColor = System.Drawing.Color.White;
            this.btnNuevaAgenda.Location = new System.Drawing.Point(52, 523);
            this.btnNuevaAgenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaAgenda.Name = "btnNuevaAgenda";
            this.btnNuevaAgenda.Size = new System.Drawing.Size(360, 42);
            this.btnNuevaAgenda.TabIndex = 5;
            this.btnNuevaAgenda.Text = "Nueva";
            this.btnNuevaAgenda.TextoColor = System.Drawing.Color.White;
            this.btnNuevaAgenda.UseVisualStyleBackColor = false;
            this.btnNuevaAgenda.Click += new System.EventHandler(this.btnNuevaAgenda_Click);
            // 
            // selectorFecha1
            // 
            this.selectorFecha1.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.selectorFecha1.BordeTamaño = 0;
            this.selectorFecha1.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.selectorFecha1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.selectorFecha1.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.selectorFecha1.Font = new System.Drawing.Font("Roboto", 11F);
            this.selectorFecha1.IsDesplegado = false;
            this.selectorFecha1.Location = new System.Drawing.Point(52, 208);
            this.selectorFecha1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectorFecha1.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.selectorFecha1.MinimumSize = new System.Drawing.Size(4, 35);
            this.selectorFecha1.Name = "selectorFecha1";
            this.selectorFecha1.Size = new System.Drawing.Size(359, 35);
            this.selectorFecha1.TabIndex = 0;
            this.selectorFecha1.TextoColor = System.Drawing.Color.White;
            this.selectorFecha1.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            this.selectorFecha1.CloseUp += new System.EventHandler(this.selectorFecha1_CloseUp);
            // 
            // dgvReservas
            // 
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(0, 0);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(991, 703);
            this.dgvReservas.TabIndex = 17;
            this.dgvReservas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentDoubleClick);
            // 
            // lblErrorModificarCita
            // 
            this.lblErrorModificarCita.AutoSize = true;
            this.lblErrorModificarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblErrorModificarCita.ForeColor = System.Drawing.Color.White;
            this.lblErrorModificarCita.Location = new System.Drawing.Point(53, 353);
            this.lblErrorModificarCita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorModificarCita.Name = "lblErrorModificarCita";
            this.lblErrorModificarCita.Size = new System.Drawing.Size(0, 25);
            this.lblErrorModificarCita.TabIndex = 34;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvReservas);
            this.pnlDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgv.Location = new System.Drawing.Point(4, 33);
            this.pnlDgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(991, 709);
            this.pnlDgv.TabIndex = 35;
            // 
            // gbDatosReserva
            // 
            this.gbDatosReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDatosReserva.Controls.Add(this.pnlDgv);
            this.gbDatosReserva.Controls.Add(this.lblErrorModificarCita);
            this.gbDatosReserva.Font = new System.Drawing.Font("Roboto", 14F);
            this.gbDatosReserva.ForeColor = System.Drawing.Color.Black;
            this.gbDatosReserva.Location = new System.Drawing.Point(519, 119);
            this.gbDatosReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosReserva.Name = "gbDatosReserva";
            this.gbDatosReserva.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosReserva.Size = new System.Drawing.Size(999, 746);
            this.gbDatosReserva.TabIndex = 39;
            this.gbDatosReserva.TabStop = false;
            this.gbDatosReserva.Text = "Datos Reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1552, 880);
            this.Controls.Add(this.gbDatosReserva);
            this.Controls.Add(this.gbFechaReserva);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cita";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.gbFechaReserva.ResumeLayout(false);
            this.gbFechaReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.pnlDgv.ResumeLayout(false);
            this.gbDatosReserva.ResumeLayout(false);
            this.gbDatosReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSeleccionarAgenda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControlesPersonalizados.SelectorFecha selectorFecha1;
        private System.Windows.Forms.GroupBox gbFechaReserva;
        private ControlesPersonalizados.BotonPersonalizado btnEditarAgenda;
        private ControlesPersonalizados.BotonPersonalizado btnNuevaAgenda;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblErrorModificarCita;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.GroupBox gbDatosReserva;
        private ControlesPersonalizados.BotonPersonalizado btnEliminarAgenda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ControlesPersonalizados.BotonPersonalizado btnRecordar;
    }
}