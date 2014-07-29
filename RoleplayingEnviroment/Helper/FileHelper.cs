using Atmorithm.Objects;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Atmorithm.Helper
{
    public static class FileHelper
    {
        public static List<Track> GetTrackListFromFiles()
        {
            var trackList = new List<Track>();
            foreach (var track in Directory.GetFiles(Program.MusicDirectory))
            {
                if (track.Contains(".mp3") || track.Contains(".wav"))
                {
                    var newTrack = GetTrackFromFile(track);
                    trackList.Add(newTrack);
                }
            }
            return trackList;
        }

        public static List<Picture> GetPictureListFromFiles()
        {
            var pictureList = new List<Picture>();
            foreach (var picture in Directory.GetFiles(Program.PictureDirectory))
            {
                if (picture.Contains(".jpg") || picture.Contains(".jpeg") || picture.Contains(".gif") || picture.Contains(".png"))
                {
                    var newPicture = GetPictureFromFile(picture);
                    pictureList.Add(newPicture);
                }
            }
            return pictureList;
        }

        public static void CopyImageToPictureDirectory(string fileToCopy)
        {
            var fileName = Path.GetFileName(fileToCopy);
            if (File.Exists(Program.PictureDirectory + fileName))
                return;

            File.Copy(fileToCopy, Program.PictureDirectory + fileName, false);
        }

        public static Picture GetPictureFromFile(string fileToConvert)
        {
            var newPicture = new Picture();
            newPicture.Name = Path.GetFileNameWithoutExtension(fileToConvert);
            newPicture.FileName = Path.GetFileName(fileToConvert);
            newPicture.Category = Program.Categories.GetCategory(newPicture.Name);
            newPicture.AllowRandomSelect = !newPicture.Name.Contains("!");
            newPicture.IsNew = !File.Exists(Program.PictureDirectory + newPicture.FileName);
            newPicture.FullPath = fileToConvert;

            return newPicture;
        }

        public static Image GetPictureAsImage(string fileToRead)
        {
            if (!File.Exists(fileToRead))
                return new Bitmap(100, 100);

            if (Path.GetExtension(fileToRead) == ".gif")
                return Image.FromFile(fileToRead);

            using (FileStream stream = new FileStream(fileToRead, FileMode.Open, FileAccess.Read))
                return Image.FromStream(stream);
        }

        public static void CopyTrackToMusicDirectory(string fileToCopy)
        {
            var fileName = Path.GetFileName(fileToCopy);
            if (File.Exists(Program.MusicDirectory + fileName))
                return;

            File.Copy(fileToCopy, Program.MusicDirectory + fileName, false);
        }

        public static Track GetTrackFromFile(string fileToConvert)
        {
            var trackToGet = new Track();
            trackToGet.Name = Path.GetFileNameWithoutExtension(fileToConvert);
            trackToGet.FileName = Path.GetFileName(fileToConvert);
            trackToGet.Category = Program.Categories.GetCategory(trackToGet.Name);
            trackToGet.IsNew = !File.Exists(Program.MusicDirectory + trackToGet.FileName);
            trackToGet.FullPath = fileToConvert;

            return trackToGet;
        }

        public static void DeleteTrack(Track trackToDelete)
        {
            try
            {
                string fileToDelete = Program.MusicDirectory + trackToDelete.FileName;
                Thread thread = new Thread(delegate() { DeleteFile(fileToDelete); });
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Datei:" + Program.MusicDirectory + trackToDelete + " konnte nicht gelöscht werden", "Fehler");
            }
        }

        public static void DeletePicture(Picture pictureToDelete)
        {
            try
            {
                string fileStringToDelete = Program.PictureDirectory + pictureToDelete.FileName;
                Thread thread = new Thread(delegate() { DeleteFile(fileStringToDelete); });
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Datei:" + Program.PictureDirectory + pictureToDelete + " konnte nicht gelöscht werden", "Fehler");
            }
        }

        private static void DeleteFile(string fileStringToDelete)
        {
            FileInfo fileToDelete = new FileInfo(fileStringToDelete);
            if (fileToDelete.Exists)
            {
                while (IsFileLocked(fileToDelete))
                    Thread.Sleep(1000);
                fileToDelete.Delete();
            }
        }

        public static bool TrackExists(Track trackToCheck)
        {
            return File.Exists(Program.MusicDirectory + trackToCheck.FileName);
        }

        public static bool PictureExists(Picture pictureToCheck)
        {
            return File.Exists(Program.PictureDirectory + pictureToCheck.FileName);
        }

        private static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}
