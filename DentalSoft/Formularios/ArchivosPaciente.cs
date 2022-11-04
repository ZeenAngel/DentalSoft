using DentalSoft.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class ArchivosPaciente : Form
    {
        // Variables
        ConexionFtp conexionFtp;
        DatosGlobales datosGlobales = new DatosGlobales();
        private string dni;

        // Constructores
        #region -> Constructores
        public ArchivosPaciente()
        {
            InitializeComponent();
        }

        public ArchivosPaciente(string dni)
        {
            InitializeComponent();
            this.dni = dni;
        }
        #endregion

        // Métodos privados
        private void OcultarMensaje()
        {
            lblErrorConexion.Visible = false;
        }

        private void MostrarMensaje(string cadena)
        {
            lblErrorConexion.Text = "     " + cadena;
            lblErrorConexion.Visible = true;
        }

        private void FormatearListView()
        {
            lvCargarFicheros.View = View.Details; // Vista modo detalles
            lvCargarFicheros.GridLines = false; // Quitar bordes
            lvCargarFicheros.FullRowSelect = true; // Seleccionar toda la fila
            lvCargarFicheros.Columns.Add("Fecha", 100, HorizontalAlignment.Left); 
            lvCargarFicheros.Columns.Add("Tamaño", 100, HorizontalAlignment.Left);
            lvCargarFicheros.Columns.Add("Nombre", -2, HorizontalAlignment.Left); // Poner -2 es para que se autoajuste
            this.Controls.Add(lvCargarFicheros);
        }

        private void CargarListView()
        {
            List<Fichero> ficheros = conexionFtp.ListarDirectorios();
            if (ficheros != null)
            {
                foreach (Fichero fichero in ficheros)
                {
                    ListViewItem objeto = new ListViewItem();
                    objeto = lvCargarFicheros.Items.Add(fichero.Fecha);
                    objeto.SubItems.Add(fichero.Tamaño);
                    objeto.SubItems.Add(fichero.Nombre);
                }
            }
        }

        // Eventos
        #region -> Eventos
        private void ArchivosPaciente_Load(object sender, EventArgs e)
        {
            conexionFtp = new ConexionFtp(ref lblErrorConexion, this.dni);
            FormatearListView();
            CargarListView();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            if (lvCargarFicheros.SelectedItems.Count > 0)
            {
                string fichero = lvCargarFicheros.SelectedItems[0].SubItems[2].Text;
                conexionFtp.DescargarFichero(fichero);
            }
            else
            {
                MostrarMensaje("Debe seleccionar un fichero a visualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OcultarMensaje();
            List<string> ficheros = new List<string>();
            List<ListViewItem> objetosBorrar = new List<ListViewItem>();
            if (lvCargarFicheros.SelectedItems.Count > 0)
            {
                foreach (ListViewItem objeto in lvCargarFicheros.SelectedItems)
                {
                    objetosBorrar.Add(objeto);
                    ficheros.Add(objeto.SubItems[2].Text);
                }
                if (conexionFtp.EliminarFichero(ficheros))
                {
                    foreach (ListViewItem objeto in objetosBorrar)
                    {
                        lvCargarFicheros.Items.Remove(objeto); // Borrar el objeto del listview
                    }
                }
            }
            else
            {
                MostrarMensaje("Debe seleccionar un fichero a eliminar");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarFichero = new OpenFileDialog();
            buscarFichero.FileName = "";
            buscarFichero.Title = "Buscar documento";
            buscarFichero.InitialDirectory = datosGlobales.DirectorioRaiz;
            if (buscarFichero.ShowDialog() == DialogResult.OK)
            {
                FileInfo informacionFichero = new FileInfo(buscarFichero.FileName);
                if(conexionFtp.SubirFichero(informacionFichero.FullName, informacionFichero.Name))
                {
                    lvCargarFicheros.Items.Clear();
                    CargarListView();
                }
                
            }
        }
        #endregion
    }
}
