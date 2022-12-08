namespace DentalSoft.Formularios
{
    partial class RecordarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordarCita));
            this.mcFechaEnvio = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.lblSeleccionarAgenda = new System.Windows.Forms.Label();
            this.btnRecordar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblEnviado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // mcFechaEnvio
            // 
            this.mcFechaEnvio.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.mcFechaEnvio.BordeTamaño = 0;
            this.mcFechaEnvio.CalendarFont = new System.Drawing.Font("Roboto", 12F);
            this.mcFechaEnvio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.mcFechaEnvio.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFechaEnvio.Font = new System.Drawing.Font("Roboto", 11F);
            this.mcFechaEnvio.IsDesplegado = false;
            this.mcFechaEnvio.Location = new System.Drawing.Point(16, 88);
            this.mcFechaEnvio.MinDate = new System.DateTime(2022, 10, 9, 17, 51, 48, 129);
            this.mcFechaEnvio.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFechaEnvio.Name = "mcFechaEnvio";
            this.mcFechaEnvio.Size = new System.Drawing.Size(270, 35);
            this.mcFechaEnvio.TabIndex = 11;
            this.mcFechaEnvio.TextoColor = System.Drawing.Color.White;
            this.mcFechaEnvio.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            // 
            // lblSeleccionarAgenda
            // 
            this.lblSeleccionarAgenda.AutoSize = true;
            this.lblSeleccionarAgenda.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblSeleccionarAgenda.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionarAgenda.Location = new System.Drawing.Point(66, 56);
            this.lblSeleccionarAgenda.Name = "lblSeleccionarAgenda";
            this.lblSeleccionarAgenda.Size = new System.Drawing.Size(160, 19);
            this.lblSeleccionarAgenda.TabIndex = 12;
            this.lblSeleccionarAgenda.Text = "Seleccione una fecha";
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
            this.btnRecordar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnRecordar.ForeColor = System.Drawing.Color.White;
            this.btnRecordar.Location = new System.Drawing.Point(16, 250);
            this.btnRecordar.Name = "btnRecordar";
            this.btnRecordar.Size = new System.Drawing.Size(270, 34);
            this.btnRecordar.TabIndex = 17;
            this.btnRecordar.Text = "Enviar email recordatorio";
            this.btnRecordar.TextoColor = System.Drawing.Color.White;
            this.btnRecordar.UseVisualStyleBackColor = false;
            this.btnRecordar.Click += new System.EventHandler(this.btnRecordar_Click);
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(312, 35);
            this.pnlCabecera.TabIndex = 18;
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
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(275, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblEnviado
            // 
            this.lblEnviado.AutoSize = true;
            this.lblEnviado.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviado.Location = new System.Drawing.Point(32, 294);
            this.lblEnviado.Name = "lblEnviado";
            this.lblEnviado.Size = new System.Drawing.Size(230, 19);
            this.lblEnviado.TabIndex = 19;
            this.lblEnviado.Text = "Emails enviados correctamente";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RecordarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(312, 322);
            this.Controls.Add(this.lblEnviado);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.btnRecordar);
            this.Controls.Add(this.mcFechaEnvio);
            this.Controls.Add(this.lblSeleccionarAgenda);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RecordarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordarCita";
            this.Load += new System.EventHandler(this.RecordarCita_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.SelectorFecha mcFechaEnvio;
        private System.Windows.Forms.Label lblSeleccionarAgenda;
        private ControlesPersonalizados.BotonPersonalizado btnRecordar;
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblEnviado;
        private System.Windows.Forms.Timer timer1;
    }
}