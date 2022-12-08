﻿namespace DentalSoft
{
    partial class EditarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarReserva));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblTituloPacienteEditarReserva = new System.Windows.Forms.Label();
            this.lblPacienteEditarReserva = new System.Windows.Forms.Label();
            this.lblApellidosEditarReserva = new System.Windows.Forms.Label();
            this.btnGuardarNuevaReserva = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.cbHorasEditarReserva = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.mcFechaEditarReserva = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.lblApellidosOdontologoEditarReserva = new System.Windows.Forms.Label();
            this.lblNombreOdontologoEditarReserva = new System.Windows.Forms.Label();
            this.lblTituloOdontologoEditarReserva = new System.Windows.Forms.Label();
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
            this.pnlCabecera.Size = new System.Drawing.Size(816, 35);
            this.pnlCabecera.TabIndex = 2;
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
            this.btnRedimensionar.Location = new System.Drawing.Point(736, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(695, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(779, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTituloPacienteEditarReserva
            // 
            this.lblTituloPacienteEditarReserva.AutoSize = true;
            this.lblTituloPacienteEditarReserva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Underline);
            this.lblTituloPacienteEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPacienteEditarReserva.Location = new System.Drawing.Point(151, 60);
            this.lblTituloPacienteEditarReserva.Name = "lblTituloPacienteEditarReserva";
            this.lblTituloPacienteEditarReserva.Size = new System.Drawing.Size(98, 27);
            this.lblTituloPacienteEditarReserva.TabIndex = 28;
            this.lblTituloPacienteEditarReserva.Text = "Paciente";
            // 
            // lblPacienteEditarReserva
            // 
            this.lblPacienteEditarReserva.AutoSize = true;
            this.lblPacienteEditarReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblPacienteEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.lblPacienteEditarReserva.Location = new System.Drawing.Point(82, 104);
            this.lblPacienteEditarReserva.Name = "lblPacienteEditarReserva";
            this.lblPacienteEditarReserva.Size = new System.Drawing.Size(65, 19);
            this.lblPacienteEditarReserva.TabIndex = 29;
            this.lblPacienteEditarReserva.Text = "Nombre";
            // 
            // lblApellidosEditarReserva
            // 
            this.lblApellidosEditarReserva.AutoSize = true;
            this.lblApellidosEditarReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblApellidosEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.lblApellidosEditarReserva.Location = new System.Drawing.Point(82, 142);
            this.lblApellidosEditarReserva.Name = "lblApellidosEditarReserva";
            this.lblApellidosEditarReserva.Size = new System.Drawing.Size(74, 19);
            this.lblApellidosEditarReserva.TabIndex = 31;
            this.lblApellidosEditarReserva.Text = "Apellidos";
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
            this.btnGuardarNuevaReserva.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNuevaReserva.Location = new System.Drawing.Point(280, 397);
            this.btnGuardarNuevaReserva.Name = "btnGuardarNuevaReserva";
            this.btnGuardarNuevaReserva.Size = new System.Drawing.Size(196, 34);
            this.btnGuardarNuevaReserva.TabIndex = 10;
            this.btnGuardarNuevaReserva.Text = "Guardar";
            this.btnGuardarNuevaReserva.TextoColor = System.Drawing.Color.White;
            this.btnGuardarNuevaReserva.UseVisualStyleBackColor = false;
            this.btnGuardarNuevaReserva.Click += new System.EventHandler(this.btnGuardarNuevaReserva_Click);
            // 
            // cbHorasEditarReserva
            // 
            this.cbHorasEditarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbHorasEditarReserva.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbHorasEditarReserva.BordeTamaño = 1;
            this.cbHorasEditarReserva.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbHorasEditarReserva.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbHorasEditarReserva.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbHorasEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.cbHorasEditarReserva.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbHorasEditarReserva.ListColorTexto = System.Drawing.Color.Black;
            this.cbHorasEditarReserva.Location = new System.Drawing.Point(466, 203);
            this.cbHorasEditarReserva.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbHorasEditarReserva.Name = "cbHorasEditarReserva";
            this.cbHorasEditarReserva.Padding = new System.Windows.Forms.Padding(1);
            this.cbHorasEditarReserva.Size = new System.Drawing.Size(200, 30);
            this.cbHorasEditarReserva.TabIndex = 5;
            this.cbHorasEditarReserva.Textos = "";
            // 
            // mcFechaEditarReserva
            // 
            this.mcFechaEditarReserva.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFechaEditarReserva.BordeTamaño = 0;
            this.mcFechaEditarReserva.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFechaEditarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.mcFechaEditarReserva.IsDesplegado = false;
            this.mcFechaEditarReserva.Location = new System.Drawing.Point(86, 198);
            this.mcFechaEditarReserva.MinDate = new System.DateTime(2022, 10, 14, 14, 15, 33, 342);
            this.mcFechaEditarReserva.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFechaEditarReserva.Name = "mcFechaEditarReserva";
            this.mcFechaEditarReserva.Size = new System.Drawing.Size(240, 35);
            this.mcFechaEditarReserva.TabIndex = 0;
            this.mcFechaEditarReserva.TextoColor = System.Drawing.Color.White;
            this.mcFechaEditarReserva.Value = new System.DateTime(2022, 10, 14, 14, 15, 33, 342);
            // 
            // lblApellidosOdontologoEditarReserva
            // 
            this.lblApellidosOdontologoEditarReserva.AutoSize = true;
            this.lblApellidosOdontologoEditarReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblApellidosOdontologoEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.lblApellidosOdontologoEditarReserva.Location = new System.Drawing.Point(462, 142);
            this.lblApellidosOdontologoEditarReserva.Name = "lblApellidosOdontologoEditarReserva";
            this.lblApellidosOdontologoEditarReserva.Size = new System.Drawing.Size(74, 19);
            this.lblApellidosOdontologoEditarReserva.TabIndex = 34;
            this.lblApellidosOdontologoEditarReserva.Text = "Apellidos";
            // 
            // lblNombreOdontologoEditarReserva
            // 
            this.lblNombreOdontologoEditarReserva.AutoSize = true;
            this.lblNombreOdontologoEditarReserva.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblNombreOdontologoEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.lblNombreOdontologoEditarReserva.Location = new System.Drawing.Point(462, 104);
            this.lblNombreOdontologoEditarReserva.Name = "lblNombreOdontologoEditarReserva";
            this.lblNombreOdontologoEditarReserva.Size = new System.Drawing.Size(65, 19);
            this.lblNombreOdontologoEditarReserva.TabIndex = 33;
            this.lblNombreOdontologoEditarReserva.Text = "Nombre";
            // 
            // lblTituloOdontologoEditarReserva
            // 
            this.lblTituloOdontologoEditarReserva.AutoSize = true;
            this.lblTituloOdontologoEditarReserva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Underline);
            this.lblTituloOdontologoEditarReserva.ForeColor = System.Drawing.Color.Black;
            this.lblTituloOdontologoEditarReserva.Location = new System.Drawing.Point(537, 60);
            this.lblTituloOdontologoEditarReserva.Name = "lblTituloOdontologoEditarReserva";
            this.lblTituloOdontologoEditarReserva.Size = new System.Drawing.Size(127, 27);
            this.lblTituloOdontologoEditarReserva.TabIndex = 32;
            this.lblTituloOdontologoEditarReserva.Text = "Odontologo";
            // 
            // EditarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.lblApellidosOdontologoEditarReserva);
            this.Controls.Add(this.lblNombreOdontologoEditarReserva);
            this.Controls.Add(this.lblTituloOdontologoEditarReserva);
            this.Controls.Add(this.lblApellidosEditarReserva);
            this.Controls.Add(this.btnGuardarNuevaReserva);
            this.Controls.Add(this.lblPacienteEditarReserva);
            this.Controls.Add(this.lblTituloPacienteEditarReserva);
            this.Controls.Add(this.cbHorasEditarReserva);
            this.Controls.Add(this.mcFechaEditarReserva);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarReserva";
            this.Load += new System.EventHandler(this.EditarReserva_Load);
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
        private ControlesPersonalizados.SelectorFecha mcFechaEditarReserva;
        private ControlesPersonalizados.ComboBoxPersonalizado cbHorasEditarReserva;
        private System.Windows.Forms.Label lblTituloPacienteEditarReserva;
        private System.Windows.Forms.Label lblPacienteEditarReserva;
        private ControlesPersonalizados.BotonPersonalizado btnGuardarNuevaReserva;
        private System.Windows.Forms.Label lblApellidosEditarReserva;
        private System.Windows.Forms.Label lblApellidosOdontologoEditarReserva;
        private System.Windows.Forms.Label lblNombreOdontologoEditarReserva;
        private System.Windows.Forms.Label lblTituloOdontologoEditarReserva;
    }
}