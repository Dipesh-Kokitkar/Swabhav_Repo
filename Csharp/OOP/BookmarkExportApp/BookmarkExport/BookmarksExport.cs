using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookmarkExport
{
    class BookmarksExport
    {
        public void ExportBookmark(List<Bookmark> list) {
            StringBuilder htmllines=new StringBuilder();
            htmllines.Append("\n<html>\n<title>Bookmark</title>\n<body>");

            foreach (Bookmark bookmark in list) {
                htmllines.Append("\n<a href=\""+bookmark.Url+"\">"+bookmark.Name+"</a>");
            }
            htmllines.Append("\n</body>\n</html>");
            File.AppendAllText("bookmark.html",htmllines.ToString());
        }
    }
}
