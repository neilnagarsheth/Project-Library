using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Library
{
    public class GamePanel : Panel
    {
        public GameLibrary gameLibrary { get; set; }
        public PictureBox gameCoverArt { get; set; }

        private Label nameOfGame;

        public GamePanel(GameLibrary gameLibrary)
        {
            this.gameLibrary = gameLibrary;
            Margin = new Padding(10);
            Size = new Size(80,120);
            SetLabel();
            SetImage();
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void SetLabel()
        {
            nameOfGame = new Label();
            nameOfGame.Font = new Font(FontFamily.GenericSansSerif, 7.0f);
            nameOfGame.Text = gameLibrary.gameName;
            nameOfGame.Anchor = AnchorStyles.None;
            this.Controls.Add(nameOfGame);
            nameOfGame.Location = new Point(0, nameOfGame.Parent.ClientSize.Height - 15);
        }

        private void SetImage()
        {
            gameCoverArt = new PictureBox();
            gameCoverArt.Size = new Size(80, 100);
            if (!gameLibrary.coverArtPath.Equals(String.Empty))
            {
                gameCoverArt.Image = new Bitmap(gameLibrary.coverArtPath);
            }
            this.Controls.Add(gameCoverArt);
        }

    }
}
