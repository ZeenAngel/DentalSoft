using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DentalSoft.Clases
{
    internal class Estilo
    {

        // Constantes
        const String AZUL = "#106EC4";
        const String AZULCELESTE = "#B4D2E6";
        const String VERDE = "#00C3A5";
        const String GRIS = "#ECECEC";
        const String NEGRO = "#000000";
        const String FUENTETEXTO = "Roboto";

        // Variables
        private DataGridView dgv;
        private ColorConverter cv = new ColorConverter();

        public void EstiloDataGridView(DataGridView nuevo)
        {
            this.dgv = nuevo;

            // Estilo general celdas
            DataGridViewCellStyle estiloCeldas = new DataGridViewCellStyle();         
            estiloCeldas.BackColor = (Color)cv.ConvertFromString(GRIS); // Cambiar color fondo celda
            estiloCeldas.ForeColor = (Color)cv.ConvertFromString(NEGRO); // Cambiar color fuente
            estiloCeldas.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alinear el contenido de la celda
            estiloCeldas.NullValue = ""; // Cambiar el valor por defecto de las celdas sin asignar
            estiloCeldas.SelectionBackColor = (Color)cv.ConvertFromString(VERDE); // Cambiar el color de fondo de la fila seleccionada
            estiloCeldas.WrapMode = DataGridViewTriState.True; // Ajustar las celdas al tamaño del contenido
            estiloCeldas.Font = new Font(FUENTETEXTO, 14, FontStyle.Regular); // Asignar fuente por defecto
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dgv.DefaultCellStyle = estiloCeldas;  // Asignar el estilo al DGV
            this.dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // Ajustar el tamaño de las filas automáticamente
            this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Ajustar el alto de las filas automáticamente

            // Establecer estilo cabecera
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; // Establecer alto de cabecera autoajustable
            this.dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders; // Establece el ancho de la cabecera por defecto a su contenido
            this.dgv.EnableHeadersVisualStyles = false; // Deshabilitar que la cabecera utilice los estilos actuales
            DataGridViewCellStyle estiloCabecera = new DataGridViewCellStyle(); // Crear estilo para la cabecera
            estiloCabecera.BackColor = (Color)cv.ConvertFromString(AZUL); // Cambiar Fondo Cabecera
            estiloCabecera.ForeColor = (Color)cv.ConvertFromString(NEGRO); // Cambiar Color Fuente Cabecera
            estiloCabecera.Font = new Font(FUENTETEXTO, 18, FontStyle.Bold); // Cambiar Tipo de fuente de Cabecera
            estiloCabecera.Padding = new Padding(0, 0, 0, 0); // Reducir Padding a 0 para intentar centrar el texto de la cabecera
            estiloCabecera.Alignment = DataGridViewContentAlignment.MiddleLeft; // Cambiar la alineación de la Cabecera   
            this.dgv.ColumnHeadersDefaultCellStyle = estiloCabecera; // Asignar el estilo a la cabecera
            // this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Quitar los bordes de la cabecera

            // Establecer estilo filas alternas
            DataGridViewCellStyle estiloFilas = new DataGridViewCellStyle(); // Crear estilo para las filas   
            estiloFilas.BackColor = (Color)cv.ConvertFromString(AZULCELESTE); // Asignar color de fondo a la fila pareja  
            estiloFilas.ForeColor = (Color)cv.ConvertFromString(NEGRO); // Asignar color de fuente a la fila pareja
            estiloFilas.NullValue = ""; // Asignar valor por defecto de las celdas sin asignar de la fila pareja
            this.dgv.AlternatingRowsDefaultCellStyle = estiloFilas;

            // Retoques generales DataGridLayout
            this.dgv.RowTemplate.Height = 30; // Cambiar altura de la fila
            this.dgv.BackgroundColor = (Color)cv.ConvertFromString(GRIS); // Cambiar color fondo DGV
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Cuando se selecciona un campo, se selecciona toda la fila
            this.dgv.MultiSelect = false; // Deshabilitar la selección múltiple de filas

            // Quitar bordes DGV
            this.dgv.BorderStyle = BorderStyle.None; // Quitar el borde al DGV
            this.dgv.AllowUserToAddRows = false; // Quitar la fila en blanco del final que permite agregar
            this.dgv.RowHeadersVisible = false; // Ocultar la columna de la izquierda
        }
    }
}
