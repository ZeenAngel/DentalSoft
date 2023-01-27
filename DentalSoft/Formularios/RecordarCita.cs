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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DentalSoft.Formularios
{
    public partial class RecordarCita : Form
    {
        // Variables


        // Constructor
        public RecordarCita()
        {
            InitializeComponent();
        }

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Métodos privados
        private void EnviarEmail()
        {
            ConexionMail conexionMail = new ConexionMail();
            conexionMail.InicializarClienteSmtp();
            if (conexionMail.RecordarCita(mcFechaEnvio.Value.ToString("yyyy-MM-dd")))
            {
                lblEnviado.Visible = true;
                timer1.Start();
            }
        }

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

        private void btnRecordar_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }

        private void RecordarCita_Load(object sender, EventArgs e)
        {
            mcFechaEnvio.MinDate = DateTime.Now;
            mcFechaEnvio.Value = DateTime.Now;
            lblEnviado.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEnviado.Visible = false;
            timer1.Stop();
        }
        #endregion
    }
}
