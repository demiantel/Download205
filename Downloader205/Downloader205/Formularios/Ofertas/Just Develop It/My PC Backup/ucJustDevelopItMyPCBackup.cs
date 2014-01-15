using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Just_Develop_It.My_PC_Backup
{
    public partial class ucJustDevelopItMyPCBackup : UserControl
    {
        public ucJustDevelopItMyPCBackup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.mypcbackup.com/terms#termsdiv");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.mypcbackup.com/terms#privacy");
        }

        private void ucJustDevelopItMyPCBackup_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang11274{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\colortbl ;\red102\green102\blue102;}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\cf1\lang10\f0\fs22 MyPCBackup EULA - End User Licence Agreement\par
\par
IMPORTANT-READ CAREFULLY: This MyPCBackup (\ldblquote MyPCBackup\rdblquote ) License Agreement (""License"" or \ldblquote Agreement\rdblquote ) is a legal agreement between You (either an individual or an entity, who will be referred to in this License as ""You"" or \ldblquote Your\rdblquote ) and MyPCBackup for the use of desktop, laptop, and mobile device software applications, and which may include associated media, printed materials, and other components and software modules including but not limited to drivers (""Product""). The Product also includes any software updates and upgrades that MyPCBackup may provide to You or make available to You, or that You obtain after the date You obtain Your initial copy of the Product, to the extent that such items are not accompanied by a separate license agreement or terms of use. BY INSTALLING, COPYING, DOWNLOADING, ACCESSING OR OTHERWISE USING THE PRODUCT, YOU AGREE TO BE BOUND BY THE TERMS OF THIS MyPCBackupLICENSE AGREEMENT. IF YOU DO NOT AGREE TO THE TERMS OF THIS AGREEMENT YOU HAVE NO RIGHTS TO THE PRODUCT AND SHOULD NOT INSTALL, COPY, DOWNLOAD, ACCESS OR USE THE PRODUCT.\par
\par
The Product is protected by copyright laws as well as other intellectual property laws. The Product is licensed and not sold.\par
\par
1. GRANT OF LICENSE. MyPCBackup grants You a non-exclusive, nontransferable license to install and use the Product subject to all the terms and conditions set forth here within.\par
\par
1.1. Single-Use Perpetual License. You may permit a single authorized end user to install the Product on a single computer for use by that end user only. Remote access is not permitted without the express written consent of MyPCBackup.\par
\par
1.2. Single-Use Term License. Same usage terms as the Single-Use Perpetual License except that the term of the license is limited to a fixed duration upon expiration of which the Product must be de-installed from the computer unless the license is renewed for an additional period of time.\par
\par
1.3. You may ask MyPCBackup for permission to have business or reseller use and distribution of MyPCBackup software and control panel. You may get written permission after emailing support@MyPCBackup.com\par
\par
After You receive written permission from MyPCBackup in an e-mail or letter, then 1.1 and 1.2 above do not apply.\par
\par
2. ADDITIONAL LIMITATIONS. You may not reverse engineer, decompile, or disassemble the Product, except and only to the extent that it is expressly permitted by applicable law notwithstanding this limitation. You may not rent, lease, lend or transfer the Product, or host the Product for third parties. The Product is licensed as a single integral product; its component parts may not be separated for use on more than one computer. The Product may include copy protection technology to prevent the unauthorized copying of the Product or may require original media for use of the Product on the computer. It is illegal to make unauthorized copies of the Product or to circumvent any copy protection technology included in the Product. The software may not be resold either by You or a third party customer without the prior written permission of MyPCBackup. All rights not expressly granted to You are retained by MyPCBackup.\par
\par
2.1. Third Party Software. The Product may contain third party software that MyPCBackup can grant sublicense to use and which is also protected by copyright law and other applicable laws.\par
\par
3. SUPPORT AND MAINTENANCE TERMS AND CONDITIONS.\par
\par
3.1. Term of Maintenance. MyPCBackup agrees to provide Maintenance (as defined herein) to You pursuant to the terms and conditions set forth herein provided that You pay the Maintenance Fee for each Product for which Maintenance is desired and as further described in Section 3.4 below. Maintenance will be provided for a period of one year, unless otherwise agreed to by the parties in writing, from the date of purchase of the Product (the \ldblquote Initial Support and Maintenance Term\rdblquote ), and with renewals, annually from the expiration date of the prior Support and Maintenance Term. Failure to renew annual maintenance may result in You having to purchase a new license in order to receive future versions of software and associated ongoing support and maintenance.\par
\par
3.2. Maintenance Services. In exchange for the Maintenance Fee, MyPCBackup agrees to provide to You during the term of this Agreement support and maintenance (collectively ""Maintenance"") as follows:\par
\par
3.2.1. Support: MyPCBackup will provide email and telephone support to You for current versions of the Product. MyPCBackup will investigate all of Your questions and problems promptly. You agree to provide adequate information to MyPCBackup to assist in the investigation and to confirm that any problems have been resolved. MyPCBackup does not provide guaranteed response time but will make good faith effort to answer emails and voice mails within twenty-four (24) hours or less during weekdays, excluding holidays.\par
\par
3.2.2. Maintenance: MyPCBackup will supply to You, at no additional charge, any improvements, upgrades, or modifications to the Product that MyPCBackup makes generally available. Any such improvements, upgrades, or modifications shall become part of the Product for all purposes of this Agreement.\par
\par
3.2.3. You acknowledge and agree that the Maintenance to be provided by MyPCBackup Ltd hereunder is limited to the most current version of the Product and the immediately preceding version.\par
\par
3.3. Exclusions. MyPCBackup\rquote  obligation to provide Support is contingent upon proper use of the Product and full compliance with this Agreement. Moreover, MyPCBackup shall be under no obligation to provide Support should such services be required due to (a) failure to operate the Product within the systems requirements provided for the Product (b) any modification or attempted modification of the Product by You or any third party or (C) Your failure or refusal to implement Product changes recommended by MyPCBackup.\par
\par
3.4. Consideration. In payment of the Maintenance services to be provided by MyPCBackup hereunder, You shall pay MyPCBackup, or its authorized agent, the applicable fee for the Initial Support and Maintenance Term as indicated on the related invoice, receipt, purchase order, or other ordering document (""Maintenance Fee""). At the end of the Initial Support and Maintenance Term, or any subsequent Support and Maintenance Term, You may renew participation in Maintenance services for additional annual term(s) provided You (a) are current on all payments due to MyPCBackup and (b) pay MyPCBackup Ltd, or its authorized agent, the applicable renewal fee, which MyPCBackup, or its authorized agent, shall invoice prior to the end of the preceding term, unless terminated by You at least 30 days prior to the expiration of the then current Support and Maintenance Term. The Maintenance Fee for renewal shall be equal to the Maintenance Fee for the immediate preceding annual term plus an increase by a percentage not to exceed the Consumer Price Index (CPI), as published by the U.S. Department of Labor. In addition, Maintenance shall be discontinued for any and all subsequent Support and Maintenance Terms for which You fail to pay MyPCBackup the invoice within ten (10) days after the prior Maintenance expiration date.\par
\par
3.5. Exceptions. For use of the free MyPCBackup software trial only the Maintenance Services and Exclusions paragraphs of this section apply.\par
\par
4. PAYMENT TERMS. Unless explicitly set forth in this Agreement, all fees and other amounts due under this Agreement are non-cancellable and non-refundable. Unless otherwise agreed to by the parties, You shall pay all fees or amounts within 30 days of the date of the invoice. A late fee shall be charged on any overdue amounts and any other fees and expenses not paid as provided under this Agreement at the rate of one and one-half percent (1\'bd%) per month, or the highest rate allowable under applicable law, whichever is less, commencing with the date payment was due.\par
\par
5. TAXES. The fees and all other amounts due as set forth in this Agreement are net amounts to be received by MyPCBackup, exclusive of all taxes, duties, and assessments, including without limitation all sales, withholding, VAT, excise, ad valorem, and use taxes (collectively, the \ldblquote Taxes\rdblquote ), and are not subject to offset or reduction because of any Taxes incurred by You or otherwise due as a result of this Agreement. You shall be responsible for and shall pay directly, any and all Taxes relating to the performance of this Agreement, provided that this paragraph shall not apply to taxes based solely on MyPCBackup\rquote  income.\par
\par
6. CONSENT TO USE OF DATA. If MyPCBackup provides any support services to You, You agree that MyPCBackup and its affiliates may collect and use all information You provide as a part of any such support services related to the Product. MyPCBackup agrees not to use this information in a form that personally identifies You.\par
\par
7. INTELLECTUAL PROPERTY RIGHTS. Subject to the license grant hereunder, all right, title and interest in and to the Product, the accompanying printed materials, and any copies of the Product are owned by MyPCBackup and its licensors.\par
\par
8. EXPORT RESTRICTIONS. You acknowledge that Product is of UK. origin. You agree to comply with all applicable UK, foreign, and local laws and regulations governing Your use of the Product.\par
\par
9. WARRANTY\par
\par
9.1. Warranty. MyPCBackup warrants that for a period of 90 days from the date of delivery (\ldblquote Warranty Period\rdblquote ), under normal use, the Product will perform substantially in conformance with the specifications published in the Documentation. During such period, and as the sole obligation of MyPCBackup and Your sole remedy under the warranty in this Section, if You provide written notice of MyPCBackup\rquote s failure to comply with the above warranty, MyPCBackup will use reasonable commercial efforts to correct such nonconformity in the Product as in accordance with the terms of the Maintenance and Support Policy. In addition, if MyPCBackup determines it is not commercially reasonable to correct the nonconformity, MyPCBackup may elect to terminate the license to such Product, upon which termination Licensee will promptly return to MyPCBackup all such copies of such Product. Upon receipt of the Product from Licensee, MyPCBackup will return to Licensee all license fees (and any unused support fees) paid to MyPCBackup by You for such Product. This warranty set forth above does not apply to, and MyPCBackup shall have no obligation with respect to, any non-conformity arising as a result of (i) use of the Product other than as specified under this Agreement and the related Documentation; (ii) any modification or alteration of the Product performed other than by MyPCBackup or its agents, or (iii) transfer of the Product to any computer system other than the ones on which Product is authorized to be stalled, except as permitted in this Agreement.\par
\par
9.2. Disclaimer. Other than the warranty set forth in Section 9.1 above, and to the maximum extent permitted by applicable law, MyPCBackup, its authorized resellers and their subsidiaries provides the Product and any support services related to the Product (""Support Services"") AS IS AND WITH ALL FAULTS, and hereby disclaim all other warranties and conditions, either express, implied or statutory, including, but not limited to, any implied warranties, duties or conditions of merchantability, of fitness for a particular purpose, of accuracy or completeness of responses, of results, of workmanlike effort, of lack of viruses, and of lack of negligence, all with regard to the Product, and the provision of or failure to provide support services.\par
\par
10. LIMIT OF LIABILITY AND EXCLUSION OF INCIDENTAL, CONSEQUENTIAL AND CERTAIN OTHER DAMAGES. TO THE MAXIMUM EXTENT PERMITTED BY APPLICABLE LAW, IN NO EVENT SHALL MyPCBackup, ITS AUTHORIZED RESELLERS OR THEIR SUBSIDIARIES BE LIABLE FOR ANY SPECIAL, INCIDENTAL, INDIRECT, PUNITIVE OR CONSEQUENTIAL DAMAGES WHATSOEVER (INCLUDING, BUT NOT LIMITED TO, DAMAGES FOR LOSS OF PROFITS OR CONFIDENTIAL OR OTHER INFORMATION, FOR BUSINESS INTERRUPTION, FOR PERSONAL INJURY, FOR LOSS OF PRIVACY, FOR FAILURE TO MEET ANY DUTY INCLUDING OF GOOD FAITH OR OF REASONABLE CARE, FOR NEGLIGENCE, AND FOR ANY OTHER PECUNIARY OR OTHER LOSS WHATSOEVER) ARISING OUT OF OR IN ANY WAY RELATED TO THE USE OF OR INABILITY TO USE THE PRODUCT, THE PROVISION OF OR FAILURE TO PROVIDE SUPPORT SERVICES, OR OTHERWISE UNDER OR IN CONNECTION WITH ANY PROVISION OF THIS LICENSE, EVEN IN THE EVENT OF THE FAULT, TORT (INCLUDING NEGLIGENCE), STRICT LIABILITY, BREACH OF CONTRACT OR BREACH OF WARRANTY OF MyPCBackup, EVEN IF MyPCBackup HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.\par
\par
10.1. LIMITATION OF LIABILITY AND REMEDIES. Notwithstanding any damages that You might incur for any reason whatsoever (including, without limitation, all damages referenced above and all direct or general damages), the entire liability of MyPCBackup, its resellers and their subsidiaries under any provision of this License and Your exclusive remedy for all of the foregoing shall be limited to the amount actually paid by You for the Product. The foregoing limitations, exclusions and disclaimers shall apply to the maximum extent permitted by applicable law, even if any remedy fails its essential purpose.\par
\par
10.2. NOTICE TO U.S. GOVERNMENT END USERS\par
\par
10.3. For contracts with agencies of the Department of Defense, the Government\rquote s rights in: (1) commercial computer software and commercial computer software documentation shall be governed, pursuant to 48 C.F.R. 227.7201 through 227.7202-4, by MyPCBackup\rquote  standard commercial license(s) for the respective product(s); (2) software and software documentation other than commercial computer software and commercial computer software documentation shall be governed by 48 C.F.R. 252.227-7014; (3) technical data for commercial items other than software or software documentation shall be governed by 48 C.F.R. 252.227-7015(b); and (4) technical data for non-commercial items other than software or software documentation shall be governed by 48 C.F.R. 252.227-7013.\par
\par
10.4. For contracts with U.S. Government agencies other than the Department of Defense agencies, the Government\rquote s rights in: (1) commercial computer software and commercial computer software documentation shall be governed, pursuant to 48 C.F.R. 2.101 and 12.212, by MyPCBackup\rquote  standard commercial license(s) for the respective product(s); (2) software and software documentation other than commercial computer software and commercial computer software documentation shall be governed by 48 C.F.R. 52.227-14, Alternative III; and (3) technical data other than software and software documentation shall be governed by 48 C.F.R. 52.227-14 including, where applicable Alternatives I or II.\par
\par
11. GENERAL. This Agreement will be governed by and construed in accordance with the laws of the State of California excluding that body of laws known as conflicts of law. The United Nations Convention on Contracts for the International Sale of Goods will not apply. Any legal action or proceeding arising under this Agreement will be brought exclusively in the federal or state courts located in San Jose, California and the parties hereby irrevocably consent to the personal jurisdiction and venue therein. You may not assign this Agreement or any right or interest hereunder, by operation of law or otherwise, without MyPCBackup\rquote  express prior written consent. Any attempt to assign this Agreement, without such consent, will be null and of no effect. Subject to the foregoing, this Agreement will bind and inure to the benefit of each party's successors and permitted assigns. Except as expressly set forth in this Agreement, the exercise by either party of any of its remedies under this Agreement will be without prejudice to its other remedies under this Agreement or otherwise. If for any reason a court of competent jurisdiction finds any provision of this Agreement invalid or unenforceable, that provision of the Agreement will be enforced to the maximum extent permissible and the other provisions of this Agreement will remain in full force and effect. All notices or approvals required or permitted under this Agreement will be in writing and delivered by confirmed facsimile transmission, by overnight delivery services, or by certified mail, and in each instance will be deemed given upon receipt. All notices or approvals will be sent to the addresses set forth in the applicable ordering document or invoice or to such other address as may be specified by either party to the other in accordance with this Section. Neither party will be responsible for any failure or delay in its performance under this Agreement (except for any payment obligations) due to causes beyond its reasonable control, including, but not limited to, labor disputes, strikes, lockouts, shortages of or inability to obtain labor, energy or supplies, war, terrorism, riot, or acts of God. The failure by either party to enforce any provision of this Agreement will not constitute a waiver of future enforcement of that or any other provision. This Agreement, including MyPCBackup\rquote  support and maintenance services terms constitutes the entire and exclusive agreement between the parties concerning its subject matter and supersedes all prior written and oral understandings and agreements between the parties regarding its subject matter. The terms and conditions contained in any customer purchase order or other ordering document that are inconsistent with or in addition to the terms and conditions of this Agreement are hereby rejected by MyPCBackup and will be deemed null and of no effect.\par
\par
12. COMPLIANCE WITH LICENSES. If You are a business, company or organization, You agree that upon request from MyPCBackup or its authorized representative You will within thirty (30) days fully document and certify that use of any and all MyPCBackup Products at the time of the request is in conformity with Your valid licenses from MyPCBackup.\par
\par
13. Should You have any questions concerning this License, or if You desire to contact MyPCBackup for any reason, please email support@MyPCBackup.com\par
\par
14. Please note. Should your Operating system not allow .NET framework products to be installed and run, we will install the necessary software to do so. This will take place before the completion of the MyPCBackup Install.\par
}";
        }
    }
}
