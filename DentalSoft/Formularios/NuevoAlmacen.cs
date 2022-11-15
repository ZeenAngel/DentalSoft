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
    public partial class NuevoAlmacen : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        private int idAlmacen = 0;
        private bool isEditando = false;

        // Constructores
        #region -> Constructores
        public NuevoAlmacen()
        {
            InitializeComponent();
        }

        public NuevoAlmacen(int idAlmacen)
        {
            InitializeComponent();
            this.idAlmacen = idAlmacen;
            this.isEditando = true;
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
        private void LimpiarCampos()
        {
            txtNombre.Texto = "";
            txtUbicacion.Texto = "";
        }

        private void MostrarMensaje(string cadena)
        {
            lblErrorNombre.Text = "     " + cadena;
            lblErrorNombre.Visible = true;
        }

        private void OcultarMensaje()
        {
            lblErrorNombre.Visible = false;
        }

        private void CargarDatos()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT nombre, ubicacion FROM almacen WHERE id = " + this.idAlmacen;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    txtNombre.Texto = reader.GetString(0);
                    if(! reader.IsDBNull(1)) // Comprobar que la ubicación no es nula
                        txtUbicacion.Text = reader.GetString(1);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private int GetSiguienteIdAlmacen()
        {
            int id = -1;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT id FROM almacen ORDER BY id DESC LIMIT 1";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return ++id; // Devuelve el siguiente id
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState ^= FormWindowState.Maximized;
                btnRedimensionar.Image = System.Drawing.Image.FromFile(datosGlobales.PathBotonRedimensionar);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnRedimensionar.Image = System.Drawing.Image.FromFile(datosGlobales.PathBotonMaximizar);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoAlmacen_Load(object sender, EventArgs e)
        {
            if (isEditando)
                CargarDatos();
            OcultarMensaje();

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarAlmacen_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Texto.Equals(""))
            {
                string sentencia = "";
                if (isEditando)
                {
                    sentencia = "UPDATE almacen SET nombre = '" + txtNombre.Texto + "'";
                    if (!txtUbicacion.Texto.Equals(""))
                        sentencia += ", ubicacion = '" + txtUbicacion.Texto + "'";
                    sentencia += " WHERE id = " + this.idAlmacen;
                }
                else
                {
                    int siguienteIdAlmacen = GetSiguienteIdAlmacen();
                    sentencia = "INSERT INTO almacen VALUES(" + siguienteIdAlmacen + ", '" + txtNombre.Texto + "'";
                    if (!txtUbicacion.Texto.Equals(""))
                        sentencia += ", '" + txtUbicacion.Texto + "')";
                    else
                        sentencia += ")";
                }
                if (conexion.EstablecerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexion.CerrarConexion();
                    if (isEditando)
                    {
                        DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Almacén editado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Almacén guardado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
            }
            else
                MostrarMensaje("Debe introducir un nombre para el almacén");
        }
        #endregion
    }
}
