using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class DetalleFactura
    {
        // Variables
        #region -> Variables
        private int id;
        private int tratamiento;
        private int cantidad;
        private float precio;
        private string factura;
        #endregion

        // Constructores
        #region -> Constructores
        public DetalleFactura() { }

        public DetalleFactura(int id)
        {
            this.id = id;
        }

        public DetalleFactura(int id, int tratamiento, int cantidad, float precio, string factura)
        {
            this.id = id;
            this.tratamiento = tratamiento;
            this.cantidad = cantidad;
            this.precio = precio;
            this.factura = factura;
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public int Id { get => id; set => id = value; }
        public int Tratamiento { get => tratamiento; set => tratamiento = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Factura { get => factura; set => factura = value; }
        #endregion
    }
}
