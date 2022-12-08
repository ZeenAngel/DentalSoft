namespace DentalSoft
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelImagen = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAccederLogin = new System.Windows.Forms.Button();
            this.linkRecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.btnCerrarLogin = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.txtContraseñaLogin = new DentalSoft.TextboxPersonalizado();
            this.txtUsuarioLogin = new DentalSoft.TextboxPersonalizado();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.panelImagen.Controls.Add(this.pictureBox3);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(250, 330);
            this.panelImagen.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 330);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // btnAccederLogin
            // 
            this.btnAccederLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAccederLogin.FlatAppearance.BorderSize = 0;
            this.btnAccederLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnAccederLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnAccederLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccederLogin.Location = new System.Drawing.Point(343, 251);
            this.btnAccederLogin.Name = "btnAccederLogin";
            this.btnAccederLogin.Size = new System.Drawing.Size(337, 40);
            this.btnAccederLogin.TabIndex = 1;
            this.btnAccederLogin.Text = "ACCEDER";
            this.btnAccederLogin.UseVisualStyleBackColor = false;
            this.btnAccederLogin.Click += new System.EventHandler(this.btnAccederLogin_Click);
            // 
            // linkRecuperarContraseña
            // 
            this.linkRecuperarContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.linkRecuperarContraseña.AutoSize = true;
            this.linkRecuperarContraseña.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRecuperarContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.linkRecuperarContraseña.Location = new System.Drawing.Point(449, 308);
            this.linkRecuperarContraseña.Name = "linkRecuperarContraseña";
            this.linkRecuperarContraseña.Size = new System.Drawing.Size(117, 13);
            this.linkRecuperarContraseña.TabIndex = 15;
            this.linkRecuperarContraseña.TabStop = true;
            this.linkRecuperarContraseña.Text = "Recuperar contraseña";
            this.linkRecuperarContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperarContraseña_LinkClicked);
            // 
            // btnCerrarLogin
            // 
            this.btnCerrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarLogin.Image")));
            this.btnCerrarLogin.Location = new System.Drawing.Point(752, 2);
            this.btnCerrarLogin.Name = "btnCerrarLogin";
            this.btnCerrarLogin.Size = new System.Drawing.Size(25, 25);
            this.btnCerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarLogin.TabIndex = 6;
            this.btnCerrarLogin.TabStop = false;
            this.btnCerrarLogin.Click += new System.EventHandler(this.btnCerrarLogin_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(721, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(391, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(245, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLogin.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorLogin.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorLogin.Image")));
            this.lblErrorLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorLogin.Location = new System.Drawing.Point(351, 213);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(85, 15);
            this.lblErrorLogin.TabIndex = 16;
            this.lblErrorLogin.Text = "Mensaje Error";
            this.lblErrorLogin.Visible = false;
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtContraseñaLogin.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtContraseñaLogin.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtContraseñaLogin.BordeRadio = 15;
            this.txtContraseñaLogin.BordeTamaño = 2;
            this.txtContraseñaLogin.Contraseña = true;
            this.txtContraseñaLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaLogin.ForeColor = System.Drawing.Color.Black;
            this.txtContraseñaLogin.Location = new System.Drawing.Point(343, 163);
            this.txtContraseñaLogin.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtContraseñaLogin.MarcadorPosicionTexto = "Contraseña";
            this.txtContraseñaLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseñaLogin.Multilinea = false;
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseñaLogin.PosicionSeleccion = 0;
            this.txtContraseñaLogin.Size = new System.Drawing.Size(337, 34);
            this.txtContraseñaLogin.SubrayadoEstilo = true;
            this.txtContraseñaLogin.TabIndex = 10;
            this.txtContraseñaLogin.TamañoMaximo = 30000;
            this.txtContraseñaLogin.Texto = "";
            this.txtContraseñaLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseñaLogin_KeyPress);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtUsuarioLogin.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtUsuarioLogin.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtUsuarioLogin.BordeRadio = 15;
            this.txtUsuarioLogin.BordeTamaño = 2;
            this.txtUsuarioLogin.Contraseña = false;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(343, 100);
            this.txtUsuarioLogin.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtUsuarioLogin.MarcadorPosicionTexto = "Usuario";
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuarioLogin.Multilinea = false;
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuarioLogin.PosicionSeleccion = 0;
            this.txtUsuarioLogin.Size = new System.Drawing.Size(337, 34);
            this.txtUsuarioLogin.SubrayadoEstilo = true;
            this.txtUsuarioLogin.TabIndex = 5;
            this.txtUsuarioLogin.TamañoMaximo = 30000;
            this.txtUsuarioLogin.Texto = "";
            this.txtUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioLogin_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrarLogin);
            this.Controls.Add(this.linkRecuperarContraseña);
            this.Controls.Add(this.btnAccederLogin);
            this.Controls.Add(this.txtContraseñaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.panelImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private TextboxPersonalizado txtUsuarioLogin;
        private TextboxPersonalizado txtContraseñaLogin;
        private System.Windows.Forms.Button btnAccederLogin;
        private System.Windows.Forms.LinkLabel linkRecuperarContraseña;
        private System.Windows.Forms.PictureBox btnCerrarLogin;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblErrorLogin;
    }
}

