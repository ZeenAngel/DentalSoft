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
    public partial class GestionarAlmacen : Form
    {
        // Variables
        private MenuPrincipal formPadre;
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private const int anchoMinimoDniDgv = 100;

        // Constructores
        #region -> Constructores
        public GestionarAlmacen()
        {
            InitializeComponent();
        }

        public GestionarAlmacen(MenuPrincipal formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
        }
        #endregion

        // Métodos privados
        private void MostrarMensaje(string cadena)
        {
            lblErrorAlmacen.Text = "     " + cadena;
            lblErrorAlmacen.Visible = true;
        }

        private void OcultarMensaje()
        {
            lblErrorAlmacen.Visible = false;
        }

        private void AjustarColumnasDgv()
        {
            for (int i = 0; i < dgvAlmacen.ColumnCount - 1; i++)
                dgvAlmacen.Columns[i].MinimumWidth = anchoMinimoDniDgv;
            dgvAlmacen.Columns[dgvAlmacen.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor
            for (int i = 0; i < dgvAlmacen.ColumnCount; i++) // No permitir editar las columnas
                dgvAlmacen.Columns[i].ReadOnly = true;
        }

        private void CargarDgv()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Nombre, ubicacion AS Ubicación FROM Almacen";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvAlmacen.DataSource = tabla;
                tabla.Dispose();
                comando.Dispose();
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }

        private void FiltrarAlmacen()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Nombre, ubicacion AS Ubicación FROM Almacen WHERE " + cbFiltros.Textos + " LIKE '" + txtAlmacen.Texto + "%'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dgvAlmacen.DataSource = tabla;
                tabla.Dispose();
                comando.Dispose();
                conexion.CerrarConexion();
                AjustarColumnasDgv();
            }
        }

        private void CargarFiltros()
        {
            for (int i = 0; i < dgvAlmacen.Columns.Count; i++)
                cbFiltros.Items.Add(dgvAlmacen.Columns[i].HeaderText.ToString());
            cbFiltros.SelectedIndex = 0;
        }

        private int GetIdAlmacen(string almacen)
        {
            int id = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT id FROM almacen WHERE nombre = '" + almacen + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return id;
        }

        private bool ComprobarCantidadProducto(int almacen)
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT cantidad FROM producto WHERE almacen = " + almacen;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0) > 0)
                        {
                            sw = true;
                            break;
                        }
                    }
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private bool ComprobarProductosAlmacen()
        {
            bool sw = false;
            int almacen = GetIdAlmacen(dgvAlmacen.Rows[dgvAlmacen.CurrentRow.Index].Cells[7].Value.ToString());
            // TODO: Comprobar que el almacen no tenga productos almacenados (comprobando en la tabla Producto los que tengan el id del almacén, y que tengan cantidad > que cero
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*) FROM producto WHERE almacen = " + almacen;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetInt32(0) > 0)
                        sw = true;
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            if (sw)
                sw = ComprobarCantidadProducto(almacen);
            return sw;
        }

        private bool ComprobarCantidadAlmacenes()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*) FROM almacen";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.GetInt32(0) <= 1)
                        sw = true;
                }
                conexion.CerrarConexion();
            }
            return sw;
        }

        private void EliminarProductos(int almacen)
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "DELETE FROM producto WHERE almacen = " + almacen;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        // Eventos
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen(this.formPadre);
            formPadre.AbrirFormularioHijo(almacen);
        }

        private void txtAlmacen__TextChanged(object sender, EventArgs e)
        {
            if (txtAlmacen.Texto.Equals(""))
                CargarDgv();
            else
                FiltrarAlmacen();
        }

        private void cbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarAlmacen();
        }

        private void btnNuevoAlmacen_Click(object sender, EventArgs e)
        {
            NuevoAlmacen nuevoAlmacen = new NuevoAlmacen();
            nuevoAlmacen.ShowDialog();
            CargarDgv();
        }

        private void btnEditarAlmacen_Click(object sender, EventArgs e)
        {
            if (dgvAlmacen.SelectedRows.Count > 0)
            {
                NuevoAlmacen nuevoAlmacen = new NuevoAlmacen(GetIdAlmacen(dgvAlmacen.Rows[dgvAlmacen.CurrentRow.Index].Cells[0].Value.ToString()));
                nuevoAlmacen.ShowDialog();
                CargarDgv();
            }
            else
                MostrarMensaje("Debe seleccionar un almacén de la lista");
        }

        private void btnEliminarAlmacen_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            DialogResult mensaje;
            if (dgvAlmacen.SelectedRows.Count > 0) // Comprobar si hay seleccionada alguna fila
            {
                int idAlmacen = GetIdAlmacen(dgvAlmacen.Rows[dgvAlmacen.CurrentRow.Index].Cells[0].Value.ToString());
                if (! ComprobarProductosAlmacen())
                {
                    mensaje = MessageBoxPersonalizadoControl.Show("¿Seguro que quiere eliminar este almacen y los productos asociados a el?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (mensaje == DialogResult.Yes)
                    {
                        if (!ComprobarCantidadAlmacenes()) // Comprobar que no sea el último almacen
                        {
                            EliminarProductos(idAlmacen); // Eliminar los productos del almacén
                            if (conexion.EstablecerConexion())
                            {
                                string sentencia = "DELETE FROM almacen WHERE id = " + idAlmacen + "'";
                                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                comando.ExecuteNonQuery();
                                comando.Dispose();
                                conexion.CerrarConexion();
                                CargarDgv();
                            }
                        }
                        else
                            MostrarMensaje("No se puede eliminar este almacén porque es el único que existe");
                    }
                }
                else
                    MostrarMensaje("No se puede eliminar un almacén que aún dispone de productos con stock");
            }
            else
                MostrarMensaje("Debe seleccionar un almacén de la lista");
        }

        private void GestionarAlmacen_Load(object sender, EventArgs e)
        {
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvAlmacen);
            CargarDgv();
            CargarFiltros();
        }

        
    }
}
