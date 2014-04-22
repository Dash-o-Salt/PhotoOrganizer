namespace PhotoOrganizer
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameAllFilesInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToSubFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recycleImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageNavigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFitWidth = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblImagePosition = new System.Windows.Forms.Label();
            this.btnViewExif = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.tbFolderToMove = new System.Windows.Forms.TextBox();
            this.btnBadDelete = new System.Windows.Forms.Button();
            this.btnBadRecycle = new System.Windows.Forms.Button();
            this.btnMoveToSubFolder = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.imageOperationsToolStripMenuItem,
            this.imageNavigationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openToolStripMenuItem.Text = "Open Folder";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem,
            this.renameAllFilesInFolderToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 20);
            this.toolStripMenuItem1.Text = "Batch Operations";
            // 
            // stripExifDataFromAllFilesInFolderToolStripMenuItem
            // 
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem.Enabled = false;
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem.Name = "stripExifDataFromAllFilesInFolderToolStripMenuItem";
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem.Text = "Strip Image Metadata From All Files in Folder";
            this.stripExifDataFromAllFilesInFolderToolStripMenuItem.Click += new System.EventHandler(this.stripExifDataFromAllFilesInFolderToolStripMenuItem_Click);
            // 
            // renameAllFilesInFolderToolStripMenuItem
            // 
            this.renameAllFilesInFolderToolStripMenuItem.Enabled = false;
            this.renameAllFilesInFolderToolStripMenuItem.Name = "renameAllFilesInFolderToolStripMenuItem";
            this.renameAllFilesInFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.renameAllFilesInFolderToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.renameAllFilesInFolderToolStripMenuItem.Text = "Rename All Files in Folder";
            this.renameAllFilesInFolderToolStripMenuItem.Click += new System.EventHandler(this.renameAllFilesInFolderToolStripMenuItem_Click);
            // 
            // imageOperationsToolStripMenuItem
            // 
            this.imageOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousImageToolStripMenuItem,
            this.nextImageToolStripMenuItem,
            this.rotateLeftToolStripMenuItem,
            this.rotateRightToolStripMenuItem,
            this.fitWidthToolStripMenuItem,
            this.moveToSubFolderToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.recycleImageToolStripMenuItem});
            this.imageOperationsToolStripMenuItem.Name = "imageOperationsToolStripMenuItem";
            this.imageOperationsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.imageOperationsToolStripMenuItem.Text = "Image Operations";
            // 
            // previousImageToolStripMenuItem
            // 
            this.previousImageToolStripMenuItem.Enabled = false;
            this.previousImageToolStripMenuItem.Name = "previousImageToolStripMenuItem";
            this.previousImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.previousImageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.previousImageToolStripMenuItem.Text = "Previous Image";
            this.previousImageToolStripMenuItem.Click += new System.EventHandler(this.previousImageToolStripMenuItem_Click);
            // 
            // nextImageToolStripMenuItem
            // 
            this.nextImageToolStripMenuItem.Enabled = false;
            this.nextImageToolStripMenuItem.Name = "nextImageToolStripMenuItem";
            this.nextImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nextImageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.nextImageToolStripMenuItem.Text = "Next Image";
            this.nextImageToolStripMenuItem.Click += new System.EventHandler(this.nextImageToolStripMenuItem_Click);
            // 
            // rotateLeftToolStripMenuItem
            // 
            this.rotateLeftToolStripMenuItem.Enabled = false;
            this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
            this.rotateLeftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.rotateLeftToolStripMenuItem.Text = "Rotate Left";
            this.rotateLeftToolStripMenuItem.Click += new System.EventHandler(this.rotateLeftToolStripMenuItem_Click);
            // 
            // rotateRightToolStripMenuItem
            // 
            this.rotateRightToolStripMenuItem.Enabled = false;
            this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
            this.rotateRightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.rotateRightToolStripMenuItem.Text = "Rotate Right";
            this.rotateRightToolStripMenuItem.Click += new System.EventHandler(this.rotateRightToolStripMenuItem_Click);
            // 
            // fitWidthToolStripMenuItem
            // 
            this.fitWidthToolStripMenuItem.Enabled = false;
            this.fitWidthToolStripMenuItem.Name = "fitWidthToolStripMenuItem";
            this.fitWidthToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fitWidthToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.fitWidthToolStripMenuItem.Text = "Fit Width";
            this.fitWidthToolStripMenuItem.Click += new System.EventHandler(this.fitWidthToolStripMenuItem_Click);
            // 
            // moveToSubFolderToolStripMenuItem
            // 
            this.moveToSubFolderToolStripMenuItem.Enabled = false;
            this.moveToSubFolderToolStripMenuItem.Name = "moveToSubFolderToolStripMenuItem";
            this.moveToSubFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.moveToSubFolderToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.moveToSubFolderToolStripMenuItem.Text = "Move to SubFolder";
            this.moveToSubFolderToolStripMenuItem.Click += new System.EventHandler(this.moveToSubFolderToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteToolStripMenuItem.Text = "Delete Image";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // recycleImageToolStripMenuItem
            // 
            this.recycleImageToolStripMenuItem.Enabled = false;
            this.recycleImageToolStripMenuItem.Name = "recycleImageToolStripMenuItem";
            this.recycleImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.recycleImageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.recycleImageToolStripMenuItem.Text = "Recycle Image";
            this.recycleImageToolStripMenuItem.Click += new System.EventHandler(this.recycleImageToolStripMenuItem_Click);
            // 
            // imageNavigationToolStripMenuItem
            // 
            this.imageNavigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sliderToolStripMenuItem,
            this.tiledToolStripMenuItem});
            this.imageNavigationToolStripMenuItem.Name = "imageNavigationToolStripMenuItem";
            this.imageNavigationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.imageNavigationToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.imageNavigationToolStripMenuItem.Text = "Image Navigation";
            // 
            // sliderToolStripMenuItem
            // 
            this.sliderToolStripMenuItem.Enabled = false;
            this.sliderToolStripMenuItem.Name = "sliderToolStripMenuItem";
            this.sliderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.sliderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sliderToolStripMenuItem.Text = "Slider...";
            this.sliderToolStripMenuItem.Click += new System.EventHandler(this.sliderToolStripMenuItem_Click);
            // 
            // tiledToolStripMenuItem
            // 
            this.tiledToolStripMenuItem.Enabled = false;
            this.tiledToolStripMenuItem.Name = "tiledToolStripMenuItem";
            this.tiledToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tiledToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tiledToolStripMenuItem.Text = "Tiled...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.aboutToolStripMenuItem1.Text = "About Photo Organizer";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFitWidth);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblImagePosition);
            this.groupBox1.Controls.Add(this.btnViewExif);
            this.groupBox1.Controls.Add(this.btnRotateLeft);
            this.groupBox1.Controls.Add(this.btnRotateRight);
            this.groupBox1.Controls.Add(this.tbFolderToMove);
            this.groupBox1.Controls.Add(this.btnBadDelete);
            this.groupBox1.Controls.Add(this.btnBadRecycle);
            this.groupBox1.Controls.Add(this.btnMoveToSubFolder);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 669);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routing Controls";
            // 
            // btnFitWidth
            // 
            this.btnFitWidth.Image = global::PhotoOrganizer.Properties.Resources.gnome_view_fullscreen;
            this.btnFitWidth.Location = new System.Drawing.Point(832, 17);
            this.btnFitWidth.Name = "btnFitWidth";
            this.btnFitWidth.Size = new System.Drawing.Size(38, 38);
            this.btnFitWidth.TabIndex = 12;
            this.btnFitWidth.Text = "\r\n";
            this.toolTip1.SetToolTip(this.btnFitWidth, "Fit Screen Width");
            this.btnFitWidth.UseVisualStyleBackColor = true;
            this.btnFitWidth.Click += new System.EventHandler(this.btnFitWidth_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(556, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Image Name";
            this.lblName.Visible = false;
            // 
            // lblImagePosition
            // 
            this.lblImagePosition.AutoSize = true;
            this.lblImagePosition.Location = new System.Drawing.Point(556, 41);
            this.lblImagePosition.Name = "lblImagePosition";
            this.lblImagePosition.Size = new System.Drawing.Size(76, 13);
            this.lblImagePosition.TabIndex = 10;
            this.lblImagePosition.Text = "Image Position";
            this.lblImagePosition.Visible = false;
            // 
            // btnViewExif
            // 
            this.btnViewExif.Location = new System.Drawing.Point(876, 17);
            this.btnViewExif.Name = "btnViewExif";
            this.btnViewExif.Size = new System.Drawing.Size(120, 38);
            this.btnViewExif.TabIndex = 9;
            this.btnViewExif.Text = "View Image Metadata";
            this.toolTip1.SetToolTip(this.btnViewExif, "Moves Image to the designated folder");
            this.btnViewExif.UseVisualStyleBackColor = true;
            this.btnViewExif.Click += new System.EventHandler(this.btnViewExifData_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Image = global::PhotoOrganizer.Properties.Resources.undo;
            this.btnRotateLeft.Location = new System.Drawing.Point(144, 19);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(38, 38);
            this.btnRotateLeft.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnRotateLeft, "Rotate Image Left");
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Image = global::PhotoOrganizer.Properties.Resources.redo;
            this.btnRotateRight.Location = new System.Drawing.Point(100, 19);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(38, 38);
            this.btnRotateRight.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnRotateRight, "Rotate Image Right");
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // tbFolderToMove
            // 
            this.tbFolderToMove.Location = new System.Drawing.Point(323, 27);
            this.tbFolderToMove.Name = "tbFolderToMove";
            this.tbFolderToMove.Size = new System.Drawing.Size(139, 20);
            this.tbFolderToMove.TabIndex = 5;
            this.tbFolderToMove.Text = "BadImages";
            // 
            // btnBadDelete
            // 
            this.btnBadDelete.Image = global::PhotoOrganizer.Properties.Resources.delete;
            this.btnBadDelete.Location = new System.Drawing.Point(512, 19);
            this.btnBadDelete.Name = "btnBadDelete";
            this.btnBadDelete.Size = new System.Drawing.Size(38, 38);
            this.btnBadDelete.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnBadDelete, "Delete Image");
            this.btnBadDelete.UseVisualStyleBackColor = true;
            this.btnBadDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBadRecycle
            // 
            this.btnBadRecycle.Image = global::PhotoOrganizer.Properties.Resources.recycleBin;
            this.btnBadRecycle.Location = new System.Drawing.Point(468, 19);
            this.btnBadRecycle.Name = "btnBadRecycle";
            this.btnBadRecycle.Size = new System.Drawing.Size(38, 38);
            this.btnBadRecycle.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBadRecycle, "Recycle Image");
            this.btnBadRecycle.UseVisualStyleBackColor = true;
            this.btnBadRecycle.Click += new System.EventHandler(this.btnRecycle_Click);
            // 
            // btnMoveToSubFolder
            // 
            this.btnMoveToSubFolder.Location = new System.Drawing.Point(208, 19);
            this.btnMoveToSubFolder.Name = "btnMoveToSubFolder";
            this.btnMoveToSubFolder.Size = new System.Drawing.Size(109, 38);
            this.btnMoveToSubFolder.TabIndex = 2;
            this.btnMoveToSubFolder.Text = "Move to SubFolder";
            this.toolTip1.SetToolTip(this.btnMoveToSubFolder, "Moves Image to the designated folder");
            this.btnMoveToSubFolder.UseVisualStyleBackColor = true;
            this.btnMoveToSubFolder.Click += new System.EventHandler(this.btnMoveToSubFolder_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::PhotoOrganizer.Properties.Resources.back;
            this.btnPrevious.Location = new System.Drawing.Point(12, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 38);
            this.btnPrevious.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPrevious, "Previous Image");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PhotoOrganizer.Properties.Resources.forward;
            this.btnNext.Location = new System.Drawing.Point(56, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 38);
            this.btnNext.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnNext, "Next Image");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPanel.AutoScroll = true;
            this.pictureBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureBoxPanel.Controls.Add(this.pictureBox1);
            this.pictureBoxPanel.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(984, 636);
            this.pictureBoxPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 636);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBoxPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Photo Organizer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBadRecycle;
        private System.Windows.Forms.Button btnMoveToSubFolder;
        private System.Windows.Forms.Button btnBadDelete;
        private System.Windows.Forms.TextBox tbFolderToMove;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stripExifDataFromAllFilesInFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameAllFilesInFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToSubFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recycleImageToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button btnViewExif;
        private System.Windows.Forms.Label lblImagePosition;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.Button btnFitWidth;
        private System.Windows.Forms.ToolStripMenuItem fitWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageNavigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sliderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledToolStripMenuItem;
    }
}

