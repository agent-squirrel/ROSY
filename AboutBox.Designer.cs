namespace ROSY
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.sluglabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(98, 172);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 27);
            this.okbutton.TabIndex = 0;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(38, 14);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(195, 40);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Copyright Adam Heathcote \r\n2014 - 2016";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sluglabel
            // 
            this.sluglabel.AutoSize = true;
            this.sluglabel.Location = new System.Drawing.Point(56, 57);
            this.sluglabel.Name = "sluglabel";
            this.sluglabel.Size = new System.Drawing.Size(168, 20);
            this.sluglabel.TabIndex = 2;
            this.sluglabel.Text = "OSIRiS Recovery System";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionlabel.Location = new System.Drawing.Point(29, 85);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(217, 62);
            this.descriptionlabel.TabIndex = 5;
            this.descriptionlabel.Text = "ROSY is a tool for recovering a \r\nlive system when OSIRiS has \r\nfailed to be run." +
    "";
            this.descriptionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(25, 148);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(221, 20);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "labelVersion";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(270, 204);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.sluglabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.okbutton);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label sluglabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.Label labelVersion;
    }
}
