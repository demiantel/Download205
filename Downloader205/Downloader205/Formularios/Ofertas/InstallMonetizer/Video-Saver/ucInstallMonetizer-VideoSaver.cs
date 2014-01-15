using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.InstallMonetizer.Video_Saver
{
    public partial class ucInstallMonetizer_VideoSaver : UserControl
    {
        public ucInstallMonetizer_VideoSaver()
        {
            InitializeComponent();
        }

        private void ucInstallMonetizer_VideoSaver_Load(object sender, EventArgs e)
        {

            //llPolicy.Links.Add(0, string.Concat("http://www.conduit.com/privacy/searchprotectprivacypolicy").Length, @"http://www.conduit.com/privacy/searchprotectprivacypolicy");

            richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang11274{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\colortbl ;\red0\green0\blue255;}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang10\f0\fs22 VideoSaver - Terms of Service Agreement\par
Last updated: November 8, 2012\par
Introduction\par
This Terms of Service Agreement (this ""Agreement"") governs your use of this website and the VideoSaver downloadable browser add-on and affiliated applications (the ""Software"") distributed by VideoSaver Ltd. (""Company"", ""we"" or ""us"") and its affiliates. The Software enhances the interaction with various websites by adding features, functionality and content through your browser. The desktop version of the Software is available for download at {\field{\*\fldinst{HYPERLINK ""www.Video-Saver.comm""}}{\fldrslt{\ul\cf1 www.Video-Saver.comm}}}\f0\fs22  and other websites maintained by the Company or its affiliates (the ""Sites"").. The Software, the Sites, and any related features, updates, functionalities, products, services, software, websites, programs, promotions or content provided by the Company or its affiliates shall be referred to collectively as the ""Services"". Use of the Services is governed by the Company's Privacy Policy, currently available at {\field{\*\fldinst{HYPERLINK ""http://www.Video-Saver.com/privacy.html""}}{\fldrslt{\ul\cf1 http://www.Video-Saver.com/privacy.html}}}\f0\fs22  (""Privacy Policy""), and incorporated by reference into this Agreement.\par
BY DOWNLOADING THE SOFTWARE OR USING ANY OF THE SITES OR SERVICES, YOU ACCEPT AND AGREE TO BE BOUND BY THE TERMS AND CONDITIONS OF THIS AGREEMENT, INCLUDING THE PRIVACY POLICY.\par
Acceptance of Terms of Service\par
The terms in this Agreement are conditions upon which the Company shall grant you a limited license to use the Services. The Company may, at any time and without notice, modify the terms in this agreement and/or the Privacy Policy . All material modifications will apply prospectively to the User. By using the Services, you acknowledge that you are of legal age to form a binding contract, and agree to comply with all applicable laws, rules and regulations (""Applicable Law"").\par
Software Features and Advertising\par
{\field{\*\fldinst{HYPERLINK ""http://video-saver.com/terms-of-service/""}}{\fldrslt{ReadMore...\par
}}}}";
        }
    }
}
