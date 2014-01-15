using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Downloader205.Formularios.Ofertas.PC_Speed_Up
{
    public partial class ucPCSpeedUp : UserControl
    {
        public ucPCSpeedUp()
        {
            InitializeComponent();
        }

        private void ucPCSpeedUp_Load(object sender, EventArgs e)
        {
        }

        private void llTerminosYCondiciones_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llTerminosYCondiciones.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.pcspeedup.com/terms.aspx");
        }

        private void llPrivacy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llPrivacy.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.pcspeedup.com/privacy.aspx");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
