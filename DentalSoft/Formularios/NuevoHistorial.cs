using DentalSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class NuevoHistorial : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        public string dni;
        public string fecha;

        // Constructor
        public NuevoHistorial()
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
        #region -> Métodos privados
        private void OcultarMensaje()
        {
            lblErrorAlergias.Visible = false;
            lblErrorMedicacion.Visible = false;
            lblErrorGuardar.Visible = false;
        }

        private void MostrarMensaje(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "alergias":
                    lblErrorAlergias.Text = "     " + cadena;
                    lblErrorAlergias.Visible = true;
                    break;
                case "medicación":
                    lblErrorMedicacion.Text = "     " + cadena;
                    lblErrorMedicacion.Visible = true;
                    break;
                case "guardar":
                    lblErrorGuardar.Text = "     " + cadena;
                    lblErrorGuardar.Visible = true;
                    break;
            }
        }

        private void LimpiarCampos()
        {
            txtAlergias.Text = "";
            txtMedicacion.Text = "";
            txtObservaciones.Text = "";
        }

        private bool ComprobarTextosNulos()
        {
            bool sw = false;
            DialogResult mensaje;
            if (!txtAlergias.Text.Equals(""))
            {
                if (!txtMedicacion.Text.Equals(""))
                    sw = true;
                else
                {
                    mensaje = MessageBoxPersonalizadoControl.Show("No ha introducido ninguna Medicación. ¿Quiere poner el texto por defecto?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (mensaje == DialogResult.Yes)
                    {
                        txtMedicacion.Text = datosGlobales.MedicacionPredeterminado;
                    }
                    else
                        MostrarMensaje("El campo medicación no puede quedar vacío", "medicación");
                }
            }
            else
            {
                mensaje = MessageBoxPersonalizadoControl.Show("No ha introducido ninguna Alergia. ¿Quiere poner el texto por defecto?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (mensaje == DialogResult.Yes)
                {
                    txtAlergias.Text = datosGlobales.AlergiasPredeterminado;
                    if (!txtMedicacion.Text.Equals(""))
                        sw = true;
                    else
                    {
                        mensaje = MessageBoxPersonalizadoControl.Show("No ha introducido ninguna Medicación. ¿Quiere poner el texto por defecto?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (mensaje == DialogResult.Yes)
                        {
                            txtMedicacion.Text = datosGlobales.MedicacionPredeterminado;
                        }
                        else
                            MostrarMensaje("El campo medicación no puede quedar vacío", "medicación");
                    }
                }
                else
                    MostrarMensaje("El campo de alergias no puede quedar vacío", "alergias");
            }           
            return sw;
        }

        private bool NoExisteHistorial()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT paciente FROM historial_clinico WHERE paciente = '" + txtPaciente.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (!reader.HasRows)
                    sw = true;
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private void CargarDatos()
        {
            txtPaciente.Texto = this.dni;
            txtPaciente.Enabled = false;
            txtFecha.Texto = this.fecha;
            txtFecha.Enabled = false;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void NuevoHistorial_Load(object sender, EventArgs e)
        {
            OcultarMensaje();
            CargarDatos();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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

        private void btnLimipar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarTextosNulos())
            {
                if (NoExisteHistorial())
                {
                    if (conexion.EstablecerConexion())
                    {
                        DateTime fecha = DateTime.Parse(txtFecha.Texto);
                        string sentencia = "INSERT INTO historial_clinico VALUES('" + txtPaciente.Texto + "', '" + fecha.ToString("yyyy-MM-dd") + "', '" + txtAlergias.Text + "', '" + txtMedicacion.Text + "'";
                        if (txtObservaciones.Text.Equals(""))
                            sentencia += ", null)";
                        else
                            sentencia += ", '" + txtObservaciones.Text + "')";
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        int resultado = comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexion.CerrarConexion();
                        if (resultado > 0)
                        {
                            DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Historial creado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                            MostrarMensaje("No se ha podido guardar el historial", "guardar");
                    }
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Dentalsoft\\Documentacion\\Plantilla_Historial_clinico.pdf");
        }
        #endregion
    }
}
