using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Library
{
    public class GameLibraryController
    {
        public void AddGame(GameLibrary gameLibrary)
        {
            Program.libraryXML.Element(Program.RootXMLName).Add(
                        new XElement(Program.GameElement, new XAttribute(Program.GameID, gameLibrary.id),
                        new XElement(Program.GamePath, gameLibrary.path),
                        new XElement(Program.GameName, gameLibrary.gameName),
                        new XElement(Program.GameSize, gameLibrary.size)
                    )
                 );
            Program.libraryXML.Element(Program.RootXMLName).Attribute(Program.IDSize).SetValue(gameLibrary.id);
            Program.libraryXML.Save(Program.XMLFileName);
        }
    }
}
