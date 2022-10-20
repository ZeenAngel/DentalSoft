using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DentalSoft.ControlesPersonalizados
{
    public class SelectorFecha : DateTimePicker
    {
        #region -> Variables

        private Color fondoColor = Color.MediumSlateBlue;
        private Color textoColor = Color.White;
        private Color bordeColor = Color.PaleVioletRed;
        private int bordeTamaño = 0;
        private bool isDesplegado = false;
        private Image iconoCalendario = Properties.Resources.icono_calendariofull_blanco16;
        private RectangleF iconoCalendarioAreaBoton;
        private const int iconoCalendarioAncho = 34; // Estas variables son para controlar el ancho del icono desplegable
        private const int iconoFlechaAncho = 17;

        #endregion

        // Constructor
        public SelectorFecha()
        {
            this.SetStyle(ControlStyles.UserPaint, true); // El control será dibujado por el usuario y no por el sistema. Sirve para sobreescribir los métodos Paint nativos de Windows
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
            this.MinDate = DateTime.Now;
        }

        #region -> Getters y Setters

        [Category("Propiedades Avanzadas SelectorFecha")]
        public Color FondoColor {
            get
            {
                return fondoColor;
            }
            set
            {
                fondoColor = value;
                if (fondoColor.GetBrightness() >= 0.8) // Si es 0.0 es negro, si es 1.0 es blanco
                    iconoCalendario = Properties.Resources.icono_calendariofull_negro16;
                else
                    iconoCalendario = Properties.Resources.icono_calendariofull_blanco16;
                this.Invalidate(); // Redibujar el control
            }
        }
        [Category("Propiedades Avanzadas SelectorFecha")]
        public Color TextoColor {
            get
            {
                return textoColor;
            }
            set
            {
                textoColor = value;
                this.Invalidate();
            }
        }
        [Category("Propiedades Avanzadas SelectorFecha")]
        public Color BordeColor {
            get
            {
                return bordeColor;
            }
            set
            {
                bordeColor = value;
                this.Invalidate();
            }
        }
        [Category("Propiedades Avanzadas SelectorFecha")]
        public int BordeTamaño { 
            get {
                return bordeTamaño; 
            }
            set
            {
                bordeTamaño = value;
                this.Invalidate();
            }
        }
        public bool IsDesplegado {
            get
            {
                return isDesplegado;
            }
            set
            {
                isDesplegado = value;
                this.Invalidate();
            } 
        }

        #endregion

        #region -> Métodos sobrecargados

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            isDesplegado = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs); 
            isDesplegado = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true; // Evitar cambiar las fechas con las teclas numéricas
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Se utiliza los using para que se eliminen los objetos una vez han sido utilizados
            using (Graphics grafico = this.CreateGraphics())
            using (Pen bordeLapiz = new Pen(bordeColor, bordeTamaño)) // Lápiz para dibujar los bordes
            using (SolidBrush fondoPincel = new SolidBrush(fondoColor)) // Pincel sólido para dibujar el fondo
            using (SolidBrush iconoFondoPincel = new SolidBrush(Color.FromArgb(50, 64, 64, 64))) // Pincel sólido para dibujar el fondo del icono del calendario cuando está desplegado
            using (SolidBrush textoPincel = new SolidBrush(textoColor)) // Pincel sólido para el color del texto
            using (StringFormat textoFormato = new StringFormat())
            {
                RectangleF areaControl = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconoArea = new RectangleF(areaControl.Width - iconoCalendarioAncho, 0, iconoCalendarioAncho, areaControl.Height);
                bordeLapiz.Alignment = PenAlignment.Inset;
                textoFormato.LineAlignment = StringAlignment.Center;

                // Dibujar el control
                grafico.FillRectangle(fondoPincel, areaControl); // Dibujar el rectángulo
                grafico.DrawString("    " + this.Text, this.Font, textoPincel, areaControl, textoFormato); // Dibujar el texto
                if (isDesplegado) // Oscurecer formulario fondo cuando se desplega el calendario
                    grafico.FillRectangle(iconoFondoPincel, iconoArea);
                if (bordeTamaño > 0) // Dibujar el borde
                    grafico.DrawRectangle(bordeLapiz, areaControl.X, areaControl.Y, areaControl.Width, areaControl.Height);
                grafico.DrawImage(iconoCalendario, this.Width - iconoCalendario.Width - 9, (this.Height - iconoCalendario.Height) / 2); // Dibujar el icono

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconoAncho = GetAnchoBotonIcono();
            iconoCalendarioAreaBoton = new RectangleF(this.Width - iconoAncho, 0, iconoAncho, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconoCalendarioAreaBoton.Contains(e.Location)) // Si el icono tiene el cursor encima
                this.Cursor = Cursors.Hand; // Establecer el cursor a icono de Mano
            else
                this.Cursor = Cursors.Default;
        }

        #endregion

        // Métodos privados
        private int GetAnchoBotonIcono()
        {
            int textoAncho = TextRenderer.MeasureText(this.Text, this.Font).Width; // Almacenar el ancho del texto
            if (textoAncho <= this.Width - (iconoCalendarioAncho + 20))
                return iconoCalendarioAncho;
            else
                return iconoFlechaAncho;
        }
    }
}
