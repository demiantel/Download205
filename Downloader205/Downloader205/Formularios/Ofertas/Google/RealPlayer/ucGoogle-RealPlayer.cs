using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Google.RealPlayer
{
    public partial class ucGoogle_RealPlayer : UserControl
    {

        public bool checkeado = true;
        public ucGoogle_RealPlayer()
        {
            InitializeComponent();
        }

        private void ucGoogle_RealPlayer_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkeado = checkBox1.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
