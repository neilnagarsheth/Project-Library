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
        private GamePanel activePanel;
        private GameLibraryController gameLibraryController;

        public GalleryLibrary()
        {
            InitializeComponent();
            PopulateLibrary();
            BrowseForArtBtn.Hide();
            activePanel = null;
            gameLibraryController = new GameLibraryController();
        }

        private void PopulateLibrary()
        {
            List<Game> Games = (
                    from game in Program.libraryXML.Descendants(Program.GameElement)
                    select new Game(Int32.Parse(game.Attribute(Program.GameID).Value), game.Element(Program.GamePath).Value, game.Element(Program.GameName).Value, long.Parse(game.Element(Program.GameSize).Value), game.Element(Program.CoverArtPath).Value)
                ).ToList();
            foreach (Game game in Games)
            {
                AddGameToLibraryFlowPanel(game);
            }
        }

        public void AddGameToLibraryFlowPanel(Game game)
        {
            GamePanel gamePanel = new GamePanel(game);
            gamePanel.gameCoverArt.Click += (sender, eventArgs) =>
                {
                    activePanel = gamePanel;
                    UpdateBottomPanel(gamePanel.game);
                };
            gamePanel.gameCoverArt.DoubleClick += (sender, eventArgs) =>
                {
                    System.Diagnostics.Process.Start(gamePanel.game.path);
                };
            GalleryPanel.Controls.Add(gamePanel);
        }

        public void UpdateBottomPanel(Game game)
        {
            if (!BrowseForArtBtn.Visible)
            {
                BrowseForArtBtn.Visible = true;
            }
            gameNameLabel.Text = game.gameName;
            sizeLabel.Text = game.size.ToString() + " Bytes";
            gamePathLabel.Text = "Path " + game.path;
            coverArtPathLabel.Text = game.coverArtPath;
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            AddGame addGameForm = new AddGame();
            addGameForm.galleryLibraryForm = this;
            addGameForm.ShowDialog();
        }

        private void BrowseForArtBtn_Click(object sender, EventArgs e)
        {
            if(activePanel != null)
            {
                BrowseForArt.Filter = "Images(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
                DialogResult result = BrowseForArt.ShowDialog();
                if(result.Equals(DialogResult.OK))
                {
                    activePanel.game.coverArtPath = BrowseForArt.FileName;
                    gameLibraryController.UpdateGame(activePanel.game);
                    activePanel.SetImage();
                    activePanel.gameCoverArt.Refresh();
                    coverArtPathLabel.Text = activePanel.game.coverArtPath;
                }
            }
        }
    }
}
