using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace DirectoryInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] folders= Directory.GetDirectories(@"C:\Windows\System32");
            string[] foldernames = new string[folders.Length];
            int i = 0;
            foreach (string folder in folders) {
                foldernames[i] =Path.GetFileName(folder);
                i++;
                    }
            IEnumerable<string> enumberablefolders = foldernames.Where((n) =>n.Length>=5).Take(5);
            foreach (string foldername in enumberablefolders) {
                Console.WriteLine(foldername);
            }
        }
    }
}
