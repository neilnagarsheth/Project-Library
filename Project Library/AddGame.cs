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
    public partial class AddGame : Form
    {
        public GalleryLibrary galleryLibraryForm;
        private GameLibraryController gameLibraryController;

        public AddGame()
        {
            gameLibraryController = new GameLibraryController();
            InitializeComponent();
        }

        private void ManualAddBtn_Click(object sender, EventArgs e)
        {
            bool validFile = false;
            DialogResult result;
            while (!validFile)
            {
                result = BrowseForGames.ShowDialog();
                if (result.Equals(DialogResult.OK) && Path.GetExtension(BrowseForGames.FileName).Equals(".exe"))
                {
                    validFile = true;
                    GameLibrary game = new GameLibrary(BrowseForGames.FileName, Path.GetFileNameWithoutExtension(BrowseForGames.FileName), new System.IO.FileInfo(BrowseForGames.FileName).Length, "");
                    gameLibraryController.AddGame(game);
                    galleryLibraryForm.AddGameToLibraryFlowPanel(game);
                    galleryLibraryForm.isAddGameOpen = false;
                    Close();
                }
                else if (result.Equals(DialogResult.Cancel))
                {
                    break;
                }
                else
                {
                    if (MessageBox.Show("Invalid file, do you wish to try and find the right file again?", "Invalid File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.No))
                    {
                        break;
                    }
                }
            }
        }
    }
}
