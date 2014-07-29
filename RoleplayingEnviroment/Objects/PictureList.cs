using Atmorithm.Helper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Atmorithm.Objects
{
    public class PictureList
    {
        private List<Picture> _pictures = new List<Picture>();

        public PictureList()
        {
            if (!Directory.Exists(Program.PictureDirectory))
                Directory.CreateDirectory(Program.PictureDirectory);

            UpdatePictureList();
        }

        private void UpdatePictureList()
        {
            var oldPictureList = XMLHelper.ReadPictureList();
            var newPictureList = FileHelper.GetPictureListFromFiles();

            foreach (var picture in newPictureList)
            {
                if (oldPictureList.Any(x => x.Name.ToLower() == picture.Name.ToLower()) == false)
                    XMLHelper.AddPicture(picture);
            }

            foreach (var picture in oldPictureList)
            {
                if (newPictureList.Any(x => x.Name.ToLower() == picture.Name.ToLower()) == false)
                {
                    XMLHelper.DeletePicture(picture);
                    Program.TrackPicturesList.DeleteAssociationsByPicture(picture);
                }
            }

            _pictures = XMLHelper.ReadPictureList().OrderBy(t => t.Name).ToList();
        }

        public List<Picture> GetPictureList()
        {
            return _pictures;
        }

        public void AddPictureToList(Picture pictureToAdd)
        {
            if (_pictures.Where(p => p.Name == pictureToAdd.Name).FirstOrDefault() != null)
                return;

            _pictures.Add(pictureToAdd);
            XMLHelper.AddPicture(pictureToAdd);
        }

        public void UpdatePicture(Picture pictureToUpdate)
        {
            var index = _pictures.FindIndex(p => p.Name == pictureToUpdate.Name);
            _pictures[index] = pictureToUpdate;
            XMLHelper.UpdatePicture(pictureToUpdate);
        }

        public void DeletePicture(Picture pictureToDelete)
        {
            _pictures.Remove(pictureToDelete);

            Program.TrackPicturesList.DeleteAssociationsByPicture(pictureToDelete);
            XMLHelper.DeletePicture(pictureToDelete);
            FileHelper.DeletePicture(pictureToDelete);
        }

        public void ReassignCategories()
        {
            foreach (var picture in _pictures)
            {
                string newCategory = Program.Categories.GetCategory(picture.Name);
                if (!newCategory.Equals("Sonstiges") && !newCategory.Equals(picture.Category))
                {
                    picture.Category = newCategory;
                    XMLHelper.UpdatePicture(picture);
                }
            }
        }

        public void ReassignCategories(string categoryToAssign)
        {
            foreach (var picture in _pictures)
            {
                string newCategory = Program.Categories.GetCategory(picture.Name);
                if (newCategory.Equals(categoryToAssign))
                {
                    picture.Category = newCategory;
                    XMLHelper.UpdatePicture(picture);
                }
            }
        }
    }
}
