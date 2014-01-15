using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Sterkly.loffinam
{
    public partial class Sterkly__loffinam : UserControl
    {
        public Sterkly__loffinam()
        {
            InitializeComponent();
        }

        private void Sterkly__loffinam_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://loffinam.net/Terms");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://loffinam.net/Privacy");
        }
    }
}
