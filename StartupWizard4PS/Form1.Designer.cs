﻿namespace StartupWizard4PS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAVImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnProductie = new System.Windows.Forms.RadioButton();
            this.rBtnTest = new System.Windows.Forms.RadioButton();
            this.rBtnOntwikkel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnDev = new System.Windows.Forms.RadioButton();
            this.rBtnNoExpert = new System.Windows.Forms.RadioButton();
            this.rBtnConfig = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkClose = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAVImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.TitleText.Location = new System.Drawing.Point(127, 22);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(258, 29);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "Advanced Loginscreen";
            // 
            // OndertitelText
            // 
            this.OndertitelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OndertitelText.AutoSize = true;
            this.OndertitelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OndertitelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.OndertitelText.Location = new System.Drawing.Point(157, 58);
            this.OndertitelText.Name = "OndertitelText";
            this.OndertitelText.Size = new System.Drawing.Size(184, 20);
            this.OndertitelText.TabIndex = 2;
            this.OndertitelText.Text = "Microsoft Dynamics NAV";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnProductie);
            this.groupBox1.Controls.Add(this.rBtnTest);
            this.groupBox1.Controls.Add(this.rBtnOntwikkel);
            this.groupBox1.Location = new System.Drawing.Point(12, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select your server";
            // 
            // rBtnProductie
            // 
            this.rBtnProductie.AutoSize = true;
            this.rBtnProductie.Location = new System.Drawing.Point(19, 75);
            this.rBtnProductie.Name = "rBtnProductie";
            this.rBtnProductie.Size = new System.Drawing.Size(70, 17);
            this.rBtnProductie.TabIndex = 9;
            this.rBtnProductie.Text = "Productie";
            this.rBtnProductie.UseVisualStyleBackColor = true;
            this.rBtnProductie.CheckedChanged += new System.EventHandler(this.rBtnProductie_CheckedChanged);
            // 
            // rBtnTest
            // 
            this.rBtnTest.AutoSize = true;
            this.rBtnTest.Checked = true;
            this.rBtnTest.Location = new System.Drawing.Point(19, 52);
            this.rBtnTest.Name = "rBtnTest";
            this.rBtnTest.Size = new System.Drawing.Size(46, 17);
            this.rBtnTest.TabIndex = 8;
            this.rBtnTest.TabStop = true;
            this.rBtnTest.Text = "Test";
            this.rBtnTest.UseVisualStyleBackColor = true;
            this.rBtnTest.CheckedChanged += new System.EventHandler(this.rBtnTest_CheckedChanged);
            // 
            // rBtnOntwikkel
            // 
            this.rBtnOntwikkel.AutoSize = true;
            this.rBtnOntwikkel.Location = new System.Drawing.Point(19, 29);
            this.rBtnOntwikkel.Name = "rBtnOntwikkel";
            this.rBtnOntwikkel.Size = new System.Drawing.Size(72, 17);
            this.rBtnOntwikkel.TabIndex = 7;
            this.rBtnOntwikkel.Text = "Ontwikkel";
            this.rBtnOntwikkel.UseVisualStyleBackColor = true;
            this.rBtnOntwikkel.CheckedChanged += new System.EventHandler(this.rBtnOntwikkel_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRole);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select your role";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(18, 41);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(419, 21);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.CmbRole_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnDev);
            this.groupBox3.Controls.Add(this.rBtnNoExpert);
            this.groupBox3.Controls.Add(this.rBtnConfig);
            this.groupBox3.Location = new System.Drawing.Point(12, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expert mode";
            // 
            // rBtnDev
            // 
            this.rBtnDev.AutoSize = true;
            this.rBtnDev.Location = new System.Drawing.Point(18, 77);
            this.rBtnDev.Name = "rBtnDev";
            this.rBtnDev.Size = new System.Drawing.Size(259, 17);
            this.rBtnDev.TabIndex = 12;
            this.rBtnDev.Text = "I\'m a hardcore coder and want to be in Dev mode";
            this.rBtnDev.UseVisualStyleBackColor = true;
            // 
            // rBtnNoExpert
            // 
            this.rBtnNoExpert.AutoSize = true;
            this.rBtnNoExpert.Checked = true;
            this.rBtnNoExpert.Location = new System.Drawing.Point(18, 31);
            this.rBtnNoExpert.Name = "rBtnNoExpert";
            this.rBtnNoExpert.Size = new System.Drawing.Size(171, 17);
            this.rBtnNoExpert.TabIndex = 10;
            this.rBtnNoExpert.TabStop = true;
            this.rBtnNoExpert.Text = "Unfortunately, i\'m not an expert";
            this.rBtnNoExpert.UseVisualStyleBackColor = true;
            // 
            // rBtnConfig
            // 
            this.rBtnConfig.AutoSize = true;
            this.rBtnConfig.Location = new System.Drawing.Point(18, 54);
            this.rBtnConfig.Name = "rBtnConfig";
            this.rBtnConfig.Size = new System.Drawing.Size(299, 17);
            this.rBtnConfig.TabIndex = 11;
            this.rBtnConfig.Text = "I want to Configure everything, i need configuration modus";
            this.rBtnConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCompany);
            this.groupBox4.Location = new System.Drawing.Point(12, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select your company";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(18, 41);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(419, 21);
            this.cmbCompany.TabIndex = 0;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.CmbCompany_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(397, 557);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkClose
            // 
            this.chkClose.AutoSize = true;
            this.chkClose.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClose.Location = new System.Drawing.Point(333, 534);
            this.chkClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(120, 17);
            this.chkClose.TabIndex = 11;
            this.chkClose.Text = "Login screen sluiten";
            this.chkClose.UseVisualStyleBackColor = true;
            // 
            // Opstartkeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 592);
            this.Controls.Add(this.chkClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OndertitelText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.NAVImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Opstartkeuze";
            this.Text = "Advanced Loginscreen NAV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAVImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NAVImage;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label OndertitelText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnProductie;
        private System.Windows.Forms.RadioButton rBtnTest;
        private System.Windows.Forms.RadioButton rBtnOntwikkel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnDev;
        private System.Windows.Forms.RadioButton rBtnNoExpert;
        private System.Windows.Forms.RadioButton rBtnConfig;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkClose;
    }
}

