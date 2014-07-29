using Atmorithm.Helper;
using System.Collections.Generic;
using System.Linq;

namespace Atmorithm.Objects
{
    public class TrackPicturesList
    {
        private List<TrackPictures> _trackToPictureList = new List<TrackPictures>();


        public TrackPicturesList()
        {
            _trackToPictureList = XMLHelper.ReadTrackPictureAssociationList();
        }

        public List<TrackPictures> GetTrackToPictureList()
        {
            return _trackToPictureList;
        }

        public void AddNewAssociation(TrackPictures associationToAdd)
        {
            if (_trackToPictureList.Where(tp => tp.TrackName == associationToAdd.TrackName && tp.PictureFileName == associationToAdd.PictureFileName).FirstOrDefault() != null)
                return;

            _trackToPictureList.Add(associationToAdd);
            XMLHelper.AddTrackPictureAssociation(associationToAdd);
        }

        public void DeleteAssociation(TrackPictures relationshipToDelete)
        {
            _trackToPictureList.Remove(relationshipToDelete);
            XMLHelper.DeleteTrackPictureAssociation(relationshipToDelete);
        }

        public void DeleteAssociationsByTrack(Track track)
        {
            var associations = _trackToPictureList.Where(tp => tp.TrackName == track.Name).ToList();
            foreach (var association in associations)
            {
                DeleteAssociation(association);
            }
        }

        public void DeleteAssociationsByPicture(Picture picture)
        {
            var associations = _trackToPictureList.Where(tp => tp.PictureFileName == picture.FileName).ToList();
            foreach (var association in associations)
            {
                DeleteAssociation(association);
            }
        }

        public List<Picture> GetAssociatedPicturesByTrack(Track trackToAssociate)
        {
            var associations = _trackToPictureList.Where(tp => tp.TrackName == trackToAssociate.Name);
            var pictureList = new List<Picture>();
            foreach (var association in associations)
            {
                pictureList.Add(Program.PictureList.GetPictureList().Where(p => p.FileName == association.PictureFileName).FirstOrDefault());
            }
            return pictureList;
        }

    }
}
