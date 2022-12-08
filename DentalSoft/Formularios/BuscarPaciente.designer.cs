namespace DentalSoft
{
    partial class BuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPaciente));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtPacienteBuscarPaciente = new DentalSoft.TextboxPersonalizado();
            this.cbFiltrosBuscarPaciente = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.pnlDgvBuscarPaciente = new System.Windows.Forms.Panel();
            this.dgvPacientesBuscarPaciente = new System.Windows.Forms.DataGridView();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlDgvBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesBuscarPaciente)).BeginInit();
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
            this.pnlCabecera.TabIndex = 1;
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
            // txtPacienteBuscarPaciente
            // 
            this.txtPacienteBuscarPaciente.BackColor = System.Drawing.Color.White;
            this.txtPacienteBuscarPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPacienteBuscarPaciente.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPacienteBuscarPaciente.BordeRadio = 0;
            this.txtPacienteBuscarPaciente.BordeTamaño = 2;
            this.txtPacienteBuscarPaciente.Contraseña = false;
            this.txtPacienteBuscarPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteBuscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtPacienteBuscarPaciente.Location = new System.Drawing.Point(55, 85);
            this.txtPacienteBuscarPaciente.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPacienteBuscarPaciente.MarcadorPosicionTexto = "Introduce el paciente a buscar";
            this.txtPacienteBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPacienteBuscarPaciente.Multilinea = false;
            this.txtPacienteBuscarPaciente.Name = "txtPacienteBuscarPaciente";
            this.txtPacienteBuscarPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPacienteBuscarPaciente.PosicionSeleccion = 0;
            this.txtPacienteBuscarPaciente.Size = new System.Drawing.Size(464, 30);
            this.txtPacienteBuscarPaciente.SubrayadoEstilo = true;
            this.txtPacienteBuscarPaciente.TabIndex = 0;
            this.txtPacienteBuscarPaciente.TamañoMaximo = 30000;
            this.txtPacienteBuscarPaciente.Texto = "";
            this.txtPacienteBuscarPaciente._TextChanged += new System.EventHandler(this.txtPacienteBuscarPaciente__TextChanged);
            // 
            // cbFiltrosBuscarPaciente
            // 
            this.cbFiltrosBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltrosBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltrosBuscarPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltrosBuscarPaciente.BordeTamaño = 1;
            this.cbFiltrosBuscarPaciente.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrosBuscarPaciente.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltrosBuscarPaciente.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbFiltrosBuscarPaciente.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltrosBuscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.cbFiltrosBuscarPaciente.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltrosBuscarPaciente.ListColorTexto = System.Drawing.Color.Black;
            this.cbFiltrosBuscarPaciente.Location = new System.Drawing.Point(561, 85);
            this.cbFiltrosBuscarPaciente.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltrosBuscarPaciente.Name = "cbFiltrosBuscarPaciente";
            this.cbFiltrosBuscarPaciente.Padding = new System.Windows.Forms.Padding(1);
            this.cbFiltrosBuscarPaciente.Size = new System.Drawing.Size(200, 30);
            this.cbFiltrosBuscarPaciente.TabIndex = 5;
            this.cbFiltrosBuscarPaciente.Textos = "";
            this.cbFiltrosBuscarPaciente.OnSelectedIndexChanged += new System.EventHandler(this.cbFiltrosBuscarPaciente_OnSelectedIndexChanged);
            // 
            // pnlDgvBuscarPaciente
            // 
            this.pnlDgvBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBuscarPaciente.Controls.Add(this.dgvPacientesBuscarPaciente);
            this.pnlDgvBuscarPaciente.Location = new System.Drawing.Point(55, 143);
            this.pnlDgvBuscarPaciente.Name = "pnlDgvBuscarPaciente";
            this.pnlDgvBuscarPaciente.Size = new System.Drawing.Size(706, 316);
            this.pnlDgvBuscarPaciente.TabIndex = 4;
            // 
            // dgvPacientesBuscarPaciente
            // 
            this.dgvPacientesBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesBuscarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientesBuscarPaciente.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientesBuscarPaciente.Name = "dgvPacientesBuscarPaciente";
            this.dgvPacientesBuscarPaciente.Size = new System.Drawing.Size(706, 316);
            this.dgvPacientesBuscarPaciente.TabIndex = 0;
            this.dgvPacientesBuscarPaciente.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientesBuscarPaciente_CellContentDoubleClick);
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.pnlDgvBuscarPaciente);
            this.Controls.Add(this.cbFiltrosBuscarPaciente);
            this.Controls.Add(this.txtPacienteBuscarPaciente);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPaciente";
            this.Load += new System.EventHandler(this.BuscarPaciente_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlDgvBuscarPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesBuscarPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private TextboxPersonalizado txtPacienteBuscarPaciente;
        private ControlesPersonalizados.ComboBoxPersonalizado cbFiltrosBuscarPaciente;
        private System.Windows.Forms.Panel pnlDgvBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvPacientesBuscarPaciente;
    }
}