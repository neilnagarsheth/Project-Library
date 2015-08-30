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
        private Label nameOfGame;
        private PictureBox gameCoverArt;

        public GamePanel(GameLibrary gameLibrary)
        {
            this.gameLibrary = gameLibrary;
            Margin = new Padding(3);
            Size = new Size(200,300);
            BackColor = Color.Gray;
            SetLabel();
            SetImage();
        }

        private void SetLabel()
        {
            nameOfGame = new Label();
            nameOfGame.Text = gameLibrary.gameName;
            nameOfGame.Anchor = AnchorStyles.None;
            this.Controls.Add(nameOfGame);
            nameOfGame.Location = new Point((nameOfGame.Parent.ClientSize.Width / 2) - nameOfGame.Width, nameOfGame.Parent.ClientSize.Height - 15);
        }

        private void SetImage()
        {
            gameCoverArt = new PictureBox();
            gameCoverArt.Size = new Size(200, 280);
            if (!gameLibrary.coverArtPath.Equals(String.Empty))
            {
                gameCoverArt.Image = new Bitmap(gameLibrary.coverArtPath);
            }
            gameCoverArt.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(gameCoverArt);
        }

    }
}
