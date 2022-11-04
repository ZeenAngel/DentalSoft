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

namespace DentalSoft
{
    public partial class EditarReserva : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        int idReserva;
        string fecha = "";
        string hora = "";

        // Constructores
        #region -> Constructores
        public EditarReserva()
        {
            InitializeComponent();
        }

        public EditarReserva(int idReserva)
        {
            InitializeComponent();
            this.idReserva = idReserva;
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
        private void CargarHoras() // NO ESTABLECE LA HORA CORRECTAMENTE
        {

            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Hora FROM Horas_Consulta";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    cbHorasEditarReserva.Items.Add(reader.GetString(0));
                reader.Close();
                conexion.CerrarConexion();
                if (! this.hora.Equals(""))
                {
                    for(int i = 0; i < cbHorasEditarReserva.Items.Count; i++)
                    {
                        if (cbHorasEditarReserva.Items[i].ToString().Equals(this.hora))
                        {
                            cbHorasEditarReserva.SelectedIndex = i;
                            break;
                        }
                    }
                }else
                    cbHorasEditarReserva.SelectedIndex = 0;
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EstablecerFecha() // MODIFICAR PARECE QUE NO FUNCIONA
        {
            if(! this.fecha.Equals(""))
                mcFechaEditarReserva.Value = DateTime.Parse(this.fecha);
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EditarReserva_Load(object sender, EventArgs e)
        {
            mcFechaEditarReserva.MinDate = DateTime.Now;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT DATE_FORMAT(r.Fecha, \"%d-%m-%Y\"), r.Hora, p.Nombre, p.Apellido1, p.Apellido2, e.Nombre, e.Apellido1, e.Apellido2 " +
                    "FROM Reserva AS r INNER JOIN Paciente AS p ON r.Paciente=p.Dni INNER JOIN Empleado AS e ON e.DNI=r.Odontologo WHERE r.Id=" + idReserva;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows) { 
                    reader.Read();
                    this.fecha = reader.GetString(0);
                    this.hora = reader.GetString(1);
                    lblPacienteEditarReserva.Text = reader.GetString(2);
                    lblApellidosEditarReserva.Text = reader.GetString(3) + " " + reader.GetString(4);
                    lblNombreOdontologoEditarReserva.Text = reader.GetString(5);
                    lblApellidosOdontologoEditarReserva.Text = reader.GetString(6) + " " + reader.GetString(7);
                }
                reader.Close();
                conexion.CerrarConexion();
                CargarHoras();
                EstablecerFecha();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido establecer la conexión con la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarNuevaReserva_Click(object sender, EventArgs e)
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "UPDATE Reserva SET Fecha='" + mcFechaEditarReserva.Value.ToString("yyyy-MM-dd") + "', Hora='" +
                                    cbHorasEditarReserva.SelectedItem.ToString() + "' WHERE Id=" + idReserva;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                this.Close();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


    }
}
