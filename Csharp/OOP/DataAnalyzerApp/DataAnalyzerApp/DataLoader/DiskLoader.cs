using System;
using System.Collections.Generic;
using System.IO;

namespace DataAnalyzerApp.DataLoader
{
    class DiskLoader : Loader
    {
        private const string PATH = @"data.txt";

        public string[] load()
        {
            if (File.Exists(PATH))
            {
                string[] datalines = File.ReadAllLines(PATH);
                return datalines;
            }
            return null;
        }
    }
}
