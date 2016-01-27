namespace Area51VisualPatcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.multiplayerLabel = new System.Windows.Forms.Label();
            this.patchButton = new System.Windows.Forms.Button();
            this.area51FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aspectRatioBox = new System.Windows.Forms.ComboBox();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiplayerLabel
            // 
            this.multiplayerLabel.AutoSize = true;
            this.multiplayerLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayerLabel.Location = new System.Drawing.Point(61, 24);
            this.multiplayerLabel.Name = "multiplayerLabel";
            this.multiplayerLabel.Size = new System.Drawing.Size(220, 28);
            this.multiplayerLabel.TabIndex = 0;
            this.multiplayerLabel.Text = "Waiting to Patch";
            // 
            // patchButton
            // 
            this.patchButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchButton.Location = new System.Drawing.Point(30, 126);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(288, 74);
            this.patchButton.TabIndex = 2;
            this.patchButton.Text = "Patch Game";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // area51FileDialog
            // 
            this.area51FileDialog.FileName = "gameFileDialog";
            // 
            // aspectRatioBox
            // 
            this.aspectRatioBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspectRatioBox.FormattingEnabled = true;
            this.aspectRatioBox.Location = new System.Drawing.Point(53, 79);
            this.aspectRatioBox.Name = "aspectRatioBox";
            this.aspectRatioBox.Size = new System.Drawing.Size(239, 21);
            this.aspectRatioBox.TabIndex = 3;
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(353, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripMenuItem1,
            this.githubToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // twitterToolStripMenuItem1
            // 
            this.twitterToolStripMenuItem1.Name = "twitterToolStripMenuItem1";
            this.twitterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.twitterToolStripMenuItem1.Text = "Twitter";
            this.twitterToolStripMenuItem1.Click += new System.EventHandler(this.twitterToolStripMenuItem1_Click);
            // 
            // githubToolStripMenuItem1
            // 
            this.githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            this.githubToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.githubToolStripMenuItem1.Text = "Github";
            this.githubToolStripMenuItem1.Click += new System.EventHandler(this.githubToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 221);
            this.Controls.Add(this.aspectRatioBox);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.multiplayerLabel);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 260);
            this.MinimumSize = new System.Drawing.Size(369, 260);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area 51 Patcher";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label multiplayerLabel;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.OpenFileDialog area51FileDialog;
        private System.Windows.Forms.ComboBox aspectRatioBox;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem1;
    }
}

