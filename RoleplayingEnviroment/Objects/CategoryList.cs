
using Atmorithm.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Atmorithm.Objects
{
    public class CategoryList
    {
        private List<string> _categories = new List<string>();

        public CategoryList()
        {
            UpdateCategoryList();
        }

        private void InitilizeCategories()
        {
            _categories.Add("Atmo");
            _categories.Add("Dschungel");
            _categories.Add("Dungeon");
            _categories.Add("Emotion");
            _categories.Add("Gebäude");
            _categories.Add("Insel");
            _categories.Add("Intro");
            _categories.Add("Kampf");
            _categories.Add("Outro");
            _categories.Add("Reise");
            _categories.Add("Stadt");
            _categories.Add("Sumpf");
            _categories.Add("Tempel");
            _categories.Add("Taverne");
            _categories.Add("Wald");
            _categories.Add("Sonstiges");
            foreach (var category in _categories)
            {
                XMLHelper.AddCategory(category);
            }
        }

        private void UpdateCategoryList()
        {
            _categories = XMLHelper.ReadCategoryList();

            if (_categories.Count < 1)
                InitilizeCategories();
        }

        public List<string> GetAllCategories()
        {
            return _categories.OrderBy(x => x).ToList();
        }

        public string GetCategory(string name)
        {
            foreach (var category in this.GetAllCategories())
            {
                Regex r = new Regex("(.*?) - ", RegexOptions.IgnoreCase);
                string namePrefix = name.Split('-').FirstOrDefault();
                if (namePrefix.Trim().ToLower().Contains(category.ToLower()))
                    return category;
            }
            return "Sonstiges";
        }

        public bool CategoryExists(string categoryToCheck)
        {
            return _categories.Where(c => c.Equals(categoryToCheck)).FirstOrDefault() != null;
        }

        public void AddCategory(string categoryToAdd)
        {
            if (_categories.Where(c => c == categoryToAdd).FirstOrDefault() != null)
                return;

            _categories.Add(categoryToAdd);
            XMLHelper.AddCategory(categoryToAdd);
        }

        public void DeleteCategory(string categoryToDelete)
        {
            _categories.Remove(categoryToDelete);
            var filteredTrackList = Program.TrackList.GetTrackList().Where(t => t.Category == categoryToDelete).ToList();
            foreach (var track in filteredTrackList)
            {
                track.Category = "Sonstiges";
                Program.TrackList.UpdateTrack(track);
            }

            var filteredPictureList = Program.PictureList.GetPictureList().Where(p => p.Category == categoryToDelete).ToList();
            foreach (var picture in filteredPictureList)
            {
                picture.Category = "Sonstiges";
                Program.PictureList.UpdatePicture(picture);
            }

            XMLHelper.DeleteCategory(categoryToDelete);
        }
    }
}
