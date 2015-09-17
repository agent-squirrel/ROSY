namespace ROSY
{
    partial class ROSY_mainwindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROSY_mainwindow));
            this.about_button = new System.Windows.Forms.Button();
            this.runbutton = new System.Windows.Forms.Button();
            this.newusername = new System.Windows.Forms.TextBox();
            this.newuserlabel = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // about_button
            // 
            this.about_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_button.Location = new System.Drawing.Point(410, 12);
            this.about_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(74, 31);
            this.about_button.TabIndex = 1;
            this.about_button.Text = "About";
            this.tooltip.SetToolTip(this.about_button, "About ROSY");
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // runbutton
            // 
            this.runbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runbutton.Location = new System.Drawing.Point(210, 163);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(75, 32);
            this.runbutton.TabIndex = 3;
            this.runbutton.Text = "Run";
            this.tooltip.SetToolTip(this.runbutton, "Click here to begin the reset process");
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // newusername
            // 
            this.newusername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newusername.Location = new System.Drawing.Point(258, 132);
            this.newusername.MaxLength = 20;
            this.newusername.Name = "newusername";
            this.newusername.Size = new System.Drawing.Size(100, 27);
            this.newusername.TabIndex = 2;
            this.tooltip.SetToolTip(this.newusername, "Enter a new User Name for your New Account");
            // 
            // newuserlabel
            // 
            this.newuserlabel.AutoSize = true;
            this.newuserlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserlabel.Location = new System.Drawing.Point(133, 135);
            this.newuserlabel.Name = "newuserlabel";
            this.newuserlabel.Size = new System.Drawing.Size(119, 20);
            this.newuserlabel.TabIndex = 4;
            this.newuserlabel.Text = "New User Name:";
            this.tooltip.SetToolTip(this.newuserlabel, "Enter a new User Name for your New Account");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ROSY.Properties.Resources.rosy_logo_minature_fw;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ROSY_mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(495, 207);
            this.Controls.Add(this.newuserlabel);
            this.Controls.Add(this.newusername);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ROSY_mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROSY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button runbutton;
        private System.Windows.Forms.TextBox newusername;
        private System.Windows.Forms.Label newuserlabel;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

