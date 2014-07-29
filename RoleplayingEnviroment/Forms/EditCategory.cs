using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Atmorithm.Forms
{
    public partial class EditCategory : Form
    {
        private bool _categoryExists = false;
        private const string REASSIGNALLCATEGORIESTEXT = "Alle Kategorien neu zuweisen";

        public EditCategory()
        {
            InitializeComponent();
            PopulateCategoryListBox();
            buttonDelete.Enabled = false;
            buttonNeu.Enabled = false;
        }

        public MusicPlayer ParentForm
        {
            get
            {
                return (MusicPlayer)this.Owner;
            }
        }

        private void PopulateCategoryListBox()
        {
            listBoxCategories.Items.Clear();
            listBoxCategories.Items.AddRange(Program.Categories.GetAllCategories().ToArray());
        }

        private void buttonAddCategory_Click(object sender, System.EventArgs e)
        {
            string categoryToAdd = textBoxName.Text;

            if (string.IsNullOrEmpty(categoryToAdd))
                return;

            if (Program.Categories.CategoryExists(categoryToAdd))
                return;

            menuStripTop.BackColor = Color.LightGreen;
            Program.Categories.AddCategory(categoryToAdd);
            PopulateCategoryListBox();
            ParentForm.BuildTree();

            buttonDelete.Enabled = true;
            buttonNeu.Enabled = false;
            _categoryExists = true;
            buttonReassignCategories.Text = string.Format("Kategorie '{0}' neu zuweisen", categoryToAdd);
        }

        private void buttonDeleteCategory_Click(object sender, System.EventArgs e)
        {
            string categoryToDelete = textBoxName.Text;

            if (string.IsNullOrEmpty(categoryToDelete))
                return;

            if (!Program.Categories.CategoryExists(categoryToDelete))
                return;

            menuStripTop.BackColor = Color.Salmon;
            Program.Categories.DeleteCategory(categoryToDelete);
            PopulateCategoryListBox();
            ParentForm.BuildTree();

            buttonDelete.Enabled = false;
            buttonNeu.Enabled = true;
            _categoryExists = false;
            buttonReassignCategories.Text = REASSIGNALLCATEGORIESTEXT;
        }

        private void listBoxCategories_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxCategories.SelectedItem == null)
                return;

            textBoxName.Text = listBoxCategories.SelectedItem.ToString();
        }

        private void textBoxName_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                buttonDelete.Enabled = false;
                buttonNeu.Enabled = false;
                _categoryExists = false;
                buttonReassignCategories.Text = REASSIGNALLCATEGORIESTEXT;
                return;
            }

            var Category = Program.Categories.GetAllCategories().Where(c => c.ToLower() == textBoxName.Text.ToLower()).FirstOrDefault();
            if (string.IsNullOrEmpty(Category))
            {
                buttonDelete.Enabled = false;
                buttonNeu.Enabled = true;
                _categoryExists = false;
                buttonReassignCategories.Text = REASSIGNALLCATEGORIESTEXT;
            }
            else
            {
                _categoryExists = true;
                buttonDelete.Enabled = true;
                buttonNeu.Enabled = false;
                textBoxName.Text = Category;
                textBoxName.Select(textBoxName.TextLength, 0);
                buttonReassignCategories.Text = string.Format("Kategorie '{0}' neu zuweisen", Category);
            }

            //var CategoryExists = Program.Categories.CategoryExists(textBoxName.Text);
            //buttonDelete.Enabled = CategoryExists;
            //buttonNeu.Enabled = !CategoryExists;
        }

        private void buttonReassignCategories_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Manuell gesetzte Kategorien in Tracks und Bildern werden möglicherweise überschrieben \nFortfahren?", buttonReassignCategories.Text, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_categoryExists)
                    ReassignOneCategory();
                else
                    ReassignAllCategories();

                ParentForm.BuildTree();
            }
        }

        private void ReassignOneCategory()
        {
            Program.PictureList.ReassignCategories(textBoxName.Text);
            Program.TrackList.ReassignCategories(textBoxName.Text);
        }

        private void ReassignAllCategories()
        {
            Program.PictureList.ReassignCategories();
            Program.TrackList.ReassignCategories();
        }
    }
}
