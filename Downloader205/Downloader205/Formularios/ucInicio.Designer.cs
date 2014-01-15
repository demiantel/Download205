namespace Downloader205.Formularios
{
    partial class ucInicio
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
            this.txtTerminosYCondiciones = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtTerminosYCondiciones
            // 
            this.txtTerminosYCondiciones.Location = new System.Drawing.Point(0, 40);
            this.txtTerminosYCondiciones.Name = "txtTerminosYCondiciones";
            this.txtTerminosYCondiciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtTerminosYCondiciones.Size = new System.Drawing.Size(489, 215);
            this.txtTerminosYCondiciones.TabIndex = 0;
            this.txtTerminosYCondiciones.Text = "";
            // 
            // ucInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtTerminosYCondiciones);
            this.Name = "ucInicio";
            this.Size = new System.Drawing.Size(489, 304);
            this.Load += new System.EventHandler(this.ucInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTerminosYCondiciones;

    }
}
