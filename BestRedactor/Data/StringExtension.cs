using System.IO;

namespace BestRedactor.Data
{
    public static class StringExtension
    {
        public static bool DirectoryСheck(this string path)
        {
            return Directory.Exists(path);
        }

        public static void DirectoryCreature(this string path)
        {
            if (!DirectoryСheck(path))
                Directory.CreateDirectory(path);
        }
    }
}