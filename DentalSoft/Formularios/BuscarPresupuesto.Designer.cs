namespace DentalSoft.Formularios
{
    partial class BuscarPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPresupuesto));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRedimensionar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlDgvBuscarPaciente = new System.Windows.Forms.Panel();
            this.dgvPresupuestos = new System.Windows.Forms.DataGridView();
            this.cbFiltros = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.txtPresupuesto = new DentalSoft.TextboxPersonalizado();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlDgvBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.btnRedimensionar);
            this.pnlCabecera.Controls.Add(this.btnMinimizar);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(816, 35);
            this.pnlCabecera.TabIndex = 10;
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
            // pnlDgvBuscarPaciente
            // 
            this.pnlDgvBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBuscarPaciente.Controls.Add(this.dgvPresupuestos);
            this.pnlDgvBuscarPaciente.Location = new System.Drawing.Point(55, 116);
            this.pnlDgvBuscarPaciente.Name = "pnlDgvBuscarPaciente";
            this.pnlDgvBuscarPaciente.Size = new System.Drawing.Size(706, 316);
            this.pnlDgvBuscarPaciente.TabIndex = 13;
            // 
            // dgvPresupuestos
            // 
            this.dgvPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPresupuestos.Location = new System.Drawing.Point(0, 0);
            this.dgvPresupuestos.Name = "dgvPresupuestos";
            this.dgvPresupuestos.Size = new System.Drawing.Size(706, 316);
            this.dgvPresupuestos.TabIndex = 0;
            this.dgvPresupuestos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuestos_CellContentDoubleClick);
            // 
            // cbFiltros
            // 
            this.cbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.BordeTamaño = 1;
            this.cbFiltros.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltros.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltros.ForeColor = System.Drawing.Color.Black;
            this.cbFiltros.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltros.ListColorTexto = System.Drawing.Color.Black;
            this.cbFiltros.Location = new System.Drawing.Point(561, 58);
            this.cbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Padding = new System.Windows.Forms.Padding(1);
            this.cbFiltros.Size = new System.Drawing.Size(200, 30);
            this.cbFiltros.TabIndex = 12;
            this.cbFiltros.Textos = "";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.BackColor = System.Drawing.Color.White;
            this.txtPresupuesto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtPresupuesto.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtPresupuesto.BordeRadio = 0;
            this.txtPresupuesto.BordeTamaño = 2;
            this.txtPresupuesto.Contraseña = false;
            this.txtPresupuesto.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.txtPresupuesto.Location = new System.Drawing.Point(55, 58);
            this.txtPresupuesto.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtPresupuesto.MarcadorPosicionTexto = "Introduce el presupuesto a buscar";
            this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPresupuesto.Multilinea = false;
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPresupuesto.PosicionSeleccion = 0;
            this.txtPresupuesto.Size = new System.Drawing.Size(464, 30);
            this.txtPresupuesto.SubrayadoEstilo = true;
            this.txtPresupuesto.TabIndex = 11;
            this.txtPresupuesto.TamañoMaximo = 30000;
            this.txtPresupuesto.Texto = "";
            this.txtPresupuesto._TextChanged += new System.EventHandler(this.txtPresupuesto__TextChanged);
            // 
            // BuscarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.pnlDgvBuscarPaciente);
            this.Controls.Add(this.cbFiltros);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.pnlCabecera);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarPresupuesto";
            this.Text = "BuscarPresupuesto";
            this.Load += new System.EventHandler(this.BuscarPresupuesto_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRedimensionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlDgvBuscarPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnRedimensionar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlDgvBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvPresupuestos;
        private ControlesPersonalizados.ComboBoxPersonalizado cbFiltros;
        private TextboxPersonalizado txtPresupuesto;
    }
}