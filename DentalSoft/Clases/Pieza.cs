using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class Pieza
    {
        // Variables
        #region -> Variables
        private int nombre;
        private string seccion;
        private string diagnostico;
        private string tratamiento;
        #endregion

        // Constructores
        #region -> Constructores
        public Pieza() { }

        public Pieza(int nombre, string seccion, string diagnostico, string tratamiento)
        {
            this.nombre = nombre;
            this.seccion = seccion;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public int Nombre { get => nombre; set => nombre = value; }
        public string Seccion { get => seccion; set => seccion = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        #endregion
    }
}
