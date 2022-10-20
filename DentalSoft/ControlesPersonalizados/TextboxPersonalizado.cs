using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    // Establecer el vento predeterminado al creado
    [DefaultEvent("_TextChanged")]
    public partial class TextboxPersonalizado : UserControl
    {
        // Variables para apariencia
        private Color bordeColor = Color.MediumSlateBlue;
        private int bordeTamaño = 2;
        private Color bordeColorFoco = Color.HotPink;
        private bool subrayadoEstilo = false;
        private bool isFocused = false;
        private int bordeRadio = 0;
        private Color marcadorPosicionColor = Color.DarkGray;
        private string marcadorPosicionTexto = "";
        private bool isMarcadorPosicion = false;
        private bool isContraseña = false;

        // Constructor
        public TextboxPersonalizado()
        {
            InitializeComponent();
        }


        #region -> Getters y Setters
        // Getter y Setter
        [Category("Propiedades Avanzadas TextBox")]
        public Color BordeColor {
            get
            {
                return bordeColor;
            }
            set {
                bordeColor = value;
                this.Invalidate();
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public int BordeTamaño
        {
            get
            {
                return bordeTamaño;
            }
            set
            {
                bordeTamaño = value;
                this.Invalidate ();
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public Color BordeColorFoco
        {
            get
            {
                return bordeColorFoco;
            }
            set
            {
                bordeColorFoco = value;
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public bool SubrayadoEstilo
        {
            get
            {
                return subrayadoEstilo;
            }
            set
            {
                subrayadoEstilo = value;
                this.Invalidate();
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public bool Contraseña
        {
            get
            {
                return isContraseña;
            }
            set
            {
                isContraseña = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public bool Multilinea
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    ControlRedimension();
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public string Texto
        {
            get
            {
                if (isMarcadorPosicion)
                    return "";
                else
                    return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                if(value.Equals(""))
                    SetMarcadorPosicion();
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public int BordeRadio
        {
            get
            {
                return bordeRadio;
            }
            set
            {
                if(value >= 0)
                {
                    bordeRadio = value;
                    this.Invalidate(); // Para llamar al evento Paint
                }
                
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public Color MarcadorPosicionColor {
            get
            {
                return marcadorPosicionColor;
            }
            set
            {
                marcadorPosicionColor = value;
                if (isContraseña)
                    textBox1.ForeColor = value;
            }
        }

        [Category("Propiedades Avanzadas TextBox")]
        public string MarcadorPosicionTexto {
            get
            {
                return marcadorPosicionTexto;
            }
            set
            {
                marcadorPosicionTexto = value;
                textBox1.Text = "";
                SetMarcadorPosicion();
            }
        }
        #endregion

        #region -> Métodos sobreescritos
        // Métodos Sobreescritos
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grafico = e.Graphics;

            if(bordeRadio > 1) // TextBox con esquinas redondeadas
            {
                // Variables necesarias para redondear los cuadros
                var rectanguloSuavizadoBorde = this.ClientRectangle;
                var rectanguloBorde = Rectangle.Inflate(rectanguloSuavizadoBorde, -bordeTamaño, -bordeTamaño);
                int suavizadoTamaño = bordeTamaño > 0 ? bordeTamaño : 1; // El tamaño de suavizado es igual al del borde, pero si el valor es 0 entonces por defecto se pone en 1

                using (GraphicsPath pathSuavizadoBorde = GetPathFigura(rectanguloSuavizadoBorde, bordeRadio))
                using (GraphicsPath pathBorde = GetPathFigura(rectanguloBorde, bordeRadio - bordeTamaño))
                using (Pen penSuavizadoBorde = new Pen(this.Parent.BackColor, suavizadoTamaño))
                using (Pen penBorde = new Pen(bordeColor, bordeTamaño))
                {
                    // Establecer la region a redondear del TextBox
                    this.Region = new Region(pathSuavizadoBorde);
                    if (bordeRadio > 15)
                        SetTextBoxRegionRedondeada();
                    grafico.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorde.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused)
                        penBorde.Color = bordeColorFoco;
                    if (subrayadoEstilo)
                    {
                        // Dibujar Suavizado de borde
                        grafico.DrawPath(penSuavizadoBorde, pathSuavizadoBorde);
                        // Dibujar borde
                        grafico.SmoothingMode = SmoothingMode.None;
                        grafico.DrawLine(penBorde, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        // Dibujar Suavizado de borde
                        grafico.DrawPath(penSuavizadoBorde, pathSuavizadoBorde);
                        // Dibujar borde
                        grafico.DrawPath(penBorde, pathBorde);
                    }
                }
            }
            else // Textbox Cuadrado normal
            {
                // Pintar borde del cuadro de texto
                using (Pen penBorde = new Pen(bordeColor, bordeTamaño))
                {
                    // Para recuperar la forma rectangular
                    this.Region = new Region(this.ClientRectangle);
                    penBorde.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (!isFocused)
                    {
                        if (subrayadoEstilo) // Estilo de linea
                            grafico.DrawLine(penBorde, 0, this.Height - 1, this.Width, this.Height - 1);
                        else // Estilo Normal
                            grafico.DrawRectangle(penBorde, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                    else
                    {
                        penBorde.Color = bordeColorFoco;

                        if (subrayadoEstilo) // Estilo de linea
                            grafico.DrawLine(penBorde, 0, this.Height - 1, this.Width, this.Height - 1);
                        else // Estilo Normal
                            grafico.DrawRectangle(penBorde, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }  
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                ControlRedimension();
            ControlRedimension();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ControlRedimension();
        }
        #endregion

        #region -> Métodos públicos
        public void Limpiar()
        {
            textBox1.Text = "";
        }
        #endregion

        #region -> Métodos privados
        // Métodos privados
        private void ControlRedimension()
        {
            if(!textBox1.Multiline)
            {
                int alturaTexto = TextRenderer.MeasureText("Texto", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, alturaTexto);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private GraphicsPath GetPathFigura(Rectangle rectangulo, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            float tamañoCurva = radio * 2F;
            path.StartFigure();
            path.AddArc(rectangulo.X, rectangulo.Y, tamañoCurva, tamañoCurva, 180, 90);
            path.AddArc(rectangulo.Right - tamañoCurva, rectangulo.Y, tamañoCurva, tamañoCurva, 270, 90);
            path.AddArc(rectangulo.Right - tamañoCurva, rectangulo.Bottom - tamañoCurva, tamañoCurva, tamañoCurva, 0, 90);
            path.AddArc(rectangulo.X, rectangulo.Bottom - tamañoCurva, tamañoCurva, tamañoCurva, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SetTextBoxRegionRedondeada()
        {
            GraphicsPath pathTexto;
            if (Multilinea)
            {
                pathTexto = GetPathFigura(textBox1.ClientRectangle, bordeRadio - bordeTamaño);
                textBox1.Region = new Region(pathTexto);
            }
            else
            {
                pathTexto = GetPathFigura(textBox1.ClientRectangle, bordeTamaño * 2);
                textBox1.Region = new Region(pathTexto);
            }
        }

        private void SetMarcadorPosicion()
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) && marcadorPosicionTexto != "")
            {
                isMarcadorPosicion = true;
                textBox1.Text = marcadorPosicionTexto;
                textBox1.ForeColor = marcadorPosicionColor;
                if (isContraseña)
                    textBox1.UseSystemPasswordChar = false;
            }
        }

        private void RemoveMarcadorPosicion()
        {
            if (isMarcadorPosicion && marcadorPosicionTexto != "")
            {
                isMarcadorPosicion = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isContraseña)
                    textBox1.UseSystemPasswordChar = true;
            }
        }
        #endregion

        #region -> Eventos
        // Eventos
        public event EventHandler _TextChanged;

        // Con esto se invoca al evento personalizado creado enviando todos los datos del método existente
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            bordeTamaño++;
            this.Invalidate();
            RemoveMarcadorPosicion();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            bordeTamaño--;
            this.Invalidate();
            SetMarcadorPosicion();
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            this.OnDragDrop(e);
        }

        private void textBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.OnMouseCaptureChanged(e);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OnMouseDoubleClick(e);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            this.OnDragEnter(e);
        }

        private void textBox1_DragLeave(object sender, EventArgs e)
        {
            this.OnDragLeave(e);
        }

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            this.OnDragOver(e);
        }

        private void textBox1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            this.OnGiveFeedback(e);
        }

        private void textBox1_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            this.OnQueryContinueDrag(e);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.OnPreviewKeyDown(e);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseHover(e);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.OnMouseMove(e);
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            this.OnValidated(e);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            this.OnValidating(e);
        }

        #endregion
    }
}
