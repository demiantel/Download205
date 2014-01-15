using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.ElexTech.YAC
{
    public partial class ucElexTechYAC : UserControl
    {
        public ucElexTechYAC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.yac.mx/eula");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.yac.mx/privacy-policy");
        }
    }
}
