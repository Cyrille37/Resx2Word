// Resx2word Copyright (C) 2006 - 2007  Joannès Vermorel (www.vermorel.com)
// This program comes with ABSOLUTELY NO WARRANTY.
// This is free software, and you are welcome to redistribute it
// under the conditions defined by the GPL 3 open-source license.

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace Word2resx
{
    class Program
    {
        static string usage = @"
USAGE: word2resx InputWORD OutputRESX

Where
    - InputWORD: the path of the Ms Word document.
    - OutputRESX: the path of the RESX document.
";

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Write(usage);
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Cannot found the input Microsoft Word document.");
                return;
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream xsltStream = assembly.GetManifestResourceStream("Word2resx.word2resx.xsl");

            // Performing transformation
            XslCompiledTransform xslt = new XslCompiledTransform(false);
            xslt.Load(new XmlTextReader(xsltStream));

            XmlReader resxReader = new XmlTextReader(args[0]);


            FileInfo output = new FileInfo(args[1]);
            StreamWriter outputStream = output.CreateText();

            xslt.Transform(resxReader, null, outputStream);

            outputStream.Close();
        }
    }
}
