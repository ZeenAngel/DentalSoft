using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class DetallePresupuesto
    {
        // Variables
        private int id;
        private int tratamiento;
        private int cantidad;
        private string presupuesto;

        // Constructores
        #region -> Constructores
        public DetallePresupuesto() { }

        public DetallePresupuesto(int id)
        {
            this.id = id;
        }

        public DetallePresupuesto(int id, int tratamiento, int cantidad, string presupuesto)
        {
            this.id = id;
            this.tratamiento = tratamiento;
            this.cantidad = cantidad;
            this.presupuesto = presupuesto;
        }
        #endregion

        // Getters y Setters
        #region -> Getters y Setters
        public int Id { get => id; set => id = value; }
        public int Tratamiento { get => tratamiento; set => tratamiento = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Presupuesto { get => presupuesto; set => presupuesto = value; }
        #endregion
    }
}
