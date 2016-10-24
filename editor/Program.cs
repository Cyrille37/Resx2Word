// ResxEditor  Copyright (C) 2006 - 2007  Joannès Vermorel (www.vermorel.com)
// This program comes with ABSOLUTELY NO WARRANTY.
// This is free software, and you are welcome to redistribute it
// under the conditions defined by the GPL 3 open-source license.

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