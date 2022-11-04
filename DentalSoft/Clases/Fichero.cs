using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class Fichero
    {
        // Variables
        #region -> Variables
        private string nombre;
        private bool isDirectorio;
        private string tamaño;
        private string fecha;
        #endregion

        // Constructor
        public Fichero() { }

        // Getters y Setters
        #region -> Getters y Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public bool IsDirectorio { get => isDirectorio; set => isDirectorio = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        #endregion
    }
}
