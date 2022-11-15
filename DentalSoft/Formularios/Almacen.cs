using DentalSoft.Clases;
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

namespace DentalSoft.Formularios
{
    public partial class Almacen : Form
    {
        // Variables
        private MenuPrincipal formPadre;
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        private const int anchoMinimoDniDgv = 100;

        // Constructores
        #region -> Constructores
        public Almacen()
        {
            InitializeComponent();
        }

        public Almacen(MenuPrincipal formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void LimpiarCampos()
        {
            txtProducto.Texto = "";
            cbFiltros.SelectedIndex = 0;
        }

        private void CargarFiltros()
        {
            for (int i = 0; i < dgvProductos.Columns.Count; i++)
                cbFiltros.Items.Add(dgvProductos.Columns[i].HeaderText.ToString());
            cbFiltros.SelectedIndex = 0;
        }

        private void AjustarColumnasDgv()
        {
            for(int i = 0; i < dgvProductos.ColumnCount - 1; i++)
                dgvProductos.Columns[i].MinimumWidth = anchoMinimoDniDgv;
            dgvProductos.Columns[dgvProductos.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvProductos.ColumnCount; i++) // No permitir editar las columnas
                dgvProductos.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT producto.Referencia, producto.Descripcion, producto.Cantidad, producto.Coste, producto.fecha_caducidad AS Caducidad, producto.Lote, " +
                    "categoria_producto.Descripcion, almacen.Nombre FROM Producto INNER JOIN categoria_producto ON categoria_producto.Id = producto.Categoria " +
                    "INNER JOIN almacen ON almacen.Id = producto.Almacen";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvProductos.DataSource = tabla;
                tabla.Dispose();
                comando.Dispose();
                conexion.CerrarConexion();
                AjustarColumnasDgv();
                ComprobarCaducados();
            }
        }

        private void FiltrarProducto()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT producto.Referencia, producto.Descripcion, producto.Cantidad, producto.Coste, producto.fecha_caducidad AS Caducidad, producto.Lote, " +
                    "categoria_producto.Descripcion, almacen.Nombre FROM Producto INNER JOIN categoria_producto ON categoria_producto.Id = producto.Categoria " +
                    "INNER JOIN almacen ON almacen.Id = producto.Almacen WHERE " + cbFiltros.Textos + " LIKE '" + txtProducto.Texto + "%'"; 
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvProductos.DataSource = tabla;
                tabla.Dispose();
                comando.Dispose();
                conexion.CerrarConexion();
                AjustarColumnasDgv();
                ComprobarCaducados();
            }
        }

        private void ComprobarCaducados()
        {
            bool caducado = false;
            bool caducaHoy = false;
            DateTime fecha;
            int cantidad;
            foreach(DataGridViewRow fila in dgvProductos.Rows)
            {
                fecha = DateTime.Parse(fila.Cells["Caducidad"].Value.ToString());
                cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                if (DateTime.Compare(fecha, DateTime.Now) < 0 && cantidad > 0) // El producto ESTÁ caducado
                { 
                    fila.DefaultCellStyle.BackColor = Color.IndianRed;
                    caducado = true;
                }
                else if (DateTime.Compare(fecha, DateTime.Now) == 0 && cantidad > 0) // El producto caduca HOY
                {
                    fila.DefaultCellStyle.BackColor = Color.GreenYellow;
                    caducaHoy = true;
                }
            }
            if (caducado && caducaHoy)
            {
                lblErrorCaducado.Text = "Hay productos caducados y productos que caducan hoy";
                lblErrorCaducado.Visible = true;
            }
            else if (caducado)
            {
                lblErrorCaducado.Text = "Hay productos caducados";
                lblErrorCaducado.Visible = true;
            }
            else if (caducaHoy)
            {
                lblErrorCaducado.Text = "Hay productos que caducan hoy";
                lblErrorCaducado.Visible = true;
            }
            else
                lblErrorCaducado.Visible = false;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Almacen_Load(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvProductos);
            CargarDgv();
            CargarFiltros();
        }

        private void cbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducto();
        }

        private void txtProducto__TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarProducto();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoProducto = new NuevoProducto();
            nuevoProducto.ShowDialog();
            LimpiarCampos();
            CargarDgv();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                string referencia = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString();
                NuevoProducto nuevoProducto = new NuevoProducto(referencia);
                nuevoProducto.ShowDialog();
                LimpiarCampos();
                CargarDgv();
                ComprobarCaducados();
            }
            else
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar un producto de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            if (dgvProductos.SelectedRows.Count > 0) // Comprobar si hay seleccionada alguna fila
            {
                string referencia = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString();
                mensaje = MessageBoxPersonalizadoControl.Show("¿Seguro que quiere eliminar este producto?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mensaje == DialogResult.Yes)
                {
                    if (conexion.EstablecerConexion())
                    {
                        string sentencia = "DELETE FROM producto WHERE referencia ='" + referencia + "'";
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                        conexion.CerrarConexion();
                        LimpiarCampos();
                        CargarDgv();
                    }
                }
            }
            else
            {
                mensaje = MessageBoxPersonalizadoControl.Show("Debe seleccionar un producto de la lista", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionarAlmacenes_Click(object sender, EventArgs e)
        {
            GestionarAlmacen gestionarAlmacen = new GestionarAlmacen(this.formPadre);
            formPadre.AbrirFormularioHijo(gestionarAlmacen);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // TODO: Crear un formulario en el que se muestren informes del inventario, por categoría o por almacén
        }
        #endregion
    }
}
