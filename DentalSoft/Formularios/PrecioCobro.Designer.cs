namespace DentalSoft.Formularios
{
    partial class PrecioCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrecioCobro));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnIntroducirPrecio = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtPrecio = new DentalSoft.TextboxPersonalizado();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(342, 35);
            this.pnlCabecera.TabIndex = 89;
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
            this.btnCerrar.Location = new System.Drawing.Point(305, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIntroducirPrecio
            // 
            this.btnIntroducirPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIntroducirPrecio.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnIntroducirPrecio.BordeRadio = 32;
            this.btnIntroducirPrecio.BordeTamaño = 0;
            this.btnIntroducirPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntroducirPrecio.FlatAppearance.BorderSize = 0;
            this.btnIntroducirPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnIntroducirPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroducirPrecio.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIntroducirPrecio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducirPrecio.ForeColor = System.Drawing.Color.White;
            this.btnIntroducirPrecio.Location = new System.Drawing.Point(156, 56);
            this.btnIntroducirPrecio.Name = "btnIntroducirPrecio";
            this.btnIntroducirPrecio.Size = new System.Drawing.Size(175, 34);
            this.btnIntroducirPrecio.TabIndex = 88;
            this.btnIntroducirPrecio.Text = "Introducir precio";
            this.btnIntroducirPrecio.TextoColor = System.Drawing.Color.White;
            this.btnIntroducirPrecio.UseVisualStyleBackColor = false;
            this.btnIntroducirPrecio.Click += new System.EventHandler(this.btnIntroducirPrecio_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPrecio.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPrecio.BordeRadio = 0;
            this.txtPrecio.BordeTamaño = 2;
            this.txtPrecio.Contraseña = false;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(13, 56);
            this.txtPrecio.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.MarcadorPosicionTexto = "";
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio.Multilinea = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecio.PosicionSeleccion = 0;
            this.txtPrecio.Size = new System.Drawing.Size(136, 34);
            this.txtPrecio.SubrayadoEstilo = true;
            this.txtPrecio.TabIndex = 86;
            this.txtPrecio.TamañoMaximo = 30000;
            this.txtPrecio.Texto = "";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPrecio.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPrecio.Image")));
            this.lblErrorPrecio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPrecio.Location = new System.Drawing.Point(13, 93);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(85, 15);
            this.lblErrorPrecio.TabIndex = 87;
            this.lblErrorPrecio.Text = "Mensaje Error";
            this.lblErrorPrecio.Visible = false;
            // 
            // PrecioCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 120);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.btnIntroducirPrecio);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.txtPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrecioCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrecioCobro";
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private ControlesPersonalizados.BotonPersonalizado btnIntroducirPrecio;
        private System.Windows.Forms.Label lblErrorPrecio;
        private TextboxPersonalizado txtPrecio;
    }
}