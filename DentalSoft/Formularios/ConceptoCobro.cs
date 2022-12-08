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
    public partial class ConceptoCobro : Form
    {
        // Variables
        private Caja caja;

        // Constructores
        #region -> Constructores
        public ConceptoCobro()
        {
            InitializeComponent();
        }

        public ConceptoCobro(Caja caja)
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
        private void DevolverConcepto()
        {
            this.caja.conceptoOtros = txtConcepto.Texto;
            this.Close();
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

        private void txtConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
                DevolverConcepto();
        }

        private void btnIntroducirConcepto_Click(object sender, EventArgs e)
        {
            DevolverConcepto();
        }
        #endregion
    }
}
