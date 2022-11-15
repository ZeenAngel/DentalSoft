using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class Producto
    {
        // Variables
        #region -> Variables
        private ConexionBD conexion = new ConexionBD();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private string referencia;
        private string descripcion;
        private int cantidad;
        private float coste;
        private string fecha_caducidad;
        private string lote;
        private int categoria;
        private int almacen;
        #endregion

        // Constructores
        public Producto() { }

        public Producto(string referencia)
        {
            this.referencia = referencia;
            CargarProducto();
        }

        // Getters y Setters
        #region -> Getters y Setters
        public string Referencia { get => referencia; set => referencia = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Coste { get => coste; set => coste = value; }
        public string Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
        public string Lote { get => lote; set => lote = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Almacen { get => almacen; set => almacen = value; }
        #endregion

        // Métodos
        #region -> Métodos
        public bool CargarProducto()
        {
            return CargarProducto(this.referencia);
        }

        public bool CargarProducto(string referencia)
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM producto WHERE Referencia = '" + this.referencia + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    this.descripcion = reader.GetString(1);
                    this.cantidad = reader.GetInt32(2);
                    this.coste = reader.GetFloat(3);
                    this.fecha_caducidad = reader.GetDateTime(4).ToString("dd-MM-yyyy");
                    this.lote = reader.GetString(5);
                    this.categoria = reader.GetInt32(6);
                    this.almacen = reader.GetInt32(7);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }
        
        public string GetNombreAlmacen()
        {
            string almacen = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT nombre FROM almacen WHERE Id = " + this.almacen;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    almacen = reader.GetString(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return almacen;
        }

        public string GetNombreCategoria()
        {
            string categoria = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT descripcion FROM categoria_producto WHERE Id = " + this.categoria;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    categoria = reader.GetString(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return categoria;
        }
        #endregion
    }
}
