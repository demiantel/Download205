namespace Downloader205
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelFondo = new System.Windows.Forms.Panel();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.lblAppDescript = new System.Windows.Forms.Label();
            this.pnlDescarga = new System.Windows.Forms.Panel();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCabecera1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkipAll = new System.Windows.Forms.Button();
            this.llContactUs = new System.Windows.Forms.LinkLabel();
            this.llWhyItIsFree = new System.Windows.Forms.LinkLabel();
            this.llHelp = new System.Windows.Forms.LinkLabel();
            this.llSetupInfo = new System.Windows.Forms.LinkLabel();
            this.llPrivacyPolicy = new System.Windows.Forms.LinkLabel();
            this.panelPasos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombrePrograma = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.pnlCaptura = new System.Windows.Forms.Panel();
            this.pnlConfirmar = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            this.pnlDescarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackgroundImage = global::Downloader205.Properties.Resources.BannerIzquierda;
            this.panelFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFondo.Controls.Add(this.btnDescargar);
            this.panelFondo.Controls.Add(this.lblAppDescript);
            this.panelFondo.Controls.Add(this.pnlDescarga);
            this.panelFondo.Controls.Add(this.lblCabecera1);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.btnSkipAll);
            this.panelFondo.Controls.Add(this.llContactUs);
            this.panelFondo.Controls.Add(this.llWhyItIsFree);
            this.panelFondo.Controls.Add(this.llHelp);
            this.panelFondo.Controls.Add(this.llSetupInfo);
            this.panelFondo.Controls.Add(this.llPrivacyPolicy);
            this.panelFondo.Controls.Add(this.panelPasos);
            this.panelFondo.Controls.Add(this.btnCancelar);
            this.panelFondo.Controls.Add(this.btnAceptar);
            this.panelFondo.Controls.Add(this.lblNombrePrograma);
            this.panelFondo.Controls.Add(this.pbIcono);
            this.panelFondo.Controls.Add(this.pnlCaptura);
            this.panelFondo.Controls.Add(this.pnlConfirmar);
            this.panelFondo.Controls.Add(this.btnFinish);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(681, 411);
            this.panelFondo.TabIndex = 1;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(523, 364);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(145, 23);
            this.btnDescargar.TabIndex = 16;
            this.btnDescargar.Text = "Next »";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Visible = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // lblAppDescript
            // 
            this.lblAppDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDescript.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAppDescript.Location = new System.Drawing.Point(165, 18);
            this.lblAppDescript.Name = "lblAppDescript";
            this.lblAppDescript.Size = new System.Drawing.Size(503, 26);
            this.lblAppDescript.TabIndex = 14;
            this.lblAppDescript.Text = "Welcome to the minecraft setup Wizzard";
            // 
            // pnlDescarga
            // 
            this.pnlDescarga.Controls.Add(this.lblProgreso);
            this.pnlDescarga.Controls.Add(this.progressBar1);
            this.pnlDescarga.Controls.Add(this.pictureBox1);
            this.pnlDescarga.Location = new System.Drawing.Point(171, 47);
            this.pnlDescarga.Name = "pnlDescarga";
            this.pnlDescarga.Size = new System.Drawing.Size(500, 300);
            this.pnlDescarga.TabIndex = 6;
            this.pnlDescarga.Visible = false;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.BackColor = System.Drawing.Color.Transparent;
            this.lblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.ForeColor = System.Drawing.Color.White;
            this.lblProgreso.Location = new System.Drawing.Point(208, 107);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(0, 24);
            this.lblProgreso.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 134);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCabecera1
            // 
            this.lblCabecera1.AutoSize = true;
            this.lblCabecera1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCabecera1.Location = new System.Drawing.Point(165, 2);
            this.lblCabecera1.Name = "lblCabecera1";
            this.lblCabecera1.Size = new System.Drawing.Size(315, 18);
            this.lblCabecera1.TabIndex = 13;
            this.lblCabecera1.Text = "Welcome to the minecraft setup Wizzard";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome";
            // 
            // btnSkipAll
            // 
            this.btnSkipAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSkipAll.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSkipAll.Location = new System.Drawing.Point(76, 364);
            this.btnSkipAll.Name = "btnSkipAll";
            this.btnSkipAll.Size = new System.Drawing.Size(64, 23);
            this.btnSkipAll.TabIndex = 11;
            this.btnSkipAll.Text = "Skip All";
            this.btnSkipAll.UseVisualStyleBackColor = false;
            this.btnSkipAll.Visible = false;
            this.btnSkipAll.Click += new System.EventHandler(this.btnSkipAll_Click);
            // 
            // llContactUs
            // 
            this.llContactUs.AutoSize = true;
            this.llContactUs.BackColor = System.Drawing.Color.Transparent;
            this.llContactUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llContactUs.LinkColor = System.Drawing.Color.White;
            this.llContactUs.Location = new System.Drawing.Point(4, 330);
            this.llContactUs.Name = "llContactUs";
            this.llContactUs.Size = new System.Drawing.Size(52, 12);
            this.llContactUs.TabIndex = 10;
            this.llContactUs.TabStop = true;
            this.llContactUs.Text = "Contact Us";
            this.llContactUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llContactUs_LinkClicked);
            // 
            // llWhyItIsFree
            // 
            this.llWhyItIsFree.AutoSize = true;
            this.llWhyItIsFree.BackColor = System.Drawing.Color.Transparent;
            this.llWhyItIsFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llWhyItIsFree.LinkColor = System.Drawing.Color.White;
            this.llWhyItIsFree.Location = new System.Drawing.Point(4, 304);
            this.llWhyItIsFree.Name = "llWhyItIsFree";
            this.llWhyItIsFree.Size = new System.Drawing.Size(62, 12);
            this.llWhyItIsFree.TabIndex = 9;
            this.llWhyItIsFree.TabStop = true;
            this.llWhyItIsFree.Text = "Why It is Free";
            this.llWhyItIsFree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWhyItIsFree_LinkClicked);
            // 
            // llHelp
            // 
            this.llHelp.AutoSize = true;
            this.llHelp.BackColor = System.Drawing.Color.Transparent;
            this.llHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llHelp.LinkColor = System.Drawing.Color.White;
            this.llHelp.Location = new System.Drawing.Point(4, 317);
            this.llHelp.Name = "llHelp";
            this.llHelp.Size = new System.Drawing.Size(24, 12);
            this.llHelp.TabIndex = 8;
            this.llHelp.TabStop = true;
            this.llHelp.Text = "Help";
            this.llHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHelp_LinkClicked);
            // 
            // llSetupInfo
            // 
            this.llSetupInfo.AutoSize = true;
            this.llSetupInfo.BackColor = System.Drawing.Color.Transparent;
            this.llSetupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetupInfo.LinkColor = System.Drawing.Color.White;
            this.llSetupInfo.Location = new System.Drawing.Point(4, 291);
            this.llSetupInfo.Name = "llSetupInfo";
            this.llSetupInfo.Size = new System.Drawing.Size(47, 12);
            this.llSetupInfo.TabIndex = 7;
            this.llSetupInfo.TabStop = true;
            this.llSetupInfo.Text = "Setup Info";
            this.llSetupInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetupInfo_LinkClicked);
            // 
            // llPrivacyPolicy
            // 
            this.llPrivacyPolicy.AutoSize = true;
            this.llPrivacyPolicy.BackColor = System.Drawing.Color.Transparent;
            this.llPrivacyPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrivacyPolicy.LinkColor = System.Drawing.Color.White;
            this.llPrivacyPolicy.Location = new System.Drawing.Point(4, 278);
            this.llPrivacyPolicy.Name = "llPrivacyPolicy";
            this.llPrivacyPolicy.Size = new System.Drawing.Size(64, 12);
            this.llPrivacyPolicy.TabIndex = 6;
            this.llPrivacyPolicy.TabStop = true;
            this.llPrivacyPolicy.Text = "Privacy Policy";
            this.llPrivacyPolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPrivacyPolicy_LinkClicked);
            // 
            // panelPasos
            // 
            this.panelPasos.Location = new System.Drawing.Point(171, 47);
            this.panelPasos.Name = "panelPasos";
            this.panelPasos.Size = new System.Drawing.Size(500, 300);
            this.panelPasos.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(6, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Decline";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(523, 364);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Next »";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePrograma.ForeColor = System.Drawing.Color.White;
            this.lblNombrePrograma.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombrePrograma.Location = new System.Drawing.Point(4, 32);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(154, 33);
            this.lblNombrePrograma.TabIndex = 2;
            this.lblNombrePrograma.Text = "Welcome";
            // 
            // pbIcono
            // 
            this.pbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pbIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbIcono.Location = new System.Drawing.Point(-1, 68);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(161, 64);
            this.pbIcono.TabIndex = 1;
            this.pbIcono.TabStop = false;
            // 
            // pnlCaptura
            // 
            this.pnlCaptura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCaptura.Location = new System.Drawing.Point(171, 47);
            this.pnlCaptura.Name = "pnlCaptura";
            this.pnlCaptura.Size = new System.Drawing.Size(500, 300);
            this.pnlCaptura.TabIndex = 1;
            // 
            // pnlConfirmar
            // 
            this.pnlConfirmar.Location = new System.Drawing.Point(264, 116);
            this.pnlConfirmar.Name = "pnlConfirmar";
            this.pnlConfirmar.Size = new System.Drawing.Size(300, 150);
            this.pnlConfirmar.TabIndex = 15;
            this.pnlConfirmar.VisibleChanged += new System.EventHandler(this.pnlConfirmar_VisibleChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(523, 364);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(145, 23);
            this.btnFinish.TabIndex = 17;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 411);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloads 205 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.pnlDescarga.ResumeLayout(false);
            this.pnlDescarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfirmar;
        private System.Windows.Forms.Panel pnlCaptura;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Label lblNombrePrograma;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelPasos;
        private System.Windows.Forms.LinkLabel llPrivacyPolicy;
        private System.Windows.Forms.LinkLabel llSetupInfo;
        private System.Windows.Forms.LinkLabel llHelp;
        private System.Windows.Forms.LinkLabel llWhyItIsFree;
        private System.Windows.Forms.LinkLabel llContactUs;
        private System.Windows.Forms.Button btnSkipAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCabecera1;
        private System.Windows.Forms.Panel pnlDescarga;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAppDescript;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnFinish;

    }
}

