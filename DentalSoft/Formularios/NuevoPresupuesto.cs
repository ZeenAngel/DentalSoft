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
    public partial class NuevoPresupuesto : Form
    {
        //Variables
        private DatosGlobales datosGlobales = new DatosGlobales();
        private ConexionBD conexion = new ConexionBD();
        private Paciente paciente;

        // Funcionalidades arrastrar formulario
        #region -> Funcionalidades
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        // Constructor
        public NuevoPresupuesto()
        {
            InitializeComponent();
        }

        // Métodos privados
        #region -> Métodos privados
        private void LimpiarCampos()
        {
            dgvDetalles.Rows.Clear();
            CargarDatosPresupuesto();
            cbCentros.SelectedIndex = 0;
            cbTratamientos.SelectedIndex = 0;
            txtPaciente.Texto = "";
            txtCantidad.Texto = "";
            lblTotal.Text = "Total: ";
        }

        private void MostrarMensaje(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "centro":
                    lblErrorCentro.Text = "     " + cadena;
                    lblErrorCentro.Visible = true;
                    break;
                case "paciente":
                    lblErrorPaciente.Text = "     " + cadena;
                    lblErrorPaciente.Visible = true;
                    break;
                case "cantidad":
                    lblErrorCantidad.Text = "     " + cadena;
                    lblErrorCantidad.Visible = true;
                    break;
                case "guardar":
                    lblErrorGuardar.Text = "     " + cadena;
                    lblErrorGuardar.Visible = true;
                    break;
                case "tratamiento":
                    lblErrorTratamiento.Text = "     " + cadena;
                    lblErrorTratamiento.Visible = true;
                    break;
                case "eliminar":
                    lblErrorEliminar.Text = "     " + cadena;
                    lblErrorEliminar.Visible = true;
                    break;
            }
        }

        private void OcultarMensajesError()
        {
            lblErrorCentro.Visible = false;
            lblErrorPaciente.Visible = false;
            lblErrorTratamiento.Visible = false;
            lblErrorCantidad.Visible = false;
            lblErrorGuardar.Visible = false;
            lblErrorEliminar.Visible = false;
        }

        private void AjustarDgv()
        {
            dgvDetalles.Columns[0].MinimumWidth = 200;
            dgvDetalles.Columns[1].MinimumWidth = 150;
            dgvDetalles.Columns[2].MinimumWidth = 90;
            dgvDetalles.Columns[dgvDetalles.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Hacer que la última columna rellene todo el contenedor 
            for (int i = 0; i < dgvDetalles.ColumnCount; i++) // No permitir editar las columnas
                dgvDetalles.Columns[i].ReadOnly = true;
        }

        private void GenerarNumeroPresupuesto(string presupuesto)
        {
            string fechaAnterior = presupuesto.Substring(1, 2);
            presupuesto = presupuesto.Substring(3, (presupuesto.Length - 3));

            // HAY QUE RELLENAR CON CEROS A LA IZQUIERDA, EL TOTAL CUANDO ES MENOR A 10 SON 7 CEROS
            int temporal = int.Parse(presupuesto) + 1;
            string cadenaPresupuesto = temporal.ToString();
            string numPresupuesto = "";
            string fecha = DateTime.Now.ToString("yy"); // De esta forma cuando se cambie de año, cambiará en el número de presupuesto
            if (fechaAnterior.Equals(fecha))
            {
                for (int i = cadenaPresupuesto.Length - 1; i < 7; i++)
                    numPresupuesto += "0";
                numPresupuesto += cadenaPresupuesto;
                lblPresupuesto.Text = datosGlobales.LetraPrespuesto + fecha + numPresupuesto;
            }
            else
                lblPresupuesto.Text = datosGlobales.LetraPrespuesto + fecha + datosGlobales.NumeroInicialPresupuesto;
        }

        private void CargarTratamientos()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT nombre FROM tratamiento ORDER BY Id";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    List<string> tratamientos = new List<string>();
                    tratamientos.Add("");
                    while (reader.Read())
                        tratamientos.Add(reader.GetString(0));
                    foreach (string tratamiento in tratamientos)
                        cbTratamientos.Items.Add(tratamiento);
                }
                reader.Close();
                conexion.CerrarConexion();

            }
        }

        private void CargarCentros()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT nombre FROM centro";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    List<string> centros = new List<string>();
                    centros.Add("");
                    while (reader.Read())
                        centros.Add(reader.GetString(0));
                    foreach (string centro in centros)
                        cbCentros.Items.Add(centro);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
        }

        private void CargarDatosPresupuesto()
        {
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Num_presupuesto FROM presupuesto ORDER BY Num_presupuesto DESC LIMIT 1";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    GenerarNumeroPresupuesto(reader.GetString(0));
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd-MM-yyyy");
            CargarTratamientos();
        }

        private bool ComprobarLetraDni(int dniNumeros, string letra)
        {
            bool sw = false;
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            int posicion = dniNumeros % 23;
            if (control[posicion].Equals(letra))
                sw = true;
            return sw;
        }

        private bool ComprobarDni()
        {
            bool sw = true;
            string dni = txtPaciente.Texto.ToUpper();
            string numeros = dni.Substring(0, dni.Length - 1);
            string letra = dni.Substring(dni.Length - 1, 1);
            if (dni.Length != 9)
            {
                MostrarMensaje("El Dni debe tener una longitud de 9 caracteres", "paciente");
                sw = false;
            }
            bool isNumero = int.TryParse(numeros, out int dniNumeros);
            if (!isNumero)
            {
                MostrarMensaje("El Dni debe comenzar por 8 dígitos", "paciente");
                sw = false;
            }
            if (!ComprobarLetraDni(dniNumeros, letra))
            {
                MostrarMensaje("La letra del Dni no es correcta", "paciente");
                sw = false;
            }
            return sw;
        }

        private bool IsNumero()
        {
            return int.TryParse(txtCantidad.Texto, out int cantidad);
        }

        private bool ExistePaciente()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Paciente WHERE Dni = '" + txtPaciente.Texto + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    sw = true;
                    reader.Read();
                    paciente = new Paciente();
                    paciente.Dni = reader.GetString(0);
                    paciente.Nombre = reader.GetString(1);
                    paciente.Apellido1 = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        paciente.Apellido2 = reader.GetString(3);
                    reader.Close();
                    conexion.CerrarConexion();
                }
                else
                {
                    reader.Close();
                    conexion.CerrarConexion();
                    DialogResult mensaje = MessageBoxPersonalizadoControl.Show("El paciente introducido no existe, ¿Quiere crear un nuevo paciente?", datosGlobales.TituloAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (mensaje == DialogResult.Yes)
                    {
                        NuevoPaciente nuevoPaciente = new NuevoPaciente(ref this.txtPaciente);
                        nuevoPaciente.ShowDialog();
                        sw = ExistePaciente(); // Compruebo que ha creado el paciente y no ha cerrado la ventana simplemente
                    }
                    else
                        MostrarMensaje("El paciente no existe", "paciente");
                }
            }
            return sw;
        }

        private float ObtenerPrecio()
        {
            float precio = 0;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Precio FROM tratamiento WHERE Id = " + cbTratamientos.SelectedIndex;
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    precio = reader.GetFloat(0);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            return precio;
        }

        private void CalcularTotal()
        {
            float total = 0;
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
                total += float.Parse(fila.Cells[3].Value.ToString());
            lblTotal.Text = "Total: " + total + "€";
        }

        private string ObtenerCentro()
        {
            string centro = "";
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT cif FROM centro WHERE nombre = '" + cbCentros.SelectedItem.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    centro = reader.GetString(0);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            return centro;
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
        #endregion

        // Eventos
        #region -> Eventos
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

        private void NuevoPresupuesto_Load(object sender, EventArgs e)
        {
            OcultarMensajesError();
            CargarDatosPresupuesto();
            CargarCentros();
            Estilo estilo = new Estilo();
            estilo.EstiloDataGridView(dgvDetalles);
            AjustarDgv();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (cbTratamientos.SelectedIndex > 0)
            {
                if (IsNumero()) // Ver si la cantidad es válida
                {
                    float precio = ObtenerPrecio();
                    float subtotal = int.Parse(txtCantidad.Texto) * precio;
                    dgvDetalles.Rows.Add(cbTratamientos.SelectedItem.ToString(), txtCantidad.Texto, precio.ToString(), subtotal);
                    CalcularTotal();
                    cbTratamientos.SelectedIndex = 0;
                    txtCantidad.Texto = "";
                }
                else
                    MostrarMensaje("La cantidad no tiene un formato válido", "cantidad");
            }
            else
                MostrarMensaje("Debe seleccionar un tratamiento", "tratamiento");

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPaciente buscarPaciente = new BuscarPaciente(ref txtPaciente);
            buscarPaciente.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ExistePaciente() && ComprobarDni())
            {
                if (dgvDetalles.Rows.Count > 0)
                {
                    string centro = ObtenerCentro();
                    if (conexion.EstablecerConexion())
                    {
                        string sentencia = "INSERT INTO Presupuesto VALUES ('" + lblPresupuesto.Text + "', '"
                            + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + centro + "', '" + txtPaciente.Texto + "')"; // Insertar en Presupuesto
                        MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                        int resultado = comando.ExecuteNonQuery();
                        comando.Dispose();
                        if (resultado > 0) // Si se ha insertado en presupuesto
                        {
                            MySqlTransaction transaccion = null;
                            try
                            {
                                transaccion = conexion.conexionSql.BeginTransaction();
                                foreach (DataGridViewRow fila in dgvDetalles.Rows)
                                {
                                    int tratamiento = ObtenerTratamiento(conexion, fila.Cells[0].Value.ToString());
                                    sentencia = "INSERT INTO detalle_presupuesto(tratamiento, cantidad, presupuesto) VALUES " +
                                        "(" + tratamiento + ", " + fila.Cells[1].Value.ToString() + ", '" + lblPresupuesto.Text + "')";
                                    comando = new MySqlCommand(sentencia, conexion.conexionSql);
                                    comando.ExecuteNonQuery();
                                }
                                transaccion.Commit();
                                comando.Dispose();
                                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Presupuesto guardado correctamente", datosGlobales.TituloAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                    MostrarMensaje("Debe añadir algun tratamiento", "guardar");
            }
            else
                MostrarMensaje("Debe seleccionar un centro", "centro");
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvDetalles.SelectedRows.Count > 0)
            dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
        else
            MostrarMensaje("Debe seleccionar la fila a eliminar", "eliminar");
    }
    #endregion


}
}
