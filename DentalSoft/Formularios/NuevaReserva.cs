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
        const string txtPaciente = "paciente";
        const string txtOdontologo = "odontologo";

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
        private void CargarHoras()
        {
            
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Hora FROM Horas_Consulta";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbHoraNuevaReserva.Items.Add(reader.GetString(0));
                reader.Close();
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
                case txtPaciente:
                    lblErrorPacienteNuevaReserva.Text = "      " + cadena; // Los espacios iniciales es para dar espacio al mensaje de advertencia
                    lblErrorPacienteNuevaReserva.Visible = true;
                    break;
                case txtOdontologo:
                    lblErrorOdontologoNuevaReserva.Text = "      " + cadena; // Los espacios iniciales es para dar espacio al mensaje de advertencia
                    lblErrorOdontologoNuevaReserva.Visible = true;
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
            if(!txtPacienteNuevaReserva.Texto.Equals(""))
            {
                string dni, numeros, letra;
                bool isNumero = false;
                switch (etiqueta)
                {
                    case txtPaciente:
                        dni = txtPacienteNuevaReserva.Texto.ToUpper();
                        numeros = dni.Substring(0, dni.Length - 1);
                        letra = dni.Substring(dni.Length - 1, 1);
                        if (dni.Length != 9)
                        {
                            MostrarMensajeError("El Dni debe tener una longitud de 9 caracteres", txtPaciente);
                            break;
                        }
                        isNumero = int.TryParse(numeros, out int dniNumeros);
                        if (!isNumero)
                        {
                            MostrarMensajeError("El Dni debe comenzar por 8 dígitos", txtPaciente);
                            break;
                        }
                        if (!ComprobarLetraDni(dniNumeros, letra))
                        {
                            MostrarMensajeError("La letra del Dni no es correcta", txtPaciente);
                            break;
                        }
                        sw = true;
                        break;
                    case txtOdontologo:
                        dni = txtOdontologoNuevaReserva.Texto.ToUpper();
                        numeros = dni.Substring(0, dni.Length - 1);
                        letra = dni.Substring(dni.Length - 1, 1);
                        if (dni.Length != 9)
                        {
                            MostrarMensajeError("El Dni debe tener una longitud de 9 caracteres", txtOdontologo);
                            break;
                        }
                        isNumero = int.TryParse(numeros, out int dniNumero);
                        if (!isNumero)
                        {
                            MostrarMensajeError("El Dni debe comenzar por 8 dígitos", txtOdontologo);
                            break;
                        }
                        if (!ComprobarLetraDni(dniNumero, letra))
                        {
                            MostrarMensajeError("La letra del Dni no es correcta", txtOdontologo);
                            break;
                        }
                        sw = true;
                        break;
                }
            }
            else
            {
                if (etiqueta.Equals(txtPaciente))
                    MostrarMensajeError("Debe introducir un Paciente", txtPaciente);
                else
                    MostrarMensajeError("Debe introducir un Odontologo", txtOdontologo);
            }
            return sw;
        }

        private bool ExisteDni(string etiqueta)
        {
            bool sw = false;
            string sentencia = "";
            switch (etiqueta)
            {
                case txtPaciente:
                    sentencia = "SELECT Dni FROM Paciente WHERE Dni='" + txtPacienteNuevaReserva.Texto.ToUpper() + "'";
                    break;
                case txtOdontologo:
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

        private void GuardarRegistro()
        {
            DialogResult mensaje;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "INSERT INTO Reserva(Fecha, Hora, Paciente, Odontologo) VALUES ('" + mcCalendarioNuevaReserva.Value.ToString("yyyy-MM-dd") + "', '" +
                                    cbHoraNuevaReserva.SelectedItem.ToString() + "', '" + txtPacienteNuevaReserva.Texto.ToUpper() + "', '" + txtOdontologoNuevaReserva.Texto + "')";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    LimpiarCampos();
                    mensaje = MessageBoxPersonalizadoControl.Show("Reserva creada correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK);
                    Agenda agenda = new Agenda(formPadre);
                    agenda.MdiParent = this.MdiParent;
                    formPadre.AbrirFormularioHijo(agenda);
                    this.Close();
                }
                else
                    mensaje = MessageBoxPersonalizadoControl.Show("No se ha guardado la reserva", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conexion.CerrarConexion();
            }
            else
            {
                mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            mcCalendarioNuevaReserva.MinDate = DateTime.Now;
            CargarHoras();
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
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            if (ComprobarDni(txtPaciente))
            {
                lblErrorPacienteNuevaReserva.Visible = false;
                if (ComprobarDni(txtOdontologo))
                {
                    lblErrorOdontologoNuevaReserva.Visible = false;
                    if (ExisteDni(txtPaciente))
                    {
                        if (ExisteDni(txtOdontologo))
                        {
                            GuardarRegistro();
                        }
                        else
                        {
                            lblErrorOdontologoNuevaReserva.Text = "El Odontologo introducido no existe";
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
                            MostrarMensajeError("El paciente no existe", txtPaciente);
                    }
                } 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
