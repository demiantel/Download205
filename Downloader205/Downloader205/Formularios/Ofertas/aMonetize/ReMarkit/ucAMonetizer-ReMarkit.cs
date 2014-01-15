using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.aMonetize.ReMarkit
{
    public partial class ucAMonetizer_ReMarkit : UserControl
    {
        public bool chequeadoReMarkIt = true;
        public bool chequeadoWebStroller = true;

        public ucAMonetizer_ReMarkit()
        {
            InitializeComponent();
        }

        private void ucAMonetizer_ReMarkit_Load(object sender, EventArgs e)
        {
            llTerms.Links.Add(0, string.Concat("http://re-markit.co/terms-of-service").Length, @"http://re-markit.co/terms-of-service");
            llPrivacy.Links.Add(0, string.Concat("http://re-markit.co/privacy-policy").Length, @"http://re-markit.co/privacy-policy");
        }

        private void lblMarkitTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://re-markit.co/terms-of-service");
        }

        private void lblPrivacy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://re-markit.co/privacy-policy");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://webstroller.net/legal/");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chequeadoReMarkIt = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            chequeadoWebStroller = checkBox2.Checked;
        }
    }
}
