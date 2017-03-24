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
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace A3Packer
{
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();

            chkToken.Checked = true; // Enable for security purposes - even though it's just hiding the token lol

            // Load settings here

            if (!string.IsNullOrEmpty(Properties.Settings.Default.ObfuSQFLocation))
            {
                txtObfuSQFPath.Text = Properties.Settings.Default.ObfuSQFLocation;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ObfuSQFToken))
            {
                txtObfuSQFToken.Text = Properties.Settings.Default.ObfuSQFToken;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.PBOManagerLocation))
            {
                txtPBOManagerPath.Text = Properties.Settings.Default.PBOManagerLocation;
            }
        }


        // Master password to view the token??????
        
        private OpenFileDialog ofd = new OpenFileDialog()
        {
            Filter = "Executable Files (*.exe)|*.exe"
        };

        private void chkToken_CheckedChanged(object sender, EventArgs e)
        {
            txtObfuSQFToken.UseSystemPasswordChar = chkToken.Checked;
        }

        private void btnBrowsePacker_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open your PBO Manager binary!";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPBOManagerPath.Text = ofd.FileName;
                
                // Only update the path when you actually change it
                Properties.Settings.Default["PBOManagerLocation"] = ofd.FileName;
            }

            ofd.Dispose();
        }

        private void btnBrowseObfuscator_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open your ObfuSQF tool binary!";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtObfuSQFPath.Text = ofd.FileName;

                // Only update the path when you actually change it
                Properties.Settings.Default["ObfuSQFLocation"] = ofd.FileName;
            }

            ofd.Dispose();
        }

        private void lblObfuSQFLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://armaservices.maverick-apps.de/Products/Obfuscator/");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["ObfuSQFToken"] = txtObfuSQFToken.Text;

            Properties.Settings.Default.Save();
            Hide(); // Close was throwing a StackOverflowException so we'll fix it by using Hide instead
        }

        private void btnClearSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            Application.Restart(); // Restart the application so the settings are cleared properly
        }

        private void Configure_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Simply press the OK button rather than write a method or copy/paste the same code for the closing event
            btnOK.PerformClick(); 
        }
    }
}
