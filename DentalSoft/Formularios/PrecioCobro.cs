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

namespace DentalSoft.Formularios
{
    public partial class PrecioCobro : Form
    {
        // Variables
        private Caja caja;

        // Constructores
        #region -> Constructores
        public PrecioCobro()
        {
            InitializeComponent();
        }

        public PrecioCobro(Caja caja)
        {
            InitializeComponent();
            this.caja = caja;
        }
        #endregion

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private bool IsNumero()
        {
            bool sw = false;
            float precio = 0;
            if (txtPrecio.Texto.Contains("."))
                txtPrecio.Texto = txtPrecio.Texto.Replace(".", ",");
            sw = float.TryParse(txtPrecio.Texto, out precio);
            if(sw)
                caja.precioOtros = precio;
            return sw;
        }

        private void OcultarMensaje()
        {
            lblErrorPrecio.Visible = false;
        }

        private void MostrarMensaje(string cadena)
        {
            lblErrorPrecio.Text = "     " + cadena;
            lblErrorPrecio.Visible = true;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                OcultarMensaje();
                if (IsNumero())
                    this.Close();
                else
                    MostrarMensaje("El precio no tiene un formato válido");
            }
        }

        private void btnIntroducirPrecio_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            if (IsNumero())
                this.Close();
            else
                MostrarMensaje("El precio no tiene un formato válido");
        }
        #endregion
    }
}
