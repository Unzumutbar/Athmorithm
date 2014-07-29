using Atmorithm.Helper;
using Atmorithm.Objects;

namespace Atmorithm
{
    public static class Bootstrapper
    {
        public static void InitilizeDatabase()
        {
            Program.Settings = new Settings();
            Program.Settings.ReadSettings();
            if (Program.Settings.DatabaseVersion < Program.CurrentDataBaseVersion)
            {
                DatabaseHelper.UpdateDatabase(Program.Settings.DatabaseVersion);
                Program.Settings.DatabaseVersion = Program.CurrentDataBaseVersion;
            }

            Program.Categories = new CategoryList();
            Program.TrackList = new TrackList();
            Program.PictureList = new PictureList();
            Program.TrackPicturesList = new TrackPicturesList();
        }
    }
}
