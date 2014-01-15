using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Revenyou.ShoppingHelper
{
    public partial class ucRevenyouShoppingHelper : UserControl
    {
        public bool chequeado = true;
        public ucRevenyouShoppingHelper()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chequeado = checkBox1.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.snapdo.com/EULA.aspx?lang=en");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.snapdo.com/Privacy.aspx?lang=en");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
