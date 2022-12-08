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
using System.Windows.Forms.DataVisualization.Charting;

namespace DentalSoft.Clases
{
    public partial class Estadisticas : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();

        // Constructor
        public Estadisticas()
        {
            InitializeComponent();
        }

        // Métodos privados
        #region -> Métodos privados
        #region RellenarVarios
        private void RellenarTotalVentas()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT SUM(cantidad*precio) FROM detalle_factura";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblVentasTotal.Text = "Sin datos";
                    else
                        lblVentasTotal.Text = reader.GetFloat(0) + " €";
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarVentasMes()
        {
            if (conexion.EstablecerConexion())
            {
                DateTime fecha = DateTime.Now;
                string mes = fecha.ToString("yyyy-MM");
                string inicio = mes + "-01";
                string fin = fecha.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd"); // Sumo 1 mes y resto 1 día y obtengo el último día del mes
                string sentencia = "SELECT SUM(detalle_factura.cantidad*detalle_factura.precio) FROM detalle_factura " +
                    "INNER JOIN factura ON detalle_factura.Factura = factura.Num_factura WHERE factura.fecha BETWEEN '" + inicio + "' AND '" + fin + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblVentasMes.Text = "Sin datos";
                    else
                        lblVentasMes.Text = reader.GetString(0) + " €";
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarVentasSemana()
        {
            if (conexion.EstablecerConexion())
            {
                DateTime fecha = DateTime.Now;
                int dia = (int) fecha.DayOfWeek;
                DateTime inicio;
                DateTime fin;
                if (dia > 0)
                {
                    inicio = fecha.AddDays((dia - (dia - 1)) * -1);
                    fin = fecha.AddDays(7 - dia);
                }
                else
                {
                    inicio = fecha;
                    fin = fecha.AddDays(6);
                }
                string sentencia = "SELECT SUM(detalle_factura.cantidad*detalle_factura.precio) FROM detalle_factura " +
                    "INNER JOIN factura ON detalle_factura.Factura = factura.Num_factura WHERE factura.fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblVentasSemana.Text = "0 €";
                    else
                        lblVentasSemana.Text = reader.GetFloat(0) + " €";
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarCaja()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT SUM(detalle_factura.cantidad*detalle_factura.precio) FROM detalle_factura " +
                    "INNER JOIN factura ON detalle_factura.Factura = factura.Num_factura WHERE factura.Fecha = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblCaja.Text = "0 €";
                    else
                        lblCaja.Text = reader.GetFloat(0) + " €";
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarClientesTotal()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*) FROM paciente";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblPacientesTotal.Text = "0";
                    else
                        lblPacientesTotal.Text = "" + reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarClientesNuevosMes()
        {
            if (conexion.EstablecerConexion())
            {
                DateTime fecha = DateTime.Now;
                string mes = fecha.ToString("yyyy-MM");
                string inicio = mes += "-01";
                string fin = mes += "-31";
                string sentencia = "SELECT COUNT(*) FROM paciente INNER JOIN historial_clinico ON paciente.Dni = historial_clinico.Paciente WHERE historial_clinico.Fecha_creacion BETWEEN '" + inicio + "' AND '" + fin + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblPacientesNuevosMes.Text = "0";
                    else
                        lblPacientesNuevosMes.Text = "" + reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarEmpleadosTotal()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*)-1 FROM empleado"; // Le resto 1 para que no tenga en cuenta al Administrador que no es un empleado
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblEmpleadosTotal.Text = "" + reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarProductosTotal()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*) FROM producto";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.IsDBNull(0))
                        lblProductosTotal.Text = "0";
                    else
                        lblProductosTotal.Text = "" + reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private int CantidadPresupuestos()
        {
            int totalPresupuestos = -1;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*) FROM presupuesto";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (! reader.IsDBNull(0))
                        totalPresupuestos = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return totalPresupuestos;
        }

        private int CantidadFacturasDesdePresupuestos()
        {
            int totalFacturas = -1;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT COUNT(*) FROM factura WHERE presupuesto IS NOT NULL";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (! reader.IsDBNull(0))
                        totalFacturas = reader.GetInt32(0);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return totalFacturas;
        }

        private void RellenarRatioPresupuestoFactura()
        {
            int totalPresupuestos = CantidadPresupuestos();
            int totalFacturas = CantidadFacturasDesdePresupuestos();
            if (totalPresupuestos > 0 && totalFacturas > 0)
                lblRatioPresupuestosFacturas.Text = Math.Round((totalFacturas * 100) / (double)totalPresupuestos) + " %";
            else
                lblRatioPresupuestosFacturas.Text = "Sin datos";
        }
        #endregion

        private void RellenarVentasPorMes()
        {
            DateTime fecha;
            string fin = "";
            string sentencia = "";
            ArrayList meses = new ArrayList();
            ArrayList ventas = new ArrayList();
            for(int i = 1; i <= DateTime.Now.Month; i++)
            {
                if (conexion.EstablecerConexion())
                {
                    fecha = new DateTime(DateTime.Now.Year, i, 1);
                    fin = fecha.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
                    sentencia = "SELECT SUM(detalle_factura.cantidad*detalle_factura.precio) FROM detalle_factura " +
                        "INNER JOIN factura ON detalle_factura.Factura = factura.Num_factura WHERE factura.fecha BETWEEN '" + fecha.ToString("yyyy-MM-dd") + "' AND '" + fin + "'";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        meses.Add(fecha.ToString("MMMM"));
                        if (reader.IsDBNull(0))
                            ventas.Add(0);
                        else
                            ventas.Add(reader.GetFloat(0));
                    }
                    reader.Close();
                    comando.Dispose();
                    conexion.CerrarConexion();
                }
            }
            chVentasPorMes.Series[0].Points.DataBindXY(meses, ventas);
        }

        private void RellenarPacientesPorEdad()
        {
            ArrayList edad = new ArrayList();
            ArrayList cantidad = new ArrayList();
            for(int i = 10; i <= 90; i += 10)
            {
                if (conexion.EstablecerConexion())
                {
                    string sentencia = "SELECT COUNT(*) FROM paciente WHERE edad BETWEEN " + (i - 9) + " AND " + i;
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        edad.Add("<" + i);
                        cantidad.Add(reader.GetInt32(0));
                    }
                    reader.Close();
                    comando.Dispose();
                    conexion.CerrarConexion();
                }
            }
            chPacientesPorEdad.Series[0].Points.DataBindXY(edad, cantidad);
        }

        private void RellenarTratamientos()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT tratamiento.Nombre, COUNT(*) FROM episodio_clinico " +
                    "INNER JOIN tratamiento ON episodio_clinico.Tratamiento = tratamiento.Id GROUP BY tratamiento.Nombre";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                ArrayList tratamiento = new ArrayList();
                ArrayList cantidad = new ArrayList();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        tratamiento.Add(reader.GetString(0));
                        cantidad.Add(reader.GetInt32(1)); 
                    }
                    chTratamientos.Series[0].Points.DataBindXY(tratamiento, cantidad);
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
        }

        private void RellenarVarios()
        {
            RellenarTotalVentas();
            RellenarVentasMes();
            RellenarVentasSemana();
            RellenarCaja();
            RellenarClientesTotal();
            RellenarClientesNuevosMes();
            RellenarEmpleadosTotal();
            RellenarProductosTotal();
            RellenarRatioPresupuestoFactura();
        }
        #endregion

        // Eventos
        private void Estadisticas_Load(object sender, EventArgs e)
        {
            RellenarVentasPorMes();
            RellenarPacientesPorEdad();
            RellenarTratamientos();
            RellenarVarios();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
