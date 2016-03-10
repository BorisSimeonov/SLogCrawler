namespace SLogCrawler
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnStartLogCrawl = new System.Windows.Forms.Button();
            this.tbResultDestination = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.tbResultBox = new System.Windows.Forms.TextBox();
            this.controlPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.LightGray;
            this.controlPanel.Controls.Add(this.btnStartLogCrawl);
            this.controlPanel.Controls.Add(this.tbResultDestination);
            this.controlPanel.Controls.Add(this.tbFilePath);
            this.controlPanel.Controls.Add(this.btnSaveLocation);
            this.controlPanel.Controls.Add(this.btnLoadFile);
            this.controlPanel.Controls.Add(this.lblControlPanel);
            this.controlPanel.Location = new System.Drawing.Point(-6, -1);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(580, 270);
            this.controlPanel.TabIndex = 0;
            // 
            // btnStartLogCrawl
            // 
            this.btnStartLogCrawl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStartLogCrawl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartLogCrawl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartLogCrawl.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLogCrawl.ForeColor = System.Drawing.Color.Gold;
            this.btnStartLogCrawl.Location = new System.Drawing.Point(18, 197);
            this.btnStartLogCrawl.Name = "btnStartLogCrawl";
            this.btnStartLogCrawl.Size = new System.Drawing.Size(518, 60);
            this.btnStartLogCrawl.TabIndex = 5;
            this.btnStartLogCrawl.Text = "START CRAWL";
            this.btnStartLogCrawl.UseVisualStyleBackColor = false;
            this.btnStartLogCrawl.Click += new System.EventHandler(this.btnStartLogCrawl_Click);
            // 
            // tbResultDestination
            // 
            this.tbResultDestination.BackColor = System.Drawing.Color.Gold;
            this.tbResultDestination.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbResultDestination.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultDestination.ForeColor = System.Drawing.Color.Black;
            this.tbResultDestination.Location = new System.Drawing.Point(18, 165);
            this.tbResultDestination.Name = "tbResultDestination";
            this.tbResultDestination.ReadOnly = true;
            this.tbResultDestination.Size = new System.Drawing.Size(517, 26);
            this.tbResultDestination.TabIndex = 4;
            this.tbResultDestination.TabStop = false;
            this.tbResultDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFilePath
            // 
            this.tbFilePath.BackColor = System.Drawing.Color.Gold;
            this.tbFilePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFilePath.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilePath.ForeColor = System.Drawing.Color.Black;
            this.tbFilePath.Location = new System.Drawing.Point(18, 96);
            this.tbFilePath.MaxLength = 500;
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(518, 26);
            this.tbFilePath.TabIndex = 3;
            this.tbFilePath.TabStop = false;
            this.tbFilePath.Tag = "";
            this.tbFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.ForeColor = System.Drawing.Color.Gold;
            this.btnSaveLocation.Location = new System.Drawing.Point(18, 128);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(186, 31);
            this.btnSaveLocation.TabIndex = 2;
            this.btnSaveLocation.Text = "Choose Save Location";
            this.btnSaveLocation.UseVisualStyleBackColor = false;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.ForeColor = System.Drawing.Color.Gold;
            this.btnLoadFile.Location = new System.Drawing.Point(18, 59);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(186, 31);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load Log File";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.BackColor = System.Drawing.Color.LightGray;
            this.lblControlPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblControlPanel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblControlPanel.Location = new System.Drawing.Point(122, 10);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(326, 31);
            this.lblControlPanel.TabIndex = 0;
            this.lblControlPanel.Text = "Log Crawler Control Panel";
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.Teal;
            this.displayPanel.Controls.Add(this.tbResultBox);
            this.displayPanel.Location = new System.Drawing.Point(-6, 275);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(580, 136);
            this.displayPanel.TabIndex = 0;
            // 
            // tbResultBox
            // 
            this.tbResultBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbResultBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbResultBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultBox.ForeColor = System.Drawing.Color.White;
            this.tbResultBox.Location = new System.Drawing.Point(7, 7);
            this.tbResultBox.Multiline = true;
            this.tbResultBox.Name = "tbResultBox";
            this.tbResultBox.ReadOnly = true;
            this.tbResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResultBox.Size = new System.Drawing.Size(572, 122);
            this.tbResultBox.TabIndex = 0;
            this.tbResultBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(574, 417);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 456);
            this.MinimumSize = new System.Drawing.Size(590, 456);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLogCrawler";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label lblControlPanel;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbResultDestination;
        private System.Windows.Forms.Button btnStartLogCrawl;
        private System.Windows.Forms.TextBox tbResultBox;
    }
}

