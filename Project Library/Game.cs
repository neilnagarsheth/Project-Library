using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class Game
    {
        public int id { get; set; }
        public string path { get; set; }
        public string gameName { get; set; }
        public long size { get; set; }
        public string coverArtPath { get; set; }
        public Game(string path, string gameName, long size, string coverArtPath)
        {
            id = ++Program.libraryID;
            this.path = path;
            this.gameName = gameName;
            this.size = size;
            this.coverArtPath = coverArtPath;
        }

        public Game(int id, string path, string gameName, long size, string coverArtPath) 
        {
            this.id = id;
            this.path = path;
            this.gameName = gameName;
            this.size = size;
            this.coverArtPath = coverArtPath;
        }
    }
}
