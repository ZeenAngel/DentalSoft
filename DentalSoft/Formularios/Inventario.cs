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
    public partial class Inventario : Form
    {
        // Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();

        // Constructor
        public Inventario()
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
        private void MostrarMensaje(string cadena)
        {
            lblErrorFiltro.Text = "     " + cadena;
            lblErrorFiltro.Visible = true;
        }

        private void OcultarMensaje()
        {
            lblErrorFiltro.Visible = false;
        }

        private void OcultarFiltros()
        {
            lblCategorias.Visible = false;
            lblAlmacen.Visible = false;
            lblFechaInicio.Visible = false;
            lblFechaFin.Visible = false;
            cbCategorias.Visible = false;
            cbAlmacen.Visible = false;
            mcFechaInicio.Visible = false;
            mcFechaFin.Visible = false;
        }

        private void LimpiarCampos()
        {
            OcultarFiltros();
            cbFiltros.SelectedIndex = 0;
            cbCategorias.SelectedIndex = 0;
            cbAlmacen.SelectedIndex = 0;
            mcFechaInicio.Value = DateTime.Now;
            mcFechaFin.Value = DateTime.Now;
        }

        private void CargarComboFiltros()
        {
            cbFiltros.Items.Add("");
            cbFiltros.Items.Add("Categoría");
            cbFiltros.Items.Add("Almacén");
            cbFiltros.Items.Add("Fecha");
        }

        private void CargarCategorias()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT descripcion FROM categoria_producto";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    List<string> categorias = new List<string>();
                    while (reader.Read())
                        categorias.Add(reader.GetString(0));
                    foreach (string categoria in categorias)
                        cbCategorias.Items.Add(categoria);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void CargarAlmacenes()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT nombre FROM almacen";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    List<string> almacenes = new List<string>();
                    while (reader.Read())
                        almacenes.Add(reader.GetString(0));
                    foreach (string almacen in almacenes)
                        cbAlmacen.Items.Add(almacen);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void CargarInventarioCompleto()
        {
            this.productoTableAdapter.Fill(this.dataSetInventario.Producto);
            this.rvInventario.RefreshReport();
        }

        private int GetIdCategoria()
        {
            int idCategoria = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT id FROM categoria_producto WHERE descripcion = '" + cbCategorias.SelectedItem.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    idCategoria = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return idCategoria;
        }

        private int GetIdAlmacen()
        {
            int idAlmacen = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT id FROM almacen WHERE nombre = '" + cbAlmacen.SelectedItem.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    idAlmacen = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return idAlmacen;
        }

        private bool ComprobarFechas()
        {
            bool sw = false;
            if (DateTime.Compare(mcFechaInicio.Value, mcFechaFin.Value) <= 0) // Si la fecha de inicio es anterior a la de fin
                sw = true;
            return sw;
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

        private void Inventario_Load(object sender, EventArgs e)
        {
            OcultarMensaje();
            OcultarFiltros();
            CargarComboFiltros();
            CargarCategorias();
            CargarAlmacenes();
            CargarInventarioCompleto();
        }

        private void cbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarFiltros();
            switch (cbFiltros.SelectedItem.ToString())
            {
                case "Categoría":
                    lblCategorias.Visible = true;
                    cbCategorias.Visible = true;
                    break;
                case "Almacén":
                    lblAlmacen.Visible = true;
                    cbAlmacen.Visible = true;
                    break;
                case "Fecha":
                    lblFechaInicio.Visible = true;
                    mcFechaInicio.Visible = true;
                    lblFechaFin.Visible = true;
                    mcFechaFin.Visible = true;
                    break;
                default:
                    LimpiarCampos();
                    CargarInventarioCompleto();
                    break;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (cbFiltros.SelectedItem.ToString())
            {
                case "Categoría":
                    int categoria = GetIdCategoria();
                    this.productoTableAdapter.FillByCategoria(this.dataSetInventario.Producto, categoria);
                    this.rvInventario.RefreshReport();
                    break;
                case "Almacén":
                    int almacen = GetIdAlmacen();
                    this.productoTableAdapter.FillByAlmacen(this.dataSetInventario.Producto, almacen);
                    this.rvInventario.RefreshReport();
                    break;
                case "Fecha":
                    if (ComprobarFechas()) // La fecha de inicio es anterior a la de fin
                    {
                        this.productoTableAdapter.FillByFecha(this.dataSetInventario.Producto, mcFechaInicio.Value, mcFechaFin.Value);
                        this.rvInventario.RefreshReport();
                    }
                    else
                        MostrarMensaje("La fecha de inicio no puede ser posterior a la de fin");
                    break;
                default:
                    CargarInventarioCompleto();
                    break;
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            OcultarFiltros();
            LimpiarCampos();
            this.productoTableAdapter.Fill(this.dataSetInventario.Producto);
            this.rvInventario.RefreshReport();
        }
    }
}
