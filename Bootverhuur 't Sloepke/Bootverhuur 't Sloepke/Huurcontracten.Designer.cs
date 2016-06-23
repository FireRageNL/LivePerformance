namespace Bootverhuur__t_Sloepke
{
    partial class Huurcontracten
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
            this.lbHuurcontracten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHuurcontracten
            // 
            this.lbHuurcontracten.FormattingEnabled = true;
            this.lbHuurcontracten.Location = new System.Drawing.Point(13, 13);
            this.lbHuurcontracten.Name = "lbHuurcontracten";
            this.lbHuurcontracten.Size = new System.Drawing.Size(554, 433);
            this.lbHuurcontracten.TabIndex = 0;
            // 
            // Huurcontracten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 458);
            this.Controls.Add(this.lbHuurcontracten);
            this.Name = "Huurcontracten";
            this.Text = "Huurcontracten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHuurcontracten;
    }
}