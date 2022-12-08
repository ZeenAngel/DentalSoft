namespace DentalSoft.Formularios
{
    partial class GestionarAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarAlmacen));
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.btnEliminarAlmacen = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEditarAlmacen = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevoAlmacen = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.lblFiltrosPacientes = new System.Windows.Forms.Label();
            this.pnlDgvBuscarPaciente = new System.Windows.Forms.Panel();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.cbFiltros = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.txtAlmacen = new DentalSoft.TextboxPersonalizado();
            this.lblErrorAlmacen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.pnlDgvBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(25, 23);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 13;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEliminarAlmacen
            // 
            this.btnEliminarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarAlmacen.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarAlmacen.BordeRadio = 32;
            this.btnEliminarAlmacen.BordeTamaño = 0;
            this.btnEliminarAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEliminarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlmacen.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarAlmacen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlmacen.Location = new System.Drawing.Point(864, 617);
            this.btnEliminarAlmacen.Name = "btnEliminarAlmacen";
            this.btnEliminarAlmacen.Size = new System.Drawing.Size(270, 34);
            this.btnEliminarAlmacen.TabIndex = 20;
            this.btnEliminarAlmacen.Text = "Eliminar Almacen";
            this.btnEliminarAlmacen.TextoColor = System.Drawing.Color.White;
            this.btnEliminarAlmacen.UseVisualStyleBackColor = false;
            this.btnEliminarAlmacen.Click += new System.EventHandler(this.btnEliminarAlmacen_Click);
            // 
            // btnEditarAlmacen
            // 
            this.btnEditarAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarAlmacen.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarAlmacen.BordeRadio = 32;
            this.btnEditarAlmacen.BordeTamaño = 0;
            this.btnEditarAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnEditarAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEditarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAlmacen.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarAlmacen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnEditarAlmacen.Location = new System.Drawing.Point(454, 617);
            this.btnEditarAlmacen.Name = "btnEditarAlmacen";
            this.btnEditarAlmacen.Size = new System.Drawing.Size(270, 34);
            this.btnEditarAlmacen.TabIndex = 15;
            this.btnEditarAlmacen.Text = "Editar Almacen";
            this.btnEditarAlmacen.TextoColor = System.Drawing.Color.White;
            this.btnEditarAlmacen.UseVisualStyleBackColor = false;
            this.btnEditarAlmacen.Click += new System.EventHandler(this.btnEditarAlmacen_Click);
            // 
            // btnNuevoAlmacen
            // 
            this.btnNuevoAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoAlmacen.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevoAlmacen.BordeRadio = 32;
            this.btnNuevoAlmacen.BordeTamaño = 0;
            this.btnNuevoAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAlmacen.FlatAppearance.BorderSize = 0;
            this.btnNuevoAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevoAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAlmacen.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoAlmacen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAlmacen.Location = new System.Drawing.Point(25, 617);
            this.btnNuevoAlmacen.Name = "btnNuevoAlmacen";
            this.btnNuevoAlmacen.Size = new System.Drawing.Size(270, 34);
            this.btnNuevoAlmacen.TabIndex = 10;
            this.btnNuevoAlmacen.Text = "Nuevo Almacen";
            this.btnNuevoAlmacen.TextoColor = System.Drawing.Color.White;
            this.btnNuevoAlmacen.UseVisualStyleBackColor = false;
            this.btnNuevoAlmacen.Click += new System.EventHandler(this.btnNuevoAlmacen_Click);
            // 
            // lblFiltrosPacientes
            // 
            this.lblFiltrosPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrosPacientes.AutoSize = true;
            this.lblFiltrosPacientes.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltrosPacientes.ForeColor = System.Drawing.Color.Black;
            this.lblFiltrosPacientes.Location = new System.Drawing.Point(877, 117);
            this.lblFiltrosPacientes.Name = "lblFiltrosPacientes";
            this.lblFiltrosPacientes.Size = new System.Drawing.Size(50, 19);
            this.lblFiltrosPacientes.TabIndex = 52;
            this.lblFiltrosPacientes.Text = "Filtrar";
            // 
            // pnlDgvBuscarPaciente
            // 
            this.pnlDgvBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBuscarPaciente.Controls.Add(this.dgvAlmacen);
            this.pnlDgvBuscarPaciente.Location = new System.Drawing.Point(25, 184);
            this.pnlDgvBuscarPaciente.Name = "pnlDgvBuscarPaciente";
            this.pnlDgvBuscarPaciente.Size = new System.Drawing.Size(1109, 384);
            this.pnlDgvBuscarPaciente.TabIndex = 51;
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlmacen.Location = new System.Drawing.Point(0, 0);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.Size = new System.Drawing.Size(1109, 384);
            this.dgvAlmacen.TabIndex = 0;
            // 
            // cbFiltros
            // 
            this.cbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.BordeTamaño = 1;
            this.cbFiltros.ColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltros.ColorIcono = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.cbFiltros.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbFiltros.EstiloListaDesplegable = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFiltros.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltros.ForeColor = System.Drawing.Color.Black;
            this.cbFiltros.ListaColorFondo = System.Drawing.Color.WhiteSmoke;
            this.cbFiltros.ListColorTexto = System.Drawing.Color.Black;
            this.cbFiltros.Location = new System.Drawing.Point(934, 111);
            this.cbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Padding = new System.Windows.Forms.Padding(1);
            this.cbFiltros.Size = new System.Drawing.Size(200, 30);
            this.cbFiltros.TabIndex = 5;
            this.cbFiltros.Textos = "";
            this.cbFiltros.OnSelectedIndexChanged += new System.EventHandler(this.cbFiltros_OnSelectedIndexChanged);
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.BackColor = System.Drawing.Color.White;
            this.txtAlmacen.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtAlmacen.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtAlmacen.BordeRadio = 0;
            this.txtAlmacen.BordeTamaño = 2;
            this.txtAlmacen.Contraseña = false;
            this.txtAlmacen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacen.ForeColor = System.Drawing.Color.Black;
            this.txtAlmacen.Location = new System.Drawing.Point(25, 111);
            this.txtAlmacen.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtAlmacen.MarcadorPosicionTexto = "Introduce el almacen a buscar";
            this.txtAlmacen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAlmacen.Multilinea = false;
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAlmacen.Size = new System.Drawing.Size(591, 34);
            this.txtAlmacen.SubrayadoEstilo = true;
            this.txtAlmacen.TabIndex = 0;
            this.txtAlmacen.Texto = "";
            this.txtAlmacen._TextChanged += new System.EventHandler(this.txtAlmacen__TextChanged);
            // 
            // lblErrorAlmacen
            // 
            this.lblErrorAlmacen.AutoSize = true;
            this.lblErrorAlmacen.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblErrorAlmacen.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorAlmacen.Image")));
            this.lblErrorAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorAlmacen.Location = new System.Drawing.Point(318, 571);
            this.lblErrorAlmacen.Name = "lblErrorAlmacen";
            this.lblErrorAlmacen.Size = new System.Drawing.Size(106, 19);
            this.lblErrorAlmacen.TabIndex = 56;
            this.lblErrorAlmacen.Text = "Mensaje Error";
            this.lblErrorAlmacen.Visible = false;
            // 
            // GestionarAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.lblErrorAlmacen);
            this.Controls.Add(this.btnEliminarAlmacen);
            this.Controls.Add(this.btnEditarAlmacen);
            this.Controls.Add(this.btnNuevoAlmacen);
            this.Controls.Add(this.lblFiltrosPacientes);
            this.Controls.Add(this.pnlDgvBuscarPaciente);
            this.Controls.Add(this.cbFiltros);
            this.Controls.Add(this.txtAlmacen);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarAlmacen";
            this.Text = "GestionarAlmacen";
            this.Load += new System.EventHandler(this.GestionarAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.pnlDgvBuscarPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private ControlesPersonalizados.BotonPersonalizado btnEliminarAlmacen;
        private ControlesPersonalizados.BotonPersonalizado btnEditarAlmacen;
        private ControlesPersonalizados.BotonPersonalizado btnNuevoAlmacen;
        private System.Windows.Forms.Label lblFiltrosPacientes;
        private System.Windows.Forms.Panel pnlDgvBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private ControlesPersonalizados.ComboBoxPersonalizado cbFiltros;
        private TextboxPersonalizado txtAlmacen;
        private System.Windows.Forms.Label lblErrorAlmacen;
    }
}