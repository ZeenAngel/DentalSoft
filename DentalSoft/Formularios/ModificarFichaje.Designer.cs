namespace DentalSoft.Formularios
{
    partial class ModificarFichaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarFichaje));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnGuardarProducto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.mcFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.txtHora = new DentalSoft.TextboxPersonalizado();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloEmpleado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblErrorGuardar = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.btnMinimizar);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(444, 38);
            this.pnlCabecera.TabIndex = 2;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 29);
            this.lblTitulo.TabIndex = 41;
            this.lblTitulo.Text = "DentalSoft";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(363, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
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
            this.btnCerrar.Location = new System.Drawing.Point(400, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarProducto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarProducto.BordeRadio = 32;
            this.btnGuardarProducto.BordeTamaño = 0;
            this.btnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProducto.Location = new System.Drawing.Point(112, 344);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(193, 34);
            this.btnGuardarProducto.TabIndex = 10;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.TextoColor = System.Drawing.Color.White;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
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
            this.mcFecha.Location = new System.Drawing.Point(140, 131);
            this.mcFecha.MinDate = new System.DateTime(2000, 1, 1, 17, 51, 0, 0);
            this.mcFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.Size = new System.Drawing.Size(271, 35);
            this.mcFecha.TabIndex = 0;
            this.mcFecha.TextoColor = System.Drawing.Color.White;
            this.mcFecha.Value = new System.DateTime(2022, 10, 9, 17, 56, 50, 302);
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Window;
            this.txtHora.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtHora.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtHora.BordeRadio = 0;
            this.txtHora.BordeTamaño = 2;
            this.txtHora.Contraseña = false;
            this.txtHora.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtHora.ForeColor = System.Drawing.Color.Black;
            this.txtHora.Location = new System.Drawing.Point(140, 198);
            this.txtHora.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtHora.MarcadorPosicionTexto = "";
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Multilinea = false;
            this.txtHora.Name = "txtHora";
            this.txtHora.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHora.PosicionSeleccion = 0;
            this.txtHora.Size = new System.Drawing.Size(123, 39);
            this.txtHora.SubrayadoEstilo = true;
            this.txtHora.TabIndex = 5;
            this.txtHora.TamañoMaximo = 30000;
            this.txtHora.Texto = "";
            this.txtHora._TextChanged += new System.EventHandler(this.txtHora__TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblFecha.Location = new System.Drawing.Point(24, 137);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 29);
            this.lblFecha.TabIndex = 49;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTituloEmpleado
            // 
            this.lblTituloEmpleado.AutoSize = true;
            this.lblTituloEmpleado.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblTituloEmpleado.Location = new System.Drawing.Point(24, 61);
            this.lblTituloEmpleado.Name = "lblTituloEmpleado";
            this.lblTituloEmpleado.Size = new System.Drawing.Size(127, 29);
            this.lblTituloEmpleado.TabIndex = 50;
            this.lblTituloEmpleado.Text = "Empleado:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblHora.Location = new System.Drawing.Point(24, 209);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 29);
            this.lblHora.TabIndex = 51;
            this.lblHora.Text = "Hora";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblEmpleado.Location = new System.Drawing.Point(136, 61);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(161, 29);
            this.lblEmpleado.TabIndex = 52;
            this.lblEmpleado.Text = "Dni empleado";
            // 
            // lblErrorGuardar
            // 
            this.lblErrorGuardar.AutoSize = true;
            this.lblErrorGuardar.Font = new System.Drawing.Font("Roboto", 10F);
            this.lblErrorGuardar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorGuardar.Image")));
            this.lblErrorGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorGuardar.Location = new System.Drawing.Point(109, 324);
            this.lblErrorGuardar.Name = "lblErrorGuardar";
            this.lblErrorGuardar.Size = new System.Drawing.Size(115, 20);
            this.lblErrorGuardar.TabIndex = 53;
            this.lblErrorGuardar.Text = "Mensaje Error";
            this.lblErrorGuardar.Visible = false;
            // 
            // ModificarFichaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(444, 405);
            this.Controls.Add(this.lblErrorGuardar);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblTituloEmpleado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.mcFecha);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarFichaje";
            this.Text = "ModificarFichaje";
            this.Load += new System.EventHandler(this.ModificarFichaje_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private ControlesPersonalizados.BotonPersonalizado btnGuardarProducto;
        private ControlesPersonalizados.SelectorFecha mcFecha;
        private TextboxPersonalizado txtHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloEmpleado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblErrorGuardar;
    }
}