using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_Library
{
    public static class Program
    {
        public static int libraryID;
        public static XDocument libraryXML;
        public const String XMLFileName = "GameLibrary.xml";
        public const String RootXMLName = "Games";
        public const String IDSize = "Size";

        public const String GameElement = "Game";
        public const String GameID = "id";
        public const String GamePath = "Path";
        public const String GameName = "Name";
        public const String GameSize = "GameSize";



        private static void CheckXMLFile()
        {
            if (File.Exists(XMLFileName))
            {
                libraryXML = XDocument.Load(XMLFileName);
                libraryID = Int32.Parse(libraryXML.Document.Element(RootXMLName).Attribute(IDSize).Value.ToString());
            }
            else
            {
                CreateXMLTable();
            }
        }

        private static void CreateXMLTable()
        {
            libraryID = 0;
            libraryXML = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), 
                                       new XComment("GameLibrary"), 
                                       new XElement(RootXMLName, new XAttribute(IDSize, libraryID)));
            libraryXML.Save(XMLFileName);
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckXMLFile();
            Application.Run(new Library());
        }
    }
}
