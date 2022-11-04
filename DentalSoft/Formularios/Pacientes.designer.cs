namespace DentalSoft
{
    partial class Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.pnlDgvBuscarPaciente = new System.Windows.Forms.Panel();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.lblFiltrosPacientes = new System.Windows.Forms.Label();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.btnHistorialPacientes = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEliminarPacientes = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEditarPacientes = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevoPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.cbFiltrosPacientes = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.txtPacientes = new DentalSoft.TextboxPersonalizado();
            this.pnlDgvBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDgvBuscarPaciente
            // 
            this.pnlDgvBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBuscarPaciente.Controls.Add(this.dgvPacientes);
            this.pnlDgvBuscarPaciente.Location = new System.Drawing.Point(92, 187);
            this.pnlDgvBuscarPaciente.Name = "pnlDgvBuscarPaciente";
            this.pnlDgvBuscarPaciente.Size = new System.Drawing.Size(966, 335);
            this.pnlDgvBuscarPaciente.TabIndex = 15;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(966, 335);
            this.dgvPacientes.TabIndex = 0;
            // 
            // lblFiltrosPacientes
            // 
            this.lblFiltrosPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrosPacientes.AutoSize = true;
            this.lblFiltrosPacientes.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltrosPacientes.ForeColor = System.Drawing.Color.Black;
            this.lblFiltrosPacientes.Location = new System.Drawing.Point(801, 123);
            this.lblFiltrosPacientes.Name = "lblFiltrosPacientes";
            this.lblFiltrosPacientes.Size = new System.Drawing.Size(50, 19);
            this.lblFiltrosPacientes.TabIndex = 16;
            this.lblFiltrosPacientes.Text = "Filtrar";
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = ((System.Drawing.Image)(resources.GetObject("pbAtras.Image")));
            this.pbAtras.Location = new System.Drawing.Point(25, 23);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(100, 50);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 12;
            this.pbAtras.TabStop = false;
            // 
            // btnHistorialPacientes
            // 
            this.btnHistorialPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnHistorialPacientes.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnHistorialPacientes.BordeRadio = 32;
            this.btnHistorialPacientes.BordeTamaño = 0;
            this.btnHistorialPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialPacientes.FlatAppearance.BorderSize = 0;
            this.btnHistorialPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnHistorialPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPacientes.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnHistorialPacientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPacientes.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPacientes.Location = new System.Drawing.Point(292, 637);
            this.btnHistorialPacientes.Name = "btnHistorialPacientes";
            this.btnHistorialPacientes.Size = new System.Drawing.Size(559, 34);
            this.btnHistorialPacientes.TabIndex = 28;
            this.btnHistorialPacientes.Text = "Historial Paciente";
            this.btnHistorialPacientes.TextoColor = System.Drawing.Color.White;
            this.btnHistorialPacientes.UseVisualStyleBackColor = false;
            this.btnHistorialPacientes.Click += new System.EventHandler(this.btnHistorialPacientes_Click);
            // 
            // btnEliminarPacientes
            // 
            this.btnEliminarPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarPacientes.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarPacientes.BordeRadio = 32;
            this.btnEliminarPacientes.BordeTamaño = 0;
            this.btnEliminarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPacientes.FlatAppearance.BorderSize = 0;
            this.btnEliminarPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEliminarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPacientes.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarPacientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPacientes.Location = new System.Drawing.Point(788, 562);
            this.btnEliminarPacientes.Name = "btnEliminarPacientes";
            this.btnEliminarPacientes.Size = new System.Drawing.Size(270, 34);
            this.btnEliminarPacientes.TabIndex = 27;
            this.btnEliminarPacientes.Text = "Eliminar Paciente";
            this.btnEliminarPacientes.TextoColor = System.Drawing.Color.White;
            this.btnEliminarPacientes.UseVisualStyleBackColor = false;
            this.btnEliminarPacientes.Click += new System.EventHandler(this.btnEliminarPacientes_Click);
            // 
            // btnEditarPacientes
            // 
            this.btnEditarPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarPacientes.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarPacientes.BordeRadio = 32;
            this.btnEditarPacientes.BordeTamaño = 0;
            this.btnEditarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPacientes.FlatAppearance.BorderSize = 0;
            this.btnEditarPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEditarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPacientes.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarPacientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnEditarPacientes.Location = new System.Drawing.Point(432, 562);
            this.btnEditarPacientes.Name = "btnEditarPacientes";
            this.btnEditarPacientes.Size = new System.Drawing.Size(270, 34);
            this.btnEditarPacientes.TabIndex = 26;
            this.btnEditarPacientes.Text = "Editar Paciente";
            this.btnEditarPacientes.TextoColor = System.Drawing.Color.White;
            this.btnEditarPacientes.UseVisualStyleBackColor = false;
            this.btnEditarPacientes.Click += new System.EventHandler(this.btnEditarPacientes_Click);
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoPaciente.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevoPaciente.BordeRadio = 32;
            this.btnNuevoPaciente.BordeTamaño = 0;
            this.btnNuevoPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPaciente.FlatAppearance.BorderSize = 0;
            this.btnNuevoPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPaciente.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPaciente.Location = new System.Drawing.Point(92, 562);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(270, 34);
            this.btnNuevoPaciente.TabIndex = 25;
            this.btnNuevoPaciente.Text = "Nuevo Paciente";
            this.btnNuevoPaciente.TextoColor = System.Drawing.Color.White;
            this.btnNuevoPaciente.UseVisualStyleBackColor = false;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // cbFiltrosPacientes
            // 
            this.cbFiltrosPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltrosPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltrosPacientes.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltrosPacientes.BordeTamaño = 1;
            this.cbFiltrosPacientes.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrosPacientes.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltrosPacientes.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbFiltrosPacientes.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltrosPacientes.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrosPacientes.ForeColor = System.Drawing.Color.Black;
            this.cbFiltrosPacientes.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrosPacientes.ListColorTexto = System.Drawing.Color.Black;
            this.cbFiltrosPacientes.Location = new System.Drawing.Point(858, 117);
            this.cbFiltrosPacientes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltrosPacientes.Name = "cbFiltrosPacientes";
            this.cbFiltrosPacientes.Padding = new System.Windows.Forms.Padding(1);
            this.cbFiltrosPacientes.Size = new System.Drawing.Size(200, 30);
            this.cbFiltrosPacientes.TabIndex = 14;
            this.cbFiltrosPacientes.Textos = "";
            this.cbFiltrosPacientes.OnSelectedIndexChanged += new System.EventHandler(this.cbFiltrosPacientes_OnSelectedIndexChanged);
            // 
            // txtPacientes
            // 
            this.txtPacientes.BackColor = System.Drawing.Color.White;
            this.txtPacientes.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPacientes.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPacientes.BordeRadio = 0;
            this.txtPacientes.BordeTamaño = 2;
            this.txtPacientes.Contraseña = false;
            this.txtPacientes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacientes.ForeColor = System.Drawing.Color.Black;
            this.txtPacientes.Location = new System.Drawing.Point(92, 114);
            this.txtPacientes.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPacientes.MarcadorPosicionTexto = "Introduce el paciente a buscar";
            this.txtPacientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPacientes.Multilinea = false;
            this.txtPacientes.Name = "txtPacientes";
            this.txtPacientes.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPacientes.Size = new System.Drawing.Size(591, 34);
            this.txtPacientes.SubrayadoEstilo = true;
            this.txtPacientes.TabIndex = 13;
            this.txtPacientes.Texto = "";
            this.txtPacientes._TextChanged += new System.EventHandler(this.txtPacientes__TextChanged);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.btnHistorialPacientes);
            this.Controls.Add(this.btnEliminarPacientes);
            this.Controls.Add(this.btnEditarPacientes);
            this.Controls.Add(this.btnNuevoPaciente);
            this.Controls.Add(this.lblFiltrosPacientes);
            this.Controls.Add(this.pnlDgvBuscarPaciente);
            this.Controls.Add(this.cbFiltrosPacientes);
            this.Controls.Add(this.txtPacientes);
            this.Controls.Add(this.pbAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.pnlDgvBuscarPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.Panel pnlDgvBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private ControlesPersonalizados.ComboBoxPersonalizado cbFiltrosPacientes;
        private TextboxPersonalizado txtPacientes;
        private System.Windows.Forms.Label lblFiltrosPacientes;
        private ControlesPersonalizados.BotonPersonalizado btnNuevoPaciente;
        private ControlesPersonalizados.BotonPersonalizado btnEditarPacientes;
        private ControlesPersonalizados.BotonPersonalizado btnEliminarPacientes;
        private ControlesPersonalizados.BotonPersonalizado btnHistorialPacientes;
    }
}