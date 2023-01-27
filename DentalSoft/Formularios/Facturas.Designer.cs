namespace DentalSoft.Formularios
{
    partial class Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFactura = new DentalSoft.Datos.DataSetFactura();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.lblFiltroFactura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiltroPaciente = new System.Windows.Forms.Label();
            this.lblErrorFactura = new System.Windows.Forms.Label();
            this.lblErrorPaciente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rvFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturaTableAdapter = new DentalSoft.Datos.DataSetFacturaTableAdapters.FacturaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTodas = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtFiltroPaciente = new DentalSoft.TextboxPersonalizado();
            this.mcFiltrarFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.btnFiltroFactura = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnFiltrarPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtFiltroFactura = new DentalSoft.TextboxPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.dataSetFactura;
            // 
            // dataSetFactura
            // 
            this.dataSetFactura.DataSetName = "DataSetFactura";
            this.dataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lvFacturas
            // 
            this.lvFacturas.HideSelection = false;
            this.lvFacturas.Location = new System.Drawing.Point(212, 110);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(462, 580);
            this.lvFacturas.TabIndex = 94;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.DoubleClick += new System.EventHandler(this.lvFacturas_DoubleClick);
            // 
            // lblFiltroFactura
            // 
            this.lblFiltroFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltroFactura.AutoSize = true;
            this.lblFiltroFactura.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltroFactura.Location = new System.Drawing.Point(21, 13);
            this.lblFiltroFactura.Name = "lblFiltroFactura";
            this.lblFiltroFactura.Size = new System.Drawing.Size(166, 24);
            this.lblFiltroFactura.TabIndex = 105;
            this.lblFiltroFactura.Text = "Filtrar por factura";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.Location = new System.Drawing.Point(21, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "Filtrar por fecha";
            // 
            // lblFiltroPaciente
            // 
            this.lblFiltroPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltroPaciente.AutoSize = true;
            this.lblFiltroPaciente.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltroPaciente.Location = new System.Drawing.Point(21, 130);
            this.lblFiltroPaciente.Name = "lblFiltroPaciente";
            this.lblFiltroPaciente.Size = new System.Drawing.Size(179, 24);
            this.lblFiltroPaciente.TabIndex = 102;
            this.lblFiltroPaciente.Text = "Filtrar por paciente";
            // 
            // lblErrorFactura
            // 
            this.lblErrorFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorFactura.AutoSize = true;
            this.lblErrorFactura.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFactura.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorFactura.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorFactura.Image")));
            this.lblErrorFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorFactura.Location = new System.Drawing.Point(22, 84);
            this.lblErrorFactura.Name = "lblErrorFactura";
            this.lblErrorFactura.Size = new System.Drawing.Size(106, 19);
            this.lblErrorFactura.TabIndex = 106;
            this.lblErrorFactura.Text = "Mensaje Error";
            this.lblErrorFactura.Visible = false;
            // 
            // lblErrorPaciente
            // 
            this.lblErrorPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorPaciente.AutoSize = true;
            this.lblErrorPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPaciente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPaciente.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPaciente.Image")));
            this.lblErrorPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPaciente.Location = new System.Drawing.Point(22, 200);
            this.lblErrorPaciente.Name = "lblErrorPaciente";
            this.lblErrorPaciente.Size = new System.Drawing.Size(106, 19);
            this.lblErrorPaciente.TabIndex = 104;
            this.lblErrorPaciente.Text = "Mensaje Error";
            this.lblErrorPaciente.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rvFacturas
            // 
            this.rvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.facturaBindingSource;
            this.rvFacturas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFacturas.LocalReport.ReportEmbeddedResource = "DentalSoft.Informes.InformeFacturas.rdlc";
            this.rvFacturas.Location = new System.Drawing.Point(12, 107);
            this.rvFacturas.Name = "rvFacturas";
            this.rvFacturas.ServerReport.BearerToken = null;
            this.rvFacturas.Size = new System.Drawing.Size(794, 583);
            this.rvFacturas.TabIndex = 107;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnTodas);
            this.panel1.Controls.Add(this.txtFiltroPaciente);
            this.panel1.Controls.Add(this.mcFiltrarFecha);
            this.panel1.Controls.Add(this.lblErrorFactura);
            this.panel1.Controls.Add(this.lblFiltroPaciente);
            this.panel1.Controls.Add(this.btnFiltroFactura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFiltroFactura);
            this.panel1.Controls.Add(this.btnFiltrarPaciente);
            this.panel1.Controls.Add(this.txtFiltroFactura);
            this.panel1.Controls.Add(this.lblErrorPaciente);
            this.panel1.Location = new System.Drawing.Point(811, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 510);
            this.panel1.TabIndex = 108;
            // 
            // btnTodas
            // 
            this.btnTodas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodas.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodas.BordeRadio = 40;
            this.btnTodas.BordeTamaño = 0;
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodas.FlatAppearance.BorderSize = 0;
            this.btnTodas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodas.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodas.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnTodas.ForeColor = System.Drawing.Color.White;
            this.btnTodas.Location = new System.Drawing.Point(62, 467);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(224, 40);
            this.btnTodas.TabIndex = 30;
            this.btnTodas.Text = "Ver todas";
            this.btnTodas.TextoColor = System.Drawing.Color.White;
            this.btnTodas.UseVisualStyleBackColor = false;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // txtFiltroPaciente
            // 
            this.txtFiltroPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltroPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltroPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtFiltroPaciente.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtFiltroPaciente.BordeRadio = 0;
            this.txtFiltroPaciente.BordeTamaño = 2;
            this.txtFiltroPaciente.Contraseña = false;
            this.txtFiltroPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroPaciente.Location = new System.Drawing.Point(25, 158);
            this.txtFiltroPaciente.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtFiltroPaciente.MarcadorPosicionTexto = "Introduce el Dni del paciente";
            this.txtFiltroPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroPaciente.Multilinea = false;
            this.txtFiltroPaciente.Name = "txtFiltroPaciente";
            this.txtFiltroPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltroPaciente.PosicionSeleccion = 0;
            this.txtFiltroPaciente.Size = new System.Drawing.Size(250, 34);
            this.txtFiltroPaciente.SubrayadoEstilo = true;
            this.txtFiltroPaciente.TabIndex = 15;
            this.txtFiltroPaciente.TamañoMaximo = 30000;
            this.txtFiltroPaciente.Texto = "";
            // 
            // mcFiltrarFecha
            // 
            this.mcFiltrarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mcFiltrarFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltrarFecha.BordeTamaño = 0;
            this.mcFiltrarFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.mcFiltrarFecha.IsDesplegado = false;
            this.mcFiltrarFecha.Location = new System.Drawing.Point(25, 269);
            this.mcFiltrarFecha.MinDate = new System.DateTime(2022, 11, 8, 12, 50, 6, 969);
            this.mcFiltrarFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFiltrarFecha.Name = "mcFiltrarFecha";
            this.mcFiltrarFecha.Size = new System.Drawing.Size(292, 35);
            this.mcFiltrarFecha.TabIndex = 25;
            this.mcFiltrarFecha.TextoColor = System.Drawing.Color.White;
            this.mcFiltrarFecha.Value = new System.DateTime(2022, 11, 8, 12, 50, 6, 969);
            this.mcFiltrarFecha.CloseUp += new System.EventHandler(this.mcFiltrarFecha_CloseUp);
            // 
            // btnFiltroFactura
            // 
            this.btnFiltroFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltroFactura.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltroFactura.BordeRadio = 40;
            this.btnFiltroFactura.BordeTamaño = 0;
            this.btnFiltroFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroFactura.FlatAppearance.BorderSize = 0;
            this.btnFiltroFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnFiltroFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroFactura.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltroFactura.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnFiltroFactura.ForeColor = System.Drawing.Color.White;
            this.btnFiltroFactura.Location = new System.Drawing.Point(287, 29);
            this.btnFiltroFactura.Name = "btnFiltroFactura";
            this.btnFiltroFactura.Size = new System.Drawing.Size(39, 40);
            this.btnFiltroFactura.TabIndex = 10;
            this.btnFiltroFactura.Text = "Ir";
            this.btnFiltroFactura.TextoColor = System.Drawing.Color.White;
            this.btnFiltroFactura.UseVisualStyleBackColor = false;
            this.btnFiltroFactura.Click += new System.EventHandler(this.btnFiltroFactura_Click);
            // 
            // btnFiltrarPaciente
            // 
            this.btnFiltrarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrarPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrarPaciente.BordeRadio = 40;
            this.btnFiltrarPaciente.BordeTamaño = 0;
            this.btnFiltrarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarPaciente.FlatAppearance.BorderSize = 0;
            this.btnFiltrarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnFiltrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPaciente.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltrarPaciente.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnFiltrarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarPaciente.Location = new System.Drawing.Point(287, 152);
            this.btnFiltrarPaciente.Name = "btnFiltrarPaciente";
            this.btnFiltrarPaciente.Size = new System.Drawing.Size(39, 40);
            this.btnFiltrarPaciente.TabIndex = 20;
            this.btnFiltrarPaciente.Text = "Ir";
            this.btnFiltrarPaciente.TextoColor = System.Drawing.Color.White;
            this.btnFiltrarPaciente.UseVisualStyleBackColor = false;
            this.btnFiltrarPaciente.Click += new System.EventHandler(this.btnFiltrarPaciente_Click);
            // 
            // txtFiltroFactura
            // 
            this.txtFiltroFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltroFactura.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltroFactura.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtFiltroFactura.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtFiltroFactura.BordeRadio = 0;
            this.txtFiltroFactura.BordeTamaño = 2;
            this.txtFiltroFactura.Contraseña = false;
            this.txtFiltroFactura.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroFactura.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroFactura.Location = new System.Drawing.Point(25, 35);
            this.txtFiltroFactura.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtFiltroFactura.MarcadorPosicionTexto = "Introduce el número de factura";
            this.txtFiltroFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroFactura.Multilinea = false;
            this.txtFiltroFactura.Name = "txtFiltroFactura";
            this.txtFiltroFactura.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltroFactura.PosicionSeleccion = 0;
            this.txtFiltroFactura.Size = new System.Drawing.Size(250, 34);
            this.txtFiltroFactura.SubrayadoEstilo = true;
            this.txtFiltroFactura.TabIndex = 5;
            this.txtFiltroFactura.TamañoMaximo = 30000;
            this.txtFiltroFactura.Texto = "";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rvFacturas);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.Label lblErrorFactura;
        private ControlesPersonalizados.BotonPersonalizado btnFiltroFactura;
        private System.Windows.Forms.Label lblFiltroFactura;
        private TextboxPersonalizado txtFiltroFactura;
        private System.Windows.Forms.Label lblErrorPaciente;
        private ControlesPersonalizados.BotonPersonalizado btnTodas;
        private ControlesPersonalizados.BotonPersonalizado btnFiltrarPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiltroPaciente;
        private ControlesPersonalizados.SelectorFecha mcFiltrarFecha;
        private TextboxPersonalizado txtFiltroPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rvFacturas;
        private Datos.DataSetFactura dataSetFactura;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private Datos.DataSetFacturaTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}