using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace DentalSoft.ControlesPersonalizados
{
    public class BotonPersonalizado : Button
    {
        // Variables
        private int bordeTamaño = 0;
        private int bordeRadio = 40;
        private Color bordeColor = Color.PaleVioletRed;

        // Constructor
        public BotonPersonalizado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(RedimensionarBoton); // Esto eveita que al superar el máximo de borde el botón se deforme
        }

        #region -> Getters y Setters

        [Category("Propiedades Avanzadas Botón")]
        public int BordeTamaño {
            get
            {
                return bordeTamaño;
            }
            set
            {
                bordeTamaño = value;
                this.Invalidate();
            }
        }

        [Category("Propiedades Avanzadas Botón")]
        public int BordeRadio {
            get
            {
                return bordeRadio;
            }
            set
            {
                bordeRadio = value;
                this.Invalidate();
            }
        }

        [Category("Propiedades Avanzadas Botón")]
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

        [Category("Propiedades Avanzadas Botón")]
        public Color FondoColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        [Category("Propiedades Avanzadas Botón")]
        public Color TextoColor
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;
            }
        }

        #endregion

        #region -> Métodos privados

        private GraphicsPath GetRutaFigura(RectangleF rectangulo, float radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            ruta.StartFigure();
            ruta.AddArc(rectangulo.X, rectangulo.Y, radio, radio, 180, 90);
            ruta.AddArc(rectangulo.Width - radio, rectangulo.Y, radio, radio, 270, 90);
            ruta.AddArc(rectangulo.Width - radio, rectangulo.Height - radio, radio, radio, 0, 90);
            ruta.AddArc(rectangulo.X, rectangulo.Height - radio, radio, radio, 90, 90);
            ruta.CloseFigure();
            return ruta;
        }

        private void BotonCambioColorFondo(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        private void RedimensionarBoton(object sender, EventArgs e)
        {
            if(bordeRadio > this.Height)
                bordeRadio = this.Height;
        }

        #endregion

        #region -> Métodos sobrecargados

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Suavizar los bordes
            RectangleF rectanguloSuperficie = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectanguloBorde = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if(bordeRadio > 2) // Botón de esquinas redondeadas
            {
                using (GraphicsPath rutaSuperficie = GetRutaFigura(rectanguloSuperficie, bordeRadio))
                using (GraphicsPath rutaBorde = GetRutaFigura(rectanguloBorde, bordeRadio - 1F))
                using (Pen lapizSuperficie = new Pen(this.Parent.BackColor, 2))
                using (Pen lapizBorde = new Pen(bordeColor, bordeTamaño))
                {
                    lapizBorde.Alignment = PenAlignment.Inset;
                    this.Region = new Region(rutaSuperficie);
                    pevent.Graphics.DrawPath(lapizSuperficie, rutaSuperficie); // Dibujar superficie botón
                    if(bordeTamaño >= 1) // Dibujar borde botón
                        pevent.Graphics.DrawPath(lapizBorde, rutaBorde);
                }
            }
            else // Botón normal
            {
                this.Region = new Region(rectanguloSuperficie);
                if(bordeTamaño >= 1)
                {
                    using(Pen lapizBorde = new Pen(bordeColor, bordeTamaño))
                    {
                        lapizBorde.Alignment= PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(lapizBorde, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(BotonCambioColorFondo);
        }

        #endregion
    }
}
