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
    public partial class TratamientoPaciente : Form
    {
        // Variables
        #region -> Variables
        DatosGlobales datosGlobales = new DatosGlobales();
        Paciente paciente;
        private const int anchoMinimo = 150;
        #endregion

        // Constructores
        #region -> Constructores
        public TratamientoPaciente()
        {
            InitializeComponent();
        }

        public TratamientoPaciente(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }

        public TratamientoPaciente(int reserva)
        {
            InitializeComponent();
            CargarReserva(reserva);
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
        private void AjustarColumnasDgv()
        {
            dgvHistorial.Columns[0].MinimumWidth = anchoMinimo;
            dgvHistorial.Columns[2].MinimumWidth = anchoMinimo;
            dgvHistorial.Columns[3].MinimumWidth = anchoMinimo;
            dgvHistorial.Columns[dgvHistorial.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvHistorial.ColumnCount; i++) // No permitir editar las columnas
                dgvHistorial.Columns[i].ReadOnly = true;
        }

        private bool isSeleccionadoTodo()
        {
            bool sw = false;
            if (btnOclusal.Text.Equals("X") && btnVestibular.Text.Equals("X") && btnLingual.Text.Equals("X") && btnDistal.Text.Equals("X") && btnMesial.Text.Equals("X"))
            {
                if (isMolarInferior(int.Parse(cbPieza.SelectedItem.ToString())))
                {
                    if (btnRaizIzquierda.Text.Equals("X") && btnRaizDerecha.Text.Equals("X"))
                        sw = true;
                }
                else if (isMolarSuperior(int.Parse(cbPieza.SelectedItem.ToString())))
                {
                    if (btnRaizIzquierda.Text.Equals("X") && btnRaizCentral.Text.Equals("X") && btnRaizDerecha.Text.Equals("X"))
                        sw = true;
                }
                else
                {
                    if (btnRaiz.Text.Equals("X"))
                        sw = true;
                }
            }
            return sw;
        }

        private void LimpiarSeleccion()
        {
            btnRaiz.Text = "";
            btnRaiz.BackColor = Color.White;
            btnRaizCentral.Text = "";
            btnRaizCentral.BackColor = Color.White;
            btnRaizDerecha.Text = "";
            btnRaizDerecha.BackColor = Color.White;
            btnRaizIzquierda.Text = "";
            btnRaizIzquierda.BackColor = Color.White;
            btnOclusal.Text = "";
            btnOclusal.BackColor = Color.White;
            btnLingual.Text = "";
            btnLingual.BackColor = Color.White;
            btnDistal.Text = "";
            btnDistal.BackColor = Color.White;
            btnMesial.Text = "";
            btnMesial.BackColor = Color.White;
            btnVestibular.Text = "";
            btnVestibular.BackColor = Color.White;
        }

        private void OcultarRaicesMolares()
        {
            btnRaiz.Enabled = true;
            btnRaiz.Visible = true;
            btnRaizIzquierda.Enabled = false;
            btnRaizIzquierda.Visible = false;
            btnRaizDerecha.Enabled = false;
            btnRaizDerecha.Visible = false;
            btnRaizCentral.Enabled = false;
            btnRaizCentral.Visible = false;
        }

        private void MostrarRaicesMolares()
        {
            btnRaiz.Enabled = false;
            btnRaiz.Visible = false;
            btnRaizCentral.Enabled = false;
            btnRaizCentral.Visible = false;
            btnRaizIzquierda.Enabled = true;
            btnRaizIzquierda.Visible = true;
            btnRaizDerecha.Enabled = true;
            btnRaizDerecha.Visible = true;
        }

        private void MostrarRaicesSuperiores()
        {
            btnRaizCentral.Enabled = true;
            btnRaizCentral.Visible = true;
        }

        private void CargarReserva(int reserva)
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Reserva WHERE Id=" + reserva;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                paciente = new Paciente(reader.GetString(3));
                paciente.CargarPaciente();
                paciente.CargarOdontograma();
                conexion.CerrarConexion();
            }
        }

        private void CargarDatosPaciente()
        {
            lblNombre.Text = paciente.Nombre + " " + paciente.Apellido1 + " " + paciente.Apellido2;
            lblEdad.Text = paciente.Edad + " años";
            if (paciente.Genero.Equals("M"))
                lblGenero.Text = "Masculino";
            else
                lblGenero.Text = "Femenino";
        }

        private void CargarPiezas()
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Id FROM Pieza";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbPieza.Items.Add(reader.GetString(0));
                reader.Close();
                cbPieza.SelectedIndex = 0;
                conexion.CerrarConexion();
            }
        }

        private void CargarDiagnosticos()
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Nombre FROM Diagnostico";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbDiagnostico.Items.Add(reader.GetString(0));
                reader.Close();
                cbDiagnostico.SelectedIndex = 0;
                conexion.CerrarConexion();
            }
        }

        private void CargarTratamientos()
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Nombre FROM Tratamiento";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbTratamiento.Items.Add(reader.GetString(0));
                reader.Close();
                cbTratamiento.SelectedIndex = 0;
                conexion.CerrarConexion();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarComboBox()
        {
            CargarPiezas();
            CargarDiagnosticos();
            CargarTratamientos();
        }

        private void ComprobarPieza()
        {
            int pieza = int.Parse(cbPieza.SelectedItem.ToString());
            if (isMolarSuperior(pieza))
            {
                MostrarRaicesMolares();
                MostrarRaicesSuperiores();
            }
            else if (isMolarInferior(pieza))
                MostrarRaicesMolares();
            else
                OcultarRaicesMolares();
        }

        private bool isMolarSuperior(int pieza)
        {
            if (pieza == 16 || pieza == 17 || pieza == 18 || pieza == 26 || pieza == 27 || pieza == 28)
                return true;
            else
                return false;
        }

        private bool isMolarInferior(int pieza)
        {
            if (pieza == 36 || pieza == 37 || pieza == 38 || pieza == 46 || pieza == 47 || pieza == 48)
                return true;
            else
                return false;
        }

        private void CargarDgv()
        {
            ConexionBD conexion = new ConexionBD();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT episodio_clinico.Fecha, episodio_clinico.Pieza, seccion.Nombre AS Seccion, diagnostico.Nombre AS Diagnostico, tratamiento.Nombre AS Tratamiento " +
                    "FROM episodio_clinico INNER JOIN seccion ON episodio_clinico.Seccion = seccion.Id INNER JOIN diagnostico ON episodio_clinico.Diagnostico = diagnostico.Id " +
                    "INNER JOIN tratamiento ON episodio_clinico.Tratamiento = tratamiento.Id WHERE episodio_clinico.Historial='" + this.paciente.Dni + "' ORDER BY episodio_clinico.Fecha DESC";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvHistorial.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int ClaveSeccion(ConexionBD conexion, string seccion)
        {
            int clave = 0;
            string sentencia = "SELECT Id FROM Seccion WHERE Nombre='" + seccion + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            clave = reader.GetInt32(0);
            reader.Close();
            return clave;
        }

        private int ClaveDiagnostico(ConexionBD conexion)
        {
            int clave = 0;
            string sentencia = "SELECT Id FROM Diagnostico WHERE Nombre='" + cbDiagnostico.SelectedItem.ToString() + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            clave = reader.GetInt32(0);
            reader.Close();
            return clave;
        }

        private int ClaveTratamiento(ConexionBD conexion)
        {
            int clave = 0;
            string sentencia = "SELECT Id FROM Tratamiento WHERE Nombre='" + cbTratamiento.SelectedItem.ToString() + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            clave = reader.GetInt32(0);
            reader.Close();
            return clave;
        }
        #endregion

        // Eventos
        #region -> Eventos
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

        private void TratamientoPaciente_Load(object sender, EventArgs e)
        {
            CargarDatosPaciente();
            CargarComboBox();
            OcultarRaicesMolares();
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvHistorial);
            CargarDgv();
        }

        private void cbPieza_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarSeleccion();
            ComprobarPieza();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarSeleccion();
        }

        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            btnVestibular.Text = "X";
            btnVestibular.BackColor = Color.DimGray;
            btnLingual.Text = "X";
            btnLingual.BackColor = Color.DimGray;
            btnDistal.Text = "X";
            btnDistal.BackColor = Color.DimGray;
            btnMesial.Text = "X";
            btnMesial.BackColor = Color.DimGray;
            btnOclusal.Text = "X";
            btnOclusal.BackColor = Color.DimGray;
            if (isMolarSuperior(int.Parse(cbPieza.SelectedItem.ToString())))
            {
                btnRaizIzquierda.Text = "X";
                btnRaizIzquierda.BackColor = Color.DimGray;
                btnRaizDerecha.Text = "X";
                btnRaizDerecha.BackColor = Color.DimGray;
                btnRaizCentral.Text = "X";
                btnRaizCentral.BackColor = Color.DimGray;
            }
            else if (isMolarInferior(int.Parse(cbPieza.SelectedItem.ToString())))
            {
                btnRaizIzquierda.Text = "X";
                btnRaizIzquierda.BackColor = Color.DimGray;
                btnRaizDerecha.Text = "X";
                btnRaizDerecha.BackColor = Color.DimGray;
            }
            else
            {
                btnRaiz.Text = "X";
                btnRaiz.BackColor = Color.White;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            string sentencia = "INSERT INTO Episodio_clinico(Historial, Fecha, Pieza, Seccion, Diagnostico, Tratamiento) VALUES ('" +
                paciente.Dni + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + cbPieza.SelectedItem.ToString() + ", ";
            if (conexion.EstablecerConexion())
            {
                if (isSeleccionadoTodo())
                {
                    sentencia += "1, " + ClaveDiagnostico(conexion) + ", " + ClaveTratamiento(conexion) + ")";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    foreach (Button boton in gbSeccion.Controls.OfType<Button>())
                    {
                        if (!boton.Name.Equals("btnLimpiar") && !boton.Name.Equals("btnSeleccionarTodo"))
                        {
                            if (boton.Text.Equals("X"))
                            {
                                sentencia = "INSERT INTO Episodio_clinico(Historial, Fecha, Pieza, Seccion, Diagnostico, Tratamiento) VALUES ('" +
                                paciente.Dni + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + cbPieza.SelectedItem.ToString() + ", " +
                                ClaveSeccion(conexion, boton.Tag.ToString()) + ", " + ClaveDiagnostico(conexion) + ", " + ClaveTratamiento(conexion) + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                comando.ExecuteNonQuery();
                            }
                        }
                    }
                }
                conexion.CerrarConexion();
                CargarDgv();
            }
            
        }

        private void btnVestibular_Click(object sender, EventArgs e)
        {
            if (btnVestibular.Text.Equals("X"))
            {
                btnVestibular.Text = "";
                btnVestibular.BackColor = Color.White;
            }
            else
            {
                btnVestibular.Text = "X";
                btnVestibular.BackColor = Color.DimGray;
            }
        }

        private void btnDistal_Click(object sender, EventArgs e)
        {
            if (btnDistal.Text.Equals("X"))
            {
                btnDistal.Text = "";
                btnDistal.BackColor = Color.White;
            }
            else
            {
                btnDistal.Text = "X";
                btnDistal.BackColor = Color.DimGray;
            }
        }

        private void btnOclusal_Click(object sender, EventArgs e)
        {
            if (btnOclusal.Text.Equals("X"))
            {
                btnOclusal.Text = "";
                btnOclusal.BackColor = Color.White;
            }
            else
            {
                btnOclusal.Text = "X";
                btnOclusal.BackColor = Color.DimGray;
            }
        }

        private void btnMesial_Click(object sender, EventArgs e)
        {
            if (btnMesial.Text.Equals("X"))
            {
                btnMesial.Text = "";
                btnMesial.BackColor = Color.White;
            }
            else
            {
                btnMesial.Text = "X";
                btnMesial.BackColor = Color.DimGray;
            }
        }

        private void btnLingual_Click(object sender, EventArgs e)
        {
            if (btnLingual.Text.Equals("X"))
            {
                btnLingual.Text = "";
                btnLingual.BackColor = Color.White;
            }
            else
            {
                btnLingual.Text = "X";
                btnLingual.BackColor = Color.DimGray;
            }
        }

        private void btnRaizIzquierda_Click(object sender, EventArgs e)
        {
            if (btnRaizIzquierda.Text.Equals("X"))
            {
                btnRaizIzquierda.Text = "";
                btnRaizIzquierda.BackColor = Color.White;
            }
            else
            {
                btnRaizIzquierda.Text = "X";
                btnRaizIzquierda.BackColor = Color.DimGray;
            }
        }

        private void btnRaizDerecha_Click(object sender, EventArgs e)
        {
            if (btnRaizDerecha.Text.Equals("X"))
            {
                btnRaizDerecha.Text = "";
                btnRaizDerecha.BackColor = Color.White;
            }
            else
            {
                btnRaizDerecha.Text = "X";
                btnRaizDerecha.BackColor = Color.DimGray;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (btnRaiz.Text.Equals("X"))
            {
                btnRaiz.Text = "";
                btnRaiz.BackColor = Color.White;
            }
            else
            {
                btnRaiz.Text = "X";
                btnRaiz.BackColor = Color.DimGray;
            }
        }

        private void btnRaizCentral_Click_1(object sender, EventArgs e)
        {
            if (btnRaizCentral.Text.Equals("X"))
            {
                btnRaizCentral.Text = "";
                btnRaizCentral.BackColor = Color.White;
            }
            else
            {
                btnRaizCentral.Text = "X";
                btnRaizCentral.BackColor = Color.DimGray;
            }
        }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


    }
}
