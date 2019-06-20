using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompositeApp;

namespace CompositeMainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder moives = new Folder("Moives");
            Folder hindi = new Folder("Hindi");
            Folder english = new Folder("English");
            Folder comedy = new Folder("Comedy");

            File abc = new File("ABC", "MP4", 100);
            File xyz = new File("XYZ", "AVI", 200);
            File dhamal = new File("Dhamal", "MP4", 1000);
            File endgame = new File("Endgame", "MP4", 2000);
            File lmn = new File("LMN", "AVI", 500);

            comedy.AddItems(lmn);
            english.AddItems(endgame);
            hindi.AddItems(dhamal);

            moives.AddItems(abc);
            moives.AddItems(xyz);
            moives.AddItems(hindi);
            moives.AddItems(english);
            moives.AddItems(comedy);
            moives.AddItems(new File("Jhon", "MP4", 5000));

            moives.Display(0);

        }


    }
}

