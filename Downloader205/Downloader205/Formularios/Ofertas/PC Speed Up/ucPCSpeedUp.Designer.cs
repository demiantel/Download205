namespace Downloader205.Formularios.Ofertas.PC_Speed_Up
{
    partial class ucPCSpeedUp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llTerminosYCondiciones = new System.Windows.Forms.LinkLabel();
            this.llPrivacy = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Downloader205.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // llTerminosYCondiciones
            // 
            this.llTerminosYCondiciones.AutoSize = true;
            this.llTerminosYCondiciones.BackColor = System.Drawing.Color.Transparent;
            this.llTerminosYCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llTerminosYCondiciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llTerminosYCondiciones.Location = new System.Drawing.Point(141, 282);
            this.llTerminosYCondiciones.Name = "llTerminosYCondiciones";
            this.llTerminosYCondiciones.Size = new System.Drawing.Size(80, 9);
            this.llTerminosYCondiciones.TabIndex = 1;
            this.llTerminosYCondiciones.TabStop = true;
            this.llTerminosYCondiciones.Text = "Terms and Conditions";
            this.llTerminosYCondiciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTerminosYCondiciones_LinkClicked_1);
            // 
            // llPrivacy
            // 
            this.llPrivacy.AutoSize = true;
            this.llPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.llPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrivacy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llPrivacy.Location = new System.Drawing.Point(235, 282);
            this.llPrivacy.Name = "llPrivacy";
            this.llPrivacy.Size = new System.Drawing.Size(54, 9);
            this.llPrivacy.TabIndex = 2;
            this.llPrivacy.TabStop = true;
            this.llPrivacy.Text = "Privacy Policy";
            this.llPrivacy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPrivacy_LinkClicked_1);
            // 
            // ucPCSpeedUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llPrivacy);
            this.Controls.Add(this.llTerminosYCondiciones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucPCSpeedUp";
            this.Size = new System.Drawing.Size(500, 300);
            this.Load += new System.EventHandler(this.ucPCSpeedUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llTerminosYCondiciones;
        private System.Windows.Forms.LinkLabel llPrivacy;
    }
}
