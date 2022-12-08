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
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace DentalSoft.Formularios
{
    public partial class Agenda : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();

        // Constructor
        public Agenda()
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
            lblErrorHora.Visible = false;
            lblErrorOdontologo.Visible = false;
            lblErrorGuardar.Visible = false;
        }

        private void MostrarMensaje(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "hora":
                    lblErrorHora.Text = "     " + cadena;
                    lblErrorHora.Visible = true;
                    break;
                case "odontologo":
                    lblErrorOdontologo.Text = "     " + cadena;
                    lblErrorOdontologo.Visible = true;
                    break;
                case "guardar":
                    lblErrorGuardar.Text = "     " + cadena;
                    lblErrorGuardar.Visible = true;
                    break;
            }
            
        }

        private void CargarHorasGeneral()
        {
            lvHorasConsulta.Items.Clear();
            lvHorasDisponibles.Items.Clear();
            List<string> horas = new List<string>();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT hora FROM horas_consulta ORDER BY hora";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    while(reader.Read())
                        horas.Add(reader.GetString(0));
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
                foreach (string hora in horas)
                {
                    lvHorasConsulta.Items.Add(hora);
                    lvHorasDisponibles.Items.Add(hora);
                }
            }
        }

        private bool ComprobarExisteHora()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT hora FROM horas_consulta WHERE hora = '" + txtNuevaHora.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if(! reader.HasRows)
                    sw = true;
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private bool GuardarHora()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "INSERT INTO horas_consulta(hora) VALUES('" + txtNuevaHora.Texto + "')";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                    sw = true;
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private bool ComprobarHoraValida()
        {
            bool sw = false;
            if (txtNuevaHora.Texto.Length == 5)
                sw = true;
            return sw;
        }

        private void ComprobarBotones()
        {
            if(lvHorasDisponibles.Items.Count == 0)
            {
                btnAñadirHora.Enabled = false;
                btnAñadirTodasHora.Enabled = false;
            }else
            {
                btnAñadirHora.Enabled = true;
                btnAñadirTodasHora.Enabled = true;
            }
            if(lvHorasAsignadas.Items.Count == 0)
            {
                btnQuitarHora.Enabled = false;
                btnQuitarTodasHora.Enabled = false;
            }
            else
            {
                btnQuitarHora.Enabled = true;
                btnQuitarTodasHora.Enabled = true;
            }
        }

        private bool ExisteOdontologo()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT dni FROM empleado WHERE dni = '" + txtOdontologo.Texto + "' AND puesto = 3";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    sw = true;
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private void LimpiarCampos()
        {
            txtOdontologo.Texto = "";
            mcFecha.Value = DateTime.Now;
            CargarHorasGeneral();
            lvHorasAsignadas.Items.Clear();
        }

        private void QuitarHoraListview(string hora)
        {
            for(int i = 0; i < lvHorasDisponibles.Items.Count; i++)
            {
                if (lvHorasDisponibles.Items[i].Text.Equals(hora))
                {
                    lvHorasDisponibles.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void ComprobarAgenda()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT hora FROM agenda WHERE odontologo = '" + txtOdontologo.Texto + "' AND fecha = '" + mcFecha.Value.ToString("yyyy-MM-dd") + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                        QuitarHoraListview(reader.GetString(0));
                }
                conexion.CerrarConexion();
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Ajustes_Load(object sender, EventArgs e)
        {
            OcultarMensaje();
            txtNuevaHora.TamañoMaximo = 5;
            CargarHorasGeneral();
            mcFecha.MinDate = DateTime.Now;
        }

        private void btnNuevaHora_Click(object sender, EventArgs e)
        {
            if (ComprobarHoraValida())
            {
                if (ComprobarExisteHora())
                {
                    if (GuardarHora())
                    {
                        OcultarMensaje();
                        CargarHorasGeneral();
                    }
                    else
                        MostrarMensaje("No se ha podido guardar la hora", "hora");
                }
                else
                    MostrarMensaje("Ya existe esa hora", "hora");
            }
            else
                MostrarMensaje("Debe introducir una hora válida en formato hh:mm", "hora");
            
        }

        private void txtNuevaHora__TextChanged(object sender, EventArgs e)
        {
            if (!txtNuevaHora.Texto.Equals(""))
            {
                int ultimaPosicion = txtNuevaHora.Texto.Length - 1;
                if (ultimaPosicion == 2 && txtNuevaHora.Texto[ultimaPosicion] != ':')
                {
                    txtNuevaHora.Texto = txtNuevaHora.Texto.Substring(0, ultimaPosicion);
                    txtNuevaHora.PosicionSeleccion = txtNuevaHora.Texto.Length; // Colocar el cursor al final del texto
                }
                else if(ultimaPosicion == 0 && txtNuevaHora.Texto[ultimaPosicion] != '0' && txtNuevaHora.Texto[ultimaPosicion] != '1'
                    && txtNuevaHora.Texto[ultimaPosicion] != '2')
                {
                    txtNuevaHora.Texto = "";
                }
                else if(ultimaPosicion == 3 && txtNuevaHora.Texto[ultimaPosicion] != '0' && txtNuevaHora.Texto[ultimaPosicion] != '1'
                    && txtNuevaHora.Texto[ultimaPosicion] != '2' && txtNuevaHora.Texto[ultimaPosicion] != '3' && txtNuevaHora.Texto[ultimaPosicion] != '4'
                    && txtNuevaHora.Texto[ultimaPosicion] != '5')
                {
                    txtNuevaHora.Texto = txtNuevaHora.Texto.Substring(0, ultimaPosicion);
                    txtNuevaHora.PosicionSeleccion = txtNuevaHora.Texto.Length; // Colocar el cursor al final del texto
                }
                else if((txtNuevaHora.Texto[ultimaPosicion] == ':' && ultimaPosicion != 2) && (txtNuevaHora.Texto[ultimaPosicion] != '0' && txtNuevaHora.Texto[ultimaPosicion] != '1'
                    && txtNuevaHora.Texto[ultimaPosicion] != '2' && txtNuevaHora.Texto[ultimaPosicion] != '3' && txtNuevaHora.Texto[ultimaPosicion] != '4'
                    && txtNuevaHora.Texto[ultimaPosicion] != '5' && txtNuevaHora.Texto[ultimaPosicion] != '6' && txtNuevaHora.Texto[ultimaPosicion] != '7'
                    && txtNuevaHora.Texto[ultimaPosicion] != '8' && txtNuevaHora.Texto[ultimaPosicion] != '9') || txtNuevaHora.Texto.Length > 5)
                {
                    txtNuevaHora.Texto = txtNuevaHora.Texto.Substring(0, ultimaPosicion);
                    txtNuevaHora.PosicionSeleccion = txtNuevaHora.Texto.Length; // Colocar el cursor al final del texto
                } 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lvHorasConsulta.SelectedItems.Count > 0)
            {
                OcultarMensaje();
                if (conexion.EstablecerConexion())
                {
                    string sentencia = "DELETE FROM horas_consulta WHERE hora = '" + lvHorasConsulta.SelectedItems[0].Text + "'";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado == 0)
                        MostrarMensaje("No se ha podido eliminar la hora", "hora");
                    comando.Dispose();
                    conexion.CerrarConexion();
                    CargarHorasGeneral();
                }
            }
        }

        private void btnBuscarOdontologoNuevaReserva_Click(object sender, EventArgs e)
        {
            BuscarOdontologo buscarOdontologo = new BuscarOdontologo(ref txtOdontologo);
            buscarOdontologo.ShowDialog();
            if (ExisteOdontologo())
            {
                CargarHorasGeneral();
                ComprobarAgenda();
            }
        }

        private void btnAñadirHora_Click(object sender, EventArgs e)
        {
            if(lvHorasDisponibles.SelectedItems.Count > 0)
            {
                lvHorasAsignadas.Items.Add(lvHorasDisponibles.SelectedItems[0].Text);
                lvHorasDisponibles.Items.Remove(lvHorasDisponibles.SelectedItems[0]);
                ComprobarBotones();
            }
            
        }

        private void btnAñadirTodasHora_Click(object sender, EventArgs e)
        {
            while(lvHorasDisponibles.Items.Count > 0)
            {
                lvHorasAsignadas.Items.Add(lvHorasDisponibles.Items[0].Text);
                lvHorasDisponibles.Items.Remove(lvHorasDisponibles.Items[0]);
            }
            ComprobarBotones();
        }

        private void btnQuitarTodasHora_Click(object sender, EventArgs e)
        {
            while (lvHorasAsignadas.Items.Count > 0)
            {
                lvHorasDisponibles.Items.Add(lvHorasAsignadas.Items[0].Text);
                lvHorasAsignadas.Items.Remove(lvHorasAsignadas.Items[0]);
            }
            ComprobarBotones();
        }

        private void btnQuitarHora_Click(object sender, EventArgs e)
        {
            if (lvHorasAsignadas.SelectedItems.Count > 0)
            {
                lvHorasDisponibles.Items.Add(lvHorasAsignadas.SelectedItems[0].Text);
                lvHorasAsignadas.Items.Remove(lvHorasAsignadas.SelectedItems[0]);
                ComprobarBotones();
            }
        }

        private void btnGuardarAgenda_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            if (ExisteOdontologo())
            {
                if (lvHorasAsignadas.Items.Count > 0)
                {
                    if (conexion.EstablecerConexion())
                    {
                        MySqlCommand comando = new MySqlCommand();
                        MySqlTransaction transaccion = null;
                        DialogResult mensaje;
                        try
                        {
                            transaccion = conexion.conexionSql.BeginTransaction();
                            for(int i = 0; i < lvHorasAsignadas.Items.Count; i++)
                            {
                                string sentencia = "INSERT INTO agenda(odontologo, fecha, hora) VALUES('" + txtOdontologo.Texto + "', '" + 
                                    mcFecha.Value.ToString("yyyy-MM-dd") + "', '" + lvHorasAsignadas.Items[i].SubItems[0].Text + "')";
                                comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                comando.ExecuteNonQuery();
                                comando.Dispose();
                            }
                            transaccion.Commit();
                            LimpiarCampos();
                            mensaje = MessageBoxPersonalizadoControl.Show("Se ha guardado la agenda correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex) 
                        {
                            mensaje = MessageBoxPersonalizadoControl.Show("No se ha guardado la agenda. Error: " + ex.Message, datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            transaccion.Dispose();
                            conexion.CerrarConexion();
                        }
                    }
                }
                else
                    MostrarMensaje("Debe asignar al menos una hora", "guardar");
            }
            else
                MostrarMensaje("No existe el odontologo", "guardar");
            ComprobarBotones();
        }

        private void txtOdontologo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (ExisteOdontologo())
                {
                    CargarHorasGeneral();
                    ComprobarAgenda();
                }
                else
                    MostrarMensaje("No existe un Odontologo con ese Dni", "odontologo");
            }
        }

        private void mcFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarHorasGeneral();
            if (ExisteOdontologo())
                ComprobarAgenda();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
