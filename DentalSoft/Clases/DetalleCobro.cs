using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class DetalleCobro
    {
        // Variables
        private string tratamiento;
        private float precio;
        private int cantidad;
        private float subtotal;

        // Constructor
        #region -> Constructores
        public DetalleCobro() { }

        public DetalleCobro(string tratamiento, float precio, int cantidad, float subtotal)
        {
            this.tratamiento = tratamiento;
            this.precio = precio;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
        #endregion
    }
}
