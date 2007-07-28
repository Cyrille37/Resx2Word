using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Data;
using System.IO;
using System.Resources;
using System.Xml;

namespace ResxEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(args));
        }
    }
}