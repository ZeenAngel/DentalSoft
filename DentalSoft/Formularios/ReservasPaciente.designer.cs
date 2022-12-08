namespace DentalSoft
{
    partial class ReservasPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservasPaciente));
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mcFiltroFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDgv.Controls.Add(this.dgvReservas);
            this.pnlDgv.Location = new System.Drawing.Point(40, 199);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(1202, 487);
            this.pnlDgv.TabIndex = 77;
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.Location = new System.Drawing.Point(0, 0);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(1202, 487);
            this.dgvReservas.TabIndex = 0;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblFiltrar.Location = new System.Drawing.Point(372, 129);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(144, 23);
            this.lblFiltrar.TabIndex = 79;
            this.lblFiltrar.Text = "Filtrar por fecha";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mcFiltroFecha
            // 
            this.mcFiltroFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltroFecha.BordeTamaño = 0;
            this.mcFiltroFecha.CalendarFont = new System.Drawing.Font("Roboto", 9.5F);
            this.mcFiltroFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.mcFiltroFecha.IsDesplegado = false;
            this.mcFiltroFecha.Location = new System.Drawing.Point(578, 123);
            this.mcFiltroFecha.MinDate = new System.DateTime(2022, 10, 22, 12, 5, 54, 859);
            this.mcFiltroFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFiltroFecha.Name = "mcFiltroFecha";
            this.mcFiltroFecha.Size = new System.Drawing.Size(252, 35);
            this.mcFiltroFecha.TabIndex = 0;
            this.mcFiltroFecha.TextoColor = System.Drawing.Color.White;
            this.mcFiltroFecha.Value = new System.DateTime(2022, 10, 23, 17, 7, 12, 419);
            this.mcFiltroFecha.CloseUp += new System.EventHandler(this.mcFiltroFecha_CloseUp);
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
            this.btnAtras.TabIndex = 76;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ReservasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1275, 715);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.mcFiltroFecha);
            this.Controls.Add(this.pnlDgv);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReservasPaciente";
            this.Text = "ReservasPaciente";
            this.Load += new System.EventHandler(this.ReservasPaciente_Load);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.Panel pnlDgv;
        private ControlesPersonalizados.SelectorFecha mcFiltroFecha;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}