using DentalSoft.Clases;
using DentalSoft.ControlesPersonalizados;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
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
    public partial class Presupuestos : Form
    {
        // Variables
        private ConexionBD conexion = new ConexionBD();

        // Constructores
        public Presupuestos()
        {
            InitializeComponent();
        }

        // Métodos privados
        #region -> Métodos privados
        private void OcultarInformes()
        {
            rvPresupuesto.Visible = false;
            lvPresupuestos.Visible = true;
        }

        private void MostrarInformes()
        {
            rvPresupuesto.Visible = true;
            lvPresupuestos.Visible = false;
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
                case "presupuesto":
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
            lvPresupuestos.View = View.Details; // Vista modo detalles
            lvPresupuestos.GridLines = false; // Quitar bordes
            lvPresupuestos.FullRowSelect = true; // Seleccionar toda la fila
            lvPresupuestos.Columns.Add("Fecha", 100, HorizontalAlignment.Left);
            lvPresupuestos.Columns.Add("Presupuesto", 100, HorizontalAlignment.Left);
            lvPresupuestos.Columns.Add("Paciente", -2, HorizontalAlignment.Left); // Poner -2 es para que se autoajuste
            this.Controls.Add(lvPresupuestos);
        }

        private List<Presupuesto> CargarListadoPresupuestos(string origen)
        {
            List<Presupuesto> presupuestos = new List<Presupuesto>();
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT * FROM Presupuesto WHERE 1";
                switch (origen)
                {
                    case "fecha":
                        sentencia += " AND Fecha = '" + mcFiltrarFecha.Value.ToString("yyyy-MM-dd") + "'";
                        break;
                    case "paciente":
                        sentencia += " AND Paciente = '" + txtFiltroPaciente.Texto.ToUpper() + "'";
                        break;
                }
                MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Presupuesto presupuesto= new Presupuesto();
                    presupuesto.NumPresupuesto = reader.GetString(0);
                    presupuesto.Fecha = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                    presupuesto.Centro = reader.GetString(2);
                    presupuesto.Paciente = reader.GetString(3);
                    presupuestos.Add(presupuesto);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            return presupuestos;
        }

        private void CargarListView(string origen)
        {
            List<Presupuesto> presupuestos = CargarListadoPresupuestos(origen);
            if (presupuestos != null)
            {
                foreach (Presupuesto presupuesto in presupuestos)
                {
                    ListViewItem objeto = new ListViewItem();
                    objeto = lvPresupuestos.Items.Add(presupuesto.Fecha);
                    objeto.SubItems.Add(presupuesto.NumPresupuesto);
                    objeto.SubItems.Add(presupuesto.Paciente);
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

        private bool ExistePresupuesto()
        {
            bool sw = false;
            if (conexion.EstablecerConexion())
            {
                string sentencia = "SELECT Num_presupuesto FROM Presupuesto WHERE Num_presupuesto='" + txtFiltroPresupuesto.Texto.ToUpper() + "'";
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
        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPresupuestos.DetallePresupuesto' Puede moverla o quitarla según sea necesario.
            this.detallePresupuestoTableAdapter.Fill(this.dataSetPresupuestos.DetallePresupuesto);
            OcultarInformes();
            FormatearListview();
            CargarListView("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltroPresupuesto_Click(object sender, EventArgs e)
        {
            OcultarEtiquetasError();
            if (ExistePresupuesto())
            {
                MostrarInformes();
                this.detallePresupuestoTableAdapter.FillByPresupuesto(this.dataSetPresupuestos.DetallePresupuesto, txtFiltroPresupuesto.Texto.ToUpper());
                this.rvPresupuesto.RefreshReport();
            }else
                MostrarMensaje("No existe el presupuesto", "presupuesto");

        }

        private void btnFiltrarPaciente_Click(object sender, EventArgs e)
        {
            OcultarInformes();
            if (ExistePaciente())
            {
                lvPresupuestos.Items.Clear();
                CargarListView("paciente");
            }
            else
                MostrarMensaje("El paciente no existe", "paciente");
        }

        private void mcFiltrarFecha_CloseUp(object sender, EventArgs e)
        {
            OcultarInformes();
            lvPresupuestos.Items.Clear();
            CargarListView("fecha");
            
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            OcultarInformes();
            lvPresupuestos.Items.Clear();
            CargarListView("");
        }

        private void lvPresupuestos_DoubleClick(object sender, EventArgs e)
        {
            if (lvPresupuestos.SelectedItems.Count > 0)
            {
                string presupuesto = lvPresupuestos.SelectedItems[0].SubItems[1].Text;
                MostrarInformes();
                this.detallePresupuestoTableAdapter.FillByPresupuesto(this.dataSetPresupuestos.DetallePresupuesto, presupuesto);
                this.rvPresupuesto.RefreshReport();
            }
        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            NuevoPresupuesto nuevoPresupuesto = new NuevoPresupuesto();
            nuevoPresupuesto.ShowDialog();
            OcultarInformes();
            lvPresupuestos.Items.Clear();
            CargarListView("");
        }
        #endregion
    }
}
