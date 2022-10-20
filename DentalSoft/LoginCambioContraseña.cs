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

namespace DentalSoft
{
    public partial class LoginCambioContraseña : Form
    {
        public string dniEmpleado;

        public LoginCambioContraseña()
        {
            InitializeComponent();
        }

        private void btnGuardarLoginCambioContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña1LoginCambioContraseña.Texto.Equals(txtContraseña2LoginCambioContraseña.Texto))
            {
                if (! txtContraseña1LoginCambioContraseña.Texto.Equals(dniEmpleado))
                {
                    Clases.ConexionBD conexion = new Clases.ConexionBD();
                    conexion.EstablecerConexion();
                    string sentencia = "UPDATE identificacion_empleado SET Password=" + txtContraseña1LoginCambioContraseña.Texto + ", Cambiar_Password=0 WHERE Usuario='" + dniEmpleado + "'"; // Cambiar la contraseña
                    MySqlCommand comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    comando = new MySqlCommand(sentencia, conexion.conexionSql);
                    comando.ExecuteNonQuery();
                    this.Dispose();
                }
                else
                {
                    lblErrorLoginCambioContraseña.Text = "     La contraseña no puede ser el dni del empleado";
                }
            }
            else
            {
                lblErrorLoginCambioContraseña.Text = "      Las contraseñas no coinciden";
            }
        }

        private void txtContraseña1LoginCambioContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnGuardarLoginCambioContraseña_Click(sender, e);
            }
        }

        private void txtContraseña2LoginCambioContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnGuardarLoginCambioContraseña_Click(sender, e);
            }
        }
    }
}
