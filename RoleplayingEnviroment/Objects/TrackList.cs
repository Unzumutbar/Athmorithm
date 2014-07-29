using Atmorithm.Helper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Atmorithm.Objects
{
    public class TrackList
    {
        private List<Track> _tracks = new List<Track>();

        public TrackList()
        {
            if (!Directory.Exists(Program.MusicDirectory))
                Directory.CreateDirectory(Program.MusicDirectory);

            UpdateTrackList();
        }

        private void UpdateTrackList()
        {
            var oldTrackList = XMLHelper.ReadTrackList();
            var newTrackList = FileHelper.GetTrackListFromFiles();

            foreach (var track in newTrackList)
            {
                if (oldTrackList.Any(x => x.Name.ToLower() == track.Name.ToLower()) == false)
                    XMLHelper.AddTrack(track);
            }

            foreach (var track in oldTrackList)
            {
                if (newTrackList.Any(x => x.Name.ToLower() == track.Name.ToLower()) == false)
                {
                    XMLHelper.DeleteTrack(track);
                    Program.TrackPicturesList.DeleteAssociationsByTrack(track);
                }
            }

            _tracks = XMLHelper.ReadTrackList().OrderBy(t => t.Name).ToList();
        }

        public List<Track> GetTrackList()
        {
            return _tracks;
        }

        public void AddTrackToList(Track trackToAdd)
        {
            if (_tracks.Where(t => t.Name == trackToAdd.Name).FirstOrDefault() != null)
                return;

            _tracks.Add(trackToAdd);
            XMLHelper.AddTrack(trackToAdd);
        }

        public void UpdateTrack(Track trackToUpdate)
        {
            var index = _tracks.FindIndex(t => t.Name == trackToUpdate.Name);
            _tracks[index] = trackToUpdate;
            XMLHelper.UpdateTrack(trackToUpdate);
        }

        public void DeleteTrack(Track trackToDelete)
        {
            _tracks.Remove(trackToDelete);

            Program.TrackPicturesList.DeleteAssociationsByTrack(trackToDelete);
            XMLHelper.DeleteTrack(trackToDelete);
            FileHelper.DeleteTrack(trackToDelete);
        }

        public void ReassignCategories()
        {
            foreach (var track in _tracks)
            {
                string newCategory = Program.Categories.GetCategory(track.Name);
                if (!newCategory.Equals("Sonstiges") && !newCategory.Equals(track.Category))
                {
                    track.Category = newCategory;
                    XMLHelper.UpdateTrack(track);
                }
            }
        }

        public void ReassignCategories(string categoryToAssign)
        {
            foreach (var track in _tracks)
            {
                string newCategory = Program.Categories.GetCategory(track.Name);
                if (newCategory.Equals(categoryToAssign))
                {
                    track.Category = newCategory;
                    XMLHelper.UpdateTrack(track);
                }
            }
        }
    }
}
