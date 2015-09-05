namespace Project_Library
{
    partial class GalleryLibrary
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
            this.UpperFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddGameBtn = new System.Windows.Forms.Button();
            this.GalleryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.coverArtPathLabel = new System.Windows.Forms.Label();
            this.BrowseForArtBtn = new System.Windows.Forms.Button();
            this.gamePathLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.UpperFlowPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperFlowPanel
            // 
            this.UpperFlowPanel.Controls.Add(this.AddGameBtn);
            this.UpperFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperFlowPanel.Name = "UpperFlowPanel";
            this.UpperFlowPanel.Size = new System.Drawing.Size(626, 100);
            this.UpperFlowPanel.TabIndex = 0;
            // 
            // AddGameBtn
            // 
            this.AddGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGameBtn.Location = new System.Drawing.Point(10, 15);
            this.AddGameBtn.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.AddGameBtn.Name = "AddGameBtn";
            this.AddGameBtn.Size = new System.Drawing.Size(173, 62);
            this.AddGameBtn.TabIndex = 0;
            this.AddGameBtn.Text = "Add Game";
            this.AddGameBtn.UseVisualStyleBackColor = true;
            this.AddGameBtn.Click += new System.EventHandler(this.AddGameBtn_Click);
            // 
            // GalleryPanel
            // 
            this.GalleryPanel.AutoScroll = true;
            this.GalleryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GalleryPanel.Location = new System.Drawing.Point(0, 100);
            this.GalleryPanel.Name = "GalleryPanel";
            this.GalleryPanel.Size = new System.Drawing.Size(626, 346);
            this.GalleryPanel.TabIndex = 1;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.coverArtPathLabel);
            this.BottomPanel.Controls.Add(this.BrowseForArtBtn);
            this.BottomPanel.Controls.Add(this.gamePathLabel);
            this.BottomPanel.Controls.Add(this.sizeLabel);
            this.BottomPanel.Controls.Add(this.gameNameLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 379);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(626, 67);
            this.BottomPanel.TabIndex = 2;
            // 
            // coverArtPathLabel
            // 
            this.coverArtPathLabel.AutoSize = true;
            this.coverArtPathLabel.Location = new System.Drawing.Point(276, 39);
            this.coverArtPathLabel.Name = "coverArtPathLabel";
            this.coverArtPathLabel.Size = new System.Drawing.Size(0, 13);
            this.coverArtPathLabel.TabIndex = 4;
            // 
            // BrowseForArtBtn
            // 
            this.BrowseForArtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseForArtBtn.Location = new System.Drawing.Point(183, 34);
            this.BrowseForArtBtn.Name = "BrowseForArtBtn";
            this.BrowseForArtBtn.Size = new System.Drawing.Size(87, 23);
            this.BrowseForArtBtn.TabIndex = 3;
            this.BrowseForArtBtn.Text = "Browse for Art";
            this.BrowseForArtBtn.UseVisualStyleBackColor = true;
            // 
            // gamePathLabel
            // 
            this.gamePathLabel.AutoSize = true;
            this.gamePathLabel.Location = new System.Drawing.Point(180, 10);
            this.gamePathLabel.Name = "gamePathLabel";
            this.gamePathLabel.Size = new System.Drawing.Size(0, 13);
            this.gamePathLabel.TabIndex = 2;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 39);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(0, 13);
            this.sizeLabel.TabIndex = 1;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Location = new System.Drawing.Point(12, 10);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(0, 13);
            this.gameNameLabel.TabIndex = 0;
            // 
            // GalleryLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.GalleryPanel);
            this.Controls.Add(this.UpperFlowPanel);
            this.Name = "GalleryLibrary";
            this.Text = "Library";
            this.UpperFlowPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel UpperFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel GalleryPanel;
        private System.Windows.Forms.Button AddGameBtn;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label coverArtPathLabel;
        private System.Windows.Forms.Button BrowseForArtBtn;
        private System.Windows.Forms.Label gamePathLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label gameNameLabel;


    }
}