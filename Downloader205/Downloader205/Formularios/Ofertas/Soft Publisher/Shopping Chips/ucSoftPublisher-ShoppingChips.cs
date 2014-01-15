using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Soft_Publisher.Shopping_Chips
{
    public partial class ucSoftPublisher_ShoppingChips : UserControl
    {
        public ucSoftPublisher_ShoppingChips()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://shoppingchip.info/terms.html");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://shoppingchip.info/privacy.html");
        }
    }
}
