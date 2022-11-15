using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Clases
{
    public class Presupuesto
    {
        // Variables
        #region -> Variables
        private string numPresupuesto;
        private string fecha;
        private string centro;
        private string paciente;
        #endregion

        // Constructores
        #region -> Constructores
        public Presupuesto() { }

        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public string NumPresupuesto { get => numPresupuesto; set => numPresupuesto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Centro { get => centro; set => centro = value; }
        public string Paciente { get => paciente; set => paciente = value; }
        #endregion
    }
}
