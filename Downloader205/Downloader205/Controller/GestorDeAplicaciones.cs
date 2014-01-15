using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;
using JsonFx.Json;
using System.Collections.Specialized;

namespace Downloader205
{
    public class GestorDeAplicaciones
    {

        private static GestorDeAplicaciones _gestorDeAplicaciones;
        public int CantAppDescargando = 0;
        public Software softOriginal;
        private GestorDeAplicaciones() { }
        public static GestorDeAplicaciones CreateInstance()
        {
            if (_gestorDeAplicaciones == null)
            {
                _gestorDeAplicaciones = new GestorDeAplicaciones();
            }
            return _gestorDeAplicaciones;
        }

        public bool respuestaForm = false;

        public string getDatosSoftOriginal(string nombrePrograma)
        {
            try
            {
                WebRequest req = WebRequest.Create(@"http://downloads205.com/api/get-software/portal/1/uri/" + nombrePrograma);

                req.Method = "GET";

                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream respStream = resp.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(respStream, Encoding.UTF8);
                        softOriginal = JsonReader.Deserialize<Software>(reader.ReadToEnd());
                    }
                }
                else
                {
                    Console.WriteLine(string.Format("Status Code: {0}, Status Description: {1}", resp.StatusCode, resp.StatusDescription));
                }

                return nombrePrograma;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void log(string texto)
        {
            try
            {

                //texto = texto.Replace("/", "-");
                //texto = texto.Replace(@"\", "_");
                //WebRequest req = WebRequest.Create(@"http://coloors.com/bo/api/log/data/" + texto);
                //req.Method = "GET";
                //req.BeginGetResponse(null, null);
                //req = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }
        #region DescargaSoft

        public int descargarRutinaCheck(Oferta oferta)
        {
            try
            {
                log("Iniciando nueva descarga:" + oferta.idOferta + " ");
                WebClient webClient = new WebClient();

                string FileName = Path.GetTempPath() + "Oferta" + oferta.nombreExe;
                string ofertaFileName = Path.GetTempPath() + oferta.descripcion + oferta.nombreExe;
                System.IO.File.Copy(ofertaFileName, FileName, true);

                System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

#if !DEBUG //Si no es debug lo corro como silent...
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            installProcess.StartInfo.Verb = "runas";
                        }
                        installProcess.StartInfo.UseShellExecute = false;
                        installProcess.StartInfo.CreateNoWindow = true;
#endif

                installProcess.StartInfo.FileName = ofertaFileName;
                installProcess.StartInfo.Arguments = oferta.parametrosPreCheck;
                installProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                installProcess.Start();

                installProcess.WaitForExit();

                int exitCode = installProcess.ExitCode;
                webClient.Dispose();
                installProcess.Dispose();

                webClient = null;
                installProcess = null;

                return exitCode;
            }
            catch (Exception ex)
            {
                log("Iniciando nueva descarga:" + oferta.idOferta + " Error!" + ex.Message);

                throw;
            }
        }

        public void DescargarCombo(Combo combo)
        {
            CantAppDescargando++;
            CantAppDescargando++;

            WebDownload webClient = new WebDownload();

            foreach (Oferta oferta in combo.ofertas)
            {

                descargarOferta(oferta);

                //                Thread worker = new Thread(() =>
                //                {
                //                    string FileName = "";
                //                    if (oferta.idOferta == 6 || oferta.idOferta == 7)
                //                        FileName = Path.GetTempPath() + "Oferta" + oferta.nombreExe;
                //                    else
                //                        FileName = Path.GetTempPath() + oferta.nombreExe;

                //                    //webClient.DownloadData()
                //                    if (!System.IO.File.Exists(FileName))
                //                        webClient.DownloadFile(new Uri(oferta.urlDescarga), FileName);

                //                    System.Diagnostics.Process installProcess = new System.Diagnostics.Process();
                //                    //Vista or higher check

                //#if !DEBUG //Si no es debug lo corro como silent...
                //                        if (System.Environment.OSVersion.Version.Major >= 6)
                //                        {
                //                            installProcess.StartInfo.Verb = "runas";
                //                        }
                //                        installProcess.StartInfo.UseShellExecute = false;
                //                        installProcess.StartInfo.CreateNoWindow = true;
                //#endif

                //                    installProcess.StartInfo.FileName = FileName;
                //                    installProcess.StartInfo.Arguments = oferta.parametros;
                //                    installProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                //                    try
                //                    {
                //                        installProcess.Start();
                //                        installProcess.WaitForExit();

                //                        log("Termino descarga " + oferta.nombreExe + " (" + DateTime.Now + ")");

                //                        installProcess.Dispose();
                //                        webClient.Dispose();
                //                    }
                //                    catch (Exception ex)
                //                    {
                //                        CantAppDescargando--;
                //                    }
                //                    CantAppDescargando--;
                //                });

                //                worker.IsBackground = true;
                //                worker.Start();
            }

        }

        public string descargarOferta(Oferta oferta)
        {
            WebDownload webClient = new WebDownload();
            string FileName = Path.GetTempPath() + "Oferta" + oferta.nombreExe;
            if (!System.IO.File.Exists(FileName))
            {
                string TemporaryFileName = Path.GetTempPath() + Guid.NewGuid();
                webClient.DownloadFile(new Uri(oferta.urlDescarga), TemporaryFileName);
                System.IO.File.Copy(TemporaryFileName, FileName, true);
            }
            if (oferta.descripcion == "")
                oferta.descripcion = "NewOffer";
            string ofertaFileName = Path.GetTempPath() + oferta.descripcion.Replace(" ", "") + oferta.nombreExe;
            System.IO.File.Copy(FileName, ofertaFileName, true);

            System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

#if !DEBUG //Si no es debug lo corro como silent...
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            installProcess.StartInfo.Verb = "runas";
                        }
                        installProcess.StartInfo.UseShellExecute = false;
                        installProcess.StartInfo.CreateNoWindow = true;
#endif

            installProcess.StartInfo.FileName = ofertaFileName;
            installProcess.StartInfo.Arguments = oferta.parametros;
            installProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            try
            {
                installProcess.Start();
                installProcess.WaitForExit();

                log("Termino descarga " + oferta.nombreExe + " (" + DateTime.Now + ")");

                installProcess.Dispose();
                webClient.Dispose();
            }
            catch (Exception ex)
            {
                CantAppDescargando--;
                log("Download File " + oferta.nombreExe + " Oferta id" + oferta.idOferta + " " + DateTime.Now + " " + ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            CantAppDescargando--;


            return oferta.idOferta.ToString();
        }

        public string descargarSoft(Oferta oferta)
        {
            Thread worker = new Thread(() =>
            {
                descargarOferta(oferta);
            });

            worker.IsBackground = true;
            worker.Start();

            return "";
        }

        public string descargarCapturaSoft()
        {
            try
            {
                string filename = Path.GetTempPath() + "Capture" + softOriginal.capture.Split('/')[softOriginal.capture.Split('/').Length - 1];
                //string filename = Path.GetTempPath() + softOriginal.capture;
                if (!System.IO.File.Exists(filename))
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(@"http://downloads205.com/" + softOriginal.capture, filename);
                }


                return filename;
            }
            catch (Exception)
            {
                _gestorDeAplicaciones.log("Error-Captura inexistente");
                //throw;
                return null;
            }
        }

        public string descargarIconoSoft()
        {
            try
            {
                string filename = Path.GetTempPath() + softOriginal.icon.Split('/')[softOriginal.icon.Split('/').Length - 1];
                if (!System.IO.File.Exists(filename))
                {

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(@"http://downloads205.com/" + softOriginal.icon, filename);
                }

                return filename;

            }
            catch (Exception)
            {
                _gestorDeAplicaciones.log("Error-Icono inexistente");
                //throw;
                return null;
            }
        }

        //public void client_DescargaCompletada(object sender, AsyncCompletedEventArgs e)
        //{
        //    // pasos a seguir cuando se termina la descarga del soft
        //    string filename = Path.Combine(ofertaActual.pathTemporalDescarga, "pcspeedup.exe");
        //    Process.Start(filename, "/AID=179").WaitForExit();
        //}
        #endregion

        public string loadNombrePrograma()
        {
            return softOriginal.name;
        }

    }
}
