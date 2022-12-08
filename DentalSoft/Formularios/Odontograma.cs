using DentalSoft.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class Odontograma : Form
    {
        // Variables
        private Paciente paciente;
        private Empleado empleado;

        // Constructores
        #region -> Constructores
        public Odontograma()
        {
            InitializeComponent();
        }

        public Odontograma(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }

        public Odontograma(Paciente paciente, Empleado empleado)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.empleado = empleado;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void ActivarBoton()
        {
            if(empleado.Puesto == 1 || empleado.Puesto == 3 || empleado.Puesto == 5)
                btnCrearOdontograma.Visible = true;
        }

        private void DesactivarBoton()
        {
            btnCrearOdontograma.Visible = false;
        }

        private void MostrarMensaje(string cadena)
        {
            lblError.Text = "     " + cadena;
            lblError.Visible = true;
            ActivarBoton();
        }

        private void OcultarMensaje()
        {
            lblError.Visible = false;
            DesactivarBoton();
        }

        private void ColorOdontograma(string diagnostico, Label etiqueta)
        {
            switch (diagnostico)
            {
                case "Caries":
                    etiqueta.BackColor = Color.Red;
                    break;
                case "Fractura":
                    etiqueta.BackColor = Color.White;
                    break;
                case "Obturación":
                    etiqueta.BackColor = Color.Blue;
                    break;
                case "Endodoncia":
                    etiqueta.BackColor = Color.White;
                    break;
                case "Ausencia":
                    etiqueta.BackColor = Color.Black;
                    break;
                case "Corona":
                    etiqueta.BackColor = Color.White;
                    break;
                case "Puente":
                    etiqueta.BackColor = Color.White;
                    break;
                case "Caries radiografia":
                    etiqueta.BackColor = Color.Green;
                    break;
                case "Erupción":
                    etiqueta.BackColor = Color.White;
                    break;
            }
        }

        private List<string> CargarSecciones()
        {
            List<string> secciones = new List<string>();
            secciones.Add("Oclusal");
            secciones.Add("Vestibular");
            secciones.Add("Lingual");
            secciones.Add("Mesial");
            secciones.Add("Distal");
            return secciones;
        }

        private void ImagenOdontograma(string diagnostico, Label etiqueta)
        {
            switch (diagnostico)
            {
                case "Fractura":
                    etiqueta.Image = Image.FromFile("imagenes/odontograma/letra_t.png");
                    break;
                case "Endodoncia":
                    etiqueta.Image = Image.FromFile("imagenes/odontograma/letra_e.png");
                    break;
                case "Corona":
                    etiqueta.Image = Image.FromFile("imagenes/odontograma/circulo_azul.png");
                    break;
                case "Puente":
                    etiqueta.Image = Image.FromFile("imagenes/odontograma/circulo_rojo.png");
                    break;
                case "Erupción":
                    etiqueta.Image = Image.FromFile("imagenes/odontograma/flecha_azul.png");
                    break;
            }
        }

        private Label BuscarArcada(int pieza, string nombreEtiqueta)
        {
            Label etiqueta = null;
            if(pieza >= 11 && pieza <= 18)
                etiqueta = pnlArcadaSuperiorIzquierda.Controls.OfType<Label>().FirstOrDefault(label => label.Name.Equals(nombreEtiqueta));
            else if(pieza >= 21 && pieza <= 28)
                etiqueta = pnlArcadaSuperiorDerecha.Controls.OfType<Label>().FirstOrDefault(label => label.Name.Equals(nombreEtiqueta));
            else if(pieza >= 31 && pieza <= 38)
                etiqueta = pnlArcadaInferiorDerecha.Controls.OfType<Label>().FirstOrDefault(label => label.Name.Equals(nombreEtiqueta));
            else
                etiqueta = pnlArcadaInferiorIzquierda.Controls.OfType<Label>().FirstOrDefault(label => label.Name.Equals(nombreEtiqueta));
            return etiqueta;
        }

        private string QuitarEspacios(string seccion)
        {
            return Regex.Replace(seccion, @"\s+", String.Empty);
        }

        private void ComprobarRaiz(int pieza, string diagnostico)
        {
            string nombreEtiqueta = "";
            List<string> raices = new List<string>();
            raices.Add("RaizIzquierda");
            raices.Add("RaizDerecha");
            if(pieza == 16 || pieza == 17 || pieza == 18 || pieza == 26 || pieza == 27 || pieza == 28)
            {
                raices.Add("RaizCentral");
                foreach(string raiz in raices)
                {
                    nombreEtiqueta = "lbl" + pieza + raiz;
                    Label etiqueta = BuscarArcada(pieza, nombreEtiqueta);
                    ColorOdontograma(diagnostico, etiqueta);
                    ImagenOdontograma(diagnostico, etiqueta);
                }
                raices.Remove("RaizCentral");
            }
            else if(pieza == 36 || pieza == 37 || pieza == 38 || pieza == 46 || pieza == 47 || pieza == 48)
            {
                foreach (string raiz in raices)
                {
                    nombreEtiqueta = "lbl" + pieza + raiz;
                    Label etiqueta = BuscarArcada(pieza, nombreEtiqueta);
                    ColorOdontograma(diagnostico, etiqueta);
                    ImagenOdontograma(diagnostico, etiqueta);
                }
            }
            else
            {
                nombreEtiqueta = "lbl" + pieza + "Raiz";
                Label etiqueta = BuscarArcada(pieza, nombreEtiqueta);
                ColorOdontograma(diagnostico, etiqueta);
                ImagenOdontograma(diagnostico, etiqueta);
            }
        }

        private string CrearNombreEtiqueta(string nombreEtiqueta, int pieza, string seccion)
        {
            nombreEtiqueta = "lbl" + pieza;
            switch (seccion)
            {
                case "Raiz izquierda":
                    nombreEtiqueta += "RaizIzquierda";
                    break;
                case "Raiz derecha":
                    nombreEtiqueta += "RaizDerecha";
                    break;
                case "Raiz central":
                    nombreEtiqueta += "RaizCentral";
                    break;
                default:
                    nombreEtiqueta += QuitarEspacios(seccion);
                    break;
            }
            return nombreEtiqueta;
        }

        private void CargarOdontograma()
        {
            OcultarMensaje();
            DesactivarBoton();
            if (this.paciente.CargarOdontograma())
            {
                List<string> secciones = CargarSecciones();
                string nombreEtiqueta = "";
                foreach (Pieza pieza in this.paciente.Odontograma)
                {
                    if (!pieza.Seccion.Equals("Completa"))
                    {
                        nombreEtiqueta = CrearNombreEtiqueta(nombreEtiqueta, pieza.Nombre, pieza.Seccion);
                        Label etiqueta = BuscarArcada(pieza.Nombre, nombreEtiqueta);
                        ColorOdontograma(pieza.Diagnostico, etiqueta);
                        ImagenOdontograma(pieza.Diagnostico, etiqueta);
                    }
                    else
                    {
                        ComprobarRaiz(pieza.Nombre, pieza.Diagnostico);
                        foreach (string seccion in secciones)
                        {
                            nombreEtiqueta = "lbl" + pieza.Nombre + seccion;
                            Label etiqueta = BuscarArcada(pieza.Nombre, nombreEtiqueta);
                            ColorOdontograma(pieza.Diagnostico, etiqueta);
                            ImagenOdontograma(pieza.Diagnostico, etiqueta);
                        }
                    }
                }
            }
            else
            {
                MostrarMensaje("El paciente no tiene creado un odontograma.");
                ActivarBoton();
            }
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void Odontograma_Load(object sender, EventArgs e)
        {
           CargarOdontograma();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearOdontograma_Click(object sender, EventArgs e)
        {
            TratamientoPaciente tratamientoPaciente = new TratamientoPaciente(this.paciente);
            tratamientoPaciente.ShowDialog();
            CargarOdontograma();
            if(paciente.Odontograma.Count() > 0)
                DesactivarBoton();
        }
        #endregion
    }
}
