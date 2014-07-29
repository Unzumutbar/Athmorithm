using Atmorithm.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
namespace Atmorithm.Helper
{
    public static class XMLHelper
    {
        public static void WriteEmptyDatabase()
        {
            if (File.Exists(Program.DatabaseXmlFile))
                File.Delete(Program.DatabaseXmlFile);

            using (XmlWriter writer = XmlWriter.Create(Program.DatabaseXmlFile))
            {
                writer.WriteStartElement("AtmorithmDatabase");

                writer.WriteStartElement("Settings");
                writer.WriteEndElement();

                writer.WriteStartElement("Categories");
                writer.WriteEndElement();

                writer.WriteStartElement("Tracks");
                writer.WriteEndElement();

                writer.WriteStartElement("Pictures");
                writer.WriteEndElement();

                writer.WriteStartElement("TrackPicturesAssociation");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.Flush();
            }
        }


        public static int ReadSettingsTickRate()
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);
            try
            {
                string SlideShowTickRateAsString = (from _settings in doc.Root.Elements("Settings")
                                                    select _settings.Element("SlideShowTickRate").Value).FirstOrDefault();
                int Interval;
                if (Int32.TryParse(SlideShowTickRateAsString, out Interval))
                    return Interval;
                else
                    return 60000;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("SlideShowTickRate", 60000)
                );
                doc.Save(Program.DatabaseXmlFile);
                return 60000;
            }
        }

        public static void UpdateSettingsTickRate(int Interval)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            XElement root = doc.Root;

            var target = doc.Root.Element("Settings");
            target.Element("SlideShowTickRate").Value = Interval.ToString();

            doc.Save(Program.DatabaseXmlFile);
        }

        public static int ReadSettingsDatabaseVersion()
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);
            try
            {
                string VersionAsString = (from _settings in doc.Root.Elements("Settings")
                                          select _settings.Element("DatabaseVersion").Value).FirstOrDefault();
                int Version;
                if (Int32.TryParse(VersionAsString, out Version))
                    return Version;
                else
                    return Program.CurrentDataBaseVersion;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("DatabaseVersion", Program.CurrentDataBaseVersion)
                );
                doc.Save(Program.DatabaseXmlFile);
                return Program.CurrentDataBaseVersion;
            }
        }

        public static void UpdateSettingsDatabaseVersion(int Version)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            XElement root = doc.Root;

            var target = doc.Root.Element("Settings");
            target.Element("DatabaseVersion").Value = Version.ToString();

            doc.Save(Program.DatabaseXmlFile);
        }

        public static bool ReadSettingsFadingIsActive()
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);
            try
            {
                string FadingIsActiveAsString = (from _settings in doc.Root.Elements("Settings")
                                                 select _settings.Element("FadingIsActive").Value).FirstOrDefault();
                bool IsActive;
                if (bool.TryParse(FadingIsActiveAsString, out IsActive))
                    return IsActive;
                else
                    return true;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("FadingIsActive", true.ToString())
                );
                doc.Save(Program.DatabaseXmlFile);
                return true;
            }
        }

        public static void UpdateSettingsFadingIsActive(bool IsFadingActive)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            XElement root = doc.Root;

            var target = doc.Root.Element("Settings");
            target.Element("FadingIsActive").Value = IsFadingActive.ToString();

            doc.Save(Program.DatabaseXmlFile);
        }

        public static int ReadSettingsFadingDuration()
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);
            try
            {
                string FadingDurationAsString = (from _settings in doc.Root.Elements("Settings")
                                                 select _settings.Element("FadingDuration").Value).FirstOrDefault();
                int Duration;
                if (Int32.TryParse(FadingDurationAsString, out Duration))
                    return Duration;
                else
                    return 4000;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("FadingDuration", 4000)
                );
                doc.Save(Program.DatabaseXmlFile);
                return 4000;
            }
        }

        public static void UpdateSettingsFadingDuration(int Duration)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            XElement root = doc.Root;

            var target = doc.Root.Element("Settings");
            target.Element("FadingDuration").Value = Duration.ToString();

            doc.Save(Program.DatabaseXmlFile);
        }


        public static List<Track> ReadTrackList()
        {
            XDocument xdoc = XDocument.Load(Program.DatabaseXmlFile);
            return (from _track in xdoc.Root.Element("Tracks").Elements("Track")
                    select new Track
                    {
                        Name = _track.Element("Name").Value,
                        FileName = _track.Element("FileName").Value,
                        Category = _track.Element("Category").Value
                    }).ToList();
        }

        public static void AddTrack(Track trackToAdd)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Tracks").Add(
                 new XElement("Track",
                        new XElement("Name", trackToAdd.Name),
                        new XElement("FileName", trackToAdd.FileName),
                        new XElement("Category", trackToAdd.Category)
                        )
                 );

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void DeleteTrack(Track trackToDelete)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Tracks").Elements("Track").Where(e => e.Element("Name").Value.Equals(trackToDelete.Name)).Select(e => e).Single().Remove();

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void UpdateTrack(Track trackToUpdate)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            XElement root = doc.Root;

            var target = doc.Root.Element("Tracks").Elements("Track").Where(e => e.Element("Name").Value.Equals(trackToUpdate.Name)).Single();
            target.Element("Category").Value = trackToUpdate.Category;

            doc.Save(Program.DatabaseXmlFile);
        }


        public static List<Picture> ReadPictureList()
        {
            XDocument xdoc = XDocument.Load(Program.DatabaseXmlFile);
            return (from _picture in xdoc.Root.Element("Pictures").Elements("Picture")
                    select new Picture
                    {
                        Name = _picture.Element("Name").Value,
                        FileName = _picture.Element("FileName").Value,
                        Category = _picture.Element("Category").Value,
                        AllowRandomSelect = _picture.Element("AllowRandomSelect").Value.ToLower() == "true"
                    }).ToList();
        }

        public static void AddPicture(Picture pictureToAdd)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Pictures").Add(
                 new XElement("Picture",
                        new XElement("Name", pictureToAdd.Name),
                        new XElement("FileName", pictureToAdd.FileName),
                        new XElement("Category", pictureToAdd.Category),
                        new XElement("AllowRandomSelect", pictureToAdd.AllowRandomSelect.ToString())
                        )
                 );

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void DeletePicture(Picture pictureToDelete)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Pictures").Elements("Picture").Where(e => e.Element("Name").Value.Equals(pictureToDelete.Name)).Select(e => e).Single().Remove();

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void UpdatePicture(Picture pictureToUpdate)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            XElement root = doc.Root;

            var target = doc.Root.Element("Pictures").Elements("Picture").Where(e => e.Element("Name").Value.Equals(pictureToUpdate.Name)).Single();
            target.Element("Category").Value = pictureToUpdate.Category;
            target.Element("AllowRandomSelect").Value = pictureToUpdate.AllowRandomSelect.ToString();

            doc.Save(Program.DatabaseXmlFile);
        }


        public static List<string> ReadCategoryList()
        {
            XDocument xdoc = XDocument.Load(Program.DatabaseXmlFile);
            return (from _category in xdoc.Root.Element("Categories").Elements("Category")
                    select _category.Element("Name").Value).ToList();
        }

        public static void AddCategory(string categoryToAdd)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Categories").Add(
                 new XElement("Category",
                        new XElement("Name", categoryToAdd)
                        )
                 );

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void DeleteCategory(string categoryToDelete)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Categories").Elements("Category").Where(e => e.Element("Name").Value.Equals(categoryToDelete)).Select(e => e).Single().Remove();

            doc.Save(Program.DatabaseXmlFile);
        }


        public static List<TrackPictures> ReadTrackPictureAssociationList()
        {
            XDocument xdoc = XDocument.Load(Program.DatabaseXmlFile);
            return (from _relationship in xdoc.Root.Element("TrackPicturesAssociation").Elements("TrackPictures")
                    select new TrackPictures
                    {
                        TrackName = _relationship.Element("TrackName").Value,
                        PictureFileName = _relationship.Element("PictureFileName").Value,
                    }).ToList();
        }

        public static void AddTrackPictureAssociation(TrackPictures relationshipToAdd)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("TrackPicturesAssociation").Add(
                 new XElement("TrackPictures",
                        new XElement("TrackName", relationshipToAdd.TrackName),
                        new XElement("PictureFileName", relationshipToAdd.PictureFileName)
                        )
                 );

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void DeleteTrackPictureAssociation(TrackPictures relationshipToDelete)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("TrackPicturesAssociation").Elements("TrackPictures").Where(e => e.Element("TrackName").Value.Equals(relationshipToDelete.TrackName) && e.Element("PictureFileName").Value.Equals(relationshipToDelete.PictureFileName)).Select(e => e).Single().Remove();

            doc.Save(Program.DatabaseXmlFile);
        }

        #region Updatespezifische Funktionen
        public static void UpdateV2()
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Add(new XElement("TrackPicturesAssociation"));

            doc.Save(Program.DatabaseXmlFile);
        }
        #endregion
    }
}
