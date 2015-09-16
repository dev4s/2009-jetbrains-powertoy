namespace InstallProgramForJetBrainsPowerToy
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.InstallAllVs2008 = new System.Windows.Forms.Button();
            this.InstallAllVs2010 = new System.Windows.Forms.Button();
            this.UninstallAllVs2010 = new System.Windows.Forms.Button();
            this.UninstallAllVs2008 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(12, 42);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(323, 20);
            this.PathTextBox.TabIndex = 5;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(336, 40);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(81, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // InstallAllVs2008
            // 
            this.InstallAllVs2008.Enabled = false;
            this.InstallAllVs2008.Location = new System.Drawing.Point(12, 68);
            this.InstallAllVs2008.Name = "InstallAllVs2008";
            this.InstallAllVs2008.Size = new System.Drawing.Size(405, 23);
            this.InstallAllVs2008.TabIndex = 1;
            this.InstallAllVs2008.Text = "Install All Programs For VS 2008";
            this.InstallAllVs2008.UseVisualStyleBackColor = true;
            this.InstallAllVs2008.Click += new System.EventHandler(this.InstallAllVs2008_Click);
            // 
            // InstallAllVs2010
            // 
            this.InstallAllVs2010.Enabled = false;
            this.InstallAllVs2010.Location = new System.Drawing.Point(12, 97);
            this.InstallAllVs2010.Name = "InstallAllVs2010";
            this.InstallAllVs2010.Size = new System.Drawing.Size(405, 23);
            this.InstallAllVs2010.TabIndex = 2;
            this.InstallAllVs2010.Text = "Install All Programs For VS 2010";
            this.InstallAllVs2010.UseVisualStyleBackColor = true;
            this.InstallAllVs2010.Click += new System.EventHandler(this.InstallAllVs2010_Click);
            // 
            // UninstallAllVs2010
            // 
            this.UninstallAllVs2010.Enabled = false;
            this.UninstallAllVs2010.Location = new System.Drawing.Point(12, 155);
            this.UninstallAllVs2010.Name = "UninstallAllVs2010";
            this.UninstallAllVs2010.Size = new System.Drawing.Size(405, 23);
            this.UninstallAllVs2010.TabIndex = 4;
            this.UninstallAllVs2010.Text = "Uninstall All Programs For VS 2010";
            this.UninstallAllVs2010.UseVisualStyleBackColor = true;
            this.UninstallAllVs2010.Click += new System.EventHandler(this.UninstallAllVs2010_Click);
            // 
            // UninstallAllVs2008
            // 
            this.UninstallAllVs2008.Enabled = false;
            this.UninstallAllVs2008.Location = new System.Drawing.Point(12, 126);
            this.UninstallAllVs2008.Name = "UninstallAllVs2008";
            this.UninstallAllVs2008.Size = new System.Drawing.Size(405, 23);
            this.UninstallAllVs2008.TabIndex = 3;
            this.UninstallAllVs2008.Text = "Uninstall All Programs For VS 2008";
            this.UninstallAllVs2008.UseVisualStyleBackColor = true;
            this.UninstallAllVs2008.Click += new System.EventHandler(this.UninstallAllVs2008_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(405, 23);
            this.progressBar.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 187);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.UninstallAllVs2010);
            this.Controls.Add(this.UninstallAllVs2008);
            this.Controls.Add(this.InstallAllVs2010);
            this.Controls.Add(this.InstallAllVs2008);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Install PowerToys From JetBrains";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button InstallAllVs2008;
        private System.Windows.Forms.Button InstallAllVs2010;
        private System.Windows.Forms.Button UninstallAllVs2010;
        private System.Windows.Forms.Button UninstallAllVs2008;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

