using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Downloader205.Formularios.Ofertas.Revenyou.Weather_alerts
{
    public partial class ucRevenyou_WeatherAlerts : UserControl
    {
        public bool WeatherAlers = true;
        public bool Mobogeine = true;
        public ucRevenyou_WeatherAlerts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://desktopweatheralerts.com/terms-of-use/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://desktopweatheralerts.com/privacy-policy/");
        }

        private void ucRevenyou_WeatherAlerts_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang11274{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\colortbl ;\red0\green0\blue255;}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang10\f0\fs22 Terms of Use\par
\par
Weather Alerts Terms of Use\par
\par
Updated: October 20th 2013\par
\par
This website (and any and all sub-domains) (the \ldblquote Site\rdblquote ) and any and all services (\ldblquote Services\rdblquote ) and software (\ldblquote Software\rdblquote ) provided through the Site is owned and operated by Local Weather LLC, its parent and subsidiaries (collectively, \ldblquote Local Weather\rdblquote ). For the purposes hereof, the users of the Site, Software and Services are referred to as \ldblquote you\rdblquote , \ldblquote your\rdblquote  or \ldblquote User\rdblquote  and Local Weather is referred to as the \ldblquote Company\rdblquote , \ldblquote we\rdblquote , \ldblquote us\rdblquote  or \ldblquote our\rdblquote . The following is a legally binding agreement between you and the Company with respect your access and use of the Site, the Software and the Services. For good and valuable consideration (the adequacy and sufficiency of which is acknowledged by each of the parties) of the mutual promises of the parties contained herein, the parties hereby agree as set forth below. All Users will be subject to and bound by these Terms of Use (\ldblquote Agreement\rdblquote  or \ldblquote Terms of Use\rdblquote ).\par
\par
Acceptance of Terms\par
\par
BY ACCESSING AND/OR USING THE SITE AND ANY OF THE SERVICES AND/OR DOWNLOADING THE SOFTWARE, YOU BECOME A USER OF THE SITE, THE SOFTWARE AND THE SERVICES AND EXPRESSLY ACKNOWLEDGE THAT YOU HAVE READ, UNDERSTOOD, ACCEPT AND AGREE TO EACH OF THE TERMS AND CONDITIONS SET FORTH BELOW. IF YOU DO NOT AGREE TO ACCEPT EACH AND ALL OF THE FOLLOWING TERMS AND CONDITIONS AS SET FORTH BELOW, PLEASE DO NOT ACCESS OR USE THE SITE, THE SOFTWARE OR ANY OF THE SERVICES.\par
\par
Eligibility\par
\par
You must be at least 18 years old to use the Site, the Software and the Services. By using the Site, the Software, or the Services, you represent and warrant that you are at least 18 years of age. If you are not 18 years of age or older, please do not access or use the Site, the Software or the Services.\par
\par
Special Notice for Non-English Speakers:\par
\par
The Weather Alerts Software is suited primarily for the use of English speakers and, therefore, this Agreement is written in English and is addressed to English speakers. If you are not proficient in English and feel that you cannot properly understand this Agreement, we recommend that you either retain the help of an English speaker to help you understand and accept the terms of this Agreement or, alternatively, refrain from installing or using the Local Weather Software. In any event, if you choose to install or Use the Local Weather Software, you will be bound by this Agreement and the Privacy Policy incorporated herein.\par
\par
Special Notice for Residents of the State of Alaska, USA:\par
\par
The Local Weather Software may be prohibited by Alaska law. Therefore, by installing or Using the Local Weather Software, you represent and warrant that your computer is not located in the state of Alaska. To the extent that our systems are able to recognize that your computer is located in the state of Alaska, we will not enable you to install the Local Weather Software.\par
\par
Privacy\par
\par
Prior to providing any personal information to us about you on the Site or in connection with the Software or the Services, please review our Privacy Policy (as amended and supplemented from time to time) located at {\field{\*\fldinst{HYPERLINK ""http://desktopweatheralerts.com/privacy-policy/""}}{\fldrslt{\ul\cf1 http://desktopweatheralerts.com/privacy-policy/}}}\f0\fs22  You agree and warrant that any and all of your personal information provided to us is true and correct, including, but not limited to, your name, physical or electronic mailing address, phone number, fax number and other information requested (and you agree to update the same). You understand that all personal information provided by you to us will be subject to the terms and conditions of our Privacy Policy. You acknowledge and agree that we may disclose information you provide if required to do so by any applicable law, or if we, in our sole and absolute discretion, believe that disclosure is reasonable or necessary to (1) comply with any applicable law, requests or orders from law enforcement, or any legal process (whether or not such disclosure is affirmatively required by applicable law); or (2) protect or defend the rights or property of the Company or any third party.\par
\par
Purchase of Ad Free Version of Software\par
\par
You may purchase an ad free version of the software for a fee if it is offered on the Company Site.  No refunds will be given once you have purchased the ad free version. If we are unable to charge your credit card or your payment cannot be processed for any reason, your Payment will be cancelled and we will not provide you an ad free version of the Software. You are responsible for paying any and all applicable taxes (including, without limitation, sales tax, services tax, use tax and value-added tax), duties, levies, charges and excises imposed by any government agency or entity, except for those taxes that may be based on the income of Company. The Company shall have no obligation, responsibility or liability with respect to your aforementioned responsibilities or liabilities to any government agencies or entities. Notice: No United Kingdom residents may purchase an ad free version of the Software.\par
\par
Trials and Promotions\par
\par
From time to time, the Company may offer certain trials or promotions to Users or new users. We reserve the right to, in our sole and absolute discretion, to at any time (without any liability thereof) discontinue, modify, suspend, reorganize or terminate any such trials and promotions. Any trial or promotion will be subject to the terms and conditions of such trial or promotion, but in no event whatsoever shall any trial or promotion modify or change any of the terms and conditions of these Terms of Use (except as is expressly set forth by us in the trial or promotion).\par
\par
Site Information\par
\par
The Company does not represent or endorse the accuracy or reliability of, and specifically and expressly disclaims any and all liability related to (whether directly or indirectly), any information displayed, uploaded, posted on the Site, or otherwise distributed or transmitted through the Site by any person or entity. Moreover, the Company in its sole and absolute discretion reserves the right to refuse to post, host or display, and the right to remove or delete, any information from this Site, in whole or in part, for any reason (or no reason) at any time without any notice thereof to you or any other person or entity. Any comments, feedback or advice that you provide to us at, through, in connection with or relating to this Site shall be deemed to be non-confidential and we (and our affiliates) shall have an unrestricted and absolute right to post and publish the same (in our sole and absolute discretion) for any purpose whatsoever.\par
\par
Your Conduct, Behavior and Duties\par
\par
You represent, warrant and agree that you will not, directly or indirectly: (a) falsify or misrepresent any information regarding your identity or intentions with respect to any matter in connection with the Site, the Software or the Services; (b) post, publish, transmit, distribute, or upload any information or materials through the Site, the Software or the Services that is unlawful, obscene, lewd, sexually explicit, derogatory, abusive, threatening, discriminatory with respect to race, religion or gender, or is otherwise reasonably disagreeable, offensive or objectionable; (c) post, publish, transmit, distribute, or upload any information or materials through the Site, the Software or the Services that contains a virus, or any other harmful software code or programming routine, that could impair operation or function of the Site, the Software or the Services or access of others who may, do or will access or use the Site, the Software or the Services; (d) post, publish, transmit, distribute, offer or upload any information or materials through the Site, the Software or the Services that is (in whole or part) unlawful, false, deceptive, misleading, fraudulent, or otherwise reasonably disagreeable, offensive or objectionable, including (without limitation) any information, document, communication or transmission that constitutes, affirms, encourages or supports the commission of any illegal activity or any violation of any local, state, national or applicable foreign law, rule or regulation, including (without limitation) any laws that protect the intellectual property, personal or privacy rights of any person or entity; (e) post, publish, transmit, distribute, or upload any information, content, documents or materials through or in connection with the Site, the Software or the Services that in any way violates any patent, copyright, trademark or any other proprietary intellectual property rights of others; (f) post, publish, transmit, distribute, or upload any information, documents, content or materials through or in connection with the Site, the Software or the Services that violates any legal, property, intangible, confidentiality or privacy rights of others; and (g) post, publish, transmit, distribute, or upload through or in connection with the Site, the Software or the Services any bulk e-mail solicitations, chain letters, solicitations, advertisements, pyramid schemes or any other unsolicited communication, including, without limitation, spamming those who access, browse or use the Site, the Software or the Services.\par
\par
You are prohibited from violating or attempting to violate the security of the Site, the Software or the Services, or any third party network, system, server, or account, including, without limitation, engaging in any of the following activities: (a) accessing data, folders, information, content, materials, servers, accounts, databases, etc. which you are not authorized to access, (b) impersonating our personnel (or any other person or entity) or engaging in any other pre-texting, (c) attempting to (i) probe, scan or test the vulnerability of a system, server, account or network, or (ii) breach security, validation or authentication measures of any of the foregoing, (d) attempting to interfere with, disrupt or disable service or access or use of the Site, the Software or the Services to or for any user, host, server, account or network, including, without limitation, via means of overloading, \ldblquote flooding,\rdblquote  \ldblquote mailbombing,\rdblquote  \ldblquote denial of service\rdblquote  attacks, or \ldblquote crashing\rdblquote , (e) forging any TCP/IP packet header or any part of the header information in any e-mail or posting, (f) taking any action in order to obtain services to which you are not entitled, or (g) attempting to utilize another party\rquote s account name or persona without first obtaining authorization from that party. You are also prohibited from attempting any action designed to circumvent or alter any method of measuring or billing for the Site or the Services for any User. Violations of these policies and the Site\rquote s, the Software\rquote s and the Services or security may result in civil or criminal liability for the offending party.\par
\par
Additional Representations and Warranties\par
\par
You hereby represent, warrant and agree that: (a) you have full capacity, right and authority to accept these Terms of Use; (b) your use of the Site, the Software or the Services will not, directly or indirectly, infringe (in whole or in part) any intellectual property rights, including, but not limited to, patent, copyright, trademark, trade secret, mask work or other intellectual property rights, personal or privacy rights of any third party or the Company; (c) your use of the Site, the Software and the Services will in all manners and respects comply with any and all applicable laws, rules and regulations; (d) your use of the Site, the Software and the Services will not in any manner, directly or indirectly, disparage, defame, discredit or harm Company or its reputation or goodwill; (e) your acceptance of these Terms of Use and/or use of the Site, the Software and the Services hereunder does not breach any of your obligations to any third party, breach any contract or agreement or violate any applicable rule, law or regulation; and (f) your acceptance of these Terms of Use and use of the Site, the Software and the Services is for a bona fide purpose and you are not using the Site, the Software or the Services to resell any Services or distribute or otherwise use the Software or Services for an improper, illegal or unethical purpose.\par
\par
Legal Compliance\par
\par
You agree to comply, at your sole and own expense, with any and all applicable laws, ordinances, regulations and codes, including (without limitation) the identification and procurement of required permits, certificates, licenses, insurance, approvals and inspections, needed as a result of or in connection with these Terms of Use. You will immediately report to us any and all suspected or actual violations of these Terms of Use by others that you are aware of (or should be aware of, based upon the circumstances).\par
\par
Regulatory Compliance\par
\par
Company may be subject to regulation by agencies of the government of United States of America and/or foreign governments, including, but not limited to, the United States Department of Commerce, which prohibit export or diversion of certain technical products to certain countries. Your present and warrant that you will comply in all respects with the applicable rules and regulations of any and all agencies of the governments of the United States of America and foreign governments that are applicable to your use of the Site, the Software and the Services; provided, that in the event or instance of any conflict or ambiguity between the applicable rules and regulations of agencies of the United States of America and those of any foreign government, the former (i.e. of the U.S.A.) shall be given priority and precedence.\par
\par
Disclaimer of Legal Compliance\par
\par
YOU EXPRESSLY UNDERSTAND AND ACKNOWLEDGE THAT THE SITE, THE SOFTWARE AND SERVICES MAY NOT CONFORM TO, OR MEET WITH, ANY OR ALL APPLICABLE REQUIREMENTS OF SSAE 16, PAYMENT CARD INDUSTRY (PCI) STANDARDS (AS AMENDED), THE SARBANES-OXLEY ACT OF 2002 (AS AMENDED), THE HEALTH INSURANCE PORTABILITY AND ACCOUNTABILITY ACT (HIPAA) (AS AMENDED), THE GRAMM-LEACH-BILEY ACT (AS AMENDED) AND OTHER LAWS, RULES AND REGULATIONS. THE COMPANY MAKES NO REPRESENTATIONS OR WARRANTIES WITH RESPECT TO THE SITE, THE SOFTWARE AND THE SERVICES AND THEIR COMPLIANCE WITH THE AFOREMENTIONED LAWS OR ANY OTHER LAWS, RULES OR REGULATIONS.\par
\par
Proprietary Information\par
\par
All Company information, materials, content, images, graphics, software, trademarks, logos, service marks provided on or through the Site, the Software or the Services (collectively the \ldblquote Proprietary Information\rdblquote ) is and are the sole and exclusive property of the Company or are duly licensed by the Company, and may not be used, copied, reproduced, distributed, republished, uploaded, downloaded, displayed, posted or transmitted in any form or by any means without the prior express written consent of the Company. The Proprietary Information, including (without limitation) all HTML code, server-side code, XML code, and compilations of meta tag key words, specification and trade name data, newsletters and publications, press materials, product and service descriptions, testimonials and all similar data and information, is exclusively owned or duly licensed by the Company, and is and shall, to the maximum extent allowed by applicable law, be protected by copyright and trademark laws and international treaty provisions. To the extent that the Proprietary Information is also covered by copyright law (and you are hereby advised that much or all of the Proprietary Information is copyrighted), violators are given notice that any such violations may result in severe civil and criminal penalties. Violators of this paragraph will be prosecuted to the maximum extent possible. Users of the Site, the Software and the Services shall have no right to the Proprietary Information. COPYING OR REPRODUCTION OF THE PROPRIETARY INFORMATION, INCLUDING, BUT NOT LIMITED TO, WEATHER NOTFICATIONS SOFTWARE OR CONTENT, TO ANY OTHER SERVER OR LOCATION FOR FURTHER REPRODUCTION OR REDISTRIBUTION IS EXPRESSLY PROHIBITED. Proprietary Information also includes, without limitation, information, materials, content, images, graphics, software, trademarks, logos, service marks licensed or made available to Company by third parties.\par
\par
Intellectual Property\par
\par
Except as expressly set forth herein, nothing on the Site or through your use of the Software or Services is intended to grant any rights (including, without limitation, under or with respect to any patent, mask work right, copyright, trademark, title, interest in products or trade secret of Company) to you. All such rights shall remain the sole and exclusive property of the Company and you shall gain no interest, right or title therein. Further, nothing contained herein, on the Site or through your use of the Software or Services should be construed as granting (whether express, by implication, estoppel or otherwise) any license or right to use any intellectual property, trademarks, copyrights or other proprietary information (or the Proprietary Information) displayed on or through the Site, the Software or the Services. The absence of a product or service name or logo anywhere in the text of the Site, the Software or the Services does not constitute a waiver of any trademark or other intellectual property rights concerning that name or logo. UNDER NO CIRCUMSTANCES WHATSOEVER MAY ANY USER REVERSE ENGINEER, DECOMPILE, DISASSEMBLE OR OTHERWISE ATTEMPT TO DECIPHER THE SITE, THE SOFTWARE OR THE SERVICES OR ANY OTHER ASPECT OF THE COMPANY\rquote S TECHNOLOGY, INTELLECTUAL PROPERTY, PRODUCTS, SERVICES OR PROPRIETARY INFORMATION.\par
\par
Third Party Code; Notice and Attribution.\par
\par
The Weather Alerts Software include third party software subject to open source license terms, which may include, without limitation, the following applications: Encryption Engine and Compression Algorithm. All rights are reserved by the licensors of such code and ownership is attributed as follows: Encryption Engine: Copyright \'a9 2002, Dr Brian Gladman brg@gladman.me.uk, Worcester, UK.  Compression Algorithm: Copyright \'a9 1995-2002 Jean-loup Gailly and Mark Adler.\par
\par
Supervision\par
\par
The Company does not assume responsibility for verifying the content, materials, documents and information passed through or accessed via or in connection with the Site, the Software or the Services. The Company is not responsible for any damages, losses, expenses or other injuries incurred by any User as a result of, relating to, or in connection with, any content, materials, documents and information transmitted, distributed or uploaded through or in connection with the Site, the Software or the Services.\par
\par
Access\par
\par
We may alter, suspend or discontinue (in whole or in part) the Site and the Services or your access to use Site and the Services at any time for any reason (or no reason) without any notice or liability whatsoever to you or to any third party (provided, that if you are a User of the Services and we suspend or discontinue the Services or your use of the Services, without cause or reason or notice).\par
\par
The Site, the Software and the Services may become unavailable due to routine maintenance or malfunction of computer equipment or for other reasons, and in any such instance, may result in damages to your systems or operations; we shall no liability whatsoever to you under any such circumstance. You shall be solely and wholly responsible for ensuring that any information, documents, materials or content obtained through or in connection with the Site, the Software or the Services (i) does not contain any virus or other computer software code or subroutine designed to disable, erase, impair or otherwise damage your systems, software or data, and (ii) that are lawfully and properly used, uploaded, shared or accessed by you, are backed up or stored on your own systems or servers. The Company shall have no obligation or duty whatsoever to backup any portion of the Site or any information, content, materials or documents on the Site. You expressly agree and acknowledge that you are not relying on us to perform any backup or storing of your content, information, materials or documents.\par
\par
Third Party Content, Advertising or Services\par
\par
Please note that the free version of the Software is supported by advertising. Accordingly, the Site and the free version of the Software may provide third party content, advertising and services, and links thereto (e.g., links to third party websites), that are owned or operated by third parties or generated by other users (collectively, \ldblquote Third Party Content and Services\rdblquote ). As a user of the Site and the free version of the Software and Services, you may be presented with Third Party Content and Services within the Site, through your use of the Software and Services, and within web pages rendered by your browser when the Software or Services are enabled. Such Third Party Content and Services are not endorsed or controlled by the Company, and the Company assumes no responsibility for the content, privacy policies, or practices of any Third Party Content and Services. Additionally, your dealings with or participation in promotions of advertisers derived from such Third Party Content and Services, including payment and delivery of goods, and any other terms are solely between you and such providers of Third Party Content and Services. You agree that the Company shall not be responsible for any loss or damage of any sort relating to your dealings with such providers of Third Party Content and Services. By upgrading to the Company\rquote s paid or premium version of the Software and Services, the program, mechanism or add-on to the Software that provides the Third Party Content and Services will be automatically uninstalled.\par
\par
Important Information Regarding Local Weather Software Functionality\par
\par
Local Weather Software incorporates search functionality software (the \ldblquote Software\rdblquote ), described as follows: The Software recognizes keywords from your Internet browser to display relevant contextual advertisements. These advertisements may be displayed on your computer screen at any time while you are searching and shopping online (and not necessarily while you are using any product or service related to or downloaded with the Software). The Software neither stores any personally identifiable information nor records your browsing behavior. Please refer to Section 11 (below) for further information about our privacy policies.\par
\par
Display of Advertising.\par
\par
The Software starts automatically when you start your computer, runs in the background on your computer, and may periodically direct you to our sponsors\rquote  websites and/or show you other forms of advertisements (including the Slider or pop up format). By installing Weather Alerts and/or using the Software you grant Local Weather permission to periodically show you advertisements. The frequency of these advertisements will be limited. Depending on Internet activity, active users may see about five (5) advertisements per day; some may see more, some may see fewer. On occasion, you may search for a website and receive an error from your browser software indicating that the site cannot be found. When this occurs, the Software includes a function that may redirect your web browser to our sponsor\rquote s websites based on the content of the website address, or URL, which you entered. You hereby consent to these actions. Please note that you may receive ads for Adult-oriented websites if you utilize keywords connected to, search for or view Adult websites. An Adult website is one that contains or references (whether via audio, video, audiovisual, images, sounds or text) any of the following: profanity, violence, blood and gore, weapons, use of alcohol, drugs, tobacco, online gambling, pornography, erotica, erotic images, nudity, sex, sexually explicit images, and sexual references. Local Weather does not permit ads that are themselves pornographic, nor does it permit advertisements for online \ldblquote pay-for-play\rdblquote  gambling, either directly or indirectly, in the United States or other jurisdictions where such advertisements are disallowed. More generally, Local Weather does not permit ads promoting illegal products or illegal practices. If you believe you have received an ad that violates these prohibitions, please contact us at the web or street address listed in the last section of this Agreement. We request that you enclose a screenshot of the advertisement (including its ad label) in your communication to us.\par
\par
Identification of Advertisements.\par
\par
The advertisements that the Software presents are not endorsed by or affiliated with the websites that trigger their appearance. Advertisements that the Software presents are branded with a Local Weather brand name in, for example, the browser window. This branding will let you know that the advertisements are brought to you by Weather Alerts and not by the website you may be viewing when the advertisements are displayed.\par
\par
Links to Us\par
\par
Unless another party has entered into a written agreement with the Company, a party may only provide a hypertext link to the Site on another web site, if such hyperlink complies with ALL of the following conditions: 1) the link must be a text-only link clearly marked as {\field{\*\fldinst{HYPERLINK ""www.desktopweatheralerts.com""}}{\fldrslt{\ul\cf1 www.desktopweatheralerts.com}}}\f0\fs22 ; 2) the link must \ldblquote point\rdblquote  to the URL \ldblquote{\field{\*\fldinst{HYPERLINK ""http://www.desktopweatheralerts.com""}}{\fldrslt{\ul\cf1 http://www.desktopweatheralerts.com}}}\f0\fs22\rdblquote  and not to any other pages within the site; 3) the link, when activated by a user of the linking site, must display the Site full-screen and not with a \ldblquote frame\rdblquote  on the linking web site; and 4) the appearance, position and other aspects of the link must not be such as to directly or indirectly damage or dilute the goodwill associated with the name and trademarks of the Company and the Site, and must not create the false or misleading appearance that the Company or the Site is associated with, or endorses or sponsors, the linking web site. The Company may selectively revoke its consent to any link at any time (for any reason or no reason) in the Company\rquote s sole and absolute discretion.\par
\par
Support, Software Updates and Uninstall\par
\par
The Company may elect to provide you with customer support for the Site, the Software and/or the Services (collectively, \ldblquote Support\rdblquote ), in its discretion, and may terminate such Support at any time without notice to you. The Company reserves the right, at any time, to add additional services and products, including services and products of its third party affiliates and marketing partners, and/or add additional, features or functions to, or release new versions of, the Software (any such new services, products, or features, functions or versions of the Software, \ldblquote Upgrades\rdblquote ). The Company reserves to right to automatically install, without your additional consent, any Upgrades at any time when the Software communicates with the Company\rquote s servers. Finally, although we may make Upgrades available to you, you understand and acknowledge that we have no obligation to do so. The Company may change, suspend, or discontinue any aspect of the Site, Software and/or Services at any time. The Company may also impose limits on certain features within the free version of our Software and Services or restrict your access to parts or all of the features without notice or liability to you. The Company reserves the right to market, promote, advertise or solicit other offerings through your use of the free or paid version of our Software and Services. Once installed, the Software can be uninstalled by accessing Add/Remove Software (or Uninstall a Program) through your Control Panel.\par
\par
Disclaimer of Warranties\par
\par
THE SITE, THE SOFTWARE AND THE SERVICES ARE PROVIDED ON AN \ldblquote AS-IS\rdblquote  AND \ldblquote AS-AVAILABLE\rdblquote  BASIS WITHOUT WARRANTIES OF ANY KIND WHATSOEVER. TO THE FULLEST AND MAXIMUM EXTENT PERMISSIBLE PURSUANT TO APPLICABLE LAW, THE COMPANY DISCLAIMS ANY AND ALL WARRANTIES, EXPRESS OR IMPLIED, INCLUDING, BUT NOT LIMITED TO, IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, TITLE AND NON-INFRINGEMENT. SPECIFICALLY, BUT WITHOUT LIMITATION, THE COMPANY DOES NOT WARRANT THAT: (1) THE INFORMATION, MATERIALS OR CONTENT ON THE SITE OR RELATED TO THE SOFTWARE OR THE SERVICES IS CORRECT, ACCURATE OR RELIABLE; (2) THE FUNCTIONS CONTAINED ON THE SITE OR THROUGH THE SOFTWARE OR THE SERVICES WILL BE UNINTERRUPTED, SECURE OR ERROR-FREE; OR (3) ANY DEFECTS WILL BE CORRECTED, OR THAT THE SITE, THE SOFTWARE OR THE SERVICES OR THE SERVER THAT MAKES THEM AVAILABLE ARE FREE OF VIRUSES OR OTHER HARMFUL COMPONENTS. YOU HEREBY ACKNOWLEDGE THAT USE OF THE SITE, THE SOFTWARE AND THE SERVICES IS AT YOUR SOLE AND ABSOLUTE RISK IN YOUR OWN DISCRETION.\par
\par
Limitation of Liability\par
\par
NOTWITHSTANDING ANYTHING TO THE CONTRARY HEREIN, IN NO EVENT, AND UNDER NO CIRCUMSTANCES, WHATSOEVER (AND REGARDLESS OF THE PURPORTED THEORY OF LIABILITY, WHETHER IN CONTRACT, TORT, STRICT LIABILITY OR OTHERWISE) WILL WEATHER ALERTS BE LIABLE (EVEN IF WEATHER ALERTS KNOWS OR HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES) FOR: (1) ANY INCIDENTAL, SPECIAL, CONSEQUENTIAL, EXEMPLARY, PUNITIVE OR INDIRECT DAMAGES ARISING OUT OF, RELATING TO, OR IN CONNECTION WITH THE SITE, THE SOFTWARE, ANY SERVICES OR THE RELATIONSHIP BETWEEN YOU AND LOCAL WEATHER; OR (2) AGGREGATE, CUMULATIVE LIABILITY ARISING OUT OF, RELATING TO, OR IN CONNECTION WITH, THESE TERMS OF USE, THE SITE, THE SOFTWARE, ANY SERVICES OR THE RELATIONSHIP BETWEEN YOU AND LOCAL WEATHER, WHICH EXCEEDS THE AMOUNT ACTUALLY PAID BY YOU TO LOCAL WEATHER TO ACCESS AND USE THE SOFTWARE AND THE SERVICES (IF YOU ARE A USER), OR, IF YOU HAVE NOT PAID TO USE THE SITE OR THE SERVICES, THE TOTAL AMOUNT OF $9.99 (TEN UNITED STATES DOLLARS). Each of you and us expressly acknowledge and agree that the limitations of liability set forth in this paragraph are an essential element to the agreement to enter into a relationship between you and LOCAL WEATHER, and in the absence of such limitations, the economic terms of the relationship between you and LOCAL WEATHER would have been substantially different than provided herein and/or the parties would not have entered into such a relationship.\par
\par
Indemnification\par
\par
You will, at your own expense, defend, indemnify and hold harmless the Company, its affiliates and agents, and their respective officers, directors, shareholders, agents, representatives, contractors, employees and customers (each, an \ldblquote Indemnitee\rdblquote , and collectively, \ldblquote Indemnitees\rdblquote ) from and against any and all loss, cost, expense, damage, claim, demand, or liability, including (without limitation) reasonable attorney and professional fees and costs, and the cost of settlement, compromise, judgment, or verdict incurred by, or demanded of, an Indemnitee, that, directly or indirectly, arises out of, results from or occurs in connection with: (a) your negligence, bad faith or willful misconduct; (b) your breach of any of the provisions of these Terms of Use; (c) your violation of any applicable law, rule or regulation; (d) (i) infringement by you of any intellectual property, proprietary or other rights of any third party, including (without limitation) any patent, copyright or trademark, (ii) unlawful disclosure, use, or misappropriation of a trade secret by you, or (iii) violation of any other third-party intellectual property right, or other property or personal right of any person or entity; or (c) your use of the Site, the Software or any Services in any manner whatsoever. We reserve the right, at our own cost and in our sole and absolute discretion, to assume the exclusive defense and control of any matter otherwise subject to indemnification by you, in which event you will fully cooperate with us in asserting any available defenses, and reimburse our reasonable costs and expenses (including, without limitation, reasonable attorney and professional fees) in connection with, relating to or arising from our defense in such matter.\par
\par
Changes or Specialized Modifications\par
\par
The Company may, in its sole and absolute discretion, modify or change any or every aspect of these Terms of Use at any time (for any reason or no reason), effective immediately upon posting such modifications or changes (or a revised version of these Terms of Use incorporating such modifications or changes therein) on or through the Site. Please periodically consult the end of these Terms of Use to determine when these Terms of Use were last revised. You agree to periodically review these Terms of Use to ensure that you are in compliance with any ongoing changes or modifications that are made to these Terms of Use. Your continued use of the Site, Software and Services after any such modifications or changes are posted will constitute your complete and unequivocal acceptance of such any modifications or changes to these Terms of Use. The Company reserves the right, but has no obligation whatsoever, to modify or change these Terms of Use as it applies to any specific User, provided that any and all such special modifications must be in writing and signed by and between the Company and the applicable User. Any specialized modifications so made shall apply exclusively and only to the User that is a party to such written agreement.\par
\par
General\par
\par
If any provision of these Terms of Use is declared by a court of competent jurisdiction to be illegal, invalid or unenforceable for any reason, then: (i) such provision will be enforced to the maximum extent permissible under the circumstances so as to effectuate the original intent of the parties with respect to such provisions; and (ii) the remaining provisions of these Terms of Use will be unaffected thereby and will continue to remain in full force and effect at all times.\par
\par
These Terms of Use shall be governed by and construed in accordance with the laws of the State of Minnesota without regard to the conflicts of law provisions thereof. You expressly agree that any controversy, dispute or claim (\ldblquote Litigation\rdblquote ) arising out of, relating to, or in connection with, these Terms of Use, the Site, the Software or the Services shall be settled by confidential binding arbitration in Hennepin County Minnesota, in accordance with the applicable rules of the American Arbitration Association, and judgment on the award rendered by the arbitrator(s) shall be binding on the parties and may be entered in any court having jurisdiction. Regardless of any statute or law to the contrary, any claim or cause of action arising out of or related to these Terms of Use or your use of the Site, the Software or the Services must be filed within 6 months after such claim or cause of action arose or was reasonable discovered, whichever is later, or be forever barred. In the event of any Litigation, both parties expressly and irremovably consent to the exclusive venue and personal jurisdiction in Hennepin County Minnesota. In the event of any Litigation arising from, related to or in connection with these Terms of Use, the Site, the Software or the Services, the prevailing party thereof shall be entitled to recover its reasonable expenses, including (without limitation) attorneys\rquote  fees and the costs of litigation and arbitration. The agreement to arbitrate in this paragraph shall not prevent Company from seeking redress in any court of competent jurisdiction to protect its Proprietary Information or intellectual property, nor shall it prevent either party from enforcing this agreement to arbitrate or enforcing any judgment in any court of competent jurisdiction. You expressly agree that any Litigation arising out of, relating to, or in connection with, these Terms of Use, the Site, the Software or the Services, shall be resolved individually, without resort to any form of class action.\par
\par
Company will not be liable for any failure to perform acts due to causes beyond its control (including, without limitation, electrical outage, Internet Service Provider downtime, power failure, fire, flood, strike, civil disturbance, terrorism, war or Acts of God). If any such circumstances occur, Company shall provide reasonable notice to you of the same and the time for Company to perform hereunder will be extended for a period of time equal to the duration of the delay or default caused thereby.\par
\par
Neither this Agreement, nor any rights or obligations hereunder, may be assigned or otherwise transferred (in whole or in part) by you without the prior express written consent of Company. Any attempted assignment by you in violation of this paragraph shall be null and void. This Agreement will be binding upon and inure to the benefit of the parties hereto and their respective successors, heirs, executors and permitted assigns. Company may freely assign or transfer (in whole or in part) this Agreement without your consent or notice thereof to you. Company may also freely subcontract or otherwise delegate the Services or any portion thereof or any of its obligations under these Terms of Use to a third party or subcontractor without your consent or notice thereof to you.\par
\par
The rights and remedies of Company under these Terms of Use are cumulative and may be exercised singularly or concurrently in each and every instance. You acknowledge and agree that any actual or threatened breach of any of the provisions contained in the paragraphs titled Intellectual Property and/or Proprietary Information herein may result in immediate, irreparable and continuing damage to Company for which there is no adequate remedy at law, and Company may apply to any court of competent jurisdiction for immediate equitable relief (including, without limitation, specific performance or injunctive relief) without the need for posting of any bond.\par
\par
Failure by Company to enforce any right, remedy or provision hereof will not be deemed a waiver of the same or any future enforcement of that or any other right, remedy or provision, unless (and only to the extent) that such waiver is in writing and signed by a duly authorized representative of Company.\par
\par
These Terms of Use contains the entire understanding between Company and you with respect to the subject matter hereof and supersedes any and all prior and contemporaneous agreements or understandings (whether oral, written, implied or otherwise) between the parties with respect to the subject matter hereof. Except as provided in the paragraph titled \ldblquote Changes or Specialized Modifications\rdblquote , any modification, addendum, or amendment to these Terms of Use will not be effective unless the same is in writing and signed by duly authorized representatives of both parties hereof.\par
\par
Contact Us.\par
\par
If you have any questions about the Weather Alerts Software, you should first consult the Local Weather website: {\field{\*\fldinst{HYPERLINK ""http://www.desktopweatheralerts.com""}}{\fldrslt{\ul\cf1 http://www.desktopweatheralerts.com}}}\f0\fs22 . This site includes links to company information. If you have further questions or concerns, please contact us at {\field{\*\fldinst{HYPERLINK ""http://desktopweatheralerts.com/contact-us/""}}{\fldrslt{\ul\cf1 http://desktopweatheralerts.com/contact-us/}}}\f0\fs22 .\par
}";

            richTextBox2.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang11274{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
{\colortbl ;\red0\green0\blue255;}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang10\f0\fs22 End User License Agreement\par
\par
READ THIS USER AGREEMENT CAREFULLY BEFORE INSTALLING, ACCESSING, COPYING OR USING THE SOFTWARE ACCOMPANYING THIS AGREEMENT. CLICKING ON THE ""Download and Install Button"" , OR IN ANY OTHER WAY INSTALLING, ACCESSING, COPYING OR USING THE SOFTWARE, CREATES A LEGALLY ENFORCEABLE CONTRACT AND CONSTITUTES ACCEPTANCE OF ALL TERMS AND CONDITIONS OF THIS AGREEMENT WITHOUT MODIFICATION.\par
RETURN: IF YOU ARE NOT AUTHORIZED TO ENTER INTO THIS AGREEMENT, OR IF YOU DO NOT AGREE TO ALL OF THE TERMS OF THIS AGREEMENT, THEN YOU MUST CLICK ON THE ""CANCEL"" BUTTON DURING THE MOBOGENIE INSTALLATION PROCESS, AND YOU MUST NOT INSTALL, ACCESS, COPY OR USE THE SOFTWARE, AND YOU MUST, WITHIN 3 DAYS, DELETE AND PERMANENTLY ERASE FROM ALL COMPUTER MEMORIES AND STORAGE MEDIA ALL COPIES OF THE SOFTWARE AND DOCUMENTATION.\par
\par
* All users (Users""), must carefully read the following Terms of Service (TOS), before utilizing any MOBOGENIE services.\par
\par
1. ACCEPTANCE OF TERMS\par
Welcome to the MOBOGENIE Global Mobile Web Community! We want to build the largest Community Platform focused on Android Mobile Content and Services (Service""). MOBOGENIE is a unique place where Users can take advantage of a private online hard disk dedicated to storing, publishing and sharing material and personal content for mobile devices -- including pictures, ringtones, wallpapers, logos, as well as the most appropriate applications for users of mobile phones. Service provided to the Users of the mobile phones also includes the conversion of files from the PC which can be adapted and then sent to mobile phones throughout the world.\par
By registering pertinent details on the website and bringing into use any services including but not limited to any MOBOGENIE products, software, data feeds, and services provided to you on, from, or through the MOBOGENIE website, you acknowledge that you have read and accept the TOS. If you do not agree to any of these terms or conditions, please do not use the Service.\par
MOBOGENIE reserves the exclusive right to decide what can and cannot be done through its Service. Users become Members"" of MOBOGENIE only after installing and/or using any MOBOGENIE products, software, data feeds, and services.\par
\par
2. SERVICE DESCRIPTION\par
Welcome to the MOBOGENIE Global Mobile Web Community! We want to build the largest Community Platform focused on Android Mobile Content and Services (Service""). MOBOGENIE is a unique place where users can take advantage of a PC internet to download applications, games and other mobile contents directly on the phone without using mobile internet. Users can also publish and share material and personal content for mobile devices -- including pictures, ringtones, wallpapers, logos, as well as the most appropriate applications for mobile phones. Service provided to Users also includes the conversion of files from the PC which can be adapted and then sent to mobile phones throughout the world.\par
TOS applies to all Users of the Service, including users who are also contributors of Content to the Service. ""Content"" includes the text, software, scripts, graphics, photos, sounds, music, videos, audiovisual combinations, interactive features and other materials you may view on, have access through, or contribute to the Service. The Service includes all aspects of MOBOGENIE, including but not limited to all products, software and services offered via the MOBOGENIE website and other mobile phone applications\par
MOBOGENIE reserves the exclusive right to decide appropriate usage of the Service. Users become Members"" of MOBOGENIE only after installing and/or using any MOBOGENIE products, software, data feeds, and services.\par
Currently, MOBOGENIE provides its Users a web-based online hard disk dedicated to storing, publishing and sharing material and personal content for mobile phones (i.e. applications, pictures, games, utilities, logos, ringtones, images and audio executable files). MOBOGENIE Users may save, share and distribute their personal files on the Web, via Mobile, and to virtually any mobile phone in the world. Users can enjoy the use of a private area to save their materials. User content can be kept private or can be made available to the entire MOBOGENIE community, depending on the selection of the posting User.\par
MOBOGENIE provides a FREE Service for publishing, managing and sharing personal mobile content for all mobile phones regardless of mobile phone manufacturer and wireless service provider. Personal mobile content on MOBOGENIE public area can also be downloaded to any PC and be sent and downloaded to User's mobile device, for FREE. Free registration includes:\par
\par
    1. Free downloads to User's mobile phone;\par
    2. Free file downloads to desktop, and>\par
    3. Unlimited applications upgrade;\par
\par
MOBOGENIE DOES NOT own the content uploaded by the Users, but rather provides a service to transfer the personal content provided by the Users from the web to mobile devices. MOBOGENIE does not has any control of the files uploaded by the Users, and therefore cannot be held responsible for any loss, damage and liability caused by the content uploaded to its platform. Upon receipt of any notice from the copyright owner, MOBOGENIE shall take responsible for Deleting infringing material after verification.\par
\par
Unless otherwise indicated, any modification of MOBOGENIE Service which alters the way in which the Service can be used and/or the launch of new services will be subject to, and therefore regulated by the TOS. Users acknowledge that the Service is provided as is"" and as available,"" therefore, MOBOGENIE does not assume any responsibility and makes no guarantee as to the use and availability of the Service. MOBOGENIE has created certain areas where Users can upload and publish adult\\mature content. Users must be at least 18 years of age to access and view such areas. These areas have been set up in order to keep content and files not suitable for minors in a restricted area, not accessible by Users younger than18 years old. At the same time, even in this area of MOBOGENIE, pornography of any kind is strictly prohibited. We invite all Users to post their content in this area when they feel that such content is not suitable for minors.\par
\par
MOBOGENIE does not assume any implicit or explicit responsibility for the content stored and published by the Users in any area of MOBOGENIE. Declarations and opinions expressed by the Users do not necessarily represent MOBOGENIE opinions, as MOBOGENIE does not approve, select, certify or control the content of the files. Moreover, MOBOGENIE is not responsible for the receipt or for the quality of any good or service sold or advertised on MOBOGENIE. If any User believes that a file published or uploaded by another User is in violation of laws and regulations, the User is encourage to report it to MOBOGENIE at the email address: support@mobogenie.com.\par
\par
3. OBLIGATIONS RELATING TO REGISTRATION AND CHILD PROTECTION\par
In order to utilize the Service, the User must agree to represent that he\\she is of legal age to form a binding contract and is not a person barred from receiving services under the laws of the United States. MOBOGENIE is concerned about the safety and privacy of all its Users, particularly children. For this reason, Users must be at least 14 years old to utilize the Service\par
\par
4. PRIVACY POLICY AND INFORMATION ON PERSONAL DATA PROTECTION\par
The information if anyof a User are collected and used in accordance with the laws of the United States, and to the MOBOGENIE Privacy Policy, which can be viewed at the URL:http://www.mobogenie.com/privacy-policy.html\par
\par
    MOBOGENIE declares that:\par
    1.The Dataif anyprovided by Users are collected and used by the Company which owns and runs the MOBOGENIE Platform and provides the Service. The Data are collected for: advertising, promotion, and direct marketing purposes of MOBOGENIE. By utilizing the Service.\par
    2. With the same purposes as stated above, some data may be communicated by MOBOGENIE to other entities belonging to MOBOGENIE Group or to the 3rd parties, in order to perform activities instrumental to the maintenance, development, distribution, and improvement of the Service. For organizational purposes related to centralized operations and provision of the Service, and due to the international scope of MOBOGENIE, some personal data of Users may be transferred, even temporarily, to different countries of the United States.\par
\par
    MOBOGENIE recognizes specific rights of its Users, including the possibility (i) to request records indicating whether or not MOBOGENIE retains the User's personal data (ii) to track the origin of the User's record, and of the logic and objectives for retaining such data; (iii) to effect the updating, correction, integration and eventual cancellation of the User's data, wherever possible; (iv) to oppose the use of personal data for marketing and sales purposes. In order to exercise these specific rights, the User may directly contact MOBOGENIE for privacy and database issues at support@mobogenie.com.\par
\par
5. USER CONDUCT\par
The User has the sole responsibility for any content uploaded, published, or in any other way transmitted to or distributed through the Service. MOBOGENIE does not control the content posted or uploaded to its servers by the Users and, as such, does not guarantee the integrity, correctness, or quality of such content. MOBOGENIE only provides uploading space service for the users and will not edit and modify any uploading contents in any forms. In addition, MOBOGENIE will not get any economic benefits directly from the content posted or uploaded to its servers by the users. Under no circumstances will MOBOGENIE be liable in any way for any content made available through the Service.\par
\par
    The Users agree not to use the Service to:\par
    a) Upload, publish, or make available in any other way Content that is unlawful or prohibited;\par
    b) Harm people under the age of 18 in any way;\par
    c) Upload, publish, or make available in any other way Content that the User does not have the right to distribute;\par
    d) Upload, publish, or make available in any other way Content which infringes any Patent, Laws, Trade Secrets, Copyright or other Proprietary Rights;\par
    e) Disturb or interfere with the Service, the servers or the networks connected to the Service;\par
    f) Violate any local or International laws or applicable regulations;\par
    g) Collect and store other Users' personal data without their explicit permission;\par
    h) Upload, publish, or make available in any other way pornographic material, which is strictly prohibited in all areas of MOBOGENIE.\par
\par
MOBOGENIE does not filter or review the Content uploaded by the Users in advance. Nonetheless, MOBOGENIE and other entities designated by MOBOGENIE reserve the sole right Cwithout assuming any obligation- to refuse or remove any Content accessible through the Service. The User is solely responsible for the material posted by himself/herself in any area of MOBOGENIE. The publication and posting of the following types of Content is strictly prohibited:\par
\par
    a) Material not suitable for people under the age of 18 (except in the expressly designated Adult areas"");\par
    b) Content which infringes any local or International copyright laws, in particular Pirate Software (WAREZ, CRACK), musical files, applications and games, images and texts covered by copyright laws;\par
    c) Content which can offend or harm other people, including expression of hatred, racism, or the discrimination against groups of people, or threatening or insulting;\par
    d) Content promoting or providing information for the promotion of illegal activities, or potentially harmful to the 3rd parties;\par
    e) Paid advertising or sponsorship;\par
    f) Content or activities infringing any local or international laws.\par
\par
The User recognizes and accepts MOBOGENIE's right to save Content and disclose it to the 3rd parties, in order to:\par
\par
    a) provide an efficient service;\par
    b) manage the User's account consistently with MOBOGENIE operational procedures;\par
    c) comply with legal requests because MOBOGENIE believes, in good faith, that it is necessary to: (i) fulfil legal obligations; (ii) defend from the 3rd party accusations relating to the infringement of Copyright laws; (iii) to protect MOBOGENIE and its Users' rights, property and security.\par
\par
By uploading files on MOBOGENIE, the Users agree to respect to accpet the TOS. MOBOGENIE reserves the right to decide what the Users can or cannot do with the Service. MOBOGENIE reserves the right to remove any User's file at any moment, and to cancel any subscription without prior notice. It is the sole responsibility of the User to keep a copy of the Content uploaded on MOBOGENIE. MOBOGENIE does not assume any responsibility in case of partial or total loss of the User's material. Although MOBOGENIE is not obliged to pre-screen and screen the files uploaded by Users, MOBOGENIE reserves the right to access any account and any file, without prior notice and/or authorization, in order to verify the Users' compliance with the TOS. Personal data if anyprovided to MOBOGENIE remains the User's property. The User allows MOBOGENIE to use this information for operational and marketing purposes. This information will never be sold or ceded to the 3rd parties, unless specifically requested by laws, or unless explicitly agreed to by the User. The use of this Service is entirely at the User's risk. Services are provided without any implicit or explicit guarantees. In no way is MOBOGENIE responsible for eventual damages deriving from the inaccessibility to personal information, from the loss or alteration of stored materials by other Users, or by any other event, including service interruption.\par
\par
6. PUBLIC CONTENT\par
The User agrees that all videos, pictures and tunes he/she publishes onto the Public areas of MOBOGENIE are provided for a free, perpetual, irrevocable, non-exclusive, and freely sub-licensable license to use, reproduce, modify, adapt, publish, translate, to create derived works, distribute, and visualize (partially or wholly) in the whole world and/or to incorporate this Content in any form, media or technology currently known or to be developed in the future.\par
\par
7. INDEMNITY\par
In the event of legal action brought on by a third party in relation to Content submitted, posted, published or otherwise made available through the Service, and/or in relation to any Users' conduct, and/or in relation to the User's violation of the TOS, and/or of the User's infringement of rights of others, the User agrees to indemnify MOBOGENIE, and its affiliates, partners, owners, officers, agents, and employees from all claims and demands (including legal fees).\par
\par
8. NO RESALE OR COMMERCIAL USE OF SERVICE\par
The User agrees not to reproduce, copy, duplicate, sell, resell or in any way use for commercial purposes any part of the Service, including access to the Service.\par
\par
9. GENERAL RULES REGARDING SERVICE USE\par
The Users agree that MOBOGENIE may establish rules and general limits, which can be updated from time to time, regarding the use of the Service, including the maximum amount of disk space can be used by each user, the number of times the User can access the Service per Unit of time, the number and size of the content which can be uploaded or downloaded, and the duration of each session. The Users agree that MOBOGENIE cannot be held responsible for the loss of data, or content uploaded by the Users.\par
\par
10. SERVICE MODIFICATION\par
MOBOGENIE reserves the sole and exclusive right to modify at any moment, even without notice, temporarily or permanently, the Service. The Users agree that MOBOGENIE cannot be held responsible for any of the modifications, suspensions or cancelling of the Service.\par
\par
11. THE USER ACKNOWLEDGES AND ACCEPTS\par
The User acknowledges and accepts that MOBOGENIE may, at its sole discretion, suspend the User's access to the Service. Moreover, MOBOGENIE has the right to remove or cancel any of the Users' content, without notice and without being obliged to explain.\par
\par
12. MOBOGENIE's PROPRIETARY RIGHTS\par
The User acknowledges and agrees that all Software utilized in connection with the Service (Software"") is protected by the Intellectual Property laws. MOBOGENIE grants the User a non-exclusive, non-transferable and personal, royalty-free license to use the Software on a single Computer. The Users shall not copy, modify, create derivative works and shall not reverse engineer, de-compile or disassemble MOBOGENIE in any shape or form, and in any way try to discover the source codes of the Software, sell, sub-license, or transfer to the 3rd parties any right on the Software.\par
\par
13. MOBOGENIE'S DISCLAIMER OF WARRANTIES\par
\par
    The Users declare expressly that:\par
    a) The utilization of the Service is at his\\her sole discretion. The Service is provided AS IS"" and AS AVAILABLE"". Therefore MOBOGENIE cannot be held responsible in relation to the fruition and availability of the Service. MOBOGENIE expressly disclaims all warranties of any kind.\par
    b) MOBOGENIE does not warrant that: (i) the Service will satisfy the User's needs, (ii) the Service will be provided without interruptions, or without errors, (iii) the quality of Service purchased through the Service will satisfy the User's expectations.\par
    c)Any file downloaded from or obtained through the Service is obtained at the sole discretion of the User, and the User is solely responsible for any harm caused, directly or indirectly, by the content on the Computer or the mobile phone.\par
    d) No advise, suggestion, help, written or verbal, provided by MOBOGENIE to the Users, shall imply any warranty from MOBOGENIE.\par
\par
14. LIMITATIONS OF LIABILITY\par
MOBOGENIE services are provided without any implicit or explicit warranty. MOBOGENIE cannot be held responsible of any harm coming from the inability to access or use the Service, or the loss of the files uploaded by the Users. It is the responsibility of the Users to keep a copy of the Content uploaded on MOBOGENIE. MOBOGENIE declines any responsibility for any harm due to the inability to access the Service, viruses, damaged files, errors, interruption of the Service, network problems, non authorized access, modification of data. MOBOGENIE reserves the right to modify the Service and the TOS at any time, with or without notice.\par
\par
15. COMMUNICATION\par
All communications between the Users and MOBOGENIE shall be in written form via Electronic email or Postal services.\par
\par
16. COPYRIGHT AND INTELLECTUAL PROPERTY\par
MOBOGENIE cares and protects Intellectual Property rights and requests its Users to do the same. If you believe that one of your works has been copied in a way that infringes copyright laws, within the Service, please report it to MOBOGENIE with the following information provided:\par
\par
    1. Detailed description of the work protected by copyright laws which you believe being infringed, also describing of the origin of the right itself;\par
    2. Indicate where, in the platform, you have found the infringement;\par
    3. Your name, address, phone number, and email address;\par
    4. A declaration in which you state, in good faith, that the use of the Content is not authorized by the copyright owner, or any of its licensees, or under the copyright laws;\par
    5. A declaration stating that the information you provide are true and that you are the legitimate copyright owner or you are legitimately acting on behalf of the owner;\par
    6. The user shall declare in advance, if any of his/her content is copyrighted and registered with the authority.\par
\par
17. APPLICABLE LAW AND FORUM\par
The TOS and the relationship between MOBOGENIE and its Users will be governed by laws of the United States. If for any reason the court finds any provision or portion of the TOS, to be unenforceable, the remainder of the TOS shall continue in full force and effect.\par
\par
18. VIOLATIONS\par
Please report any violations to these TOS to our Help and Support Group:support@mobogenie.com\par
\par
19. CONTACT MOBOGENIE?\par
To contact mobogenie in relation to the ""mobogenie"" branded software or products, please submit a support request to customer support team, please submit a support request to {\field{\*\fldinst{HYPERLINK ""http://www.mobogenie.com/support/""}}{\fldrslt{\ul\cf1 http://www.mobogenie.com/support/}}}\f0\fs22\par
Department: Mobogenie\par
Beijing Yang Fan Jing He Information Consulting Co. Ltd.,\par
East Tower, Jing Yan Building,No.29 Shijingshan Road,\par
Shijingshan District,\par
Beijing 100043,\par
P. R. China\par
\par
TOS ACCEPTANCE\par
User acknowledges to he/she has read, understands, and accepts the TOS and in particular: Art. 1 (Acceptance Of Terms); Art. 4( Privacy Policy And Information On Personal Data Protection); Art. 7 (Indemnity); Art. 10,11(Service Modification); Art. 13 (MOBOGENIE's Disclaimer Of Warranties); Art. 14 (Limitation Of Liability); Art. 17(Applicable Law And FORUM).\par
\par
YOU ACKNOWLEDGE THAT YOU HAVE READ AND ACCEPT THESE TERMS AND CONDITIONS BY PRESSING THE ""I AGREE"" BUTTON DURING MOBOGENIE INSTALLATION PROCESS AND AGREED TO BE BOUND BY ITS TERMS AND CONDITIONS. IF YOU DO NOT AGREE TO THESE TERMS AND CONDITIONS, YOU MAY CHOOSE NOT TO BECOME A USER OF THE SERVICE BY PRESSING THE ""CANCEL"" BUTTON BELOW AND YOU WILL NOT BE PERMITTED TO USE MOBOGENIE \par
}";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WeatherAlers = checkBox1.Checked;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.mobogenie.com/end-user-license-agreement.html");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore.exe", "http://www.mobogenie.com/privacy-policy.html");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Mobogeine = checkBox2.Checked;
        }
    }
}
