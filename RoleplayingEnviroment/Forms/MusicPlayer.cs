using Atmorithm.Objects;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class MusicPlayer : Form
    {
        private PictureViewer PlayerPictureViewer;
        private PictureViewer GameMasterPictureViewer;
        private EditTrack EditTrackForm;
        private EditPicture EditPictureForm;
        private EditCategory EditCategoryForm;
        private SelectScreen SelectScreenForm;
        private EditSettings EditSettingsForm;

        private static Random random = new Random();
        private MediaControl.AudioPlayer AudioPlayer = new MediaControl.AudioPlayer();
        private bool Muted = true;
        private bool IsPictureLocked = false;
        private bool FullScreen = false;
        private Track CurrentTrack;
        private int TickRate = Program.Settings.SlideShowTickRate;

        public MusicPlayer()
        {
            InitializeComponent();
            SetButtons(false);
            CurrentTrack = new Track();

            openPictureDialog.InitialDirectory = Program.PictureDirectory;
            openPictureDialog.Filter = "Bilder (*.gif, *.jpg, *.jpeg, *.png) | *.gif; *.jpg; *.jpeg; *.png";

            AudioPlayer.Repeat = true;

            timerChangePicture.Interval = TickRate;

            BuildTree();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            PlayerPictureViewer = new PictureViewer(false, false, false);
            PlayerPictureViewer.Location = new Point(this.Location.X + this.Width, this.Location.Y + this.Height - PlayerPictureViewer.Height);
            PlayerPictureViewer.Hide();

            GameMasterPictureViewer = new PictureViewer(true, true, true) { Location = new Point(this.Location.X + this.Width, this.Location.Y + this.Height - PlayerPictureViewer.Height) };
            GameMasterPictureViewer.Show();
            trackbarVolume.Value = trackbarVolume.Maximum;
        }

        public void BuildTree()
        {
            treeViewTracks.Nodes.Clear();
            treeViewTracks.BeginUpdate();

            TreeNode parentNode = null;
            foreach (var category in Program.Categories.GetAllCategories())
            {
                parentNode = new TreeNode(category);

                foreach (var track in Program.TrackList.GetTrackList().Where(t => category.Equals(t.Category)))
                {
                    TreeNode childNode = new TreeNode(track.Name);
                    parentNode.Nodes.Add(childNode);
                }
                parentNode.Collapse();
                treeViewTracks.Nodes.Add(parentNode);
            }
            treeViewTracks.EndUpdate();
            treeViewTracks.Refresh();
        }

        private void PlayTrack(Track trackToPlay)
        {
            if (Program.Settings.FadingIsActive && AudioPlayer.bFileIsOpen)
                FadeOutCurrentTrack();

            if (AudioPlayer.bFileIsOpen)
                AudioPlayer.Close();

            AudioPlayer.Open(Program.MusicDirectory + trackToPlay.FileName);

            if (!IsPictureLocked)
                ChangePicture(trackToPlay);

            if (AudioPlayer.bFileIsOpen)
            {
                var lastTrack = CurrentTrack;
                timerChangePicture.Start();
                CurrentTrack = trackToPlay;
                labelCurrentTrack.Text = trackToPlay.Name;
                SetButtons(true);
                AudioPlayer.Play();
                AudioPlayer.Repeat = true;
                AudioPlayer.SetAudioOn();
                buttonMute.Image = mediaIcons.Images[4];
                Muted = false;

                if (Program.Settings.FadingIsActive)
                    FadeInCurrentTrack();
                else
                    AudioPlayer.Volume = trackbarVolume.Value;
            }
        }

        private void FadeInCurrentTrack()
        {
            AudioPlayer.Volume = 0;
            int tbVolume = trackbarVolume.Value;
            int apVolume = AudioPlayer.Volume;
            int increase = tbVolume / 10;
            int steps = 0;

            while (apVolume < tbVolume)
            {
                steps++;

                if (apVolume + increase <= tbVolume)
                {
                    apVolume += increase;
                    increase += 10;
                }
                else
                    apVolume = tbVolume;
            }

            int sleepDuration = Program.Settings.FadingDurationHalf / steps;
            while (AudioPlayer.Volume < trackbarVolume.Value)
            {
                System.Threading.Thread.Sleep(sleepDuration);

                if (AudioPlayer.Volume + increase <= trackbarVolume.Value)
                {
                    AudioPlayer.Volume += increase;
                    increase += 10;
                }
                else
                    AudioPlayer.Volume = trackbarVolume.Value;
            }
        }

        private void FadeOutCurrentTrack()
        {
            int tbVolume = trackbarVolume.Value;
            int decrease = tbVolume / 10;
            int steps = 0;

            int apVolume = AudioPlayer.Volume;

            while (apVolume > 0)
            {
                if (apVolume - decrease >= 0)
                {
                    apVolume -= decrease;
                    decrease += 10;
                }
                else
                    apVolume = 0;

                steps++;
            }

            int sleepDuration = Program.Settings.FadingDurationHalf / steps;
            while (AudioPlayer.Volume > 0)
            {
                if (AudioPlayer.Volume - decrease >= 0)
                {
                    AudioPlayer.Volume -= decrease;
                    decrease += 10;
                }
                else
                    AudioPlayer.Volume = 0;

                System.Threading.Thread.Sleep(sleepDuration);
            }
        }

        private void ChangePicture(Track trackToPlay)
        {
            var filteredPictureList = Program.TrackPicturesList.GetAssociatedPicturesByTrack(trackToPlay);
            if (filteredPictureList.Count < 1)
            {
                filteredPictureList = Program.PictureList.GetPictureList().Where(p => p.Category.ToLower() == trackToPlay.Category.ToLower() && p.AllowRandomSelect).ToList();
                if (filteredPictureList.Count == 0)
                    filteredPictureList = Program.PictureList.GetPictureList();
            }
            int r = random.Next(filteredPictureList.Count());
            PlayerPictureViewer.ChangePicture(Program.PictureDirectory + filteredPictureList[r].FileName);
            GameMasterPictureViewer.ChangePicture(Program.PictureDirectory + filteredPictureList[r].FileName);
        }

        public void ChangeTickRate(int intervallInMilliseconds)
        {
            timerChangePicture.Interval = intervallInMilliseconds;
        }

        public void PictureViewerChangeScreenAndMaximize(Screen destinationScreen)
        {
            PlayerPictureViewer.ChangeScreenAndMaximize(destinationScreen);
        }

        private void SetButtons(bool Enable)
        {
            buttonPause.Enabled = Enable;
            buttonStop.Enabled = Enable;
            buttonMute.Enabled = Enable;
            trackbarVolume.Enabled = Enable;
            buttonPrevious.Enabled = Enable;
            buttonNext.Enabled = Enable;
        }

        private Track GetSelectedTrackFromTree(bool getRandomTrackAtParentNodes = false)
        {
            if (treeViewTracks.SelectedNode == null)
                return null;

            if (treeViewTracks.SelectedNode.Parent == null)
            {
                if (!getRandomTrackAtParentNodes)
                    return null;

                var filteredTrackList = Program.TrackList.GetTrackList().Where(t => t.Category.ToLower() == treeViewTracks.SelectedNode.Text.ToLower() && t.Name != CurrentTrack.Name).ToList();
                if (filteredTrackList.Count == 0)
                    return null;

                int r = random.Next(filteredTrackList.Count());
                return filteredTrackList[r];
            }

            string selectedTrackAsString = treeViewTracks.SelectedNode.Text;
            if (string.IsNullOrEmpty(selectedTrackAsString))
                return null;

            var selectedTrack = Program.TrackList.GetTrackList().Where(t => t.Name.ToLower() == selectedTrackAsString.ToLower()).FirstOrDefault();
            if (selectedTrack == null)
                return null;

            return selectedTrack;
        }

        #region Controls

        private void buttonPlay_Click(object sender, System.EventArgs e)
        {
            if (treeViewTracks.SelectedNode == null)
                return;

            if (treeViewTracks.SelectedNode.Parent == null)
                return;

            var selectedTrack = Program.TrackList.GetTrackList().Where(t => t.Name.Equals(treeViewTracks.SelectedNode.Text)).FirstOrDefault();
            if (selectedTrack == null)
                return;

            PlayTrack(selectedTrack);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerChangePicture.Stop();
            AudioPlayer.Stop();
            SetButtons(false);
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (Muted == false)
            {
                AudioPlayer.SetAudioOff();
                buttonMute.Image = mediaIcons.Images[3];
                Muted = true;
            }
            else
            {
                AudioPlayer.SetAudioOn();
                buttonMute.Image = mediaIcons.Images[4];
                Muted = false;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (AudioPlayer.Pause == false)
            {
                timerChangePicture.Stop();
                AudioPlayer.Pause = true;
                Muted = true;
                buttonMute.Image = mediaIcons.Images[3];
                trackbarVolume.Enabled = false;
            }
            else
            {
                timerChangePicture.Start();
                AudioPlayer.Pause = false;
                Muted = false;
                buttonMute.Image = mediaIcons.Images[4];
                trackbarVolume.Enabled = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var filteredTrackList = Program.TrackList.GetTrackList().Where(t => t.Category == CurrentTrack.Category).ToList<Track>();
            var index = filteredTrackList.FindIndex(t => t.Name == CurrentTrack.Name);

            if (index + 1 >= filteredTrackList.Count)
                PlayTrack(filteredTrackList[0]);
            else
                PlayTrack(filteredTrackList[index + 1]);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            var filteredTrackList = Program.TrackList.GetTrackList().Where(t => t.Category == CurrentTrack.Category).ToList<Track>();
            var index = filteredTrackList.FindIndex(t => t.Name == CurrentTrack.Name);

            if (index - 1 < 0)
                PlayTrack(filteredTrackList[filteredTrackList.Count - 1]);
            else
                PlayTrack(filteredTrackList[index - 1]);
        }

        private void buttonTracksBearbeiten_Click(object sender, EventArgs e)
        {
            if (EditTrackForm == null || (EditTrackForm.IsDisposed))
            {
                EditTrackForm = new EditTrack() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            EditTrackForm.Show();

            var selectedTrack = GetSelectedTrackFromTree();
            if (selectedTrack == null)
                return;
            EditTrackForm.SelectTrack(selectedTrack);
        }

        private void buttonBilderBearbeiten_Click(object sender, EventArgs e)
        {
            if (EditPictureForm == null || (EditPictureForm.IsDisposed))
            {
                EditPictureForm = new EditPicture() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            EditPictureForm.Show();
        }

        private void buttonKategorieBearbeiten_Click(object sender, EventArgs e)
        {
            if (EditCategoryForm == null || (EditCategoryForm.IsDisposed))
            {
                EditCategoryForm = new EditCategory() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            EditCategoryForm.Show();
        }

        private void buttonSetTickRate_Click(object sender, EventArgs e)
        {
            if (EditSettingsForm == null || (EditSettingsForm.IsDisposed))
            {
                EditSettingsForm = new EditSettings() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            EditSettingsForm.Show();
        }

        private void buttonToggleFullscreen_Click(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            var currentScreen = Screen.FromControl(this);
            if (!FullScreen && screens.Count() > 1)
            {
                var destinationScreens = screens.Where(s => s.DeviceName != currentScreen.DeviceName).ToList();
                FullScreen = true;
                buttonToggleFullscreen.Image = mediaIcons.Images[5];
                PlayerPictureViewer.Show();
                if (destinationScreens.Count() > 1)
                {
                    if (SelectScreenForm == null || (SelectScreenForm.IsDisposed))
                    {
                        SelectScreenForm = new SelectScreen() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
                    }
                    SelectScreenForm.SetScreenList(destinationScreens);
                    SelectScreenForm.Show();
                }
                else
                    PlayerPictureViewer.ChangeScreenAndMaximize(destinationScreens.FirstOrDefault());
            }
            else
            {
                FullScreen = false;
                buttonToggleFullscreen.Image = mediaIcons.Images[6];
                PlayerPictureViewer.Hide();
                //PlayerPictureViewer.ChangeScreenAndReset(currentScreen, new Point(this.Location.X + this.Width, this.Location.Y + this.Height - PlayerPictureViewer.Height));
            }
        }

        private void buttonTogglePictureLock_Click(object sender, EventArgs e)
        {
            if (IsPictureLocked)
            {
                buttonTogglePictureLock.Image = mediaIcons.Images[7];
                IsPictureLocked = false;
            }
            else
            {

                if (openPictureDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        IsPictureLocked = true;
                        buttonTogglePictureLock.Image = mediaIcons.Images[8];
                        PlayerPictureViewer.ChangePicture(openPictureDialog.FileName);
                        GameMasterPictureViewer.ChangePicture(openPictureDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void trackbarVolume_Scroll(object sender, EventArgs e)
        {
            AudioPlayer.Volume = trackbarVolume.Value;
        }

        private void trackbarVolume_MouseDown(object sender, MouseEventArgs e)
        {
            double dblValue;
            dblValue = ((double)e.X / (double)trackbarVolume.Width) * (trackbarVolume.Maximum - trackbarVolume.Minimum);
            if (dblValue > trackbarVolume.Value && dblValue > trackbarVolume.Value + 50)
                trackbarVolume.Value = Convert.ToInt32(dblValue);
            else if (dblValue < trackbarVolume.Value && dblValue < trackbarVolume.Value - 50)
                trackbarVolume.Value = Convert.ToInt32(dblValue);
        }

        private void treeViewTracks_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedTrack = GetSelectedTrackFromTree(true);
            if (selectedTrack == null)
                return;

            PlayTrack(selectedTrack);
        }

        private void timerChangePicture_Tick(object sender, EventArgs e)
        {
            if (!IsPictureLocked)
                ChangePicture(CurrentTrack);
        }

        private void treeViewTracks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (EditTrackForm == null || EditTrackForm.IsDisposed)
                return;

            var selectedTrack = GetSelectedTrackFromTree();
            if (selectedTrack == null)
                return;

            EditTrackForm.SelectTrack(selectedTrack);
        }

        #endregion

    }
}
