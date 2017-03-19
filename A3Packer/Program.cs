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
using System.Windows.Forms;

namespace A3Packer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
