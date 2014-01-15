using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Revizer.Re_Markable
{
    public partial class ucRevizerReMarkable : UserControl
    {
        public ucRevizerReMarkable()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://bettermarkit.net/terms-of-service/");
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://bettermarkit.net/privacy-policy/");
        }
    }
}
