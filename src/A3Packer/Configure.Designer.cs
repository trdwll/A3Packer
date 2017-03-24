/**
 * A3Packer - A GUI for Packing and Obfuscating Arma 3 missions licensed under MIT.
 * 
 * Copyright (c) 2017 Russ 'trdwll' Treadwell
 * License: MIT
 * 
 * 
 * Source is provided to this software because we believe users have a    
 * right to know exactly what a program is going to do before they run it. 
 * This also allows you to audit the software for security holes.          
 * 
 */
namespace A3Packer
{
    partial class Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configure));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtObfuSQFToken = new System.Windows.Forms.TextBox();
            this.chkToken = new System.Windows.Forms.CheckBox();
            this.txtObfuSQFPath = new System.Windows.Forms.TextBox();
            this.txtPBOManagerPath = new System.Windows.Forms.TextBox();
            this.btnBrowseObfuscator = new System.Windows.Forms.Button();
            this.btnBrowsePacker = new System.Windows.Forms.Button();
            this.lblObfuSQFLink = new System.Windows.Forms.LinkLabel();
            this.lblPBOManagerLocation = new System.Windows.Forms.Label();
            this.lblObfuSQFLocation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(362, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(6, 41);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(85, 13);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "ObfuSQF Token";
            // 
            // txtObfuSQFToken
            // 
            this.txtObfuSQFToken.Location = new System.Drawing.Point(123, 38);
            this.txtObfuSQFToken.Name = "txtObfuSQFToken";
            this.txtObfuSQFToken.Size = new System.Drawing.Size(289, 20);
            this.txtObfuSQFToken.TabIndex = 3;
            // 
            // chkToken
            // 
            this.chkToken.AutoSize = true;
            this.chkToken.Location = new System.Drawing.Point(330, 64);
            this.chkToken.Name = "chkToken";
            this.chkToken.Size = new System.Drawing.Size(82, 17);
            this.chkToken.TabIndex = 4;
            this.chkToken.Text = "Hide Token";
            this.chkToken.UseVisualStyleBackColor = true;
            this.chkToken.CheckedChanged += new System.EventHandler(this.chkToken_CheckedChanged);
            // 
            // txtObfuSQFPath
            // 
            this.txtObfuSQFPath.Location = new System.Drawing.Point(123, 13);
            this.txtObfuSQFPath.Name = "txtObfuSQFPath";
            this.txtObfuSQFPath.ReadOnly = true;
            this.txtObfuSQFPath.Size = new System.Drawing.Size(256, 20);
            this.txtObfuSQFPath.TabIndex = 1;
            // 
            // txtPBOManagerPath
            // 
            this.txtPBOManagerPath.Location = new System.Drawing.Point(140, 13);
            this.txtPBOManagerPath.Name = "txtPBOManagerPath";
            this.txtPBOManagerPath.ReadOnly = true;
            this.txtPBOManagerPath.Size = new System.Drawing.Size(239, 20);
            this.txtPBOManagerPath.TabIndex = 5;
            // 
            // btnBrowseObfuscator
            // 
            this.btnBrowseObfuscator.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseObfuscator.Image")));
            this.btnBrowseObfuscator.Location = new System.Drawing.Point(385, 13);
            this.btnBrowseObfuscator.Name = "btnBrowseObfuscator";
            this.btnBrowseObfuscator.Size = new System.Drawing.Size(25, 23);
            this.btnBrowseObfuscator.TabIndex = 2;
            this.btnBrowseObfuscator.UseVisualStyleBackColor = true;
            this.btnBrowseObfuscator.Click += new System.EventHandler(this.btnBrowseObfuscator_Click);
            // 
            // btnBrowsePacker
            // 
            this.btnBrowsePacker.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowsePacker.Image")));
            this.btnBrowsePacker.Location = new System.Drawing.Point(383, 10);
            this.btnBrowsePacker.Name = "btnBrowsePacker";
            this.btnBrowsePacker.Size = new System.Drawing.Size(25, 23);
            this.btnBrowsePacker.TabIndex = 6;
            this.btnBrowsePacker.UseVisualStyleBackColor = true;
            this.btnBrowsePacker.Click += new System.EventHandler(this.btnBrowsePacker_Click);
            // 
            // lblObfuSQFLink
            // 
            this.lblObfuSQFLink.AutoSize = true;
            this.lblObfuSQFLink.Location = new System.Drawing.Point(6, 61);
            this.lblObfuSQFLink.Name = "lblObfuSQFLink";
            this.lblObfuSQFLink.Size = new System.Drawing.Size(157, 13);
            this.lblObfuSQFLink.TabIndex = 10;
            this.lblObfuSQFLink.TabStop = true;
            this.lblObfuSQFLink.Text = "Don\'t have an ObfuSQF token?";
            this.lblObfuSQFLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblObfuSQFLink_LinkClicked);
            // 
            // lblPBOManagerLocation
            // 
            this.lblPBOManagerLocation.AutoSize = true;
            this.lblPBOManagerLocation.Location = new System.Drawing.Point(6, 16);
            this.lblPBOManagerLocation.Name = "lblPBOManagerLocation";
            this.lblPBOManagerLocation.Size = new System.Drawing.Size(118, 13);
            this.lblPBOManagerLocation.TabIndex = 11;
            this.lblPBOManagerLocation.Text = "PBO Manager Location";
            // 
            // lblObfuSQFLocation
            // 
            this.lblObfuSQFLocation.AutoSize = true;
            this.lblObfuSQFLocation.Location = new System.Drawing.Point(6, 16);
            this.lblObfuSQFLocation.Name = "lblObfuSQFLocation";
            this.lblObfuSQFLocation.Size = new System.Drawing.Size(95, 13);
            this.lblObfuSQFLocation.TabIndex = 12;
            this.lblObfuSQFLocation.Text = "ObfuSQF Location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObfuSQFPath);
            this.groupBox1.Controls.Add(this.lblObfuSQFLocation);
            this.groupBox1.Controls.Add(this.lblObfuSQFLink);
            this.groupBox1.Controls.Add(this.btnBrowseObfuscator);
            this.groupBox1.Controls.Add(this.lblToken);
            this.groupBox1.Controls.Add(this.txtObfuSQFToken);
            this.groupBox1.Controls.Add(this.chkToken);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 85);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ObfuSQF Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPBOManagerPath);
            this.groupBox2.Controls.Add(this.lblPBOManagerLocation);
            this.groupBox2.Controls.Add(this.btnBrowsePacker);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 46);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PBO Manager Settings";
            // 
            // btnClearSettings
            // 
            this.btnClearSettings.Location = new System.Drawing.Point(12, 165);
            this.btnClearSettings.Name = "btnClearSettings";
            this.btnClearSettings.Size = new System.Drawing.Size(91, 23);
            this.btnClearSettings.TabIndex = 7;
            this.btnClearSettings.Text = "Clear Settings";
            this.btnClearSettings.UseVisualStyleBackColor = true;
            this.btnClearSettings.Click += new System.EventHandler(this.btnClearSettings_Click);
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 200);
            this.Controls.Add(this.btnClearSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configure_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtObfuSQFToken;
        private System.Windows.Forms.CheckBox chkToken;
        private System.Windows.Forms.TextBox txtObfuSQFPath;
        private System.Windows.Forms.TextBox txtPBOManagerPath;
        private System.Windows.Forms.Button btnBrowseObfuscator;
        private System.Windows.Forms.Button btnBrowsePacker;
        private System.Windows.Forms.LinkLabel lblObfuSQFLink;
        private System.Windows.Forms.Label lblPBOManagerLocation;
        private System.Windows.Forms.Label lblObfuSQFLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearSettings;
    }
}