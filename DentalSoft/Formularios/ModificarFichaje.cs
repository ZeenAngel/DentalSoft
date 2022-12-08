using DentalSoft.Clases;
using MySql.Data.MySqlClient;
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
    public partial class ModificarFichaje : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private string empleado;
        private string fecha;
        private string hora;

        // Constructores
        #region -> Constructores
        public ModificarFichaje()
        {
            InitializeComponent();
        }

        public ModificarFichaje(string empleado, string fecha, string hora)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.fecha = fecha;
            this.hora = hora;
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
        private void MostrarMensaje(string cadena)
        {
            lblErrorGuardar.Text = "     " + cadena;
            lblErrorGuardar.Visible = true;
        }

        private void OcultarMensaje()
        {
            lblErrorGuardar.Visible = false;
        }

        private void CargarDatos()
        {
            lblEmpleado.Text = this.empleado;
            mcFecha.Value = DateTime.Parse(this.fecha);
            txtHora.Texto = this.hora;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtHora.Texto.Length == 5)
            {
                ConexionBD conexion = new ConexionBD();
                if (conexion.EstablecerConexion())
                {
                    string sentencia = "UPDATE fichaje_empleado SET fecha = '" + mcFecha.Value.ToString("yyyy-MM-dd") +
                        "', hora = '" + txtHora.Texto + "' WHERE empleado = '" + this.empleado +
                        "' AND fecha = '" + DateTime.Parse(this.fecha).ToString("yyyy-MM-dd") + "' AND hora = '" + this.hora + "'";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    int resultado = comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexion.CerrarConexion();
                    if (resultado > 0)
                    {
                        DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Se ha guardado la agenda correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MostrarMensaje("No se ha podido modificar la hora");
                }
            }
            else
                MostrarMensaje("El formato de hora no es correcto");
        }

        private void ModificarFichaje_Load(object sender, EventArgs e)
        {
            CargarDatos();
            OcultarMensaje();
        }

        private void txtHora__TextChanged(object sender, EventArgs e)
        {
            if (!txtHora.Texto.Equals(""))
            {
                int ultimaPosicion = txtHora.Texto.Length - 1;
                if (ultimaPosicion == 2 && txtHora.Texto[ultimaPosicion] != ':')
                {
                    txtHora.Texto = txtHora.Texto.Substring(0, ultimaPosicion);
                    txtHora.PosicionSeleccion = txtHora.Texto.Length; // Colocar el cursor al final del texto
                }
                else if (ultimaPosicion == 0 && txtHora.Texto[ultimaPosicion] != '0' && txtHora.Texto[ultimaPosicion] != '1'
                    && txtHora.Texto[ultimaPosicion] != '2')
                {
                    txtHora.Texto = "";
                }
                else if (ultimaPosicion == 3 && txtHora.Texto[ultimaPosicion] != '0' && txtHora.Texto[ultimaPosicion] != '1'
                    && txtHora.Texto[ultimaPosicion] != '2' && txtHora.Texto[ultimaPosicion] != '3' && txtHora.Texto[ultimaPosicion] != '4'
                    && txtHora.Texto[ultimaPosicion] != '5')
                {
                    txtHora.Texto = txtHora.Texto.Substring(0, ultimaPosicion);
                    txtHora.PosicionSeleccion = txtHora.Texto.Length; // Colocar el cursor al final del texto
                }
                else if ((txtHora.Texto[ultimaPosicion] == ':' && ultimaPosicion != 2) && (txtHora.Texto[ultimaPosicion] != '0' && txtHora.Texto[ultimaPosicion] != '1'
                    && txtHora.Texto[ultimaPosicion] != '2' && txtHora.Texto[ultimaPosicion] != '3' && txtHora.Texto[ultimaPosicion] != '4'
                    && txtHora.Texto[ultimaPosicion] != '5' && txtHora.Texto[ultimaPosicion] != '6' && txtHora.Texto[ultimaPosicion] != '7'
                    && txtHora.Texto[ultimaPosicion] != '8' && txtHora.Texto[ultimaPosicion] != '9') || txtHora.Texto.Length > 5)
                {
                    txtHora.Texto = txtHora.Texto.Substring(0, ultimaPosicion);
                    txtHora.PosicionSeleccion = txtHora.Texto.Length; // Colocar el cursor al final del texto
                }
            }
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState ^= FormWindowState.Maximized;
                btnRedimensionar.Image = Image.FromFile(datosGlobales.PathBotonRedimensionar);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionar.Image = Image.FromFile(datosGlobales.PathBotonMaximizar);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
