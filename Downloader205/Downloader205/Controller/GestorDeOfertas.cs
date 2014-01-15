using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Security.Principal;

namespace Downloader205.Controller
{
    public class GestorDeOfertas
    {
        // Guardo todas las ofertas que se revisaron y son posibles de ofrecer al cliente
        GestorDeAplicaciones gestorApp;
        private List<Oferta> ofertasDisponibles = new List<Oferta>();
        private List<Steep> steeps = new List<Steep>();

        public GestorDeOfertas()
        {
            InicializarListaOfertas();
            gestorApp = GestorDeAplicaciones.CreateInstance();
        }

        private void InicializarListaOfertas()
        {
            steeps = new List<Steep>();
            //List<Steep> steeps = new List<Steep>();

            Steep steep = new Steep();
            Combo combo = new Combo();
            Oferta oferta;

            // COMBO 1
            #region InstallMonetizer - Search Protect
            steep.idSteep = 1;

            if (steep.combosDeOfertas == null)
                steep.combosDeOfertas = new List<Combo>();

            combo.idCombo = 1;
            combo.nombre = "Search Protect";

            oferta = new Oferta();
            oferta.idOferta = 1;
            oferta.descripcion = "Search Protect";
            oferta.urlDescarga = "http://cdn.goateastcach.us/cdn/Unipack_Installer.exe";
            oferta.nombreExe = "Unipack_Installer.exe";
            oferta.parametros = "/type=installer /AID=243 /PubID=12960 /CBID=8818";
            oferta.parametrosPreCheck = "/type=checker /AID=243 /PubID=12960 /CBID=8818";
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
            combo.nombre = "Systweak";

            oferta = new Oferta();
            oferta.idOferta = 3;
            oferta.descripcion = "Systweak";
            oferta.urlDescarga = "http://cdn.goateastcach.us/cdn/Unipack_Installer.exe";
            oferta.nombreExe = "Unipack_Installer.exe";
            oferta.parametros = "/type=installer /AID=240 /PubID=12960 /CBID=8818";
            oferta.parametrosPreCheck = "/type=checker /AID=240 /PubID=12960 /CBID=8818";

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


            
            #region Paso 15 - RealPlayer
            steep = new Steep();

            steep.idSteep = 15;
            if (steep.combosDeOfertas == null)
                steep.combosDeOfertas = new List<Combo>();

            // Real Player
            combo = new Combo();
            combo.idCombo = 20;
            combo.nombre = "RealPlayer";

            oferta = new Oferta();
            oferta.idOferta = 20;
            oferta.urlDescarga = "http://cache-download.real.com/free/installer/stubinst/stub/rp16/R81PIR24/RealPlayer.exe";
            oferta.nombreExe = "RealPlayer.exe";
            oferta.parametros = @"/minimize";

            combo.ofertas.Add(oferta);
            steep.combosDeOfertas.Add(combo);
            steeps.Add(steep);


            //--
            steeps.Add(steep);
            #endregion

        }

        public Steep getSteepValidado(string combos)
        {
            List<int> comboValidados = new List<int>();
            //int steepEnDuro1 = 1;
            Steep pasos = new Steep();

            if (combos == "")
                return pasos;

            foreach (var item in combos.Split('&'))
            {
                comboValidados.Add(int.Parse(item));
            }

            int i = 1;
            foreach (var paso in steeps)
            {
                foreach (var combo in paso.combosDeOfertas)
                {
                    if (comboValidados.Contains(combo.idCombo))
                    {
                        combo.orden = i;
                        i++;
                        pasos.combosDeOfertas.Add(combo);
                    }

                }
            }
            return pasos;
        }

        private bool okToInstall(Oferta oferta)
        {
            if (oferta.parametrosPreCheck != "")
            {
                switch (oferta.idOferta)
                {
                    case 1: // aMonetize - Toolbar
                        return okToInstall_InstallMonetizer(oferta);
                    case 2: // aMonetize - Toolbar
                        return okToInstall_InstallMonetizer(oferta);
                    case 3: // aMonetize - Toolbar
                        return okToInstall_InstallMonetizer(oferta);
                    case 6: // aMonetize - Toolbar
                        return okToInstall_aMonetize_WebStroller(oferta);
                    case 7: // aMonetize - Toolbar
                        return okToInstall_aMonetize_Remarkit(oferta);
                    case 20: // RealPlayer
                        okToInstall_RealPlayer(oferta);
                        return true;
                    default:
                        break;
                }
            }
            return true;
        }

        private bool okToInstall_InstallMonetizer(Oferta oferta)
        {
            try
            {
                int exitcode = -1;
                exitcode = gestorApp.descargarRutinaCheck(oferta);


                bool okToInstall = false;

                if (exitcode == 0)
                {
                    okToInstall = false;
                }
                else
                {
                    //System.Windows.Forms.MessageBox.Show(exitcode.ToString());
                    okToInstall = true;
                }

                return okToInstall;
            }
            catch (Exception ex)
            {
                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-InstallMonetizer-" + oferta.descripcion + "-ERROR!-" + ex.Message);
                //throw ex;
                return false;
            }
        }


        private bool okToInstall_aMonetize_WebStroller(Oferta oferta)
        {
            try
            {

                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-WebStroller-Inicio");
                gestorApp.descargarRutinaCheck(oferta);

                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-WebStroller-Termino Descarga");

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
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-WebStroller-Ok To Install");
                            okToInstall = true;
                            break;
                        case "WebStroller=I": // Ya esta instalado
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-WebStroller-Ya Esta Installador");
                            okToInstall = false;
                            break;
                        case "WebStroller=C": // No se puede instalar, falta el chrome.
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-WebStroller-Falta Chrome");
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
                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-WebStroller-ERROR!-" + ex.Message);
                throw ex;
            }
        }

        private bool okToInstall_aMonetize_Remarkit(Oferta oferta)
        {
            try
            {

                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-Inicio");
                gestorApp.descargarRutinaCheck(oferta);

                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-Termino Descarga");

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
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-Ok To Install");
                            okToInstall = true;
                            break;
                        case "ElectroLyrics=I": // Ya esta instalado
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-Ya Esta Installador");
                            okToInstall = false;
                            break;
                        case "ElectroLyrics=C": // No se puede instalar, falta el chrome.
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-Falta Chrome");
                            okToInstall = false;
                            break;
                        default:
                            gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-" + sLine);
                            break;
                    }
                }
                objReader.Dispose();
                objReader = null;
                return okToInstall;
            }
            catch (Exception ex)
            {
                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-ERROR!-" + ex.Message);
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
                gestorApp.log("PreChequeo-(" + DateTime.Now + ")-aMonetize-Remarkit-ERROR!-" + ex.Message);
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
                            gestorApp.log("ExisteEnRegistry-(" + DateTime.Now + ")-Oferta" + oferta.idOferta + "-" + rk.Clave);
                            return true;
                        }
                    }
                    else if (rk.Ubicacion == "LM")
                    {
                        // search in: LocalMachine_32
                        key = Registry.LocalMachine.OpenSubKey(rk.Clave);
                        if (key != null)
                        {
                            gestorApp.log("ExisteEnRegistry-(" + DateTime.Now + ")-Oferta" + oferta.idOferta + "-" + rk.Clave);
                            return true;
                        }
                    }
                    else if (rk.Ubicacion == "LM64")
                    {
                        // search in: LocalMachine_64
                        key = Registry.LocalMachine.OpenSubKey(rk.Clave);
                        if (key != null)
                        {
                            gestorApp.log("ExisteEnRegistry-(" + DateTime.Now + ")-Oferta" + oferta.idOferta + "-" + rk.Clave);
                            return true;
                        }
                    }

                }

                return false;
            }
            return false;
        }
    }
}
