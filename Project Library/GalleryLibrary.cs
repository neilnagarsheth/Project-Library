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
            List<GameLibrary> Games = (
                    from game in Program.libraryXML.Descendants(Program.GameElement)
                    select new GameLibrary(Int32.Parse(game.Attribute(Program.GameID).Value), game.Element(Program.GamePath).Value, game.Element(Program.GameName).Value, double.Parse(game.Element(Program.GameSize).Value), game.Element(Program.CoverArtPath).Value)
                ).ToList();
            foreach (GameLibrary game in Games)
            {
                AddGameToLibraryFlowPanel(game);
            }
        }

        public void AddGameToLibraryFlowPanel(GameLibrary game)
        {
            GamePanel gamePanel = new GamePanel(game);
            gamePanel.gameCoverArt.Click += (sender, eventArgs) =>
                {
                    activePanel = gamePanel;
                    UpdateBottomPanel(gamePanel.gameLibrary);
                };
            gamePanel.gameCoverArt.DoubleClick += (sender, eventArgs) =>
                {
                    System.Diagnostics.Process.Start(gamePanel.gameLibrary.path);
                };
            GalleryPanel.Controls.Add(gamePanel);
        }

        public void UpdateBottomPanel(GameLibrary gameLibrary)
        {
            if (!BrowseForArtBtn.Visible)
            {
                BrowseForArtBtn.Visible = true;
            }
            gameNameLabel.Text = gameLibrary.gameName;
            sizeLabel.Text = gameLibrary.size.ToString() + " Bytes";
            gamePathLabel.Text = "Path " + gameLibrary.path;
            coverArtPathLabel.Text = gameLibrary.coverArtPath;
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
                    activePanel.gameLibrary.coverArtPath = BrowseForArt.FileName;
                    gameLibraryController.UpdateGame(activePanel.gameLibrary);
                    activePanel.SetImage();
                    activePanel.gameCoverArt.Refresh();
                    coverArtPathLabel.Text = activePanel.gameLibrary.coverArtPath;
                }
            }
        }
    }
}
