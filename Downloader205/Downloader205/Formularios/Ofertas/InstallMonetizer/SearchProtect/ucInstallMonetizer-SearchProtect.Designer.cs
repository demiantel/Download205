namespace Downloader205.Formularios.Ofertas.InstallMonetizer.SearchProtect
{
    partial class ucInstallMonetizer_SearchProtect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.llPolicy = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "By clicking \'Agree\', you accept the Privacy Policy and the above license agreemen" +
    "t";
            // 
            // llPolicy
            // 
            this.llPolicy.AutoSize = true;
            this.llPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPolicy.Location = new System.Drawing.Point(169, 269);
            this.llPolicy.Name = "llPolicy";
            this.llPolicy.Size = new System.Drawing.Size(73, 13);
            this.llPolicy.TabIndex = 4;
            this.llPolicy.TabStop = true;
            this.llPolicy.Text = "Privacy Policy";
            this.llPolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPolicy_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Install Search Protect to set my home page and default search to Conduit Search f" +
    "or Internet Explorer, Firefox, and Chrome, and to notify me of any chnages.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(344, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Learn more";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 223);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // ucInstallMonetizer_SearchProtect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llPolicy);
            this.Controls.Add(this.label1);
            this.Name = "ucInstallMonetizer_SearchProtect";
            this.Size = new System.Drawing.Size(500, 300);
            this.Load += new System.EventHandler(this.ucInstallMonetizer_SearchProtect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llPolicy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
