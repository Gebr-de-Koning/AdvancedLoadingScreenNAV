namespace StartupWizard4PS
{
    partial class Opstartkeuze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opstartkeuze));
            this.TitleText = new System.Windows.Forms.Label();
            this.OndertitelText = new System.Windows.Forms.Label();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAVImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAVImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.TitleText.Location = new System.Drawing.Point(127, 22);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(255, 33);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "Advanced Loginscreen";
            // 
            // OndertitelText
            // 
            this.OndertitelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OndertitelText.AutoSize = true;
            this.OndertitelText.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OndertitelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.OndertitelText.Location = new System.Drawing.Point(157, 58);
            this.OndertitelText.Name = "OndertitelText";
            this.OndertitelText.Size = new System.Drawing.Size(185, 21);
            this.OndertitelText.TabIndex = 2;
            this.OndertitelText.Text = "Microsoft Dynamics NAV";
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.Location = new System.Drawing.Point(170, 116);
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.Size = new System.Drawing.Size(200, 26);
            this.ServerComboBox.TabIndex = 4;
            this.ServerComboBox.SelectedIndexChanged += new System.EventHandler(this.ServerComboBox_SelectedIndexChanged);
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ServerLabel.Location = new System.Drawing.Point(83, 112);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(81, 28);
            this.ServerLabel.TabIndex = 5;
            this.ServerLabel.Text = "Server:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StartupWizard4PS.Properties.Resources.GDKlogo_20160616_klein;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NAVImage
            // 
            this.NAVImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NAVImage.Image = global::StartupWizard4PS.Properties.Resources.microsoft_dynamics_nav;
            this.NAVImage.Location = new System.Drawing.Point(390, 7);
            this.NAVImage.Name = "NAVImage";
            this.NAVImage.Size = new System.Drawing.Size(82, 78);
            this.NAVImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NAVImage.TabIndex = 0;
            this.NAVImage.TabStop = false;
            // 
            // Opstartkeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.ServerComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OndertitelText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.NAVImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opstartkeuze";
            this.Text = "Advanced Loginscreen NAV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAVImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NAVImage;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label OndertitelText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Label ServerLabel;
    }
}

