namespace DentalSoft.Formularios
{
    partial class Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen));
            this.lblFiltrosPacientes = new System.Windows.Forms.Label();
            this.pnlDgvBuscarPaciente = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnGestionarAlmacenes = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEliminarProducto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnEditarProducto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevoProducto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.cbFiltros = new DentalSoft.ControlesPersonalizados.ComboBoxPersonalizado();
            this.txtProducto = new DentalSoft.TextboxPersonalizado();
            this.lblErrorCaducado = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.btnInventario = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.pnlDgvBuscarPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrosPacientes
            // 
            this.lblFiltrosPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrosPacientes.AutoSize = true;
            this.lblFiltrosPacientes.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltrosPacientes.ForeColor = System.Drawing.Color.Black;
            this.lblFiltrosPacientes.Location = new System.Drawing.Point(807, 111);
            this.lblFiltrosPacientes.Name = "lblFiltrosPacientes";
            this.lblFiltrosPacientes.Size = new System.Drawing.Size(50, 19);
            this.lblFiltrosPacientes.TabIndex = 32;
            this.lblFiltrosPacientes.Text = "Filtrar";
            // 
            // pnlDgvBuscarPaciente
            // 
            this.pnlDgvBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgvBuscarPaciente.Controls.Add(this.dgvProductos);
            this.pnlDgvBuscarPaciente.Location = new System.Drawing.Point(98, 175);
            this.pnlDgvBuscarPaciente.Name = "pnlDgvBuscarPaciente";
            this.pnlDgvBuscarPaciente.Size = new System.Drawing.Size(966, 335);
            this.pnlDgvBuscarPaciente.TabIndex = 31;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(966, 335);
            this.dgvProductos.TabIndex = 0;
            // 
            // btnGestionarAlmacenes
            // 
            this.btnGestionarAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestionarAlmacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGestionarAlmacenes.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGestionarAlmacenes.BordeRadio = 32;
            this.btnGestionarAlmacenes.BordeTamaño = 0;
            this.btnGestionarAlmacenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarAlmacenes.FlatAppearance.BorderSize = 0;
            this.btnGestionarAlmacenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnGestionarAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarAlmacenes.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnGestionarAlmacenes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarAlmacenes.ForeColor = System.Drawing.Color.White;
            this.btnGestionarAlmacenes.Location = new System.Drawing.Point(98, 638);
            this.btnGestionarAlmacenes.Name = "btnGestionarAlmacenes";
            this.btnGestionarAlmacenes.Size = new System.Drawing.Size(430, 34);
            this.btnGestionarAlmacenes.TabIndex = 36;
            this.btnGestionarAlmacenes.Text = "Gestionar Almacenes";
            this.btnGestionarAlmacenes.TextoColor = System.Drawing.Color.White;
            this.btnGestionarAlmacenes.UseVisualStyleBackColor = false;
            this.btnGestionarAlmacenes.Click += new System.EventHandler(this.btnGestionarAlmacenes_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarProducto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarProducto.BordeRadio = 32;
            this.btnEliminarProducto.BordeTamaño = 0;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEliminarProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(794, 561);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(270, 34);
            this.btnEliminarProducto.TabIndex = 35;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.TextoColor = System.Drawing.Color.White;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarProducto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarProducto.BordeRadio = 32;
            this.btnEditarProducto.BordeTamaño = 0;
            this.btnEditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProducto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnEditarProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEditarProducto.Location = new System.Drawing.Point(438, 561);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(270, 34);
            this.btnEditarProducto.TabIndex = 34;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.TextoColor = System.Drawing.Color.White;
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoProducto.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevoProducto.BordeRadio = 32;
            this.btnNuevoProducto.BordeTamaño = 0;
            this.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Location = new System.Drawing.Point(98, 561);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(270, 34);
            this.btnNuevoProducto.TabIndex = 33;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.TextoColor = System.Drawing.Color.White;
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
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
            this.cbFiltros.Location = new System.Drawing.Point(864, 105);
            this.cbFiltros.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Padding = new System.Windows.Forms.Padding(1);
            this.cbFiltros.Size = new System.Drawing.Size(200, 30);
            this.cbFiltros.TabIndex = 30;
            this.cbFiltros.Textos = "";
            this.cbFiltros.OnSelectedIndexChanged += new System.EventHandler(this.cbFiltros_OnSelectedIndexChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.White;
            this.txtProducto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtProducto.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtProducto.BordeRadio = 0;
            this.txtProducto.BordeTamaño = 2;
            this.txtProducto.Contraseña = false;
            this.txtProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Black;
            this.txtProducto.Location = new System.Drawing.Point(98, 102);
            this.txtProducto.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtProducto.MarcadorPosicionTexto = "Introduce el producto a buscar";
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProducto.Multilinea = false;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProducto.Size = new System.Drawing.Size(591, 34);
            this.txtProducto.SubrayadoEstilo = true;
            this.txtProducto.TabIndex = 29;
            this.txtProducto.Texto = "";
            this.txtProducto._TextChanged += new System.EventHandler(this.txtProducto__TextChanged);
            // 
            // lblErrorCaducado
            // 
            this.lblErrorCaducado.AutoSize = true;
            this.lblErrorCaducado.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblErrorCaducado.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorCaducado.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorCaducado.Image")));
            this.lblErrorCaducado.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorCaducado.Location = new System.Drawing.Point(279, 525);
            this.lblErrorCaducado.Name = "lblErrorCaducado";
            this.lblErrorCaducado.Size = new System.Drawing.Size(106, 19);
            this.lblErrorCaducado.TabIndex = 48;
            this.lblErrorCaducado.Text = "Mensaje Error";
            this.lblErrorCaducado.Visible = false;
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
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnInventario.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnInventario.BordeRadio = 32;
            this.btnInventario.BordeTamaño = 0;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnInventario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(634, 638);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(430, 34);
            this.btnInventario.TabIndex = 49;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextoColor = System.Drawing.Color.White;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.lblErrorCaducado);
            this.Controls.Add(this.btnGestionarAlmacenes);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.lblFiltrosPacientes);
            this.Controls.Add(this.pnlDgvBuscarPaciente);
            this.Controls.Add(this.cbFiltros);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.pnlDgvBuscarPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private ControlesPersonalizados.BotonPersonalizado btnGestionarAlmacenes;
        private ControlesPersonalizados.BotonPersonalizado btnEliminarProducto;
        private ControlesPersonalizados.BotonPersonalizado btnEditarProducto;
        private ControlesPersonalizados.BotonPersonalizado btnNuevoProducto;
        private System.Windows.Forms.Label lblFiltrosPacientes;
        private System.Windows.Forms.Panel pnlDgvBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvProductos;
        private ControlesPersonalizados.ComboBoxPersonalizado cbFiltros;
        private TextboxPersonalizado txtProducto;
        private System.Windows.Forms.Label lblErrorCaducado;
        private ControlesPersonalizados.BotonPersonalizado btnInventario;
    }
}