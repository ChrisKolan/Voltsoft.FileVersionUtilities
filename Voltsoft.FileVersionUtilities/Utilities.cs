using System.Diagnostics;

namespace Voltsoft.FileVersionUtilities
{
    public static class Utilities
    {
        public static FileVersionInfo GetFileVersionInfo(string pathToFile)
        {
            FileVersionInfo fileVersionInfo;

            try
            {
                fileVersionInfo = FileVersionInfo.GetVersionInfo(pathToFile);
            }
            catch (System.IO.FileNotFoundException)
            {
                fileVersionInfo = null;
            }
            return fileVersionInfo;
        }

        public static string GetFileVersion(string pathToFile)
        {
            var fileVersionInfo = GetFileVersionInfo(pathToFile);

            if (fileVersionInfo == null)
                return null;

            return fileVersionInfo.FileVersion;
        }
    }
}
