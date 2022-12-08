using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Clases
{
    public class DatosGlobales
    {
        // Variables
        #region -> Variables
        private string tituloAplicacion = "DentalSoft";
        private string directorioRaiz = "C:\\Dentalsoft";
        private string directorioTemporal = "C:\\Dentalsoft\\Temp";
        private string pathImagenMaximizar = "imagenes/botones/boton_maximizar_blanco.png";
        private string pathImagenRedimensionar = "imagenes/botones/boton_redimensionar_blanco.png";
        private string alergiasPredeterminado = "SIN ALERGIAS CONOCIDAS";
        private string medicacionPredeterminado = "NO TOMA NINGUNA MEDICACIÓN ACTUALMENTE";
        private string urlApiFichar = "http://localhost:8080/api/fichar";
        private string letraPrespuesto = "P";
        private string letraFactura = "F";
        private string numeroInicialPresupuesto = "00000001";
        private string correoRemitente = "dentalsoftproyectodam@gmail.com";
        private string contraseñaCorreoRemitente = "zwsbcbehdbymfgxm";
        private string hostCorreoRemitente = "smtp.gmail.com";
        private int puertoCorreoRemitente = 587;
        private bool cifradoSsl = true;
        #endregion

        // Constructor
        public DatosGlobales() { }

        // Getters y Setters
        #region -> Getters y Setters    
        public string TituloAplicacion { get => tituloAplicacion; set => tituloAplicacion = value; }
        public string DirectorioTemporal { get => directorioTemporal; set => directorioTemporal = value; }
        public string DirectorioRaiz { get => directorioRaiz; set => directorioRaiz = value; }
        public string PathBotonMaximizar { get => pathImagenMaximizar; set => pathImagenMaximizar = value; }
        public string PathBotonRedimensionar { get => pathImagenRedimensionar; set => pathImagenRedimensionar = value; }
        public string AlergiasPredeterminado { get => alergiasPredeterminado; set => alergiasPredeterminado = value; }
        public string MedicacionPredeterminado { get => medicacionPredeterminado; set => medicacionPredeterminado = value; }
        public string UrlApiFichar { get => urlApiFichar; set => urlApiFichar = value; }
        public string LetraPrespuesto { get => letraPrespuesto; set => letraPrespuesto = value; }
        public string NumeroInicialPresupuesto { get => numeroInicialPresupuesto; set => numeroInicialPresupuesto = value; }
        public string LetraFactura { get => letraFactura; set => letraFactura = value; }
        public string CorreoRemitente { get => correoRemitente; set => correoRemitente = value; }
        public string ContraseñaCorreoRemitente { get => contraseñaCorreoRemitente; set => contraseñaCorreoRemitente = value; }
        public string HostCorreoRemitente { get => hostCorreoRemitente; set => hostCorreoRemitente = value; }
        public int PuertoCorreoRemitente { get => puertoCorreoRemitente; set => puertoCorreoRemitente = value; }
        public bool CifradoSsl { get => cifradoSsl; set => cifradoSsl = value; }
        #endregion
    }
}
