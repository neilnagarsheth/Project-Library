using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class GameLibrary
    {
        public int id { get; set; }
        public string path { get; set; }
        public string gameName { get; set; }
        public double size { get; set; }
        public string coverArtPath { get; set; }
        public GameLibrary(string path, string gameName, double size, string coverArtPath)
        {
            id = ++Program.libraryID;
            this.path = path;
            this.gameName = gameName;
            this.size = size;
            this.coverArtPath = coverArtPath;
        }

        public GameLibrary(int id, string path, string gameName, double size, string coverArtPath) 
        {
            this.id = id;
            this.path = path;
            this.gameName = gameName;
            this.size = size;
            this.coverArtPath = coverArtPath;
        }
    }
}
