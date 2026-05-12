using System;
using System.Collections.Generic;
using System.Text;

namespace lguamanS5.utilities
{
    public class FileAccessHelper
    {
        public static string getFolderPath(string Filename) 
        {
            return System.IO.Path.Combine(FileSystem.AppDataDirectory, Filename);


        }
    }
}
