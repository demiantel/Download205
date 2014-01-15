using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Downloader205.Formularios.Ofertas.InstallMonetizer.SearchProtect
{
    public partial class ucInstallMonetizer_SearchProtect : UserControl
    {
        public ucInstallMonetizer_SearchProtect()
        {
            InitializeComponent();
        }

        private void ucInstallMonetizer_SearchProtect_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang11274{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang10\f0\fs22 Search Protect by Conduit \endash  EULA Addendum\par
You have elected to download Search Protect by Conduit.\par
Search Protect is a free desktop application that saves your preferred Browser\rquote s home page and default search settings. Search Protect is designed to prevent attempts by other software you download from the Internet to change your preferred Browser settings.\par
Your use of Search Protect by Conduit is governed by the terms and conditions herein, and the terms and conditions of the EULA and Privacy Policy which are incorporated herein by reference.\par
Search Protect may contain certain third-party free/libre/open-source software (""FLOSS"") components which are governed by their respective licenses, not the EULA or this Addendum. A list of FLOSS components and their respective licenses is included in the LICENSE, which is incorporated by reference to this Addendum. By downloading or using Search Protect in any way, you are accepting and agreeing to be bound by all licenses specified in the LICENSE in their entirety.\par
Search Protect may alert you if a third party attempts to change your Browser\rquote s default search or home page settings. You can elect to change your Browser\rquote s search and home page settings at any time by clicking the \ldblquote Settings\rdblquote  link in the Search Protect dialogue box or by going to the Tools/Settings/Options tab on your Browser. Learn More\par
By using this Conduit Software you may enable Conduit to access, use, and collect a variety of information, both personal and non-personal, regarding your Internet Browser and information about your computer (additional information is further detailed in our Privacy Policy. This information is stored with your search query history and IP address. Search Protect also logs all third-party attempts to change your search settings.\par
From time to time, Search Protect may automatically download and install updates from Conduit. These updates are designed to improve, enhance, and further develop the Conduit Software and may take the form of bug fixes, enhanced functions, new software modules, and completely new versions. You agree to receive such updates (and permit Conduit to deliver these to you) as part of your use of the Conduit Software.\par
ReadMore...( http://www.conduit.com/legal/searchprotectdescription/)
}
 ";
        }

        private void llPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited. 
            this.llPolicy.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("IExplore.exe", "http://video-saver.com/privacy-policy/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.conduit.com/legal/searchprotectlearnmore/");
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.conduit.com/legal/searchprotectdescription/");
        }
    }
}
