
namespace Atmorithm.Helper
{
    public static class DatabaseHelper
    {
        public static void UpdateDatabase(int databaseVersion)
        {
            switch (databaseVersion)
            {
                case 0: goto case 1;

                case 1: XMLHelper.UpdateV2();
                    break;
            }
        }
    }
}
