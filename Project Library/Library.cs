using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class Library : Form
    {
        private GameLibraryController gameLibraryController;

        public Library()
        {
            InitializeComponent();
            gameLibraryController = new GameLibraryController();
            PopulateGameLibrary();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            bool validFile = false;
            DialogResult result;
            while(!validFile)
            {
                result = BrowseForGames.ShowDialog();
                if(result.Equals(DialogResult.OK) && Path.GetExtension(BrowseForGames.FileName).Equals(".exe"))
                {
                    validFile = true;
                    GameLibrary game = new GameLibrary(BrowseForGames.FileName, Path.GetFileName(BrowseForGames.FileName), new System.IO.FileInfo(BrowseForGames.FileName).Length, "");
                    gameLibraryController.AddGame(game);
                    AbosolutePathLabel.Text = BrowseForGames.FileName;
                    AddGameToLibraryListView(game);
                }
                else if(result.Equals(DialogResult.Cancel))
                {
                    break;
                }
                else
                {
                    if(MessageBox.Show("Invalid file, do you wish to try and find the right file again?", "Invalid File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.No))
                    {
                        break;
                    }
                }
            }
        }

        private void GameLibraryListView_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to launch this application?", "Launch Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                System.Diagnostics.Process.Start(GameLibraryListView.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void PopulateGameLibrary()
        {
            List<GameLibrary> Games = (
                    from game in Program.libraryXML.Descendants(Program.GameElement)
                    select new GameLibrary(Int32.Parse(game.Attribute(Program.GameID).Value), game.Element(Program.GamePath).Value, game.Element(Program.GameName).Value, double.Parse(game.Element(Program.GameSize).Value), game.Element(Program.CoverArtPath).Value)
                ).ToList();
            foreach (GameLibrary game in Games)
            {
                AddGameToLibraryListView(game);
            }
        }

        private void AddGameToLibraryListView(GameLibrary game)
        {
            ListViewItem item = new ListViewItem(new string[] { game.gameName, game.path, game.size.ToString() });
            GameLibraryListView.Items.Add(item);
        }

    }
}
