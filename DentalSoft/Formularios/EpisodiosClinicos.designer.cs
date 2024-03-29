﻿namespace DentalSoft.Formularios
{
    partial class EpisodiosClinicos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpisodiosClinicos));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.episodioclinicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEpisodioClinico = new DentalSoft.Datos.DataSetEpisodioClinico();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.episodio_clinicoTableAdapter = new DentalSoft.Datos.DataSetEpisodioClinicoTableAdapters.episodio_clinicoTableAdapter();
            this.btnFiltrarTodos = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.mcFiltrarFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.episodioclinicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEpisodioClinico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // episodioclinicoBindingSource
            // 
            this.episodioclinicoBindingSource.DataMember = "episodio_clinico";
            this.episodioclinicoBindingSource.DataSource = this.dataSetEpisodioClinico;
            // 
            // dataSetEpisodioClinico
            // 
            this.dataSetEpisodioClinico.DataSetName = "DataSetEpisodioClinico";
            this.dataSetEpisodioClinico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAtras
            // 
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(40, 28);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 78;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.reportViewer1);
            this.pnlContenedor.Location = new System.Drawing.Point(40, 104);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(794, 577);
            this.pnlContenedor.TabIndex = 79;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            reportDataSource1.Name = "DataSetEpisodiosCompletos";
            reportDataSource1.Value = this.episodioclinicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentalSoft.Informes.InformeEpisodiosCompletos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Roboto", 14F);
            this.lblFiltrar.Location = new System.Drawing.Point(26, 22);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(188, 29);
            this.lblFiltrar.TabIndex = 82;
            this.lblFiltrar.Text = "Filtrar por fecha:";
            // 
            // episodio_clinicoTableAdapter
            // 
            this.episodio_clinicoTableAdapter.ClearBeforeFill = true;
            // 
            // btnFiltrarTodos
            // 
            this.btnFiltrarTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrarTodos.BordeColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltrarTodos.BordeRadio = 40;
            this.btnFiltrarTodos.BordeTamaño = 0;
            this.btnFiltrarTodos.FlatAppearance.BorderSize = 0;
            this.btnFiltrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnFiltrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarTodos.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrarTodos.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnFiltrarTodos.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarTodos.Location = new System.Drawing.Point(84, 233);
            this.btnFiltrarTodos.Name = "btnFiltrarTodos";
            this.btnFiltrarTodos.Size = new System.Drawing.Size(150, 40);
            this.btnFiltrarTodos.TabIndex = 5;
            this.btnFiltrarTodos.Text = "Ver Todos";
            this.btnFiltrarTodos.TextoColor = System.Drawing.Color.White;
            this.btnFiltrarTodos.UseVisualStyleBackColor = false;
            this.btnFiltrarTodos.Click += new System.EventHandler(this.btnFiltrarTodos_Click);
            // 
            // mcFiltrarFecha
            // 
            this.mcFiltrarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcFiltrarFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltrarFecha.BordeTamaño = 0;
            this.mcFiltrarFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.mcFiltrarFecha.IsDesplegado = false;
            this.mcFiltrarFecha.Location = new System.Drawing.Point(30, 62);
            this.mcFiltrarFecha.MinDate = new System.DateTime(2000, 1, 1, 13, 26, 0, 0);
            this.mcFiltrarFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFiltrarFecha.Name = "mcFiltrarFecha";
            this.mcFiltrarFecha.Size = new System.Drawing.Size(261, 35);
            this.mcFiltrarFecha.TabIndex = 0;
            this.mcFiltrarFecha.TextoColor = System.Drawing.Color.White;
            this.mcFiltrarFecha.Value = new System.DateTime(2022, 10, 29, 13, 46, 1, 999);
            this.mcFiltrarFecha.CloseUp += new System.EventHandler(this.mcFiltrarFecha_CloseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Controls.Add(this.mcFiltrarFecha);
            this.panel1.Controls.Add(this.btnFiltrarTodos);
            this.panel1.Location = new System.Drawing.Point(855, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 303);
            this.panel1.TabIndex = 83;
            // 
            // EpisodiosClinicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1275, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnAtras);
            this.Font = new System.Drawing.Font("Roboto", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EpisodiosClinicos";
            this.Text = "EpisodiosClinicos";
            this.Load += new System.EventHandler(this.EpisodiosClinicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.episodioclinicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEpisodioClinico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.Panel pnlContenedor;
        private ControlesPersonalizados.SelectorFecha mcFiltrarFecha;
        private ControlesPersonalizados.BotonPersonalizado btnFiltrarTodos;
        private System.Windows.Forms.Label lblFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource episodioclinicoBindingSource;
        private Datos.DataSetEpisodioClinico dataSetEpisodioClinico;
        private Datos.DataSetEpisodioClinicoTableAdapters.episodio_clinicoTableAdapter episodio_clinicoTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}