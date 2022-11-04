using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class DatosPaciente : Form
    {
        // Variables
        private Clases.Paciente paciente;

        // Constructores
        #region -> Constructores
        public DatosPaciente()
        {
            InitializeComponent();
        }

        public DatosPaciente(Clases.Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
        }
        #endregion

        // Métodos privados
        #region -> Métodos privados
        private void CargarDatos()
        {
            txtDni.Texto = paciente.Dni;
            txtNombre.Texto = paciente.Nombre;
            txtApellido1.Texto = paciente.Apellido1;
            if (paciente.Apellido2 != null)
                txtApellido2.Texto = paciente.Apellido2;
            txtTelefono.Texto = paciente.Telefono;
            if (paciente.Email != null)
                txtEmail.Texto = paciente.Email;
            txtCp.Texto = paciente.Cp;
            txtDireccion.Texto = paciente.Direccion;
            textboxPersonalizado1.Texto = paciente.Edad.ToString();
            if (paciente.Genero.Equals("M"))
                textboxPersonalizado2.Texto = "Masculino";
            else
                textboxPersonalizado2.Texto = "Femenino";
        }
        #endregion

        // Eventos
        #region -> Eventos
        private void DatosPaciente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
