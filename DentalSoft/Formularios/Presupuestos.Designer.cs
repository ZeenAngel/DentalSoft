namespace DentalSoft.Formularios
{
    partial class Presupuestos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presupuestos));
            this.rvPresupuesto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFiltroPaciente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiltroPresupuesto = new System.Windows.Forms.Label();
            this.lvPresupuestos = new System.Windows.Forms.ListView();
            this.lblErrorFactura = new System.Windows.Forms.Label();
            this.lblErrorPaciente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevoPresupuesto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnFiltroPresupuesto = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.txtFiltroPresupuesto = new DentalSoft.TextboxPersonalizado();
            this.btnTodos = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.btnFiltrarPaciente = new DentalSoft.ControlesPersonalizados.BotonPersonalizado();
            this.mcFiltrarFecha = new DentalSoft.ControlesPersonalizados.SelectorFecha();
            this.txtFiltroPaciente = new DentalSoft.TextboxPersonalizado();
            this.dataSetPresupuestos = new DentalSoft.Datos.DataSetPresupuestos();
            this.detallePresupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePresupuestoTableAdapter = new DentalSoft.Datos.DataSetPresupuestosTableAdapters.DetallePresupuestoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePresupuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvPresupuesto
            // 
            reportDataSource1.Name = "DataSetPresupuesto";
            reportDataSource1.Value = this.detallePresupuestoBindingSource;
            this.rvPresupuesto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPresupuesto.LocalReport.ReportEmbeddedResource = "DentalSoft.Informes.InformePresupuestos.rdlc";
            this.rvPresupuesto.Location = new System.Drawing.Point(25, 112);
            this.rvPresupuesto.Name = "rvPresupuesto";
            this.rvPresupuesto.ServerReport.BearerToken = null;
            this.rvPresupuesto.Size = new System.Drawing.Size(794, 583);
            this.rvPresupuesto.TabIndex = 0;
            // 
            // lblFiltroPaciente
            // 
            this.lblFiltroPaciente.AutoSize = true;
            this.lblFiltroPaciente.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltroPaciente.Location = new System.Drawing.Point(834, 257);
            this.lblFiltroPaciente.Name = "lblFiltroPaciente";
            this.lblFiltroPaciente.Size = new System.Drawing.Size(141, 19);
            this.lblFiltroPaciente.TabIndex = 83;
            this.lblFiltroPaciente.Text = "Filtrar por paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.Location = new System.Drawing.Point(834, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 84;
            this.label2.Text = "Filtrar por fecha";
            // 
            // lblFiltroPresupuesto
            // 
            this.lblFiltroPresupuesto.AutoSize = true;
            this.lblFiltroPresupuesto.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblFiltroPresupuesto.Location = new System.Drawing.Point(834, 140);
            this.lblFiltroPresupuesto.Name = "lblFiltroPresupuesto";
            this.lblFiltroPresupuesto.Size = new System.Drawing.Size(168, 19);
            this.lblFiltroPresupuesto.TabIndex = 89;
            this.lblFiltroPresupuesto.Text = "Filtrar por presupuesto";
            // 
            // lvPresupuestos
            // 
            this.lvPresupuestos.HideSelection = false;
            this.lvPresupuestos.Location = new System.Drawing.Point(207, 112);
            this.lvPresupuestos.Name = "lvPresupuestos";
            this.lvPresupuestos.Size = new System.Drawing.Size(462, 580);
            this.lvPresupuestos.TabIndex = 1;
            this.lvPresupuestos.UseCompatibleStateImageBehavior = false;
            this.lvPresupuestos.DoubleClick += new System.EventHandler(this.lvPresupuestos_DoubleClick);
            // 
            // lblErrorFactura
            // 
            this.lblErrorFactura.AutoSize = true;
            this.lblErrorFactura.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFactura.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorFactura.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorFactura.Image")));
            this.lblErrorFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorFactura.Location = new System.Drawing.Point(835, 211);
            this.lblErrorFactura.Name = "lblErrorFactura";
            this.lblErrorFactura.Size = new System.Drawing.Size(85, 15);
            this.lblErrorFactura.TabIndex = 91;
            this.lblErrorFactura.Text = "Mensaje Error";
            this.lblErrorFactura.Visible = false;
            // 
            // lblErrorPaciente
            // 
            this.lblErrorPaciente.AutoSize = true;
            this.lblErrorPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPaciente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblErrorPaciente.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorPaciente.Image")));
            this.lblErrorPaciente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorPaciente.Location = new System.Drawing.Point(835, 327);
            this.lblErrorPaciente.Name = "lblErrorPaciente";
            this.lblErrorPaciente.Size = new System.Drawing.Size(85, 15);
            this.lblErrorPaciente.TabIndex = 87;
            this.lblErrorPaciente.Text = "Mensaje Error";
            this.lblErrorPaciente.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNuevoPresupuesto
            // 
            this.btnNuevoPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoPresupuesto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoPresupuesto.BordeRadio = 40;
            this.btnNuevoPresupuesto.BordeTamaño = 0;
            this.btnNuevoPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnNuevoPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnNuevoPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPresupuesto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnNuevoPresupuesto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuevoPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPresupuesto.Location = new System.Drawing.Point(874, 627);
            this.btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            this.btnNuevoPresupuesto.Size = new System.Drawing.Size(224, 40);
            this.btnNuevoPresupuesto.TabIndex = 30;
            this.btnNuevoPresupuesto.Text = "Crear nuevo presupuesto";
            this.btnNuevoPresupuesto.TextoColor = System.Drawing.Color.White;
            this.btnNuevoPresupuesto.UseVisualStyleBackColor = false;
            this.btnNuevoPresupuesto.Click += new System.EventHandler(this.btnNuevoPresupuesto_Click);
            // 
            // btnFiltroPresupuesto
            // 
            this.btnFiltroPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltroPresupuesto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltroPresupuesto.BordeRadio = 40;
            this.btnFiltroPresupuesto.BordeTamaño = 0;
            this.btnFiltroPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnFiltroPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnFiltroPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroPresupuesto.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnFiltroPresupuesto.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnFiltroPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnFiltroPresupuesto.Location = new System.Drawing.Point(1091, 164);
            this.btnFiltroPresupuesto.Name = "btnFiltroPresupuesto";
            this.btnFiltroPresupuesto.Size = new System.Drawing.Size(39, 40);
            this.btnFiltroPresupuesto.TabIndex = 5;
            this.btnFiltroPresupuesto.Text = "Ir";
            this.btnFiltroPresupuesto.TextoColor = System.Drawing.Color.White;
            this.btnFiltroPresupuesto.UseVisualStyleBackColor = false;
            this.btnFiltroPresupuesto.Click += new System.EventHandler(this.btnFiltroPresupuesto_Click);
            // 
            // txtFiltroPresupuesto
            // 
            this.txtFiltroPresupuesto.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltroPresupuesto.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtFiltroPresupuesto.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtFiltroPresupuesto.BordeRadio = 0;
            this.txtFiltroPresupuesto.BordeTamaño = 2;
            this.txtFiltroPresupuesto.Contraseña = false;
            this.txtFiltroPresupuesto.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroPresupuesto.Location = new System.Drawing.Point(838, 169);
            this.txtFiltroPresupuesto.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtFiltroPresupuesto.MarcadorPosicionTexto = "Introduce el número de presupuesto";
            this.txtFiltroPresupuesto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroPresupuesto.Multilinea = false;
            this.txtFiltroPresupuesto.Name = "txtFiltroPresupuesto";
            this.txtFiltroPresupuesto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltroPresupuesto.Size = new System.Drawing.Size(250, 30);
            this.txtFiltroPresupuesto.SubrayadoEstilo = true;
            this.txtFiltroPresupuesto.TabIndex = 0;
            this.txtFiltroPresupuesto.Texto = "";
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodos.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodos.BordeRadio = 40;
            this.btnTodos.BordeTamaño = 0;
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.btnTodos.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.Location = new System.Drawing.Point(874, 564);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(224, 40);
            this.btnTodos.TabIndex = 25;
            this.btnTodos.Text = "Ver todos";
            this.btnTodos.TextoColor = System.Drawing.Color.White;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // btnFiltrarPaciente
            // 
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
            this.btnFiltrarPaciente.Location = new System.Drawing.Point(1091, 279);
            this.btnFiltrarPaciente.Name = "btnFiltrarPaciente";
            this.btnFiltrarPaciente.Size = new System.Drawing.Size(39, 40);
            this.btnFiltrarPaciente.TabIndex = 15;
            this.btnFiltrarPaciente.Text = "Ir";
            this.btnFiltrarPaciente.TextoColor = System.Drawing.Color.White;
            this.btnFiltrarPaciente.UseVisualStyleBackColor = false;
            this.btnFiltrarPaciente.Click += new System.EventHandler(this.btnFiltrarPaciente_Click);
            // 
            // mcFiltrarFecha
            // 
            this.mcFiltrarFecha.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltrarFecha.BordeTamaño = 0;
            this.mcFiltrarFecha.FondoColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.mcFiltrarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.mcFiltrarFecha.IsDesplegado = false;
            this.mcFiltrarFecha.Location = new System.Drawing.Point(838, 396);
            this.mcFiltrarFecha.MinDate = new System.DateTime(2022, 11, 8, 12, 50, 6, 969);
            this.mcFiltrarFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.mcFiltrarFecha.Name = "mcFiltrarFecha";
            this.mcFiltrarFecha.Size = new System.Drawing.Size(292, 35);
            this.mcFiltrarFecha.TabIndex = 20;
            this.mcFiltrarFecha.TextoColor = System.Drawing.Color.White;
            this.mcFiltrarFecha.Value = new System.DateTime(2022, 11, 8, 12, 50, 6, 969);
            this.mcFiltrarFecha.CloseUp += new System.EventHandler(this.mcFiltrarFecha_CloseUp);
            // 
            // txtFiltroPaciente
            // 
            this.txtFiltroPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltroPaciente.BordeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(196)))));
            this.txtFiltroPaciente.BordeColorFoco = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.txtFiltroPaciente.BordeRadio = 0;
            this.txtFiltroPaciente.BordeTamaño = 2;
            this.txtFiltroPaciente.Contraseña = false;
            this.txtFiltroPaciente.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroPaciente.Location = new System.Drawing.Point(838, 285);
            this.txtFiltroPaciente.MarcadorPosicionColor = System.Drawing.Color.DarkGray;
            this.txtFiltroPaciente.MarcadorPosicionTexto = "Introduce el Dni del paciente";
            this.txtFiltroPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroPaciente.Multilinea = false;
            this.txtFiltroPaciente.Name = "txtFiltroPaciente";
            this.txtFiltroPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltroPaciente.Size = new System.Drawing.Size(250, 30);
            this.txtFiltroPaciente.SubrayadoEstilo = true;
            this.txtFiltroPaciente.TabIndex = 10;
            this.txtFiltroPaciente.Texto = "";
            // 
            // dataSetPresupuestos
            // 
            this.dataSetPresupuestos.DataSetName = "DataSetPresupuestos";
            this.dataSetPresupuestos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallePresupuestoBindingSource
            // 
            this.detallePresupuestoBindingSource.DataMember = "DetallePresupuesto";
            this.detallePresupuestoBindingSource.DataSource = this.dataSetPresupuestos;
            // 
            // detallePresupuestoTableAdapter
            // 
            this.detallePresupuestoTableAdapter.ClearBeforeFill = true;
            // 
            // Presupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.rvPresupuesto);
            this.Controls.Add(this.lvPresupuestos);
            this.Controls.Add(this.btnNuevoPresupuesto);
            this.Controls.Add(this.lblErrorFactura);
            this.Controls.Add(this.btnFiltroPresupuesto);
            this.Controls.Add(this.lblFiltroPresupuesto);
            this.Controls.Add(this.txtFiltroPresupuesto);
            this.Controls.Add(this.lblErrorPaciente);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrarPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFiltroPaciente);
            this.Controls.Add(this.mcFiltrarFecha);
            this.Controls.Add(this.txtFiltroPaciente);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Roboto", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Presupuestos";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePresupuestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private TextboxPersonalizado txtFiltroPaciente;
        private ControlesPersonalizados.SelectorFecha mcFiltrarFecha;
        private System.Windows.Forms.Label lblFiltroPaciente;
        private System.Windows.Forms.Label label2;
        private ControlesPersonalizados.BotonPersonalizado btnFiltrarPaciente;
        private ControlesPersonalizados.BotonPersonalizado btnTodos;
        private System.Windows.Forms.Label lblErrorPaciente;
        private System.Windows.Forms.Label lblErrorFactura;
        private ControlesPersonalizados.BotonPersonalizado btnFiltroPresupuesto;
        private System.Windows.Forms.Label lblFiltroPresupuesto;
        private TextboxPersonalizado txtFiltroPresupuesto;
        private Microsoft.Reporting.WinForms.ReportViewer rvPresupuesto;
        private ControlesPersonalizados.BotonPersonalizado btnNuevoPresupuesto;
        private System.Windows.Forms.ListView lvPresupuestos;
        private Datos.DataSetPresupuestos dataSetPresupuestos;
        private System.Windows.Forms.BindingSource detallePresupuestoBindingSource;
        private Datos.DataSetPresupuestosTableAdapters.DetallePresupuestoTableAdapter detallePresupuestoTableAdapter;
    }
}