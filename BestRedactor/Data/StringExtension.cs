using System;
using System.IO;

namespace BestRedactor.Data
{
    public static class StringExtension
    {
        public static bool DirectoryСheck(this string path)
        {
            return Directory.Exists(path);
        }

        public static void DirectoryCreature(this string path,bool delete = false)
        {
            if (DirectoryСheck(path) && delete)
            {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }
            if (!DirectoryСheck(path))
                Directory.CreateDirectory(path);
        }

        public static void PathNotNull(this string path)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path), @"Путь должен быть");
        }
    }
}