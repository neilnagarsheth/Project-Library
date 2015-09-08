namespace Project_Library
{
    partial class AddGame
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
            this.ManualAddBtn = new System.Windows.Forms.Button();
            this.AutoAddBtn = new System.Windows.Forms.Button();
            this.BrowseForGames = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ManualAddBtn
            // 
            this.ManualAddBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManualAddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManualAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualAddBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ManualAddBtn.Location = new System.Drawing.Point(15, 15);
            this.ManualAddBtn.Name = "ManualAddBtn";
            this.ManualAddBtn.Size = new System.Drawing.Size(404, 107);
            this.ManualAddBtn.TabIndex = 0;
            this.ManualAddBtn.Text = "Manually Add Game";
            this.ManualAddBtn.UseVisualStyleBackColor = false;
            this.ManualAddBtn.Click += new System.EventHandler(this.ManualAddBtn_Click);
            // 
            // AutoAddBtn
            // 
            this.AutoAddBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AutoAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoAddBtn.Location = new System.Drawing.Point(15, 163);
            this.AutoAddBtn.Name = "AutoAddBtn";
            this.AutoAddBtn.Size = new System.Drawing.Size(404, 105);
            this.AutoAddBtn.TabIndex = 1;
            this.AutoAddBtn.Text = "Automatically Find Games";
            this.AutoAddBtn.UseVisualStyleBackColor = true;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 283);
            this.Controls.Add(this.AutoAddBtn);
            this.Controls.Add(this.ManualAddBtn);
            this.MaximumSize = new System.Drawing.Size(450, 321);
            this.MinimumSize = new System.Drawing.Size(450, 321);
            this.Name = "AddGame";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Add A Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManualAddBtn;
        private System.Windows.Forms.Button AutoAddBtn;
        private System.Windows.Forms.OpenFileDialog BrowseForGames;
    }
}