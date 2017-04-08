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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Load settings here?
            chkRememberProject.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.LastProjectLocation);

            btnObfuscate.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.ObfuSQFLocation) && 
                !string.IsNullOrEmpty(Properties.Settings.Default.ObfuSQFToken);
            btnPackPBO.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.PBOManagerLocation);
        }

        private string projectPath = ""; // Set a project path string so we can remember it later and store it if needed

        // Just reuse these?! :D
        private FolderBrowserDialog fbd = new FolderBrowserDialog();
        private SaveFileDialog sfd = new SaveFileDialog()
        {
            Title = "Save you PBO Mission File",
            Filter = "PBO File (*.pbo)|*.pbo"
        };

        private void ExecuteCLI(string application, string args, bool displayWindow = false)
        {
            Text = "Please Wait";

            Process process = new Process();
            process.EnableRaisingEvents = true;
            process.StartInfo.WindowStyle = displayWindow ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = application;
            process.StartInfo.Arguments = args;

            try
            {
                process.Start();
                process.WaitForExit();

                MessageBox.Show($"Saved mission to {sfd.FileName}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text = "A3Packer";
            }
            catch (Exception ex) // Since this can throw a few exceptions lets default to just Exception
            {
                MessageBox.Show($"Something went wrong?!?? \n{ex.Message}", "idk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Mission file wasn't saved! Please try again!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            process.Close();
            process.Dispose();
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            MessageBox.Show($"Saved mission to {sfd.FileName}");
        }

        private void btnPackPBO_Click(object sender, EventArgs e)
        {
            chkRememberProject.Enabled ^= string.IsNullOrEmpty(projectPath); // Toggle the Remember Project checkbox

            string args = ""; // Save the args so we can execute PBO Manager later

            // If you don't want to save the last project then choose another one
            if (!chkRememberProject.Checked)
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    args = $"-pack {fbd.SelectedPath}";
                    projectPath = fbd.SelectedPath; // Set the project path here so we can use it elsewhere
                }

                fbd.Dispose();
            }
            else
            {
                args = $"-pack {Properties.Settings.Default.LastProjectLocation}";
            }
            
            if (!string.IsNullOrEmpty(fbd.SelectedPath) 
                || !string.IsNullOrEmpty(Properties.Settings.Default.LastProjectLocation))
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // TODO: Save the mission to x location and backup the previous pbo if a pbo exists with the same name

                    ExecuteCLI(Properties.Settings.Default.PBOManagerLocation, $"{args} {sfd.FileName}");
                }

                sfd.Dispose();
            }
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            Configure cfg = new Configure();
            cfg.ShowDialog();
        }

        private void btnObfuscate_Click(object sender, EventArgs e)
        {
            chkRememberProject.Enabled ^= string.IsNullOrEmpty(projectPath); // Toggle the Remember Project checkbox

            string args = ""; // Save the args so we can execute PBO Manager later

            // If you don't want to save the last project then choose another one
            if (!chkRememberProject.Checked)
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    args = $"-input={fbd.SelectedPath}";
                    projectPath = fbd.SelectedPath; // Set the project path here so we can use it elsewhere
                }

                fbd.Dispose();
            }
            else
            {
                args = $"-input={Properties.Settings.Default.LastProjectLocation}";
            }

            if (!string.IsNullOrEmpty(fbd.SelectedPath) 
                || !string.IsNullOrEmpty(Properties.Settings.Default.LastProjectLocation) 
                && !string.IsNullOrEmpty(Properties.Settings.Default.ObfuSQFToken)) // We don't really need this check here as we disable the buttons if it's null
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // TODO: Save the mission to x location and backup the previous pbo if a pbo exists with the same name

                    ExecuteCLI(Properties.Settings.Default.ObfuSQFLocation, 
                        $"-token={Properties.Settings.Default.ObfuSQFToken} \"{args}\" \"-output={sfd.FileName}\"");
                }

                sfd.Dispose();
            }
        }

        private void chkRememberProject_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberProject.Checked)
            {
                if (!string.IsNullOrEmpty(projectPath))
                {
                    Properties.Settings.Default["LastProjectLocation"] = projectPath; // Store the last project path in the settings
                }
            }
            else
            {
                Properties.Settings.Default["LastProjectLocation"] = ""; // Clear the last project path
            }

            Properties.Settings.Default.Save(); // Save the setting when we toggle it
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save(); // Save all settings before we close the application
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A3Packer \nCreated By: Russ 'trdwll' Treadwell \nBuild: 1.0\n\nwww.trdwll.com \nDonate? Email me russ@trdwll.com", 
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
