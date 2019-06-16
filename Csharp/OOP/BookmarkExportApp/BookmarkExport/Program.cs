using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookmarkExport
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageBookmarks managebook = new ManageBookmarks();
            managebook.AddBookmark("Gmail", "https://mail.google.com/mail/?tab=rm&ogbl");
            managebook.AddBookmark("StackOverFlow", "https://stackoverflow.com/questions/32500099/how-to-print-double-quotes-in-c-sharp-console-application");

            //managebook.Export();
            BookmarksExport export = new BookmarksExport();
            export.ExportBookmark(managebook.BookmarkList);
            Console.WriteLine("Bookmarks exported sucessfully");
        }
    }
}
