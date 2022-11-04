using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalSoft.Formularios
{
    public partial class EpisodiosClinicos : Form
    {
        // Variables
        private MenuPrincipalPaciente formPadre;
        private string dni;

        // Constructores
        #region -> Constructores
        public EpisodiosClinicos()
        {
            InitializeComponent();
        }

        public EpisodiosClinicos(string dni, MenuPrincipalPaciente formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            this.dni = dni;
        }
        #endregion

        private void btnAtras_Click(object sender, EventArgs e)
        {
            HistorialPaciente historialPaciente = new HistorialPaciente(this.dni, this.formPadre);
            this.Close();
        }

        private void EpisodiosClinicos_Load(object sender, EventArgs e)
        {
            this.episodio_clinicoTableAdapter.FillTodosEpisodios(this.dataSetEpisodioClinico.episodio_clinico, this.dni);
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrarTodos_Click(object sender, EventArgs e)
        {
            this.episodio_clinicoTableAdapter.FillTodosEpisodios(this.dataSetEpisodioClinico.episodio_clinico, this.dni);
            this.reportViewer1.RefreshReport();
        }

        private void mcFiltrarFecha_CloseUp(object sender, EventArgs e)
        {
            this.episodio_clinicoTableAdapter.FillEpisodiosByFecha(this.dataSetEpisodioClinico.episodio_clinico, this.dni, mcFiltrarFecha.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
