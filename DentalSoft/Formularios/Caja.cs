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
    public partial class Caja : Form
    {
        // Variables
        #region -> Variables
        private Paciente paciente = new Paciente();
        private ConexionBD conexion = new ConexionBD();
        private Presupuesto presupuesto = new Presupuesto();
        private DatosGlobales datosGlobales = new DatosGlobales();
        private string centro;
        private float total = 0;
        private float cambio = 0;
        public int cantidad = 0;
        public float precioOtros = 0;
        public string conceptoOtros = "";
        #endregion

        // Constructores
        #region -> Constructores
        public Caja()
        {
            InitializeComponent();
        }

        public Caja(string centro)
        {
            InitializeComponent();
            this.centro = centro;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void ReiniciarValores()
        {
            this.cantidad = 0;
            this.precioOtros = 0;
            this.conceptoOtros = "";
        }

        private void PagoMetalico()
        {
            lblEntrega.Visible = true;
            txtEntrega.Visible = true;
            lblCambio.Visible = true;
        }

        private void OtrosPagos()
        {
            lblEntrega.Visible = false;
            txtEntrega.Visible = false;
            lblCambio.Visible = false;
            lblImporteCambio.Visible = false;
        }

        private void CargarMetodosPago()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT descripcion FROM metodo_cobro";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        cbMetodosPago.Items.Add(reader.GetString(0));
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            cbMetodosPago.SelectedIndex = 0;
        }

        private void OcultarEtiquetas()
        {
            lblImporteCambio.Visible = false;
            lblImporteTotal.Visible = false;
        }

        private void MostrarEtiquetaCambio()
        {
            lblImporteCambio.Visible = true;
        }

        private void AjustarColumnasDgv()
        {
            dgvCobro.Columns[0].MinimumWidth = 250;
            dgvCobro.Columns[1].MinimumWidth = 110;
            dgvCobro.Columns[2].MinimumWidth = 100;
            dgvCobro.Columns[dgvCobro.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < dgvCobro.ColumnCount; i++) // No permitir editar las columnas
                dgvCobro.Columns[i].ReadOnly = true;
        }

        private void OcultarMensaje()
        {
            lblErrorPaciente.Visible = false;
            lblErrorPresupuesto.Visible = false;
        }

        private void MostrarMensaje(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "paciente":
                    lblErrorPaciente.Text = "     " + cadena;
                    lblErrorPaciente.Visible = true;
                    break;
                case "presupuesto":
                    lblErrorPresupuesto.Text = "     " + cadena;
                    lblErrorPresupuesto.Visible = true;
                    break;
                case "entrega":
                    lblErrorEntrega.Text = "     " + cadena;
                    lblEntrega.Visible = true;
                    break;
            }
        }

        private void OcultarNombrePaciente()
        {
            lblNombrePaciente.Visible = false;
        }

        private void MostrarNombrePaciente()
        {
            lblNombrePaciente.Visible = true;
        }

        private void MostrarBuscarPaciente()
        {
            btnCargarPaciente.Visible = false;
            btnBuscarPaciente.Visible = true;
        }

        private void MostrarCargarPaciente()
        {
            btnCargarPaciente.Visible = true;
            btnBuscarPaciente.Visible = false;
        }

        private void MostrarBuscarPresupuesto()
        {
            btnBuscarPresupuesto.Visible = true;
            btnCargarPresupuesto.Visible = false;
        }

        private void MostrarCargarPresupuesto()
        {
            btnBuscarPresupuesto.Visible = false;
            btnCargarPresupuesto.Visible = true;
        }

        private bool CargarNombrePaciente(string origen)
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT dni, nombre, apellido1, apellido2 FROM paciente WHERE dni = '";
                switch (origen)
                {
                    case "paciente":
                        sentencia += txtPaciente.Texto + "'";
                        break;
                    case "presupuesto":
                        sentencia += presupuesto.Paciente + "'";
                        break;
                }
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    paciente.Dni = reader.GetString(0);
                    paciente.Nombre = reader.GetString(1);
                    paciente.Apellido1 = reader.GetString(2);
                    lblNombrePaciente.Text = paciente.Nombre + " " + paciente.Apellido1;
                    if (!reader.IsDBNull(2))
                    {
                        paciente.Apellido2 = reader.GetString(3);
                        lblNombrePaciente.Text += " " + paciente.Apellido2;
                    }
                    MostrarNombrePaciente();
                    sw = true;
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private bool ComprobarReserva()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM reserva WHERE fecha = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND paciente = '" + txtPaciente.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetInt32(5) == 3) // Comprobar si el estado de la reserva es Finalizado
                        sw = true;
                }
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private bool CargarTratamientoPaciente()
        {
            bool sw = false;
            if (ComprobarReserva())
            {
                if (conexion.EstablecerConexion())
                {
                    List<DetalleCobro> detalles = new List<DetalleCobro>();
                    string sentencia = "SELECT tratamiento.Nombre, tratamiento.Precio FROM episodio_clinico " +
                        "INNER JOIN tratamiento ON episodio_clinico.Tratamiento = tratamiento.Id " +
                        "WHERE episodio_clinico.Fecha = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND episodio_clinico.Historial = '" + txtPaciente.Texto +
                        "' AND tratamiento.Nombre != 'Sin tratar' GROUP BY tratamiento.Nombre";
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DetalleCobro detalle = null;
                        while (reader.Read())
                        {
                            detalle = new DetalleCobro();
                            detalle.Tratamiento = reader.GetString(0);
                            detalle.Precio = reader.GetFloat(1);
                            detalles.Add(detalle);
                        }
                        sw = true;
                    }
                    reader.Close();
                    comando.Dispose();
                    sentencia = "SELECT COUNT(*) AS Cantidad FROM episodio_clinico INNER JOIN tratamiento ON episodio_clinico.Tratamiento = tratamiento.Id WHERE episodio_clinico.Fecha = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND episodio_clinico.Historial = '" + txtPaciente.Texto + "' AND tratamiento.Nombre != 'Sin tratar' GROUP BY tratamiento.Nombre;";
                    comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            foreach (DetalleCobro detalle in detalles)
                            {
                                detalle.Cantidad = reader.GetInt32(0);
                                detalle.Subtotal = detalle.Cantidad * detalle.Precio;
                                dgvCobro.Rows.Add(detalle.Tratamiento, detalle.Cantidad, detalle.Precio, detalle.Subtotal);
                            }
                        }
                    }
                    reader.Close();
                    comando.Dispose();
                    conexion.CerrarConexion();
                }
            }
            return sw;
        }

        private bool CargarTratamientoPresupuesto()
        {
            bool sw = false;
            this.presupuesto = new Presupuesto(txtPresupuesto.Texto);
            if (presupuesto.Centro != null)
            {
                if (ComprobarValidezPresupuesto())
                {
                    sw = true;
                    List<DetalleCobro> listaDetallesCobros = new List<DetalleCobro>();
                    DetalleCobro detalleCobro = null;
                    MySqlCommand comando = null;
                    MySqlDataReader reader = null;
                    if (conexion.EstablecerConexion())
                    {
                        foreach (DetallePresupuesto detalle in presupuesto.Detalles)
                        {
                            string sentencia = "SELECT nombre, precio FROM tratamiento WHERE id = " + detalle.Tratamiento;
                            comando = new MySqlCommand(sentencia, conexion.conexionSql);
                            reader = comando.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                detalleCobro = new DetalleCobro();
                                detalleCobro.Tratamiento = reader.GetString(0);
                                detalleCobro.Precio = reader.GetFloat(1);
                                detalleCobro.Cantidad = detalle.Cantidad;
                                detalleCobro.Subtotal = detalleCobro.Cantidad * detalleCobro.Precio;
                                listaDetallesCobros.Add(detalleCobro);
                            }
                            reader.Close();
                            comando.Dispose();
                        }
                        conexion.CerrarConexion();
                        foreach (DetalleCobro detalle in listaDetallesCobros)
                            dgvCobro.Rows.Add(detalle.Tratamiento, detalle.Cantidad, detalle.Precio, detalle.Subtotal);
                    }
                }
                else
                    MostrarMensaje("El presupuesto ya no es válido", "presupuesto");
            }
            else
                MostrarMensaje("No se han podido cargar los datos del presupuesto", "presupuesto");
            return sw;
        }

        private void CargarTotal()
        {
            float total = 0;
            foreach (DataGridViewRow fila in dgvCobro.Rows)
                total += float.Parse(fila.Cells[3].Value.ToString());
            lblImporteTotal.Text = total.ToString() + " €";
            this.total = total;
            lblImporteTotal.Visible = true;
        }

        private void CargarPaciente()
        {
            OcultarMensaje();
            if (CargarNombrePaciente("paciente"))
                if (CargarTratamientoPaciente())
                    CargarTotal();
                else
                    MostrarMensaje("El paciente no se ha realizado un tratamiento hoy", "paciente");
            else
                MostrarMensaje("El paciente no existe", "paciente");
        }

        private void CargarPresupuesto()
        {
            OcultarMensaje();
            if (CargarNombrePaciente("presupuesto"))
                if (CargarTratamientoPresupuesto())
                    CargarTotal();
            else
                MostrarMensaje("El presupuesto no existe", "presupuesto");
            
        }

        private bool IsNumero()
        {
            return float.TryParse(txtEntrega.Texto.ToString(), out var numero);
        }

        private bool ComprobarValidezPresupuesto()
        {
            bool sw = false;
            TimeSpan validezPresupuesto = DateTime.Parse(this.presupuesto.Fecha) - DateTime.Now;
            if (validezPresupuesto.Days <= 30)
                sw = true;
            return sw;
        }

        private int ObtenerTratamiento(ConexionBD conexion, string tratamiento)
        {
            int idTratamiento = 0;
            string sentencia = "SELECT id FROM tratamiento WHERE nombre = '" + tratamiento + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idTratamiento = reader.GetInt32(0);
            }
            reader.Close();
            return idTratamiento;
        }

        private string GenerarNumeroFactura()
        {
            string numFactura = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT num_factura FROM factura ORDER BY Num_factura DESC LIMIT 1";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string factura = reader.GetString(0);
                    string fechaAnterior = factura.Substring(1, 2);
                    factura = factura.Substring(3, (factura.Length - 3));
                    int temporal = int.Parse(factura) + 1;
                    string cadenaFactura = temporal.ToString();
                    string fecha = DateTime.Now.ToString("yy"); // De esta forma cuando se cambie de año, cambiará en el número de presupuesto
                    numFactura = datosGlobales.LetraFactura + fecha;
                    if (fechaAnterior.Equals(fecha))
                    {
                        for (int i = cadenaFactura.Length - 1; i < 7; i++)
                            numFactura += "0";
                        numFactura += temporal;
                    }
                    else
                        numFactura += datosGlobales.NumeroInicialPresupuesto;
                }
                else
                    numFactura = datosGlobales.LetraFactura + DateTime.Now.ToString("yy") + datosGlobales.NumeroInicialPresupuesto;
                reader.Close();
                comando.Dispose();
                conexion.CerrarConexion();
            }
            return numFactura;
        }

        private void LimpiarCampos()
        {
            dgvCobro.Rows.Clear();
            txtPaciente.Texto = "";
            txtPresupuesto.Texto = "";
            txtEntrega.Texto = "";
            OcultarEtiquetas();
            this.total = 0;
            this.cambio = 0;
            this.conceptoOtros = "";
            this.precioOtros = 0;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Caja_Load(object sender, EventArgs e)
        {
            MostrarBuscarPaciente();
            MostrarBuscarPresupuesto();
            OcultarMensaje();
            OcultarNombrePaciente();
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvCobro);
            AjustarColumnasDgv();
            OcultarEtiquetas();
            CargarMetodosPago();
        }

        private void txtPaciente__TextChanged(object sender, EventArgs e)
        {
            if (txtPaciente.Texto.Equals(""))
                MostrarBuscarPaciente();
            else
                MostrarCargarPaciente();
        }

        private void txtPresupuesto__TextChanged(object sender, EventArgs e)
        {
            if (txtPresupuesto.Texto.Equals(""))
                MostrarBuscarPresupuesto();
            else
                MostrarCargarPresupuesto();
        }

        private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return) && !txtPaciente.Texto.Equals(""))
                CargarPaciente();
        }

        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return) && !txtPresupuesto.Texto.Equals(""))
                CargarPresupuesto();
        }

        private void btnCargarPaciente_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            if (!CargarTratamientoPaciente())
                MostrarMensaje("El paciente no se ha realizado un tratamiento hoy", "paciente");
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPaciente buscarPaciente = new BuscarPaciente(ref txtPaciente);
            buscarPaciente.ShowDialog();
            CargarNombrePaciente("paciente");
            CargarTratamientoPaciente();
            CargarTotal();
        }

        private void btnCargarPresupuesto_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            if (! CargarTratamientoPresupuesto())
                MostrarMensaje("El presupuesto no existe", "presupuesto");
        }

        private void btnBuscarPresupuesto_Click(object sender, EventArgs e)
        {
            BuscarPresupuesto buscarPresupuesto = new BuscarPresupuesto(ref txtPresupuesto);
            buscarPresupuesto.ShowDialog();
            CargarTratamientoPresupuesto();
            CargarTotal();
        }

        private void cbMetodosPago_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodosPago.SelectedIndex == 0)
                PagoMetalico();
            else
                OtrosPagos();
        }

        private void BotonesTratamientos(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            DetalleCobro detalleCobro = new DetalleCobro();
            CantidadCobro cantidadCobro = new CantidadCobro(this); // Cantidad    
            cantidadCobro.ShowDialog();
            detalleCobro.Cantidad = this.cantidad;
            if (boton.Text.Equals("Otros"))
            {
                ConceptoCobro conceptoCobro = new ConceptoCobro(this); // Concepto
                conceptoCobro.ShowDialog();
                if (this.conceptoOtros.Equals(""))
                    this.conceptoOtros = "Otros";
                detalleCobro.Tratamiento = this.conceptoOtros;
                PrecioCobro precioCobro = new PrecioCobro(this); // Precio
                precioCobro.ShowDialog();
                detalleCobro.Precio = this.precioOtros;
                detalleCobro.Subtotal = this.cantidad * this.precioOtros; // Subtotal
            }
            else
            {
                detalleCobro.Tratamiento = boton.Text;
                if (conexion.EstablecerConexion())
                {
                    string sentencia = "SELECT precio FROM tratamiento WHERE id = " + boton.Tag; // Precio
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        detalleCobro.Precio = reader.GetFloat(0);
                    }
                    reader.Close();
                    comando.Dispose();
                    conexion.CerrarConexion();
                }
                detalleCobro.Subtotal = detalleCobro.Cantidad * detalleCobro.Precio;
            }
            dgvCobro.Rows.Add(detalleCobro.Tratamiento, detalleCobro.Cantidad, detalleCobro.Precio, detalleCobro.Subtotal); // Añadir fila al DGV
            ReiniciarValores();
            CargarTotal();
        }

        private void txtEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (IsNumero())
                {
                    float entrega = float.Parse(txtEntrega.Texto);
                    if (entrega >= this.total)
                    {
                        this.cambio = entrega - this.total;
                        lblImporteCambio.Text = this.cambio.ToString() + " €";
                        MostrarEtiquetaCambio();
                    }
                    else
                        MostrarMensaje("La cantidad entregada debe ser superior o igual al importe", "entrega");
                }
                else
                    MostrarMensaje("Debe introducir una cantidad correcta", "entrega");
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            string numFactura = GenerarNumeroFactura();
            Centro centro = new Centro(this.centro);
            if (conexion.EstablecerConexion())
            {
                string sentencia = "INSERT INTO factura VALUES('" + numFactura + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + centro.Cif +
                    "', '" + centro.Nombre + "', '" + centro.Direccion + "', '" + centro.Localidad + "', '" + centro.Cp + "', '" + centro.Telefono +
                    "', '" + paciente.Dni + "', '" + paciente.Nombre + "', '" + paciente.Apellido1 + "'";
                if (paciente.Apellido2 != null) // Si tiene segundo apellido
                    sentencia += ", '" + paciente.Apellido2 + "'";
                else
                    sentencia += ", null";
                if (presupuesto.NumPresupuesto != null) // Si se ha cargado un presupuesto
                    sentencia += ", '" + presupuesto.NumPresupuesto + "'";
                else
                    sentencia += ", null";
                sentencia += ")";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                int resultado = comando.ExecuteNonQuery();
                comando.Dispose();
                if (resultado > 0) // Si se ha insertado en factura
                {
                    MySqlTransaction transaccion = null;
                    try
                    {
                        transaccion = conexion.conexionSql.BeginTransaction();
                        foreach (DataGridViewRow fila in dgvCobro.Rows)
                        {
                            int tratamiento = ObtenerTratamiento(conexion, fila.Cells[0].Value.ToString());
                            sentencia = "INSERT INTO detalle_factura(tratamiento, cantidad, precio, factura) VALUES " +
                                "(" + tratamiento + ", " + fila.Cells[1].Value.ToString() + ", " + fila.Cells[2].Value.ToString() + ", '" + numFactura + "')";
                            comando = new MySqlCommand(sentencia, conexion.conexionSql);
                            comando.ExecuteNonQuery();
                        }
                        transaccion.Commit();
                        comando.Dispose();
                        DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Cobro realizado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Error: " + ex.Message, datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexion.CerrarConexion();
                    }
                }
            }
        }
        #endregion
    }
}
