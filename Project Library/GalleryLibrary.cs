using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public partial class GalleryLibrary : Form
    {
        public bool isAddGameOpen { get; set; }

        public GalleryLibrary()
        {
            InitializeComponent();
            PopulateLibrary();
            isAddGameOpen = false;
            BrowseForArtBtn.Hide();
        }

        private void PopulateLibrary()
        {
            List<GameLibrary> Games = (
                    from game in Program.libraryXML.Descendants(Program.GameElement)
                    select new GameLibrary(Int32.Parse(game.Attribute(Program.GameID).Value), game.Element(Program.GamePath).Value, game.Element(Program.GameName).Value, double.Parse(game.Element(Program.GameSize).Value), game.Element(Program.CoverArtPath).Value)
                ).ToList();
            foreach (GameLibrary game in Games)
            {
                AddGameToLibraryFlowPanel(game);
            }
        }

        public void UpdateBottomPanel(GameLibrary gameLibrary)
        {
            if(!BrowseForArtBtn.Visible)
            {
                BrowseForArtBtn.Visible = true;
            }
            gameNameLabel.Text = gameLibrary.gameName;
            sizeLabel.Text = gameLibrary.size.ToString() + " Bytes";
            gamePathLabel.Text = "Path " + gameLibrary.path;
            coverArtPathLabel.Text = gameLibrary.coverArtPath;
        }

        public void AddGameToLibraryFlowPanel(GameLibrary game)
        {
            GamePanel gamePanel = new GamePanel(game);
            gamePanel.gameCoverArt.Click += (sender, eventArgs) =>
                {
                    UpdateBottomPanel(gamePanel.gameLibrary);
                };
            GalleryPanel.Controls.Add(gamePanel);
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            if (!isAddGameOpen)
            {
                AddGame addGameForm = new AddGame();
                addGameForm.galleryLibraryForm = this;
                addGameForm.Show();
                isAddGameOpen = true;
            }
        }
    }
}
