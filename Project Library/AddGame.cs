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
            BrowseForGames.Filter = "Executables|*.exe";
            DialogResult result = BrowseForGames.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                Game game = new Game(BrowseForGames.FileName, Path.GetFileNameWithoutExtension(BrowseForGames.FileName), GetFileSizeSumFromDirectory(BrowseForGames.FileName), "");
                gameLibraryController.AddGame(game);
                galleryLibraryForm.AddGameToLibraryFlowPanel(game);
                Close();
            }
        }

        private long GetFileSizeSumFromDirectory(string searchDirectory)
        {
            var files = Directory.EnumerateFiles(searchDirectory);
            var currentSize = (from file in files let fileInfo = new FileInfo(file) select fileInfo.Length).Sum();
            var directories = Directory.EnumerateDirectories(searchDirectory);
            var subDirSize = (from directory in directories select GetFileSizeSumFromDirectory(directory)).Sum();
            return currentSize + subDirSize;
        }
    }
}
