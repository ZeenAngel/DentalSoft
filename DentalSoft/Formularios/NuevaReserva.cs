using DentalSoft.Clases;
using DentalSoft.ControlesPersonalizados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class NuevaReserva : Form
    {
        // Variables
        public Empleado empleado;
        private MenuPrincipal formPadre;
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();

        // Constructores
        #region -> Constructores
        public NuevaReserva()
        {
            InitializeComponent();
        }

        public NuevaReserva(MenuPrincipal formularioPadre)
        {
            InitializeComponent();
            this.formPadre = formularioPadre;
            this.empleado = this.formPadre.empleado;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void OcultarMensajesError()
        {
            lblErrorHoras.Visible = false;
            lblErrorOdontologoNuevaReserva.Visible = false;
            lblErrorPacienteNuevaReserva.Visible = false;
        }

        private void CargarHoras()
        {
            cbHoraNuevaReserva.Items.Clear();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Hora FROM agenda WHERE odontologo = '" + txtOdontologoNuevaReserva.Texto + "' " +
                    "AND fecha = '" + mcCalendarioNuevaReserva.Value.ToString("yyyy-MM-dd") + "' AND reservada = 0";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        cbHoraNuevaReserva.Items.Add(reader.GetString(0));
                }
                else
                    cbHoraNuevaReserva.Items.Add("Sin horas");
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
                cbHoraNuevaReserva.SelectedIndex = 0;
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtPacienteNuevaReserva.Texto = "";
            txtOdontologoNuevaReserva.Texto = "";
            cbHoraNuevaReserva.SelectedIndex = 0;
        }

        private void MostrarMensajeError(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "paciente":
                    lblErrorPacienteNuevaReserva.Text = "      " + cadena; // Los espacios iniciales es para dar espacio al mensaje de advertencia
                    lblErrorPacienteNuevaReserva.Visible = true;
                    break;
                case "odontologo":
                    lblErrorOdontologoNuevaReserva.Text = "      " + cadena; // Los espacios iniciales es para dar espacio al mensaje de advertencia
                    lblErrorOdontologoNuevaReserva.Visible = true;
                    break;
                case "horas":
                    lblErrorHoras.Text = "     " + cadena;
                    lblErrorHoras.Visible = true;
                    break;
            }
        }

        private bool ComprobarLetraDni(int dniNumeros, string letra)
        {
            bool sw = false;
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            int posicion = dniNumeros % 23;
            if (control[posicion].Equals(letra))
                sw = true;
            return sw;
        }

        private bool ComprobarDni(string etiqueta)
        {
            bool sw = false;
            if (!txtPacienteNuevaReserva.Texto.Equals(""))
            {
                string dni, numeros, letra;
                bool isNumero = false;
                switch (etiqueta)
                {
                    case "paciente":
                        dni = txtPacienteNuevaReserva.Texto.ToUpper();
                        numeros = dni.Substring(0, dni.Length - 1);
                        letra = dni.Substring(dni.Length - 1, 1);
                        if (dni.Length != 9)
                        {
                            MostrarMensajeError("El Dni debe tener una longitud de 9 caracteres", "paciente");
                            break;
                        }
                        isNumero = int.TryParse(numeros, out int dniNumeros);
                        if (!isNumero)
                        {
                            MostrarMensajeError("El Dni debe comenzar por 8 dígitos", "paciente");
                            break;
                        }
                        if (!ComprobarLetraDni(dniNumeros, letra))
                        {
                            MostrarMensajeError("La letra del Dni no es correcta", "paciente");
                            break;
                        }
                        sw = true;
                        break;
                    case "odontologo":
                        dni = txtOdontologoNuevaReserva.Texto.ToUpper();
                        numeros = dni.Substring(0, dni.Length - 1);
                        letra = dni.Substring(dni.Length - 1, 1);
                        if (dni.Length != 9)
                        {
                            MostrarMensajeError("El Dni debe tener una longitud de 9 caracteres", "odontologo");
                            break;
                        }
                        isNumero = int.TryParse(numeros, out int dniNumero);
                        if (!isNumero)
                        {
                            MostrarMensajeError("El Dni debe comenzar por 8 dígitos", "odontologo");
                            break;
                        }
                        if (!ComprobarLetraDni(dniNumero, letra))
                        {
                            MostrarMensajeError("La letra del Dni no es correcta", "odontologo");
                            break;
                        }
                        sw = true;
                        break;
                }
            }
            else
            {
                if (etiqueta.Equals("paciente"))
                    MostrarMensajeError("Debe introducir un Paciente", "paciente");
                else
                    MostrarMensajeError("Debe introducir un Odontologo", "odontologo");
            }
            return sw;
        }

        private bool ExisteDni(string etiqueta)
        {
            bool sw = false;
            string sentencia = "";
            switch (etiqueta)
            {
                case "paciente":
                    sentencia = "SELECT Dni FROM Paciente WHERE Dni='" + txtPacienteNuevaReserva.Texto.ToUpper() + "'";
                    break;
                case "odontologo":
                    sentencia = "SELECT Dni FROM Empleado WHERE Dni='" + txtOdontologoNuevaReserva.Texto.ToUpper() + "' AND Puesto=3 AND Activo=1";
                    break;
            }
            if (conexion.EstablecerConexion())
            {
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    sw = true;
                reader.Close();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private void ReservarHoraAgenda()
        {
            if(conexion.EstablecerConexion())
            {
                string sentencia = "UPDATE agenda SET reservada = 1 WHERE odontologo = '" + 
                    txtOdontologoNuevaReserva.Texto + "' AND fecha = '" + 
                    mcCalendarioNuevaReserva.Value.ToString("yyyy-MM-dd") + "' AND hora = '" + 
                    cbHoraNuevaReserva.SelectedItem.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void GuardarRegistro()
        {
            DialogResult mensaje;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "INSERT INTO Reserva(Fecha, Hora, Paciente, Odontologo) VALUES ('" + mcCalendarioNuevaReserva.Value.ToString("yyyy-MM-dd") + "', '" +
                                    cbHoraNuevaReserva.SelectedItem.ToString() + "', '" + txtPacienteNuevaReserva.Texto.ToUpper() + "', '" + txtOdontologoNuevaReserva.Texto + "')";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                int resultado = comando.ExecuteNonQuery();
                comando.Dispose();
                conexion.CerrarConexion();
                if (resultado > 0)
                {
                    ReservarHoraAgenda();
                    LimpiarCampos();
                    mensaje = MessageBoxPersonalizadoControl.Show("Reserva creada correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK);
                    Cita agenda = new Cita(formPadre);
                    agenda.MdiParent = this.MdiParent;
                    formPadre.AbrirFormularioHijo(agenda);
                    this.Close();
                }
                else
                    mensaje = MessageBoxPersonalizadoControl.Show("No se ha guardado la reserva", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnLimpiarDatosNuevaReserva_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {
            OcultarMensajesError();
            mcCalendarioNuevaReserva.MinDate = DateTime.Now;
        }

        private void btnBuscarPacienteNuevaReserva_Click(object sender, EventArgs e)
        {
            BuscarPaciente buscarP = new BuscarPaciente(ref this.txtPacienteNuevaReserva);
            buscarP.ShowDialog();
        }

        private void btnBuscarOdontologoNuevaReserva_Click(object sender, EventArgs e)
        {
            BuscarOdontologo buscarO = new BuscarOdontologo(ref this.txtOdontologoNuevaReserva);
            buscarO.ShowDialog();
            if (ExisteDni("odontologo"))
                CargarHoras();
            else
                MostrarMensajeError("No existe el odontologo seleccionado", "odontologo");
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            if (ComprobarDni("paciente"))
            {
                lblErrorPacienteNuevaReserva.Visible = false;
                if (ComprobarDni("odontologo"))
                {
                    lblErrorOdontologoNuevaReserva.Visible = false;
                    if (ExisteDni("paciente"))
                    {
                        if (ExisteDni("odontologo"))
                        {
                            if (!cbHoraNuevaReserva.SelectedItem.ToString().Equals("Sin horas"))
                                GuardarRegistro();
                            else
                                MostrarMensajeError("No hay disponible ninguna hora en esta fecha", "hora");
                        }
                        else
                        {
                            MostrarMensajeError("El Odontologo introducido no existe", "odontologo");
                        }
                    }
                    else
                    {
                        mensaje = MessageBoxPersonalizadoControl.Show("El paciente introducido no existe, ¿Quiere crear un nuevo paciente?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (mensaje == DialogResult.Yes)
                        {
                            NuevoPaciente nuevoPaciente = new NuevoPaciente(ref this.txtPacienteNuevaReserva);
                            nuevoPaciente.ShowDialog();
                            GuardarRegistro();
                        }
                        else
                            MostrarMensajeError("El paciente no existe", "paciente");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOdontologoNuevaReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (ComprobarDni("odontologo"))
                {
                    if (ExisteDni("odontologo"))
                    {
                        CargarHoras();
                    }
                }
            }
        }

        private void mcCalendarioNuevaReserva_ValueChanged(object sender, EventArgs e)
        {
            if (ExisteDni("odontologo"))
                CargarHoras();
        }
        #endregion
    }
}
