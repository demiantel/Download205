using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Soft_Publisher.Iminent_Toolbar
{
    public partial class SoftPublisher_Confirmacion : UserControl
    {
        GestorDeAplicaciones gestorApp = GestorDeAplicaciones.CreateInstance();
        public SoftPublisher_Confirmacion()
        {
            InitializeComponent();
        }

        private void SoftPublisher_Confirmacion_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.iminent.com/Corporate/Eula");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.iminent.com/Corporate/Privacy");
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Control pnl = this.ParentForm.Controls.Find("pnlConfirmar", true)[0];
            pnl.Visible = false;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            gestorApp.respuestaForm = true;
            Control pnl = this.ParentForm.Controls.Find("pnlConfirmar", true)[0];
            pnl.Visible = false;
        }

    }
}
