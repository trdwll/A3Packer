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
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnPackPBO = new System.Windows.Forms.Button();
            this.btnObfuscate = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.chkRememberProject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPackPBO
            // 
            this.btnPackPBO.Enabled = false;
            this.btnPackPBO.Image = ((System.Drawing.Image)(resources.GetObject("btnPackPBO.Image")));
            this.btnPackPBO.Location = new System.Drawing.Point(12, 12);
            this.btnPackPBO.Name = "btnPackPBO";
            this.btnPackPBO.Size = new System.Drawing.Size(77, 52);
            this.btnPackPBO.TabIndex = 0;
            this.btnPackPBO.UseVisualStyleBackColor = true;
            this.btnPackPBO.Click += new System.EventHandler(this.btnPackPBO_Click);
            // 
            // btnObfuscate
            // 
            this.btnObfuscate.Enabled = false;
            this.btnObfuscate.Image = ((System.Drawing.Image)(resources.GetObject("btnObfuscate.Image")));
            this.btnObfuscate.Location = new System.Drawing.Point(95, 12);
            this.btnObfuscate.Name = "btnObfuscate";
            this.btnObfuscate.Size = new System.Drawing.Size(77, 52);
            this.btnObfuscate.TabIndex = 1;
            this.btnObfuscate.UseVisualStyleBackColor = true;
            this.btnObfuscate.Click += new System.EventHandler(this.btnObfuscate_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigure.Location = new System.Drawing.Point(178, 12);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnConfigure.TabIndex = 7;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(260, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(22, 22);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkRememberProject
            // 
            this.chkRememberProject.AutoSize = true;
            this.chkRememberProject.Enabled = false;
            this.chkRememberProject.Location = new System.Drawing.Point(178, 47);
            this.chkRememberProject.Name = "chkRememberProject";
            this.chkRememberProject.Size = new System.Drawing.Size(113, 17);
            this.chkRememberProject.TabIndex = 9;
            this.chkRememberProject.Text = "Remember Project";
            this.chkRememberProject.UseVisualStyleBackColor = true;
            this.chkRememberProject.CheckedChanged += new System.EventHandler(this.chkRememberProject_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 76);
            this.Controls.Add(this.chkRememberProject);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnObfuscate);
            this.Controls.Add(this.btnPackPBO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A3Packer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPackPBO;
        private System.Windows.Forms.Button btnObfuscate;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox chkRememberProject;
    }
}

