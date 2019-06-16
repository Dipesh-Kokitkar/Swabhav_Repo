using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookmarkExport
{
    class ManageBookmarks
    {
        private BookmarksExport _bookmarkexport;
        private List<Bookmark> _bookmarks;

        public ManageBookmarks() {
            _bookmarkexport = new BookmarksExport();
            _bookmarks = new List<Bookmark>();
        }

        public void AddBookmark(string name,string url) {
            _bookmarks.Add(new Bookmark(name,url));
        }

        public List<Bookmark> BookmarkList
        {
            get { return _bookmarks; }
        }

        /*public void Export() {
            _bookmarkexport.ExportBookmark(BookmarkList);
        }*/
       
    }
}
