using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
public partial class MessageBoxPersonalizado : Form
{

        #region -> Funcionalidad
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        // Variables
        private Color colorPrincipal = Color.CornflowerBlue;
        private int bordeTamaño = 2;

        #region -> Constructores

        public MessageBoxPersonalizado(string texto)
        {
            InitializeComponent();
            InicializarObjetos();
            this.ColorPrincipal = colorPrincipal;
            this.labelMessage.Text = texto;
            this.labelCaption.Text = "";
            SetTamañoFormulario();
            SetBotones(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1); // Establecer Botones por Defecto
        }
        public MessageBoxPersonalizado(string texto, string titulo)
        {
            InitializeComponent();
            InicializarObjetos();
            this.ColorPrincipal = colorPrincipal;
            this.labelMessage.Text = texto;
            this.labelCaption.Text = titulo;
            SetTamañoFormulario();
            SetBotones(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1); // Establecer Botones por Defecto
        }
        public MessageBoxPersonalizado(string texto, string titulo, MessageBoxButtons botones)
        {
            InitializeComponent();
            InicializarObjetos();
            this.ColorPrincipal = colorPrincipal;
            this.labelMessage.Text = texto;
            this.labelCaption.Text = titulo;
            SetTamañoFormulario();
            SetBotones(botones, MessageBoxDefaultButton.Button1); // Establecer Boton1 por Defecto
        }
        public MessageBoxPersonalizado(string texto, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            InitializeComponent();
            InicializarObjetos();
            this.ColorPrincipal = colorPrincipal;
            this.labelMessage.Text = texto;
            this.labelCaption.Text = titulo;
            SetTamañoFormulario();
            SetBotones(botones, MessageBoxDefaultButton.Button1); // Establecer Boton1 por Defecto
            SetIcono(icono);
        }
        public MessageBoxPersonalizado(string texto, string titulo, MessageBoxButtons botones, MessageBoxIcon icono, MessageBoxDefaultButton botonDefecto)
        {
            InitializeComponent();
            InicializarObjetos();
            this.ColorPrincipal = colorPrincipal;
            this.labelMessage.Text = texto;
            this.labelCaption.Text = titulo;
            SetTamañoFormulario();
            SetBotones(botones, botonDefecto);
            SetIcono(icono);
        }

        #endregion

        // Setters y Getters
        public Color ColorPrincipal
        {
            get { 
                return colorPrincipal; 
            }
            set
            {
                colorPrincipal = value;
                this.BackColor = colorPrincipal; //Color Borde Formulario
                this.panelTitleBar.BackColor = ColorPrincipal;// Fondo Barra de título
            }
        }

        #region -> Métodos privados

        private void InicializarObjetos()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(bordeTamaño); // Tamaño del borde
            this.labelMessage.MaximumSize = new Size(550, 0);
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.button1.DialogResult = DialogResult.OK;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
        }
        private void SetTamañoFormulario()
        {
            int widht = this.labelMessage.Width + this.pictureBoxIcon.Width + this.panelBody.Padding.Left;
            int height = this.panelTitleBar.Height + this.labelMessage.Height + this.panelButtons.Height + this.panelBody.Padding.Top;
            this.Size = new Size(widht, height);
        }
        private void SetBotones(MessageBoxButtons botones, MessageBoxDefaultButton botonDefecto)
        {
            int xCentro = (this.panelButtons.Width - button1.Width) / 2;
            int yCentro = (this.panelButtons.Height - button1.Height) / 2;

            switch (botones)
            {
                case MessageBoxButtons.OK:
                    // OK Botón
                    button1.Visible = true;
                    button1.Location = new Point(xCentro, yCentro);
                    button1.Text = "Vale";
                    button1.DialogResult = DialogResult.OK; // Establecer el DialogResult

                    // Establecer Botón por Defecto
                    SetBotonDefecto(botonDefecto);
                    break;
                case MessageBoxButtons.OKCancel:
                    // OK Botón
                    button1.Visible = true;
                    button1.Location = new Point(xCentro - (button1.Width / 2) - 5, yCentro);
                    button1.Text = "Vale";
                    button1.DialogResult = DialogResult.OK;

                    // Cancelar Botón
                    button2.Visible = true;
                    button2.Location = new Point(xCentro + (button2.Width / 2) + 5, yCentro);
                    button2.Text = "Cancelar";
                    button2.DialogResult = DialogResult.Cancel;
                    button2.BackColor = Color.DimGray;

                    // Establecer Botón por Defecto
                    if (botonDefecto != MessageBoxDefaultButton.Button3) // Solo hay 2 botones, por lo que el botón personalizado no puede ser el 3
                        SetBotonDefecto(botonDefecto);
                    else
                        SetBotonDefecto(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    // Reintentar Botón
                    button1.Visible = true;
                    button1.Location = new Point(xCentro - (button1.Width / 2) - 5, yCentro);
                    button1.Text = "Reintentar";
                    button1.DialogResult = DialogResult.Retry;//Set DialogResult

                    // Cancelar Botón
                    button2.Visible = true;
                    button2.Location = new Point(xCentro + (button2.Width / 2) + 5, yCentro);
                    button2.Text = "Cancelar";
                    button2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button2.BackColor = Color.DimGray;

                    // Establecer Botón por Defecto
                    if (botonDefecto != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetBotonDefecto(botonDefecto);
                    else SetBotonDefecto(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    // Si Botón
                    button1.Visible = true;
                    button1.Location = new Point(xCentro - (button1.Width / 2) - 5, yCentro);
                    button1.Text = "Si";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    // No Botón
                    button2.Visible = true;
                    button2.Location = new Point(xCentro + (button2.Width / 2) + 5, yCentro);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    // Establecer Botón por Defecto
                    if (botonDefecto != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetBotonDefecto(botonDefecto);
                    else SetBotonDefecto(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    // Si Botón
                    button1.Visible = true;
                    button1.Location = new Point(xCentro - button1.Width - 5, yCentro);
                    button1.Text = "Si";
                    button1.DialogResult = DialogResult.Yes;//Set DialogResult

                    // No Botón
                    button2.Visible = true;
                    button2.Location = new Point(xCentro, yCentro);
                    button2.Text = "No";
                    button2.DialogResult = DialogResult.No;//Set DialogResult
                    button2.BackColor = Color.IndianRed;

                    // Cancelar Botón
                    button3.Visible = true;
                    button3.Location = new Point( + button2.Width + 5, yCentro);
                    button3.Text = "Cancelar";
                    button3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    button3.BackColor = Color.DimGray;

                    // Establecer Botón por Defecto
                    SetBotonDefecto(botonDefecto);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    // Abortar Butón
                    button1.Visible = true;
                    button1.Location = new Point(xCentro - button1.Width - 5, yCentro);
                    button1.Text = "Abortar";
                    button1.DialogResult = DialogResult.Abort;//Set DialogResult
                    button1.BackColor = Color.Goldenrod;

                    // Reintentar Butón
                    button2.Visible = true;
                    button2.Location = new Point(xCentro, yCentro);
                    button2.Text = "Reintentar";
                    button2.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    // Ignorar Butón
                    button3.Visible = true;
                    button3.Location = new Point(xCentro + button2.Width + 5, yCentro);
                    button3.Text = "Ignorar";
                    button3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    button3.BackColor = Color.IndianRed;

                    // Establecer Botón por Defecto
                    SetBotonDefecto(botonDefecto);
                    break;
            }
        }
        private void SetBotonDefecto(MessageBoxDefaultButton botonDefecto)
        {
            switch (botonDefecto)
            {
                case MessageBoxDefaultButton.Button1: // Foco Botón1
                    button1.Select();
                    button1.ForeColor = Color.White;
                    button1.Font = new Font(button1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2: // Foco Botón2
                    button2.Select();
                    button2.ForeColor = Color.White;
                    button2.Font = new Font(button2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3: // Foco Botón3
                    button3.Select();
                    button3.ForeColor = Color.White;
                    button3.Font = new Font(button3.Font, FontStyle.Underline);
                    break;
            }
        }
        private void SetIcono(MessageBoxIcon icono)
        {
            switch (icono)
            {
                case MessageBoxIcon.Error: // Error
                    this.pictureBoxIcon.Image = Properties.Resources.error;
                    ColorPrincipal = Color.FromArgb(224, 79, 95);
                    this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: // Información
                    this.pictureBoxIcon.Image = Properties.Resources.information;
                    ColorPrincipal = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question: // Interrogación
                    this.pictureBoxIcon.Image = Properties.Resources.question;
                    ColorPrincipal = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation: // Exclamación
                    this.pictureBoxIcon.Image = Properties.Resources.exclamation;
                    ColorPrincipal = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: // Prohibición
                    this.pictureBoxIcon.Image = Properties.Resources.chat;
                    ColorPrincipal = Color.CornflowerBlue;
                    break;
            }
        }

        #endregion

        //  Eventos
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
