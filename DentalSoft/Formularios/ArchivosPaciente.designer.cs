namespace DentalSoft
{
    partial class ArchivosPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivosPaciente));
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.lvCargarFicheros = new System.Windows.Forms.ListView();
            this.lblCargarFicheros = new System.Windows.Forms.Label();
            this.lblErrorConexion = new System.Windows.Forms.Label();
            this.btnNuevo = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEliminar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnVisualizar = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(40, 28);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 77;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lvCargarFicheros
            // 
            this.lvCargarFicheros.HideSelection = false;
            this.lvCargarFicheros.Location = new System.Drawing.Point(153, 152);
            this.lvCargarFicheros.Name = "lvCargarFicheros";
            this.lvCargarFicheros.Size = new System.Drawing.Size(517, 492);
            this.lvCargarFicheros.TabIndex = 0;
            this.lvCargarFicheros.UseCompatibleStateImageBehavior = false;
            // 
            // lblCargarFicheros
            // 
            this.lblCargarFicheros.AutoSize = true;
            this.lblCargarFicheros.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblCargarFicheros.Location = new System.Drawing.Point(149, 112);
            this.lblCargarFicheros.Name = "lblCargarFicheros";
            this.lblCargarFicheros.Size = new System.Drawing.Size(225, 23);
            this.lblCargarFicheros.TabIndex = 80;
            this.lblCargarFicheros.Text = "Documentos del paciente";
            // 
            // lblErrorConexion
            // 
            this.lblErrorConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorConexion.AutoSize = true;
            this.lblErrorConexion.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorConexion.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorConexion.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorConexion.Image")));
            this.lblErrorConexion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorConexion.Location = new System.Drawing.Point(150, 668);
            this.lblErrorConexion.Name = "lblErrorConexion";
            this.lblErrorConexion.Size = new System.Drawing.Size(85, 15);
            this.lblErrorConexion.TabIndex = 83;
            this.lblErrorConexion.Text = "Mensaje Error";
            this.lblErrorConexion.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevo.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevo.BordeRadio = 40;
            this.btnNuevo.BordeTamaño = 0;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevo.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(812, 465);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 40);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo...";
            this.btnNuevo.TextoColor = System.Drawing.Color.White;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BordeRadio = 40;
            this.btnEliminar.BordeTamaño = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(812, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextoColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnVisualizar.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnVisualizar.BordeRadio = 40;
            this.btnVisualizar.BordeTamaño = 0;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnVisualizar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(812, 218);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(163, 40);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextoColor = System.Drawing.Color.White;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // ArchivosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1275, 715);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.lblErrorConexion);
            this.Controls.Add(this.lblCargarFicheros);
            this.Controls.Add(this.lvCargarFicheros);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ArchivosPaciente";
            this.Text = "ArchivosPaciente";
            this.Load += new System.EventHandler(this.ArchivosPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.ListView lvCargarFicheros;
        private System.Windows.Forms.Label lblCargarFicheros;
        private System.Windows.Forms.Label lblErrorConexion;
        private ControlesPersonalizados.BotonPersonalizado btnNuevo;
        private ControlesPersonalizados.BotonPersonalizado btnEliminar;
        private ControlesPersonalizados.BotonPersonalizado btnVisualizar;
    }
}