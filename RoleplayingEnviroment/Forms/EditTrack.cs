using Atmorithm.Helper;
using Atmorithm.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class EditTrack : Form
    {
        private List<Picture> _associatedPictures = new List<Picture>();
        private Track _currentTrack;
        private Image _emptyImage;
        private bool _refreshTrackList = false;

        public MusicPlayer ParentForm
        {
            get
            {
                return (MusicPlayer)this.Owner;
            }
        }

        public EditTrack(Track selectedTrack = null)
        {
            InitializeComponent();

            openPictureDialog.InitialDirectory = Program.PictureDirectory;
            openPictureDialog.Filter = "Bilder (*.gif, *.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.gif; *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            openTrackDialog.InitialDirectory = Program.MusicDirectory;
            openTrackDialog.Filter = "Musik (*.mp3, *.wav) | *.mp3; *.wav";

            foreach (var track in Program.TrackList.GetTrackList())
            {
                comboBoxName.Items.Add(track.Name);
            }

            comboBoxCategory.Items.AddRange(Program.Categories.GetAllCategories().ToArray());

            if (selectedTrack != null)
                LoadTrackDetails(selectedTrack);

            _emptyImage = pictureBox.Image;

            SetButtons(false);
        }

        private void LoadTrackDetails(Track selectedTrack)
        {
            SetButtons(true);

            listBoxPictures.Items.Clear();
            _associatedPictures.Clear();

            comboBoxName.SelectedIndex = comboBoxName.FindStringExact(selectedTrack.Name);
            textBoxFileName.Text = selectedTrack.FileName;
            comboBoxCategory.SelectedIndex = comboBoxCategory.FindStringExact(selectedTrack.Category);
            _associatedPictures = Program.TrackPicturesList.GetAssociatedPicturesByTrack(selectedTrack);

            if (_associatedPictures.Count > 0)
            {
                pictureBox.Image = FileHelper.GetPictureAsImage(Program.PictureDirectory + _associatedPictures.FirstOrDefault().FileName) ?? _emptyImage;
                foreach (var picture in _associatedPictures)
                {
                    listBoxPictures.Items.Add(picture.FileName);
                }
            }
            else
                pictureBox.Image = _emptyImage;

            _currentTrack = selectedTrack;
            _refreshTrackList = false;
        }

        public void SelectTrack(Track selectedTrack)
        {
            LoadTrackDetails(selectedTrack);
        }

        private void SetButtons(bool Enable)
        {
            comboBoxCategory.Enabled = Enable;
            buttonDelete.Enabled = Enable;
            buttonSave.Enabled = Enable;
            buttonLoadPicture.Enabled = Enable;
            buttonClearPicture.Enabled = Enable;
        }

        #region Controls

        private void comboBoxName_DropDownClosed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxName.Text))
                return;

            var selectedTrack = Program.TrackList.GetTrackList().Where(t => t.Name.ToLower() == comboBoxName.Text.ToLower()).FirstOrDefault();
            if (selectedTrack == null)
                return;
            LoadTrackDetails(selectedTrack);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Yellow;
            _refreshTrackList = true;
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            if (openTrackDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetButtons(true);
                    _refreshTrackList = true;
                    listBoxPictures.Items.Clear();
                    _associatedPictures.Clear();

                    menuStrip1.BackColor = Color.Yellow;

                    var trackToAdd = FileHelper.GetTrackFromFile(openTrackDialog.FileName);
                    comboBoxName.Items.Add(trackToAdd.Name);
                    comboBoxName.Text = trackToAdd.Name;
                    textBoxFileName.Text = trackToAdd.FileName;
                    comboBoxCategory.Text = trackToAdd.Category;

                    _currentTrack = trackToAdd;

                    pictureBox.Image = _emptyImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxName.Text) || string.IsNullOrEmpty(comboBoxCategory.Text))
                return;

            _currentTrack.Category = comboBoxCategory.Text;

            if (_currentTrack.IsNew)
            {
                FileHelper.CopyTrackToMusicDirectory(_currentTrack.FullPath);
                Program.TrackList.AddTrackToList(_currentTrack);
            }
            else
                Program.TrackList.UpdateTrack(_currentTrack);

            Program.TrackPicturesList.DeleteAssociationsByTrack(_currentTrack);
            foreach (var picture in _associatedPictures)
            {
                var relationship = new TrackPictures() { TrackName = _currentTrack.Name, PictureFileName = picture.FileName };
                Program.TrackPicturesList.AddNewAssociation(relationship);

            }

            foreach (var picture in _associatedPictures.Where(p => p.IsNew))
            {
                FileHelper.CopyImageToPictureDirectory(picture.FullPath);
                Program.PictureList.AddPictureToList(picture);
            }

            if (_refreshTrackList)
                ParentForm.BuildTree();

            menuStrip1.BackColor = Color.LightGreen;


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxName.Text == string.Empty)
                return;

            var trackToDelete = Program.TrackList.GetTrackList().Where(p => p.Name == comboBoxName.Text).FirstOrDefault();
            if (trackToDelete == null)
                return;

            menuStrip1.BackColor = Color.Salmon;
            pictureBox.Image = _emptyImage;
            comboBoxName.Items.Remove(textBoxFileName);
            textBoxFileName.Text = string.Empty;
            Program.TrackList.DeleteTrack(trackToDelete);
            ParentForm.BuildTree();
        }

        private void buttonAddPicture_Click(object sender, System.EventArgs e)
        {

            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    menuStrip1.BackColor = Color.Yellow;

                    var fileName = openPictureDialog.FileName;
                    var pictureToAdd = FileHelper.GetPictureFromFile(fileName);
                    if (listBoxPictures.Items.Contains(pictureToAdd.FileName))
                        return;

                    pictureBox.Image = FileHelper.GetPictureAsImage(fileName) ?? _emptyImage;
                    listBoxPictures.Items.Add(pictureToAdd.FileName);
                    _associatedPictures.Add(pictureToAdd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonClearPicture_Click(object sender, EventArgs e)
        {
            if (listBoxPictures.SelectedItem == null)
                return;

            var pictureToClear = _associatedPictures.Where(a => a.FileName == listBoxPictures.SelectedItem.ToString()).FirstOrDefault();
            _associatedPictures.Remove(pictureToClear);
            listBoxPictures.Items.Remove(pictureToClear.FileName);
            pictureBox.Image = _emptyImage;
        }

        private void listBoxPictures_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxPictures.SelectedItem == null)
                return;

            pictureBox.Image = FileHelper.GetPictureAsImage(Program.PictureDirectory + listBoxPictures.SelectedItem.ToString());
        }

        #endregion




    }
}
