using Atmorithm.Helper;
using Atmorithm.Objects;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class EditPicture : Form
    {
        private Picture _currentPicture;
        private Image _emptyImage;

        public MusicPlayer ParentForm
        {
            get
            {
                return (MusicPlayer)this.Owner;
            }
        }

        public EditPicture()
        {
            InitializeComponent();

            openPictureDialog.InitialDirectory = Program.PictureDirectory;
            openPictureDialog.Filter = "Bilder (*.gif, *.jpg, *.jpeg, *.png) | *.gif; *.jpg; *.jpeg; *.png";

            foreach (var picture in Program.PictureList.GetPictureList())
            {
                comboBoxName.Items.Add(picture.Name);
            }

            _emptyImage = pictureBox.Image;
            comboBoxCategory.Items.AddRange(Program.Categories.GetAllCategories().ToArray());
            SetButtons(false);
        }

        public void LoadPictureDetails(Picture selectedPicture)
        {
            SetButtons(true);

            comboBoxName.SelectedIndex = comboBoxName.FindStringExact(selectedPicture.Name);
            textBoxFileName.Text = selectedPicture.FileName;
            comboBoxCategory.SelectedIndex = comboBoxCategory.FindStringExact(selectedPicture.Category);
            checkBoxAllowRandomSelect.Checked = selectedPicture.AllowRandomSelect;
            pictureBox.Image = FileHelper.GetPictureAsImage(Program.PictureDirectory + selectedPicture.FileName) ?? _emptyImage;

            if (selectedPicture.FileName.Contains(".gif"))
                buttonDelete.Visible = false;
            else
                buttonDelete.Visible = true;

            _currentPicture = selectedPicture;
        }

        private void SetButtons(bool Enable)
        {
            comboBoxCategory.Enabled = Enable;
            buttonDelete.Enabled = Enable;
            buttonSave.Enabled = Enable;
            checkBoxAllowRandomSelect.Enabled = Enable;
        }

        #region Controls

        private void comboBoxName_DropDownClosed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxName.Text))
                return;

            var selectedPicture = Program.PictureList.GetPictureList().Where(p => p.Name.ToLower() == comboBoxName.Text.ToLower()).FirstOrDefault();
            if (selectedPicture == null)
                return;

            LoadPictureDetails(selectedPicture);
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxName.Text) || string.IsNullOrEmpty(comboBoxCategory.Text))
                return;

            _currentPicture.Category = comboBoxCategory.Text;
            _currentPicture.AllowRandomSelect = checkBoxAllowRandomSelect.Checked;

            if (_currentPicture.IsNew)
            {
                FileHelper.CopyImageToPictureDirectory(_currentPicture.FullPath);
                Program.PictureList.AddPictureToList(_currentPicture);
            }
            else
                Program.PictureList.UpdatePicture(_currentPicture);

            menuStrip1.BackColor = Color.LightGreen;
        }

        private void buttonNeu_Click(object sender, System.EventArgs e)
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetButtons(true);
                    menuStrip1.BackColor = Color.Yellow;

                    var pictureToAdd = FileHelper.GetPictureFromFile(openPictureDialog.FileName);
                    comboBoxName.Items.Add(pictureToAdd.Name);
                    comboBoxName.Text = pictureToAdd.Name;
                    textBoxFileName.Text = pictureToAdd.FileName;
                    comboBoxCategory.Text = pictureToAdd.Category;
                    checkBoxAllowRandomSelect.Checked = pictureToAdd.AllowRandomSelect;

                    _currentPicture = pictureToAdd;

                    this.pictureBox.Image = FileHelper.GetPictureAsImage(openPictureDialog.FileName) ?? _emptyImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Yellow;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxName.Text == string.Empty)
                return;

            var pictureToDelete = Program.PictureList.GetPictureList().Where(p => p.Name == comboBoxName.Text).FirstOrDefault();
            if (pictureToDelete == null)
                return;

            menuStrip1.BackColor = Color.Salmon;

            var deletedItem = comboBoxName.Text;
            comboBoxName.Items.Remove(deletedItem);
            textBoxFileName.Text = string.Empty;
            checkBoxAllowRandomSelect.Checked = false;
            comboBoxCategory.Text = string.Empty;
            pictureBox.Image = _emptyImage;

            SetButtons(false);
            Program.PictureList.DeletePicture(pictureToDelete);


        }

        #endregion
    }
}
