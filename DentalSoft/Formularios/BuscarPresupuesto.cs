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
    public partial class BuscarPresupuesto : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        private TextboxPersonalizado textboxPresupuesto;

        // Constructores
        public BuscarPresupuesto()
        {
            InitializeComponent();
        }

        public BuscarPresupuesto(ref TextboxPersonalizado txtPresupuesto)
        {
            InitializeComponent();
            this.textboxPresupuesto = txtPresupuesto;
        }

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        #endregion

        // Métodos privados
        private void CargarFiltros()
        {
            for (int i = 0; i < dgvPresupuestos.Columns.Count; i++)
                cbFiltros.Items.Add(dgvPresupuestos.Columns[i].HeaderText.ToString());
            cbFiltros.SelectedIndex = 0;
        }

        private void AjustarColumnasDgv()
        {
            dgvPresupuestos.Columns[0].MinimumWidth = 220;
            dgvPresupuestos.Columns[1].MinimumWidth = 160;
            dgvPresupuestos.Columns[2].MinimumWidth = 160;
            dgvPresupuestos.Columns[dgvPresupuestos.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvPresupuestos.ColumnCount; i++) // No permitir editar las columnas
                dgvPresupuestos.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string presupuesto = txtPresupuesto.Texto;
                string sentencia = "SELECT * FROM Presupuesto";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvPresupuestos.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FiltrarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Presupuesto WHERE " + cbFiltros.Textos + " LIKE '"
                    + txtPresupuesto.Texto + "%'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvPresupuestos.DataSource = tabla;
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("No se ha podido conectar a la base de datos", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Eventos
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

        private void BuscarPresupuesto_Load(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvPresupuestos);
            CargarDgv();
            CargarFiltros();
        }

        private void txtPresupuesto__TextChanged(object sender, EventArgs e)
        {
            if (txtPresupuesto.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarDgv();
        }

        private void dgvPresupuestos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textboxPresupuesto.Texto = dgvPresupuestos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
