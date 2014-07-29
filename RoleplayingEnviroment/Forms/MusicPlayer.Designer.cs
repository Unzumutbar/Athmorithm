namespace Atmorithm.Forms
{
    partial class MusicPlayer
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewTracks = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonInhalteBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTracksBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBilderBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonKategorieBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSetTickRate = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToggleFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTogglePictureLock = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.mediaIcons = new System.Windows.Forms.ImageList(this.components);
            this.trackbarVolume = new System.Windows.Forms.TrackBar();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelCurrentTrack = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerChangePicture = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewTracks);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(294, 487);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewTracks
            // 
            this.treeViewTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTracks.Location = new System.Drawing.Point(0, 24);
            this.treeViewTracks.Name = "treeViewTracks";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.treeViewTracks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewTracks.Size = new System.Drawing.Size(294, 404);
            this.treeViewTracks.TabIndex = 2;
            this.treeViewTracks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTracks_AfterSelect);
            this.treeViewTracks.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewTracks_NodeMouseDoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonInhalteBearbeiten,
            this.buttonToggleFullscreen,
            this.buttonTogglePictureLock});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(294, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // buttonInhalteBearbeiten
            // 
            this.buttonInhalteBearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonTracksBearbeiten,
            this.buttonBilderBearbeiten,
            this.buttonKategorieBearbeiten,
            this.buttonSetTickRate});
            this.buttonInhalteBearbeiten.Image = ((System.Drawing.Image)(resources.GetObject("buttonInhalteBearbeiten.Image")));
            this.buttonInhalteBearbeiten.Name = "buttonInhalteBearbeiten";
            this.buttonInhalteBearbeiten.Size = new System.Drawing.Size(130, 20);
            this.buttonInhalteBearbeiten.Text = "Inhalte bearbeiten";
            // 
            // buttonTracksBearbeiten
            // 
            this.buttonTracksBearbeiten.Image = ((System.Drawing.Image)(resources.GetObject("buttonTracksBearbeiten.Image")));
            this.buttonTracksBearbeiten.Name = "buttonTracksBearbeiten";
            this.buttonTracksBearbeiten.Size = new System.Drawing.Size(204, 22);
            this.buttonTracksBearbeiten.Text = "Tracks bearbeiten";
            this.buttonTracksBearbeiten.Click += new System.EventHandler(this.buttonTracksBearbeiten_Click);
            // 
            // buttonBilderBearbeiten
            // 
            this.buttonBilderBearbeiten.Image = ((System.Drawing.Image)(resources.GetObject("buttonBilderBearbeiten.Image")));
            this.buttonBilderBearbeiten.Name = "buttonBilderBearbeiten";
            this.buttonBilderBearbeiten.Size = new System.Drawing.Size(204, 22);
            this.buttonBilderBearbeiten.Text = "Bilder bearbeiten";
            this.buttonBilderBearbeiten.Click += new System.EventHandler(this.buttonBilderBearbeiten_Click);
            // 
            // buttonKategorieBearbeiten
            // 
            this.buttonKategorieBearbeiten.Image = global::Atmorithm.Properties.Resources.pricetag;
            this.buttonKategorieBearbeiten.Name = "buttonKategorieBearbeiten";
            this.buttonKategorieBearbeiten.Size = new System.Drawing.Size(204, 22);
            this.buttonKategorieBearbeiten.Text = "Kategorien bearbeiten";
            this.buttonKategorieBearbeiten.Click += new System.EventHandler(this.buttonKategorieBearbeiten_Click);
            // 
            // buttonSetTickRate
            // 
            this.buttonSetTickRate.Image = global::Atmorithm.Properties.Resources.clock;
            this.buttonSetTickRate.Name = "buttonSetTickRate";
            this.buttonSetTickRate.Size = new System.Drawing.Size(204, 22);
            this.buttonSetTickRate.Text = "Einstellungen bearbeiten";
            this.buttonSetTickRate.Click += new System.EventHandler(this.buttonSetTickRate_Click);
            // 
            // buttonToggleFullscreen
            // 
            this.buttonToggleFullscreen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonToggleFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("buttonToggleFullscreen.Image")));
            this.buttonToggleFullscreen.Name = "buttonToggleFullscreen";
            this.buttonToggleFullscreen.Size = new System.Drawing.Size(28, 20);
            this.buttonToggleFullscreen.ToolTipText = "Bilder auf zweitem Bildschirm ausgeben";
            this.buttonToggleFullscreen.Click += new System.EventHandler(this.buttonToggleFullscreen_Click);
            // 
            // buttonTogglePictureLock
            // 
            this.buttonTogglePictureLock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonTogglePictureLock.Image = global::Atmorithm.Properties.Resources.unlocked;
            this.buttonTogglePictureLock.Name = "buttonTogglePictureLock";
            this.buttonTogglePictureLock.Size = new System.Drawing.Size(28, 20);
            this.buttonTogglePictureLock.ToolTipText = "Bild für Wiedergabe festlegen";
            this.buttonTogglePictureLock.Click += new System.EventHandler(this.buttonTogglePictureLock_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonPlay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackbarVolume, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonStop, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMute, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPause, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrevious, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentTrack, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 55);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonPlay
            // 
            this.buttonPlay.ImageIndex = 0;
            this.buttonPlay.ImageList = this.mediaIcons;
            this.buttonPlay.Location = new System.Drawing.Point(33, 23);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(24, 24);
            this.buttonPlay.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonPlay, "Play");
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // mediaIcons
            // 
            this.mediaIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mediaIcons.ImageStream")));
            this.mediaIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.mediaIcons.Images.SetKeyName(0, "play.png");
            this.mediaIcons.Images.SetKeyName(1, "pause.png");
            this.mediaIcons.Images.SetKeyName(2, "stop.png");
            this.mediaIcons.Images.SetKeyName(3, "volume-mute.png");
            this.mediaIcons.Images.SetKeyName(4, "volume-medium.png");
            this.mediaIcons.Images.SetKeyName(5, "eye.png");
            this.mediaIcons.Images.SetKeyName(6, "eye-disabled.png");
            this.mediaIcons.Images.SetKeyName(7, "unlocked.png");
            this.mediaIcons.Images.SetKeyName(8, "locked.png");
            this.mediaIcons.Images.SetKeyName(9, "skip-forward.png");
            this.mediaIcons.Images.SetKeyName(10, "skip-backward.png");
            // 
            // trackbarVolume
            // 
            this.trackbarVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarVolume.Location = new System.Drawing.Point(153, 23);
            this.trackbarVolume.Maximum = 1000;
            this.trackbarVolume.Name = "trackbarVolume";
            this.trackbarVolume.Size = new System.Drawing.Size(108, 24);
            this.trackbarVolume.SmallChange = 100;
            this.trackbarVolume.TabIndex = 6;
            this.trackbarVolume.TickFrequency = 100;
            this.trackbarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.trackbarVolume, "Lautstärke");
            this.trackbarVolume.Scroll += new System.EventHandler(this.trackbarVolume_Scroll);
            this.trackbarVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackbarVolume_MouseDown);
            // 
            // buttonStop
            // 
            this.buttonStop.ImageIndex = 2;
            this.buttonStop.ImageList = this.mediaIcons;
            this.buttonStop.Location = new System.Drawing.Point(93, 23);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(24, 24);
            this.buttonStop.TabIndex = 5;
            this.toolTip.SetToolTip(this.buttonStop, "Stop");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.ImageIndex = 4;
            this.buttonMute.ImageList = this.mediaIcons;
            this.buttonMute.Location = new System.Drawing.Point(267, 23);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(24, 24);
            this.buttonMute.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonMute, "Stumm schalten");
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.ImageIndex = 1;
            this.buttonPause.ImageList = this.mediaIcons;
            this.buttonPause.Location = new System.Drawing.Point(63, 23);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(24, 24);
            this.buttonPause.TabIndex = 4;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.ImageIndex = 9;
            this.buttonNext.ImageList = this.mediaIcons;
            this.buttonNext.Location = new System.Drawing.Point(123, 23);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(24, 24);
            this.buttonNext.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonNext, "Nächsten Track der Kategorie abspielen");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.ImageIndex = 10;
            this.buttonPrevious.ImageList = this.mediaIcons;
            this.buttonPrevious.Location = new System.Drawing.Point(3, 23);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(24, 24);
            this.buttonPrevious.TabIndex = 9;
            this.toolTip.SetToolTip(this.buttonPrevious, "Stop");
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelCurrentTrack
            // 
            this.labelCurrentTrack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCurrentTrack.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCurrentTrack, 7);
            this.labelCurrentTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTrack.Location = new System.Drawing.Point(3, 2);
            this.labelCurrentTrack.Name = "labelCurrentTrack";
            this.labelCurrentTrack.Size = new System.Drawing.Size(0, 16);
            this.labelCurrentTrack.TabIndex = 10;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "Hintergrund.jpg";
            // 
            // timerChangePicture
            // 
            this.timerChangePicture.Interval = 900000;
            this.timerChangePicture.Tick += new System.EventHandler(this.timerChangePicture_Tick);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 487);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.Text = "Atmorithmus Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewTracks;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar trackbarVolume;
        private System.Windows.Forms.ToolStripMenuItem buttonInhalteBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem buttonTracksBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem buttonBilderBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem buttonKategorieBearbeiten;
        private System.Windows.Forms.ImageList mediaIcons;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ToolStripMenuItem buttonToggleFullscreen;
        private System.Windows.Forms.ToolStripMenuItem buttonTogglePictureLock;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelCurrentTrack;
        private System.Windows.Forms.Timer timerChangePicture;
        private System.Windows.Forms.ToolStripMenuItem buttonSetTickRate;

    }
}