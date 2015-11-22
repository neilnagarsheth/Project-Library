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
        public void AddGame(Game game)
        {
            Program.libraryXML.Element(Program.RootXMLName).Add(
                        new XElement(Program.GameElement, new XAttribute(Program.GameID, game.id),
                        new XElement(Program.GamePath, game.path),
                        new XElement(Program.GameName, game.gameName),
                        new XElement(Program.GameSize, game.size),
                        new XElement(Program.CoverArtPath, game.coverArtPath)
                    )
                 );
            Program.libraryXML.Element(Program.RootXMLName).Attribute(Program.IDSize).SetValue(game.id);
            Program.libraryXML.Save(Program.XMLFileName);
        }

        public void UpdateGame(Game game)
        {
            var target = Program.libraryXML
                .Element(Program.RootXMLName)
                .Elements(Program.GameElement)
                .Where(e => e.Attribute(Program.GameID).Value.Equals(game.id.ToString()))
                .Single();
            target.Element(Program.GameName).Value = game.gameName;
            target.Element(Program.GamePath).Value = game.path;
            target.Element(Program.GameSize).Value = game.size.ToString();
            target.Element(Program.CoverArtPath).Value = game.coverArtPath;

            Program.libraryXML.Save(Program.XMLFileName);
        }
    }
}
