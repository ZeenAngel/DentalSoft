using DentalSoft.Formularios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Label = System.Windows.Forms.Label;

namespace DentalSoft.Clases
{
    
    public class ConexionFtp
    {
        // Variables
        private Label lblResultados;
        private string servidor = "ftp://localhost/dentalsoft";
        private string usuario = "dentalsoft";
        private string password = "oretania";
        private string directorioTemporal = "C:\\Dentalsoft\\Temp";

        // Constructores
        #region -> Constructores
        public ConexionFtp() { }

        public ConexionFtp(ref Label lblResultados)
        {
            this.lblResultados = lblResultados;
        }

        public ConexionFtp(ref Label lblResultados, string dni)
        {
            this.lblResultados = lblResultados;
            this.servidor += "/" + dni;
        }
        #endregion

        // Métodos
        #region -> Métodos
        private void MostrarMensaje(string cadena)
        {
            lblResultados.Visible = true;
            lblResultados.Text = "     " + cadena;
        }

        private void OcultarMensaje()
        {
            lblResultados.Visible = false;
        }

        public List<Fichero> ListarDirectorios()
        {
            List<Fichero> listado = null;
            string datos = CargarDirectorios();      
            if(!datos.Equals("Error"))
            {
                listado = new List<Fichero>();
                string[] ficheros = datos.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); // Partir los datos por cada salto de línea
                string temporal = "";
                foreach (string objeto in ficheros)
                {
                    Fichero fichero = new Fichero();
                    temporal = objeto.Trim();
                    if (temporal.Substring(0, 1).Equals("d")) // Comprobar si es directorio
                        fichero.IsDirectorio = true;
                    else
                        fichero.IsDirectorio = false;
                    int tamaño = int.Parse(temporal.Substring(20, 15).Trim());
                    if (tamaño < 1000) // Tamaño
                        fichero.Tamaño = tamaño + " bytes";
                    else
                        fichero.Tamaño = tamaño / 1000 + " KB";
                    fichero.Fecha = temporal.Substring(36, 12); // Fecha
                    fichero.Nombre = temporal.Substring(49, temporal.Length - 49); // Nombre
                    if (!fichero.Nombre.Equals("") && !fichero.Nombre.Equals(".") && !fichero.Nombre.Equals(".."))
                        listado.Add(fichero);
                }
            }
            else
            {
                CrearDirectorioPaciente();
            }
            return listado;
        }

        private string CargarDirectorios()
        {
           OcultarMensaje();
            try
            {
                Uri uri = new Uri(this.servidor); // Crear la URL
                FtpWebRequest clienteRequest = (FtpWebRequest)WebRequest.Create(uri); // Crear el Objeto Ftp
                clienteRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                clienteRequest.Credentials = new NetworkCredential(this.usuario, this.password); // Crear y cargar las credenciales
                clienteRequest.EnableSsl = false; // Especificar que no hay SSL           
                clienteRequest.KeepAlive = false; // Evitar que se cierre la conexión

                FtpWebResponse respuesta = (FtpWebResponse)clienteRequest.GetResponse(); // Crear el objeto de la respuesta FTP
                StreamReader reader = new StreamReader(respuesta.GetResponseStream(), Encoding.UTF8); // Crear el flujo y el filtro de lectura
                string resultado = reader.ReadToEnd();
                reader.Close(); // Cerrar reader
                respuesta.Close(); // Cerrar respuesta
                return resultado;
            }
            catch(Exception e)
            {
                MostrarMensaje("Error en la conexión FTP: " + e.Message);
                return "Error";
            }
        }

        public bool DescargarFichero(string nombre)
        {
            OcultarMensaje();
            FtpWebRequest clienteRequest = (FtpWebRequest)FtpWebRequest.Create(this.servidor + "/" + nombre);
            clienteRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            clienteRequest.Credentials = new NetworkCredential(this.usuario, this.password); // Crear y cargar las credenciales
            try
            {
                if (!Directory.Exists(directorioTemporal))
                {
                    DirectoryInfo directorio = Directory.CreateDirectory(directorioTemporal);
                }
            }
            catch (Exception e)
            {
                MostrarMensaje("Error en el acceso a la carpeta temporal: " + e.Message);
                return false;
            }
            try
            {
                string temporal = Path.Combine(directorioTemporal, nombre);
                FileStream flujoFichero = File.OpenWrite(temporal);
                Stream flujo = clienteRequest.GetResponse().GetResponseStream();
                byte[] buffer = new byte[1024];
                int leido;
                while ((leido = flujo.Read(buffer, 0, 1024)) != 0)
                    flujoFichero.Write(buffer, 0, leido);
                flujo.Close();
                flujoFichero.Flush();
                flujoFichero.Close();
                VisualizadorImagenes vi = new VisualizadorImagenes(directorioTemporal + "\\" + nombre);
                vi.ShowDialog();
                return true;
            }
            catch(Exception e)
            {
                MostrarMensaje("Error en la descarga del fichero: " + e.Message);
                return false;
            }

            /*
            try
            {
                FtpWebRequest clienteRequest = (FtpWebRequest)FtpWebRequest.Create(this.servidor + "/" + nombre);
                clienteRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                clienteRequest.Credentials = new NetworkCredential(this.usuario, this.password); // Crear y cargar las credenciales
                using(StreamReader reader = new StreamReader(clienteRequest.GetResponse().GetResponseStream()))
                {
                    string resultado = reader.ReadToEnd();
                    try
                    {
                        if (!Directory.Exists(directorioTemporal))
                        {
                            DirectoryInfo directorio = Directory.CreateDirectory(directorioTemporal);
                        }
                    }
                    catch(Exception e)
                    {
                        MostrarMensaje("Error en el acceso a la carpeta temporal: " + e.Message);
                        return false;
                    }
                    string temporal = Path.Combine(directorioTemporal, nombre);
                    using(StreamWriter writer = new StreamWriter(temporal, false))
                    {
                        writer.Write(resultado);
                        writer.Flush();
                        writer.Close();
                    }
                    reader.Close();
                }
                VisualizadorImagenes vi = new VisualizadorImagenes(directorioTemporal + "\\" + nombre);
                vi.ShowDialog();
                // Process.Start(directorioTemporal + "\\" + nombre); // No visualiza la imagen correctamente curiosamente
                return true;
            }catch(Exception e)
            {
                MostrarMensaje("Error en la descarga del fichero: " + e.Message);
                return false;
            }
            */
        }

        private bool ComprobarExtension(string nombre)
        {
            
            if (nombre.Substring(nombre.LastIndexOf('.'), nombre.Length - nombre.LastIndexOf('.')).Equals(".jpg") ||
                nombre.Substring(nombre.LastIndexOf('.'), nombre.Length - nombre.LastIndexOf('.')).Equals(".jpeg") ||
                nombre.Substring(nombre.LastIndexOf('.'), nombre.Length - nombre.LastIndexOf('.')).Equals(".png") ||
                nombre.Substring(nombre.LastIndexOf('.'), nombre.Length - nombre.LastIndexOf('.')).Equals(".gif") ||
                nombre.Substring(nombre.LastIndexOf('.'), nombre.Length - nombre.LastIndexOf('.')).Equals(".bmp"))
            {
                return true;
            }
            else
                return false;

        }

        public bool SubirFichero(string fichero, string nombre)
        {
            OcultarMensaje();
            if(ComprobarExtension(nombre))
            {
                try
                {
                    FtpWebRequest clienteRequest = (FtpWebRequest)FtpWebRequest.Create(this.servidor + "/" + nombre);
                    clienteRequest.Method = WebRequestMethods.Ftp.UploadFile;
                    clienteRequest.Credentials = new NetworkCredential(this.usuario, this.password);
                    using (FileStream flujoFichero = File.OpenRead(fichero)) // Crear el flujo de lectura del fichero
                    {
                        byte[] buffer = new byte[flujoFichero.Length]; // Buffer de lectura
                        flujoFichero.Read(buffer, 0, buffer.Length);
                        flujoFichero.Close();
                        using (Stream flujoFtp = clienteRequest.GetRequestStream()) // Crear el flujo de escritura
                        {
                            flujoFtp.Write(buffer, 0, buffer.Length); // Escribir el fichero
                            flujoFtp.Flush(); // Limpiar el buffer
                            flujoFtp.Close();
                        }
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MostrarMensaje("Error en la subida del fichero: " + e.Message);
                    return false;
                }
            }
            else
            {
                MostrarMensaje("Solo puede subir ficheros de imagen");
                return false;
            } 
        }

        public bool EliminarFichero(List<string> ficheros)
        {
            OcultarMensaje();
            try
            {
                Uri uri = new Uri(this.servidor);
                foreach(string fichero in ficheros)
                {
                    FtpWebRequest clienteRequest = (FtpWebRequest)FtpWebRequest.Create(this.servidor + "/" + fichero);
                    clienteRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                    clienteRequest.Credentials = new NetworkCredential(this.usuario, this.password);
                    FtpWebResponse respuesta = (FtpWebResponse)clienteRequest.GetResponse();
                    respuesta.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MostrarMensaje("Error en la eliminación del fichero: " + e.Message);
                return false;
            }
        }

        private void CrearDirectorioPaciente()
        {
            try
            {
                Uri uri = new Uri(this.servidor);
                FtpWebRequest clienteRequest = WebRequest.Create(this.servidor) as FtpWebRequest;
                clienteRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                clienteRequest.Credentials = new NetworkCredential(this.usuario, this.password);
                FtpWebResponse respuesta = clienteRequest.GetResponse() as FtpWebResponse;
                respuesta.Close();
                ListarDirectorios();
            }
            catch(Exception e)
            {
                MostrarMensaje("Error en la creación de la carpeta del paciente. Error: " + e.Message);
            }
        }
        #endregion
    }

    

}
