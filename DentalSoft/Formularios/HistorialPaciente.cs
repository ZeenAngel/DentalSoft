using DentalSoft.Clases;
using DentalSoft.Formularios;
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
    public partial class HistorialPaciente : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private Paciente paciente;
        private Historial historial;
        private MenuPrincipalPaciente formPadre;
        private string dni;
        private bool isEditando = false;

        // Constructores
        #region -> Constructores
        public HistorialPaciente()
        {
            InitializeComponent();
        }

        public HistorialPaciente(string dni, MenuPrincipalPaciente formPadre)
        {
            InitializeComponent();
            this.dni = dni;
            this.formPadre = formPadre;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void CrearHistorialNuevo()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "INSERT INTO Historial_Clinico VALUES('" + paciente.Dni + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                if (txtAlergias.Text.Equals(""))
                    sentencia += ", '" + datosGlobales.AlergiasPredeterminado + "'";
                else
                    sentencia += ", '" + txtAlergias.Text + "'";
                if (txtMedicacion.Text.Equals(""))
                    sentencia += ", '" + datosGlobales.MedicacionPredeterminado + "'";
                else
                    sentencia += ", '" + txtMedicacion.Text + "'";
                if (txtObservaciones.Text.Equals(""))
                    sentencia += ", NULL)";
                else
                    sentencia += ", '" + txtObservaciones.Text + "')";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
                historial.CargarHistorial();
                RellenarHistorial();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RellenarHistorial()
        {
            lblPaciente.Text = paciente.Nombre + " " + paciente.Apellido1;
            if (paciente.Apellido2 != null)
                lblPaciente.Text += " " + paciente.Apellido2;
            txtAlergias.Text = historial.Alergias;
            txtMedicacion.Text = historial.Medicacion;
            txtObservaciones.Text = historial.Observaciones;
        }

        private void GuardarCambios()
        {
            if (this.isEditando)
            {
                if (conexion.EstablecerConexion())
                {
                    string sentencia = "UPDATE Historial_Clinico SET Alergias='" + txtAlergias.Text + "', Medicacion='" + txtMedicacion + "'";
                    if (!txtObservaciones.Equals(""))
                        sentencia += ", Observaciones='" + txtObservaciones.Text + "' ";
                    sentencia += "WHERE Paciente='" + historial.Paciente + "'";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    comando.ExecuteNonQuery();
                    DeshabilitarEdicion();
                }
                else
                {
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                HabilitarEdicion();
        }

        private void DeshabilitarEdicion()
        {
            btnEditar.Text = "Editar Historial";
            txtAlergias.Enabled = false;
            txtAlergias.BackColor = Color.FromArgb(236, 236, 236);
            txtMedicacion.Enabled = false;
            txtMedicacion.BackColor = Color.FromArgb(236, 236, 236);
            txtObservaciones.Enabled = false;
            txtObservaciones.BackColor = Color.FromArgb(236, 236, 236);
            this.isEditando = false;
        }

        private void HabilitarEdicion()
        {
            txtAlergias.Enabled = true;
            txtAlergias.BackColor = Color.White;
            txtMedicacion.Enabled = true;
            txtMedicacion.BackColor = Color.White;
            txtObservaciones.Enabled = true;
            txtObservaciones.BackColor = Color.White;
            btnEditar.Text = "Guardar Historial";
            this.isEditando = true;
        }
        #endregion

        // Eventos
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistorialPaciente_Load(object sender, EventArgs e)
        {
            paciente = new Paciente(this.dni);
            paciente.CargarPaciente();
            historial = new Historial(paciente.Dni);
            if (historial.CargarHistorial())
                RellenarHistorial();
            else
                CrearHistorialNuevo();
            DeshabilitarEdicion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void btnEpisodios_Click(object sender, EventArgs e)
        {
            EpisodiosClinicos episodiosClinicos = new EpisodiosClinicos(this.dni, this.formPadre);
            formPadre.AbrirFormularioHijo(episodiosClinicos);
        }
    }
}
