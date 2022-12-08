namespace DentalSoft.Formularios
{
    partial class ConceptoCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConceptoCobro));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnIntroducirConcepto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtConcepto = new DentalSoft.TextboxPersonalizado();
            this.lblErrorConcepto = new System.Windows.Forms.Label();
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
            this.pnlCabecera.Size = new System.Drawing.Size(587, 35);
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
            this.btnCerrar.Location = new System.Drawing.Point(550, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIntroducirConcepto
            // 
            this.btnIntroducirConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIntroducirConcepto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnIntroducirConcepto.BordeRadio = 32;
            this.btnIntroducirConcepto.BordeTamaño = 0;
            this.btnIntroducirConcepto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIntroducirConcepto.FlatAppearance.BorderSize = 0;
            this.btnIntroducirConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnIntroducirConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntroducirConcepto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnIntroducirConcepto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducirConcepto.ForeColor = System.Drawing.Color.White;
            this.btnIntroducirConcepto.Location = new System.Drawing.Point(405, 41);
            this.btnIntroducirConcepto.Name = "btnIntroducirConcepto";
            this.btnIntroducirConcepto.Size = new System.Drawing.Size(175, 34);
            this.btnIntroducirConcepto.TabIndex = 88;
            this.btnIntroducirConcepto.Text = "Introducir concepto";
            this.btnIntroducirConcepto.TextoColor = System.Drawing.Color.White;
            this.btnIntroducirConcepto.UseVisualStyleBackColor = false;
            this.btnIntroducirConcepto.Click += new System.EventHandler(this.btnIntroducirConcepto_Click);
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.SystemColors.Window;
            this.txtConcepto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtConcepto.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtConcepto.BordeRadio = 0;
            this.txtConcepto.BordeTamaño = 2;
            this.txtConcepto.Contraseña = false;
            this.txtConcepto.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtConcepto.ForeColor = System.Drawing.Color.Black;
            this.txtConcepto.Location = new System.Drawing.Point(13, 41);
            this.txtConcepto.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtConcepto.MarcadorPosicionTexto = "";
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtConcepto.Multilinea = false;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConcepto.PosicionSeleccion = 0;
            this.txtConcepto.Size = new System.Drawing.Size(385, 34);
            this.txtConcepto.SubrayadoEstilo = true;
            this.txtConcepto.TabIndex = 86;
            this.txtConcepto.TamañoMaximo = 30000;
            this.txtConcepto.Texto = "";
            this.txtConcepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConcepto_KeyPress);
            // 
            // lblErrorConcepto
            // 
            this.lblErrorConcepto.AutoSize = true;
            this.lblErrorConcepto.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorConcepto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorConcepto.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorConcepto.Image")));
            this.lblErrorConcepto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorConcepto.Location = new System.Drawing.Point(13, 78);
            this.lblErrorConcepto.Name = "lblErrorConcepto";
            this.lblErrorConcepto.Size = new System.Drawing.Size(85, 15);
            this.lblErrorConcepto.TabIndex = 87;
            this.lblErrorConcepto.Text = "Mensaje Error";
            this.lblErrorConcepto.Visible = false;
            // 
            // ConceptoCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 98);
            this.Controls.Add(this.pnlCabecera);
            this.Controls.Add(this.btnIntroducirConcepto);
            this.Controls.Add(this.lblErrorConcepto);
            this.Controls.Add(this.txtConcepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConceptoCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConceptoCobro";
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
        private ControlesPersonalizados.BotonPersonalizado btnIntroducirConcepto;
        private System.Windows.Forms.Label lblErrorConcepto;
        private TextboxPersonalizado txtConcepto;
    }
}