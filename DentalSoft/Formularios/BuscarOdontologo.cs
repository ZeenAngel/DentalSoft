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
    public partial class BuscarOdontologo : Form
    {
        // Variables
        const int anchoMinimoDniDgv = 125;
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private TextboxPersonalizado txtOdontologo;

        // Constructores
        #region -> Constructores
        public BuscarOdontologo()
        {
            InitializeComponent();
        }

        public BuscarOdontologo(ref TextboxPersonalizado txtOdontologo)
        {
            InitializeComponent();
            this.txtOdontologo = txtOdontologo;
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
        private void CargarFiltros()
        {
            for (int i = 0; i < dgvOdontologoBuscarOdontologo.Columns.Count; i++)
                cbFiltrosBuscarOdontologo.Items.Add(dgvOdontologoBuscarOdontologo.Columns[i].HeaderText.ToString());
            cbFiltrosBuscarOdontologo.SelectedIndex = 0;
        }

        private void AjustarColumnasDgv()
        {
            dgvOdontologoBuscarOdontologo.Columns[dgvOdontologoBuscarOdontologo.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            dgvOdontologoBuscarOdontologo.Columns[0].MinimumWidth = anchoMinimoDniDgv;
            for (int i = 0; i < dgvOdontologoBuscarOdontologo.ColumnCount; i++) // No permitir editar las columnas
                dgvOdontologoBuscarOdontologo.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string odnntologo = txtOdontologoBuscarOdontologo.Texto;
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2 FROM Empleado WHERE Puesto=3 AND Activo=1";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvOdontologoBuscarOdontologo.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FiltrarOdontologos()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni, Nombre, Apellido1, Apellido2 FROM Empleado WHERE " + cbFiltrosBuscarOdontologo.Textos + " LIKE '" 
                    + txtOdontologoBuscarOdontologo.Texto + "%' AND Puesto=3 AND Activo=1";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvOdontologoBuscarOdontologo.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void txtOdontologoBuscarOdontologo__TextChanged(object sender, EventArgs e)
        {
            if (txtOdontologoBuscarOdontologo.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarOdontologos();
        }

        private void BuscarOdontologo_Load(object sender, EventArgs e)
        {
            Clases.Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(this.dgvOdontologoBuscarOdontologo);
            CargarDgv();
            CargarFiltros();
        }

        private void dgvOdontologoBuscarOdontologo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtOdontologo.Texto = dgvOdontologoBuscarOdontologo.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

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
        #endregion


    }
}
