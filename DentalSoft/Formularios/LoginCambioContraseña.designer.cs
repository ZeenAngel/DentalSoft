namespace DentalSoft
{
    partial class LoginCambioContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCambioContraseña));
            this.btnGuardarLoginCambioContraseña = new System.Windows.Forms.Button();
            this.lblErrorLoginCambioContraseña = new System.Windows.Forms.Label();
            this.txtContraseña2LoginCambioContraseña = new DentalSoft.TextboxPersonalizado();
            this.txtContraseña1LoginCambioContraseña = new DentalSoft.TextboxPersonalizado();
            this.SuspendLayout();
            // 
            // btnGuardarLoginCambioContraseña
            // 
            this.btnGuardarLoginCambioContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarLoginCambioContraseña.FlatAppearance.BorderSize = 0;
            this.btnGuardarLoginCambioContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGuardarLoginCambioContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGuardarLoginCambioContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarLoginCambioContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLoginCambioContraseña.Location = new System.Drawing.Point(82, 169);
            this.btnGuardarLoginCambioContraseña.Name = "btnGuardarLoginCambioContraseña";
            this.btnGuardarLoginCambioContraseña.Size = new System.Drawing.Size(337, 40);
            this.btnGuardarLoginCambioContraseña.TabIndex = 10;
            this.btnGuardarLoginCambioContraseña.Text = "GUARDAR";
            this.btnGuardarLoginCambioContraseña.UseVisualStyleBackColor = false;
            this.btnGuardarLoginCambioContraseña.Click += new System.EventHandler(this.btnGuardarLoginCambioContraseña_Click);
            // 
            // lblErrorLoginCambioContraseña
            // 
            this.lblErrorLoginCambioContraseña.AutoSize = true;
            this.lblErrorLoginCambioContraseña.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLoginCambioContraseña.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorLoginCambioContraseña.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorLoginCambioContraseña.Image")));
            this.lblErrorLoginCambioContraseña.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorLoginCambioContraseña.Location = new System.Drawing.Point(96, 136);
            this.lblErrorLoginCambioContraseña.Name = "lblErrorLoginCambioContraseña";
            this.lblErrorLoginCambioContraseña.Size = new System.Drawing.Size(85, 15);
            this.lblErrorLoginCambioContraseña.TabIndex = 17;
            this.lblErrorLoginCambioContraseña.Text = "Mensaje Error";
            this.lblErrorLoginCambioContraseña.Visible = false;
            // 
            // txtContraseña2LoginCambioContraseña
            // 
            this.txtContraseña2LoginCambioContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtContraseña2LoginCambioContraseña.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtContraseña2LoginCambioContraseña.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtContraseña2LoginCambioContraseña.BordeRadio = 15;
            this.txtContraseña2LoginCambioContraseña.BordeTamaño = 2;
            this.txtContraseña2LoginCambioContraseña.Contraseña = true;
            this.txtContraseña2LoginCambioContraseña.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña2LoginCambioContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña2LoginCambioContraseña.Location = new System.Drawing.Point(82, 79);
            this.txtContraseña2LoginCambioContraseña.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtContraseña2LoginCambioContraseña.MarcadorPosicionTexto = "Repite de nuevo la contraseña";
            this.txtContraseña2LoginCambioContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseña2LoginCambioContraseña.Multilinea = false;
            this.txtContraseña2LoginCambioContraseña.Name = "txtContraseña2LoginCambioContraseña";
            this.txtContraseña2LoginCambioContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseña2LoginCambioContraseña.PosicionSeleccion = 0;
            this.txtContraseña2LoginCambioContraseña.Size = new System.Drawing.Size(337, 34);
            this.txtContraseña2LoginCambioContraseña.SubrayadoEstilo = true;
            this.txtContraseña2LoginCambioContraseña.TabIndex = 5;
            this.txtContraseña2LoginCambioContraseña.TamañoMaximo = 30000;
            this.txtContraseña2LoginCambioContraseña.Texto = "";
            this.txtContraseña2LoginCambioContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña2LoginCambioContraseña_KeyPress);
            // 
            // txtContraseña1LoginCambioContraseña
            // 
            this.txtContraseña1LoginCambioContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtContraseña1LoginCambioContraseña.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtContraseña1LoginCambioContraseña.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtContraseña1LoginCambioContraseña.BordeRadio = 15;
            this.txtContraseña1LoginCambioContraseña.BordeTamaño = 2;
            this.txtContraseña1LoginCambioContraseña.Contraseña = true;
            this.txtContraseña1LoginCambioContraseña.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña1LoginCambioContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña1LoginCambioContraseña.Location = new System.Drawing.Point(82, 21);
            this.txtContraseña1LoginCambioContraseña.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtContraseña1LoginCambioContraseña.MarcadorPosicionTexto = "Introduce una nueva contraseña";
            this.txtContraseña1LoginCambioContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseña1LoginCambioContraseña.Multilinea = false;
            this.txtContraseña1LoginCambioContraseña.Name = "txtContraseña1LoginCambioContraseña";
            this.txtContraseña1LoginCambioContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContraseña1LoginCambioContraseña.PosicionSeleccion = 0;
            this.txtContraseña1LoginCambioContraseña.Size = new System.Drawing.Size(337, 34);
            this.txtContraseña1LoginCambioContraseña.SubrayadoEstilo = true;
            this.txtContraseña1LoginCambioContraseña.TabIndex = 0;
            this.txtContraseña1LoginCambioContraseña.TamañoMaximo = 30000;
            this.txtContraseña1LoginCambioContraseña.Texto = "";
            this.txtContraseña1LoginCambioContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña1LoginCambioContraseña_KeyPress);
            // 
            // LoginCambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lblErrorLoginCambioContraseña);
            this.Controls.Add(this.btnGuardarLoginCambioContraseña);
            this.Controls.Add(this.txtContraseña2LoginCambioContraseña);
            this.Controls.Add(this.txtContraseña1LoginCambioContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginCambioContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCambioContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarLoginCambioContraseña;
        private TextboxPersonalizado txtContraseña2LoginCambioContraseña;
        private TextboxPersonalizado txtContraseña1LoginCambioContraseña;
        private System.Windows.Forms.Label lblErrorLoginCambioContraseña;
    }
}