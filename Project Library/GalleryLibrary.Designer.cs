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
            this.ContentWrapperFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ContentWrapperFlow
            // 
            this.ContentWrapperFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentWrapperFlow.Location = new System.Drawing.Point(0, 0);
            this.ContentWrapperFlow.Name = "ContentWrapperFlow";
            this.ContentWrapperFlow.Size = new System.Drawing.Size(596, 371);
            this.ContentWrapperFlow.TabIndex = 0;
            // 
            // GalleryLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 371);
            this.Controls.Add(this.ContentWrapperFlow);
            this.Name = "GalleryLibrary";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ContentWrapperFlow;

    }
}