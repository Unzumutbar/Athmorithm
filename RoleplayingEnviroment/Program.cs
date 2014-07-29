using Atmorithm.Forms;
using Atmorithm.Helper;
using Atmorithm.Objects;
using System;
using System.IO;
using System.Windows.Forms;

namespace Atmorithm
{
    static class Program
    {
        public static int CurrentDataBaseVersion = 2;
        public static string AppDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string MusicDirectory = AppDirectory + @"\Musik\";
        public static string PictureDirectory = AppDirectory + @"\Bilder\";
        public static string DatabaseXmlFile = "Atmorithmus - Datenbank.xml";
        public static CategoryList Categories;
        public static TrackList TrackList;
        public static PictureList PictureList;
        public static TrackPicturesList TrackPicturesList;
        public static Settings Settings;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(DatabaseXmlFile))
                XMLHelper.WriteEmptyDatabase();

            Bootstrapper.InitilizeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayer());
        }
    }
}
