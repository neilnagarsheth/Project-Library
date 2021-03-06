﻿using System;
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
        public Game game { get; set; }
        public PictureBox gameCoverArt { get; set; }

        private Label nameOfGame;
        private Size imageSize;

        public GamePanel(Game gameLibrary)
        {
            this.game = gameLibrary;
            Margin = new Padding(10);
            Size = new Size(80,120);
            imageSize = new Size(80, 100);
            SetLabel();
            SetImage();
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void SetLabel()
        {
            nameOfGame = new Label();
            nameOfGame.Font = new Font(FontFamily.GenericSansSerif, 7.0f);
            nameOfGame.Text = game.gameName;
            nameOfGame.Anchor = AnchorStyles.None;
            this.Controls.Add(nameOfGame);
            nameOfGame.Location = new Point(0, nameOfGame.Parent.ClientSize.Height - 15);
        }

        public void SetImage()
        {
            if(gameCoverArt == null)
            {
                gameCoverArt = new PictureBox();
                gameCoverArt.Size = imageSize;
            }
            if (!game.coverArtPath.Equals(String.Empty))
            {
                gameCoverArt.Image = new Bitmap(game.coverArtPath);
                gameCoverArt.Image = new Bitmap(gameCoverArt.Image, imageSize);
            }
            this.Controls.Add(gameCoverArt);
        }
    }
}
