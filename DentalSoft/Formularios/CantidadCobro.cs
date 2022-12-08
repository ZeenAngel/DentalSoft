using DentalSoft.Clases;
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
    public partial class CantidadCobro : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private Caja caja;

        // Constructores
        public CantidadCobro()
        {
            InitializeComponent();
        }

        public CantidadCobro(Caja caja)
        {
            InitializeComponent();
            this.caja = caja;
        }

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void OcultarMensaje()
        {
            lblErrorCantidad.Visible = false;
        }

        private void MostrarMensaje(string cadena)
        {
            lblErrorCantidad.Text = "     " + cadena;
            lblErrorCantidad.Visible = true;
        }

        private bool IsNumero()
        {
            bool sw = false;
            int cantidad = 0;
            sw = int.TryParse(txtCantidad.Texto, out cantidad);
            if(sw)
                caja.cantidad = cantidad;
            return sw;
        }
        #endregion

        // Eventos
        #region -> Eventos
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIntroducirCantidad_Click(object sender, EventArgs e)
        {
            if (IsNumero())
                this.Close();
            else
                MostrarMensaje("Debe introducir una cantidad correcta");
        }

        private void CantidadCobro_Load(object sender, EventArgs e)
        {
            OcultarMensaje();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (IsNumero())
                    this.Close();
                else
                    MostrarMensaje("Debe introducir una cantidad correcta");
            }
        }
        #endregion
    }
}
