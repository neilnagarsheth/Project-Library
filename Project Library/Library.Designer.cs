namespace Project_Library
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UpperHalfPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BrowsePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AbsolutePathPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AbosolutePathLabel = new System.Windows.Forms.Label();
            this.GameLibraryListView = new System.Windows.Forms.ListView();
            this.GameNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrowseForGames = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.UpperHalfPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.BrowsePanel.SuspendLayout();
            this.AbsolutePathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.UpperHalfPanel);
            this.flowLayoutPanel1.Controls.Add(this.GameLibraryListView);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(547, 295);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UpperHalfPanel
            // 
            this.UpperHalfPanel.Controls.Add(this.TitlePanel);
            this.UpperHalfPanel.Controls.Add(this.BrowsePanel);
            this.UpperHalfPanel.Location = new System.Drawing.Point(3, 3);
            this.UpperHalfPanel.Name = "UpperHalfPanel";
            this.UpperHalfPanel.Size = new System.Drawing.Size(544, 99);
            this.UpperHalfPanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(541, 39);
            this.TitlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(273, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Click Browse to add a game to your library";
            // 
            // BrowsePanel
            // 
            this.BrowsePanel.Controls.Add(this.BrowseButton);
            this.BrowsePanel.Controls.Add(this.AbsolutePathPanel);
            this.BrowsePanel.Location = new System.Drawing.Point(3, 48);
            this.BrowsePanel.Name = "BrowsePanel";
            this.BrowsePanel.Size = new System.Drawing.Size(541, 39);
            this.BrowsePanel.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Location = new System.Drawing.Point(3, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(87, 36);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // AbsolutePathPanel
            // 
            this.AbsolutePathPanel.Controls.Add(this.AbosolutePathLabel);
            this.AbsolutePathPanel.Location = new System.Drawing.Point(96, 3);
            this.AbsolutePathPanel.Name = "AbsolutePathPanel";
            this.AbsolutePathPanel.Size = new System.Drawing.Size(434, 36);
            this.AbsolutePathPanel.TabIndex = 2;
            // 
            // AbosolutePathLabel
            // 
            this.AbosolutePathLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AbosolutePathLabel.AutoSize = true;
            this.AbosolutePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbosolutePathLabel.Location = new System.Drawing.Point(10, 10);
            this.AbosolutePathLabel.Margin = new System.Windows.Forms.Padding(10);
            this.AbosolutePathLabel.Name = "AbosolutePathLabel";
            this.AbosolutePathLabel.Size = new System.Drawing.Size(0, 15);
            this.AbosolutePathLabel.TabIndex = 1;
            // 
            // GameLibraryListView
            // 
            this.GameLibraryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameNameColumn,
            this.PathColumn,
            this.FileSizeColumn});
            this.GameLibraryListView.Location = new System.Drawing.Point(3, 108);
            this.GameLibraryListView.Name = "GameLibraryListView";
            this.GameLibraryListView.Size = new System.Drawing.Size(544, 175);
            this.GameLibraryListView.TabIndex = 1;
            this.GameLibraryListView.UseCompatibleStateImageBehavior = false;
            this.GameLibraryListView.View = System.Windows.Forms.View.Details;
            this.GameLibraryListView.DoubleClick += new System.EventHandler(this.GameLibraryListView_DoubleClick);
            // 
            // GameNameColumn
            // 
            this.GameNameColumn.Text = "Game";
            this.GameNameColumn.Width = 100;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Path";
            this.PathColumn.Width = 300;
            // 
            // FileSizeColumn
            // 
            this.FileSizeColumn.Text = "Size";
            this.FileSizeColumn.Width = 100;
            // 
            // BrowseForGames
            // 
            this.BrowseForGames.FileName = "openFileDialog1";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 319);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Library";
            this.Text = "Library";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.UpperHalfPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.BrowsePanel.ResumeLayout(false);
            this.AbsolutePathPanel.ResumeLayout(false);
            this.AbsolutePathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel UpperHalfPanel;
        private System.Windows.Forms.FlowLayoutPanel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel BrowsePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label AbosolutePathLabel;
        private System.Windows.Forms.FlowLayoutPanel AbsolutePathPanel;
        private System.Windows.Forms.OpenFileDialog BrowseForGames;
        private System.Windows.Forms.ListView GameLibraryListView;
        private System.Windows.Forms.ColumnHeader GameNameColumn;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.ColumnHeader FileSizeColumn;


    }
}

