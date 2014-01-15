using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.InstallMonetizer.Systweak
{
    public partial class ucInstallMonetizerSystweak : UserControl
    {
        public ucInstallMonetizerSystweak()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.systweak.com/registrycleaner/eula");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.systweak.com/privacypolicy");
        }
    }
}
