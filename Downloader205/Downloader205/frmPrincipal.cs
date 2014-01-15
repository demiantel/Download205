using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Downloader205
{
    public partial class frmPrincipal : Form
    {
        string _codSoft;
        string _combos;
        string nombrePrograma;
        string FileName;
        public bool DescargoSoftOriginal = false;

        private string cadenaThankYou = "";
        //public Oferta ofertaActual;
        GestorDeAplicaciones gestorApp;

        Controller.GestorDeOfertas gestorDeOfertas = new Controller.GestorDeOfertas();


        public Combo comboActual = new Combo();
        public Steep steep = new Steep();
        public frmPrincipal(string codSoft, string combos)
        {
            _codSoft = codSoft;
            _combos = combos;
            InitializeComponent();
        }

        #region comportamiento pantalla
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Cargo la informacion del programa original desde la web.
            gestorApp = GestorDeAplicaciones.CreateInstance();
            _codSoft = gestorApp.getDatosSoftOriginal(_codSoft);
            nombrePrograma = gestorApp.loadNombrePrograma();
            this.Text = nombrePrograma;

            panelPasos.Visible = false;

            string pathCaptura = gestorApp.descargarCapturaSoft();
            if (pathCaptura != null)
                pnlCaptura.BackgroundImage = Image.FromFile(gestorApp.descargarCapturaSoft());
            string pathIcono = gestorApp.descargarIconoSoft();
            if (pathIcono != null)
                pbIcono.BackgroundImage = Image.FromFile(gestorApp.descargarIconoSoft());

            cargarNombreProgarma(null);

            lblCabecera1.Text = "Welcome to the " + nombrePrograma + " setup Wizard";
            lblAppDescript.Text = "Follow the on-Screen instructions outlined in this wizard to install the new version of " + nombrePrograma + " and benefit from all the latest features and updates " + nombrePrograma + " has to offer.";

            if (pathCaptura != null)
            {
                Image img = Image.FromFile(gestorApp.descargarCapturaSoft());
                Bitmap pic = new Bitmap(img);
                for (int w = 0; w < pic.Width; w++)
                {
                    for (int h = 0; h < pic.Height; h++)
                    {
                        Color c = pic.GetPixel(w, h);
                        Color newC = Color.FromArgb(100, c);
                        pic.SetPixel(w, h, newC);
                    }
                }
                this.pictureBox1.Image = pic;
            }
        }

        private void LoadCombo(Combo comboActual)
        {
            cargarNombreProgarma(comboActual.nombre);

            switch (comboActual.idCombo)
            {
                case 1: // Install Monetizer - Toolbar
                    LoadInstallMonetizer_SearchProtect();
                    break;
                case 2: // Install Monetizer - Video Saver
                    LoadInstallMonetizer_VideoSaver();
                    break;
                case 3: // Install Monetizer - Systweak
                    LoadInstallMonetizer_Systweak();
                    break;
                case 4: // Softpublisher - Toolbar
                    LoadSoftPulblisherIminentToolBar();
                    break;
                case 19: // Softpublisher - Toolbar
                    LoadSoftPublisher_ShopingChip();
                    break;
                case 5: // aMonetizer - Toolbar
                    LoadAMonetizer_ReMarkit();
                    break;
                case 9: // Revenyou	- Weather alerts
                    LoadRevenyou_WeatherAlerts();
                    break;
                case 6: // Revenyou	- Great Arcade hits
                    LoadRevenyou_GreatArcadeHits();
                    break;
                case 8: // Revenyou	- Shoping Helper
                    LoadRevenyou_ShoppingHelper();
                    break;
                case 10: // Sterkly - loffinam
                    LoadSterkly_loffinam();
                    break;
                case 12: // Revizer	- Re Markable
                    LoadRevizer_ReMarkable();
                    break;
                case 13: // Adsology - Optimizer_Pro
                    LoadAdsology_Optimizer_Pro();
                    break;
                case 14: // Adsology - Optimizer_Pro
                    LoadElexTechYAC();
                    break;
                case 15: // Adsology - Optimizer_Pro
                    LoadJustDevelopItMyPCBackup();
                    break;
                case 16: // Oneclickbar	Multimedia Toolbar
                    LoadOneclickbarMultimedia_Toolbar();
                    break;
                case 17: // Delapy
                    LoadDealply();
                    break;
                case 18: // PC speed UP
                    LoadPCSpeedUp();
                    break;
                case 20: // Google - RealPlayer
                    LoadGoogle_RealPlayer();
                    break;


                default:
                    break;
            }
            panelPasos.Visible = true;
        }

        private void DescargarSoftOriginal(bool descargarMsi)
        {
            try
            {
                panelPasos.Visible = false;
                pnlCaptura.Visible = false;
                pnlDescarga.Visible = true;
                btnSkipAll.Enabled = false;
                btnCancelar.Enabled = false;
                btnFinish.Visible = true;
                btnFinish.Enabled = false;
                btnDescargar.Visible = false;
                lblNombrePrograma.Text = nombrePrograma;

                WebDownload webClient = new WebDownload();

                if (descargarMsi)
                {
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompletedMsi);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.Proxy = null;
                    FileName = Path.GetTempPath() + gestorApp.softOriginal.codSoftware + ".msi";
                    webClient.DownloadFileAsync(new Uri("http://downloads205.com/bin/_third-party/" + _codSoft + ".msi"), FileName);
                }
                else
                {
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    webClient.Proxy = null;
                    FileName = Path.GetTempPath() + gestorApp.softOriginal.codSoftware + ".exe";
                    webClient.DownloadFileAsync(new Uri("http://downloads205.com/bin/_third-party/" + _codSoft + ".exe"), FileName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BuscarCombo()
        {

            if (steep.ordenAnterior == null)
            {
                foreach (var combo in steep.combosDeOfertas)
                {
                    LoadCombo(combo);
                    comboActual = combo;
                    steep.ordenAnterior = combo.orden;
                    btnAceptar.Visible = false;
                    btnDescargar.Visible = true;

                    return;
                }
            }
            else
            {
                foreach (var combo in steep.combosDeOfertas)
                {
                    if (combo.orden > steep.ordenAnterior)
                    {
                        LoadCombo(combo);
                        comboActual = combo;
                        steep.ordenAnterior = combo.orden;
                        btnAceptar.Visible = false;
                        btnDescargar.Visible = true;

                        return;
                    }
                }
            }
            DescargarSoftOriginal(false);
        }

        // Aceptar
        private void button1_Click(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            btnCancelar.Visible = true;
            btnSkipAll.Visible = true;

            steep = gestorDeOfertas.getSteepValidado(_combos);

            if (steep != null) // Recorro los steeps...
            {
                if (steep.ordenAnterior == null)

                    BuscarCombo();
                return;
            }

            DescargarSoftOriginal(false);
        }

        // Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var oferta in comboActual.ofertas)
            {
                concatenarThankYou(oferta.idOferta.ToString(), "N");
            }
            BuscarCombo();
        }

        private void btnSkipAll_Click(object sender, EventArgs e)
        {
            foreach (var combo in steep.combosDeOfertas)
            {
                if (combo.orden > steep.ordenAnterior)
                {
                    foreach (var oferta in combo.ofertas)
                    {

                        concatenarThankYou(oferta.idOferta.ToString(), "N");
                    }
                }
            }

            //concatenarThankYou("Skip-All", "S");
            DescargarSoftOriginal(false);
        }

        private void llPrivacyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llPrivacyPolicy.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/content/privacy-policy");
        }

        private void llSetupInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llSetupInfo.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/content/Setup-Info");
        }

        private void llWhyItIsFree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llWhyItIsFree.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/content/Why-is-this-free");
        }

        private void llHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llHelp.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/content/Help");
        }

        private void llContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llContactUs.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/content/Contact-Us");
        }
        #endregion

        void cargarNombreProgarma(string nombre)
        {
            if (nombre != "" && nombre != null)
                lblNombrePrograma.Text = nombrePrograma + " - " + nombre;
            else
                lblNombrePrograma.Text = nombrePrograma;
        }


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblProgreso.Text = e.ProgressPercentage.ToString();
            progressBar1.Value = e.ProgressPercentage;
            Console.WriteLine(e.ProgressPercentage.ToString());
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                DescargarSoftOriginal(true);
            }
            else
            {
                System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

                installProcess.StartInfo.FileName = FileName;
                try
                {
                    ThreadPool.QueueUserWorkItem(delegate
                    {
                        try
                        {
                            installProcess.Start();
                            gestorApp.log("Install Soft Original OK");
                        }
                        catch (Exception ex)
                        {
                            gestorApp.log("Install Soft Original-Error:" + ex.Message);
                        }
                    });

                    btnFinish.BringToFront();
                    btnFinish.Visible = true;
                    btnFinish.Enabled = true;

                    DescargoSoftOriginal = true;
                }
                catch (Exception ex)
                {
                    gestorApp.log("Descarga Soft Original-Error:" + ex.Message);
                }
            }
        }

        private void DownloadCompletedMsi(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                gestorApp.log("Error descarga soft original");
            }
            else
            {
                System.Diagnostics.Process installProcess = new System.Diagnostics.Process();

                installProcess.StartInfo.FileName = FileName;
                try
                {
                    ThreadPool.QueueUserWorkItem(delegate
                    {
                        try
                        {
                            installProcess.Start();
                            gestorApp.log("Install Soft Original OK");
                        }
                        catch (Exception ex)
                        {
                            gestorApp.log("Install Soft Original-Error:" + ex.Message);
                        }
                    });

                    btnFinish.BringToFront();
                    btnFinish.Visible = true;
                    btnFinish.Enabled = true;


                    DescargoSoftOriginal = true;
                }
                catch (Exception ex)
                {
                    gestorApp.log("Descarga Soft Original-Error:" + ex.Message);
                }
            }
        }

        #region Inicializacion de User Controls

        #region InstallMonetizer
        private Downloader205.Formularios.Ofertas.InstallMonetizer.Video_Saver.ucInstallMonetizer_VideoSaver ucInstallMonetizer_VideoSaver;
        private void LoadInstallMonetizer_VideoSaver()
        {
            panelPasos.Controls.Clear();

            ucInstallMonetizer_VideoSaver = new Downloader205.Formularios.Ofertas.InstallMonetizer.Video_Saver.ucInstallMonetizer_VideoSaver();
            ucInstallMonetizer_VideoSaver.Dock = DockStyle.Fill;
            ucInstallMonetizer_VideoSaver.Enabled = true;
            ucInstallMonetizer_VideoSaver.Visible = true;
            ucInstallMonetizer_VideoSaver.BringToFront();

            panelPasos.Controls.Add(ucInstallMonetizer_VideoSaver);
        }

        private Downloader205.Formularios.Ofertas.InstallMonetizer.Systweak.ucInstallMonetizerSystweak ucInstallMonetizerSystweak;
        private void LoadInstallMonetizer_Systweak()
        {
            panelPasos.Controls.Clear();

            ucInstallMonetizerSystweak = new Downloader205.Formularios.Ofertas.InstallMonetizer.Systweak.ucInstallMonetizerSystweak();
            ucInstallMonetizerSystweak.Dock = DockStyle.Fill;
            ucInstallMonetizerSystweak.Enabled = true;
            ucInstallMonetizerSystweak.Visible = true;
            ucInstallMonetizerSystweak.BringToFront();

            panelPasos.Controls.Add(ucInstallMonetizerSystweak);
        }

        private Downloader205.Formularios.Ofertas.InstallMonetizer.SearchProtect.ucInstallMonetizer_SearchProtect ucInstallMonetizer_SearchProtect;
        private void LoadInstallMonetizer_SearchProtect()
        {
            panelPasos.Controls.Clear();

            ucInstallMonetizer_SearchProtect = new Downloader205.Formularios.Ofertas.InstallMonetizer.SearchProtect.ucInstallMonetizer_SearchProtect();
            ucInstallMonetizer_SearchProtect.Dock = DockStyle.Fill;
            ucInstallMonetizer_SearchProtect.Enabled = true;
            ucInstallMonetizer_SearchProtect.Visible = true;
            ucInstallMonetizer_SearchProtect.BringToFront();

            panelPasos.Controls.Add(ucInstallMonetizer_SearchProtect);
        }
        #endregion

        private Downloader205.Formularios.Ofertas.PC_Speed_Up.ucPCSpeedUp ucPCSpeedUp;
        private void LoadPCSpeedUp()
        {
            panelPasos.Controls.Clear();

            ucPCSpeedUp = new Downloader205.Formularios.Ofertas.PC_Speed_Up.ucPCSpeedUp();
            ucPCSpeedUp.Dock = DockStyle.Fill;
            ucPCSpeedUp.Enabled = true;
            ucPCSpeedUp.Visible = true;
            ucPCSpeedUp.BringToFront();

            panelPasos.Controls.Add(ucPCSpeedUp);
        }

        #region softPublisher
        private Downloader205.Formularios.Ofertas.Soft_Publisher.Iminent_Toolbar.ucSoftPublisher_IminentToolBar ucSoftPulblisherIminentToolBar;
        private void LoadSoftPulblisherIminentToolBar()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucSoftPulblisherIminentToolBar = new Downloader205.Formularios.Ofertas.Soft_Publisher.Iminent_Toolbar.ucSoftPublisher_IminentToolBar();
            ucSoftPulblisherIminentToolBar.Dock = DockStyle.Fill;
            ucSoftPulblisherIminentToolBar.Enabled = true;
            ucSoftPulblisherIminentToolBar.Visible = true;
            ucSoftPulblisherIminentToolBar.BringToFront();

            panelPasos.Controls.Add(ucSoftPulblisherIminentToolBar);
        }

        private Downloader205.Formularios.Ofertas.Soft_Publisher.Shopping_Chips.ucSoftPublisher_ShoppingChips ucSoftPublisher_ShopingChip;
        private void LoadSoftPublisher_ShopingChip()
        {
            panelPasos.Controls.Clear();

            ucSoftPublisher_ShopingChip = new Downloader205.Formularios.Ofertas.Soft_Publisher.Shopping_Chips.ucSoftPublisher_ShoppingChips();
            ucSoftPublisher_ShopingChip.Dock = DockStyle.Fill;
            ucSoftPublisher_ShopingChip.Enabled = true;
            ucSoftPublisher_ShopingChip.Visible = true;
            ucSoftPublisher_ShopingChip.BringToFront();

            panelPasos.Controls.Add(ucSoftPublisher_ShopingChip);
        }
        private Downloader205.Formularios.Ofertas.Soft_Publisher.Iminent_Toolbar.SoftPublisher_Confirmacion ucConfirmacion;
        private void LoaducConfirmacion()
        {
            pnlConfirmar.Visible = true;
            pnlConfirmar.Controls.Clear();
            pnlConfirmar.BringToFront();

            ucConfirmacion = new Downloader205.Formularios.Ofertas.Soft_Publisher.Iminent_Toolbar.SoftPublisher_Confirmacion();
            ucConfirmacion.Dock = DockStyle.Fill;
            ucConfirmacion.Enabled = true;
            ucConfirmacion.Visible = true;
            ucConfirmacion.BringToFront();

            pnlConfirmar.Controls.Add(ucConfirmacion);
        }


        #endregion

        #region aMomentize
        private Downloader205.Formularios.Ofertas.aMonetize.ReMarkit.ucAMonetizer_ReMarkit ucAMonetizer_ReMarkit;
        private void LoadAMonetizer_ReMarkit()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucAMonetizer_ReMarkit = new Downloader205.Formularios.Ofertas.aMonetize.ReMarkit.ucAMonetizer_ReMarkit();
            ucAMonetizer_ReMarkit.Dock = DockStyle.Fill;
            ucAMonetizer_ReMarkit.Enabled = true;
            ucAMonetizer_ReMarkit.Visible = true;
            ucAMonetizer_ReMarkit.BringToFront();

            panelPasos.Controls.Add(ucAMonetizer_ReMarkit);
        }
        #endregion

        #region Revenyou
        private Downloader205.Formularios.Ofertas.Revenyou.Weather_alerts.ucRevenyou_WeatherAlerts ucRevenyou_WeatherAlerts;
        private void LoadRevenyou_WeatherAlerts()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucRevenyou_WeatherAlerts = new Downloader205.Formularios.Ofertas.Revenyou.Weather_alerts.ucRevenyou_WeatherAlerts();
            ucRevenyou_WeatherAlerts.Dock = DockStyle.Fill;
            ucRevenyou_WeatherAlerts.Enabled = true;
            ucRevenyou_WeatherAlerts.Visible = true;
            ucRevenyou_WeatherAlerts.BringToFront();

            panelPasos.Controls.Add(ucRevenyou_WeatherAlerts);
        }

        private Downloader205.Formularios.Ofertas.Revenyou.Mobogenie.ucRevenyouMobogenie ucRevenyouMobogenie;
        private void LoadRevenyou_Mobogenie()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucRevenyouMobogenie = new Downloader205.Formularios.Ofertas.Revenyou.Mobogenie.ucRevenyouMobogenie();
            ucRevenyouMobogenie.Dock = DockStyle.Fill;
            ucRevenyouMobogenie.Enabled = true;
            ucRevenyouMobogenie.Visible = true;
            ucRevenyouMobogenie.BringToFront();

            panelPasos.Controls.Add(ucRevenyouMobogenie);
        }

        private Downloader205.Formularios.Ofertas.Revenyou.Great_Arcade_Hits.ucRevenyouGreatArcadehits ucRevenyouGreatArcadehits;
        private void LoadRevenyou_GreatArcadeHits()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucRevenyouGreatArcadehits = new Downloader205.Formularios.Ofertas.Revenyou.Great_Arcade_Hits.ucRevenyouGreatArcadehits();
            ucRevenyouGreatArcadehits.Dock = DockStyle.Fill;
            ucRevenyouGreatArcadehits.Enabled = true;
            ucRevenyouGreatArcadehits.Visible = true;
            ucRevenyouGreatArcadehits.BringToFront();

            panelPasos.Controls.Add(ucRevenyouGreatArcadehits);
        }

        private Downloader205.Formularios.Ofertas.Revenyou.ShoppingHelper.ucRevenyouShoppingHelper ucRevenyouShoppingHelper;
        private void LoadRevenyou_ShoppingHelper()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucRevenyouShoppingHelper = new Downloader205.Formularios.Ofertas.Revenyou.ShoppingHelper.ucRevenyouShoppingHelper();
            ucRevenyouShoppingHelper.Dock = DockStyle.Fill;
            ucRevenyouShoppingHelper.Enabled = true;
            ucRevenyouShoppingHelper.Visible = true;
            ucRevenyouShoppingHelper.BringToFront();

            panelPasos.Controls.Add(ucRevenyouShoppingHelper);
        }


        private Downloader205.Formularios.Ofertas.Google.RealPlayer.ucGoogle_RealPlayer ucRealPlayer;
        private void LoadGoogle_RealPlayer()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucRealPlayer = new Downloader205.Formularios.Ofertas.Google.RealPlayer.ucGoogle_RealPlayer();
            ucRealPlayer.Dock = DockStyle.Fill;
            ucRealPlayer.Enabled = true;
            ucRealPlayer.Visible = true;
            ucRealPlayer.BringToFront();

            panelPasos.Controls.Add(ucRealPlayer);
        }

        #endregion

        #region Sterkly	loffinam
        private Downloader205.Formularios.Ofertas.Sterkly.loffinam.Sterkly__loffinam ucSterkly__loffinam;
        private void LoadSterkly_loffinam()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucSterkly__loffinam = new Downloader205.Formularios.Ofertas.Sterkly.loffinam.Sterkly__loffinam();
            ucSterkly__loffinam.Dock = DockStyle.Fill;
            ucSterkly__loffinam.Enabled = true;
            ucSterkly__loffinam.Visible = true;
            ucSterkly__loffinam.BringToFront();

            panelPasos.Controls.Add(ucSterkly__loffinam);
        }
        #endregion

        #region Revizer ReMarkable
        private Downloader205.Formularios.Ofertas.Revizer.Re_Markable.ucRevizerReMarkable ucRevizerReMarkable;
        private void LoadRevizer_ReMarkable()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucRevizerReMarkable = new Downloader205.Formularios.Ofertas.Revizer.Re_Markable.ucRevizerReMarkable();
            ucRevizerReMarkable.Dock = DockStyle.Fill;
            ucRevizerReMarkable.Enabled = true;
            ucRevizerReMarkable.Visible = true;
            ucRevizerReMarkable.BringToFront();

            panelPasos.Controls.Add(ucRevizerReMarkable);
        }
        #endregion

        #region Adsology Optimizer_Pro
        private Downloader205.Formularios.Ofertas.Adsology.Optimizer_Pro.ucAdsologyOptimizerPro ucAdsologyOptimizerPro;
        private void LoadAdsology_Optimizer_Pro()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucAdsologyOptimizerPro = new Downloader205.Formularios.Ofertas.Adsology.Optimizer_Pro.ucAdsologyOptimizerPro();
            ucAdsologyOptimizerPro.Dock = DockStyle.Fill;
            ucAdsologyOptimizerPro.Enabled = true;
            ucAdsologyOptimizerPro.Visible = true;
            ucAdsologyOptimizerPro.BringToFront();

            panelPasos.Controls.Add(ucAdsologyOptimizerPro);
        }
        #endregion

        #region Adsology Optimizer_Pro
        private Downloader205.Formularios.ElexTech.YAC.ucElexTechYAC ucElexTechYAC;
        private void LoadElexTechYAC()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucElexTechYAC = new Downloader205.Formularios.ElexTech.YAC.ucElexTechYAC();
            ucElexTechYAC.Dock = DockStyle.Fill;
            ucElexTechYAC.Enabled = true;
            ucElexTechYAC.Visible = true;
            ucElexTechYAC.BringToFront();

            panelPasos.Controls.Add(ucElexTechYAC);
        }
        #endregion

        #region Just Develop It My PC Backup
        private Downloader205.Formularios.Ofertas.Just_Develop_It.My_PC_Backup.ucJustDevelopItMyPCBackup ucJustDevelopItMyPCBackup;
        private void LoadJustDevelopItMyPCBackup()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucJustDevelopItMyPCBackup = new Downloader205.Formularios.Ofertas.Just_Develop_It.My_PC_Backup.ucJustDevelopItMyPCBackup();
            ucJustDevelopItMyPCBackup.Dock = DockStyle.Fill;
            ucJustDevelopItMyPCBackup.Enabled = true;
            ucJustDevelopItMyPCBackup.Visible = true;
            ucJustDevelopItMyPCBackup.BringToFront();

            panelPasos.Controls.Add(ucJustDevelopItMyPCBackup);
        }
        #endregion

        #region Just Develop It My PC Backup
        private Downloader205.Formularios.Ofertas.Oneclickbar.Multimedia_Toolbar.ucOneclickbar_Multimedia_Toolbar ucOneclickbar_Multimedia_Toolbar;
        private void LoadOneclickbarMultimedia_Toolbar()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucOneclickbar_Multimedia_Toolbar = new Downloader205.Formularios.Ofertas.Oneclickbar.Multimedia_Toolbar.ucOneclickbar_Multimedia_Toolbar();
            ucOneclickbar_Multimedia_Toolbar.Dock = DockStyle.Fill;
            ucOneclickbar_Multimedia_Toolbar.Enabled = true;
            ucOneclickbar_Multimedia_Toolbar.Visible = true;
            ucOneclickbar_Multimedia_Toolbar.BringToFront();

            panelPasos.Controls.Add(ucOneclickbar_Multimedia_Toolbar);
        }
        #endregion


        #region Delapy
        private Downloader205.Formularios.Ofertas.Dealply.Dealply.ucDealply ucDealply;
        private void LoadDealply()
        {
            panelPasos.Controls.Clear();
            panelPasos.BringToFront();

            ucDealply = new Downloader205.Formularios.Ofertas.Dealply.Dealply.ucDealply();
            ucDealply.Dock = DockStyle.Fill;
            ucDealply.Enabled = true;
            ucDealply.Visible = true;
            ucDealply.BringToFront();

            panelPasos.Controls.Add(ucDealply);
        }
        #endregion


        #endregion
        private void pnlConfirmar_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlConfirmar.Visible == false)
                if (ucSoftPulblisherIminentToolBar != null)
                {
                    if (ucSoftPulblisherIminentToolBar.AcumuladorPreguntas < 2)
                    {
                        ucSoftPulblisherIminentToolBar.AcumuladorPreguntas++;
                        LoaducConfirmacion();
                    }
                    else
                    {
                        if (gestorApp.respuestaForm == true)
                            foreach (var oferta in comboActual.ofertas)
                                gestorApp.descargarSoft(oferta);

                        btnAceptar.Enabled = true;
                        // Busco la proxima oferta.
                        BuscarCombo();
                    }
                }

        }

        private void concatenarThankYou(string cadena, string valor)
        {
            if (cadenaThankYou == "")
                cadenaThankYou = "?";
            else
                cadenaThankYou += "&";

            cadenaThankYou += cadena + "=" + valor;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            switch (comboActual.idCombo)
            {
                case 4: // SoftPublisher-Toolbar
                    if (ucSoftPulblisherIminentToolBar.AcumuladorPreguntas < 2)
                    {
                        ucSoftPulblisherIminentToolBar.AcumuladorPreguntas++;
                        LoaducConfirmacion();
                    }
                    else
                    {
                        if (gestorApp.respuestaForm == true)
                            foreach (var oferta in comboActual.ofertas)
                                concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                        else
                            foreach (var oferta in comboActual.ofertas)
                                concatenarThankYou(oferta.idOferta.ToString(), "N");
                    }
                    break;
                case 5: // aMonetize
                    if (ucAMonetizer_ReMarkit.chequeadoReMarkIt && ucAMonetizer_ReMarkit.chequeadoWebStroller)
                    {
                        gestorApp.DescargarCombo(comboActual);

                        foreach (var off in comboActual.ofertas)
                        {
                            concatenarThankYou(off.idOferta.ToString(), "S");
                        }
                    }
                    else
                    {
                        foreach (var oferta in comboActual.ofertas)
                        {
                            if (oferta.idOferta == 7)
                            {
                                if (ucAMonetizer_ReMarkit.chequeadoReMarkIt)
                                    concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                                else
                                    concatenarThankYou(oferta.idOferta.ToString(), "N");
                            }
                            if (oferta.idOferta == 6)
                            {
                                if (ucAMonetizer_ReMarkit.chequeadoWebStroller)
                                    concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                                else
                                    concatenarThankYou(oferta.idOferta.ToString(), "N");
                            }
                        }
                    }
                    break;

                case 9: // Revenyou	- WatherAlers + Mobogine
                    foreach (var oferta in comboActual.ofertas)
                    {
                        if (oferta.idOferta == 8)
                        {
                            if (ucRevenyou_WeatherAlerts.WeatherAlers)
                                concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                            else
                                concatenarThankYou(oferta.idOferta.ToString(), "N");
                        }
                        if (oferta.idOferta == 9)
                        {
                            if (ucRevenyou_WeatherAlerts.Mobogeine)
                                concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                            else
                                concatenarThankYou(oferta.idOferta.ToString(), "N");
                        }
                    }
                    break;
                case 8: // Revenyou	- ShoppingHelper
                    if (ucRevenyouShoppingHelper.chequeado)
                        foreach (var oferta in comboActual.ofertas)
                            concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                    else
                        foreach (var oferta in comboActual.ofertas)
                            concatenarThankYou(oferta.idOferta.ToString(), "N");

                    break;

                case 16: // One Clicbar Multimedia
                    if (ucOneclickbar_Multimedia_Toolbar.InstallAll)
                    {
                        foreach (var oferta in comboActual.ofertas)
                            concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                    }
                    else
                    {
                        if (!ucOneclickbar_Multimedia_Toolbar.InstallHomepage)
                        {
                            foreach (var oferta in comboActual.ofertas)
                            {
                                oferta.parametros = oferta.parametros + " /dsp";
                                concatenarThankYou(oferta.idOferta.ToString(), "N");
                            }
                        }
                        if (!ucOneclickbar_Multimedia_Toolbar.InstallSearch)
                        {
                            foreach (var oferta in comboActual.ofertas)
                            {
                                oferta.parametros = oferta.parametros + " /dse";
                                concatenarThankYou(oferta.idOferta.ToString(), "N");
                            }
                        }
                        if (!ucOneclickbar_Multimedia_Toolbar.InstallTab)
                        {
                            foreach (var oferta in comboActual.ofertas)
                            {
                                oferta.parametros = oferta.parametros + " /dnt";
                                concatenarThankYou(oferta.idOferta.ToString(), "N");
                            }
                        }

                        if (ucOneclickbar_Multimedia_Toolbar.InstallHomepage ||
                            ucOneclickbar_Multimedia_Toolbar.InstallTab ||
                            ucOneclickbar_Multimedia_Toolbar.InstallSearch)
                        {
                            foreach (var oferta in comboActual.ofertas)
                                concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                        }
                    }
                    break;
                default:
                    {
                        foreach (var oferta in comboActual.ofertas)
                            concatenarThankYou(gestorApp.descargarSoft(oferta), "S");
                    }
                    break;
            }

            if (!(comboActual.idCombo == 4 && ucSoftPulblisherIminentToolBar.AcumuladorPreguntas < 2))
                BuscarCombo();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!DescargoSoftOriginal)
                    if (MessageBox.Show(this, "Are you sure you want to exit?...", "Close",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/software/thank-you/uri/" + _codSoft + cadenaThankYou);

                        this.Visible = false;
                        while (gestorApp.CantAppDescargando != 0)
                        {
                            Thread.Sleep(1000);
                        }

                    }
            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                gestorApp.log("WindowsShutDown");

                if (MessageBox.Show(this, "Are you sure you want to exit?...", "Close",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.Visible = false;
                    while (gestorApp.CantAppDescargando != 0)
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://downloads205.com/software/thank-you/uri/" + _codSoft + cadenaThankYou);
            Application.Exit();
        }

    }


    public class Combo
    {
        public int idCombo { get; set; }
        public string nombre { get; set; }
        public List<Oferta> ofertas = new List<Oferta>();
        public int orden { get; set; }
    }

    public class Steep
    {
        public int idSteep { get; set; }
        public List<Combo> combosDeOfertas = new List<Combo>();
        public int? ordenAnterior { get; set; }
    }

    public class Oferta
    {
        public int idOferta { get; set; }
        public string descripcion { get; set; }
        public string urlDescarga { get; set; }
        public string nombreExe { get; set; }
        public string parametros { get; set; }
        public string parametrosPreCheck { get; set; }
        public string parametrosPostCheck { get; set; }
        public List<Registro> registryKey { get; set; } // Usar esto es importante

    }

    public class Registro
    {
        public string Ubicacion { get; set; }
        public string Clave { get; set; }
        public string valor { get; set; }
    }

    public class WebDownload : WebClient
    {
        /// <summary>
        /// Time in milliseconds
        /// </summary>
        public int Timeout { get; set; }

        public WebDownload() : this(0) { }

        public WebDownload(int timeout)
        {
            this.Timeout = Int32.MaxValue;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            if (request != null)
            {
                request.Timeout = this.Timeout;
            }
            return request;
        }
    }

    public class Software
    {
        public string codSoftware { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string capture { get; set; }
        public string nombreExe { get; set; }
    }
}
