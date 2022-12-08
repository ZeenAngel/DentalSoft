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
    public partial class Facturas : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();

        // Constructor
        public Facturas()
        {
            InitializeComponent();
        }

        // Métodos privados
        #region -> Métodos privados
        private void OcultarInformes()
        {
            rvFacturas.Visible = false;
            lvFacturas.Visible = true;
        }

        private void MostrarInformes()
        {
            rvFacturas.Visible = true;
            lvFacturas.Visible = false;
        }

        private void OcultarEtiquetasError()
        {
            lblErrorFactura.Visible = false;
            lblErrorPaciente.Visible = false;
        }

        private void MostrarMensaje(string cadena, string etiqueta)
        {
            switch (etiqueta)
            {
                case "factura":
                    lblErrorFactura.Text = "     " + cadena;
                    lblErrorFactura.Visible = true;
                    break;
                case "paciente":
                    lblErrorPaciente.Text = "     " + cadena;
                    lblErrorPaciente.Visible = false;
                    break;
            }
        }

        private void FormatearListview()
        {
            lvFacturas.View = View.Details; // Vista modo detalles
            lvFacturas.GridLines = false; // Quitar bordes
            lvFacturas.FullRowSelect = true; // Seleccionar toda la fila
            lvFacturas.Columns.Add("Fecha", 100, HorizontalAlignment.Left);
            lvFacturas.Columns.Add("Factura", 100, HorizontalAlignment.Left);
            lvFacturas.Columns.Add("Paciente", -2, HorizontalAlignment.Left); // Poner -2 es para que se autoajuste
            this.Controls.Add(lvFacturas);
        }

        private List<Factura> CargarListadoFacturas(string origen)
        {
            List<Factura> facturas = new List<Factura>();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Factura WHERE 1";
                switch (origen)
                {
                    case "fecha":
                        sentencia += " AND Fecha = '" + mcFiltrarFecha.Value.ToString("yyyy-MM-dd") + "'";
                        break;
                    case "paciente":
                        sentencia += " AND Dni_paciente = '" + txtFiltroPaciente.Texto.ToUpper() + "'";
                        break;
                }
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Factura factura = new Factura();
                    factura.NumFactura = reader.GetString(0);
                    factura.Fecha = reader.GetDateTime(1).ToString("dd-MM-yyyy");
                    factura.NifCentro = reader.GetString(2);
                    factura.NombreCentro = reader.GetString(3);
                    factura.Direccion = reader.GetString(4);
                    factura.Localidad = reader.GetString(5);
                    factura.Cp = reader.GetString(6);
                    factura.Telefono = reader.GetString(7);
                    factura.DniPaciente = reader.GetString(8);
                    factura.NombrePaciente = reader.GetString(9);
                    factura.Apellido1Paciente = reader.GetString(10);
                    if (!reader.IsDBNull(11))
                        factura.Apellido2Paciente = reader.GetString(11);
                    if (!reader.IsDBNull(12))
                        factura.Presupuesto = reader.GetString(12);
                    facturas.Add(factura);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            return facturas;
        }

        private void CargarListView(string origen)
        {
            List<Factura> facturas = CargarListadoFacturas(origen);
            if (facturas != null)
            {
                foreach (Factura factura in facturas)
                {
                    ListViewItem objeto = new ListViewItem();
                    objeto = lvFacturas.Items.Add(factura.Fecha);
                    objeto.SubItems.Add(factura.NumFactura);
                    objeto.SubItems.Add(factura.DniPaciente);
                }
            }
        }

        private bool ExistePaciente()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Dni FROM Paciente WHERE Dni='" + txtFiltroPaciente.Texto.ToUpper() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    sw = true;
                reader.Close();
                conexion.CerrarConexion();
            }
            return sw;
        }

        private bool ExisteFactura()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT num_factura FROM factura WHERE num_factura='" + txtFiltroFactura.Texto.ToUpper() + "'";
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                    sw = true;
                reader.Close();
                conexion.CerrarConexion();
            }
            return sw;
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            OcultarInformes();
            FormatearListview();
            CargarListView("");
        }

        private void btnFiltroFactura_Click(object sender, EventArgs e)
        {
            OcultarEtiquetasError();
            if (ExisteFactura())
            {
                MostrarInformes();
                this.facturaTableAdapter.FillByFactura(this.dataSetFactura.Factura, txtFiltroFactura.Texto.ToUpper());
                this.rvFacturas.RefreshReport();
            }
            else
                MostrarMensaje("No existe el presupuesto", "presupuesto");
        }

        private void btnFiltrarPaciente_Click(object sender, EventArgs e)
        {
            OcultarInformes();
            if (ExistePaciente())
            {
                lvFacturas.Items.Clear();
                CargarListView("paciente");
            }
            else
                MostrarMensaje("El paciente no existe", "paciente");
        }

        private void mcFiltrarFecha_CloseUp(object sender, EventArgs e)
        {
            OcultarInformes();
            lvFacturas.Items.Clear();
            CargarListView("fecha");
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            OcultarInformes();
            lvFacturas.Items.Clear();
            CargarListView("");
        }

        private void lvFacturas_DoubleClick(object sender, EventArgs e)
        {
            if (lvFacturas.SelectedItems.Count > 0)
            {
                string presupuesto = lvFacturas.SelectedItems[0].SubItems[1].Text;
                MostrarInformes();
                this.facturaTableAdapter.FillByFactura(this.dataSetFactura.Factura, presupuesto);
                this.rvFacturas.RefreshReport();
            }
        }
        #endregion
    }
}
