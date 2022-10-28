using DentalSoft.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class VisualizadorImagenes : Form
    {
        // Variables
        private string imagen;

        // Constructores
        public VisualizadorImagenes()
        {
            InitializeComponent();
        }

        public VisualizadorImagenes(string imagen)
        {
            InitializeComponent();
            this.imagen = imagen;
        }

        private void VisualizadorImagenes_Load(object sender, EventArgs e)
        {
            // pbImagen.ImageLocation = this.imagen;
            try
            {
                pbImagen.Image = Image.FromFile(this.imagen);
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {
                DialogResult mensaje = MessageBoxPersonalizadoControl.Show("Error: " + ex.Message, "DentalSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
