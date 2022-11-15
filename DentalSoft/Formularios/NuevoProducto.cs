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
    public partial class NuevoProducto : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private Producto producto = null;
        private bool isEditando = false;

        // Constructores
        #region -> Constructores
        public NuevoProducto()
        {
            InitializeComponent();
        }

        public NuevoProducto(string referencia)
        {
            InitializeComponent();
            producto = new Producto(referencia);
            isEditando= true;
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
        private void LimpiarCampos()
        {
            if (!isEditando)
                txtReferencia.Texto = "";
            txtDescripcion.Texto = "";
            txtCantidad.Texto = "";
            txtCoste.Texto = "";
            mcCaducidad.Value = DateTime.Now;
            txtLote.Texto = "";
            cbCategoria.SelectedIndex = 0;
            cbAlmacen.SelectedIndex = 0;
        }

        private void OcultarMensajes()
        {
            lblErrorReferencia.Visible = false;
            lblErrorDescripcion.Visible = false;
            lblErrorCantidad.Visible = false;
            lblErrorCoste.Visible = false;
            lblErrorCaducidad.Visible = false;
            lblErrorLote.Visible = false;
            lblErrorCategoria.Visible = false;
            lblErrorAlmacen.Visible = false;
        }

        private void MostrarMensajes(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "referencia":
                    lblErrorReferencia.Text = "     " + cadena;
                    lblErrorReferencia.Visible = true;
                    break;
                case "descripcion":
                    lblErrorDescripcion.Text = "     " + cadena;
                    
                    break;
                case "cantidad":
                    lblErrorCantidad.Text = "     " + cadena;
                    lblErrorCantidad.Visible = true;
                    break;
                case "coste":
                    lblErrorCoste.Text = "     " + cadena;
                    lblErrorCoste.Visible = true;
                    break;
                case "caducidad":
                    lblErrorCaducidad.Text = "     " + cadena;
                    lblErrorCaducidad.Visible = true;
                    break;
                case "lote":
                    lblErrorLote.Text = "     " + cadena;
                    lblErrorLote.Visible = true;
                    break;
                case "categoria":
                    lblErrorCategoria.Text = "     " + cadena;
                    lblErrorCategoria.Visible = true;
                    break;
                case "almacen":
                    lblErrorAlmacen.Text = "     " + cadena;
                    lblErrorAlmacen.Visible = true;
                    break;
                case "guardar":
                    lblErrorGuardar.Text = "     " + cadena;
                    lblErrorGuardar.Visible = true;
                    break;
            }
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
                    categorias.Add("");
                    while (reader.Read())
                        categorias.Add(reader.GetString(0));
                    foreach (string categoria in categorias)
                        cbCategoria.Items.Add(categoria);
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
                    almacenes.Add("");
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

        private bool IsNumero(string textbox)
        {
            string numero = "";
            switch (textbox)
            {
                case "cantidad":
                    numero = txtCantidad.Texto;
                    if (numero.Contains(","))
                        numero = numero.Replace(',', '.');
                    txtCantidad.Texto = numero;
                    break;
                case "coste":
                    numero = txtCoste.Texto;
                    if (numero.Contains(","))
                        numero = numero.Replace(',', '.');
                    txtCoste.Texto = numero;
                    break;
            }
            
            txtCantidad.Texto = numero;
            return float.TryParse(numero, out float numCantidad); // Devuelve true si puede convertir la cadena en número
        }

        private bool ComprobarNulos()
        {
            bool sw = false;
            if (!txtReferencia.Texto.Equals("")) // Referencia
                if (!txtDescripcion.Texto.Equals("")) // Descripción
                    if (!txtCantidad.Texto.Equals("")) // Cantidad
                        if (IsNumero("cantidad")) // IsNumero Cantidad
                            if (!txtCoste.Texto.Equals("")) // Coste
                                if (IsNumero("coste")) // IsNumero Coste
                                    if(DateTime.Compare(mcCaducidad.Value, DateTime.Now) > 0) // Comprobar si la fecha introducida es anterior a la actual
                                        if (!txtLote.Texto.Equals("")) // Lote
                                            if (cbCategoria.SelectedIndex > 0) // Categoria
                                                if (cbAlmacen.SelectedIndex > 0) // Almacen
                                                    sw = true;
                                                else
                                                    MostrarMensajes("Debe seleccionar un almacen", "almacen");
                                            else
                                                MostrarMensajes("Debe seleccionar una categoría", "categoria");
                                        else
                                            MostrarMensajes("Debe introducir un Lote", "lote");
                                    else
                                        MostrarMensajes("El producto está caducado o caduca hoy", "caducidad");
                                else
                                    MostrarMensajes("Formato inválido", "coste");
                            else
                                MostrarMensajes("Debe introducir un coste", "coste");
                        else
                            MostrarMensajes("Formato válido", "cantidad");
                    else
                        MostrarMensajes("Debe introducir una cantidad", "cantidad");
                else
                    MostrarMensajes("Debe introducir una descripción", "descripcion");
            else
                MostrarMensajes("Debe introducir una referencia", "referencia");
            return sw;
        }

        private int GetIdCategoria()
        {
            int categoria = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT id FROM categoria_producto WHERE Descripcion = '" + cbCategoria.SelectedItem.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    categoria = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return categoria;
        }

        private int GetIdAlmacen()
        {
            int almacen = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT id FROM almacen WHERE Nombre = '" + cbAlmacen.SelectedItem.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    almacen = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return almacen;
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

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            // No establezco el calendario a un MinDate DateTime.Now porque así si introduce una fecha anterior
            // puede ver el mensaje de error y tirar el producto
            if (isEditando)
                txtReferencia.Enabled = false;
            CargarCategorias();
            CargarAlmacenes();
            mcCaducidad.Value = DateTime.Now;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            OcultarMensajes();
            if (ComprobarNulos())
            {
                string sentencia = "";
                if (!isEditando)
                    sentencia = "INSERT INTO Producto VALUES('" + txtReferencia.Texto + "', '" + txtDescripcion.Texto + "', " +
                        txtCantidad.Texto + ", " + txtCoste.Texto + ", '" + mcCaducidad.Value.ToString("yyyy-MM-dd") + "', '" +
                        txtLote.Texto + "', " + GetIdCategoria() + ", " + GetIdAlmacen() + ")";
                else
                    sentencia = "UPDATE producto SET descripcion = '" + txtDescripcion.Texto + "', cantidad = " + txtCantidad.Texto + ", coste = " + txtCoste.Texto + ", fecha_caducidad = '" + mcCaducidad.Value.ToString("yyyy-MM-dd") + "', lote = '" + txtLote.Texto + "', categoria = " + GetIdCategoria() + ", almacen = " + GetIdAlmacen() + " WHERE referencia = '" + txtReferencia.Texto + "'";
                if (conexion.EstablecerConexion())
                {
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Producto guardado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                        MostrarMensajes("Ha ocurrido un error al guardar el producto", "guardar");
                    comando.Dispose();
                    conexion.CerrarConexion();
                }
                
            }
        }
    }
}
