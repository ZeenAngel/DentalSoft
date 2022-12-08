using DentalSoft.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        private List<DataGridViewRow> filasEliminar = new List<DataGridViewRow>();
        private const int anchoMinimoDniDgv = 140;

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
        private void MostrarMensaje(string cadena)
        {
            lblErrorCaducado.Text = "     " + cadena;
            lblErrorCaducado.Visible = true;
        }

        private void OcultarMensaje()
        {
            lblErrorCaducado.Visible = false;
        }

        private void MostrarTextbox()
        {
            txtProducto.Visible = true;
            lblFecha.Visible = false;
            mcFiltrarFecha.Visible = false;
        }

        private void MostrarFecha()
        {
            txtProducto.Visible = false;
            lblFecha.Visible = true;
            mcFiltrarFecha.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtProducto.Texto = "";
            cbFiltros.SelectedIndex = 0;
        }

        private void CargarFiltros()
        {
            cbFiltros.Items.Add("Dinámico");
            for (int i = 0; i < dgvProductos.Columns.Count; i++)
                cbFiltros.Items.Add(dgvProductos.Columns[i].HeaderText.ToString());
            cbFiltros.SelectedIndex = 0;
        }

        private void AjustarColumnasDgv()
        {
            for (int i = 0; i < dgvProductos.ColumnCount - 1; i++)
                dgvProductos.Columns[i].MinimumWidth = anchoMinimoDniDgv;
            dgvProductos.Columns[dgvProductos.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvProductos.ColumnCount; i++) // No permitir editar las columnas
                dgvProductos.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT producto.Referencia, producto.Descripcion AS Nombre, producto.Cantidad, producto.Coste, producto.fecha_caducidad AS Caducidad, producto.Lote, " +
                    "categoria_producto.Descripcion AS Categoría, almacen.Nombre AS Almacén FROM Producto INNER JOIN categoria_producto ON categoria_producto.Id = producto.Categoria " +
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
            }
        }

        private void CargarDgvDinamico()
        {
            foreach(DataGridViewRow fila in filasEliminar)
                dgvProductos.Rows.Remove(fila);
            filasEliminar.Clear();
        }

        private void FiltrarProducto()
        {
            if (conexion.EstablecerConexion())
            {
                string filtro = "";
                string texto = txtProducto.Texto;
                bool contiene;
                if (cbFiltros.Textos.Equals("Dinámico") && !txtProducto.Texto.Equals(""))
                {
                    filasEliminar.Clear();
                    for (int i = 0; i < dgvProductos.RowCount; i++)
                    {
                        contiene = false;
                        for (int j = 0; j < dgvProductos.Rows[i].Cells.Count; j++)
                        {
                            if (dgvProductos.Rows[i].Cells[j].Value.ToString().Contains(txtProducto.Texto))
                            {
                                contiene = true;
                                break;
                            }
                        }
                        if (!contiene)
                            filasEliminar.Add(dgvProductos.Rows[i]);
                    }
                    CargarDgvDinamico();
                }
                else
                {
                    switch (cbFiltros.Textos)
                    {
                        case "Referencia":
                            filtro = "producto.Referencia";
                            break;
                        case "Nombre":
                            filtro = "producto.Descripcion";
                            break;
                        case "Cantidad":
                            filtro = "producto.Cantidad";
                            break;
                        case "Coste":
                            filtro = "producto.Coste";
                            break;
                        case "Caducidad":
                            filtro = "producto.fecha_caducidad";
                            texto = mcFiltrarFecha.Value.ToString("yyyy-MM-dd");
                            break;
                        case "Lote":
                            filtro = "producto.Lote";
                            break;
                        case "Categoría":
                            filtro = "categoria_producto.Descripcion";
                            break;
                        case "Almacén":
                            filtro = "almacen.Nombre";
                            break;
                        default:
                            filtro = "1";
                            break;
                    }
                    string sentencia = "SELECT producto.Referencia, producto.Descripcion AS Nombre, producto.Cantidad, producto.Coste, producto.fecha_caducidad AS Caducidad, producto.Lote, " +
                        "categoria_producto.Descripcion AS Categoría, almacen.Nombre AS Almacén FROM Producto INNER JOIN categoria_producto ON categoria_producto.Id = producto.Categoria " +
                        "INNER JOIN almacen ON almacen.Id = producto.Almacen WHERE " + filtro + " LIKE '" + texto + "%'";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    dgvProductos.DataSource = tabla;
                    tabla.Dispose();
                    comando.Dispose();
                }
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Almacen_Load(object sender, EventArgs e)
        {
            OcultarMensaje();
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvProductos);
            CargarDgv();
            CargarFiltros();
            txtProducto.Focus();
        }

        private void cbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltros.SelectedItem.ToString().Equals("Sin filtrar"))
            {
                MostrarTextbox();
                CargarDgv();
            }
            else if (cbFiltros.SelectedItem.ToString().Equals("Caducidad"))
            {
                MostrarFecha();
                FiltrarProducto();
            }
            else
            {
                MostrarTextbox();
                FiltrarProducto();
            }
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
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
        }

        private void mcFiltrarFecha_CloseUp(object sender, EventArgs e)
        {
            FiltrarProducto();
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Caducidad"))
            {
                bool caducado = false;
                bool caducaSemana = false;
                DateTime fechaCaducidad = DateTime.Parse(e.Value.ToString());
                DateTime fechaSemanaAntes = fechaCaducidad.AddDays(-7);
                fechaSemanaAntes = fechaSemanaAntes.AddDays(-7); // Le resto 7 días a la fecha actual
                int cantidad = int.Parse(dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                if (DateTime.Compare(fechaCaducidad, DateTime.Now) < 0 && cantidad > 0) // El producto ESTÁ caducado
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                    caducado = true;
                }
                else if (DateTime.Compare(fechaSemanaAntes, DateTime.Now) <= 0 && cantidad > 0) // El producto caduca ESTA SEMANA
                {
                    e.CellStyle.BackColor = Color.GreenYellow;
                    caducaSemana = true;
                }
                if (caducado && caducaSemana)
                {
                    lblErrorCaducado.Text = "     Hay productos caducados y productos que caducan esta semana";
                    lblErrorCaducado.Visible = true;
                }
                else if (caducado)
                {
                    lblErrorCaducado.Text = "     Hay productos caducados";
                    lblErrorCaducado.Visible = true;
                }
                else if (caducaSemana)
                {
                    lblErrorCaducado.Text = "     Hay productos que caducan esta semana";
                    lblErrorCaducado.Visible = true;
                }
                else
                    lblErrorCaducado.Visible = false;
            }
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (!txtProducto.Texto.Equals("") && e.KeyCode == Keys.Back)
            {
                CargarDgv();
                FiltrarProducto();
            }
        }
        #endregion
    }
}
