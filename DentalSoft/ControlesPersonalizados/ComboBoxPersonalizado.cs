using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;
using System.Security.Permissions;
using System.Threading;
using System.Globalization;

namespace DentalSoft.ControlesPersonalizados
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class ComboBoxPersonalizado : UserControl
    {
        // Variables
        #region -> Variables
        private Color colorFondo = Color.WhiteSmoke;
        private Color colorIcono = Color.MediumSlateBlue;
        private Color listaColorFondo = Color.FromArgb(230, 228, 245);
        private Color listColorTexto = Color.DimGray;
        private Color bordeColor = Color.MediumSlateBlue;
        private int bordeTamaño = 1;

        // Elementos del combobox
        private ComboBox combo;
        private Label lblTexto;
        private Button btnIcono;

        // Campos de eventos
        public event EventHandler OnSelectedIndexChanged; // Evento predeterminado
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        [Category("Propiedades Avanzadas ComboBox")]
        public Color ColorFondo {
            get
            {
                return colorFondo;
            }
            set { 
                colorFondo = value;
                this.lblTexto.BackColor = colorFondo;
                this.btnIcono.BackColor = colorFondo;
            }
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public Color ColorIcono {
            get
            {
                return colorIcono;
            }
            set
            {
                colorIcono = value;
                btnIcono.Invalidate(); // Redibujar icono
            } 
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public Color ListaColorFondo {
            get
            {
                return listaColorFondo;
            }
            set
            {
                listaColorFondo = value;
                this.combo.BackColor = listaColorFondo;
            } 
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public Color ListColorTexto {
            get
            {
                return listColorTexto;
            }
            set
            {
                listColorTexto = value;
                combo.ForeColor = listColorTexto;
            } 
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public Color BordeColor {
            get
            {
                return bordeColor;
            }
            set
            {
                bordeColor = value;
                base.BackColor = bordeColor; // La propiedad BackColor de la clase base se encarga de cambiar el color del borde del control
            } 
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public int BordeTamaño {
            get
            {
                return bordeTamaño;
            }
            set
            {
                bordeTamaño = value;
                this.Padding = new Padding(bordeTamaño); // El tamaño del borde lo genera la clase Padding
                AjustarTamañoCombobox();
            } 
        }

        // Propiedades sobrecargadas
        [Category("Propiedades Avanzadas ComboBox")]
        public override Color ForeColor {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                lblTexto.ForeColor = value;
            }
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public override Font Font {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                this.lblTexto.Font = value;
                this.combo.Font = value;
            }
        }

        // Propiedades nuevas
        [Category("Propiedades Avanzadas ComboBox")]
        public string Textos
        {
            get
            {
                return this.lblTexto.Text;
            }
            set
            {
                lblTexto.Text = value;
            }
        }

        [Category("Propiedades Avanzadas ComboBox")]
        public ComboBoxStyle EstiloListaDesplegable
        {
            get
            {
                return this.combo.DropDownStyle;
            }
            set
            {
                if(this.combo.DropDownStyle != ComboBoxStyle.Simple) // Comprobar que la lista sea desplegable
                    this.combo.DropDownStyle = value;
            }
        }

        // Items
        [Category("Datos Personalizados")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return combo.Items;
            }
        }

        // DataSource
        [Category("Datos Personalizados")]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get
            {
                return this.combo.DataSource;
            }
            set
            {
                this.combo.DataSource = value;
            }
        }

        // AutocompleteCustomSource
        [Category("Datos Personalizados")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return this.combo.AutoCompleteCustomSource;
            }
            set
            {
                this.combo.AutoCompleteCustomSource = value;
            }
        }

        // AutoCompleteSource
        [Category("Datos Personalizados")]
        [DefaultValue(AutoCompleteSource.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return this.combo.AutoCompleteSource;
            }
            set
            {
                this.combo.AutoCompleteSource = value;
            }
        }

        // AutocompleteMode
        [Category("Datos Personalizados")]
        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return this.combo.AutoCompleteMode;
            }
            set
            {
                this.combo.AutoCompleteMode = value;
            }
        }

        // SelectedItem
        [Category("Datos Personalizados")]
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get
            {
                return this.combo.SelectedItem;
            }
            set
            {
                this.combo.SelectedItem = value;
            }
        }

        // SelectedIndex
        [Category("Datos Personalizados")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return this.combo.SelectedIndex;
            }
            set
            {
                this.combo.SelectedIndex = value;
            }
        }
        #endregion

        // Constructor
        #region -> Constructor
        public ComboBoxPersonalizado()
        {
            this.combo = new ComboBox();
            this.lblTexto = new Label();
            this.btnIcono = new Button();
            this.SuspendLayout();

            // ComboBox: Lista desplegable
            this.combo.BackColor = this.listaColorFondo;
            this.combo.Font = new Font(this.Font.Name, 10F); 
            this.combo.ForeColor = this.listColorTexto; 
            this.combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); // Evento predeterminado
            this.combo.TextChanged += new EventHandler(ComboBox_CambioTexto); // Evento actualizar texto

            // Botón: Icono
            this.btnIcono.Dock = DockStyle.Right; // Anclado a la derecha
            this.btnIcono.FlatStyle = FlatStyle.Flat;
            this.btnIcono.FlatAppearance.BorderSize = 0; 
            btnIcono.BackColor = this.colorFondo; 
            btnIcono.Size = new Size(30, 30); 
            btnIcono.Cursor = Cursors.Hand;
            btnIcono.Click += new EventHandler(Icon_Click); // Evento abrir lista desplegable
            btnIcono.Paint += new PaintEventHandler(Icon_Paint); // Evento dibujar botón

            // Label: Texto
            this.lblTexto.Dock = DockStyle.Fill; // Rellena el espacio sobrante
            this.lblTexto.AutoSize = false;
            this.lblTexto.BackColor = colorFondo;
            this.lblTexto.TextAlign = ContentAlignment.MiddleLeft;
            this.lblTexto.Padding = new Padding(8, 0, 0, 0);
            this.lblTexto.Font = new Font(this.Font.Name, 10F);
            this.lblTexto.Click += new EventHandler(ClicK_Superficie); // Evento seleccionar combobox
            this.lblTexto.MouseEnter += new EventHandler(Superficie_MouseEnter);
            this.lblTexto.MouseLeave += new EventHandler(Superficie_MouseLeave);

            // Control de usuario
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnIcono);
            this.Controls.Add(combo);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(bordeTamaño);
            base.BackColor = bordeColor;
            this.ResumeLayout();
            AjustarTamañoCombobox();
        }    
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void AjustarTamañoCombobox()
        {
            this.combo.Width = this.lblTexto.Width;
            this.combo.Location = new Point()
            {
                X = this.Width - this.Padding.Right - combo.Width,
                Y = this.lblTexto.Bottom - combo.Height
            };
        }
        #endregion

        // Métodos sobrecargados
        #region -> Métodos sobrecargados
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AjustarTamañoCombobox();
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            // Variables para dibujar
            int iconoAncho = 14;
            int iconoAlto = 6;
            var iconoRectangulo = new Rectangle((btnIcono.Width - iconoAncho) / 2, (btnIcono.Height - iconoAlto) / 2, iconoAncho, iconoAlto);
            Graphics grafico = e.Graphics;

            // Dibujar icono de flecha
            using (GraphicsPath ruta = new GraphicsPath())
            using (Pen lapiz = new Pen(colorIcono, 2))
            {
                grafico.SmoothingMode = SmoothingMode.AntiAlias;
                ruta.AddLine(iconoRectangulo.X, iconoRectangulo.Y, iconoRectangulo.X + (iconoAncho / 2), iconoRectangulo.Bottom);
                ruta.AddLine(iconoRectangulo.X + (iconoAncho / 2), iconoRectangulo.Bottom, iconoRectangulo.Right, iconoRectangulo.Y);
                grafico.DrawPath(lapiz, ruta); // Dibujar ruta creada
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            lblTexto.Text = combo.Text;
        }

        private void ClicK_Superficie(object sender, EventArgs e)
        {
            this.OnClick(e);
            combo.Select(); // Seleccionar el combobox
            if (this.combo.DropDownStyle == ComboBoxStyle.DropDownList) // Si el estilo desplegable es lista desplegable, se abre
                this.combo.DroppedDown = true;
        }

        private void ComboBox_CambioTexto(object sender, EventArgs e)
        {
            this.lblTexto.Text = combo.Text; // Actualizar el texto
        }              

        private void Icon_Click(object sender, EventArgs e)
        {
            combo.Select();
            this.combo.DroppedDown = true;
        }

        private void Superficie_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Superficie_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        #endregion
    }
}
