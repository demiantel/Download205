using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Oneclickbar.Multimedia_Toolbar
{
    public partial class ucOneclickbar_Multimedia_Toolbar : UserControl
    {
        public bool InstallAll = true;
        public bool InstallHomepage = true;
        public bool InstallSearch = true;
        public bool InstallTab = true;
        
        public ucOneclickbar_Multimedia_Toolbar()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://myserp.net/privacy.html");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://myserp.net/eula.html ");
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                chkHomepage.Checked = true;
                chkSearch.Checked = true;
                chkTab.Checked = true;
                InstallAll = true;
            }
            else
            {
                //if (sender == chkAll)
                //{
                //    chkHomepage.Checked = false;
                //    chkSearch.Checked = false;
                //    chkTab.Checked = false;
                //}
                InstallAll = false;
            }

        }

        private void chkHomepage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHomepage.Checked)
            {
                if (chkTab.Checked & chkSearch.Checked)
                {
                    InstallAll = true;
                    chkAll.Checked = true;
                }

                InstallHomepage = true;
            }
            else
            {
                InstallAll = false;
                chkAll.Checked = false;
                InstallHomepage = false;
            }

        }

        private void chkSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearch.Checked)
            {
                if (chkTab.Checked & chkHomepage.Checked)
                {
                    InstallAll = true;
                    chkAll.Checked = true;
                }

                InstallSearch = true;
            }
            else
            {
                InstallAll = false;
                chkAll.Checked = false;
                InstallSearch = false;
            }
        }

        private void chkTab_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTab.Checked)
            {
                if (chkSearch.Checked & chkHomepage.Checked)
                {
                    InstallAll = true;
                    chkAll.Checked = true;
                }

                InstallTab = true;
            }
            else
            {
                InstallAll = false;
                chkAll.Checked = false;
                InstallTab = false;
            }
        }
    }
}
