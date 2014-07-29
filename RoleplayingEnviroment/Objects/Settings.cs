using Atmorithm.Helper;

namespace Atmorithm.Objects
{
    public class Settings
    {
        public void ReadSettings()
        {
            _databaseVersion = XMLHelper.ReadSettingsDatabaseVersion();
            _slideShowTickRate = XMLHelper.ReadSettingsTickRate();
            _fadingIsActive = XMLHelper.ReadSettingsFadingIsActive();
            _fadingDuration = XMLHelper.ReadSettingsFadingDuration();
        }

        private int _slideShowTickRate;
        public int SlideShowTickRate
        {
            get { return _slideShowTickRate; }
            set
            {
                if (_slideShowTickRate != value)
                {
                    _slideShowTickRate = value;
                    XMLHelper.UpdateSettingsTickRate(value);
                }
            }
        }

        private int _databaseVersion;
        public int DatabaseVersion
        {
            get { return _databaseVersion; }
            set
            {
                if (_databaseVersion != value)
                {
                    _databaseVersion = value;
                    XMLHelper.UpdateSettingsDatabaseVersion(value);
                }
            }
        }

        private bool _fadingIsActive;
        public bool FadingIsActive
        {
            get { return _fadingIsActive; }
            set
            {
                if (_fadingIsActive != value)
                {
                    _fadingIsActive = value;
                    XMLHelper.UpdateSettingsFadingIsActive(value);
                }
            }
        }

        private int _fadingDuration;
        public int FadingDuration
        {
            get { return _fadingDuration; }
            set
            {
                if (_fadingDuration != value)
                {
                    _fadingDuration = value;
                    XMLHelper.UpdateSettingsFadingDuration(value);
                }
            }
        }

        public int FadingDurationHalf
        {
            get { return FadingDuration / 2; }
        }

        public string DatabaseVersionString
        {
            get { return string.Format("Datenbankversion: 1.{0}", _databaseVersion); }
        }
    }
}
